// 文件: TextBrowserWin.xaml.cs
// 功能: 取数据 → 格式化 → 文本框

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
    public partial class PluginMainWindow : Window
    {
        // !!!插件上下文
        public IPluginContext _ctx;
        public ViDi2.Training.IControl _control;   

        public PluginMainWindow(IPluginContext ctx)
        {
            InitializeComponent();
            

            if (ctx == null) throw new ArgumentNullException(nameof(ctx));
            _ctx = ctx;


            // IMainWindow 已经在插件上下文里给出
            var mainWin = ctx.MainWindow;
            _control = mainWin.WorkspaceBrowserViewModel.Control
                        ?? throw new InvalidOperationException("无法获取 IControl 服务");
            
            Loaded += (s, e) => LogMgr.Register(this);   // 注册
            Closed += (s, e) => LogMgr.UnRegister();     // 反注册
            
            WireEvents();

        }
    }
}