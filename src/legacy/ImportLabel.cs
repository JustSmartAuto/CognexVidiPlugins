// 文件: ImportLabel.cs
// 功能: 从sqlite3数据库导入蓝色工具/绿色工具标注信息和图像

// 标准库
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

// 数据库
using Microsoft.Data.Sqlite;

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
         * 2. 导入按钮：选择文件夹 → 从 SQLite 读回样本
         * =============================================================== */
        private void BtnImportDatabase_Click(object sender, RoutedEventArgs e)
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

            if (tool is ViDi2.Training.IBlueTool bt)
                ImportDatabaseToTool(bt, "Blue");
            else if (tool is ViDi2.Training.IGreenTool gt)
                ImportDatabaseToTool(gt, "Green");
            else
            {
                MessageBox.Show("仅支持 Blue/Green 工具！");
                return;
            }
        }

        #region 导入逻辑
        /* -----------------------------------------------------------
         * 公共入口：只做“覆盖确认”+“事务迭代”，具体 Blue/Green 分出去
         * ----------------------------------------------------------- */
        private void ImportDatabaseToTool(object toolObj, string toolType)
        {
            // 1. 转公共父接口
            if (!(toolObj is ViDi2.Training.ITool tool))
            {
                MessageBox.Show("仅支持 ViDi Tool 类型！");
                return;
            }

            // 2. 再确认子类型
            var blue  = tool as ViDi2.Training.IBlueTool;
            var green = tool as ViDi2.Training.IGreenTool;
            if (blue == null && green == null)
            {
                MessageBox.Show("仅支持 Blue/Green 工具！");
                return;
            }

            string dbPath = GetDbPath(tool.Name);
            if (!File.Exists(dbPath))
            {
                MessageBox.Show("数据库不存在，请先导出！\n" + dbPath);
                return;
            }

            var mode = MessageBox.Show("是否“覆盖”已有样本？\n选 No 则仅增量更新。", "导入模式",
                                       MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            if (mode == MessageBoxResult.Cancel) return;
            bool overwrite = mode == MessageBoxResult.Yes;

            try
            {
                BtnImportDatabase.IsEnabled = false;
                Status.Text = "正在导入…";
                Progress.Visibility = Visibility.Visible;
                Progress.Value = 0;

                using (var conn = OpenDb(tool.Name))
                {
                    /* ---------- 1. 统计 ---------- */
                    string cntSql = "SELECT COUNT(*) FROM samples WHERE tool=$tool";
                    using (var cmd = new SqliteCommand(cntSql, conn))
                    {
                        cmd.Parameters.AddWithValue("$tool", tool.Name);
                        int total = Convert.ToInt32(cmd.ExecuteScalar());
                        if (total == 0) { MessageBox.Show("数据库中无样本！"); return; }

                        /* ---------- 2. 按类型分派 ---------- */
                        if (blue != null)
                        {   
                            // ImportBlueTool(blue, overwrite, conn, total);
                        }
                        else
                        {
                            // ImportGreenTool(green, overwrite, conn, total);
                        }
                    }
                }

                MessageBox.Show("导入完成！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("导入失败：\n" + ex.Message, "错误");
            }
            finally
            {
                BtnImportDatabase.IsEnabled = true;
                Progress.Visibility = Visibility.Collapsed;
                Status.Text = "";
                RefreshData(); // 刷新右侧文本框
            }
        }
        #endregion 导入逻辑
        
        // #region 蓝色工具
        // /* -----------------------------------------------------------
        // * 蓝色：清空→重建→写 Features
        // * ----------------------------------------------------------- */
        // private void ImportBlueTool(ViDi2.Training.IBlueTool blue,
        //                             bool overwrite,
        //                             SqliteConnection conn,
        //                             int total, 
        //                             ViDi2.Training.IStream stream = null)
        // {
        //     /* ---------- 1. 覆盖模式先清空 ---------- */
        //     if (overwrite)
        //         blue.Database.RemoveImages("");

        //     /* ---------- 2. 预读库（更新模式用） ---------- */
        //     // 获取工具所属的流
        //     if(stream != null)
        //     {
        //         stream = blue.Stream;
        //     }

        //     var existLabels = new Dictionary<string, HashSet<string>>();
        //     if (!overwrite)
        //     {
        //         foreach (var v in blue.Database.List())
        //         {
        //             var view = blue.Database.GetMarking(v) as IBlueLabeledView;
        //             if (view == null) continue;
        //             var set = new HashSet<string>(
        //                         view.LabeledFeatures?.Select(f => f.Name).ToList() ?? new List<string>());
        //             existLabels[v.SampleName] = set;
        //         }
        //     }

        //     /* ---------- 3. 逐条导入 ---------- */
        //     string selSql = @"SELECT name,image,json FROM samples
        //                     WHERE tool=$tool ORDER BY id";
        //     using (var cmd = new SqliteCommand(selSql, conn))
        //     {
        //         cmd.Parameters.AddWithValue("$tool", blue.Name);
        //         using (var r = cmd.ExecuteReader())
        //         {
        //             int idx = 0;
        //             while (r.Read())
        //             {
        //                 string name = r.GetString(0);
        //                 byte[] png  = (byte[])r[1];
        //                 string json = r.GetString(2);
        //                 var dto = JsonConvert.DeserializeObject<ImportDto>(json);

        //                 /* 重建图像 */
        //                 ViDi2.IImage img;
        //                 using (var ms = new MemoryStream(png))
        //                     img = LibraryImage.Factory.Load(ms, ViDi2.ImageFormat.PNG);

        //                 /* 1. 新建空样本 */
        //                 var sample = stream.CreateSample();   // ← 直接去掉了 .Tool
        //                 sample.AddImage(img);

        //                 /* 2. 生成视图（大小、位姿、掩模默认即可） */
        //                 var view = sample.AddView(blue,        // ← 直接去掉了 .Tool
        //                                         default(ViDi2.Size),
        //                                         default(ViDi2.Matrix),
        //                                         null); // as IBlueView

        //                 /* 3. 合并标签（更新模式） */
        //                 if (!overwrite && existLabels.TryGetValue(name, out var oldSet))
        //                     dto.labels = dto.labels.Union(oldSet).Distinct().ToList();

        //                 /* 4. 写 Features */
        //                 foreach (var f in dto.labels)
        //                     view.AddFeature(f);               // ← 用 AddFeature 代替 Features.Add

        //                 /* 进度 */
        //                 Progress.Value = (++idx * 100 / total);
        //                 System.Windows.Threading.Dispatcher.CurrentDispatcher
        //                     .Invoke(() => { }, System.Windows.Threading.DispatcherPriority.Render);
        //             }
        //         }
        //     }
        // }
        // #endregion 蓝色工具

        // #region 绿色工具
        // /* -----------------------------------------------------------
        // * 绿色：清空→重建→写 Tags
        // * ----------------------------------------------------------- */
        // private void ImportGreenTool(ViDi2.Training.IGreenTool green,
        //                             bool overwrite,
        //                             SqliteConnection conn,
        //                             int total,
        //                             ViDi2.Training.IStream stream = null)
        // {
        //     /* ---------- 1. 覆盖模式先清空 ---------- */
        //     if (overwrite)
        //         green.Database.RemoveImages("");

        //     /* ---------- 2. 预读库（更新模式用） ---------- */
        //     var existTags = new Dictionary<string, HashSet<string>>();
        //     if (!overwrite)
        //     {
        //         foreach (var v in green.Database.List())
        //         {
        //             var view = green.Database.GetMarking((FrameKey)v) as IGreenLabeledView;
        //             if (view == null) continue;
        //             var set = new HashSet<string>(view.LabeledTags ?? Array.Empty<string>());
        //             existTags[v.SampleName] = set;
        //         }
        //     }

        //     /* ---------- 3. 逐条导入 ---------- */
        //     string selSql = @"SELECT name,image,json FROM samples
        //                     WHERE tool=$tool ORDER BY id";
        //     using (var cmd = new SqliteCommand(selSql, conn))
        //     {
        //         cmd.Parameters.AddWithValue("$tool", green.Name);
        //         using (var r = cmd.ExecuteReader())
        //         {
        //             int idx = 0;
        //             while (r.Read())
        //             {
        //                 string name = r.GetString(0);
        //                 byte[] png  = (byte[])r[1];
        //                 string json = r.GetString(2);
        //                 var dto = JsonConvert.DeserializeObject<ImportDto>(json);

        //                 /* 重建图像 */
        //                 ViDi2.IImage img;
        //                 using (var ms = new MemoryStream(png))
        //                     img = LibraryImage.Factory.Load(ms, ViDi2.ImageFormat.PNG);

        //                 /* 1. 新建空样本 */
        //                 var sample = green.Tool.CreateSample(name);
        //                 sample.AddImage(img);

        //                 /* 2. 生成视图 */
        //                 var view = sample.AddView(green.Tool,
        //                                         default(ViDi2.Size),
        //                                         null,
        //                                         null) as IGreenView;

        //                 /* 3. 合并标签（更新模式） */
        //                 if (!overwrite && existTags.TryGetValue(name, out var oldSet))
        //                     dto.labels = dto.labels.Union(oldSet).Distinct().ToList();

        //                 /* 4. 写 Tags */
        //                 foreach (var t in dto.labels)
        //                     view.Tags(t);

        //                 /* 进度 */
        //                 Progress.Value = (++idx * 100 / total);
        //                 System.Windows.Threading.Dispatcher.CurrentDispatcher
        //                     .Invoke(() => { }, System.Windows.Threading.DispatcherPriority.Render);
        //             }
        //         }
        //     }
        // }
        // #endregion 绿色工具

    }
}