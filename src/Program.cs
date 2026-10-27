// 文件: Program.cs

// 标准库
using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;

// 插件接口
using ViDi2.Training;
using ViDi2.Training.UI;

namespace JusNet472Template
{
    public class MyPlugin : IPlugin
    {
        public string Name        => "JusXAnyLabel.VPlugin";
        public string Description => "导入/导出标注信息";
        public int    Version     => 251231;

        private IPluginContext _ctx;
        private MenuItem       _menu;
        private PluginMainWindow _win;

        public void Initialize(IPluginContext ctx)
        {
            _ctx = ctx;
            var pluginsMenu = ctx.MainWindow.MainMenu.Items
                                 .OfType<MenuItem>()
                                 .FirstOrDefault(m => m.Name == "PluginsMenu");
            if (pluginsMenu == null) return;

            _menu = new MenuItem { Header = Name, ToolTip = Description };
            _menu.Click += (_, __) => ToggleWindow();
            pluginsMenu.Items.Add(_menu);
        }

        public void DeInitialize()
        {
            if (_menu?.Parent is MenuItem p) p.Items.Remove(_menu);
            _win?.Close();
            _win = null;
        }

        private void ToggleWindow()
        {
            if (_win == null)
            {
                _win = new PluginMainWindow(_ctx)
                {
                    Owner = System.Windows.Application.Current.MainWindow,
                    WindowStyle = System.Windows.WindowStyle.ToolWindow,
                    Width = 700, Height = 600,
                    MinWidth = 500, MinHeight = 400
                };
                _win.Closing += (s, e) => _win = null;
            }
            _win.Show();
            _win.Activate();
        }
    }
}