// 文件: Program.cs
// 功能: vidi插件入口.

// 标准库
using System;
using System.Threading;
using System.Windows.Controls;
using System.Windows.Markup;
using System.IO;
using System.Linq;


// 插件接口
using ViDi2.Training.UI;

namespace JusNet472Template
{
    // 1. 必须 public
    // 2. 必须实现 IPlugin
    public class MyPlugin : IPlugin
    {
        private IPluginContext _context;
        private MenuItem _menuItem;
        private Window1 _window;   // 你自己的 WPF 窗口

        public string Name        => "JusVidiPluginTemplate";
        public string Description => "演示带窗口的 ViDi 插件";
        public int    Version     => 1;

        public void Initialize(IPluginContext context)
        {
            _context = context;

            /* 1. 在主菜单“PluginsMenu”里加一项 */
            MenuItem pluginsMenu = _context.MainWindow.MainMenu.Items
                                          .OfType<MenuItem>()
                                          .FirstOrDefault(mi => mi.Name == "PluginsMenu");
            if (pluginsMenu == null) return;          // 保险

            _menuItem = new MenuItem
            {
                Header = Name,
                ToolTip = Description
            };
            _menuItem.Click += OnMenuClick;
            pluginsMenu.Items.Add(_menuItem);
        }

        public void DeInitialize()
        {
            /* 2. 移除菜单 */
            if (_menuItem != null && _menuItem.Parent is MenuItem parent)
                parent.Items.Remove(_menuItem);

            /* 3. 清理窗口资源 */
            if (_window != null)
            {
                _window.Close();
                _window = null;
            }
        }

        /* 4. 显示/隐藏窗口 */
        private void OnMenuClick(object sender, EventArgs e)
        {
            if (_window == null)
            {
                _window = new Window1();
                _window.Closing += (s, args) =>
                {
                    // 不按“X”真关，只是隐藏
                    args.Cancel = true;
                    _window.Hide();
                };
            }

            if (_window.IsVisible)
                _window.Hide();
            else
                _window.Show();   // 非模态，可切换
        }
    }
}