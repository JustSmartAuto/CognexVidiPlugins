// 文件: XAnyLabelingDTO.cs
// 功能: 定义xanylabeling的标注格式

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

// 禁用警告
#pragma warning disable CS8632

namespace JusNet472Template
{
    /// <summary>
    /// 标注格式 的JSON根对象
    /// </summary>
    public class XAnyLabelingDTO
    {
        // 元信息
        public string? metaName { get; set; }
        // base64
        public string? imageData   { get; set; }   
        // 本地路径(一般不用)
        public string? imagePath   { get; set; }   
        // 图片哈希
        public string? imageHash { get;set; }
        // 标注信息
        public List<XAnyLabelingShape> shapes  { get; set; } = new List<XAnyLabelingShape>();
        // ROI区域
        public XAnyLabelingShape? roiRegion { get; set; }

        /* ===== 以下字段均为可选 ===== */
        /// <summary>
        /// 文件格式版本号
        /// </summary>
        public string? version { get; set; }

        /// <summary>
        /// 预留扩展标记（对应参考代码中的 flags）
        /// </summary>
        public object? flags { get; set; }

        /// <summary>
        /// 图片高度（像素）
        /// </summary>
        public int? imageHeight { get; set; }

        /// <summary>
        /// 图片宽度（像素）
        /// </summary>
        public int? imageWidth { get; set; }
    }

    /// <summary>
    /// 单个标注
    /// </summary>
    public class XAnyLabelingShape
    {
        public string label      { get; set; } = string.Empty;
        // "rotation" | "rectangle"
        public string shape_type { get; set; } = string.Empty; 
        // [[x,y],...]s
        public List<List<float>> points { get; set; } = new List<List<float>>();   
        // 得分
        public float? score {get; set; }

        /* ===== 以下字段均为可选 ===== */
        /// <summary>
        /// 分组ID
        /// </summary>
        public object? group_id { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        public string? description { get; set; }

        /// <summary>
        /// 是否为难例
        /// </summary>
        public bool? difficult { get; set; }

        /// <summary>
        /// 预留扩展标记
        /// </summary>
        public object? flags { get; set; }

        /// <summary>
        /// 属性字典
        /// </summary>
        public object? attributes { get; set; }

        /// <summary>
        /// KIE链接信息
        /// </summary>
        public List<object>? kie_linking { get; set; }

        /// <summary>
        /// 文字方向（0-3 对应 0°/90°/180°/270°）
        /// </summary>
        public int? direction { get; set; }
    }
}

