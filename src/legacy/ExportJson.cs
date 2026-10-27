// 文件: ExportJson.cs
// 功能: 导出json

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

// Vidi
using ViDi.NET.Interfaces.training;
using ViDi2.Common.Utilities;
using ViDi2.Data;
using ViDi2.Properties;
using ViDi2.Runtime;
using ViDi2.Training;
using ViDi2.Local;

// 屏蔽警告
#pragma warning disable CS0618

namespace JusNet472Template
{
    public partial class ExportDatabaseSummaryTool
    {
        /* ================= 进度条辅助 ================= */
        private void SetProgress(int percent, string msg = null)
        {
            Dispatcher.Invoke(() =>
            {
                Progress.Value = percent;
                if (msg != null) Status.Text = msg;
            });
        }

        /* ================= 导出当前 Workspace ================= */
        private void BtnExportJson_Click(object sender, RoutedEventArgs e)
        {
            // 取 SelectedItem 而不是 SelectedIndex
            if (!(CbWorkspace.SelectedItem is NodeHolder holder))
            {
                MessageBox.Show(this, "请先选择一个 Workspace！", "提示",
                                MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // 再用名字去索引 IWorkspace
            var ws = _control.Workspaces[holder.Name] as ViDi2.Training.IWorkspace;

            /* ---------- 1. 先让用户选保存路径 ---------- */
            var time = DateTime.Now.ToString("yyyyMMddHHmm");
            var fileName = $"{ws.Name}_{time}.json";

            var dlg = new SaveFileDialog
            {
                Filter = "JSON 文件|*.json",
                FileName = fileName,
                DefaultExt = "json",
                InitialDirectory = Path.Combine("D:\\", "JustSmart", "AppCache", "ViDiInfo")
            };

            if (dlg.ShowDialog(this) != true) return;   // 用户点了“取消”直接退出
            var targetPath = dlg.FileName;

            /* ---------- 2. 真正开始干活 ---------- */
            try
            {
                Dispatcher.Invoke(() =>
                {
                    BtnExportJson.IsEnabled = false;
                    Progress.Visibility = Visibility.Visible;
                    Status.Text = "正在准备…";
                });

                var imgFactory = LibraryImage.Factory;
                ViDi2.IImage dummyImage;
                using (var ms = new MemoryStream())
                {
                    using (var img = new MagickImage(MagickColors.Black, 100, 100))
                    {
                        img.Depth = 8;
                        img.Format = MagickFormat.Png;
                        img.Write(ms);
                    }
                    ms.Position = 0;
                    dummyImage = imgFactory.Load(ms, ViDi2.ImageFormat.PNG);
                }

                var root = new ViDiNodeInfo { Name = ws.Name, Type = "Workspace" };

                int total = ws.Streams.Count(), done = 0;
                foreach (var st in ws.Streams)
                {
                    SetProgress(done * 100 / total, $"正在处理流 {st.Name} …");
                    var stNode = new ViDiNodeInfo { Name = st.Name, Type = "Stream" };
                    root.Children.Add(stNode);

                    foreach (var tool in st.Tools)
                    {
                        string toolType = "Unknown";
                        var tagsFeatures = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

                        try
                        {
                            var sample = tool.Process(dummyImage);
                            if (sample?.Markings != null && sample.Markings.ContainsKey(tool.Name))
                            {
                                var mk = sample.Markings[tool.Name];
                                if (mk is ViDi2.IRedMarking) toolType = "Red";
                                else if (mk is ViDi2.IGreenMarking) toolType = "Green";
                                else if (mk is ViDi2.IBlueMarking blueMk)
                                    toolType = blueMk.Views.Any(v => v.Matches?.Count > 0) ? "BlueRead" : "Blue";
                            }
                        }
                        catch { /* 留 Unknown */ }

                        switch (toolType)
                        {
                            case "BlueRead":
                            case "Blue":
                                if (tool is ViDi2.Training.IBlueTool bt)
                                    foreach (var f in bt.KnownFeatures)
                                        if (!string.IsNullOrWhiteSpace(f))
                                            tagsFeatures.Add(f);
                                break;
                            case "Green":
                                if (tool is ViDi2.Training.IGreenTool gt)
                                    foreach (var t in gt.KnownTags)
                                        if (!string.IsNullOrWhiteSpace(t))
                                            tagsFeatures.Add(t);
                                break;
                        }

                        stNode.Children.Add(new ViDiNodeInfo
                        {
                            Name = tool.Name,
                            Type = toolType,
                            TagsFeatures = new List<string>(tagsFeatures.OrderBy(t => t, StringComparer.OrdinalIgnoreCase))
                        });
                    }
                    done++;
                }

                /* ---------- 3. 写入文件 ---------- */
                Directory.CreateDirectory(Path.GetDirectoryName(targetPath));
                File.WriteAllText(targetPath, JsonConvert.SerializeObject(root, Formatting.Indented));
                MessageBox.Show(this, $"已导出到\n{targetPath}", "完成",
                                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"导出失败：\n{ex.Message}", "错误",
                                MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Dispatcher.Invoke(() =>
                {
                    BtnExportJson.IsEnabled = true;
                    Progress.Visibility = Visibility.Collapsed;
                    Status.Text = "";
                });
            }
        }

        /* ======== 新增：DTO ======== */
        public class ViDiNodeInfo
        {
            public string Name { get; set; } = "";
            public string Type { get; set; } = "";
            public List<ViDiNodeInfo> Children { get; set; } = new List<ViDiNodeInfo>();
            public List<string> TagsFeatures { get; set; } = new List<string>();
        }
    }
}