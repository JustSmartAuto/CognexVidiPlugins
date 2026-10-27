// 文件: SelectFolderViaFile.cs
// 功能: 通过选择文件以选择文件夹, WPF

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

// 屏蔽警告
#pragma warning disable CS8632

namespace JusNet472Template
{
    /// <summary>
    /// 提供一个静态方法：弹出文件选择框，返回所选文件所在的文件夹路径；
    /// 用户取消则返回 null。
    /// </summary>
    public static class FolderPicker
    {
        /// <summary>
        /// 调用即弹出文件选择器，返回文件夹路径或 null。
        /// 线程模型：STA（WPF 对话框要求）
        /// </summary>
        public static string PickFolderViaFile()
        {
            // 如果当前线程不是 STA，则启动一个 STA 线程来跑对话框
            if (System.Threading.Thread.CurrentThread.GetApartmentState() != System.Threading.ApartmentState.STA)
            {
                string? result = null;
                var thread = new System.Threading.Thread(() => result = InternalPick());
                thread.SetApartmentState(System.Threading.ApartmentState.STA);
                thread.Start();
                thread.Join();
                return result;
            }

            // 当前已是 STA，直接跑
            return InternalPick();
        }

        private static string? InternalPick()
        {
            var dlg = new OpenFileDialog
            {
                Title = "请选择目标文件夹下的任意一个文件",
                CheckFileExists = true,
                Multiselect = false
            };

            bool? ok = dlg.ShowDialog();
            return ok == true ? Path.GetDirectoryName(dlg.FileName) : null;
        }
    }

    /* 如果你偶尔还想“弹个窗口”而不是纯方法，下面给一个小窗壳，可删 */
    public class SelectFolderViaFileWindow : Window
    {
        private readonly TextBox _pathBox;
        public string SelectedFolder => _pathBox.Text;

        public SelectFolderViaFileWindow()
        {
            Title = "选文件→取文件夹";
            Width = 420; Height = 120;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            var grid = new Grid { Margin = new Thickness(10) };
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            _pathBox = new TextBox { IsReadOnly = true, Margin = new Thickness(0, 0, 0, 10) };
            Grid.SetRow(_pathBox, 0);
            grid.Children.Add(_pathBox);

            var btn = new Button
            {
                Content = "选择文件并定位其所在文件夹",
                Padding = new Thickness(20, 6, 20, 6),
                HorizontalAlignment = HorizontalAlignment.Left
            };
            btn.Click += (s, e) => _pathBox.Text = FolderPicker.PickFolderViaFile();
            Grid.SetRow(btn, 1);
            grid.Children.Add(btn);

            Content = grid;
        }
    }
}