// 文件: OpenWorkspace.cs
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
        /// <summary>
        /// 获取工作空间名称列表
        /// </summary>
        public static bool vidi_training_list_workspace(
            // 固定参数
            string workspace_name, string stream_name, string tool_name,
            // 控制接口
            ViDi2.Training.IControl _control,
            // 返回值
            out List<string> workspace_list)
        {
            workspace_list = _control.Workspaces
                                     .Select(ws => ws.DisplayName)
                                     .ToList();
            return true;
        }

        /// <summary>
        /// 打开指定工作空间（若已打开则直接返回）
        /// </summary>
        public static bool vidi_training_open_workspace(
            string workspace_name,
            // 预留，暂未使用
            string stream_name,        
            // 预留，暂未使用
            string tool_name,          
            ViDi2.Training.IControl _control,
            out ViDi2.Training.IWorkspace workspace)
        {
            workspace = null;

            if (string.IsNullOrEmpty(workspace_name))
                return false;

            // 1. 先在工作空间集合里找
            workspace = _control.Workspaces
                                .FirstOrDefault(ws => ws.DisplayName == workspace_name);
            if (workspace == null)
                return false;

            // 2. 如果已经打开，直接返回成功
            if (workspace.IsOpen)
                return true;

            // 3. 真正打开
            // 此时不会再抛“已存在”异常
            workspace.Open();   
            return true;
        }

    }

}