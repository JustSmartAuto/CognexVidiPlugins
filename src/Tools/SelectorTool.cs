// 文件: SelectorTool.cs
// 功能: 处理选择器事件

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace JusNet472Template
{
    public partial class PluginMainWindow
    {
        /// <summary>
        /// 缓存最近一次获取的层级关系
        /// </summary>
        public Dictionary<string, Dictionary<string, List<string>>> _wsStToolDict;

        /// <summary>
        /// 刷新按钮点击：重新获取字典并更新选择器
        /// </summary>
        public void BtnRefreshSelector_Click(object sender, RoutedEventArgs e)
        {
            AppendLog("开始刷新选择器...");

            try
            {
                // 1. 获取字典
                _wsStToolDict = GetWorkspaceStreamToolDict(this._control);

                if (_wsStToolDict == null || _wsStToolDict.Count == 0)
                {
                    AppendLog("警告：未获取到任何 Workspace/Stream/Tool 信息！");
                    return;
                }

                AppendLog($"成功获取 {_wsStToolDict.Count} 个 Workspace");

                // 2. 更新选择器
                FillSelectors();
                AppendLog("选择器刷新完成");
            }
            catch (Exception ex)
            {
                AppendLog($"刷新失败：{ex.Message}");
            }
        }

        /// <summary>
        /// 根据缓存字典填充三个 ComboBox
        /// </summary>
        public void FillSelectors()
        {
            // 保存当前选中项，便于刷新后尽量恢复
            var wsOld = CbWorkspace.SelectedItem as string;
            var stOld = CbStream.SelectedItem as string;
            var tlOld = CbTool.SelectedItem as string;

            // 清空
            CbWorkspace.ItemsSource = null;
            CbStream.ItemsSource = null;
            CbTool.ItemsSource = null;

            // 1. 填充 Workspace
            var wsNames = _wsStToolDict.Keys.OrderBy(n => n).ToList();
            CbWorkspace.ItemsSource = wsNames;

            // 尝试恢复选中
            if (wsNames.Contains(wsOld))
            {
                CbWorkspace.SelectedItem = wsOld;
                AppendLog($"恢复 Workspace 选择：{wsOld}");
            }
            else if (wsNames.Count > 0)
            {
                CbWorkspace.SelectedIndex = 0;
            }

            // 2. 根据 Workspace 联动 Stream
            RefreshStreamCombo(wsOld);
            // 3. 根据 Stream 联动 Tool
            RefreshToolCombo(stOld);
        }

        /// <summary>
        /// 根据当前选中 Workspace 刷新 Stream 列表
        /// </summary>
        private void RefreshStreamCombo(string preferSelected = null)
        {
            CbStream.ItemsSource = null;

            var ws = CbWorkspace.SelectedItem as string;
            if (string.IsNullOrEmpty(ws) || !_wsStToolDict.ContainsKey(ws))
                return;

            var stNames = _wsStToolDict[ws].Keys.OrderBy(n => n).ToList();
            CbStream.ItemsSource = stNames;

            if (stNames.Contains(preferSelected))
                CbStream.SelectedItem = preferSelected;
            else if (stNames.Count > 0)
                CbStream.SelectedIndex = 0;
        }

        /// <summary>
        /// 根据当前选中 Stream 刷新 Tool 列表
        /// </summary>
        private void RefreshToolCombo(string preferSelected = null)
        {
            CbTool.ItemsSource = null;

            var ws = CbWorkspace.SelectedItem as string;
            var st = CbStream.SelectedItem as string;
            if (string.IsNullOrEmpty(ws) || string.IsNullOrEmpty(st) ||
                !_wsStToolDict.ContainsKey(ws) ||
                !_wsStToolDict[ws].ContainsKey(st))
                return;

            var tlNames = _wsStToolDict[ws][st].OrderBy(n => n).ToList();
            CbTool.ItemsSource = tlNames;

            if (tlNames.Contains(preferSelected))
                CbTool.SelectedItem = preferSelected;
            else if (tlNames.Count > 0)
                CbTool.SelectedIndex = 0;
        }

        /// <summary>
        /// 获取当前选择器中的 Workspace / Stream / Tool 名称
        /// </summary>
        /// <param name="workspace_name">返回选中的 Workspace 名称</param>
        /// <param name="stream_name">返回选中的 Stream 名称</param>
        /// <param name="tool_name">返回选中的 Tool 名称</param>
        /// <returns>三者均非空则返回 true；任一为空返回 false</returns>
        public bool GetSelected(out string workspace_name,
                                out string stream_name,
                                out string tool_name)
        {
            workspace_name = CbWorkspace.SelectedItem as string;
            stream_name  = CbStream.SelectedItem as string;
            tool_name    = CbTool.SelectedItem as string;

            return !string.IsNullOrEmpty(workspace_name) &&
                !string.IsNullOrEmpty(stream_name)   &&
                !string.IsNullOrEmpty(tool_name);
        }

        /* ===================== 事件绑定 ===================== */
        private void CbWorkspace_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RefreshStreamCombo();
        }

        private void CbStream_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var st = CbStream.SelectedItem as string;
            if (st == null) return;
            AppendLog($"选中 Stream: {st}");
            RefreshToolCombo();
        }

        private void CbTool_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var tl = CbTool.SelectedItem as string;
            if (tl == null) return;
            AppendLog($"选中 Tool: {tl}");
        }
    }
}