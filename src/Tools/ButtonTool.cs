// 文件: ButtonTool.cs
// 功能: 处理按钮事件

// 标准库
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Collections.Generic;
using System.Windows.Controls;

// 屏蔽警告
#pragma warning disable CS8632

namespace JusNet472Template
{
    public partial class PluginMainWindow
    {
        // 这两个字段就是“控件点击后”的文件/目录
        // BtnOpenJsonFile 选中的文件
        public string? LastPickedJsonFile;   
        // BtnOpenJsonDir  选中的目录
        public string? LastPickedJsonDir;  
        // 记住“最后一次”想导入的 json 路径（文件 or 文件夹）, null 表示还没选
        public string[]? _lastJsonPaths;
         // === 第①步：把图导进数据库后，收集到的 stream 内图像名 ===
        public readonly List<string> _importedImageNamesInStream = new List<string>();

        private void WireEvents()
        {
            // 打印版本信息
            LogMgr.Info("=====================");
            LogMgr.Info("XAnyLabel.VPlugin插件");
            LogMgr.Info("version: 2601051513");
            LogMgr.Info("=====================");
            
            // 选择器刷新
            BtnRefreshSelector.Click += (s, e) =>
            {
                AppendLog("刷新选择器 按钮已点击");
                BtnRefreshSelector_Click(s, e);
            };

            // 打开单个 json 文件
            BtnOpenJsonFile.Click += (s, e) =>
            {
                AppendLog("打开标注 json 文件 按钮已点击");
                var dlg = new Microsoft.Win32.OpenFileDialog
                {
                    Filter = "JSON 文件 (*.json)|*.json",
                    Multiselect = false
                };
                if (dlg.ShowDialog() == true)
                {
                    var fi = new FileInfo(dlg.FileName);
                    // 互斥
                    LastPickedJsonDir  = null;   
                              
                    AppendLog($"选择的文件: {fi.FullName}");
                    AppendLog($"  大小: {fi.Length:N0} 字节");

                    // 记录所选择的文件
                    LastPickedJsonFile = dlg.FileName;
                    _lastJsonPaths     = new[] { dlg.FileName }; 
                    // 新一轮，先清空旧列表
                    _importedImageNamesInStream.Clear();  
                }
                else
                {
                    AppendLog("用户取消了文件选择");
                    LastPickedJsonFile = null;
                    _lastJsonPaths = null;
                }
            };

            // 打开 json 所在文件夹（通过选文件反推）
            BtnOpenJsonDir.Click += (s, e) =>
            {
                AppendLog("打开标注 json 文件夹 按钮已点击");
                string folder = FolderPicker.PickFolderViaFile();
                if (folder == null)
                {
                    AppendLog("用户取消了文件夹选择");
                    return;
                }

                // 全局记录
                LastPickedJsonDir = folder; 

                AppendLog($"选择的文件夹: {folder}");
                try
                {
                    var jsonFiles = Directory.EnumerateFiles(folder, "*.json", SearchOption.TopDirectoryOnly)
                                             .Select(Path.GetFileName)
                                             .ToArray();
                    
                    _lastJsonPaths     = Directory.EnumerateFiles(folder, "*.json").ToArray();
                    
                    AppendLog($"  包含 {jsonFiles.Length} 个 json 文件:");
                    // 新一轮，先清空旧列表
                    _importedImageNamesInStream.Clear(); 

                    foreach (var name in jsonFiles)
                        AppendLog($"    {name}");
                }
                catch (Exception ex)
                {
                    AppendLog($"  枚举 json 文件时出错: {ex.Message}");
                }
            };

            // 导入图片到数据库
            BtnImportImages.Click += (s, e) =>
            {
                AppendLog("[导入图片到数据库]按钮已点击");

                if (_lastJsonPaths == null || _lastJsonPaths.Length == 0)
                {
                    MessageBox.Show("请先选择 json 文件或文件夹！", "提示",
                                    MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                // 新一轮，先清空旧列表
                _importedImageNamesInStream.Clear(); 

                // 获取选择器数据
                string workspace_name_sel;
                string stream_name_sel;
                string tool_name_sel;

                GetSelected(
                    out workspace_name_sel,
                    out stream_name_sel,
                    out tool_name_sel
                );

                bool ok = ImportXAnyLabelTool.ImportImagesOnly(
                            workspace_name_sel,
                            stream_name_sel,
                            tool_name_sel,
                            _control,
                            _lastJsonPaths,
                            _importedImageNamesInStream);

                if (ok && _importedImageNamesInStream.Count > 0)
                {
                    AppendLog($"[Step-1] 已导入 {_importedImageNamesInStream.Count} 张图像到数据库。");
                    AppendLog("[Step-2] 请 **手动** 到主界面点击【应用】按钮（RoiApplyPreview 暂时有 bug）！");
                    AppendLog("[Step-3] 最后再点【导入标注到蓝色工具】完成标注写入。");
                }
                else
                {
                    AppendLog("[Step-1] 导入图像失败，请检查日志！");
                }
            };

            // 导入蓝色工具
            BtnImportBlue.Click += (s, e) => 
            {
                AppendLog("[导入标注到蓝色工具]按钮已点击");

                // 获取选择器数据
                string workspace_name_sel;
                string stream_name_sel;
                string tool_name_sel;

                GetSelected(
                    out workspace_name_sel,
                    out stream_name_sel,
                    out tool_name_sel
                );

                // 判断是否导入过图片
                if (_importedImageNamesInStream.Count == 0)
                {
                    MessageBox.Show("请先完成 Step-1（导入图像）！", "提示",
                                    MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                // 获取文件选择器路径
                string file_path = LastPickedJsonFile;
                string folder_path = LastPickedJsonDir;

                // 判断选择的是文件还是文件夹
                if(!string.IsNullOrEmpty(file_path))
                {
                    ImportXAnyLabelTool.ImportBlueLabelsOnly(
                        // 固定参数
                        workspace_name_sel, stream_name_sel, tool_name_sel,
                        // 控制接口
                        _control,
                        // json文件路径
                        file_path,
                        // 导入的图片名称列表
                        _importedImageNamesInStream.FirstOrDefault()
                    );
                }
                else if(!string.IsNullOrEmpty(folder_path))
                {
                    ImportXAnyLabelTool.ImportBlueLabelsOnlyMulti(
                        // 固定参数
                        workspace_name_sel, stream_name_sel, tool_name_sel,
                        // 控制接口
                        _control,
                        // json文件夹路径
                        folder_path,
                        // 导入的图片名称列表
                        _importedImageNamesInStream
                    );
                }

                AppendLog("[导入标注到蓝色工具]导入完成!");

            };

            // 导入绿色工具
            BtnImportGreen.Click += (s, e) => 
            {
                AppendLog("[导入标注到绿色工具]按钮已点击");
            };

            // 导入红色工具
            BtnImportRed.Click += (s, e) => 
            {
                AppendLog("[导入标注到红色工具]按钮已点击");
            };

        }

    }
}