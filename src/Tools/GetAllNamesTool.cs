// 文件: GetAllNamesTool.cs
// 功能: 获取所有workspace, stream, tool的名称并存储到全局字典

// 标准库
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using Microsoft.Win32;

namespace JusNet472Template
{
    public partial class PluginMainWindow
    {
        /// <summary>
        /// 获取所有 Workspace → Stream → Tool 的层级名称，并以嵌套字典形式返回
        /// </summary>
        /// <param name="control">ViDi 训练控制接口</param>
        /// <returns>
        /// 字典结构：
        /// Key   : workspace 名称
        /// Value : 字典
        ///         Key   : stream 名称
        ///         Value : List&lt;string&gt; 该流下的所有工具名称
        /// </returns>
        public static Dictionary<string, Dictionary<string, List<string>>>
            GetWorkspaceStreamToolDict(ViDi2.Training.IControl control)
        {
            var result =
                new Dictionary<string, Dictionary<string, List<string>>>(
                    StringComparer.OrdinalIgnoreCase);

            if (control == null)
                return result;

            // 遍历所有工作空间
            foreach (var ws in control.Workspaces)
            {
                var wsName = ws.DisplayName ?? string.Empty;
                if (string.IsNullOrEmpty(wsName))
                    continue;

                // 判断工作空间是否已打开
                if (ws == null) break;
                if (!ws.IsOpen) break;

                var streamDict = new Dictionary<string, List<string>>(
                                    StringComparer.OrdinalIgnoreCase);

                // 遍历该工作空间下的所有流
                foreach (var st in ws.Streams)
                {
                    var stName = st.Name ?? string.Empty;
                    if (string.IsNullOrEmpty(stName))
                        continue;

                    // 收集该流下所有工具名称
                    var toolNames = st.Tools
                                      .Select(t => t.Name)
                                      .Where(n => !string.IsNullOrEmpty(n))
                                      .ToList();

                    streamDict[stName] = toolNames;
                }

                if (streamDict.Count > 0)
                    result[wsName] = streamDict;
            }

            return result;
        }
    }
}