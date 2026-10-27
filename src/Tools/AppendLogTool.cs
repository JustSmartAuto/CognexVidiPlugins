// 文件: AppendLogTool.cs
// 功能: 在日志输出区追加日志信息

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
    public partial class PluginMainWindow
    {
        /// <summary>
        /// 在日志区追加一行带时间戳的信息
        /// </summary>
        private void AppendLog(string log)
        {
            var ts = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            OutputBox.AppendText($"[{ts}] {log}\r\n");
            OutputBox.ScrollToEnd();
        }
    }

    /// <summary>
    /// 全局日志单例
    /// </summary>
    public static class LogMgr
    {
        // 弱引用，防止窗口关闭后仍被持有
        private static WeakReference<PluginMainWindow> _win;

        // 注册窗口（在 PluginMainWindow 构造函数或 Loaded 事件里调用一次即可）
        public static void Register(PluginMainWindow window)
        {
            _win = new WeakReference<PluginMainWindow>(window);
        }

        // 取消注册（可选，在窗口 Closed 事件里调用）
        public static void UnRegister() => _win = null;

        public static void Info(string msg) => Write("INFO", msg);
        public static void Warn(string msg) => Write("WARN", msg);
        public static void Error(string msg) => Write("ERROR", msg);

        private static void Write(string level, string msg)
        {
            if (_win == null) return;

            if (_win.TryGetTarget(out var w) && w.OutputBox != null)
            {
                var ts = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                var txt = $"[{ts}] [{level}] {msg}{Environment.NewLine}";

                // 确保 UI 线程
                if (w.OutputBox.CheckAccess())
                {
                    w.OutputBox.AppendText(txt);
                    w.OutputBox.ScrollToEnd();
                }
                else
                {
                    w.OutputBox.Dispatcher.BeginInvoke((Action)(() =>
                    {
                        w.OutputBox.AppendText(txt);
                        w.OutputBox.ScrollToEnd();
                    }));
                }
            }
        }
    }

}