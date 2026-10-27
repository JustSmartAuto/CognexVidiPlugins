// 文件: OpenStream.cs
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
        // 获取流名称
        public static bool vidi_training_workspace_list_streams(
            // 固定参数
            string workspace_name, string stream_name, string tool_name,
            // 控制接口
            ViDi2.Training.IControl _control,
            // 返回值
            out List<string> stream_list
        )
        {
            // 工作流名称列表
            stream_list = new List<string>();

            // 工作空间实例
            ViDi2.Training.IWorkspace workspace;

            // 打开工作空间
            bool ok = vidi_training_open_workspace(
                workspace_name, stream_name, tool_name,
                _control,
                out workspace
            );

            if(!ok) return false;

            // 获取流名称列表
            stream_list = workspace.Streams.Select(st => st.Name).ToList();

            return true;
        }

        // 返回流实例
        public static bool vidi_training_workspace_open_stream(
            // 固定参数
            string workspace_name, string stream_name, string tool_name,
            // 控制接口
            ViDi2.Training.IControl _control,
            // 返回值
            out ViDi2.Training.IStream stream
        )
        {
            stream = null;

            // 打开工作空间
            bool ok = vidi_training_open_workspace(
                workspace_name, stream_name, tool_name,
                _control, 
                out ViDi2.Training.IWorkspace workspace
            );

            if(workspace == null)
            {
                return false;
            }

            // 找到目标流
            stream = workspace.Streams
                                    .FirstOrDefault(st => st.Name == stream_name);

            return true;
        }

        // 添加图像到流数据库
        public static bool vidi_training_stream_add_image_from_memory(
            // 固定参数
            string workspace_name, string stream_name, string tool_name,
            // 控制接口
            ViDi2.Training.IControl _control,
            // 待添加图像
            string image_base64,
            // 图像名称
            out string image_name_in_stream
        )
        {
            image_name_in_stream = null;

            // 获取流实例
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

            // 从base64构造IImage图像
            System.IO.Stream image = Base64StringToStream(image_base64);
            byte[] imgBytes = Base64StringToBytes(image_base64);

            // 扩展名
            string ext = DetectImageFormat(imgBytes);
            string image_name_prefix = DateTime.Now.ToString("yyyyMMdd_HHmmss_fff");
            string image_name_tmp = image_name_prefix + "." + ext;
            string image_name = image_name_tmp;

            // 添加图像
            stream.Database.AddImage(image, image_name_tmp);

            // // 预览ROI
            // vidi_training_roi_preview(
            //     workspace_name, stream_name, tool_name,
            //     _control,
            //     image_name
            //     );

            // // 应用ROI
            // vidi_training_roi_apply_preview(
            //     workspace_name, stream_name, tool_name,
            //     _control
            // );

            image_name_in_stream = image_name;

            return true;
        }

        #region 工具
        // 如果前缀存在，先去掉
        static System.IO.Stream Base64StringToStream(string img_base64)
        {
            byte[] bytes = Base64StringToBytes(img_base64);
            // 只读即可
            return new System.IO.MemoryStream(bytes, writable: false);   
        }

        /// <summary>
        /// 将带前缀或不带前缀的 base64 字符串安全地转换为 byte[]。
        /// 自动去除 data:image/xxx;base64, 前缀、空白字符，并自动补齐填充字符。
        /// </summary>
        /// <param name="base64">输入的 base64 字符串。</param>
        /// <returns>解码后的字节数组。</returns>
        public static byte[] Base64StringToBytes(string base64)
        {
            if (string.IsNullOrWhiteSpace(base64))
                return Array.Empty<byte>();

            // 1. 去掉前缀  data:image/xxx;base64,
            int idx = base64.IndexOf("base64,", StringComparison.OrdinalIgnoreCase);
            string pure = idx < 0 ? base64 : base64.Substring(idx + 7);

            // 2. 去除所有空白字符（换行、回车、空格、制表符）
            pure = pure.Replace(" ", "")
                    .Replace("\r", "")
                    .Replace("\n", "")
                    .Replace("\t", "");

            // 3. 长度不足 4 的倍数时补齐 '='
            int mod4 = pure.Length % 4;
            if (mod4 > 0)
                pure += new string('=', 4 - mod4);

            // 4. 解码
            return Convert.FromBase64String(pure);
        }

        /// <summary>
        /// 读文件头判断格式，返回小写扩展名
        /// </summary>
        private static string DetectImageFormat(byte[] data)
        {
            if (data.Length < 4) return "png"; // 保底
            // PNG
            if (data[0] == 0x89 && data[1] == 0x50 && data[2] == 0x4E && data[3] == 0x47)
                return "png";
            // JPG
            if (data[0] == 0xFF && data[1] == 0xD8)
                return "jpg";
            // BMP
            if (data[0] == 0x42 && data[1] == 0x4D)
                return "bmp";
            // TIFF (little/big endian)
            if ((data[0] == 0x49 && data[1] == 0x49 && data[2] == 0x2A && data[3] == 0x00) ||
                (data[0] == 0x4D && data[1] == 0x4D && data[2] == 0x00 && data[3] == 0x2A))
                return "tif";
            return "png"; // 默认
        }
        #endregion 工具 

    }
}