// 文件: SelectVidiTool.cs
// 功能: 依次选择 Workspace → Stream → Tool然后激活Workspace

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
    public partial class SelectVidiTool
    {
        // !!!插件上下文
        public IPluginContext _ctx;
        // !!!控制接口
        public ViDi2.Training.IControl _control;  

    }
}