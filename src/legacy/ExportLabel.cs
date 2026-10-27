// 文件: ExportLabel.cs
// 功能: 导出蓝色/绿色工具标注信息和图像到 sqlite3 数据库（exe 版）
// 修改点
// 1. 去掉 Microsoft.Data.Sqlite 的 using
// 2. 用 SqliteExeHelper 代替 SqliteConnection/SqliteTransaction/SqliteCommand
// 3. 参数化 SQL 改为字符串拼接，并做简单转义

using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.IO;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Xml.Linq;
using Microsoft.Win32;

// JSON
using Newtonsoft.Json;

// 图像处理
using ImageMagick;

// 运行时绑定
using Microsoft.CSharp;

// Vidi
using ViDi.NET.Interfaces.training;
using ViDi2.Common.Utilities;
using ViDi2.Data;
using ViDi2.Properties;
using ViDi2.Runtime;
using ViDi2.Training;
using ViDi2.Local;
using ViDi2;

// 屏蔽警告
#pragma warning disable CS0618

namespace JusNet472Template
{
    public partial class ExportDatabaseSummaryTool
    {
        /* ===============================================================
         * 1. 导出按钮：选择文件夹 → 导出 png+json 并写入 SQLite
         * =============================================================== */
        private void BtnExportDatabase_Click(object sender, RoutedEventArgs e)
        {
            if (!(CbWorkspace.SelectedItem is NodeHolder wh) ||
                !(CbStream.SelectedItem is NodeHolder sh) ||
                !(CbTool.SelectedItem is NodeHolder th))
            {
                MessageBox.Show("请先依次选择 Workspace → Stream → Tool！");
                return;
            }

            var tool = _control.Workspaces[wh.Name]
                               .Streams[sh.Name]
                               .Tools[th.Name];

            if (tool is ViDi2.Training.IBlueTool bTool)
                ExportToolToDatabase(bTool, "Blue");
            else if (tool is ViDi2.Training.IGreenTool gTool)
                ExportToolToDatabase(gTool, "Green");
            else
            {
                MessageBox.Show("仅支持 Blue/Green 工具！");
                return;
            }
        }

        #region 导出逻辑
        private void ExportToolToDatabase(object toolObj, string toolType)
        {
            if (!(toolObj is ViDi2.Training.ITool tool))
            {
                MessageBox.Show("仅支持 ViDi Tool 类型！");
                return;
            }

            var blue  = tool as ViDi2.Training.IBlueTool;
            var green = tool as ViDi2.Training.IGreenTool;
            if (blue == null && green == null)
            {
                MessageBox.Show("仅支持 Blue/Green 工具！");
                return;
            }

            string folder = SelectFolder();
            if (string.IsNullOrEmpty(folder)) return;

            try
            {
                BtnExportDatabase.IsEnabled = false;
                Status.Text = "正在导出…";
                Progress.Visibility = Visibility.Visible;
                Progress.Value = 0;

                // 1. 确保数据库和表存在
                SqliteExeHelper.EnsureTable();   // 复用原 helper 的 EnsureTable，可再建 samples 表

                // 2. 建本次需要的 samples 表（如果不存在）
                SqliteExeHelper.Execute(@"
CREATE TABLE IF NOT EXISTS samples(
    id         INTEGER PRIMARY KEY AUTOINCREMENT,
    name       TEXT NOT NULL,
    tool       TEXT NOT NULL,
    tool_type  TEXT NOT NULL,
    image      BLOB,
    json       TEXT,
    updated_at TEXT
);");

                int total = 0, idx = 0;
                if (blue != null)
                {
                    var db = blue.Database;
                    total = db.List().Count();
                    foreach (var key in db.List())
                    {
                        var frameKey = (FrameKey)key;
                        var view     = db.GetMarking(frameKey) as IBlueLabeledView;
                        if (view == null) { ++idx; continue; }

                        ExportOneSample(blue.Name,
                                        "Blue",
                                        frameKey.SampleName,
                                        view.LabeledFeatures?.Select(f => f.Name).ToArray(),
                                        ViewToPng(db, new ViewKey(frameKey, idx), frameKey),
                                        folder,
                                        ref idx,
                                        total);
                    }
                }
                else
                {
                    var db = green.Database;
                    total = db.List().Count();
                    foreach (var key in db.List())
                    {
                        var frameKey = (FrameKey)key;
                        var view     = db.GetMarking(frameKey) as IGreenLabeledView;
                        if (view == null) { ++idx; continue; }

                        ExportOneSample(green.Name,
                                        "Green",
                                        frameKey.SampleName,
                                        view.LabeledTags?.ToArray(),
                                        ViewToPng(db, new ViewKey(frameKey, idx), frameKey),
                                        folder,
                                        ref idx,
                                        total);
                    }
                }

                MessageBox.Show($"导出完成！\n文件夹：{folder}\n数据库：jusocr.db");
            }
            catch (Exception ex)
            {
                MessageBox.Show("导出失败：\n" + ex.Message, "错误");
            }
            finally
            {
                BtnExportDatabase.IsEnabled = true;
                Progress.Visibility = Visibility.Collapsed;
                Status.Text = "";
            }
        }

        // 统一写一条样本 + 写磁盘文件
        private void ExportOneSample(string toolName,
                                     string toolType,
                                     string sampleName,
                                     string[] labels,
                                     byte[] pngBytes,
                                     string folder,
                                     ref int idx,
                                     int total)
        {
            idx++;
            var labelJson = JsonConvert.SerializeObject(labels ?? new string[0]);
            string baseName = $"{toolName}_{sampleName}";

            // 1. 写磁盘 png/json
            File.WriteAllBytes(Path.Combine(folder, baseName + ".png"), pngBytes);
            File.WriteAllText(Path.Combine(folder, baseName + ".json"),
                              JsonConvert.SerializeObject(new
                              {
                                  name        = sampleName,
                                  tool        = toolName,
                                  tool_type   = toolType,
                                  labels
                              }, Formatting.Indented));

            // 2. 写数据库（exe 模式只能拼 SQL）
            string sql =
$@"INSERT INTO samples(name,tool,tool_type,image,json,updated_at)
VALUES('{Escape(sampleName)}',
       '{Escape(toolName)}',
       '{Escape(toolType)}',
       '{Escape(Convert.ToBase64String(pngBytes))}',   // BLOB 用 base64 存
       '{Escape(labelJson)}',
       '{Escape(DateTime.Now.ToString("O"))}');";

            SqliteExeHelper.Execute(sql);

            Progress.Value = idx * 100 / total;
        }
        #endregion 导出逻辑

        #region 辅助
        // 简单防注入
        private static string Escape(string s) => s.Replace("'", "''");
        #endregion
    }
}