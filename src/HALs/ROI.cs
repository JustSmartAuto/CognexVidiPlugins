// 文件: ROI.cs
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
        // 预览ROI
        public static bool vidi_training_roi_preview(
            // 固定参数
            string workspace_name, string stream_name, string tool_name,
            // 控制接口
            ViDi2.Training.IControl _control,
            // 数据库中图像名称
            string image_name_in_stream
        )
        {
            // 视图筛选器关键词
            string view_name = "";
            if(string.IsNullOrEmpty(image_name_in_stream))
            {
                // view_name = "new";
                string view_key_string = "";
                // 1. 构造 FrameKey（样本名 + 帧序号 0）
                var frameKey = new ViDi2.FrameKey(image_name_in_stream, frameIndex: 0);

                // 2. 构造 ViewKey（视图序号也固定给 -1）
                var viewKey = new ViDi2.Training.ViewKey(frameKey, index: -1);

                view_key_string = viewKey.ToString();

                view_name = view_key_string;
            }
            else
            {
                // view_name = $"filename ~ '{image_name_in_stream}'";
                // view_name = image_name_in_stream;
                string view_key_string = "";
                // 1. 构造 FrameKey（样本名 + 帧序号 0）
                var frameKey = new ViDi2.FrameKey(image_name_in_stream, frameIndex: 0);

                // 2. 构造 ViewKey（视图序号也固定给 -1）
                // var viewKey = new ViDi2.Training.ViewKey(frameKey, index: -1);
                // var viewKey = ViDi2.Training.ViewKey.Parse($"{image_name_in_stream}|0:-1");

                view_key_string = frameKey.ToString();

                view_name = view_key_string;
            }

            // 取出 LibraryAccess 并显式转换成 Training 命名空间下的接口
            // (RoiPreview 方法定义在 命名空间 ViDi2.Training 的同名接口 ViDi2.Training.ILibraryAccess 上)
            ViDi2.Training.ILibraryAccess lib = _control.LibraryAccess as ViDi2.Training.ILibraryAccess;
            // 保险起见判空
            if (lib == null) return false;   

            // 预览ROI
            string result = lib.RoiPreview(
                workspace_name,
                stream_name,
                tool_name,
                view_name
            );

            LogMgr.Info($"[导入标注到蓝色工具]RoiPreview={result}");

            return true;
        }

        // 应用ROI预览
        public static bool vidi_training_roi_apply_preview(
            // 固定参数
            string workspace_name, string stream_name, string tool_name,
            // 控制接口
            ViDi2.Training.IControl _control
        )
        {
            // 取出 LibraryAccess 并显式转换成 Training 命名空间下的接口
            // (RoiApplyPreview 方法定义在 命名空间 ViDi2.Training 的同名接口 ViDi2.Training.ILibraryAccess 上)
            ViDi2.Training.ILibraryAccess lib = _control.LibraryAccess as ViDi2.Training.ILibraryAccess;
            // 保险起见判空
            if (lib == null) return false;   

            // 应用ROI预览
            lib.RoiApplyPreview(
                workspace_name,
                stream_name,
                tool_name
            );

            LogMgr.Info($"[导入标注到蓝色工具]RoiApplyPreview()");

            return true;
        }
        
    }

}