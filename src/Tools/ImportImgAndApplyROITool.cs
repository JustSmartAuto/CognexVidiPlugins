// 文件: ImportImgAndApplyROI.cs
// 功能: 导入图片到vidi的图像数据库并使用整张图作为ROI

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
    // 导入图片数据到所选工具所在流的图像数据库

    // 输入: 图像base64, 工作空间，流，工具
    // 输出: 无
    // 处理: 将图像base64转为png图片, 图片名为{timestamp}.png,
    // 设置整张图为ROI区域

    public class ImportImgAndApplyROI
    {
        public ViDi2.Training.IControl _control;
        public ViDi2.Training.IStream _stream;
        
       
    }
}