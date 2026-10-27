// 文件: VidiLabelTool.cs
// 功能: 封装vidi标签功能

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
    public partial class TextBrowserWin
    {

    }

}