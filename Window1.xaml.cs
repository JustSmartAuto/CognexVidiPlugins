// 文件: Windows1.xaml.cs
// 功能: vidi插件主窗口

// 标准库 
using System;
using System.Reflection;
using System.Windows;

namespace JusNet472Template
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        // 点击“确定”关闭窗口
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}