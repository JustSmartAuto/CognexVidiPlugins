// 文件: VidiSharpHAL.cs
// 功能: 从csharp操作vidi数据库高层级封装

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

// 插件接口
using ViDi2;
using ViDi2.Common;
using ViDi2.Common.Utilities;
using ViDi2.UI;
using ViDi2.Training;
using ViDi2.Training.UI;

// 禁用警告
#pragma warning disable CS8632

namespace JusNet472Template
{
    public partial class VidiSharpHAL
    {
        // !!!插件上下文
        public IPluginContext _ctx;

        // !!!控制接口
        public ViDi2.Training.IControl _control;  

        // 所有函数前三个参数: string workspace_name, string stream_name, string tool_name,
        // public bool vidi_training_open_workspace() { return true; }
        // public bool vidi_training_workspace_list_streams() { return true; }
        // public bool vidi_training_get_parameter(){ return true; }
        // public bool vidi_training_set_parameter(){ return true; }
        // public bool vidi_training_stream_add_samples_to_set(){ return true; }
        // public bool vidi_training_stream_add_image_from_memory(){ return true; }
        // public bool vidi_training_tool_set_parameter(){ return true; }
        // public bool vidi_training_tool_get_parameter(){ return true; }
        // public bool vidi_training_tool_get_marking(){ return true; }
        // public bool vidi_training_roi_preview(){ return true; }
        // public bool vidi_training_roi_apply_preview(){ return true; }
        // public bool vidi_training_blue_set_feature(){ return true; }
        // public bool vidi_training_tool_set_view_train(){ return true; }
        // public bool vidi_training_view_set_mask(){ return true; }
        // public bool vidi_training_stream_get_image(){ return true; }
        // public bool vidi_training_stream_list_tools(){ return true; }
    }
}