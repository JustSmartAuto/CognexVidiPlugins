// 文件: ImportXAnyLabelTool.cs
// 功能: 导入XAnyLabel标注信息

// 标准库
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Collections.Generic;
using System.Windows.Controls;

// JSON
using Newtonsoft.Json;

// 屏蔽警告
#pragma warning disable CS8632

namespace JusNet472Template
{
    public partial class ImportXAnyLabelTool
    {
        // BtnOpenJsonFile 选中的文件
        public string? LastPickedJsonFile;

        // BtnOpenJsonDir  选中的目录
        public string? LastPickedJsonDir;    

        // 控制接口
        public ViDi2.Training.IControl _control;

        // 选择器选中的工具
        public string workspace_name_sel;
        public string stream_name_sel;
        public string tool_name_sel;

        // 导入单个json
        public static bool ImportBlue(
            // 固定参数
            string workspace_name, string stream_name, string tool_name,
            // 控制接口
            ViDi2.Training.IControl _control,
            // 选择的json数据(单个json)
            string json_file_path
        )
        {
            // 读取json数据
            string txt = File.ReadAllText(json_file_path);
            XAnyLabelingDTO xany_dto = JsonConvert.DeserializeObject<XAnyLabelingDTO>(txt);
            List<VidiBlueReadDTO> vidi_blue_dto_list = ConvertToBlue(xany_dto);

            // 将图像添加数据库
            bool ok1 = VidiSharpHAL.vidi_training_stream_add_image_from_memory(
                // 固定参数
                workspace_name, stream_name, tool_name,
                // 控制接口
                _control,
                // 图像base64数据
                xany_dto.imageData,
                // 图像名称
                out string img_name_in_stream
            );

            LogMgr.Info($"[导入标注到蓝色工具]ok1={ok1}");

            // 应用视图ROI
            bool ok2 = VidiSharpHAL.vidi_training_roi_preview(
                // 固定参数
                workspace_name, stream_name, tool_name,
                // 控制接口
                _control,
                // 图像名称
                img_name_in_stream
            );
            LogMgr.Info($"[导入标注到蓝色工具]ok2={ok2}");

            bool ok3 = VidiSharpHAL.vidi_training_roi_apply_preview(
                // 固定参数
                workspace_name, stream_name, tool_name,
                // 控制接口
                _control
            );
            LogMgr.Info($"[导入标注到蓝色工具]ok3={ok3}");

            // 导入features
            bool ok4 = true;
            // img_name_in_stream = "20260105_140703_461.jpg";
            for (int i = 0; i < vidi_blue_dto_list.Count; i++)
            {
                ok4 = VidiSharpHAL.vidi_training_blue_set_feature(
                    // 固定参数
                    workspace_name, stream_name, tool_name,
                    // 控制接口
                    _control,
                    // 图像名称
                    image_name_in_stream: img_name_in_stream, 
                    // 标注数据
                    label: vidi_blue_dto_list[i],
                    // 索引
                    idx: i
                );
            }
            LogMgr.Info($"[导入标注到蓝色工具]ok4={ok4}");
            
            // 设置训练标志
            bool ok5 = VidiSharpHAL.vidi_training_tool_set_train_flag(
                // 固定参数
                workspace_name, stream_name, tool_name,
                // 控制接口
                _control,
                // 图像名称
                img_name_in_stream
            );
            LogMgr.Info($"[导入标注到蓝色工具]ok5={ok5}");

            return true;
        }

        // 导入多个json
        public static bool ImportBlues(
            // 固定参数
            string workspace_name, string stream_name, string tool_name,
            // 控制接口
            ViDi2.Training.IControl _control,
            // 选择的json数据(多个json)
            string json_folder_path
        )   
        {
            // 遍历文件夹中json文件
            var jsonFiles = Directory.GetFiles(json_folder_path, "*.json");
            if (jsonFiles.Length == 0)
            {
                return false;
            }

            // 逐个导入
            foreach (string file_path in jsonFiles)
            {
                ImportXAnyLabelTool.ImportBlue(
                    // 固定参数
                    workspace_name, stream_name, tool_name,
                    // 控制接口
                    _control,
                    // json文件路径
                    file_path
                );
            }

            return true;
        }

        #region 分别导入图片与导入标注
        /* ==========================================================
        * Step-1：只把图像灌进数据库，返回 stream 内图像名列表
        * ========================================================== */
        public static bool ImportImagesOnly(
            string workspace, string stream, string tool,
            ViDi2.Training.IControl ctrl,
            IEnumerable<string> jsonPaths,   // 单个或多个 json
            List<string> outputImageNames)   // 出参
        {
            outputImageNames.Clear();
            foreach (string jsonPath in jsonPaths)
            {
                string txt = File.ReadAllText(jsonPath);
                var xany = JsonConvert.DeserializeObject<XAnyLabelingDTO>(txt);

                bool ok = VidiSharpHAL.vidi_training_stream_add_image_from_memory(
                    workspace, stream, tool,
                    ctrl,
                    xany.imageData,
                    out string imgNameInStream);

                if (!ok) return false;

                outputImageNames.Add(imgNameInStream);
                LogMgr.Info($"[ImportImagesOnly] 导入图像 -> {imgNameInStream}");
            }
            return true;
        }

        /* ==========================================================
        * Step-3：把标注写进“已经存在”的图像 viewKey
        * 单文件版本
        * ========================================================== */
        public static bool ImportBlueLabelsOnly(
            string workspace, string stream, string tool,
            ViDi2.Training.IControl ctrl,
            string jsonPath,          // 原 json
            string imageNameInStream) // 第①步得到的 stream 内图像名
        {
            string txt = File.ReadAllText(jsonPath);
            var xany   = JsonConvert.DeserializeObject<XAnyLabelingDTO>(txt);
            var blues  = ConvertToBlue(xany);   // 你自己的转换函数

            // 不再加图，也不再调用 RoiApplyPreview
            for (int i = 0; i < blues.Count; i++)
            {
                bool ok = VidiSharpHAL.vidi_training_blue_set_feature(
                    workspace, stream, tool,
                    ctrl,
                    imageNameInStream,
                    blues[i],
                    i);
                if (!ok) return false;
            }

            // 打训练标记
            VidiSharpHAL.vidi_training_tool_set_train_flag(
                workspace, stream, tool,
                ctrl,
                imageNameInStream);

            LogMgr.Info($"[ImportLabelsOnly] 完成标注写入 -> {imageNameInStream}");
            return true;
        }

        /* ==========================================================
        * Step-3：批量版本（文件夹）
        * ========================================================== */
        public static bool ImportBlueLabelsOnlyMulti(
            string workspace, string stream, string tool,
            ViDi2.Training.IControl ctrl,
            string jsonFolder,
            List<string> imageNamesInStream) // 与 json 文件一一对应
        {
            var jsonFiles = Directory.GetFiles(jsonFolder, "*.json")
                                    .OrderBy(f => f)
                                    .ToArray();
            if (jsonFiles.Length != imageNamesInStream.Count)
            {
                LogMgr.Error("json 文件数量与已导入图像数量不一致！");
                return false;
            }

            for (int i = 0; i < jsonFiles.Length; i++)
            {
                bool ok = ImportBlueLabelsOnly(workspace, stream, tool,
                                        ctrl,
                                        jsonFiles[i],
                                        imageNamesInStream[i]);
                if (!ok) return false;
                LogMgr.Info($"ImportBlueLabelsOnlyMulti进度: {i}/{jsonFiles.Length}");
            }
            return true;
        }
        #endregion 分别导入图片与导入标注
    }
}