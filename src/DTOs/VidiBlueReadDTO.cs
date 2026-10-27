// 文件: VidiBlueReadDTO.cs
// ViDi 2.1 蓝色工具（BlueRead）训练样本 DTO
// 字段名与 SDK 文档保持一致，可直接用于 ITool.ImportSamples
using System;

namespace JusNet472Template
{
    [Serializable]
    public class VidiBlueReadDTO
    {
        public byte[] ImageBytes; // png/jpg 二进制
        public string FileName;   // 仅做标识
        public string Label;      // 字符串内容，可空
        public float  CenterX;    // 旋转矩形中心 x
        public float  CenterY;    // 旋转矩形中心 y
        public float  Width;      // 短边（x 轴）
        public float  Height;     // 长边（高:宽 = 2:3）
        public float  Angle;      // 旋转角（度，顺时针为正）
    }
}