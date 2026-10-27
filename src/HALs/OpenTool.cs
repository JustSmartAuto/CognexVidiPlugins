// 文件: OpenTool.cs
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
        // 获取工具参数
        public static bool vidi_training_tool_get_parameter(
            // 固定参数
            string workspace_name, string stream_name, string tool_name,
            // 控制接口
            ViDi2.Training.IControl _control
        )
        {
            /*******************    
            string GetToolParameter(
                string workspace_name,
                string stream_name,
                string tool_name,
                string parameter_path,
                ILibraryAccessContext context = null
            )
            *******************/

            // FIXME: 参数名
            string para_path = "";

            // 取出 LibraryAccess 并显式转换成 Training 命名空间下的接口
            // (GetToolParameter 方法定义在 命名空间 ViDi2.Training 的同名接口 ViDi2.Training.ILibraryAccess 上)
            ViDi2.Training.ILibraryAccess lib = _control.LibraryAccess as ViDi2.Training.ILibraryAccess;
            // 保险起见判空
            if (lib == null) return false;   

            lib.GetToolParameter(
                workspace_name, stream_name, tool_name,
                para_path
            );

            return true;
        }

        // 设置蓝色工具标注
        public static bool vidi_training_blue_set_feature(
            // 固定参数
            string workspace_name, string stream_name, string tool_name,
            // 控制接口
            ViDi2.Training.IControl _control,
            // 数据库中图像名称
            string image_name_in_stream,
            // 标注数据
            VidiBlueReadDTO label,
            // 循环计数
            int idx
        )
        {
            /********************
            void BlueSetFeature(
                WorkspaceName workspace,
                StreamName stream,
                ToolName tool,
                string view,
                int index,
                string id,
                double posx,
                double posy,
                double angle,
                double width,
                double height,
                ILibraryAccessContext context = null
            )

            public void SetFeature(ViewKey viewKey, int index, string id, Point position, double angle, Size size)
            {
                base.libraryAccess.BlueSetFeature(tool.Stream.Workspace.UniqueName, tool.Stream.Name, tool.Name, viewKey.ToString(), index, id, position.X, position.Y, angle, size.IsEmpty ? (-1.0) : size.Width, size.IsEmpty ? (-1.0) : size.Height);
                SignalChanged(new List<ViewKey> { viewKey });
            }
            *********************/

            // 视图筛选器关键词
            string view_name = "";
            if(string.IsNullOrEmpty(image_name_in_stream))
            {
                // view_name = "new";
                string view_key_string = "";
                // 1. 构造 FrameKey（样本名 + 帧序号 0）
                var frameKey = new ViDi2.FrameKey(image_name_in_stream, frameIndex: 0);

                // 2. 构造 ViewKey（视图序号也固定给 0）
                // var viewKey = new ViDi2.Training.ViewKey(frameKey, index: 0);
                var viewKey = new ViDi2.Training.ViewKey(frameKey, index: -1);
                view_key_string = viewKey.ToString();

                view_name = view_key_string;
            }
            else
            {
                // view_name = $"filename ~ '{image_name_in_stream}'";
                /************************************
                ViewKey Constructor 
                Initializes a new instance of a ViewKey to the given sample name and view-index 
                *************************************/
                // view_name = image_name_in_stream;
                string view_key_string = "";
                // 1. 构造 FrameKey（样本名 + 帧序号 0）
                var frameKey = new ViDi2.FrameKey(image_name_in_stream, frameIndex: 0);

                // 2. 构造 ViewKey（视图序号也固定给 0）
                var viewKey = new ViDi2.Training.ViewKey(frameKey, index: 0);
                // var viewKey = new ViDi2.Training.ViewKey(frameKey, index: -1);

                view_key_string = viewKey.ToString();

                LogMgr.Info($"[导入标注到蓝色工具]view_key_string={view_key_string}, 标签={label.Label}");

                view_name = view_key_string;
            }

            // 取出 LibraryAccess 并显式转换成 Training 命名空间下的接口
            // (BlueSetFeature  方法定义在 命名空间 ViDi2.Training 的同名接口 ViDi2.Training.ILibraryAccess 上)
            ViDi2.Training.ILibraryAccess lib = _control.LibraryAccess as ViDi2.Training.ILibraryAccess;
            // 保险起见判空
            if (lib == null) return false;   

            lib.BlueSetFeature(
                workspace_name, stream_name, tool_name,
                // 0为已应用preview, -1为未应用preview
                view: view_name,
                // -1为新增特征
                index: -1,
                id: label.Label, posx: label.CenterX, posy: label.CenterY,
                angle: label.Angle, width: label.Width, height: label.Height
            );

            // lib.AddFeature(
            //     view: view_name,
            //     id: label.Label, posx: label.CenterX, posy: label.CenterY,
            //     angle: label.Angle, width: label.Width, height: label.Height
            // );

            return true;
        }

        // 设置训练标志
        public static bool vidi_training_tool_set_view_train(
            // 固定参数
            string workspace_name, string stream_name, string tool_name,
            // 控制接口
            ViDi2.Training.IControl _control,
            // 数据库中图像名称
            string image_name_in_stream
        )
        {
            /**********************
                        void SetViewTrain(
                WorkspaceName workspace,
                StreamName stream,
                ToolName tool,
                string filter,
                int train,
                ILibraryAccessContext context = null
            )
            **********************/

            // 视图筛选器关键词
            string view_name = "";
            if(string.IsNullOrEmpty(image_name_in_stream))
            {
                view_name = "new";
            }
            else
            {
                view_name = $"filename ~ '{image_name_in_stream}'";
            }

            // 取出 LibraryAccess 并显式转换成 Training 命名空间下的接口
            // (SetViewTrain 方法定义在 命名空间 ViDi2.Training 的同名接口 ViDi2.Training.ILibraryAccess 上)
            ViDi2.Training.ILibraryAccess lib = _control.LibraryAccess as ViDi2.Training.ILibraryAccess;
            // 保险起见判空
            if (lib == null) return false;   

            lib.SetViewTrain(
                workspace_name, stream_name, tool_name,
                view_name,
                1
            );

            return true;
        }
        
        // 设置训练标志
        public static bool vidi_training_tool_set_train_flag(
            // 固定参数
            string workspace_name, string stream_name, string tool_name,
            // 控制接口
            ViDi2.Training.IControl _control,
            // 数据库中图像名称
            string image_name_in_stream
        )
        {
            /**********************
            void SetTrainFlag(
                string filter,
                bool flag
            )
            **********************/

            // 视图筛选器关键词
            string view_name = "";
            if(string.IsNullOrEmpty(image_name_in_stream))
            {
                view_name = "new";
            }
            else
            {
                view_name = $"filename ~ '{image_name_in_stream}'";
            }

            // 取出 LibraryAccess 并显式转换成 Training 命名空间下的接口
            // (SetTrainFlag  方法定义在 命名空间 ViDi2.Training 的同名接口 ViDi2.Training.IToolDatabase 上)
            ViDi2.Training.ILibraryAccess lib = _control.LibraryAccess as ViDi2.Training.ILibraryAccess;
            // 保险起见判空
            if (lib == null) return false;  

            // 获取工具所属的流
            vidi_training_workspace_open_stream(
                workspace_name, stream_name, tool_name,
                _control,
                out ViDi2.Training.IStream stream
            );

            // 判空
            if(stream == null)
            {
                return false;
            }

            // 获取工具
            ViDi2.Training.IToolList tools = stream.Tools;
            ViDi2.Training.ITool tool = tools.Where( tls => tls.Name == tool_name ).FirstOrDefault();

            // 获取工具的数据库引用
            ViDi2.Training.IToolDatabase db_by_tool = tool.Database;

            // 设置训练标志
            db_by_tool.SetTrainFlag(
                view_name,
                true
            );

            return true;
        }
    }

}