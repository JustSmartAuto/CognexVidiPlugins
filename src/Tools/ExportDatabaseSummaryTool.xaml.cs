// 文件: ExportDatabaseSummaryTool.xaml.cs
// 功能: 导出vidi图像数据库详细信息

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

// JSON处理
using Newtonsoft.Json;

// 插件接口
using ViDi2;
using ViDi2.Common;
using ViDi2.Common.Utilities;
using ViDi2.UI;
using ViDi2.Training;
using ViDi2.Training.UI;

// 屏蔽警告
#pragma warning disable CS0618

namespace JusNet472Template
{
    public partial class ExportDatabaseSummaryTool : Window
    {
        // !!!插件上下文
        public IPluginContext _ctx;
        public ViDi2.Training.IControl _control;   

        public ExportDatabaseSummaryTool(IPluginContext ctx)
        {
            InitializeComponent();
            if (ctx == null) throw new ArgumentNullException(nameof(ctx));
            _ctx = ctx;

            // IMainWindow 已经在插件上下文里给出
            var mainWin = ctx.MainWindow;
            _control = mainWin.WorkspaceBrowserViewModel.Control
                        ?? throw new InvalidOperationException("无法获取 IControl 服务");

            LoadWorkspaceList();
            RefreshData();
        }

        #region 界面级联
        public void LoadWorkspaceList()
        {
            CbWorkspace.ItemsSource = _control.Workspaces
                                             .Select(ws => new NodeHolder { Name = ws.Name })
                                             .ToList();
            if (CbWorkspace.Items.Count > 0) CbWorkspace.SelectedIndex = 0;
        }

        public void CbWorkspace_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CbStream.ItemsSource = null; CbTool.ItemsSource = null;
            if (CbWorkspace.SelectedItem is NodeHolder h)
            {
                var ws = _control.Workspaces[h.Name];
                CbStream.ItemsSource = ws.Streams
                                         .Select(s => new NodeHolder { Name = s.Name })
                                         .ToList();
                if (CbStream.Items.Count > 0) CbStream.SelectedIndex = 0;
            }
            RefreshData();
        }

        public void CbStream_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CbTool.ItemsSource = null;
            if (CbWorkspace.SelectedItem is NodeHolder wh &&
                CbStream.SelectedItem is NodeHolder sh)
            {
                var toolEnum = _control.Workspaces[wh.Name]
                                       .Streams[sh.Name]
                                       .Tools;
                CbTool.ItemsSource = toolEnum
                                    .Select(t => new NodeHolder { Name = t.Name })
                                    .ToList();
                if (CbTool.Items.Count > 0) CbTool.SelectedIndex = 0;
            }
            RefreshData();
        }

        public void CbTool_SelectionChanged(object sender, SelectionChangedEventArgs e) => RefreshData();
        public void Refresh_Click(object sender, RoutedEventArgs e) => RefreshData();
        #endregion 界面级联

        public void RefreshData()
        {
            if (CbTool.SelectedItem is NodeHolder th &&
                CbWorkspace.SelectedItem is NodeHolder wh &&
                CbStream.SelectedItem is NodeHolder sh)
            {
                // 强类型一路点下去
                var tool = _control.Workspaces[wh.Name]
                                   .Streams[sh.Name]
                                   .Tools[th.Name];

                var sb = new StringBuilder();
                sb.AppendLine($"Tool: {tool.Name}  (Type: {tool.Type})");
                sb.AppendLine(new string('-', 60));
                AppendDatabaseSummary(sb, tool.Database);
                OutputBox.Text = sb.ToString();
                Status.Text = $"Last refresh: {DateTime.Now:HH:mm:ss}";
            }
            else
            {
                OutputBox.Text = "[请依次选择 Workspace → Stream → Tool]";
                Status.Text = "No tool selected";
            }
        }

        public void AppendDatabaseSummary(StringBuilder sb, ViDi2.Training.IDatabase db)
        {
            try
            {
                var xml = db.Summary();
                var root = XElement.Parse(xml.OuterXml);
                sb.AppendLine("[Database Summary]");
                foreach (var stat in root.Elements())
                {
                    sb.AppendLine($"{stat.Name}: " +
                                  string.Join(", ", stat.Attributes()
                                                        .Select(a => $"{a.Name}={a.Value}")));
                }
                sb.AppendLine(new string('-', 60));
            }
            catch (Exception ex)
            {
                sb.AppendLine($"[读取统计信息失败: {ex.Message}]");
            }
        }

        public class NodeHolder { public string Name { get; set; } }
    }
}