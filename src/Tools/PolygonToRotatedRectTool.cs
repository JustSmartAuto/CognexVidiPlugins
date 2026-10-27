// 文件: PolygonToRotatedRectTool.cs
// 功能: 四点定义四边形转为中点定义旋转矩形

// 标准库
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Collections.Generic;
using System.Windows.Controls;

namespace JusNet472Template
{
    public partial class ImportXAnyLabelTool
    {
        #region 工具函数
        private static string StripDataURI(string s)
        {
            if (s == null) return "";
            int idx = s.IndexOf("base64,", StringComparison.OrdinalIgnoreCase);
            return idx < 0 ? s : s.Substring(idx + 7);
        }

        // 把四点 rotation → 中心旋转矩形，保证：
        // 1. x 轴为短边；
        // 2. 高:宽 = 2:3；3. 角度 0~360°
        private static RotatedRect PolygonToRotatedRect(List<PointF> pts)
        {
            /* 简易实现：AABB → 强制 x 短边 → 2:3 */
            float minX = pts.Min(p => p.X);
            float maxX = pts.Max(p => p.X);
            float minY = pts.Min(p => p.Y);
            float maxY = pts.Max(p => p.Y);

            float w = maxX - minX;
            float h = maxY - minY;

            // 让 x 为短边
            if (w > h) { float t = w; w = h; h = t; }

            // 强制 2:3 高宽比
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

        // 几何点
        public struct PointF { public float X, Y; public PointF(float x, float y) { X = x; Y = y; } }
        // 旋转矩形
        public struct RotatedRect { public float CenterX, CenterY, Width, Height, Angle; }

        // 把 XAnyLabelingDTO → VidiBlueReadDTO
        public static List<VidiBlueReadDTO> ConvertToBlue(XAnyLabelingDTO src)
        {
            // 图片
            string base64 = StripDataURI(src.imageData ?? "");
            byte[] pngBytes = Convert.FromBase64String(base64);
            string timeStamp = DateTime.Now.ToString("yyyyMMdd_HHmmssfff");

            var result = new List<VidiBlueReadDTO>();

            if (src.shapes == null) return result;

            // 遍历所有 rotation 标注
            foreach (var poly in src.shapes)
            {
                if (poly.shape_type != "rotation" || poly.points == null || poly.points.Count < 3)
                    continue;   // 跳过非 rotation 或点数不够的形状

                // 四点 → 旋转矩形
                var pts = poly.points.Select(p => new PointF(p[0], p[1])).ToList();
                RotatedRect rr = PolygonToRotatedRect(pts);   // 你的工具方法

                result.Add(new VidiBlueReadDTO
                {
                    ImageBytes = pngBytes,
                    FileName   = $"{timeStamp}_{result.Count}.png", // 避免重名
                    Label      = poly.label ?? "",
                    CenterX    = rr.CenterX,
                    CenterY    = rr.CenterY,
                    Width      = rr.Width,
                    Height     = rr.Height,
                    Angle      = rr.Angle
                });
            }

            if (result.Count == 0)
                throw new InvalidDataException("未找到任何 rotation 标注");

            return result;
        }
        #endregion 工具函数
    }
}