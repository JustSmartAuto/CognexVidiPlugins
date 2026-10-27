// 文件: ViewAndFrame.cs
// 功能: 构造ViewKey和FrameKey

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
        
        /***************************
        在训练 API 里，一幅“图”在流里的完整标识是  
        `样本名 : 帧序号 : 视图序号`  
        对应 `ViewKey.ToString()` 的返回值。  
        因此你必须先拿到“样本名”和“帧序号”，再拼出 `ViewKey`。
        ****************************/

        // 获取图像的ViewKey
        public static bool vidi_training_get_view_key(
            // 固定参数
            string workspace_name, string stream_name, string tool_name,
            // 控制接口
            ViDi2.Training.IControl _control,
            // 数据库中图像名称
            string image_name_in_stream,
            // 返回的ViewKey字符串
            out string view_key_string
        )
        {
            // 1. 构造 FrameKey（样本名 + 帧序号 0）
            var frameKey = new ViDi2.FrameKey(image_name_in_stream, frameIndex: 0);

            // 2. 构造 ViewKey（视图序号也固定给 0）
            var viewKey = new ViDi2.Training.ViewKey(frameKey, index: 0);

            view_key_string = viewKey.ToString();
            return true;
        }
    }
}