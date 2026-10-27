// 文件: TextBrowserWinExt.cs
// 功能: 提供小工具

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

// 图像处理
using ImageMagick;

// 数据库
using Microsoft.Data.Sqlite;

// Vidi
using ViDi.NET.Interfaces.training;
using ViDi2.Common.Utilities;
using ViDi2.Data;
using ViDi2.Properties;
using ViDi2.Runtime;
using ViDi2.Training;
using ViDi2.Local;
using ViDi2; 
using ViDi2.Common; 

// 屏蔽警告
#pragma warning disable CS0618

namespace JusNet472Template
{
    public partial class ExportDatabaseSummaryTool
    {
        #region 通用辅助
        // 文件夹选择器
        private string SelectFolder(string initial = null)
        {
            var openDlg = new Microsoft.Win32.SaveFileDialog
            {
                Title = "选择文件夹",
                FileName = "test.db",
                Filter = "文件夹|.:.",
                CheckFileExists = false,
                CheckPathExists = true,
                ValidateNames = false,
                InitialDirectory = initial ?? Path.Combine("D:\\JustSmart", "AppCache", "ViDiInfo")
            };
            if (openDlg.ShowDialog() == true)
                return Path.GetDirectoryName(openDlg.FileName);
            return null;
        }

        // 获取数据库路径
        private string GetDbPath(string toolName) =>
            Path.Combine("D:\\JustSmart\\AppCache\\ViDiInfo",
                         $"{toolName}_labels.sqlite3");

        // 打开数据库
        private SqliteConnection OpenDb(string toolName)
        {
            var conn = new SqliteConnection($"Data Source={GetDbPath(toolName)}");
            conn.Open();
            return conn;
        }

        private void EnsureTable(SqliteConnection conn)
        {
            const string sql = @"
CREATE TABLE IF NOT EXISTS samples(
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    name TEXT NOT NULL,
    tool TEXT NOT NULL,
    tool_type TEXT NOT NULL,
    image BLOB NOT NULL,
    json TEXT NOT NULL,
    updated_at TEXT NOT NULL
);";
            using (var cmd = new SqliteCommand(sql, conn))
                cmd.ExecuteNonQuery();
        }

        // 数据结构
        private class ImportDto
        {
            public string name { get; set; }
            public string tool { get; set; }
            public string tool_type { get; set; }
            public string tool_param { get; set; }
            public List<string> labels { get; set; }
        }

        // 把数据库里指定视图的原图导出为 PNG 字节数组
        public static byte[] ViewToPng(IDatabase db, ViewKey viewKey, FrameKey frameKey)
        {
            // 1. 从数据库取原图（注意：IImage 实现了 IDisposable）
            using IImage rawImg = db.GetImage(frameKey, format: "",  // 空字符串表示“默认通道、不缩放”
                                                width: 0);                     // 0 表示“原尺寸”

            // 2. IImage -> 内存流（ViDi 自带 PNG 编码器）
            using var viDiMs = new MemoryStream();
            rawImg.Save(viDiMs, ViDi2.ImageFormat.PNG);
            viDiMs.Position = 0;   // 复位指针

            // 3. 如果只需要 PNG 字节，到这一步就可以直接返回了
            // return viDiMs.ToArray();

            // 4. 若还想用 MagickImage 再做一次处理（压缩、改格式、加水印等）
            using var magick = new MagickImage(viDiMs);
            magick.Format = MagickFormat.Png;

            using var outMs = new MemoryStream();
            magick.Write(outMs);
            return outMs.ToArray();
        }
        #endregion 通用辅助
    }

}