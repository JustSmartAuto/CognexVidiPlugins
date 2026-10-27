## XAnyLabel.VPlugin插件

### 参数
1. .net 4.7.2
2. csharp 12.0

### 架构
1. 入口: Program.cs
2. 主窗口: MainWindow.xaml.cs
3. vidi工具选择器: SelectVidiTool.cs
4. 导入图片到数据库: ImportImgAndApplyROITool.cs
5. 导入xanylabeling标签: ImportXAnyLabelTool.cs 
6. vidi操作高层封装: VidiSharpHAL.cs

### 编译
```sh
dotnet build
```