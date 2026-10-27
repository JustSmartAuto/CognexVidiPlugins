// 文件: ImportXAnyLabel.cs
// 功能: 导入XAnyLabeling格式的标注数据到选定的vidi工具
// 选择文件夹->导入所有json文件->XAnyLabelingDTO->VidiBlueReadDTO/VidiGreenDTO/VidiRedDTO

// 如果选择导入蓝色工具标注信息, 将矩形四点框转换为x轴作为短边的2:3比例中点旋转矩形框(VidiBlueReadDTO);
// 图片数据仅使用json中的base64数据(可能带有base64;前缀), 文件名使用{timestamp}.png;

// 用法：new ImportXAnyLabel(control, tool).Run();

// 标准库
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using Microsoft.Win32;

// JSON
using Newtonsoft.Json;

// Cognex
using ViDi2.Training;

namespace JusNet472Template
{
    public class ImportXAnyLabel
    {
        private readonly IControl _control;
        private readonly ITool    _tool;

        public ImportXAnyLabel(IControl control, ITool tool)
        {
            _control = control ?? throw new ArgumentNullException(nameof(control));
            _tool    = tool    ?? throw new ArgumentNullException(nameof(tool));
        }

        public void Run()
        {
            /* ---------- 1. 选文件夹 ---------- */
            string folder = FolderPicker.PickFolderViaFile();
            if (folder == null) return;

            /* ---------- 2. 拿到所有 json ---------- */
            var jsonFiles = Directory.GetFiles(folder, "*.json");
            if (jsonFiles.Length == 0)
            {
                MessageBox.Show("目录下未找到 *.json 文件");
                return;
            }

            /* ---------- 3. 逐个解析并转换 ---------- */
            var samples = new List<object>(jsonFiles.Length);
            foreach (string file in jsonFiles)
            {
                try
                {
                    string txt = File.ReadAllText(file);
                    var dto = JsonConvert.DeserializeObject<XAnyLabelingDTO>(txt);
                    samples.Add(ConvertToBlue(dto));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"解析失败：{Path.GetFileName(file)}\n{ex.Message}");
                    return;
                }
            }

            /* ---------- 4. 一次性写入 ViDi ---------- */
            try
            {
                // _tool.ImportSamples(samples.ToArray());
                MessageBox.Show($"导入完成，共 {samples.Count} 张图");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"ViDi 导入失败\n{ex.Message}");
            }
        }

        /* ---------- 把 DTO → VidiBlueReadDTO ---------- */
        private VidiBlueReadDTO ConvertToBlue(XAnyLabelingDTO src)
        {
            /* ---- 4.1 图片 ---- */
            string base64 = StripDataURI(src.imageData ?? "");
            byte[] pngBytes = Convert.FromBase64String(base64);
            string timeStamp = DateTime.Now.ToString("yyyyMMdd_HHmmssfff");

            /* ---- 4.2 找第一个 rotation ---- */
            var poly = src.shapes?.FirstOrDefault(s =>
                            s.shape_type == "rotation" && s.points != null && s.points.Count >= 3);
            if (poly == null)
                throw new InvalidDataException("未找到 rotation 标注");

            /* ---- 4.3 四点 → 旋转矩形 ---- */
            var pts = poly.points.Select(p => new PointF(p[0], p[1])).ToList();
            RotatedRect rr = PolygonToRotatedRect(pts);   // x 短边 + 2:3

            return new VidiBlueReadDTO
            {
                ImageBytes = pngBytes,
                FileName   = timeStamp + ".png",
                Label      = poly.label ?? "",
                CenterX    = rr.CenterX,
                CenterY    = rr.CenterY,
                Width      = rr.Width,
                Height     = rr.Height,
                Angle      = rr.Angle
            };
        }

        #region 工具函数
        private static string StripDataURI(string s)
        {
            if (s == null) return "";
            int idx = s.IndexOf("base64,", StringComparison.OrdinalIgnoreCase);
            return idx < 0 ? s : s.Substring(idx + 7);
        }

        /* 把四点 rotation → 中心旋转矩形，保证：
         * 1. x 轴为短边；2. 高:宽 = 2:3；3. 角度 0~360° */
        private static RotatedRect PolygonToRotatedRect(List<PointF> pts)
        {
            /* 简易实现：AABB → 强制 x 短边 → 2:3 */
            float minX = pts.Min(p => p.X);
            float maxX = pts.Max(p => p.X);
            float minY = pts.Min(p => p.Y);
            float maxY = pts.Max(p => p.Y);

            float w = maxX - minX;
            float h = maxY - minY;

            /* 让 x 为短边 */
            if (w > h) { float t = w; w = h; h = t; }

            /* 强制 2:3 高宽比 */
            h = w * 2f / 3f;

            return new RotatedRect
            {
                CenterX = (minX + maxX) / 2f,
                CenterY = (minY + maxY) / 2f,
                Width   = w,
                Height  = h,
                Angle   = 0f
            };
        }

        private struct PointF { public float X, Y; public PointF(float x, float y) { X = x; Y = y; } }
        private struct RotatedRect { public float CenterX, CenterY, Width, Height, Angle; }
        #endregion 工具函数
    }
}