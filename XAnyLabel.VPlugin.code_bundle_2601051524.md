# XAnyLabel.VPlugin.code_2601022029 C# Source Bundle

**XAnyLabel.VPlugin.code_2512310845/Properties/AssemblyInfo.cs**
```csharp
﻿// #region Using directives

// using System;
// using System.Reflection;
// using System.Runtime.InteropServices;

// #endregion

// // General Information about an assembly is controlled through the following 
// // set of attributes. Change these attribute values to modify the information
// // associated with an assembly.
// [assembly: AssemblyTitle("JusOcrTest")]
// [assembly: AssemblyDescription("")]
// [assembly: AssemblyConfiguration("")]
// [assembly: AssemblyCompany("")]
// [assembly: AssemblyProduct("JusOcrTest")]
// [assembly: AssemblyCopyright("Copyright 2025")]
// [assembly: AssemblyTrademark("")]
// [assembly: AssemblyCulture("")]

// // This sets the default COM visibility of types in the assembly to invisible.
// // If you need to expose a type to COM, use [ComVisible(true)] on that type.
// [assembly: ComVisible(false)]

// // The assembly version has following format :
// //
// // Major.Minor.Build.Revision
// //
// // You can specify all the values or you can use the default the Revision and 
// // Build Numbers by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.0")]

```

**XAnyLabel.VPlugin.code_2512310845/Properties/WPFAssemblyInfo.cs**
```csharp
﻿#region Using directives

using System.Resources;
using System.Windows;

#endregion



//In order to begin building localizable applications, set 
//<UICulture>CultureYouAreCodingWith</UICulture> in your .csproj file
//inside a <PropertyGroup>.  For example, if you are using US english
//in your source files, set the <UICulture> to en-US.  Then uncomment
//the NeutralResourceLanguage attribute below.  Update the "en-US" in
//the line below to match the UICulture setting in the project file.

//[assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)]


[assembly: ThemeInfo(
    ResourceDictionaryLocation.None, //where theme specific resource dictionaries are located
    //(used if a resource is not found in the page, 
    // or application resource dictionaries)
    ResourceDictionaryLocation.SourceAssembly //where the generic resource dictionary is located
    //(used if a resource is not found in the page, 
    // app, or any theme specific resource dictionaries)
)]

```

**XAnyLabel.VPlugin.code_2512310845/XAnyLabelVPlugin.csproj**
```xml
﻿<Project Sdk="Microsoft.NET.Sdk.WindowsDesktop">

  <!-- 项目设置 -->
  <PropertyGroup>
    <PlatformTarget>x64</PlatformTarget>
    <TargetFramework>net472</TargetFramework>
    <UseWPF>true</UseWPF>
    <RootNamespace>JusXAnyLabel.VPlugin</RootNamespace>
    <AssemblyName>JusXAnyLabel.VPlugin</AssemblyName>
    <ApplicationIcon>assets/star_round.ico</ApplicationIcon>
  </PropertyGroup>

  <!-- 语言设置 -->
  <PropertyGroup>
    <LangVersion>12.0</LangVersion>
    <AllowUnsafeBlocks>True</AllowUnsafeBlocks>
  </PropertyGroup>

  <ItemGroup>
    <!-- 接口 -->
    <Reference Include="ViDi.NET.Interfaces">
      <HintPath>./libs/ViDi.NET.Interfaces.dll</HintPath>
    </Reference>

    <Reference Include="ViDi.NET.Training.UI.Interfaces">
      <HintPath>./libs/ViDi.NET.Training.UI.Interfaces.dll</HintPath>
    </Reference>

    <Reference Include="ViDi.NET.UI.Interfaces">
      <HintPath>./libs/ViDi.NET.UI.Interfaces.dll</HintPath>
    </Reference>

    <!-- 组件 -->
    <Reference Include="ViDi.NET">
      <HintPath>./libs/ViDi.NET.dll</HintPath>
    </Reference>

    <Reference Include="ViDi.NET.UI">
      <HintPath>./libs/ViDi.NET.UI.dll</HintPath>
    </Reference>

    <Reference Include="ViDi.NET.Local.UI">
      <HintPath>./libs/ViDi.NET.Local.dll</HintPath>
    </Reference>

    <Reference Include="ViDi.NET.Common.UI">
      <HintPath>./libs/ViDi.NET.Common.dll</HintPath>
    </Reference>

    <Reference Include="ViDi.NET.Data.UI">
      <HintPath>./libs/ViDi.NET.Data.dll</HintPath>
    </Reference>

    <Reference Include="ViDi.NET.Training.UI">
      <HintPath>./libs/ViDi.NET.Training.UI.dll</HintPath>
    </Reference>

    <!-- 微软库 -->
    <Reference Include="Microsoft.CSharp">
      <HintPath>./libs/Microsoft.CSharp.dll</HintPath>
    </Reference>

    <!-- 第三方库 -->
    <Reference Include="Newtonsoft.Json">
      <HintPath>./libs/Newtonsoft.Json.dll</HintPath>
    </Reference>

    <Reference Include="Magick.NET-Q16-AnyCPU, Version=7.14.5.0, Culture=neutral">
      <HintPath>./libs/Magick.NET-Q16-AnyCPU.dll</HintPath>
    </Reference>

  </ItemGroup>

  <!-- 数据库 -->
  <ItemGroup>
      <!-- SQLite 官方 ADO.NET Provider -->
      <Reference Include="Microsoft.Data.Sqlite">
        <HintPath>libs\sqlite3\Microsoft.Data.Sqlite.dll</HintPath>
      </Reference>

      <!-- SQLitePCLRaw 核心运行时 -->
      <Reference Include="SQLitePCLRaw.core">
        <HintPath>libs\sqlite3\SQLitePCLRaw.core.dll</HintPath>
      </Reference>

      <!-- 动态 cdecl 调用提供程序 -->
      <Reference Include="SQLitePCLRaw.provider.dynamic_cdecl">
        <HintPath>libs\sqlite3\SQLitePCLRaw.provider.dynamic_cdecl.dll</HintPath>
      </Reference>

      <!-- batteries_v2：初始化 SQLitePCLRaw 的“电池” -->
      <Reference Include="SQLitePCLRaw.batteries_v2">
        <HintPath>libs\sqlite3\SQLitePCLRaw.batteries_v2.dll</HintPath>
      </Reference>

      <!-- 原生 SQLite 引擎（必须随包部署） -->
      <Reference Include="e_sqlite3">
        <HintPath>libs\sqlite3\e_sqlite3.dll</HintPath>
        <Private>true</Private>
      </Reference>

      <!--  原生 SQLite 引擎  -->
      <None Include="libs\sqlite3\e_sqlite3.dll">
        <Link>e_sqlite3.dll</Link>
        <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
      </None>

      <!-- 依赖的 System.* 程序集 -->
      <Reference Include="System.Buffers">
        <HintPath>libs\sqlite3\System.Buffers.dll</HintPath>
      </Reference>

      <Reference Include="System.Memory">
        <HintPath>libs\sqlite3\System.Memory.dll</HintPath>
      </Reference>

      <Reference Include="System.Numerics.Vectors">
        <HintPath>libs\sqlite3\System.Numerics.Vectors.dll</HintPath>
      </Reference>

      <Reference Include="System.Runtime.CompilerServices.Unsafe">
        <HintPath>libs\sqlite3\System.Runtime.CompilerServices.Unsafe.dll</HintPath>
      </Reference>
    </ItemGroup>

    <!-- 递归包含目录下的所有文件 -->
    <ItemGroup>
        <!-- dll文件 -->
        <Content Include="libs\**\*">
          <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
        </Content>

        <!-- 资源文件 -->
        <Content Include="assets\**\*">
          <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
        </Content>
    </ItemGroup>

</Project>
```

**XAnyLabel.VPlugin.code_2512310845/include/vidi.cs**
```csharp
/** 
 * @file vidi.cs
 * @brief C# wrapper for the ViDi library containing common functions for runtime and training API
 * @author (c) 2012-2022 by Cognex Corporation
 * @version 6.1.1
 * 
 * This file contains P/Invoke declarations and wrapper classes for the ViDi C++ library.
 * All functions, structures, constants, and enums have been converted to their C# equivalents
 * while maintaining compatibility with C# 7.3 syntax.
 */

using System;
using System.Runtime.InteropServices;

namespace Cognex.ViDi
{
    /// <summary>
    /// Main class containing P/Invoke declarations for the ViDi library
    /// </summary>
    /// <summary>
    /// 包含ViDi库的P/Invoke声明的主类
    /// </summary>
    public static class ViDiNative
    {
        private const string ViDiDll = "vidi_61.dll"; // Adjust this to your actual DLL name

        // Basic type definitions
        /// <summary>
        /// null terminated char array
        /// </summary>
        /// <summary>
        /// 以null结尾的字符数组
        /// </summary>
        public const string VIDI_STRING = "null terminated char array";
        
        /// <summary>
        /// unsigned unsigned char (8 bits)
        /// </summary>
        /// <summary>
        /// 无符号字符型（8位）
        /// </summary>
        public const string VIDI_UCHAR = "unsigned char (8 bits)";
        
        /// <summary>
        /// unsigned int (64 bits)
        /// </summary>
        /// <summary>
        /// 无符号整型（64位）
        /// </summary>
        public const string VIDI_UINT64 = "unsigned int (64 bits)";
        
        /// <summary>
        /// unsigned int (32 bits)
        /// </summary>
        /// <summary>
        /// 无符号整型（32位）
        /// </summary>
        public const string VIDI_UINT = "unsigned int (32 bits)";
        
        /// <summary>
        /// int (32 bits)
        /// </summary>
        /// <summary>
        /// 整型（32位）
        /// </summary>
        public const string VIDI_INT = "int (32 bits)";
        
        /// <summary>
        /// float (32 bits)
        /// </summary>
        /// <summary>
        /// 单精度浮点型（32位）
        /// </summary>
        public const string VIDI_FLOAT = "float (32 bits)";
        
        /// <summary>
        /// double (64 bits)
        /// </summary>
        /// <summary>
        /// 双精度浮点型（64位）
        /// </summary>
        public const string VIDI_DOUBLE = "double (64 bits)";

        // Error codes
        /// <summary>
        /// Operation completed successfuly
        /// </summary>
        /// <summary>
        /// 操作成功完成
        /// </summary>
        public const uint VIDI_SUCCESS = 0;
        
        /// <summary>
        /// Operation did not complete due to an unexpected error
        /// </summary>
        /// <summary>
        /// 由于意外错误，操作未完成
        /// </summary>
        public const uint VIDI_RUNTIME_ERROR = 1000;
        
        /// <summary>
        /// Operation did not complete due to a logic error
        /// </summary>
        /// <summary>
        /// 由于逻辑错误，操作未完成
        /// </summary>
        public const uint VIDI_LOGIC_ERROR = 2000;
        
        /// <summary>
        /// Operation did not complete due to an invalid object reference
        /// </summary>
        /// <summary>
        /// 由于无效的对象引用，操作未完成
        /// </summary>
        public const uint VIDI_NOT_FOUND_ERROR = 3000;
        
        /// <summary>
        /// Operation did not complete due to an invalid argument
        /// </summary>
        /// <summary>
        /// 由于无效的参数，操作未完成
        /// </summary>
        public const uint VIDI_INVALID_ARGUMENT_ERROR = 4000;
        
        /// <summary>
        /// A filter parsing operation failed
        /// </summary>
        /// <summary>
        /// 过滤器解析操作失败
        /// </summary>
        public const uint VIDI_FILTER_PARSE_ERROR = 4500;
        
        /// <summary>
        /// Operation is not available or not supported
        /// </summary>
        /// <summary>
        /// 操作不可用或不受支持
        /// </summary>
        public const uint VIDI_INVALID_OPERATION_ERROR = 5000;
        
        /// <summary>
        /// Operation did not complete because a buffer, an image, or the library have not been initialized prior to the function's call
        /// </summary>
        /// <summary>
        /// 由于缓冲区、图像或库在函数调用前未初始化，操作未完成
        /// </summary>
        public const uint VIDI_NOT_INITIALIZED_ERROR = 6000;

        // Image format constants
        /// <summary>
        /// 8 bits images
        /// </summary>
        /// <summary>
        /// 8位图像
        /// </summary>
        public const uint VIDI_IMG_8U = 0;
        
        /// <summary>
        /// 16 bits images
        /// </summary>
        /// <summary>
        /// 16位图像
        /// </summary>
        public const uint VIDI_IMG_16U = 1;

        // Image format constants
        /// <summary>
        /// PNG image format
        /// </summary>
        /// <summary>
        /// PNG图像格式
        /// </summary>
        public const uint VIDI_IMAGE_FORMAT_PNG = 1;
        
        /// <summary>
        /// BMP image format
        /// </summary>
        /// <summary>
        /// BMP图像格式
        /// </summary>
        public const uint VIDI_IMAGE_FORMAT_BMP = 2;
        
        /// <summary>
        /// JPEG image format
        /// </summary>
        /// <summary>
        /// JPEG图像格式
        /// </summary>
        public const uint VIDI_IMAGE_FORMAT_JPEG = 3;
        
        /// <summary>
        /// TIFF image format
        /// </summary>
        /// <summary>
        /// TIFF图像格式
        /// </summary>
        public const uint VIDI_IMAGE_FORMAT_TIFF = 4;

        // Model type constants
        /// <summary>
        /// Node model type
        /// </summary>
        /// <summary>
        /// 节点模型类型
        /// </summary>
        public const uint VIDI_MODEL_TYPE_NODE = 0;
        
        /// <summary>
        /// Regex model type
        /// </summary>
        /// <summary>
        /// 正则表达式模型类型
        /// </summary>
        public const uint VIDI_MODEL_TYPE_REGEX = 1;
        
        /// <summary>
        /// String model type
        /// </summary>
        /// <summary>
        /// 字符串模型类型
        /// </summary>
        public const uint VIDI_MODEL_TYPE_STRING = 2;
        
        /// <summary>
        /// Layout model type
        /// </summary>
        /// <summary>
        /// 布局模型类型
        /// </summary>
        public const uint VIDI_MODEL_TYPE_LAYOUT = 3;

        // Debug sink constants
        /// <summary>
        /// redirects the debug log to the console
        /// </summary>
        /// <summary>
        /// 将调试日志重定向到控制台
        /// </summary>
        public const uint VIDI_DEBUG_SINK_CONSOLE = 0;
        
        /// <summary>
        /// redirects the debug log to a file
        /// </summary>
        /// <summary>
        /// 将调试日志重定向到文件
        /// </summary>
        /// <summary>
        /// 将调试日志重定向到文件
        /// </summary>
        public const uint VIDI_DEBUG_SINK_FILE = 1;
        
        /// <summary>
        /// stops the debug log
        /// </summary>
        /// <summary>
        /// 停止调试日志
        /// </summary>
        public const uint VIDI_DEBUG_STOP = 2;
        
        /// <summary>
        /// redirects the debug log to a file
        /// </summary>
        public const uint VIDI_DEBUG_SINK_DEBUG_FILE = 3;
        
        /// <summary>
        /// internal use only
        /// </summary>
        /// <summary>
        /// 仅限内部使用
        /// </summary>
        /// <summary>
        /// 仅限内部使用
        /// </summary>
        public const uint VIDI_DEBUG_DEVEL_CONSOLE = 20;

        // GPU device constants
        /// <summary>
        /// automatically connects to all gpu devices
        /// </summary>
        /// <summary>
        /// 自动连接到所有GPU设备
        /// </summary>
        public const string VIDI_AUTO_SELECT_GPU_DEVICE = "";
        
        /// <summary>
        /// initializes with no gpu support
        /// </summary>
        /// <summary>
        /// 在无GPU支持下初始化
        /// </summary>
        public const int VIDI_GPU_MODE_NO_SUPPORT = -1;
        
        /// <summary>
        /// initializes the library with no devices support
        /// </summary>
        /// <summary>
        /// 在无设备支持下初始化库
        /// </summary>
        public const int VIDI_DEFER_COMPUTE_DEVICE_INITIALIZATION = 2;
        
        /// <summary>
        /// Initalizes the gpu devices, favoring throughput
        /// </summary>
        /// <summary>
        /// 初始化GPU设备，优先考虑吞吐量
        /// </summary>
        public const int VIDI_GPU_SINGLE_DEVICE_PER_TOOL = 0;
        
        /// <summary>
        /// Initalizes the gpu devices, favoring low latency for red tools.
        /// </summary>
        /// <summary>
        /// 初始化GPU设备，优先考虑红色工具的低延迟
        /// </summary>
        public const int VIDI_GPU_MULTIPLE_DEVICES_PER_TOOL = 1;
    }

    /// <summary>
    /// Structure holding a generic data buffer
    /// </summary>
    /// <summary>
    /// 保存通用数据缓冲区的结构体
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct VIDI_BUFFER
    {
        /// <summary>
        /// size of the buffer (in bytes)
        /// </summary>
        /// <summary>
        /// 缓冲区大小（以字节为单位）
        /// </summary>
        public int size;
        
        /// <summary>
        /// char array of length size
        /// </summary>
        /// <summary>
        /// 长度为size的字符数组
        /// </summary>
        public IntPtr data;
    }

    /// <summary>
    /// Structure holding an image
    /// </summary>
    /// <summary>
    /// 保存图像的结构体
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct VIDI_IMAGE
    {
        /// <summary>
        /// width of the image
        /// </summary>
        /// <summary>
        /// 图像宽度
        /// </summary>
        public uint width;
        
        /// <summary>
        /// height of the image
        /// </summary>
        /// <summary>
        /// 图像高度
        /// </summary>
        public uint height;
        
        /// <summary>
        /// number of channels of the image (Supported number of channels 1-4)
        /// </summary>
        /// <summary>
        /// 图像的通道数（支持的通道数为1-4）
        /// </summary>
        public uint channels;
        
        /// <summary>
        /// image data
        /// </summary>
        /// <summary>
        /// 图像数据
        /// </summary>
        public IntPtr data;
        
        /// <summary>
        /// depth of a channel (VIDI_IMG_8U or VIDI_IMG_16U)
        /// </summary>
        /// <summary>
        /// 通道深度（VIDI_IMG_8U或VIDI_IMG_16U）
        /// </summary>
        public uint channel_depth;
        
        /// <summary>
        /// distance in memory between 2 pixels of the same column for 2 consecutive rows.
        /// Usually step is equal to width * the element size
        /// </summary>
        /// <summary>
        /// 内存中连续两行同一列像素之间的距离
        /// 通常步长等于宽度乘以元素大小
        /// </summary>
        public uint step;
    }

    /// <summary>
    /// Structure describing a region of interest
    /// Used to manually define a Region of Interest when using vidi_runtime_process_single_tool
    /// </summary>
    /// <summary>
    /// 描述感兴趣区域的结构体
    /// 用于在使用vidi_runtime_process_single_tool时手动定义感兴趣区域
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct VIDI_ROI
    {
        /// <summary>
        /// width of the ROI
        /// </summary>
        /// <summary>
        /// ROI的宽度
        /// </summary>
        public uint width;
        
        /// <summary>
        /// height of the ROI
        /// </summary>
        /// <summary>
        /// ROI的高度
        /// </summary>
        public uint height;
        
        /// <summary>
        /// offset in x of the ROI
        /// </summary>
        /// <summary>
        /// ROI在X方向的偏移量
        /// </summary>
        public uint offset_x;
        
        /// <summary>
        /// offset in y of the ROI
        /// </summary>
        /// <summary>
        /// ROI在Y方向的偏移量
        /// </summary>
        public uint offset_y;
        
        /// <summary>
        /// angle of the ROI
        /// </summary>
        /// <summary>
        /// ROI的角度
        /// </summary>
        public double angle;
    }

    /// <summary>
    /// Main class containing P/Invoke function declarations for the ViDi library
    /// </summary>
    /// <summary>
    /// 包含ViDi库的P/Invoke函数声明的主类
    /// </summary>
    public static class ViDiAPI
    {
        private const string ViDiDll = "vidi.dll"; // Adjust this to your actual DLL name

        /// <summary>
        /// Initializes the library
        /// </summary>
        /// <summary>
        /// 初始化库
        /// </summary>
        /// <param name="compute_mode">mode of operation</param>
        /// <param name="compute_devices">list of comma separated devices number to use in the library,</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        /// <remarks>
        /// If the list is empty, it uses all the available GPUs and no GPU if none are available
        /// If no license is available to decrypt the library, an error message created by the license service will be prompted. 
        /// This error message cannot be caught from the C library.
        /// </remarks>
        /// <remarks>
        /// 如果列表为空，则使用所有可用的GPU，如果没有可用GPU则不使用GPU
        /// 如果没有可用的许可证来解密库，许可证服务将提示错误消息
        /// 此错误消息无法从C库捕获
        /// </remarks>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_initialize(int compute_mode, [MarshalAs(UnmanagedType.LPStr)] string compute_devices);

        /// <summary>
        /// Initializes the compute devices
        /// </summary>
        /// <summary>
        /// 初始化计算设备
        /// </summary>
        /// <param name="compute_mode">mode of operation</param>
        /// <param name="compute_devices">list of comma separated devices number to use in the library,</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        /// <remarks>
        /// calling with VIDI_GPU_SINGLE_DEVICE_PER_TOOL or VIDI_GPU_MULTIPLE_DEVICES_PER_TOOL will initialize the cuda devices given by compute_devices
        /// calling with VIDI_GPU_MODE_NO_SUPPORT will uninitialize the cuda devices. This can be done only if no workspace is currently opened.
        /// If the list is empty, it uses all the available GPUs and no GPU if none are available
        /// </remarks>
        /// <remarks>
        /// 使用VIDI_GPU_SINGLE_DEVICE_PER_TOOL或VIDI_GPU_MULTIPLE_DEVICES_PER_TOOL调用将初始化由compute_devices指定的CUDA设备
        /// 使用VIDI_GPU_MODE_NO_SUPPORT调用将取消初始化CUDA设备。这只能在当前没有打开工作空间的情况下进行
        /// 如果列表为空，则使用所有可用的GPU，如果没有可用GPU则不使用GPU
        /// </remarks>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_initialize_compute_device(int compute_mode, [MarshalAs(UnmanagedType.LPStr)] string compute_devices);

        /// <summary>
        /// Initialize the optimized memory mode
        /// </summary>
        /// <summary>
        /// 初始化优化的内存模式
        /// </summary>
        /// <param name="size">(Bytes) reserved memory for computation on all the graphic cards</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        /// <remarks>
        /// 0 : deactivates optimized memory
        /// We advice not using optimized gpu memory when having a graphic card with less than 3 GB of memory.
        /// The default behavior is using optimized gpu-memory with 2-3 of available memory.
        /// This method cannot be called when gpu memory is in use, i.e. when a workspace is opened.
        /// </remarks>
        /// <remarks>
        /// 0：禁用优化内存
        /// 建议在使用少于3GB内存的显卡时不要使用优化的GPU内存
        /// 默认行为是使用优化的GPU内存，占用2-3GB的可用内存
        /// 当GPU内存正在使用时（即打开工作空间时），不能调用此方法
        /// </remarks>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_optimized_gpu_memory(ulong size);

        /// <summary>
        /// Deinitializes the library and frees all remaining buffers and images
        /// </summary>
        /// <summary>
        /// 反初始化库并释放所有剩余的缓冲区和图像
        /// </summary>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_deinitialize();

        /// <summary>
        /// Internal use only
        /// </summary>
        /// <summary>
        /// 仅限内部使用
        /// </summary>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_read_debug_infos(ref VIDI_BUFFER data, ref VIDI_BUFFER buffer);

        /// <summary>
        /// Control whether and where log messages are provided
        /// </summary>
        /// <summary>
        /// 控制是否提供日志消息以及提供的位置
        /// </summary>
        /// <param name="sink">logging output: VIDI_DEBUG_SINK_CONSOLE for console, VIDI_DEBUG_SINK_FILE for file, VIDI_DEBUG_SINK_STOP to stop the logging</param>
        /// <param name="filepath">set only with a sink VIDI_DEBUG_SINK_FILE. Set the file where the logs are written.</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        /// <param name="sink">日志输出：VIDI_DEBUG_SINK_CONSOLE表示控制台，VIDI_DEBUG_SINK_FILE表示文件，VIDI_DEBUG_SINK_STOP表示停止日志记录</param>
        /// <param name="filepath">仅在使用VIDI_DEBUG_SINK_FILE时设置。设置写入日志的文件。</param>
        /// <returns>如果通过返回0，否则返回可与vidi_get_error_message()一起使用的错误代码</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_debug_infos(uint sink, [MarshalAs(UnmanagedType.LPStr)] string filepath);

        /// <summary>
        /// Retrieve the version of the library
        /// </summary>
        /// <summary>
        /// 检索库的版本信息
        /// </summary>
        /// <param name="res_buffer">a pointer to a initialized buffer.</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        /// <remarks>
        /// Example output: &lt;version major='4' minor='1' revision='0' build='2340' type='Released'/&gt;
        /// </remarks>
        /// <remarks>
        /// 示例输出：&lt;version major='4' minor='1' revision='0' build='2340' type='Released'/&gt;
        /// </remarks>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_version(ref VIDI_BUFFER res_buffer);

        /// <summary>
        /// Get the error message corresponding to the error_number
        /// </summary>
        /// <summary>
        /// 获取与错误号对应的错误消息
        /// </summary>
        /// <param name="error_number">number returned by a failed method</param>
        /// <param name="res_buffer">pointer to a initialized buffer which will contain the error string</param>
        /// <returns>an error number that can be used with vidi_get_error_message()</returns>
        /// <remarks>
        /// Example output: &lt;error code='1000' type='runtime error'&gt;workspace is already used by another process&lt;/error&gt;
        /// </remarks>
        /// <remarks>
        /// 示例输出：&lt;error code='1000' type='runtime error'&gt;workspace is already used by another process&lt;/error&gt;
        /// </remarks>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_get_error_message(uint error_number, ref VIDI_BUFFER res_buffer);

        /// <summary>
        /// List the available CUDA devices in xml format
        /// </summary>
        /// <summary>
        /// 以XML格式列出可用的CUDA设备
        /// </summary>
        /// <param name="res_buffer">a pointer to a initialized buffer</param>
        /// <returns>an error number that can be used with vidi_get_error_message()</returns>
        /// <remarks>
        /// Example output: &lt;devices&gt;&lt;device index='0' id='GeForce GTX 660 Ti' type='cuda' version='3.0' mode='0' memory='2147483648' free_memory='1515806720'/&gt;&lt;/devices&gt;
        /// </remarks>
        /// <remarks>
        /// 示例输出：&lt;devices&gt;&lt;device index='0' id='GeForce GTX 660 Ti' type='cuda' version='3.0' mode='0' memory='2147483648' free_memory='1515806720'/&gt;&lt;/devices&gt;
        /// </remarks>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_list_compute_devices(ref VIDI_BUFFER res_buffer);

        // Buffer functions
        /// <summary>
        /// Initialize and register a buffer with the library
        /// </summary>
        /// <summary>
        /// 初始化缓冲区并在库中注册
        /// </summary>
        /// <param name="buffer">pointer on the buffer to initialize</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        /// <param name="buffer">指向要初始化的缓冲区的指针</param>
        /// <returns>如果通过返回0，否则返回可与vidi_get_error_message()一起使用的错误代码</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_init_buffer(ref VIDI_BUFFER buffer);

        /// <summary>
        /// Free the memory of the given buffer
        /// </summary>
        /// <summary>
        /// 释放给定缓冲区的内存
        /// </summary>
        /// <param name="buffer">Pointer on the buffer to free</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        /// <param name="buffer">指向要释放的缓冲区的指针</param>
        /// <returns>如果通过返回0，否则返回可与vidi_get_error_message()一起使用的错误代码</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_free_buffer(ref VIDI_BUFFER buffer);

        // Image functions
        /// <summary>
        /// Initialize and register an image with the library
        /// </summary>
        /// <summary>
        /// 初始化图像并在库中注册
        /// </summary>
        /// <param name="img">Pointer on the Image to initialize</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        /// <param name="img">指向要初始化的图像的指针</param>
        /// <returns>如果通过返回0，否则返回可与vidi_get_error_message()一起使用的错误代码</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_init_image(ref VIDI_IMAGE img);

        /// <summary>
        /// Gets an image from the global resource
        /// </summary>
        /// <summary>
        /// 从全局资源获取图像
        /// </summary>
        /// <param name="uuid">uuid of the image resource</param>
        /// <param name="img">pointer to an initialized image</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        /// <param name="uuid">图像资源的UUID</param>
        /// <param name="img">指向已初始化图像的指针</param>
        /// <returns>如果通过返回0，否则返回可与vidi_get_error_message()一起使用的错误代码</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_resource_get_image([MarshalAs(UnmanagedType.LPStr)] string uuid, ref VIDI_IMAGE img);

        /// <summary>
        /// Load an image from disk (PNG, BMP, TIFF or JPEG)
        /// </summary>
        /// <summary>
        /// 从磁盘加载图像（PNG、BMP、TIFF或JPEG）
        /// </summary>
        /// <param name="filename">filename of the image</param>
        /// <param name="img">pointer to an initialized image</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        /// <remarks>
        /// Supported types: PNG 8,16 bits 1,3,4 channels; BMP 8 bits 1,3 channels; TIFF 8, 16 bits 1,2,3 channels
        /// </remarks>
        /// <remarks>
        /// 支持的类型：PNG 8、16位 1、3、4通道；BMP 8位 1、3通道；TIFF 8、16位 1、2、3通道
        /// </remarks>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_load_image([MarshalAs(UnmanagedType.LPStr)] string filename, ref VIDI_IMAGE img);

        /// <summary>
        /// Load an image from memory (PNG, BMP, TIFF or JPEG)
        /// </summary>
        /// <summary>
        /// 从内存加载图像（PNG、BMP、TIFF或JPEG）
        /// </summary>
        /// <param name="data">buffer holding the image data</param>
        /// <param name="format">the format in which the image is stored</param>
        /// <param name="img">pointer to an initialized image</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        /// <remarks>
        /// Supported types: PNG 8,16 bits 1,3,4 channels; BMP 8 bits 1,3 channels; TIFF 8, 16 bits 1,2,3 channels
        /// This method is used to pass an image to vidi using a file contained in memory, for instance if using a service and dealing with files. 
        /// It is not intended to be used during inference.
        /// </remarks>
        /// <remarks>
        /// 支持的类型：PNG 8、16位 1、3、4通道；BMP 8位 1、3通道；TIFF 8、16位 1、2、3通道
        /// 此方法用于通过内存中的文件将图像传递给vidi，例如使用服务处理文件时
        /// 它不适用于推理过程中
        /// </remarks>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_load_image_from_memory(ref VIDI_BUFFER data, uint format, ref VIDI_IMAGE img);

        /// <summary>
        /// Creates an VIDI_IMAGE from different channels.
        /// </summary>
        /// <summary>
        /// 从不同通道创建VIDI_IMAGE
        /// </summary>
        /// <param name="width">width of input and target_image</param>
        /// <param name="height">height of input and target_image</param>
        /// <param name="step">desired step of the target_image (0 for auto step)</param>
        /// <param name="channel_depth">depth of input and target_image VIDI_IMG_8U or VIDI_IMG_16U</param>
        /// <param name="channel0">pointer to the channel0</param>
        /// <param name="channel1">pointer to the channel1 (0 if none)</param>
        /// <param name="channel2">pointer to the channel2 (0 if none)</param>
        /// <param name="channel3">pointer to the channel3 (0 if none)</param>
        /// <param name="target_image">pointer to an initialized image (vidi_init_image)</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        /// <remarks>
        /// This method is intended to be used as an interface for planar images, or to create a multi channel image from multiple grayscale images.
        /// The order of the channels is BGRA. The number of provided channels pointers must be equal to channels. 
        /// Each channel must have the same height, width, depth and channel depth.
        /// </remarks>
        /// <remarks>
        /// 此方法旨在用作平面图像的接口，或从多个灰度图像创建多通道图像
        /// 通道顺序为BGRA。提供的通道指针数量必须等于通道数
        /// 每个通道必须具有相同的高度、宽度、深度和通道深度
        /// </remarks>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_create_image(uint width, uint height, uint step, uint channel_depth, 
            IntPtr channel0, IntPtr channel1, IntPtr channel2, IntPtr channel3, ref VIDI_IMAGE target_image);

        /// <summary>
        /// Splits vidi image channels in separate images
        /// </summary>
        /// <summary>
        /// 将vidi图像通道拆分为单独的图像
        /// </summary>
        /// <param name="source_image">pointer to an image</param>
        /// <param name="channel0">pointer to the channel0</param>
        /// <param name="channel1">pointer to the channel1 (0 if none)</param>
        /// <param name="channel2">pointer to the channel2 (0 if none)</param>
        /// <param name="channel3">pointer to the channel3 (0 if none)</param>
        /// <param name="channel_step">desired step for all channels (channel0, channel1, ...)</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        /// <remarks>
        /// This method splits the source_image into multiple channels (void*), buffers of the channels must be allocated before calling this function. 
        /// The number of channels must match the number of channels pointers given.
        /// </remarks>
        /// <remarks>
        /// 此方法将source_image拆分为多个通道（void*），必须在调用此函数之前分配通道的缓冲区
        /// 通道数必须与给定的通道指针数量匹配
        /// </remarks>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_create_planar_image(ref VIDI_IMAGE source_image, 
            IntPtr channel0, IntPtr channel1, IntPtr channel2, IntPtr channel3, uint channel_step);

        /// <summary>
        /// Saves a VIDI_IMAGE struct into a file.
        /// </summary>
        /// <summary>
        /// 将VIDI_IMAGE结构保存到文件
        /// </summary>
        /// <param name="filename">filename of the image</param>
        /// <param name="img">pointer to an image</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        /// <remarks>
        /// The format is deduced from the file extension, i.e. .png, .bmp, .tiff or .jpeg
        /// </remarks>
        /// <remarks>
        /// 格式从文件扩展名推断，即.png、.bmp、.tiff或.jpeg
        /// </remarks>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_save_image([MarshalAs(UnmanagedType.LPStr)] string filename, ref VIDI_IMAGE img);

        /// <summary>
        /// Saves a VIDI_IMAGE struct into a file.
        /// </summary>
        /// <summary>
        /// 将VIDI_IMAGE结构保存到文件
        /// </summary>
        /// <param name="img">pointer to an image</param>
        /// <param name="buffer">buffer to write the image to</param>
        /// <param name="format">image format to use</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        /// <param name="img">指向图像的指针</param>
        /// <param name="buffer">要写入图像的缓冲区</param>
        /// <param name="format">要使用的图像格式</param>
        /// <returns>如果通过返回0，否则返回可与vidi_get_error_message()一起使用的错误代码</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_save_image_to_memory(ref VIDI_IMAGE img, ref VIDI_BUFFER buffer, uint format);

        /// <summary>
        /// Free the memory of the given image
        /// </summary>
        /// <summary>
        /// 释放给定图像的内存
        /// </summary>
        /// <param name="img">pointer to an initialized image to be freed</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        /// <param name="img">指向要释放的已初始化图像的指针</param>
        /// <returns>如果通过返回0，否则返回可与vidi_get_error_message()一起使用的错误代码</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_free_image(ref VIDI_IMAGE img);

        // License functions
        /// <summary>
        /// Returns information about the currently used ViDi License
        /// </summary>
        /// <summary>
        /// 返回当前使用的ViDi许可证的信息
        /// </summary>
        /// <param name="result">buffer to hold the license information</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        /// <remarks>
        /// Evaluation license example: &lt;license type='evaluation' serial_number='1-3092250'&gt;&lt;tool remaining_days='141' type='blue'/&gt;&lt;tool remaining_days='141' type='red'/&gt;&lt;tool remaining_days='141' type='green'/&gt;&lt;/license&gt;
        /// Production License example: &lt;license type='production' serial_number='2-2985895'&gt;&lt;tool type='blue'/&gt;&lt;tool type='red'/&gt;&lt;tool type='green'/&gt;&lt;/license&gt;
        /// </remarks>
        /// <remarks>
        /// 评估许可证示例：&lt;license type='evaluation' serial_number='1-3092250'&gt;&lt;tool remaining_days='141' type='blue'/&gt;&lt;tool remaining_days='141' type='red'/&gt;&lt;tool remaining_days='141' type='green'/&gt;&lt;/license&gt;
        /// 生产许可证示例：&lt;license type='production' serial_number='2-2985895'&gt;&lt;tool type='blue'/&gt;&lt;tool type='red'/&gt;&lt;tool type='green'/&gt;&lt;/license&gt;
        /// </remarks>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_license_get_info(ref VIDI_BUFFER result);

        /// <summary>
        /// Requests a license update
        /// </summary>
        /// <summary>
        /// 请求许可证更新
        /// </summary>
        /// <param name="result">buffer to hold the license update request which needs to be transfered to Cognex, i.e. in a vlicr file</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        /// <param name="result">保存许可证更新请求的缓冲区，需要传输给Cognex，例如在vlicr文件中</param>
        /// <returns>如果通过返回0，否则返回可与vidi_get_error_message()一起使用的错误代码</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_license_request_update(ref VIDI_BUFFER result);

        /// <summary>
        /// Applies a license update
        /// </summary>
        /// <summary>
        /// 应用许可证更新
        /// </summary>
        /// <param name="data">string holding the license update as supplied by Cognex, i.e. the content of the vlicu file</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        /// <param name="data">包含Cognex提供的许可证更新的字符串，即vlicu文件的内容</param>
        /// <returns>如果通过返回0，否则返回可与vidi_get_error_message()一起使用的错误代码</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_license_apply_update([MarshalAs(UnmanagedType.LPStr)] string data);

        /// <summary>
        /// Used to set global configuration parameters
        /// </summary>
        /// <summary>
        /// 用于设置全局配置参数
        /// </summary>
        /// <param name="configuration">string holding comma separated list of key=value pairs</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        /// <param name="configuration">包含逗号分隔的键=值对列表的字符串</param>
        /// <returns>如果通过返回0，否则返回可与vidi_get_error_message()一起使用的错误代码</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_global_config([MarshalAs(UnmanagedType.LPStr)] string configuration);

        /// <summary>
        /// internal use only
        /// </summary>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_execute_command([MarshalAs(UnmanagedType.LPStr)] string command, 
            [MarshalAs(UnmanagedType.LPStr)] string arguments, ref VIDI_BUFFER result);
    }

    /// <summary>
    /// Helper class for managing ViDi resources and providing convenient C# wrappers
    /// </summary>
    /// <summary>
    /// 用于管理ViDi资源并提供便捷C#包装器的辅助类
    /// </summary>
    public static class ViDiHelper
    {
        /// <summary>
        /// Gets the error message for a given error code
        /// </summary>
        /// <summary>
        /// 获取给定错误代码的错误消息
        /// </summary>
        /// <param name="errorCode">The error code</param>
        /// <returns>The error message string</returns>
        /// <param name="errorCode">错误代码</param>
        /// <returns>错误消息字符串</returns>
        public static string GetErrorMessage(uint errorCode)
        {
            VIDI_BUFFER buffer = new VIDI_BUFFER();
            try
            {
                uint result = ViDiAPI.vidi_init_buffer(ref buffer);
                if (result != ViDiNative.VIDI_SUCCESS)
                    return $"Failed to initialize buffer (error code: {result})";

                result = ViDiAPI.vidi_get_error_message(errorCode, ref buffer);
                if (result != ViDiNative.VIDI_SUCCESS)
                    return $"Failed to get error message (error code: {result})";

                if (buffer.data != IntPtr.Zero && buffer.size > 0)
                {
                    return Marshal.PtrToStringAnsi(buffer.data, buffer.size) ?? "Unknown error";
                }
                return "Unknown error";
            }
            finally
            {
                if (buffer.data != IntPtr.Zero)
                    ViDiAPI.vidi_free_buffer(ref buffer);
            }
        }

        /// <summary>
        /// Gets the version information of the ViDi library
        /// </summary>
        /// <summary>
        /// 获取ViDi库的版本信息
        /// </summary>
        /// <returns>Version information string</returns>
        /// <returns>版本信息字符串</returns>
        public static string GetVersion()
        {
            VIDI_BUFFER buffer = new VIDI_BUFFER();
            try
            {
                uint result = ViDiAPI.vidi_init_buffer(ref buffer);
                if (result != ViDiNative.VIDI_SUCCESS)
                    return $"Failed to initialize buffer (error code: {result})";

                result = ViDiAPI.vidi_version(ref buffer);
                if (result != ViDiNative.VIDI_SUCCESS)
                    return $"Failed to get version (error code: {result})";

                if (buffer.data != IntPtr.Zero && buffer.size > 0)
                {
                    return Marshal.PtrToStringAnsi(buffer.data, buffer.size) ?? "Unknown version";
                }
                return "Unknown version";
            }
            finally
            {
                if (buffer.data != IntPtr.Zero)
                    ViDiAPI.vidi_free_buffer(ref buffer);
            }
        }

        /// <summary>
        /// Lists available CUDA devices
        /// </summary>
        /// <summary>
        /// 列出可用的CUDA设备
        /// </summary>
        /// <returns>XML string containing device information</returns>
        /// <returns>包含设备信息的XML字符串</returns>
        public static string ListComputeDevices()
        {
            VIDI_BUFFER buffer = new VIDI_BUFFER();
            try
            {
                uint result = ViDiAPI.vidi_init_buffer(ref buffer);
                if (result != ViDiNative.VIDI_SUCCESS)
                    return $"Failed to initialize buffer (error code: {result})";

                result = ViDiAPI.vidi_list_compute_devices(ref buffer);
                if (result != ViDiNative.VIDI_SUCCESS)
                    return $"Failed to list compute devices (error code: {result})";

                if (buffer.data != IntPtr.Zero && buffer.size > 0)
                {
                    return Marshal.PtrToStringAnsi(buffer.data, buffer.size) ?? "No devices found";
                }
                return "No devices found";
            }
            finally
            {
                if (buffer.data != IntPtr.Zero)
                    ViDiAPI.vidi_free_buffer(ref buffer);
            }
        }

        /// <summary>
        /// Gets license information
        /// </summary>
        /// <summary>
        /// 获取许可证信息
        /// </summary>
        /// <returns>XML string containing license information</returns>
        /// <returns>包含许可证信息的XML字符串</returns>
        public static string GetLicenseInfo()
        {
            VIDI_BUFFER buffer = new VIDI_BUFFER();
            try
            {
                uint result = ViDiAPI.vidi_init_buffer(ref buffer);
                if (result != ViDiNative.VIDI_SUCCESS)
                    return $"Failed to initialize buffer (error code: {result})";

                result = ViDiAPI.vidi_license_get_info(ref buffer);
                if (result != ViDiNative.VIDI_SUCCESS)
                    return $"Failed to get license info (error code: {result})";

                if (buffer.data != IntPtr.Zero && buffer.size > 0)
                {
                    return Marshal.PtrToStringAnsi(buffer.data, buffer.size) ?? "No license info available";
                }
                return "No license info available";
            }
            finally
            {
                if (buffer.data != IntPtr.Zero)
                    ViDiAPI.vidi_free_buffer(ref buffer);
            }
        }
    }
}
```

**XAnyLabel.VPlugin.code_2512310845/include/vidi_runtime.cs**
```csharp
/** @file vidi_runtime.cs
*   @brief C# wrapper for ViDi Runtime API - Runtime application functions
*   @author  (c) 2012-2022 by Cognex Corporation
*   @version 6.1.1
*   @example example_runtime_red.cpp
*   @example example_cpp_runtime_multi_GPU.cpp
*   @example example_runtime_hdgreen.cpp
*   @example example_runtime_hdred.cpp
*/

using System;
using System.Runtime.InteropServices;

namespace ViDi
{
    /// <summary>
    /// C# wrapper for ViDi Runtime API
    /// </summary>
    /// <summary>
    /// ViDi运行时API的C#封装
    /// </summary>
    public static class RuntimeAPI
    {
        private const string VIDI_DLL = "vidi_61.dll";

        #region Runtime Workspace Management

        /** @brief Load and open a runtime workspace from file
        *   @param workspace_name   : name of the workspace in the file
        *   @param path             : path of the runtime workspace archive
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_open_workspace_from_file", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint OpenWorkspaceFromFile([MarshalAs(UnmanagedType.LPStr)] string workspaceName, [MarshalAs(UnmanagedType.LPStr)] string path);

        /** @brief Load and open a runtime workspace from file, with an option to specify which device each HDM tool is to be loaded
        *   @param workspace_name   : name of the workspace in the file
        *   @param path             : path of the runtime workspace archive
        *   @param gpu_hdm          : gpu indices for each HDM tool in the workspace(indices are 0-based) "[stream name]/[tool name]/[index]/[stream name]/[tool name]/[index]..."
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        *
        *   @remark
        *   For example, suppose there are two HDM tools with the name "Classify" and "Analyze" in the workspace, under "default" stream.
        *   To load each HDM tool to different GPUs on a multi-gpu system, set @p gpu_hdm to "default/Classify/0/default/Analyze/1".
        *
        *   @remark
        *   Caveats:
        *   @li Specifying focused tool does not affect. Focused tools are loaded to every device.
        *   @li Unspecified HDM tools load to an idle device at the time of tool load.
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_open_workspace_from_file2", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint OpenWorkspaceFromFile2([MarshalAs(UnmanagedType.LPStr)] string workspaceName, [MarshalAs(UnmanagedType.LPStr)] string path, [MarshalAs(UnmanagedType.LPStr)] string gpuHdm);

        /** @brief Load and open a runtime workspace from memory
        *   @param workspace_name   : name of the workspace in the memory
        *   @param data             : pointer to a buffer containing the data of the buffer.
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_open_workspace_from_memory", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint OpenWorkspaceFromMemory([MarshalAs(UnmanagedType.LPStr)] string workspaceName, IntPtr data);

        /** @brief Close the given workspace
        *   @param workspaceName name of the buffer
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_close_workspace", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint CloseWorkspace([MarshalAs(UnmanagedType.LPStr)] string workspaceName);

        /** @brief List the available workspaces
        *   @param response a pointer to a initialized buffer, containing a XML fragment
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_list_workspaces", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ListWorkspaces(IntPtr response);

        #endregion

        #region Runtime Stream Management

        /** @brief List the available streams in a workspace
        *   @param workspaceName name of the workspace
        *   @param response a pointer to a initialized buffer, containing a XML fragment
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_list_streams", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ListStreams([MarshalAs(UnmanagedType.LPStr)] string workspaceName, IntPtr response);

        #endregion

        #region Runtime Parameter Management

        /** @brief get parameter
        *   @param parameterPath  : the path to the parameter
        *   @param parameterValue : pointer to an initialized buffer used to return a string containing the value
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        *
        *   @remark
        *   To access a workspace parameter, combine workspace path with workspace name, e.g.
        *   @li parameterPath  : "workspaces/WS_NAME/deployment_targets"
        *
        *   @remark
        *   To access a stream parameter, combine workspace and stream path
        *   @li parameterPath  : "workspaces/WS_NAME/streams/STREAM_NAME/description"
        *
        *   @remark
        *   To access a tool parameter, combine workspace path and stream path with tool path and parameter name
        *   @li parameterPath  : "workspaces/WS_NAME/streams/STREAM_NAME/tools/TOOL_NAME/tool/processing/sampling_density"
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_get_parameter", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint GetParameter([MarshalAs(UnmanagedType.LPStr)] string parameterPath, IntPtr parameterValue);

        /** @brief set parameter
        *   @param parameterPath  : the path to the parameter
        *   @param value          : string containing the value
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_set_parameter", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint SetParameter([MarshalAs(UnmanagedType.LPStr)] string parameterPath, [MarshalAs(UnmanagedType.LPStr)] string value);

        /** @brief list parameters
        *   @param parameterPath  : The sub-path to the parameters we want to list.
        *                             Leave empty ("") to list all accessible parameters
        *   @param depth          : Depth at which we want nested parameter to be listed, starting from 'parameterPath'.
        *                             Use value -1 to list at any depth. A value of 0 will return nothing.
        *   @param value          : Pointer to an initialized buffer used to return an xml fragments listing the parameters
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_list_parameters", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ListParameters([MarshalAs(UnmanagedType.LPStr)] string parameterPath, int depth, IntPtr value);

        #endregion

        #region Runtime Tool Management

        /** @brief List the available tools in a stream
        *   @param workspaceName  : name of the workspace
        *   @param streamName     : name of the stream
        *   @param response       : a pointer to a initialized buffer, containing a XML fragment
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_list_tools", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ListTools([MarshalAs(UnmanagedType.LPStr)] string workspaceName, [MarshalAs(UnmanagedType.LPStr)] string streamName, IntPtr response);

        /** @brief lists and gets all tool parameters as an xml snippet
        *   @param workspaceName  : the name of the workspace
        *   @param streamName     : the name of the stream
        *   @param toolName       : the name of the tool
        *   @param value          : allocated buffer to store the xml snippet
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_tool_list_parameters", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ToolListParameters([MarshalAs(UnmanagedType.LPStr)] string workspaceName, [MarshalAs(UnmanagedType.LPStr)] string streamName, [MarshalAs(UnmanagedType.LPStr)] string toolName, IntPtr value);

        /** @brief set the tool parameter
        *   @param workspaceName  : the name of the workspace
        *   @param streamName     : the name of the stream
        *   @param toolName       : the name of the tool
        *   @param parameter      : the name of the parameter
        *   @param value          : string containing the value
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_tool_set_parameter", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ToolSetParameter([MarshalAs(UnmanagedType.LPStr)] string workspaceName, [MarshalAs(UnmanagedType.LPStr)] string streamName, [MarshalAs(UnmanagedType.LPStr)] string toolName, [MarshalAs(UnmanagedType.LPStr)] string parameter, [MarshalAs(UnmanagedType.LPStr)] string value);

        /** @brief get the tool parameter
        *   @param workspaceName  : the name of the workspace
        *   @param streamName     : the name of the stream
        *   @param toolName       : the name of the tool
        *   @param parameter      : the name of the parameter
        *   @param value          : pointer to an initialized buffer used to return a string containing the value
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_tool_get_parameter", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ToolGetParameter([MarshalAs(UnmanagedType.LPStr)] string workspaceName, [MarshalAs(UnmanagedType.LPStr)] string streamName, [MarshalAs(UnmanagedType.LPStr)] string toolName, [MarshalAs(UnmanagedType.LPStr)] string parameter, IntPtr value);

        /** @brief get tool info
        *   @param workspaceName  : the name of the workspace
        *   @param streamName     : the name of the stream
        *   @param toolName       : the name of the tool
        *   @param response       : returns a xml fragment containing tools informations
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_tool_get_info", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ToolGetInfo([MarshalAs(UnmanagedType.LPStr)] string workspaceName, [MarshalAs(UnmanagedType.LPStr)] string streamName, [MarshalAs(UnmanagedType.LPStr)] string toolName, IntPtr response);

        #endregion

        #region Runtime ROI Management

        /** @brief sets the mask of the tool's region of interest
        *   @param workspaceName    : the name of the workspace
        *   @param streamName       : the name of the stream
        *   @param toolName         : the name of the tool
        *   @param maskImage        : image containing the mask, if 0, clears the mask
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_roi_set_mask", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint RoiSetMask([MarshalAs(UnmanagedType.LPStr)] string workspaceName, [MarshalAs(UnmanagedType.LPStr)] string streamName, [MarshalAs(UnmanagedType.LPStr)] string toolName, IntPtr maskImage);

        /** @brief clears all region of interests on the tool's next process
        *   @param workspaceName    : the name of the workspace
        *   @param streamName       : the name of the stream
        *   @param sampleName       : the name of the sample_name
        *   @param toolName         : the name of the tool
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_roi_clear_views", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint RoiClearViews([MarshalAs(UnmanagedType.LPStr)] string workspaceName, [MarshalAs(UnmanagedType.LPStr)] string streamName, [MarshalAs(UnmanagedType.LPStr)] string sampleName, [MarshalAs(UnmanagedType.LPStr)] string toolName);

        /** @brief adds a region of interest on the tool's next process
        *   @param workspaceName    : the name of the workspace
        *   @param streamName       : the name of the stream
        *   @param toolName         : the name of the tool
        *   @param sampleName       : the name of the sample
        *   @param width            : width of the roi
        *   @param height           : height of the roi
        *   @param m00 m10 01 m02 m11 m02 m12  : parameters of the pose matrix
        *   @param maskImage        : image containing the mask, if 0, no mask is used
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_roi_add_view", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint RoiAddView([MarshalAs(UnmanagedType.LPStr)] string workspaceName, [MarshalAs(UnmanagedType.LPStr)] string streamName, [MarshalAs(UnmanagedType.LPStr)] string toolName, [MarshalAs(UnmanagedType.LPStr)] string sampleName, uint width, uint height, double m00, double m10, double m01, double m11, double m02, double m12, IntPtr maskImage);

        /** @brief exports the roi as a binary fragment.
        *   @param workspaceName    : the name of the workspace
        *   @param streamName       : the name of the stream
        *   @param toolName         : the name of the tool
        *   @param buffer           : pointer to an initialized buffer
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_roi_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint RoiExport([MarshalAs(UnmanagedType.LPStr)] string workspaceName, [MarshalAs(UnmanagedType.LPStr)] string streamName, [MarshalAs(UnmanagedType.LPStr)] string toolName, IntPtr buffer);

        /** @brief imports an roi from a binary fragment.
        *   @param workspaceName    : the name of the workspace
        *   @param streamName       : the name of the stream
        *   @param toolName         : the name of the tool
        *   @param buffer           : buffer containting the binary framgent
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_roi_import", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint RoiImport([MarshalAs(UnmanagedType.LPStr)] string workspaceName, [MarshalAs(UnmanagedType.LPStr)] string streamName, [MarshalAs(UnmanagedType.LPStr)] string toolName, IntPtr buffer);

        #endregion

        #region Runtime Blue Tool Management

        /** @brief creates a new model
        *   @param workspaceName    : the name of the workspace
        *   @param streamName       : the name of the stream
        *   @param toolName         : the name of the tool
        *   @param modelName        : the name of the model
        *   @param modelType        : the type of the model -- use VIDI_MODEL_TYPE_* macros
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_blue_create_model", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint BlueCreateModel([MarshalAs(UnmanagedType.LPStr)] string workspaceName, [MarshalAs(UnmanagedType.LPStr)] string streamName, [MarshalAs(UnmanagedType.LPStr)] string toolName, [MarshalAs(UnmanagedType.LPStr)] string modelName, uint modelType);

        /** @brief renames an existing model
        *   @param workspaceName    : the name of the workspace
        *   @param streamName       : the name of the stream
        *   @param toolName         : the name of the tool
        *   @param modelName        : the name of the model
        *   @param newName          : the new name of the model
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_blue_rename_model", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint BlueRenameModel([MarshalAs(UnmanagedType.LPStr)] string workspaceName, [MarshalAs(UnmanagedType.LPStr)] string streamName, [MarshalAs(UnmanagedType.LPStr)] string toolName, [MarshalAs(UnmanagedType.LPStr)] string modelName, [MarshalAs(UnmanagedType.LPStr)] string newName);

        /** @brief removes an existing model
        *   @param workspaceName    : the name of the workspace
        *   @param streamName       : the name of the stream
        *   @param toolName         : the name of the tool
        *   @param modelName        : the name of the model
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_blue_remove_model", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint BlueRemoveModel([MarshalAs(UnmanagedType.LPStr)] string workspaceName, [MarshalAs(UnmanagedType.LPStr)] string streamName, [MarshalAs(UnmanagedType.LPStr)] string toolName, [MarshalAs(UnmanagedType.LPStr)] string modelName);

        /** @brief retrieves the existing models
        *   @param workspaceName    : the name of the workspace
        *   @param streamName       : the name of the stream
        *   @param toolName         : the name of the tool
        *   @param resBuffer        : pointer to a initialized buffer
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_blue_list_models", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint BlueListModels([MarshalAs(UnmanagedType.LPStr)] string workspaceName, [MarshalAs(UnmanagedType.LPStr)] string streamName, [MarshalAs(UnmanagedType.LPStr)] string toolName, IntPtr resBuffer);

        /** @brief export a model from a blue tool
        *   @param workspaceName    : the name of the workspace
        *   @param streamName       : the name of the stream
        *   @param toolName         : the name of the tool
        *   @param modelName        : the name of the model
        *   @param buffer           : pointer to a buffer
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_blue_export_model", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint BlueExportModel([MarshalAs(UnmanagedType.LPStr)] string workspaceName, [MarshalAs(UnmanagedType.LPStr)] string streamName, [MarshalAs(UnmanagedType.LPStr)] string toolName, [MarshalAs(UnmanagedType.LPStr)] string modelName, IntPtr buffer);

        /** @brief import a model into a blue tool
        *   @param workspaceName    : the name of the workspace
        *   @param streamName       : the name of the stream
        *   @param toolName         : the name of the tool
        *   @param modelName        : the name of the model
        *   @param buffer           : pointer to a buffer
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_blue_import_model", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint BlueImportModel([MarshalAs(UnmanagedType.LPStr)] string workspaceName, [MarshalAs(UnmanagedType.LPStr)] string streamName, [MarshalAs(UnmanagedType.LPStr)] string toolName, [MarshalAs(UnmanagedType.LPStr)] string modelName, IntPtr buffer);

        #endregion

        #region Runtime Model Management

        /** @brief add a node to a model
        *   @param workspaceName    : the name of the workspace
        *   @param streamName       : the name of the stream
        *   @param toolName         : the name of the tool
        *   @param modelName        : the name of the model
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_model_add_node", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ModelAddNode([MarshalAs(UnmanagedType.LPStr)] string workspaceName, [MarshalAs(UnmanagedType.LPStr)] string streamName, [MarshalAs(UnmanagedType.LPStr)] string toolName, [MarshalAs(UnmanagedType.LPStr)] string modelName);

        /** @brief removes a node from the model
        *   @param workspaceName    : the name of the workspace
        *   @param streamName       : the name of the stream
        *   @param toolName         : the name of the tool
        *   @param modelName        : the name of the model
        *   @param nodeIdx          : the id of the node to delete
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_model_remove_node", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ModelRemoveNode([MarshalAs(UnmanagedType.LPStr)] string workspaceName, [MarshalAs(UnmanagedType.LPStr)] string streamName, [MarshalAs(UnmanagedType.LPStr)] string toolName, [MarshalAs(UnmanagedType.LPStr)] string modelName, uint nodeIdx);

        /** @brief Lits the nodes of a model
        *   @param workspaceName    : the name of the workspace
        *   @param streamName       : the name of the stream
        *   @param toolName         : the name of the blue tool
        *   @param modelName        : the name of the model
        *   @param result           : pointer to an initialized buffer used to return the list as XML fragment
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_model_list_nodes", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ModelListNodes([MarshalAs(UnmanagedType.LPStr)] string workspaceName, [MarshalAs(UnmanagedType.LPStr)] string streamName, [MarshalAs(UnmanagedType.LPStr)] string toolName, [MarshalAs(UnmanagedType.LPStr)] string modelName, IntPtr result);

        /** @brief list the regions from the layout model
        *   @param workspaceName    : the name of the workspace
        *   @param streamName       : the name of the stream
        *   @param toolName         : the name of the tool
        *   @param modelName        : the name of the model
        *   @param result           : pointer to an initialized buffer used to return the list as XML fragment
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_layout_model_list_regions", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint LayoutModelListRegions([MarshalAs(UnmanagedType.LPStr)] string workspaceName, [MarshalAs(UnmanagedType.LPStr)] string streamName, [MarshalAs(UnmanagedType.LPStr)] string toolName, [MarshalAs(UnmanagedType.LPStr)] string modelName, IntPtr result);

        /** @brief adds a region to the layout model
        *   @param workspaceName    : the name of the workspace
        *   @param streamName       : the name of the stream
        *   @param toolName         : the name of the tool
        *   @param modelName        : the name of the model
        *   @param regionName       : the id of the node to delete
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_layout_model_add_region", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint LayoutModelAddRegion([MarshalAs(UnmanagedType.LPStr)] string workspaceName, [MarshalAs(UnmanagedType.LPStr)] string streamName, [MarshalAs(UnmanagedType.LPStr)] string toolName, [MarshalAs(UnmanagedType.LPStr)] string modelName, [MarshalAs(UnmanagedType.LPStr)] string regionName);

        /** @brief removes a region from the layout model
        *   @param workspaceName    : the name of the workspace
        *   @param streamName       : the name of the stream
        *   @param toolName         : the name of the tool
        *   @param modelName        : the name of the model
        *   @param regionIdx        : the id of the node to delete
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_layout_model_remove_region", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint LayoutModelRemoveRegion([MarshalAs(UnmanagedType.LPStr)] string workspaceName, [MarshalAs(UnmanagedType.LPStr)] string streamName, [MarshalAs(UnmanagedType.LPStr)] string toolName, [MarshalAs(UnmanagedType.LPStr)] string modelName, uint regionIdx);

        #endregion

        #region Runtime Sample Management

        /** @brief creates a new sample with the given image
        *   @param workspaceName    : the name of the workspace
        *   @param streamName       : the name of the stream
        *   @param sampleName       : the name of the sample
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_create_sample", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint CreateSample([MarshalAs(UnmanagedType.LPStr)] string workspaceName, [MarshalAs(UnmanagedType.LPStr)] string streamName, [MarshalAs(UnmanagedType.LPStr)] string sampleName);

        /** @deprecated this method is deprecated, please use vidi_runtime_create_sample instead **/
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_init_sample", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint InitSample([MarshalAs(UnmanagedType.LPStr)] string workspaceName, [MarshalAs(UnmanagedType.LPStr)] string streamName, [MarshalAs(UnmanagedType.LPStr)] string sampleName, IntPtr image);

        /** @brief adds an image to a sample
        *   @param workspaceName    : the name of the workspace
        *   @param streamName       : the name of the stream
        *   @param sampleName       : the name of the sample
        *   @param image            : the image to add
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_sample_add_image", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint SampleAddImage([MarshalAs(UnmanagedType.LPStr)] string workspaceName, [MarshalAs(UnmanagedType.LPStr)] string streamName, [MarshalAs(UnmanagedType.LPStr)] string sampleName, IntPtr image);

        /** @brief Process a given sample by a tool, if tool is empty then process by all tools present in the given stream
        *   @param workspaceName    : the name of the workspace containing the tool
        *   @param streamName       : the name of the stream containing the tool
        *   @param toolName         : the name of the tool
        *   @param sampleName       : name of the sample
        *   @param gpuList          : list of coma separated gpu number to use for the processing. if the list is empty, uses all available gpus
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_sample_process", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint SampleProcess([MarshalAs(UnmanagedType.LPStr)] string workspaceName, [MarshalAs(UnmanagedType.LPStr)] string streamName, [MarshalAs(UnmanagedType.LPStr)] string toolName, [MarshalAs(UnmanagedType.LPStr)] string sampleName, [MarshalAs(UnmanagedType.LPStr)] string gpuList);

        /** @brief Returns an image for a sample as it was processed by a specific tool
        *   @param workspaceName    : the name of the workspace containing the tool
        *   @param streamName       : the name of the stream containing the tool
        *   @param toolName         : the name of the tool
        *   @param viewKey          : the key identifying the view, i.e. <sample-name>|<frame-index>:<view-index>; the entire image is returned for view-index = -1
        *   @param format           : the channel format, if empty the tool's channel format is used
        *   @param image            : pointer to an initialized image to return the result
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_sample_get_image", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint SampleGetImage([MarshalAs(UnmanagedType.LPStr)] string workspaceName, [MarshalAs(UnmanagedType.LPStr)] string streamName, [MarshalAs(UnmanagedType.LPStr)] string toolName, [MarshalAs(UnmanagedType.LPStr)] string viewKey, [MarshalAs(UnmanagedType.LPStr)] string format, IntPtr image);

        /** @brief releases a previously created sample
        *   @param workspaceName    : the name of the workspace
        *   @param streamName       : the name of the stream
        *   @param sampleName       : the name of the sample
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_free_sample", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint FreeSample([MarshalAs(UnmanagedType.LPStr)] string workspaceName, [MarshalAs(UnmanagedType.LPStr)] string streamName, [MarshalAs(UnmanagedType.LPStr)] string sampleName);

        /** @brief get a sample in XML format
        *   @param workspaceName    : the name of the workspace
        *   @param streamName       : the name of the stream
        *   @param sampleName       : the name of the sample
        *   @param buffer           : a pointer to a initialized buffer to which the XML will be written
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_get_sample", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint GetSample([MarshalAs(UnmanagedType.LPStr)] string workspaceName, [MarshalAs(UnmanagedType.LPStr)] string streamName, [MarshalAs(UnmanagedType.LPStr)] string sampleName, IntPtr buffer);

        /** @brief internal use only (subject to changes), get a sample in JSON format
        *   @param workspaceName    : the name of the workspace
        *   @param streamName       : the name of the stream
        *   @param sampleName       : the name of the sample
        *   @param buffer           : a pointer to a initialized buffer to which the JSON will be written
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_get_sample_json", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint GetSampleJson([MarshalAs(UnmanagedType.LPStr)] string workspaceName, [MarshalAs(UnmanagedType.LPStr)] string streamName, [MarshalAs(UnmanagedType.LPStr)] string sampleName, IntPtr buffer);

        /** @brief lists the available samples
        *   @param workspaceName    : the name of the workspace
        *   @param streamName       : the name of the stream
        *   @param buffer           : a pointer to a initialized buffer to which the list will be written
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_list_samples", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ListSamples([MarshalAs(UnmanagedType.LPStr)] string workspaceName, [MarshalAs(UnmanagedType.LPStr)] string streamName, IntPtr buffer);

        #endregion

        #region Runtime Green Tool Management

        /** @brief Add selected sample as reference views for the similarity model
        *   @param workspaceName    : the name of the workspace
        *   @param streamName       : the name of the stream
        *   @param toolName         : the name of the tool
        *   @param tagName          : the view(s) tag name to be used for training the similarity model
        *   @param sampleName       : the name of the sample set/unset as reference views
        *   @param frameIndex       : comma-separated index list of the sample frames to use, empty list "" to use all
        *   @param viewIndex        : comma-separated index list of the sample views to use, empty list "" to use all
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_green_set_similarity_reference_views", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint GreenSetSimilarityReferenceViews([MarshalAs(UnmanagedType.LPStr)] string workspaceName, [MarshalAs(UnmanagedType.LPStr)] string streamName, [MarshalAs(UnmanagedType.LPStr)] string toolName, [MarshalAs(UnmanagedType.LPStr)] string tagName, [MarshalAs(UnmanagedType.LPStr)] string sampleName, [MarshalAs(UnmanagedType.LPStr)] string frameIndex, [MarshalAs(UnmanagedType.LPStr)] string viewIndex);

        /** @brief Remove reference views from the similarity model list of references
        *   @param workspaceName    : the name of the workspace
        *   @param streamName       : the name of the stream
        *   @param toolName         : the name of the tool
        *   @param indexList        : comma-separated list of indices, use empty list "" to remove all
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_green_remove_similarity_reference_views", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint GreenRemoveSimilarityReferenceViews([MarshalAs(UnmanagedType.LPStr)] string workspaceName, [MarshalAs(UnmanagedType.LPStr)] string streamName, [MarshalAs(UnmanagedType.LPStr)] string toolName, [MarshalAs(UnmanagedType.LPStr)] string indexList);

        /** @brief lists the reference views of the tool's similarity model
        *   @param workspaceName    : the name of the workspace
        *   @param streamName       : the name of the stream
        *   @param toolName         : the name of the tool
        *   @param value            : pointer to an initialized buffer used to return an xml fragments
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_green_list_similarity_reference_views", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint GreenListSimilarityReferenceViews([MarshalAs(UnmanagedType.LPStr)] string workspaceName, [MarshalAs(UnmanagedType.LPStr)] string streamName, [MarshalAs(UnmanagedType.LPStr)] string toolName, IntPtr value);

        /** @brief Train tool's similarity model
        *   @param workspaceName    : the name of the workspace
        *   @param streamName       : the name of the stream
        *   @param toolName         : the name of the green tool
        *   @return 0 if passed, otherwise an error_code that can be used with vidi_get_error_message()
        */
        [DllImport(VIDI_DLL, EntryPoint = "vidi_runtime_green_train_similarity_model", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint GreenTrainSimilarityModel([MarshalAs(UnmanagedType.LPStr)] string workspaceName, [MarshalAs(UnmanagedType.LPStr)] string streamName, [MarshalAs(UnmanagedType.LPStr)] string toolName);

        #endregion

        #region Constants

        /// <summary>
        /// Operation completed successfully
        /// </summary>
        /// <summary>
        /// 操作成功完成
        /// </summary>
        public const uint VIDI_SUCCESS = 0;

        /// <summary>
        /// Operation did not complete due to an unexpected error
        /// </summary>
        /// <summary>
        /// 由于意外错误，操作未完成
        /// </summary>
        public const uint VIDI_RUNTIME_ERROR = 1000;

        /// <summary>
        /// Operation did not complete due to a logic error
        /// </summary>
        /// <summary>
        /// 由于逻辑错误，操作未完成
        /// </summary>
        public const uint VIDI_LOGIC_ERROR = 2000;

        /// <summary>
        /// Operation did not complete due to an invalid object reference
        /// </summary>
        /// <summary>
        /// 由于无效的对象引用，操作未完成
        /// </summary>
        public const uint VIDI_NOT_FOUND_ERROR = 3000;

        /// <summary>
        /// Operation did not complete due to an invalid argument
        /// </summary>
        /// <summary>
        /// 由于无效的参数，操作未完成
        /// </summary>
        public const uint VIDI_INVALID_ARGUMENT_ERROR = 4000;

        /// <summary>
        /// A filter parsing operation failed
        /// </summary>
        /// <summary>
        /// 过滤器解析操作失败
        /// </summary>
        public const uint VIDI_FILTER_PARSE_ERROR = 4500;

        /// <summary>
        /// Operation is not available or not supported
        /// </summary>
        /// <summary>
        /// 操作不可用或不受支持
        /// </summary>
        public const uint VIDI_INVALID_OPERATION_ERROR = 5000;

        /// <summary>
        /// Operation did not complete because a buffer, an image, or the library have not been initialized
        /// </summary>
        /// <summary>
        /// 由于缓冲区、图像或库未初始化，操作未完成
        /// </summary>
        public const uint VIDI_NOT_INITIALIZED_ERROR = 6000;

        /// <summary>
        /// Node model type
        /// </summary>
        /// <summary>
        /// 节点模型类型
        /// </summary>
        public const uint VIDI_MODEL_TYPE_NODE = 0;

        /// <summary>
        /// Regex model type
        /// </summary>
        /// <summary>
        /// 正则表达式模型类型
        /// </summary>
        public const uint VIDI_MODEL_TYPE_REGEX = 1;

        /// <summary>
        /// String model type
        /// </summary>
        /// <summary>
        /// 字符串模型类型
        /// </summary>
        public const uint VIDI_MODEL_TYPE_STRING = 2;

        /// <summary>
        /// Layout model type
        /// </summary>
        /// <summary>
        /// 布局模型类型
        /// </summary>
        public const uint VIDI_MODEL_TYPE_LAYOUT = 3;

        #endregion
    }
}
```

**XAnyLabel.VPlugin.code_2512310845/include/vidi_training.cs**
```csharp
/** @file vidi_training.cs
*   @brief C# wrapper for ViDi training API functions
*   @author  (c) 2012-2022 by Cognex Corporation
*   @version 6.1.1
*   @example example_training_red.cpp
*   @example example_training_blue.cpp
*   @example example_training_green.cpp
*   @example example_training_hdgreen.cpp
*   @example example_training_hdred.cpp
*/

using System;
using System.Runtime.InteropServices;

namespace ViDi
{
    /// <summary>
    /// C# wrapper for ViDi Training API
    /// </summary>
    /// <summary>
    /// ViDi训练API的C#包装器
    /// </summary>
    public static class ViDiTraining
    {
        private const string ViDiDll = "vidi_61.dll";

        // Constants from vidi.h
        public const int VIDI_SUCCESS = 0;
        public const int VIDI_RUNTIME_ERROR = 1000;
        public const int VIDI_LOGIC_ERROR = 2000;
        public const int VIDI_NOT_FOUND_ERROR = 3000;
        public const int VIDI_INVALID_ARGUMENT_ERROR = 4000;
        public const int VIDI_FILTER_PARSE_ERROR = 4500;
        public const int VIDI_INVALID_OPERATION_ERROR = 5000;
        public const int VIDI_NOT_INITIALIZED_ERROR = 6000;

        // Image format constants
        public const int VIDI_IMG_8U = 0;
        public const int VIDI_IMG_16U = 1;

        // Image format constants
        public const int VIDI_IMAGE_FORMAT_PNG = 1;
        public const int VIDI_IMAGE_FORMAT_BMP = 2;
        public const int VIDI_IMAGE_FORMAT_JPEG = 3;
        public const int VIDI_IMAGE_FORMAT_TIFF = 4;

        // Model type constants
        public const int VIDI_MODEL_TYPE_NODE = 0;
        public const int VIDI_MODEL_TYPE_REGEX = 1;
        public const int VIDI_MODEL_TYPE_STRING = 2;
        public const int VIDI_MODEL_TYPE_LAYOUT = 3;

        // Save constants
        public const int VIDI_AUTO_SAVE = 1;
        public const int VIDI_FORCE_SAVE = 2;

        // Clear constants
        public const int VIDI_CLEAR_MARKING = 0x01;
        public const int VIDI_CLEAR_LABEL = 0x02;
        public const int VIDI_CLEAR_BOTH = VIDI_CLEAR_LABEL | VIDI_CLEAR_MARKING;

        /// <summary>
        /// Structure holding a generic data buffer
        /// </summary>
        /// <summary>
        /// 包含通用数据缓冲区的结构体
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct VIDI_BUFFER
        {
            /// <summary>
            /// Size of the buffer (in bytes)
            /// </summary>
            /// <summary>
            /// 缓冲区大小（以字节为单位）
            /// </summary>
            public int size;
            /// <summary>
            /// Char array of length size
            /// </summary>
            /// <summary>
            /// 长度为size的字符数组
            /// </summary>
            public IntPtr data;
        }

        /// <summary>
        /// Structure holding an image
        /// </summary>
        /// <summary>
        /// 包含图像数据的结构体
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct VIDI_IMAGE
        {
            /// <summary>
            /// Width of the image
            /// </summary>
            /// <summary>
            /// 图像宽度
            /// </summary>
            public uint width;
            /// <summary>
            /// Height of the image
            /// </summary>
            /// <summary>
            /// 图像高度
            /// </summary>
            public uint height;
            /// <summary>
            /// Number of channels of the image (1-4)
            /// </summary>
            /// <summary>
            /// 图像通道数（1-4）
            /// </summary>
            public uint channels;
            /// <summary>
            /// Image data
            /// </summary>
            /// <summary>
            /// 图像数据
            /// </summary>
            public IntPtr data;
            /// <summary>
            /// Depth of a channel (VIDI_IMG_8U or VIDI_IMG_16U)
            /// </summary>
            /// <summary>
            /// 通道深度（VIDI_IMG_8U或VIDI_IMG_16U）
            /// </summary>
            public uint channel_depth;
            /// <summary>
            /// Distance in memory between 2 pixels of the same column for 2 consecutive rows
            /// </summary>
            /// <summary>
            /// 内存中相邻两行同一列像素之间的距离
            /// </summary>
            public uint step;
        }

        /// <summary>
        /// Structure describing a region of interest
        /// </summary>
        /// <summary>
        /// 描述感兴趣区域的结构体
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct VIDI_ROI
        {
            /// <summary>
            /// Width of the ROI
            /// </summary>
            /// <summary>
            /// ROI宽度
            /// </summary>
            public uint width;
            /// <summary>
            /// Height of the ROI
            /// </summary>
            /// <summary>
            /// ROI高度
            /// </summary>
            public uint height;
            /// <summary>
            /// Offset in x of the ROI
            /// </summary>
            /// <summary>
            /// ROI的X偏移量
            /// </summary>
            public uint offset_x;
            /// <summary>
            /// Offset in y of the ROI
            /// </summary>
            /// <summary>
            /// ROI的Y偏移量
            /// </summary>
            public uint offset_y;
            /// <summary>
            /// Angle of the ROI
            /// </summary>
            /// <summary>
            /// ROI的角度
            /// </summary>
            public double angle;
        }

        // Callback delegate for training cancellation
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate bool CallbackTrainCancelled();

        /** @addtogroup Training */

        /// <summary>
        /// Lists the opened workspaces
        /// </summary>
        /// <summary>
        /// 列出已打开的工作空间
        /// </summary>
        /// <param name="workspace_list">Buffer to hold the XML response</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_list_workspaces(ref VIDI_BUFFER workspace_list);

        /// <summary>
        /// Creates a new workspace with name workspace_name at location workspace_path
        /// </summary>
        /// <summary>
        /// 在指定位置创建工作空间
        /// </summary>
        /// <param name="workspace_name">The name of the workspaces that will be created. It has to be unique.</param>
        /// <param name="workspace_path">The folder where the workspace will be created. The folder has to be empty.</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_create_workspace([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                [MarshalAs(UnmanagedType.LPStr)] string workspace_path);

        /// <summary>
        /// Saves the desired workspace
        /// </summary>
        /// <summary>
        /// 保存指定的工作空间
        /// </summary>
        /// <param name="workspace_name">The name of the workspace that will be saved.</param>
        /// <param name="flag">Flag controlling whether saving mode is normal (0), forced (1) and/or auto (2)</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_save_workspace([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                              uint flag);

        /// <summary>
        /// Saves the desired workspace and calls the callback function when it finishes
        /// </summary>
        /// <summary>
        /// 保存工作空间并在完成后调用回调函数
        /// </summary>
        /// <param name="workspace_name">The name of the workspace that will be saved.</param>
        /// <param name="flag">Flag controlling whether saving mode is normal (0), forced (1) and/or auto (2)</param>
        /// <param name="callback_after_save">The callback function which will be called after the workspace is saved.</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_save_workspace2([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                               uint flag,
                                                               IntPtr callback_after_save);

        /// <summary>
        /// Opens the desired workspace
        /// </summary>
        /// <summary>
        /// 打开指定的工作空间
        /// </summary>
        /// <param name="workspace_name">The name of the workspaces that will be opened. The name has to be unique.</param>
        /// <param name="workspace_path">The path were the workspace is located</param>
        /// <param name="recover_from_auto_save">Open workspace from auto-save files if present</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_open_workspace([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                              [MarshalAs(UnmanagedType.LPStr)] string workspace_path,
                                                              uint recover_from_auto_save);

        /// <summary>
        /// Closes the desired workspace
        /// </summary>
        /// <summary>
        /// 关闭指定的工作空间
        /// </summary>
        /// <param name="workspace_name">The name of the workspaces that will be closed.</param>
        /// <param name="discard_auto_save">Discard any auto-saved data</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_close_workspace([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                               uint discard_auto_save);

        /// <summary>
        /// Imports a workspace from a file
        /// </summary>
        /// <summary>
        /// 从文件导入工作空间
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="workspace_path">Path where the workspace will be saved</param>
        /// <param name="workspace_archive">Path of the workspace archive</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_import_workspace_from_file([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                          [MarshalAs(UnmanagedType.LPStr)] string workspace_path,
                                                                          [MarshalAs(UnmanagedType.LPStr)] string workspace_archive);

        /// <summary>
        /// Import the workspace from the memory
        /// </summary>
        /// <summary>
        /// 从内存导入工作空间
        /// </summary>
        /// <param name="workspace_name">The target name of the imported workspace, has to be unique.</param>
        /// <param name="workspace_path">The path where the workspace will be saved</param>
        /// <param name="workspace_data">Pointer to a Buffer containing the workspace data</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_import_workspace_from_memory([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                            [MarshalAs(UnmanagedType.LPStr)] string workspace_path,
                                                                            ref VIDI_BUFFER workspace_data);

        /// <summary>
        /// Exports the workspace
        /// </summary>
        /// <summary>
        /// 导出工作空间
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="workspace_path">Path where to export the workspace. The extension is always .vwsa</param>
        /// <param name="with_images">If not 0, the images are exported</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_export_workspace_to_file([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                        [MarshalAs(UnmanagedType.LPStr)] string workspace_path,
                                                                        int with_images);

        /// <summary>
        /// Exports the workspace
        /// </summary>
        /// <summary>
        /// 导出工作空间
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="with_images">If not 0, the images are exported</param>
        /// <param name="workspace_data">Initialized buffer where the exported workspace is stored</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_export_workspace_to_memory([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                          int with_images,
                                                                          ref VIDI_BUFFER workspace_data);

        /// <summary>
        /// Exports a runtime workspace into a file
        /// </summary>
        /// <summary>
        /// 将运行时工作空间导出到文件
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="workspace_path">Path where to export the runtime workspace. The extension will be .vrws</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_export_runtime_workspace_to_file([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                                [MarshalAs(UnmanagedType.LPStr)] string workspace_path);

        /// <summary>
        /// Exports a runtime workspace into the memory
        /// </summary>
        /// <summary>
        /// 将运行时工作空间导出到内存
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="workspace_data">Initialized buffer where the runtime workspace data is exported</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_export_runtime_workspace_to_memory([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                                  ref VIDI_BUFFER workspace_data);

        /** @addtogroup Workspace */

        /// <summary>
        /// Add a new stream
        /// </summary>
        /// <summary>
        /// 添加新的流
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_workspace_add_stream([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                    [MarshalAs(UnmanagedType.LPStr)] string stream_name);

        /// <summary>
        /// List all the streams in a workspace
        /// </summary>
        /// <summary>
        /// 列出工作空间中的所有流
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="streams">Buffer to hold an XML fragment with the list of stream</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_workspace_list_streams([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                      ref VIDI_BUFFER streams);

        /// <summary>
        /// Clone a stream. Copies all the tools and configuration without images
        /// </summary>
        /// <summary>
        /// 克隆流，复制所有工具和配置（不包含图像）
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the source stream</param>
        /// <param name="clone_stream_name">The name of the clone</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_workspace_clone_stream([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                      [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                      [MarshalAs(UnmanagedType.LPStr)] string clone_stream_name);

        /// <summary>
        /// Rename a stream
        /// </summary>
        /// <summary>
        /// 重命名流
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="new_stream_name">New name of the stream</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_workspace_rename_stream([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                       [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                       [MarshalAs(UnmanagedType.LPStr)] string new_stream_name);

        /// <summary>
        /// Move a stream
        /// </summary>
        /// <summary>
        /// 移动流
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="target_workspace_name">The name of the target workspace</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_workspace_move_stream([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                     [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                     [MarshalAs(UnmanagedType.LPStr)] string target_workspace_name);

        /// <summary>
        /// Removes a stream
        /// </summary>
        /// <summary>
        /// 移除流
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_workspace_remove_stream([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                       [MarshalAs(UnmanagedType.LPStr)] string stream_name);

        /// <summary>
        /// Get parameter
        /// </summary>
        /// <summary>
        /// 获取参数
        /// </summary>
        /// <param name="parameter_path">The path to the parameter</param>
        /// <param name="parameter_value">Pointer to an initialized buffer used to return a string containing the value</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_get_parameter([MarshalAs(UnmanagedType.LPStr)] string parameter_path,
                                                             ref VIDI_BUFFER parameter_value);

        /// <summary>
        /// Set parameter
        /// </summary>
        /// <summary>
        /// 设置参数
        /// </summary>
        /// <param name="parameter_path">The path to the parameter</param>
        /// <param name="value">String containing the value</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_set_parameter([MarshalAs(UnmanagedType.LPStr)] string parameter_path,
                                                             [MarshalAs(UnmanagedType.LPStr)] string value);

        /// <summary>
        /// List parameters
        /// </summary>
        /// <summary>
        /// 列出参数
        /// </summary>
        /// <param name="parameter_path">The sub-path to the parameters we want to list</param>
        /// <param name="depth">Depth at which we want nested parameter to be listed</param>
        /// <param name="value">Pointer to an initialized buffer used to return an xml fragments listing the parameters</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_list_parameters([MarshalAs(UnmanagedType.LPStr)] string parameter_path,
                                                               int depth,
                                                               ref VIDI_BUFFER value);

        /** @addtogroup Version */

        /// <summary>
        /// Saves a new version of the desired workspace
        /// </summary>
        /// <summary>
        /// 保存工作空间的新版本
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_workspace_save_new_version([MarshalAs(UnmanagedType.LPStr)] string workspace_name);

        /// <summary>
        /// Deletes the version of the workspace
        /// </summary>
        /// <summary>
        /// 删除工作空间的版本
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_workspace_delete_current_version([MarshalAs(UnmanagedType.LPStr)] string workspace_name);

        /// <summary>
        /// Deletes a specified version of the workspace
        /// </summary>
        /// <summary>
        /// 删除工作空间的指定版本
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="version">Version to delete, must be higher than current version</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_workspace_delete_later_version([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                              int version);

        /// <summary>
        /// Switches the version of the workspace
        /// </summary>
        /// <summary>
        /// 切换工作空间的版本
        /// </summary>
        /// <param name="workspace_name">The name of the workspaces that will be opened. The name has to be unique.</param>
        /// <param name="version">Version to load</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_workspace_switch_version([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                        int version);

        /** @addtogroup Stream */

        /// <summary>
        /// Sets the stream sample mode
        /// </summary>
        /// <summary>
        /// 设置流样本模式
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="sample_name_expr">The regular expression used to extract the sample name from image names</param>
        /// <param name="frame_window">Determines how many consecutive and overlapping frames are generated</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_stream_sample_mode([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                  [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                  [MarshalAs(UnmanagedType.LPStr)] string sample_name_expr,
                                                                  int frame_window);

        /// <summary>
        /// Adds the samples selected by a filter to a given set
        /// </summary>
        /// <summary>
        /// 将过滤器选择的样本添加到给定集合
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="filter">The filter used to select the samples, empty str ("") = all samples</param>
        /// <param name="set">The name of the set</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_stream_add_samples_to_set([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                         [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                         [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                         [MarshalAs(UnmanagedType.LPStr)] string filter,
                                                                         [MarshalAs(UnmanagedType.LPStr)] string set);

        /// <summary>
        /// Removes the samples selected by a filter from a given set
        /// </summary>
        /// <summary>
        /// 从给定集合中移除过滤器选择的样本
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="filter">The filter used to select the samples, empty str ("") = all samples</param>
        /// <param name="set">The name of the set</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_stream_remove_samples_from_set([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                              [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                              [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                              [MarshalAs(UnmanagedType.LPStr)] string filter,
                                                                              [MarshalAs(UnmanagedType.LPStr)] string set);

        /// <summary>
        /// Changes the color for a given set
        /// </summary>
        /// <summary>
        /// 更改给定集合的颜色
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="set_name">The name of the set</param>
        /// <param name="color">Color name</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_stream_change_set_color([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                       [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                       [MarshalAs(UnmanagedType.LPStr)] string set_name,
                                                                       [MarshalAs(UnmanagedType.LPStr)] string color);

        /// <summary>
        /// Removes images according to a filter
        /// </summary>
        /// <summary>
        /// 根据过滤器移除图像
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="filter">The filter used to list the images, empty str ("") = all images</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_stream_remove_images([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                    [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                    [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                    [MarshalAs(UnmanagedType.LPStr)] string filter);

        /// <summary>
        /// Gets a sample image from a stream using a specific channel format specifier
        /// </summary>
        /// <summary>
        /// 使用特定通道格式说明符从流获取样本图像
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="sample_name">The name of the image/sample</param>
        /// <param name="format">Image channel format specifier, if empty returns first</param>
        /// <param name="width">If not 0, width of the returned image</param>
        /// <param name="image">Pointer image structure to hold the retrieved image</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_stream_get_sample_image([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                       [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                       [MarshalAs(UnmanagedType.LPStr)] string sample_name,
                                                                       [MarshalAs(UnmanagedType.LPStr)] string format,
                                                                       int width,
                                                                       ref VIDI_IMAGE image);

        /// <summary>
        /// Gets an image from a stream
        /// </summary>
        /// <summary>
        /// 从流获取图像
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="image_name">The name of the image</param>
        /// <param name="width">If not 0, width of the returned image</param>
        /// <param name="image">Pointer image structure to hold the retrieved image</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_stream_get_image([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                [MarshalAs(UnmanagedType.LPStr)] string image_name,
                                                                int width,
                                                                ref VIDI_IMAGE image);

        /// <summary>
        /// Renames a series of images according to rules
        /// </summary>
        /// <summary>
        /// 根据规则重命名一系列图像
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the stream</param>
        /// <param name="filter">The filter used to list the images, empty str = all images</param>
        /// <param name="prefix">Prefix to add before each filename</param>
        /// <param name="mode">Appends something to the prefix: 0 : old_filename, 1: index, 2: random index</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_stream_rename_images([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                    [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                    [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                    [MarshalAs(UnmanagedType.LPStr)] string filter,
                                                                    [MarshalAs(UnmanagedType.LPStr)] string prefix,
                                                                    uint mode);

        /// <summary>
        /// List the tools
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="response">Buffer to hold the XML fragment listing the tools</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_stream_list_tools([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                 ref VIDI_BUFFER response);

        /// <summary>
        /// Adds an image to the database
        /// </summary>
        /// <summary>
        /// 添加图像到数据库
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="image">Pointer to the image</param>
        /// <param name="image_name">Name of the image</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_stream_add_image_to_database([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                            [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                            ref VIDI_IMAGE image,
                                                                            [MarshalAs(UnmanagedType.LPStr)] string image_name);

        /// <summary>
        /// Adds an image to the database
        /// </summary>
        /// <summary>
        /// 添加图像到数据库
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="image_data">Buffer containing the image encoded in a supported image format</param>
        /// <param name="image_name">Name of the image</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_stream_add_image_from_memory([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                            [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                            ref VIDI_BUFFER image_data,
                                                                            [MarshalAs(UnmanagedType.LPStr)] string image_name);

        /// <summary>
        /// Adds an image to the database
        /// </summary>
        /// <summary>
        /// 添加图像到数据库
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="image">Pointer to the image</param>
        /// <param name="image_name">Name of the image</param>
        /// <param name="added_image_name">Name of the image that was actually added</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_stream_add_image([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                ref VIDI_IMAGE image,
                                                                [MarshalAs(UnmanagedType.LPStr)] string image_name,
                                                                ref VIDI_BUFFER added_image_name);

        /// <summary>
        /// Adds an image to the database
        /// </summary>
        /// <summary>
        /// 添加图像到数据库
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="image_data">Buffer containing the image encoded in a supported image format</param>
        /// <param name="image_name">Name of the image</param>
        /// <param name="added_image_name">Name of the image that was actually added</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_stream_add_encoded_image([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                        [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                        ref VIDI_BUFFER image_data,
                                                                        [MarshalAs(UnmanagedType.LPStr)] string image_name,
                                                                        ref VIDI_BUFFER added_image_name);

        /// <summary>
        /// Adds a tool in the desired stream
        /// </summary>
        /// <summary>
        /// 在指定流中添加工具
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="tool_parent">The parent of the tool in the toolchain, if empty : added directly after input</param>
        /// <param name="type">Type of the tool ("blue", "red", "green")</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_stream_add_tool([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                               [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                               [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                               [MarshalAs(UnmanagedType.LPStr)] string tool_parent,
                                                               [MarshalAs(UnmanagedType.LPStr)] string type);

        /// <summary>
        /// Removes the tool
        /// </summary>
        /// <summary>
        /// 移除工具
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_stream_remove_tool([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                  [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                  [MarshalAs(UnmanagedType.LPStr)] string tool_name);

        /// <summary>
        /// Renames the tool
        /// </summary>
        /// <summary>
        /// 重命名工具
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="new_name">The new name of the tool</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_stream_rename_tool([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                  [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                  [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                  [MarshalAs(UnmanagedType.LPStr)] string new_name);

        /// <summary>
        /// Creates a clone of the tool
        /// </summary>
        /// <summary>
        /// 创建工具的克隆
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="clone_name">The new name of the clone tool</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_stream_clone_tool([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string clone_name);

        /// <summary>
        /// Changes the position of the tool, and it's children in the toolchain
        /// </summary>
        /// <summary>
        /// 更改工具及其子项在工具链中的位置
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="new_parent">The name of the tool on which the selected tool will be attached</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_stream_move_tool([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                [MarshalAs(UnmanagedType.LPStr)] string new_parent);

        /** @addtogroup Tool */

        /// <summary>
        /// List the database according to the filter
        /// </summary>
        /// <summary>
        /// 根据过滤器列出数据库
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="filter">Filter applied to filter the response</param>
        /// <param name="sort">Sorting criteria applied to filter the response</param>
        /// <param name="ascending">Sort ascending regarding the sorting criteria if 0, descending if 1</param>
        /// <param name="res_buffer">Pointer to an initialized buffer</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_tool_list_database([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                  [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                  [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                  [MarshalAs(UnmanagedType.LPStr)] string filter,
                                                                  [MarshalAs(UnmanagedType.LPStr)] string sort,
                                                                  int ascending,
                                                                  ref VIDI_BUFFER res_buffer);

        /// <summary>
        /// Process the database according to the filter
        /// </summary>
        /// <summary>
        /// 根据过滤器处理数据库
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="filter">Filter applied to filter the response</param>
        /// <param name="gpu_list">Comma separated string containing the gpu to be used</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_tool_process_database([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                     [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                     [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                     [MarshalAs(UnmanagedType.LPStr)] string filter,
                                                                     [MarshalAs(UnmanagedType.LPStr)] string gpu_list);

        /// <summary>
        /// Update the database according to the filter
        /// </summary>
        /// <summary>
        /// 根据过滤器更新数据库
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="filter">Filter applied to filter the response</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_tool_update_database([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                    [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                    [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                    [MarshalAs(UnmanagedType.LPStr)] string filter);

        /// <summary>
        /// Update the database labels to reflect the latest parameters
        /// </summary>
        /// <summary>
        /// 更新数据库标签以反映最新参数
        /// </summary>
        /// <param name="ws_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_tool_update_database_labels([MarshalAs(UnmanagedType.LPStr)] string ws_name,
                                                                           [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                           [MarshalAs(UnmanagedType.LPStr)] string tool_name);

        /// <summary>
        /// Renames a feature/region/tag of a tool
        /// </summary>
        /// <summary>
        /// 重命名工具的特征/区域/标签
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="name">Current class name</param>
        /// <param name="new_name">New class name</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_tool_rename_class([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string new_name);

        /// <summary>
        /// Removes a feature/region/tag of a tool
        /// </summary>
        /// <summary>
        /// 移除工具的特征/区域/标签
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="name">Class name</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_tool_remove_class([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string name);

        /// <summary>
        /// Sets the color of a region/tag of a tool
        /// </summary>
        /// <summary>
        /// 设置工具区域/标签的颜色
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="name">Class name</param>
        /// <param name="color">The new color associated to the class</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_tool_set_class_color([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                    [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                    [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                    [MarshalAs(UnmanagedType.LPStr)] string name,
                                                                    [MarshalAs(UnmanagedType.LPStr)] string color);

        /// <summary>
        /// Gets all tool parameters
        /// </summary>
        /// <summary>
        /// 获取所有工具参数
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="value">Buffer to hold the parameters</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_tool_list_parameters([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                    [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                    [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                    ref VIDI_BUFFER value);

        /// <summary>
        /// Set the tool parameter
        /// </summary>
        /// <summary>
        /// 设置工具参数
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="parameter">The name of the parameter</param>
        /// <param name="value">String containing the value</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_tool_set_parameter([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                  [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                  [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                  [MarshalAs(UnmanagedType.LPStr)] string parameter,
                                                                  [MarshalAs(UnmanagedType.LPStr)] string value);

        /// <summary>
        /// Turn-on incremental-learning mode based on given pretrained model
        /// </summary>
        /// <summary>
        /// 基于给定预训练模型开启增量学习模式
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the existing tool</param>
        /// <param name="pretrained_tool_path">Path of the tool archive</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_tool_set_incremental_learning([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                             [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                             [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                             [MarshalAs(UnmanagedType.LPStr)] string pretrained_tool_path);

        /// <summary>
        /// Turn-off incremental-learning mode and remove saved pretrained-model
        /// </summary>
        /// <summary>
        /// 关闭增量学习模式并移除保存的预训练模型
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the existing tool</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_tool_unset_incremental_learning([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                               [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                               [MarshalAs(UnmanagedType.LPStr)] string tool_name);

        /// <summary>
        /// Get the tool parameter
        /// </summary>
        /// <summary>
        /// 获取工具参数
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="parameter">The name of the parameter</param>
        /// <param name="value">Pointer to an initialized buffer used to return a string containing the value</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_tool_get_parameter([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                  [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                  [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                  [MarshalAs(UnmanagedType.LPStr)] string parameter,
                                                                  ref VIDI_BUFFER value);

        /// <summary>
        /// Internal use only
        /// </summary>
        /// <summary>
        /// 仅限内部使用
        /// </summary>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_tool_exec_command([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string command,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string arguments,
                                                                 ref VIDI_BUFFER result);

        /// <summary>
        /// Deprecated. Please use the vidi_training_tool_train2
        /// </summary>
        /// <summary>
        /// 已弃用。请使用vidi_training_tool_train2
        /// </summary>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_tool_train([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                          [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                          [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                          [MarshalAs(UnmanagedType.LPStr)] string gpu_list);

        /// <summary>
        /// Trains the tool, returns immediately
        /// </summary>
        /// <summary>
        /// 训练工具，立即返回
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="gpu_list">List of gpu where the tool can be trained on</param>
        /// <param name="training_artifact_key">The key of the training artifact the train method should use to start the training</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_tool_train2([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                           [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                           [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                           [MarshalAs(UnmanagedType.LPStr)] string gpu_list,
                                                           [MarshalAs(UnmanagedType.LPStr)] string training_artifact_key);

        /// <summary>
        /// An extended API that is able to stop training immediately
        /// </summary>
        /// <summary>
        /// 可立即停止训练的扩展API
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="gpu_list">List of gpu where the tool can be trained on</param>
        /// <param name="training_artifact_key">The key of the training artifact the train method should use to start the training</param>
        /// <param name="callback_train_cancelled">A function that returns a boolean value which indicates whether the train is cancelled</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_tool_train3([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                           [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                           [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                           [MarshalAs(UnmanagedType.LPStr)] string gpu_list,
                                                           [MarshalAs(UnmanagedType.LPStr)] string training_artifact_key,
                                                           CallbackTrainCancelled callback_train_cancelled);

        /// <summary>
        /// Resets the tool
        /// </summary>
        /// <summary>
        /// 重置工具
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_tool_reset([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                          [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                          [MarshalAs(UnmanagedType.LPStr)] string tool_name);

        /// <summary>
        /// Changes tool parameters to make it compatible with a deployment target
        /// </summary>
        /// <summary>
        /// 更改工具参数使其与部署目标兼容
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="deployment_target">The deployment target</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_tool_make_target_compatible([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                           [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                           [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                           [MarshalAs(UnmanagedType.LPStr)] string deployment_target);

        /// <summary>
        /// Interrupts the operation of a specific task of the current tool
        /// </summary>
        /// <summary>
        /// 中断当前工具的特定任务操作
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="tool_task">The task of the tool, currently either "0" for training or "1" for processing</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_tool_interrupt_task([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                   [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                   [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                   uint tool_task);

        /// <summary>
        /// Interrupts all current tool operations
        /// </summary>
        /// <summary>
        /// 中断所有当前工具操作
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_tool_interrupt([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                              [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                              [MarshalAs(UnmanagedType.LPStr)] string tool_name);

        /// <summary>
        /// Blocks until the tool has finished it's task or for a certain time
        /// </summary>
        /// <summary>
        /// 阻塞直到工具完成任务或达到指定时间
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="timeout">Blocking time in milliseconds: if 0, wait indefinitely for the tool to finish its current task</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_tool_wait([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                         [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                         [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                         uint timeout);

        /// <summary>
        /// Blocks until the tool has finished it's task or for a certain time
        /// </summary>
        /// <summary>
        /// 阻塞直到工具完成任务或达到指定时间
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="tool_task">The tool task, currently either "0" for training or "1" for processing</param>
        /// <param name="timeout">Blocking time in milliseconds: if 0, wait indefinitely for the tool to finish its current task</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_tool_wait_on_task([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                 uint tool_task,
                                                                 uint timeout);

        /// <summary>
        /// Update the parameters of the tool with the default parameter of the current version
        /// </summary>
        /// <summary>
        /// 使用当前版本的默认参数更新工具参数
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_tool_update_parameters([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                      [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                      [MarshalAs(UnmanagedType.LPStr)] string tool_name);

        /// <summary>
        /// Gets the progress and ETA of the tool
        /// </summary>
        /// <summary>
        /// 获取工具的进度和预计完成时间
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="status">Buffer to hold the XML fragment</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_tool_get_status([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                               [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                               [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                               ref VIDI_BUFFER status);

        /// <summary>
        /// Exports a single tool
        /// </summary>
        /// <summary>
        /// 导出单个工具
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="file_name">File to export the tool to</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_tool_export_to_file([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                   [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                   [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                   [MarshalAs(UnmanagedType.LPStr)] string file_name);

        /// <summary>
        /// Exports a single tool
        /// </summary>
        /// <summary>
        /// 导出单个工具
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="tool_data">Buffer to hold the tool data</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_tool_export_to_memory([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                     [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                     [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                     ref VIDI_BUFFER tool_data);

        /// <summary>
        /// Imports and replaces a single tool from a file
        /// </summary>
        /// <summary>
        /// 从文件导入并替换单个工具
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the existing tool</param>
        /// <param name="file_name">Path of the tool archive</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_tool_import_from_file([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                     [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                     [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                     [MarshalAs(UnmanagedType.LPStr)] string file_name);

        /// <summary>
        /// Exports a tool's training artifact to a file
        /// </summary>
        /// <summary>
        /// 将工具的训练产物导出到文件
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the existing tool</param>
        /// <param name="file_name">Path of the training artifact archive</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_export_artifact_to_file([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                       [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                       [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                       [MarshalAs(UnmanagedType.LPStr)] string file_name);

        /// <summary>
        /// Exports a tool's training artifact to a memory buffer
        /// </summary>
        /// <summary>
        /// 将工具的训练产物导出到内存缓冲区
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the existing tool</param>
        /// <param name="training_artifact">Buffer to hold the training artifact data</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_export_artifact_to_memory([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                         [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                         [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                         ref VIDI_BUFFER training_artifact);

        /// <summary>
        /// Import the workspace from the memory
        /// </summary>
        /// <summary>
        /// 从内存导入工作空间
        /// </summary>
        /// <param name="workspace_name">The target name of the imported workspace, has to be unique.</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the existing tool</param>
        /// <param name="tool_data">Buffer holding the tool data</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_tool_import_from_memory([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                       [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                       [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                       ref VIDI_BUFFER tool_data);

        /// <summary>
        /// Import a tool's training artifacts from file
        /// </summary>
        /// <summary>
        /// 从文件导入工具的训练产物
        /// </summary>
        /// <param name="ws_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the existing tool</param>
        /// <param name="file_name">Path of the training artifact archive</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_import_artifact_from_file([MarshalAs(UnmanagedType.LPStr)] string ws_name,
                                                                         [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                         [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                         [MarshalAs(UnmanagedType.LPStr)] string file_name);

        /// <summary>
        /// Import a tool's training artifacts from the memory
        /// </summary>
        /// <summary>
        /// 从内存导入工具的训练产物
        /// </summary>
        /// <param name="ws_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the existing tool</param>
        /// <param name="buffer">Buffer holding the training artifact data</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_import_artifact_from_memory([MarshalAs(UnmanagedType.LPStr)] string ws_name,
                                                                           [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                           [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                           ref VIDI_BUFFER buffer);

        /// <summary>
        /// Import a trained suakit tool from file
        /// </summary>
        /// <summary>
        /// 从文件导入训练好的suakit工具
        /// </summary>
        /// <param name="ws_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the existing tool</param>
        /// <param name="file_name">Path to the trained suakit model file</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_import_suakit_model_from_file([MarshalAs(UnmanagedType.LPStr)] string ws_name,
                                                                             [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                             [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                             [MarshalAs(UnmanagedType.LPStr)] string file_name);

        /// <summary>
        /// Import a trained suakit tool from the memory
        /// </summary>
        /// <summary>
        /// 从内存导入训练好的suakit工具
        /// </summary>
        /// <param name="ws_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the existing tool</param>
        /// <param name="buffer">Buffer holding the training artifact data</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_import_suakit_model_from_memory([MarshalAs(UnmanagedType.LPStr)] string ws_name,
                                                                               [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                               [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                               ref VIDI_BUFFER buffer);

        /// <summary>
        /// Returns a summary about a tool's database in XML format
        /// </summary>
        /// <summary>
        /// 以XML格式返回工具数据库的摘要
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="options">Internal use only</param>
        /// <param name="statistics">Buffer to hold the XML document</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_tool_get_database_summary([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                         [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                         [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                         [MarshalAs(UnmanagedType.LPStr)] string options,
                                                                         ref VIDI_BUFFER statistics);

        /// <summary>
        /// Gets the marking from the tool
        /// </summary>
        /// <summary>
        /// 从工具获取标记
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="image_name">Image identifier</param>
        /// <param name="options">Reserved use</param>
        /// <param name="marking">Buffer to hold the XML fragment of the marking</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_tool_get_marking([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                [MarshalAs(UnmanagedType.LPStr)] string image_name,
                                                                [MarshalAs(UnmanagedType.LPStr)] string options,
                                                                ref VIDI_BUFFER marking);

        /** @addtogroup ROI */

        /// <summary>
        /// Gets a preview of the region-of-interest for a database image
        /// </summary>
        /// <summary>
        /// 获取数据库图像的感兴趣区域预览
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="image_key">Image frame key pair</param>
        /// <param name="preview">Buffer to hold the XML response</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_roi_preview([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                           [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                           [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                           [MarshalAs(UnmanagedType.LPStr)] string image_key,
                                                           ref VIDI_BUFFER preview);

        /// <summary>
        /// Apply changes made to the preview ROI parameters
        /// </summary>
        /// <summary>
        /// 应用对预览ROI参数所做的更改
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_roi_apply_preview([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string tool_name);

        /// <summary>
        /// Discard changes made to the preview ROI parameters
        /// </summary>
        /// <summary>
        /// 放弃对预览ROI参数所做的更改
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_roi_discard_preview([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                   [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                   [MarshalAs(UnmanagedType.LPStr)] string tool_name);

        /** @addtogroup Blue */

        /// <summary>
        /// Add a new feature or set the values of an existing feature
        /// </summary>
        /// <summary>
        /// 添加新特征或设置现有特征的值
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="view_id">View identifier</param>
        /// <param name="feature_idx">The index of the feature to change or &lt; 0 to add a new feature</param>
        /// <param name="id">Feature id (A-Z , 0-9)</param>
        /// <param name="pos_x">X position of the feature, in the view coordinates</param>
        /// <param name="pos_y">Y position of the feature, in the view coordinates</param>
        /// <param name="angle">Angle of the feature</param>
        /// <param name="width">Width of the feature</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_blue_set_feature([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                [MarshalAs(UnmanagedType.LPStr)] string view_id,
                                                                int feature_idx,
                                                                [MarshalAs(UnmanagedType.LPStr)] string id,
                                                                double pos_x, double pos_y,
                                                                double angle, double width);

        /// <summary>
        /// Add a new feature or set the values of an existing feature
        /// </summary>
        /// <summary>
        /// 添加新特征或设置现有特征的值
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="view_id">View identifier</param>
        /// <param name="feature_idx">The index of the feature to change or &lt; 0 to add a new feature</param>
        /// <param name="id">Feature id (A-Z , 0-9)</param>
        /// <param name="pos_x">X position of the feature, in the view coordinates</param>
        /// <param name="pos_y">Y position of the feature, in the view coordinates</param>
        /// <param name="angle">Angle of the feature</param>
        /// <param name="width">Width of the feature</param>
        /// <param name="height">Height of the feature</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_blue_set_feature_rect([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                     [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                     [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                     [MarshalAs(UnmanagedType.LPStr)] string view_id,
                                                                     int feature_idx,
                                                                     [MarshalAs(UnmanagedType.LPStr)] string id,
                                                                     double pos_x, double pos_y,
                                                                     double angle, double width, double height);

        /// <summary>
        /// Removes an existing feature
        /// </summary>
        /// <summary>
        /// 移除现有特征
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="view_id">View identifier</param>
        /// <param name="labeled">Label status of the feature</param>
        /// <param name="feature_idx">Index of the feature</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_blue_remove_feature([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                   [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                   [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                   [MarshalAs(UnmanagedType.LPStr)] string view_id,
                                                                   uint labeled,
                                                                   uint feature_idx);

        /// <summary>
        /// Creates a new model
        /// </summary>
        /// <summary>
        /// 创建新模型
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="model_name">The name of the model</param>
        /// <param name="model_type">The type of the model</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_blue_create_model([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string model_name,
                                                                 uint model_type);

        /// <summary>
        /// Renames an existing model
        /// </summary>
        /// <summary>
        /// 重命名现有模型
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="model_name">The name of the model</param>
        /// <param name="new_name">The new name of the model</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_blue_rename_model([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string model_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string new_name);

        /// <summary>
        /// Removes an existing model
        /// </summary>
        /// <summary>
        /// 移除现有模型
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="model_name">The name of the model</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_blue_remove_model([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string model_name);

        /// <summary>
        /// Retrieves the existing models
        /// </summary>
        /// <summary>
        /// 检索现有模型
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="res_buffer">Pointer to a initialized buffer used to return the list as XML fragment</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_blue_list_models([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                ref VIDI_BUFFER res_buffer);

        /// <summary>
        /// Export a model from a blue tool
        /// </summary>
        /// <summary>
        /// 从蓝色工具导出模型
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="model_name">The name of the model</param>
        /// <param name="buffer">Pointer to a buffer</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_blue_export_model([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string model_name,
                                                                 ref VIDI_BUFFER buffer);

        /// <summary>
        /// Import a model into a blue tool
        /// </summary>
        /// <summary>
        /// 将模型导入蓝色工具
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="model_name">The name of the model</param>
        /// <param name="buffer">Pointer to a buffer</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_blue_import_model([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string model_name,
                                                                 ref VIDI_BUFFER buffer);

        /** @addtogroup Model */

        /// <summary>
        /// Add a node to a model
        /// </summary>
        /// <summary>
        /// 向模型添加节点
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="model_name">The name of the model</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_model_add_node([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                              [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                              [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                              [MarshalAs(UnmanagedType.LPStr)] string model_name);

        /// <summary>
        /// Removes a node from the model
        /// </summary>
        /// <summary>
        /// 从模型中移除节点
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="model_name">The name of the model</param>
        /// <param name="node_idx">The id of the node to delete</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_model_remove_node([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string model_name,
                                                                 uint node_idx);

        /// <summary>
        /// Lists the nodes of a model
        /// </summary>
        /// <summary>
        /// 列出模型的节点
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the blue tool</param>
        /// <param name="model_name">The name of the model</param>
        /// <param name="result">Pointer to an initialized buffer used to return the list as XML fragment</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_model_list_nodes([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                [MarshalAs(UnmanagedType.LPStr)] string model_name,
                                                                ref VIDI_BUFFER result);

        /// <summary>
        /// List the regions from the layout model
        /// </summary>
        /// <summary>
        /// 列出布局模型的区域
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="model_name">The name of the model</param>
        /// <param name="result">Buffer containing the result</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_layout_model_list_regions([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                         [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                         [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                         [MarshalAs(UnmanagedType.LPStr)] string model_name,
                                                                         ref VIDI_BUFFER result);

        /// <summary>
        /// Adds a region to the layout model
        /// </summary>
        /// <summary>
        /// 向布局模型添加区域
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="model_name">The name of the model</param>
        /// <param name="region_name">The name of the region to add, must be unique</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_layout_model_add_region([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                       [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                       [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                       [MarshalAs(UnmanagedType.LPStr)] string model_name,
                                                                       [MarshalAs(UnmanagedType.LPStr)] string region_name);

        /// <summary>
        /// Removes a region from the layout model
        /// </summary>
        /// <summary>
        /// 从布局模型中移除区域
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="model_name">The name of the model</param>
        /// <param name="region_idx">The id of the region to delete</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_layout_model_remove_region([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                          [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                          [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                          [MarshalAs(UnmanagedType.LPStr)] string model_name,
                                                                          uint region_idx);

        /** @addtogroup View */

        /// <summary>
        /// Sets the training flag of views
        /// </summary>
        /// <summary>
        /// 设置视图的训练标志
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="filter">Specifies the filter</param>
        /// <param name="train">1: always, 0: never, -1: auto</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_tool_set_view_train([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                   [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                   [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                   [MarshalAs(UnmanagedType.LPStr)] string filter,
                                                                   int train);

        /// <summary>
        /// Sets the group of views
        /// </summary>
        /// <summary>
        /// 设置视图组
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="filter">Specifies the filter</param>
        /// <param name="group">The group string</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_tool_set_view_group([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                   [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                   [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                   [MarshalAs(UnmanagedType.LPStr)] string filter,
                                                                   [MarshalAs(UnmanagedType.LPStr)] string group);

        /// <summary>
        /// Accepts the views selected
        /// </summary>
        /// <summary>
        /// 接受选定的视图
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="filter">Specifies the filter</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_tool_accept_views([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string filter);

        /// <summary>
        /// Gets the sample view from the tool with a specific channel format
        /// </summary>
        /// <summary>
        /// 使用特定通道格式从工具获取样本视图
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="view_key">View identifier</param>
        /// <param name="format">Image channel format specifier, if empty the tool's channel format is used</param>
        /// <param name="width">Desired width of the view, if 0 = native</param>
        /// <param name="view_image">Pointer to an initialized image</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_tool_get_sample_image([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                     [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                     [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                     [MarshalAs(UnmanagedType.LPStr)] string view_key,
                                                                     [MarshalAs(UnmanagedType.LPStr)] string format,
                                                                     int width,
                                                                     ref VIDI_IMAGE view_image);

        /// <summary>
        /// Gets the view from the tool
        /// </summary>
        /// <summary>
        /// 从工具获取视图
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="view_key">View identifier</param>
        /// <param name="width">Desired width of the view, if 0 = native</param>
        /// <param name="view_image">Pointer to an initialized image</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_tool_get_image([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                              [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                              [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                              [MarshalAs(UnmanagedType.LPStr)] string view_key,
                                                              int width,
                                                              ref VIDI_IMAGE view_image);

        /// <summary>
        /// Clears the views according to filter
        /// </summary>
        /// <summary>
        /// 根据过滤器清除视图
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="filter">Specifies the filter</param>
        /// <param name="what">Specifies what to clear (markings, labels, all)</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_tool_clear_views([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                [MarshalAs(UnmanagedType.LPStr)] string filter,
                                                                int what);

        /// <summary>
        /// Convert TRT
        /// </summary>
        /// <summary>
        /// 转换TRT
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="gpu_list">GPU list</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_tool_convert_trt([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                [MarshalAs(UnmanagedType.LPStr)] string gpu_list);

        /** @addtogroup Mask */

        /// <summary>
        /// Sets the mask for the views selected by filter
        /// </summary>
        /// <summary>
        /// 为过滤器选定的视图设置掩码
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="filter">Filter selecting the views</param>
        /// <param name="mask_image">Image containing the mask, if 0, clears the mask</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_view_set_mask([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                             [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                             [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                             [MarshalAs(UnmanagedType.LPStr)] string filter,
                                                             ref VIDI_IMAGE mask_image);

        /// <summary>
        /// Sets the mask of the views selected by filter
        /// </summary>
        /// <summary>
        /// 为过滤器选定的视图设置掩码
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="view_key">View identifier</param>
        /// <param name="mask_image">Registered image that will contain the mask</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_view_get_mask([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                             [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                             [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                             [MarshalAs(UnmanagedType.LPStr)] string view_key,
                                                             ref VIDI_IMAGE mask_image);

        /// <summary>
        /// Assigns the views in a database to the training set according to a filter
        /// </summary>
        /// <summary>
        /// 根据过滤器将数据库中的视图分配到训练集
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="filter">View filter identifying the eligible views</param>
        /// <param name="count">The total number (&gt;1) or percentage (&lt;1) of views to select</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_database_select_training_set([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                            [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                            [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                            [MarshalAs(UnmanagedType.LPStr)] string filter,
                                                                            double count);

        /// <summary>
        /// Sets the mask of the region of interest, applies to all images/views
        /// </summary>
        /// <summary>
        /// 设置感兴趣区域的掩码，应用于所有图像/视图
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="mask_image">Image containing the mask, if 0, clears the mask</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_roi_set_mask([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                            [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                            [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                            ref VIDI_IMAGE mask_image);

        /// <summary>
        /// Clears all region of interests on the tool's next process
        /// </summary>
        /// <summary>
        /// 在工具的下一个处理中清除所有感兴趣区域
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="name">Identifier of the image sample name or filename</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_roi_clear_views([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                               [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                               [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                               [MarshalAs(UnmanagedType.LPStr)] string name);

        /// <summary>
        /// Adds a region of interest on the tool's next process
        /// </summary>
        /// <summary>
        /// 在工具的下一个处理中添加感兴趣区域
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="name">The name of the sample/image to whom the view has to be added</param>
        /// <param name="width">Width of the roi</param>
        /// <param name="height">Height of the roi</param>
        /// <param name="m00">Parameter of the pose matrix</param>
        /// <param name="m10">Parameter of the pose matrix</param>
        /// <param name="m01">Parameter of the pose matrix</param>
        /// <param name="m11">Parameter of the pose matrix</param>
        /// <param name="m02">Parameter of the pose matrix</param>
        /// <param name="m12">Parameter of the pose matrix</param>
        /// <param name="mask_image">Image containing the mask, if 0, no mask is used</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_roi_add_view([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                            [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                            [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                            [MarshalAs(UnmanagedType.LPStr)] string name,
                                                            uint width, uint height,
                                                            double m00, double m10,
                                                            double m01, double m11,
                                                            double m02, double m12,
                                                            ref VIDI_IMAGE mask_image);

        /// <summary>
        /// Gets the mask of the region of interest
        /// </summary>
        /// <summary>
        /// 获取感兴趣区域的掩码
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="mask_image">Registered image that will contain the mask</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_roi_get_mask([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                            [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                            [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                            ref VIDI_IMAGE mask_image);

        /// <summary>
        /// Exports the roi as a binary fragment
        /// </summary>
        /// <summary>
        /// 将ROI导出为二进制片段
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="buffer">Pointer to an initialized buffer</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_roi_export([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                          [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                          [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                          ref VIDI_BUFFER buffer);

        /// <summary>
        /// Imports an roi from a binary fragment
        /// </summary>
        /// <summary>
        /// 从二进制片段导入ROI
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="buffer">Buffer containing the binary fragment</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_roi_import([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                          [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                          [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                          ref VIDI_BUFFER buffer);

        /** @addtogroup Red */

        /// <summary>
        /// Label the views according to the filter
        /// </summary>
        /// <summary>
        /// 根据过滤器标记视图
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="filter">Filter to select the views to label</param>
        /// <param name="class_name">Empty class name ("") for good , "bad" for bad</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_red_label_views([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                               [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                               [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                               [MarshalAs(UnmanagedType.LPStr)] string filter,
                                                               [MarshalAs(UnmanagedType.LPStr)] string class_name);

        /// <summary>
        /// Label the views with regions
        /// </summary>
        /// <summary>
        /// 使用区域标记视图
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="filter">Filter to select the views to label</param>
        /// <param name="class_name">Empty class name ("") for good , "bad" for bad</param>
        /// <param name="region">Image containing the different region, if 0, clears the region</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_red_set_region_image([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                    [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                    [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                    [MarshalAs(UnmanagedType.LPStr)] string filter,
                                                                    [MarshalAs(UnmanagedType.LPStr)] string class_name,
                                                                    ref VIDI_IMAGE region);

        /// <summary>
        /// Get the regions image
        /// </summary>
        /// <summary>
        /// 获取区域图像
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="view_key">View identifier</param>
        /// <param name="class_name">Empty class name ("") for good , "bad" for bad</param>
        /// <param name="region">Registered image that will contain the region</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_red_get_region_image([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                    [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                    [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                    [MarshalAs(UnmanagedType.LPStr)] string view_key,
                                                                    [MarshalAs(UnmanagedType.LPStr)] string class_name,
                                                                    ref VIDI_IMAGE region);

        /// <summary>
        /// Remove a region
        /// </summary>
        /// <summary>
        /// 移除区域
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="view_key">View identifier</param>
        /// <param name="labeled">Label status of the region</param>
        /// <param name="region_idx">The index of the region</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_red_remove_region([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                 [MarshalAs(UnmanagedType.LPStr)] string view_key,
                                                                 uint labeled,
                                                                 uint region_idx);

        /// <summary>
        /// Remove a region
        /// </summary>
        /// <summary>
        /// 移除区域
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="view_key">View identifier</param>
        /// <param name="class_name">The region's class name</param>
        /// <param name="outer_count_points">The number of points on the outer contour</param>
        /// <param name="outer_points">Array of outer contour point x and y coordinates</param>
        /// <param name="count_inners">The number of inner contours</param>
        /// <param name="inner_count_points">Array of inner contour point counts</param>
        /// <param name="inner_points">Array of all inner contour point x and y coordinates</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_red_add_region([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                              [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                              [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                              [MarshalAs(UnmanagedType.LPStr)] string view_key,
                                                              [MarshalAs(UnmanagedType.LPStr)] string class_name,
                                                              uint outer_count_points,
                                                              double[] outer_points,
                                                              uint count_inners,
                                                              uint[] inner_count_points,
                                                              double[] inner_points);

        /// <summary>
        /// Measure the baseline for the red tool
        /// </summary>
        /// <summary>
        /// 测量红色工具的基线
        /// </summary>
        /// <param name="ws_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_red_measure_baseline([MarshalAs(UnmanagedType.LPStr)] string ws_name,
                                                                    [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                    [MarshalAs(UnmanagedType.LPStr)] string tool_name);

        /** @addtogroup Green */

        /// <summary>
        /// Tag the views according to the filter
        /// </summary>
        /// <summary>
        /// 根据过滤器标记视图
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="filter">Filter to select the views to label</param>
        /// <param name="value">The view's tag name or a regular expression to extract the tag from the image filename</param>
        /// <param name="mode">If set to 1, use value as regular expression to extract the tag from the image filename</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_green_tag_views([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                               [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                               [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                               [MarshalAs(UnmanagedType.LPStr)] string filter,
                                                               [MarshalAs(UnmanagedType.LPStr)] string value,
                                                               uint mode);

        /// <summary>
        /// Set selected views as reference views for the similarity model
        /// </summary>
        /// <summary>
        /// 将选定的视图设置为相似性模型的参考视图
        /// </summary>
        /// <param name="ws_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the green tool</param>
        /// <param name="database_filter">Filter to select the views to be set as reference views</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_green_set_similarity_reference_views([MarshalAs(UnmanagedType.LPStr)] string ws_name,
                                                                                    [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                                    [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                                    [MarshalAs(UnmanagedType.LPStr)] string database_filter);

        /// <summary>
        /// Lists the reference views of the tool's similarity model
        /// </summary>
        /// <summary>
        /// 列出工具相似性模型的参考视图
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="value">Pointer to an initialized buffer used to return an xml fragments</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_green_list_similarity_reference_views([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                                     [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                                     [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                                     ref VIDI_BUFFER value);

        /// <summary>
        /// Train tool's similarity model
        /// </summary>
        /// <summary>
        /// 训练工具的相似性模型
        /// </summary>
        /// <param name="ws_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the green tool</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_green_train_similarity_model([MarshalAs(UnmanagedType.LPStr)] string ws_name,
                                                                            [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                            [MarshalAs(UnmanagedType.LPStr)] string tool_name);

        /** @addtogroup TrainingSample */

        /// <summary>
        /// Creates a new sample with the given image
        /// </summary>
        /// <summary>
        /// 使用给定图像创建新样本
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="sample_name">The name of the sample</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_create_sample([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                             [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                             [MarshalAs(UnmanagedType.LPStr)] string sample_name);

        /// <summary>
        /// Adds an image to a sample
        /// </summary>
        /// <summary>
        /// 向样本添加图像
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="sample_name">The name of the sample</param>
        /// <param name="image">The image to add</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_sample_add_image([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                [MarshalAs(UnmanagedType.LPStr)] string sample_name,
                                                                ref VIDI_IMAGE image);

        /// <summary>
        /// Releases a previously created sample
        /// </summary>
        /// <summary>
        /// 释放先前创建的样本
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="sample_name">The name of the sample</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_free_sample([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                           [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                           [MarshalAs(UnmanagedType.LPStr)] string sample_name);

        /// <summary>
        /// Get a sample in XML format
        /// </summary>
        /// <summary>
        /// 以XML格式获取样本
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="sample_name">The name of the sample</param>
        /// <param name="buffer">A pointer to a initialized buffer to which the XML will be written</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_get_sample([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                          [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                          [MarshalAs(UnmanagedType.LPStr)] string sample_name,
                                                          ref VIDI_BUFFER buffer);

        /// <summary>
        /// Lists the available samples
        /// </summary>
        /// <summary>
        /// 列出可用样本
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="buffer">A pointer to a initialized buffer to which the list will be written</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_list_samples([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                            [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                            ref VIDI_BUFFER buffer);

        /// <summary>
        /// Process a given sample by a tool
        /// </summary>
        /// <summary>
        /// 通过工具处理给定样本
        /// </summary>
        /// <param name="workspace_name">The name of the workspace containing the tool</param>
        /// <param name="stream_name">The name of the stream containing the tool</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="sample_name">Name of the sample</param>
        /// <param name="gpu_list">List of coma separated gpu number to use for the processing</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_sample_process([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                              [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                              [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                              [MarshalAs(UnmanagedType.LPStr)] string sample_name,
                                                              [MarshalAs(UnmanagedType.LPStr)] string gpu_list);

        /// <summary>
        /// Gets the view for a processed sample
        /// </summary>
        /// <summary>
        /// 获取已处理样本的视图
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="view_key">The key identifying the view</param>
        /// <param name="format">The channel format, if empty the tool's channel format is used</param>
        /// <param name="view_image">Image that will contain the view</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_sample_get_image([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                [MarshalAs(UnmanagedType.LPStr)] string view_key,
                                                                [MarshalAs(UnmanagedType.LPStr)] string format,
                                                                ref VIDI_IMAGE view_image);

        /// <summary>
        /// Get the trained model information
        /// </summary>
        /// <summary>
        /// 获取训练模型信息
        /// </summary>
        /// <param name="trained_model_path">The trained model path</param>
        /// <param name="trained_model_info">Buffer to hold the XML fragment of the trained model information</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_get_trained_model_info([MarshalAs(UnmanagedType.LPStr)] string trained_model_path,
                                                                      ref VIDI_BUFFER trained_model_info);

        /// <summary>
        /// Get the available maximum image size of greensua
        /// </summary>
        /// <summary>
        /// 获取greensua的可用最大图像尺寸
        /// </summary>
        /// <param name="gpu_memory_size">GPU memory size</param>
        /// <param name="model_capacity">The base model capacity for executing ClassificationTrainer</param>
        /// <param name="num_classes">Buffer to hold the XML fragment of the number of classes</param>
        /// <param name="aspect_ratio">Buffer to hold the XML fragment of the aspect ratio (width / height)</param>
        /// <param name="maximum_size">Buffer to hold the XML fragment of the maximum available view size</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_get_available_maximum_image_size(ulong gpu_memory_size,
                                                                                int model_capacity,
                                                                                int num_classes,
                                                                                float aspect_ratio,
                                                                                ref VIDI_BUFFER maximum_size);

        /// <summary>
        /// Get the loss graph data for the HDM Tool
        /// </summary>
        /// <summary>
        /// 获取HDM工具的损失图数据
        /// </summary>
        /// <param name="workspace_name">The name of the workspace containing the tool</param>
        /// <param name="stream_name">The name of the stream containing the tool</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="is_realtime">Condition for realtime</param>
        /// <param name="last_idx">Base index you want to get data</param>
        /// <param name="loss_graph_data">Buffer to hold the XML fragment of the loss graph data</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_get_loss_graph_data([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                   [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                   [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                                   uint is_realtime,
                                                                   uint last_idx,
                                                                   ref VIDI_BUFFER loss_graph_data);

        /// <summary>
        /// Restore the backed up loss graph data for the HDM Tool
        /// </summary>
        /// <summary>
        /// 恢复HDM工具的备份损失图数据
        /// </summary>
        /// <param name="workspace_name">The name of the workspace containing the tool</param>
        /// <param name="stream_name">The name of the stream containing the tool</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_restore_loss_graph_data([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                       [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                       [MarshalAs(UnmanagedType.LPStr)] string tool_name);

        /// <summary>
        /// Clear the backed up loss graph data for the HDM Tool
        /// </summary>
        /// <summary>
        /// 清除HDM工具的备份损失图数据
        /// </summary>
        /// <param name="workspace_name">The name of the workspace containing the tool</param>
        /// <param name="stream_name">The name of the stream containing the tool</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_clear_backup_loss_graph_data([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                            [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                            [MarshalAs(UnmanagedType.LPStr)] string tool_name);

        /// <summary>
        /// Check for tags when importing the Green HDM tool
        /// </summary>
        /// <summary>
        /// 导入绿色HDM工具时检查标签
        /// </summary>
        /// <param name="workspace_name">The name of the workspace</param>
        /// <param name="stream_name">The name of the stream</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <param name="buffer">Buffer to hold the tool data</param>
        /// <param name="result">Buffer to hold the XML fragment</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_validate_tool([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                             [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                             [MarshalAs(UnmanagedType.LPStr)] string tool_name,
                                                             ref VIDI_BUFFER buffer,
                                                             ref VIDI_BUFFER result);

        /// <summary>
        /// Update labeled tags to be valid tags
        /// </summary>
        /// <summary>
        /// 更新标记的标签为有效标签
        /// </summary>
        /// <param name="workspace_name">The name of the workspace containing the tool</param>
        /// <param name="stream_name">The name of the stream containing the tool</param>
        /// <param name="tool_name">The name of the tool</param>
        /// <returns>0 if passed, otherwise an error_code that can be used with vidi_get_error_message()</returns>
        [DllImport(ViDiDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint vidi_training_update_labeled_tags([MarshalAs(UnmanagedType.LPStr)] string workspace_name,
                                                                   [MarshalAs(UnmanagedType.LPStr)] string stream_name,
                                                                   [MarshalAs(UnmanagedType.LPStr)] string tool_name);
    }
}
```

**XAnyLabel.VPlugin.code_2512310845/src/DTOs/VidiBlueReadDTO.cs**
```csharp
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
```

**XAnyLabel.VPlugin.code_2512310845/src/DTOs/VidiGreenDTO.cs**
```csharp

```

**XAnyLabel.VPlugin.code_2512310845/src/DTOs/VidiRedDTO.cs**
```csharp

```

**XAnyLabel.VPlugin.code_2512310845/src/DTOs/XAnyLabelingDTO.cs**
```csharp
// 文件: XAnyLabelingDTO.cs
// 功能: 定义xanylabeling的标注格式

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

// 禁用警告
#pragma warning disable CS8632

namespace JusNet472Template
{
    /// <summary>
    /// 标注格式 的JSON根对象
    /// </summary>
    public class XAnyLabelingDTO
    {
        // 元信息
        public string? metaName { get; set; }
        // base64
        public string? imageData   { get; set; }   
        // 本地路径(一般不用)
        public string? imagePath   { get; set; }   
        // 图片哈希
        public string? imageHash { get;set; }
        // 标注信息
        public List<XAnyLabelingShape> shapes  { get; set; } = new List<XAnyLabelingShape>();
        // ROI区域
        public XAnyLabelingShape? roiRegion { get; set; }

        /* ===== 以下字段均为可选 ===== */
        /// <summary>
        /// 文件格式版本号
        /// </summary>
        public string? version { get; set; }

        /// <summary>
        /// 预留扩展标记（对应参考代码中的 flags）
        /// </summary>
        public object? flags { get; set; }

        /// <summary>
        /// 图片高度（像素）
        /// </summary>
        public int? imageHeight { get; set; }

        /// <summary>
        /// 图片宽度（像素）
        /// </summary>
        public int? imageWidth { get; set; }
    }

    /// <summary>
    /// 单个标注
    /// </summary>
    public class XAnyLabelingShape
    {
        public string label      { get; set; } = string.Empty;
        // "rotation" | "rectangle"
        public string shape_type { get; set; } = string.Empty; 
        // [[x,y],...]s
        public List<List<float>> points { get; set; } = new List<List<float>>();   
        // 得分
        public float? score {get; set; }

        /* ===== 以下字段均为可选 ===== */
        /// <summary>
        /// 分组ID
        /// </summary>
        public object? group_id { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        public string? description { get; set; }

        /// <summary>
        /// 是否为难例
        /// </summary>
        public bool? difficult { get; set; }

        /// <summary>
        /// 预留扩展标记
        /// </summary>
        public object? flags { get; set; }

        /// <summary>
        /// 属性字典
        /// </summary>
        public object? attributes { get; set; }

        /// <summary>
        /// KIE链接信息
        /// </summary>
        public List<object>? kie_linking { get; set; }

        /// <summary>
        /// 文字方向（0-3 对应 0°/90°/180°/270°）
        /// </summary>
        public int? direction { get; set; }
    }
}


```

**XAnyLabel.VPlugin.code_2512310845/src/HALs/OpenStream.cs**
```csharp
// 文件: OpenStream.cs
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
        // 获取流名称
        public static bool vidi_training_workspace_list_streams(
            // 固定参数
            string workspace_name, string stream_name, string tool_name,
            // 控制接口
            ViDi2.Training.IControl _control,
            // 返回值
            out List<string> stream_list
        )
        {
            // 工作流名称列表
            stream_list = new List<string>();

            // 工作空间实例
            ViDi2.Training.IWorkspace workspace;

            // 打开工作空间
            bool ok = vidi_training_open_workspace(
                workspace_name, stream_name, tool_name,
                _control,
                out workspace
            );

            if(!ok) return false;

            // 获取流名称列表
            stream_list = workspace.Streams.Select(st => st.Name).ToList();

            return true;
        }

        // 返回流实例
        public static bool vidi_training_workspace_open_stream(
            // 固定参数
            string workspace_name, string stream_name, string tool_name,
            // 控制接口
            ViDi2.Training.IControl _control,
            // 返回值
            out ViDi2.Training.IStream stream
        )
        {
            stream = null;

            // 打开工作空间
            bool ok = vidi_training_open_workspace(
                workspace_name, stream_name, tool_name,
                _control, 
                out ViDi2.Training.IWorkspace workspace
            );

            if(workspace == null)
            {
                return false;
            }

            // 找到目标流
            stream = workspace.Streams
                                    .FirstOrDefault(st => st.Name == stream_name);

            return true;
        }

        // 添加图像到流数据库
        public static bool vidi_training_stream_add_image_from_memory(
            // 固定参数
            string workspace_name, string stream_name, string tool_name,
            // 控制接口
            ViDi2.Training.IControl _control,
            // 待添加图像
            string image_base64,
            // 图像名称
            out string image_name_in_stream
        )
        {
            image_name_in_stream = null;

            // 获取流实例
            vidi_training_workspace_open_stream(
                workspace_name, stream_name, tool_name,
                _control,
                out ViDi2.Training.IStream stream
            );

            // 判空
            if(stream == null)
            {
                return false;
            }

            // 从base64构造IImage图像
            System.IO.Stream image = Base64StringToStream(image_base64);
            byte[] imgBytes = Base64StringToBytes(image_base64);

            // 扩展名
            string ext = DetectImageFormat(imgBytes);
            string image_name_prefix = DateTime.Now.ToString("yyyyMMdd_HHmmss_fff");
            string image_name_tmp = image_name_prefix + "." + ext;
            string image_name = image_name_tmp;

            // 添加图像
            stream.Database.AddImage(image, image_name_tmp);

            // // 预览ROI
            // vidi_training_roi_preview(
            //     workspace_name, stream_name, tool_name,
            //     _control,
            //     image_name
            //     );

            // // 应用ROI
            // vidi_training_roi_apply_preview(
            //     workspace_name, stream_name, tool_name,
            //     _control
            // );

            image_name_in_stream = image_name;

            return true;
        }

        #region 工具
        // 如果前缀存在，先去掉
        static System.IO.Stream Base64StringToStream(string img_base64)
        {
            byte[] bytes = Base64StringToBytes(img_base64);
            // 只读即可
            return new System.IO.MemoryStream(bytes, writable: false);   
        }

        /// <summary>
        /// 将带前缀或不带前缀的 base64 字符串安全地转换为 byte[]。
        /// 自动去除 data:image/xxx;base64, 前缀、空白字符，并自动补齐填充字符。
        /// </summary>
        /// <param name="base64">输入的 base64 字符串。</param>
        /// <returns>解码后的字节数组。</returns>
        public static byte[] Base64StringToBytes(string base64)
        {
            if (string.IsNullOrWhiteSpace(base64))
                return Array.Empty<byte>();

            // 1. 去掉前缀  data:image/xxx;base64,
            int idx = base64.IndexOf("base64,", StringComparison.OrdinalIgnoreCase);
            string pure = idx < 0 ? base64 : base64.Substring(idx + 7);

            // 2. 去除所有空白字符（换行、回车、空格、制表符）
            pure = pure.Replace(" ", "")
                    .Replace("\r", "")
                    .Replace("\n", "")
                    .Replace("\t", "");

            // 3. 长度不足 4 的倍数时补齐 '='
            int mod4 = pure.Length % 4;
            if (mod4 > 0)
                pure += new string('=', 4 - mod4);

            // 4. 解码
            return Convert.FromBase64String(pure);
        }

        /// <summary>
        /// 读文件头判断格式，返回小写扩展名
        /// </summary>
        private static string DetectImageFormat(byte[] data)
        {
            if (data.Length < 4) return "png"; // 保底
            // PNG
            if (data[0] == 0x89 && data[1] == 0x50 && data[2] == 0x4E && data[3] == 0x47)
                return "png";
            // JPG
            if (data[0] == 0xFF && data[1] == 0xD8)
                return "jpg";
            // BMP
            if (data[0] == 0x42 && data[1] == 0x4D)
                return "bmp";
            // TIFF (little/big endian)
            if ((data[0] == 0x49 && data[1] == 0x49 && data[2] == 0x2A && data[3] == 0x00) ||
                (data[0] == 0x4D && data[1] == 0x4D && data[2] == 0x00 && data[3] == 0x2A))
                return "tif";
            return "png"; // 默认
        }
        #endregion 工具 

    }
}
```

**XAnyLabel.VPlugin.code_2512310845/src/HALs/OpenTool.cs**
```csharp
// 文件: OpenTool.cs
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
        // 获取工具参数
        public static bool vidi_training_tool_get_parameter(
            // 固定参数
            string workspace_name, string stream_name, string tool_name,
            // 控制接口
            ViDi2.Training.IControl _control
        )
        {
            /*******************    
            string GetToolParameter(
                string workspace_name,
                string stream_name,
                string tool_name,
                string parameter_path,
                ILibraryAccessContext context = null
            )
            *******************/

            // FIXME: 参数名
            string para_path = "";

            // 取出 LibraryAccess 并显式转换成 Training 命名空间下的接口
            // (GetToolParameter 方法定义在 命名空间 ViDi2.Training 的同名接口 ViDi2.Training.ILibraryAccess 上)
            ViDi2.Training.ILibraryAccess lib = _control.LibraryAccess as ViDi2.Training.ILibraryAccess;
            // 保险起见判空
            if (lib == null) return false;   

            lib.GetToolParameter(
                workspace_name, stream_name, tool_name,
                para_path
            );

            return true;
        }

        // 设置蓝色工具标注
        public static bool vidi_training_blue_set_feature(
            // 固定参数
            string workspace_name, string stream_name, string tool_name,
            // 控制接口
            ViDi2.Training.IControl _control,
            // 数据库中图像名称
            string image_name_in_stream,
            // 标注数据
            VidiBlueReadDTO label,
            // 循环计数
            int idx
        )
        {
            /********************
            void BlueSetFeature(
                WorkspaceName workspace,
                StreamName stream,
                ToolName tool,
                string view,
                int index,
                string id,
                double posx,
                double posy,
                double angle,
                double width,
                double height,
                ILibraryAccessContext context = null
            )

            public void SetFeature(ViewKey viewKey, int index, string id, Point position, double angle, Size size)
            {
                base.libraryAccess.BlueSetFeature(tool.Stream.Workspace.UniqueName, tool.Stream.Name, tool.Name, viewKey.ToString(), index, id, position.X, position.Y, angle, size.IsEmpty ? (-1.0) : size.Width, size.IsEmpty ? (-1.0) : size.Height);
                SignalChanged(new List<ViewKey> { viewKey });
            }
            *********************/

            // 视图筛选器关键词
            string view_name = "";
            if(string.IsNullOrEmpty(image_name_in_stream))
            {
                // view_name = "new";
                string view_key_string = "";
                // 1. 构造 FrameKey（样本名 + 帧序号 0）
                var frameKey = new ViDi2.FrameKey(image_name_in_stream, frameIndex: 0);

                // 2. 构造 ViewKey（视图序号也固定给 0）
                // var viewKey = new ViDi2.Training.ViewKey(frameKey, index: 0);
                var viewKey = new ViDi2.Training.ViewKey(frameKey, index: -1);
                view_key_string = viewKey.ToString();

                view_name = view_key_string;
            }
            else
            {
                // view_name = $"filename ~ '{image_name_in_stream}'";
                /************************************
                ViewKey Constructor 
                Initializes a new instance of a ViewKey to the given sample name and view-index 
                *************************************/
                // view_name = image_name_in_stream;
                string view_key_string = "";
                // 1. 构造 FrameKey（样本名 + 帧序号 0）
                var frameKey = new ViDi2.FrameKey(image_name_in_stream, frameIndex: 0);

                // 2. 构造 ViewKey（视图序号也固定给 0）
                var viewKey = new ViDi2.Training.ViewKey(frameKey, index: 0);
                // var viewKey = new ViDi2.Training.ViewKey(frameKey, index: -1);

                view_key_string = viewKey.ToString();

                LogMgr.Info($"[导入标注到蓝色工具]view_key_string={view_key_string}, 标签={label.Label}");

                view_name = view_key_string;
            }

            // 取出 LibraryAccess 并显式转换成 Training 命名空间下的接口
            // (BlueSetFeature  方法定义在 命名空间 ViDi2.Training 的同名接口 ViDi2.Training.ILibraryAccess 上)
            ViDi2.Training.ILibraryAccess lib = _control.LibraryAccess as ViDi2.Training.ILibraryAccess;
            // 保险起见判空
            if (lib == null) return false;   

            lib.BlueSetFeature(
                workspace_name, stream_name, tool_name,
                // 0为已应用preview, -1为未应用preview
                view: view_name,
                // -1为新增特征
                index: -1,
                id: label.Label, posx: label.CenterX, posy: label.CenterY,
                angle: label.Angle, width: label.Width, height: label.Height
            );

            // lib.AddFeature(
            //     view: view_name,
            //     id: label.Label, posx: label.CenterX, posy: label.CenterY,
            //     angle: label.Angle, width: label.Width, height: label.Height
            // );

            return true;
        }

        // 设置训练标志
        public static bool vidi_training_tool_set_view_train(
            // 固定参数
            string workspace_name, string stream_name, string tool_name,
            // 控制接口
            ViDi2.Training.IControl _control,
            // 数据库中图像名称
            string image_name_in_stream
        )
        {
            /**********************
                        void SetViewTrain(
                WorkspaceName workspace,
                StreamName stream,
                ToolName tool,
                string filter,
                int train,
                ILibraryAccessContext context = null
            )
            **********************/

            // 视图筛选器关键词
            string view_name = "";
            if(string.IsNullOrEmpty(image_name_in_stream))
            {
                view_name = "new";
            }
            else
            {
                view_name = $"filename ~ '{image_name_in_stream}'";
            }

            // 取出 LibraryAccess 并显式转换成 Training 命名空间下的接口
            // (SetViewTrain 方法定义在 命名空间 ViDi2.Training 的同名接口 ViDi2.Training.ILibraryAccess 上)
            ViDi2.Training.ILibraryAccess lib = _control.LibraryAccess as ViDi2.Training.ILibraryAccess;
            // 保险起见判空
            if (lib == null) return false;   

            lib.SetViewTrain(
                workspace_name, stream_name, tool_name,
                view_name,
                1
            );

            return true;
        }
        
        // 设置训练标志
        public static bool vidi_training_tool_set_train_flag(
            // 固定参数
            string workspace_name, string stream_name, string tool_name,
            // 控制接口
            ViDi2.Training.IControl _control,
            // 数据库中图像名称
            string image_name_in_stream
        )
        {
            /**********************
            void SetTrainFlag(
                string filter,
                bool flag
            )
            **********************/

            // 视图筛选器关键词
            string view_name = "";
            if(string.IsNullOrEmpty(image_name_in_stream))
            {
                view_name = "new";
            }
            else
            {
                view_name = $"filename ~ '{image_name_in_stream}'";
            }

            // 取出 LibraryAccess 并显式转换成 Training 命名空间下的接口
            // (SetTrainFlag  方法定义在 命名空间 ViDi2.Training 的同名接口 ViDi2.Training.IToolDatabase 上)
            ViDi2.Training.ILibraryAccess lib = _control.LibraryAccess as ViDi2.Training.ILibraryAccess;
            // 保险起见判空
            if (lib == null) return false;  

            // 获取工具所属的流
            vidi_training_workspace_open_stream(
                workspace_name, stream_name, tool_name,
                _control,
                out ViDi2.Training.IStream stream
            );

            // 判空
            if(stream == null)
            {
                return false;
            }

            // 获取工具
            ViDi2.Training.IToolList tools = stream.Tools;
            ViDi2.Training.ITool tool = tools.Where( tls => tls.Name == tool_name ).FirstOrDefault();

            // 获取工具的数据库引用
            ViDi2.Training.IToolDatabase db_by_tool = tool.Database;

            // 设置训练标志
            db_by_tool.SetTrainFlag(
                view_name,
                true
            );

            return true;
        }
    }

}
```

**XAnyLabel.VPlugin.code_2512310845/src/HALs/OpenWorkspace.cs**
```csharp
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
```

**XAnyLabel.VPlugin.code_2512310845/src/HALs/ROI.cs**
```csharp
// 文件: ROI.cs
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
        // 预览ROI
        public static bool vidi_training_roi_preview(
            // 固定参数
            string workspace_name, string stream_name, string tool_name,
            // 控制接口
            ViDi2.Training.IControl _control,
            // 数据库中图像名称
            string image_name_in_stream
        )
        {
            // 视图筛选器关键词
            string view_name = "";
            if(string.IsNullOrEmpty(image_name_in_stream))
            {
                // view_name = "new";
                string view_key_string = "";
                // 1. 构造 FrameKey（样本名 + 帧序号 0）
                var frameKey = new ViDi2.FrameKey(image_name_in_stream, frameIndex: 0);

                // 2. 构造 ViewKey（视图序号也固定给 -1）
                var viewKey = new ViDi2.Training.ViewKey(frameKey, index: -1);

                view_key_string = viewKey.ToString();

                view_name = view_key_string;
            }
            else
            {
                // view_name = $"filename ~ '{image_name_in_stream}'";
                // view_name = image_name_in_stream;
                string view_key_string = "";
                // 1. 构造 FrameKey（样本名 + 帧序号 0）
                var frameKey = new ViDi2.FrameKey(image_name_in_stream, frameIndex: 0);

                // 2. 构造 ViewKey（视图序号也固定给 -1）
                // var viewKey = new ViDi2.Training.ViewKey(frameKey, index: -1);
                // var viewKey = ViDi2.Training.ViewKey.Parse($"{image_name_in_stream}|0:-1");

                view_key_string = frameKey.ToString();

                view_name = view_key_string;
            }

            // 取出 LibraryAccess 并显式转换成 Training 命名空间下的接口
            // (RoiPreview 方法定义在 命名空间 ViDi2.Training 的同名接口 ViDi2.Training.ILibraryAccess 上)
            ViDi2.Training.ILibraryAccess lib = _control.LibraryAccess as ViDi2.Training.ILibraryAccess;
            // 保险起见判空
            if (lib == null) return false;   

            // 预览ROI
            string result = lib.RoiPreview(
                workspace_name,
                stream_name,
                tool_name,
                view_name
            );

            LogMgr.Info($"[导入标注到蓝色工具]RoiPreview={result}");

            return true;
        }

        // 应用ROI预览
        public static bool vidi_training_roi_apply_preview(
            // 固定参数
            string workspace_name, string stream_name, string tool_name,
            // 控制接口
            ViDi2.Training.IControl _control
        )
        {
            // 取出 LibraryAccess 并显式转换成 Training 命名空间下的接口
            // (RoiApplyPreview 方法定义在 命名空间 ViDi2.Training 的同名接口 ViDi2.Training.ILibraryAccess 上)
            ViDi2.Training.ILibraryAccess lib = _control.LibraryAccess as ViDi2.Training.ILibraryAccess;
            // 保险起见判空
            if (lib == null) return false;   

            // 应用ROI预览
            lib.RoiApplyPreview(
                workspace_name,
                stream_name,
                tool_name
            );

            LogMgr.Info($"[导入标注到蓝色工具]RoiApplyPreview()");

            return true;
        }
        
    }

}
```

**XAnyLabel.VPlugin.code_2512310845/src/HALs/VidiSharpHAL.cs**
```csharp
// 文件: VidiSharpHAL.cs
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
        // !!!插件上下文
        public IPluginContext _ctx;

        // !!!控制接口
        public ViDi2.Training.IControl _control;  

        // 所有函数前三个参数: string workspace_name, string stream_name, string tool_name,
        // public bool vidi_training_open_workspace() { return true; }
        // public bool vidi_training_workspace_list_streams() { return true; }
        // public bool vidi_training_get_parameter(){ return true; }
        // public bool vidi_training_set_parameter(){ return true; }
        // public bool vidi_training_stream_add_samples_to_set(){ return true; }
        // public bool vidi_training_stream_add_image_from_memory(){ return true; }
        // public bool vidi_training_tool_set_parameter(){ return true; }
        // public bool vidi_training_tool_get_parameter(){ return true; }
        // public bool vidi_training_tool_get_marking(){ return true; }
        // public bool vidi_training_roi_preview(){ return true; }
        // public bool vidi_training_roi_apply_preview(){ return true; }
        // public bool vidi_training_blue_set_feature(){ return true; }
        // public bool vidi_training_tool_set_view_train(){ return true; }
        // public bool vidi_training_view_set_mask(){ return true; }
        // public bool vidi_training_stream_get_image(){ return true; }
        // public bool vidi_training_stream_list_tools(){ return true; }
    }
}
```

**XAnyLabel.VPlugin.code_2512310845/src/HALs/ViewAndFrame.cs**
```csharp
// 文件: ViewAndFrame.cs
// 功能: 构造ViewKey和FrameKey

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
        
        /***************************
        在训练 API 里，一幅“图”在流里的完整标识是  
        `样本名 : 帧序号 : 视图序号`  
        对应 `ViewKey.ToString()` 的返回值。  
        因此你必须先拿到“样本名”和“帧序号”，再拼出 `ViewKey`。
        ****************************/

        // 获取图像的ViewKey
        public static bool vidi_training_get_view_key(
            // 固定参数
            string workspace_name, string stream_name, string tool_name,
            // 控制接口
            ViDi2.Training.IControl _control,
            // 数据库中图像名称
            string image_name_in_stream,
            // 返回的ViewKey字符串
            out string view_key_string
        )
        {
            // 1. 构造 FrameKey（样本名 + 帧序号 0）
            var frameKey = new ViDi2.FrameKey(image_name_in_stream, frameIndex: 0);

            // 2. 构造 ViewKey（视图序号也固定给 0）
            var viewKey = new ViDi2.Training.ViewKey(frameKey, index: 0);

            view_key_string = viewKey.ToString();
            return true;
        }
    }
}
```

**XAnyLabel.VPlugin.code_2512310845/src/PluginMainWindow.xaml**
```csharp
<Window x:Class="JusNet472Template.PluginMainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="JusXAnyLabel.VPlugin插件"
        ShowInTaskbar="False"
        WindowStartupLocation="CenterOwner"
        Width="700" Height="500">
    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="*"/>
        </Grid.RowDefinitions>

        <!-- 顶部标题栏 -->
        <TextBlock Grid.Row="0"
                   Text="标注数据导入插件"
                   FontWeight="Bold"
                   FontSize="14"
                   Margin="10,5,0,8"/>

        <!-- 主内容区 -->
        <Grid Grid.Row="1">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="200"/>
                <ColumnDefinition Width="*"/>
            </Grid.ColumnDefinitions>

            <!-- 左侧：选择 + 按钮 -->
            <Grid Grid.Column="0" Margin="5">
                <Grid.RowDefinitions>
                    <!-- 选择区 -->
                    <RowDefinition Height="Auto"/>
                    <!-- 按钮区 -->
                    <RowDefinition Height="*"/>
                </Grid.RowDefinitions>

                <!-- 上半部分：Workspace / Stream / Tool -->
                <StackPanel Grid.Row="0">
                    <TextBlock Text="Workspace:" FontWeight="Bold" Margin="0,0,0,2"/>
                    <ComboBox x:Name="CbWorkspace"
                              Margin="0,0,0,8"/>

                    <TextBlock Text="Stream:" FontWeight="Bold" Margin="0,0,0,2"/>
                    <ComboBox x:Name="CbStream"
                              Margin="0,0,0,8"/>

                    <TextBlock Text="Tool:" FontWeight="Bold" Margin="0,0,0,2"/>
                    <ComboBox x:Name="CbTool"
                              Margin="0,0,0,8"/>
                    
                    <!-- 手动刷新选择器 -->
                    <Button x:Name="BtnRefreshSelector"  Content="刷新选择器" Margin="0,0,0,5"/>
                </StackPanel>

                <!-- 下半部分：操作按钮 -->
                <StackPanel Grid.Row="1"
                            Orientation="Vertical"
                            VerticalAlignment="Top"
                            Margin="0,10,0,0">
                    <Button x:Name="BtnOpenJsonFile"  Content="打开标注 json 文件" Margin="0,0,0,5"/>
                    <Button x:Name="BtnOpenJsonDir"   Content="打开标注 json 文件夹" Margin="0,0,0,5"/>
                    <Button x:Name="BtnImportImages"    Content="导入标注图片到数据库" Margin="0,0,0,5"/>
                    <Button x:Name="BtnImportBlue"    Content="导入标注到蓝色工具" Margin="0,0,0,5"/>
                    <Button x:Name="BtnImportGreen"   Content="导入标注到绿色工具" Margin="0,0,0,5"/>
                    <Button x:Name="BtnImportRed"     Content="导入标注到红色工具" Margin="0,0,0,5"/>
                </StackPanel>
            </Grid>

            <!-- 右侧：日志输出 -->
            <TextBox x:Name="OutputBox"
                     Grid.Column="1"
                     FontFamily="Consolas"
                     FontSize="11"
                     IsReadOnly="True"
                     TextWrapping="NoWrap"
                     ScrollViewer.HorizontalScrollBarVisibility="Auto"
                     ScrollViewer.VerticalScrollBarVisibility="Auto"
                     Margin="5,0,5,5"/>
        </Grid>
    </Grid>
</Window>
```

**XAnyLabel.VPlugin.code_2512310845/src/PluginMainWindow.xaml.cs**
```csharp
// 文件: TextBrowserWin.xaml.cs
// 功能: 取数据 → 格式化 → 文本框

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

// JSON处理
using Newtonsoft.Json;

// 插件接口
using ViDi2;
using ViDi2.Common;
using ViDi2.Common.Utilities;
using ViDi2.UI;
using ViDi2.Training;
using ViDi2.Training.UI;

// 屏蔽警告
#pragma warning disable CS0618

namespace JusNet472Template
{
    public partial class PluginMainWindow : Window
    {
        // !!!插件上下文
        public IPluginContext _ctx;
        public ViDi2.Training.IControl _control;   

        public PluginMainWindow(IPluginContext ctx)
        {
            InitializeComponent();
            

            if (ctx == null) throw new ArgumentNullException(nameof(ctx));
            _ctx = ctx;


            // IMainWindow 已经在插件上下文里给出
            var mainWin = ctx.MainWindow;
            _control = mainWin.WorkspaceBrowserViewModel.Control
                        ?? throw new InvalidOperationException("无法获取 IControl 服务");
            
            Loaded += (s, e) => LogMgr.Register(this);   // 注册
            Closed += (s, e) => LogMgr.UnRegister();     // 反注册
            
            WireEvents();

        }
    }
}
```

**XAnyLabel.VPlugin.code_2512310845/src/Program.cs**
```csharp
// 文件: Program.cs

// 标准库
using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;

// 插件接口
using ViDi2.Training;
using ViDi2.Training.UI;

namespace JusNet472Template
{
    public class MyPlugin : IPlugin
    {
        public string Name        => "JusXAnyLabel.VPlugin";
        public string Description => "导入/导出标注信息";
        public int    Version     => 251231;

        private IPluginContext _ctx;
        private MenuItem       _menu;
        private PluginMainWindow _win;

        public void Initialize(IPluginContext ctx)
        {
            _ctx = ctx;
            var pluginsMenu = ctx.MainWindow.MainMenu.Items
                                 .OfType<MenuItem>()
                                 .FirstOrDefault(m => m.Name == "PluginsMenu");
            if (pluginsMenu == null) return;

            _menu = new MenuItem { Header = Name, ToolTip = Description };
            _menu.Click += (_, __) => ToggleWindow();
            pluginsMenu.Items.Add(_menu);
        }

        public void DeInitialize()
        {
            if (_menu?.Parent is MenuItem p) p.Items.Remove(_menu);
            _win?.Close();
            _win = null;
        }

        private void ToggleWindow()
        {
            if (_win == null)
            {
                _win = new PluginMainWindow(_ctx)
                {
                    Owner = System.Windows.Application.Current.MainWindow,
                    WindowStyle = System.Windows.WindowStyle.ToolWindow,
                    Width = 700, Height = 600,
                    MinWidth = 500, MinHeight = 400
                };
                _win.Closing += (s, e) => _win = null;
            }
            _win.Show();
            _win.Activate();
        }
    }
}
```

**XAnyLabel.VPlugin.code_2512310845/src/Tools/AppendLogTool.cs**
```csharp
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
```

**XAnyLabel.VPlugin.code_2512310845/src/Tools/ButtonTool.cs**
```csharp
// 文件: ButtonTool.cs
// 功能: 处理按钮事件

// 标准库
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Collections.Generic;
using System.Windows.Controls;

// 屏蔽警告
#pragma warning disable CS8632

namespace JusNet472Template
{
    public partial class PluginMainWindow
    {
        // 这两个字段就是“控件点击后”的文件/目录
        // BtnOpenJsonFile 选中的文件
        public string? LastPickedJsonFile;   
        // BtnOpenJsonDir  选中的目录
        public string? LastPickedJsonDir;  
        // 记住“最后一次”想导入的 json 路径（文件 or 文件夹）, null 表示还没选
        public string[]? _lastJsonPaths;
         // === 第①步：把图导进数据库后，收集到的 stream 内图像名 ===
        public readonly List<string> _importedImageNamesInStream = new List<string>();

        private void WireEvents()
        {
            // 打印版本信息
            LogMgr.Info("=====================");
            LogMgr.Info("XAnyLabel.VPlugin插件");
            LogMgr.Info("version: 2601051513");
            LogMgr.Info("=====================");
            
            // 选择器刷新
            BtnRefreshSelector.Click += (s, e) =>
            {
                AppendLog("刷新选择器 按钮已点击");
                BtnRefreshSelector_Click(s, e);
            };

            // 打开单个 json 文件
            BtnOpenJsonFile.Click += (s, e) =>
            {
                AppendLog("打开标注 json 文件 按钮已点击");
                var dlg = new Microsoft.Win32.OpenFileDialog
                {
                    Filter = "JSON 文件 (*.json)|*.json",
                    Multiselect = false
                };
                if (dlg.ShowDialog() == true)
                {
                    var fi = new FileInfo(dlg.FileName);
                    // 互斥
                    LastPickedJsonDir  = null;   
                              
                    AppendLog($"选择的文件: {fi.FullName}");
                    AppendLog($"  大小: {fi.Length:N0} 字节");

                    // 记录所选择的文件
                    LastPickedJsonFile = dlg.FileName;
                    _lastJsonPaths     = new[] { dlg.FileName }; 
                    // 新一轮，先清空旧列表
                    _importedImageNamesInStream.Clear();  
                }
                else
                {
                    AppendLog("用户取消了文件选择");
                    LastPickedJsonFile = null;
                    _lastJsonPaths = null;
                }
            };

            // 打开 json 所在文件夹（通过选文件反推）
            BtnOpenJsonDir.Click += (s, e) =>
            {
                AppendLog("打开标注 json 文件夹 按钮已点击");
                string folder = FolderPicker.PickFolderViaFile();
                if (folder == null)
                {
                    AppendLog("用户取消了文件夹选择");
                    return;
                }

                // 全局记录
                LastPickedJsonDir = folder; 

                AppendLog($"选择的文件夹: {folder}");
                try
                {
                    var jsonFiles = Directory.EnumerateFiles(folder, "*.json", SearchOption.TopDirectoryOnly)
                                             .Select(Path.GetFileName)
                                             .ToArray();
                    
                    _lastJsonPaths     = Directory.EnumerateFiles(folder, "*.json").ToArray();
                    
                    AppendLog($"  包含 {jsonFiles.Length} 个 json 文件:");
                    // 新一轮，先清空旧列表
                    _importedImageNamesInStream.Clear(); 

                    foreach (var name in jsonFiles)
                        AppendLog($"    {name}");
                }
                catch (Exception ex)
                {
                    AppendLog($"  枚举 json 文件时出错: {ex.Message}");
                }
            };

            // 导入图片到数据库
            BtnImportImages.Click += (s, e) =>
            {
                AppendLog("[导入图片到数据库]按钮已点击");

                if (_lastJsonPaths == null || _lastJsonPaths.Length == 0)
                {
                    MessageBox.Show("请先选择 json 文件或文件夹！", "提示",
                                    MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                // 新一轮，先清空旧列表
                _importedImageNamesInStream.Clear(); 

                // 获取选择器数据
                string workspace_name_sel;
                string stream_name_sel;
                string tool_name_sel;

                GetSelected(
                    out workspace_name_sel,
                    out stream_name_sel,
                    out tool_name_sel
                );

                bool ok = ImportXAnyLabelTool.ImportImagesOnly(
                            workspace_name_sel,
                            stream_name_sel,
                            tool_name_sel,
                            _control,
                            _lastJsonPaths,
                            _importedImageNamesInStream);

                if (ok && _importedImageNamesInStream.Count > 0)
                {
                    AppendLog($"[Step-1] 已导入 {_importedImageNamesInStream.Count} 张图像到数据库。");
                    AppendLog("[Step-2] 请 **手动** 到主界面点击【应用】按钮（RoiApplyPreview 暂时有 bug）！");
                    AppendLog("[Step-3] 最后再点【导入标注到蓝色工具】完成标注写入。");
                }
                else
                {
                    AppendLog("[Step-1] 导入图像失败，请检查日志！");
                }
            };

            // 导入蓝色工具
            BtnImportBlue.Click += (s, e) => 
            {
                AppendLog("[导入标注到蓝色工具]按钮已点击");

                // 获取选择器数据
                string workspace_name_sel;
                string stream_name_sel;
                string tool_name_sel;

                GetSelected(
                    out workspace_name_sel,
                    out stream_name_sel,
                    out tool_name_sel
                );

                // 判断是否导入过图片
                if (_importedImageNamesInStream.Count == 0)
                {
                    MessageBox.Show("请先完成 Step-1（导入图像）！", "提示",
                                    MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                // 获取文件选择器路径
                string file_path = LastPickedJsonFile;
                string folder_path = LastPickedJsonDir;

                // 判断选择的是文件还是文件夹
                if(!string.IsNullOrEmpty(file_path))
                {
                    ImportXAnyLabelTool.ImportBlueLabelsOnly(
                        // 固定参数
                        workspace_name_sel, stream_name_sel, tool_name_sel,
                        // 控制接口
                        _control,
                        // json文件路径
                        file_path,
                        // 导入的图片名称列表
                        _importedImageNamesInStream.FirstOrDefault()
                    );
                }
                else if(!string.IsNullOrEmpty(folder_path))
                {
                    ImportXAnyLabelTool.ImportBlueLabelsOnlyMulti(
                        // 固定参数
                        workspace_name_sel, stream_name_sel, tool_name_sel,
                        // 控制接口
                        _control,
                        // json文件夹路径
                        folder_path,
                        // 导入的图片名称列表
                        _importedImageNamesInStream
                    );
                }

                AppendLog("[导入标注到蓝色工具]导入完成!");

            };

            // 导入绿色工具
            BtnImportGreen.Click += (s, e) => 
            {
                AppendLog("[导入标注到绿色工具]按钮已点击");
            };

            // 导入红色工具
            BtnImportRed.Click += (s, e) => 
            {
                AppendLog("[导入标注到红色工具]按钮已点击");
            };

        }

    }
}
```

**XAnyLabel.VPlugin.code_2512310845/src/Tools/ExportDatabaseSummaryTool.xaml**
```csharp
<Window x:Class="JusNet472Template.ExportDatabaseSummaryTool"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="导出vidi数据库详细信息" ShowInTaskbar="False"
        WindowStartupLocation="CenterOwner"
        Width="700" Height="500">
    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="*"/>
        </Grid.RowDefinitions>

        <!-- 顶部工具栏 -->
        <StackPanel Orientation="Horizontal" Grid.Row="0" Margin="5">
            <Button Content="刷新" Click="Refresh_Click" Padding="8,2"/>
            <Button Name="BtnExportJson" Content="导出标签为JSON" Width="120" Margin="5"
            Click="BtnExportJson_Click"/>
            <Button Name="BtnExportDatabase" Content="导出工具标注信息到数据库" Width="120" Margin="5"
            Click="BtnExportDatabase_Click"/>
            <Button Name="BtnImportDatabase" Content="从数据库导入标注信息到工具" Width="120" Margin="5"
            Click="BtnImportDatabase_Click"/>
            <TextBlock x:Name="Status" Margin="10,0,0,0" VerticalAlignment="Center"/>
            <ProgressBar x:Name="Progress" Width="150" Margin="10,0,0,0"
             Minimum="0" Maximum="100" Value="0"
             Visibility="Collapsed"/>
        </StackPanel>

        <!-- 主内容区 -->
        <Grid Grid.Row="1">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="200"/>
                <ColumnDefinition Width="*"/>
            </Grid.ColumnDefinitions>

            <!-- 左侧选择区 -->
            <StackPanel Grid.Column="0" Margin="5">
                <TextBlock Text="Workspace:" FontWeight="Bold"/>
                <ComboBox x:Name="CbWorkspace" Margin="0,2,0,8"
                          DisplayMemberPath="Name"
                          SelectionChanged="CbWorkspace_SelectionChanged"/>

                <TextBlock Text="Stream:" FontWeight="Bold"/>
                <ComboBox x:Name="CbStream" Margin="0,2,0,8"
                          DisplayMemberPath="Name"
                          SelectionChanged="CbStream_SelectionChanged"/>

                <TextBlock Text="Tool:" FontWeight="Bold"/>
                <ComboBox x:Name="CbTool" Margin="0,2,0,8"
                          DisplayMemberPath="Name"
                          SelectionChanged="CbTool_SelectionChanged"/>
            </StackPanel>

            <!-- 右侧文本输出 -->
            <TextBox x:Name="OutputBox" Grid.Column="1"
                     FontFamily="Consolas" FontSize="11"
                     IsReadOnly="True"
                     ScrollViewer.HorizontalScrollBarVisibility="Auto"
                     ScrollViewer.VerticalScrollBarVisibility="Auto"/>
        </Grid>
    </Grid>
</Window>
```

**XAnyLabel.VPlugin.code_2512310845/src/Tools/ExportDatabaseSummaryTool.xaml.cs**
```csharp
// 文件: ExportDatabaseSummaryTool.xaml.cs
// 功能: 导出vidi图像数据库详细信息

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

// JSON处理
using Newtonsoft.Json;

// 插件接口
using ViDi2;
using ViDi2.Common;
using ViDi2.Common.Utilities;
using ViDi2.UI;
using ViDi2.Training;
using ViDi2.Training.UI;

// 屏蔽警告
#pragma warning disable CS0618

namespace JusNet472Template
{
    public partial class ExportDatabaseSummaryTool : Window
    {
        // !!!插件上下文
        public IPluginContext _ctx;
        public ViDi2.Training.IControl _control;   

        public ExportDatabaseSummaryTool(IPluginContext ctx)
        {
            InitializeComponent();
            if (ctx == null) throw new ArgumentNullException(nameof(ctx));
            _ctx = ctx;

            // IMainWindow 已经在插件上下文里给出
            var mainWin = ctx.MainWindow;
            _control = mainWin.WorkspaceBrowserViewModel.Control
                        ?? throw new InvalidOperationException("无法获取 IControl 服务");

            LoadWorkspaceList();
            RefreshData();
        }

        #region 界面级联
        public void LoadWorkspaceList()
        {
            CbWorkspace.ItemsSource = _control.Workspaces
                                             .Select(ws => new NodeHolder { Name = ws.Name })
                                             .ToList();
            if (CbWorkspace.Items.Count > 0) CbWorkspace.SelectedIndex = 0;
        }

        public void CbWorkspace_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CbStream.ItemsSource = null; CbTool.ItemsSource = null;
            if (CbWorkspace.SelectedItem is NodeHolder h)
            {
                var ws = _control.Workspaces[h.Name];
                CbStream.ItemsSource = ws.Streams
                                         .Select(s => new NodeHolder { Name = s.Name })
                                         .ToList();
                if (CbStream.Items.Count > 0) CbStream.SelectedIndex = 0;
            }
            RefreshData();
        }

        public void CbStream_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CbTool.ItemsSource = null;
            if (CbWorkspace.SelectedItem is NodeHolder wh &&
                CbStream.SelectedItem is NodeHolder sh)
            {
                var toolEnum = _control.Workspaces[wh.Name]
                                       .Streams[sh.Name]
                                       .Tools;
                CbTool.ItemsSource = toolEnum
                                    .Select(t => new NodeHolder { Name = t.Name })
                                    .ToList();
                if (CbTool.Items.Count > 0) CbTool.SelectedIndex = 0;
            }
            RefreshData();
        }

        public void CbTool_SelectionChanged(object sender, SelectionChangedEventArgs e) => RefreshData();
        public void Refresh_Click(object sender, RoutedEventArgs e) => RefreshData();
        #endregion 界面级联

        public void RefreshData()
        {
            if (CbTool.SelectedItem is NodeHolder th &&
                CbWorkspace.SelectedItem is NodeHolder wh &&
                CbStream.SelectedItem is NodeHolder sh)
            {
                // 强类型一路点下去
                var tool = _control.Workspaces[wh.Name]
                                   .Streams[sh.Name]
                                   .Tools[th.Name];

                var sb = new StringBuilder();
                sb.AppendLine($"Tool: {tool.Name}  (Type: {tool.Type})");
                sb.AppendLine(new string('-', 60));
                AppendDatabaseSummary(sb, tool.Database);
                OutputBox.Text = sb.ToString();
                Status.Text = $"Last refresh: {DateTime.Now:HH:mm:ss}";
            }
            else
            {
                OutputBox.Text = "[请依次选择 Workspace → Stream → Tool]";
                Status.Text = "No tool selected";
            }
        }

        public void AppendDatabaseSummary(StringBuilder sb, ViDi2.Training.IDatabase db)
        {
            try
            {
                var xml = db.Summary();
                var root = XElement.Parse(xml.OuterXml);
                sb.AppendLine("[Database Summary]");
                foreach (var stat in root.Elements())
                {
                    sb.AppendLine($"{stat.Name}: " +
                                  string.Join(", ", stat.Attributes()
                                                        .Select(a => $"{a.Name}={a.Value}")));
                }
                sb.AppendLine(new string('-', 60));
            }
            catch (Exception ex)
            {
                sb.AppendLine($"[读取统计信息失败: {ex.Message}]");
            }
        }

        public class NodeHolder { public string Name { get; set; } }
    }
}
```

**XAnyLabel.VPlugin.code_2512310845/src/Tools/ExportDatabaseSummaryToolExt.cs**
```csharp
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
```

**XAnyLabel.VPlugin.code_2512310845/src/Tools/GetAllNamesTool.cs**
```csharp
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
```

**XAnyLabel.VPlugin.code_2512310845/src/Tools/GlobalKVTool.cs**
```csharp
// 文件: GlobalKVTool.cs
// 功能: 全局数据访问

// 标准库
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

// JSON相关
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// 屏蔽警告
#pragma warning disable CS8632

namespace JusNet472Template
{
	/// <summary>
	/// 全局数据交换工具，提供线程安全的键值存储与类型转换
	/// </summary>
	public static class GlobalKV
	{
		/// <summary>
		/// 内部线程安全字典
		/// </summary>
		private static readonly ConcurrentDictionary<string, object> Kv = new();

		/// <summary>
		/// 初始化（可在此预置默认值）
		/// </summary>
		public static void Init()
		{
			// 如需预置数据，可在此添加
			// SetValue("DefaultKey", "DefaultValue");
		}

		/// <summary>
		/// 精准读取
		/// </summary>
		/// <typeparam name="T">目标类型</typeparam>
		/// <param name="key">键</param>
		/// <returns>存在则返回转换后的值，否则返回 default(T)</returns>
		// 返回可空引用（CS8603）
		public static T Get<T>(string key) =>
			Kv.TryGetValue(key, out var v) ? Convert<T>(v) : default!;

		/// <summary>
		/// 模糊读取（支持 * 或 ?）
		/// </summary>
		/// <typeparam name="T">目标类型</typeparam>
		/// <param name="pattern">通配符模式，* 代表任意字符序列，? 代表单个字符</param>
		/// <returns>匹配到的键值字典</returns>
		public static Dictionary<string, T> GetMany<T>(string pattern)
		{
			if (string.IsNullOrWhiteSpace(pattern))
				return new Dictionary<string, T>();

			var regex = new Regex(
				"^" +
				Regex.Escape(pattern)
					.Replace("\\*", ".*")
					.Replace("\\?", ".") +
				"$",
				RegexOptions.IgnoreCase | RegexOptions.Singleline);

			return Kv.Where(kv => regex.IsMatch(kv.Key))
					 .ToDictionary(
						 kv => kv.Key,
						 kv => Convert<T>(kv.Value),
						 StringComparer.OrdinalIgnoreCase);
		}

		/// <summary>
		/// 线程安全读取，无值返回 null，不抛异常
		/// </summary>
		/// <param name="key">键</param>
		/// <returns>对应值或 null 返回可空引用</returns>
		public static object? GetValue(string key)
		{
			Kv.TryGetValue(key, out var val);
			return val;
		}

		/// <summary>
		/// 线程安全写入（覆盖或新增）
		/// </summary>
		/// <param name="key">键</param>
		/// <param name="value">值</param>
		public static void SetValue(string key, object value)
		{
			if (key == null) throw new ArgumentNullException(nameof(key));
			Kv.AddOrUpdate(key, value, (_, __) => value);
		}

		/// <summary>
		/// 万能类型转换：object → 目标类型
		/// </summary>
		/// <typeparam name="T">目标类型</typeparam>
		/// <param name="v">原始值</param>
		/// <returns>转换后的值</returns>
		private static T Convert<T>(object v)
		{
			if (v is T t) return t;

			// JToken 场景（Newtonsoft.Json）
			if (v is JToken tok) return tok.ToObject<T>()!;

			// 处理可空类型
			var targetType = typeof(T);
			var underlyingType = Nullable.GetUnderlyingType(targetType) ?? targetType;

			// 空值处理
			if (v == null || DBNull.Value.Equals(v))
				return default!;

			// 相同类型
			if (underlyingType.IsInstanceOfType(v))
				return (T)System.Convert.ChangeType(v, underlyingType, CultureInfo.InvariantCulture)!;

			// 字符串 → 枚举
			if (underlyingType.IsEnum && v is string str)
				return (T)Enum.Parse(underlyingType, str, true)!;

			// 通用 IConvertible
			return (T)System.Convert.ChangeType(v, underlyingType, CultureInfo.InvariantCulture)!;
		}
	}
}
```

**XAnyLabel.VPlugin.code_2512310845/src/Tools/ImportImgAndApplyROITool.cs**
```csharp
// 文件: ImportImgAndApplyROI.cs
// 功能: 导入图片到vidi的图像数据库并使用整张图作为ROI

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

// 运行时绑定
using Microsoft.CSharp;

// Vidi
using ViDi.NET.Interfaces.training;
using ViDi2.Common.Utilities;
using ViDi2.Data;
using ViDi2.Properties;
using ViDi2.Runtime;
using ViDi2.Training;
using ViDi2.Local;
using ViDi2;

// 屏蔽警告
#pragma warning disable CS0618

namespace JusNet472Template
{
    // 导入图片数据到所选工具所在流的图像数据库

    // 输入: 图像base64, 工作空间，流，工具
    // 输出: 无
    // 处理: 将图像base64转为png图片, 图片名为{timestamp}.png,
    // 设置整张图为ROI区域

    public class ImportImgAndApplyROI
    {
        public ViDi2.Training.IControl _control;
        public ViDi2.Training.IStream _stream;
        
       
    }
}
```

**XAnyLabel.VPlugin.code_2512310845/src/Tools/ImportXAnyLabelTool.cs**
```csharp
// 文件: ImportXAnyLabelTool.cs
// 功能: 导入XAnyLabel标注信息

// 标准库
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Collections.Generic;
using System.Windows.Controls;

// JSON
using Newtonsoft.Json;

// 屏蔽警告
#pragma warning disable CS8632

namespace JusNet472Template
{
    public partial class ImportXAnyLabelTool
    {
        // BtnOpenJsonFile 选中的文件
        public string? LastPickedJsonFile;

        // BtnOpenJsonDir  选中的目录
        public string? LastPickedJsonDir;    

        // 控制接口
        public ViDi2.Training.IControl _control;

        // 选择器选中的工具
        public string workspace_name_sel;
        public string stream_name_sel;
        public string tool_name_sel;

        // 导入单个json
        public static bool ImportBlue(
            // 固定参数
            string workspace_name, string stream_name, string tool_name,
            // 控制接口
            ViDi2.Training.IControl _control,
            // 选择的json数据(单个json)
            string json_file_path
        )
        {
            // 读取json数据
            string txt = File.ReadAllText(json_file_path);
            XAnyLabelingDTO xany_dto = JsonConvert.DeserializeObject<XAnyLabelingDTO>(txt);
            List<VidiBlueReadDTO> vidi_blue_dto_list = ConvertToBlue(xany_dto);

            // 将图像添加数据库
            bool ok1 = VidiSharpHAL.vidi_training_stream_add_image_from_memory(
                // 固定参数
                workspace_name, stream_name, tool_name,
                // 控制接口
                _control,
                // 图像base64数据
                xany_dto.imageData,
                // 图像名称
                out string img_name_in_stream
            );

            LogMgr.Info($"[导入标注到蓝色工具]ok1={ok1}");

            // 应用视图ROI
            bool ok2 = VidiSharpHAL.vidi_training_roi_preview(
                // 固定参数
                workspace_name, stream_name, tool_name,
                // 控制接口
                _control,
                // 图像名称
                img_name_in_stream
            );
            LogMgr.Info($"[导入标注到蓝色工具]ok2={ok2}");

            bool ok3 = VidiSharpHAL.vidi_training_roi_apply_preview(
                // 固定参数
                workspace_name, stream_name, tool_name,
                // 控制接口
                _control
            );
            LogMgr.Info($"[导入标注到蓝色工具]ok3={ok3}");

            // 导入features
            bool ok4 = true;
            // img_name_in_stream = "20260105_140703_461.jpg";
            for (int i = 0; i < vidi_blue_dto_list.Count; i++)
            {
                ok4 = VidiSharpHAL.vidi_training_blue_set_feature(
                    // 固定参数
                    workspace_name, stream_name, tool_name,
                    // 控制接口
                    _control,
                    // 图像名称
                    image_name_in_stream: img_name_in_stream, 
                    // 标注数据
                    label: vidi_blue_dto_list[i],
                    // 索引
                    idx: i
                );
            }
            LogMgr.Info($"[导入标注到蓝色工具]ok4={ok4}");
            
            // 设置训练标志
            bool ok5 = VidiSharpHAL.vidi_training_tool_set_train_flag(
                // 固定参数
                workspace_name, stream_name, tool_name,
                // 控制接口
                _control,
                // 图像名称
                img_name_in_stream
            );
            LogMgr.Info($"[导入标注到蓝色工具]ok5={ok5}");

            return true;
        }

        // 导入多个json
        public static bool ImportBlues(
            // 固定参数
            string workspace_name, string stream_name, string tool_name,
            // 控制接口
            ViDi2.Training.IControl _control,
            // 选择的json数据(多个json)
            string json_folder_path
        )   
        {
            // 遍历文件夹中json文件
            var jsonFiles = Directory.GetFiles(json_folder_path, "*.json");
            if (jsonFiles.Length == 0)
            {
                return false;
            }

            // 逐个导入
            foreach (string file_path in jsonFiles)
            {
                ImportXAnyLabelTool.ImportBlue(
                    // 固定参数
                    workspace_name, stream_name, tool_name,
                    // 控制接口
                    _control,
                    // json文件路径
                    file_path
                );
            }

            return true;
        }

        #region 分别导入图片与导入标注
        /* ==========================================================
        * Step-1：只把图像灌进数据库，返回 stream 内图像名列表
        * ========================================================== */
        public static bool ImportImagesOnly(
            string workspace, string stream, string tool,
            ViDi2.Training.IControl ctrl,
            IEnumerable<string> jsonPaths,   // 单个或多个 json
            List<string> outputImageNames)   // 出参
        {
            outputImageNames.Clear();
            foreach (string jsonPath in jsonPaths)
            {
                string txt = File.ReadAllText(jsonPath);
                var xany = JsonConvert.DeserializeObject<XAnyLabelingDTO>(txt);

                bool ok = VidiSharpHAL.vidi_training_stream_add_image_from_memory(
                    workspace, stream, tool,
                    ctrl,
                    xany.imageData,
                    out string imgNameInStream);

                if (!ok) return false;

                outputImageNames.Add(imgNameInStream);
                LogMgr.Info($"[ImportImagesOnly] 导入图像 -> {imgNameInStream}");
            }
            return true;
        }

        /* ==========================================================
        * Step-3：把标注写进“已经存在”的图像 viewKey
        * 单文件版本
        * ========================================================== */
        public static bool ImportBlueLabelsOnly(
            string workspace, string stream, string tool,
            ViDi2.Training.IControl ctrl,
            string jsonPath,          // 原 json
            string imageNameInStream) // 第①步得到的 stream 内图像名
        {
            string txt = File.ReadAllText(jsonPath);
            var xany   = JsonConvert.DeserializeObject<XAnyLabelingDTO>(txt);
            var blues  = ConvertToBlue(xany);   // 你自己的转换函数

            // 不再加图，也不再调用 RoiApplyPreview
            for (int i = 0; i < blues.Count; i++)
            {
                bool ok = VidiSharpHAL.vidi_training_blue_set_feature(
                    workspace, stream, tool,
                    ctrl,
                    imageNameInStream,
                    blues[i],
                    i);
                if (!ok) return false;
            }

            // 打训练标记
            VidiSharpHAL.vidi_training_tool_set_train_flag(
                workspace, stream, tool,
                ctrl,
                imageNameInStream);

            LogMgr.Info($"[ImportLabelsOnly] 完成标注写入 -> {imageNameInStream}");
            return true;
        }

        /* ==========================================================
        * Step-3：批量版本（文件夹）
        * ========================================================== */
        public static bool ImportBlueLabelsOnlyMulti(
            string workspace, string stream, string tool,
            ViDi2.Training.IControl ctrl,
            string jsonFolder,
            List<string> imageNamesInStream) // 与 json 文件一一对应
        {
            var jsonFiles = Directory.GetFiles(jsonFolder, "*.json")
                                    .OrderBy(f => f)
                                    .ToArray();
            if (jsonFiles.Length != imageNamesInStream.Count)
            {
                LogMgr.Error("json 文件数量与已导入图像数量不一致！");
                return false;
            }

            for (int i = 0; i < jsonFiles.Length; i++)
            {
                bool ok = ImportBlueLabelsOnly(workspace, stream, tool,
                                        ctrl,
                                        jsonFiles[i],
                                        imageNamesInStream[i]);
                if (!ok) return false;
                LogMgr.Info($"ImportBlueLabelsOnlyMulti进度: {i}/{jsonFiles.Length}");
            }
            return true;
        }
        #endregion 分别导入图片与导入标注
    }
}
```

**XAnyLabel.VPlugin.code_2512310845/src/Tools/PolygonToRotatedRectTool.cs**
```csharp
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
```

**XAnyLabel.VPlugin.code_2512310845/src/Tools/SelectFolderViaFileTool.cs**
```csharp
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
```

**XAnyLabel.VPlugin.code_2512310845/src/Tools/SelectVidiTool.cs**
```csharp
// 文件: SelectVidiTool.cs
// 功能: 依次选择 Workspace → Stream → Tool然后激活Workspace

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

// JSON处理
using Newtonsoft.Json;

// 插件接口
using ViDi2;
using ViDi2.Common;
using ViDi2.Common.Utilities;
using ViDi2.UI;
using ViDi2.Training;
using ViDi2.Training.UI;

// 屏蔽警告
#pragma warning disable CS0618

namespace JusNet472Template
{
    public partial class SelectVidiTool
    {
        // !!!插件上下文
        public IPluginContext _ctx;
        // !!!控制接口
        public ViDi2.Training.IControl _control;  

    }
}
```

**XAnyLabel.VPlugin.code_2512310845/src/Tools/SelectorTool.cs**
```csharp
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
```

**XAnyLabel.VPlugin.code_2512310845/src/Tools/SqliteExeTool.cs**
```csharp
// 文件: SqliteExeHelper.cs
// 功能: 通过exe操作sqlite3数据库

// 标准库
using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace JusNet472Template
{
    /// <summary>
    /// 通过 sqlite3.exe 命令行完成 建库/建表/增删改查
    /// </summary>
    public static class SqliteExeHelper
    {
        // 数据库文件路径（放在 exe 同目录方便调试）
        private static readonly string DbFile =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "jusocr.db");

        // sqlite3.exe 全路径
        private static readonly string ToolPath =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles),
                        "dotnet", "sqlite3.exe");
        
        /// <summary>
        /// 执行任意 SQL 语句（无结果返回）
        /// </summary>
        public static void Execute(string sql)
        {
            Run($@"{DbFile}", sql);
        }

        /// <summary>
        /// 执行查询，返回 CSV 文本（列名+行数据）
        /// </summary>
        public static string Query(string sql)
        {
            return Run($@"{DbFile}", $".headers on\n.mode csv\n{sql}");
        }

        // 公共封装：启动进程、喂 SQL、拿回输出
        private static string Run(string dbArg, string stdinSql)
        {
            if (!File.Exists(ToolPath))
                throw new FileNotFoundException("找不到 sqlite3.exe", ToolPath);

            var psi = new ProcessStartInfo
            {
                FileName               = ToolPath,
                Arguments              = $"\"{dbArg}\"", // 数据库路径作参数
                RedirectStandardInput  = true,
                RedirectStandardOutput = true,
                RedirectStandardError  = true,
                CreateNoWindow         = true,
                UseShellExecute        = false,
                StandardOutputEncoding = Encoding.UTF8,
                StandardErrorEncoding  = Encoding.UTF8
            };

            using (var proc = Process.Start(psi))
            {
                // 把 SQL 喂进标准输入
                proc.StandardInput.Write(stdinSql);
                proc.StandardInput.Close();

                string output = proc.StandardOutput.ReadToEnd();
                string error  = proc.StandardError.ReadToEnd();
                proc.WaitForExit();

                if (proc.ExitCode != 0 || !string.IsNullOrWhiteSpace(error))
                    throw new InvalidOperationException(
                        $"sqlite3 返回错误 ({proc.ExitCode}): {error}");

                return output;
            }
        }

        /*=================== 下面几个方法方便直接调用 ===================*/

        public static void EnsureTable()
        {
            Execute(@"
CREATE TABLE IF NOT EXISTS LicenseLog(
    Id         INTEGER PRIMARY KEY AUTOINCREMENT,
    UserName   TEXT NOT NULL,
    UnlockTime TEXT DEFAULT CURRENT_TIMESTAMP,
    Result     INTEGER NOT NULL
);");
        }

        public static void InsertLog(string userName, bool success)
        {
            Execute(
$"INSERT INTO LicenseLog(UserName,Result) VALUES('{Escape(userName)}',{(success?1:0)});");
        }

        public static string GetTopLogs(int top = 20)
        {
            return Query(
$"SELECT * FROM LicenseLog ORDER BY UnlockTime DESC LIMIT {top};");
        }

        // 简单防注入（单引号加倍）
        private static string Escape(string s) => s.Replace("'", "''");
    }
}
```

**XAnyLabel.VPlugin.code_2512310845/src/Tools/VidiLabelTool.cs**
```csharp
// 文件: VidiLabelTool.cs
// 功能: 封装vidi标签功能

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

// 运行时绑定
using Microsoft.CSharp;

// Vidi
using ViDi.NET.Interfaces.training;
using ViDi2.Common.Utilities;
using ViDi2.Data;
using ViDi2.Properties;
using ViDi2.Runtime;
using ViDi2.Training;
using ViDi2.Local;
using ViDi2;

// 屏蔽警告
#pragma warning disable CS0618

namespace JusNet472Template
{
    public partial class TextBrowserWin
    {

    }

}
```

**XAnyLabel.VPlugin.code_2512310845/src/legacy/ExportJson.cs**
```csharp
// 文件: ExportJson.cs
// 功能: 导出json

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

// Vidi
using ViDi.NET.Interfaces.training;
using ViDi2.Common.Utilities;
using ViDi2.Data;
using ViDi2.Properties;
using ViDi2.Runtime;
using ViDi2.Training;
using ViDi2.Local;

// 屏蔽警告
#pragma warning disable CS0618

namespace JusNet472Template
{
    public partial class ExportDatabaseSummaryTool
    {
        /* ================= 进度条辅助 ================= */
        private void SetProgress(int percent, string msg = null)
        {
            Dispatcher.Invoke(() =>
            {
                Progress.Value = percent;
                if (msg != null) Status.Text = msg;
            });
        }

        /* ================= 导出当前 Workspace ================= */
        private void BtnExportJson_Click(object sender, RoutedEventArgs e)
        {
            // 取 SelectedItem 而不是 SelectedIndex
            if (!(CbWorkspace.SelectedItem is NodeHolder holder))
            {
                MessageBox.Show(this, "请先选择一个 Workspace！", "提示",
                                MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // 再用名字去索引 IWorkspace
            var ws = _control.Workspaces[holder.Name] as ViDi2.Training.IWorkspace;

            /* ---------- 1. 先让用户选保存路径 ---------- */
            var time = DateTime.Now.ToString("yyyyMMddHHmm");
            var fileName = $"{ws.Name}_{time}.json";

            var dlg = new SaveFileDialog
            {
                Filter = "JSON 文件|*.json",
                FileName = fileName,
                DefaultExt = "json",
                InitialDirectory = Path.Combine("D:\\", "JustSmart", "AppCache", "ViDiInfo")
            };

            if (dlg.ShowDialog(this) != true) return;   // 用户点了“取消”直接退出
            var targetPath = dlg.FileName;

            /* ---------- 2. 真正开始干活 ---------- */
            try
            {
                Dispatcher.Invoke(() =>
                {
                    BtnExportJson.IsEnabled = false;
                    Progress.Visibility = Visibility.Visible;
                    Status.Text = "正在准备…";
                });

                var imgFactory = LibraryImage.Factory;
                ViDi2.IImage dummyImage;
                using (var ms = new MemoryStream())
                {
                    using (var img = new MagickImage(MagickColors.Black, 100, 100))
                    {
                        img.Depth = 8;
                        img.Format = MagickFormat.Png;
                        img.Write(ms);
                    }
                    ms.Position = 0;
                    dummyImage = imgFactory.Load(ms, ViDi2.ImageFormat.PNG);
                }

                var root = new ViDiNodeInfo { Name = ws.Name, Type = "Workspace" };

                int total = ws.Streams.Count(), done = 0;
                foreach (var st in ws.Streams)
                {
                    SetProgress(done * 100 / total, $"正在处理流 {st.Name} …");
                    var stNode = new ViDiNodeInfo { Name = st.Name, Type = "Stream" };
                    root.Children.Add(stNode);

                    foreach (var tool in st.Tools)
                    {
                        string toolType = "Unknown";
                        var tagsFeatures = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

                        try
                        {
                            var sample = tool.Process(dummyImage);
                            if (sample?.Markings != null && sample.Markings.ContainsKey(tool.Name))
                            {
                                var mk = sample.Markings[tool.Name];
                                if (mk is ViDi2.IRedMarking) toolType = "Red";
                                else if (mk is ViDi2.IGreenMarking) toolType = "Green";
                                else if (mk is ViDi2.IBlueMarking blueMk)
                                    toolType = blueMk.Views.Any(v => v.Matches?.Count > 0) ? "BlueRead" : "Blue";
                            }
                        }
                        catch { /* 留 Unknown */ }

                        switch (toolType)
                        {
                            case "BlueRead":
                            case "Blue":
                                if (tool is ViDi2.Training.IBlueTool bt)
                                    foreach (var f in bt.KnownFeatures)
                                        if (!string.IsNullOrWhiteSpace(f))
                                            tagsFeatures.Add(f);
                                break;
                            case "Green":
                                if (tool is ViDi2.Training.IGreenTool gt)
                                    foreach (var t in gt.KnownTags)
                                        if (!string.IsNullOrWhiteSpace(t))
                                            tagsFeatures.Add(t);
                                break;
                        }

                        stNode.Children.Add(new ViDiNodeInfo
                        {
                            Name = tool.Name,
                            Type = toolType,
                            TagsFeatures = new List<string>(tagsFeatures.OrderBy(t => t, StringComparer.OrdinalIgnoreCase))
                        });
                    }
                    done++;
                }

                /* ---------- 3. 写入文件 ---------- */
                Directory.CreateDirectory(Path.GetDirectoryName(targetPath));
                File.WriteAllText(targetPath, JsonConvert.SerializeObject(root, Formatting.Indented));
                MessageBox.Show(this, $"已导出到\n{targetPath}", "完成",
                                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"导出失败：\n{ex.Message}", "错误",
                                MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Dispatcher.Invoke(() =>
                {
                    BtnExportJson.IsEnabled = true;
                    Progress.Visibility = Visibility.Collapsed;
                    Status.Text = "";
                });
            }
        }

        /* ======== 新增：DTO ======== */
        public class ViDiNodeInfo
        {
            public string Name { get; set; } = "";
            public string Type { get; set; } = "";
            public List<ViDiNodeInfo> Children { get; set; } = new List<ViDiNodeInfo>();
            public List<string> TagsFeatures { get; set; } = new List<string>();
        }
    }
}
```

**XAnyLabel.VPlugin.code_2512310845/src/legacy/ExportLabel.cs**
```csharp
// 文件: ExportLabel.cs
// 功能: 导出蓝色/绿色工具标注信息和图像到 sqlite3 数据库（exe 版）
// 修改点
// 1. 去掉 Microsoft.Data.Sqlite 的 using
// 2. 用 SqliteExeHelper 代替 SqliteConnection/SqliteTransaction/SqliteCommand
// 3. 参数化 SQL 改为字符串拼接，并做简单转义

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

// 运行时绑定
using Microsoft.CSharp;

// Vidi
using ViDi.NET.Interfaces.training;
using ViDi2.Common.Utilities;
using ViDi2.Data;
using ViDi2.Properties;
using ViDi2.Runtime;
using ViDi2.Training;
using ViDi2.Local;
using ViDi2;

// 屏蔽警告
#pragma warning disable CS0618

namespace JusNet472Template
{
    public partial class ExportDatabaseSummaryTool
    {
        /* ===============================================================
         * 1. 导出按钮：选择文件夹 → 导出 png+json 并写入 SQLite
         * =============================================================== */
        private void BtnExportDatabase_Click(object sender, RoutedEventArgs e)
        {
            if (!(CbWorkspace.SelectedItem is NodeHolder wh) ||
                !(CbStream.SelectedItem is NodeHolder sh) ||
                !(CbTool.SelectedItem is NodeHolder th))
            {
                MessageBox.Show("请先依次选择 Workspace → Stream → Tool！");
                return;
            }

            var tool = _control.Workspaces[wh.Name]
                               .Streams[sh.Name]
                               .Tools[th.Name];

            if (tool is ViDi2.Training.IBlueTool bTool)
                ExportToolToDatabase(bTool, "Blue");
            else if (tool is ViDi2.Training.IGreenTool gTool)
                ExportToolToDatabase(gTool, "Green");
            else
            {
                MessageBox.Show("仅支持 Blue/Green 工具！");
                return;
            }
        }

        #region 导出逻辑
        private void ExportToolToDatabase(object toolObj, string toolType)
        {
            if (!(toolObj is ViDi2.Training.ITool tool))
            {
                MessageBox.Show("仅支持 ViDi Tool 类型！");
                return;
            }

            var blue  = tool as ViDi2.Training.IBlueTool;
            var green = tool as ViDi2.Training.IGreenTool;
            if (blue == null && green == null)
            {
                MessageBox.Show("仅支持 Blue/Green 工具！");
                return;
            }

            string folder = SelectFolder();
            if (string.IsNullOrEmpty(folder)) return;

            try
            {
                BtnExportDatabase.IsEnabled = false;
                Status.Text = "正在导出…";
                Progress.Visibility = Visibility.Visible;
                Progress.Value = 0;

                // 1. 确保数据库和表存在
                SqliteExeHelper.EnsureTable();   // 复用原 helper 的 EnsureTable，可再建 samples 表

                // 2. 建本次需要的 samples 表（如果不存在）
                SqliteExeHelper.Execute(@"
CREATE TABLE IF NOT EXISTS samples(
    id         INTEGER PRIMARY KEY AUTOINCREMENT,
    name       TEXT NOT NULL,
    tool       TEXT NOT NULL,
    tool_type  TEXT NOT NULL,
    image      BLOB,
    json       TEXT,
    updated_at TEXT
);");

                int total = 0, idx = 0;
                if (blue != null)
                {
                    var db = blue.Database;
                    total = db.List().Count();
                    foreach (var key in db.List())
                    {
                        var frameKey = (FrameKey)key;
                        var view     = db.GetMarking(frameKey) as IBlueLabeledView;
                        if (view == null) { ++idx; continue; }

                        ExportOneSample(blue.Name,
                                        "Blue",
                                        frameKey.SampleName,
                                        view.LabeledFeatures?.Select(f => f.Name).ToArray(),
                                        ViewToPng(db, new ViewKey(frameKey, idx), frameKey),
                                        folder,
                                        ref idx,
                                        total);
                    }
                }
                else
                {
                    var db = green.Database;
                    total = db.List().Count();
                    foreach (var key in db.List())
                    {
                        var frameKey = (FrameKey)key;
                        var view     = db.GetMarking(frameKey) as IGreenLabeledView;
                        if (view == null) { ++idx; continue; }

                        ExportOneSample(green.Name,
                                        "Green",
                                        frameKey.SampleName,
                                        view.LabeledTags?.ToArray(),
                                        ViewToPng(db, new ViewKey(frameKey, idx), frameKey),
                                        folder,
                                        ref idx,
                                        total);
                    }
                }

                MessageBox.Show($"导出完成！\n文件夹：{folder}\n数据库：jusocr.db");
            }
            catch (Exception ex)
            {
                MessageBox.Show("导出失败：\n" + ex.Message, "错误");
            }
            finally
            {
                BtnExportDatabase.IsEnabled = true;
                Progress.Visibility = Visibility.Collapsed;
                Status.Text = "";
            }
        }

        // 统一写一条样本 + 写磁盘文件
        private void ExportOneSample(string toolName,
                                     string toolType,
                                     string sampleName,
                                     string[] labels,
                                     byte[] pngBytes,
                                     string folder,
                                     ref int idx,
                                     int total)
        {
            idx++;
            var labelJson = JsonConvert.SerializeObject(labels ?? new string[0]);
            string baseName = $"{toolName}_{sampleName}";

            // 1. 写磁盘 png/json
            File.WriteAllBytes(Path.Combine(folder, baseName + ".png"), pngBytes);
            File.WriteAllText(Path.Combine(folder, baseName + ".json"),
                              JsonConvert.SerializeObject(new
                              {
                                  name        = sampleName,
                                  tool        = toolName,
                                  tool_type   = toolType,
                                  labels
                              }, Formatting.Indented));

            // 2. 写数据库（exe 模式只能拼 SQL）
            string sql =
$@"INSERT INTO samples(name,tool,tool_type,image,json,updated_at)
VALUES('{Escape(sampleName)}',
       '{Escape(toolName)}',
       '{Escape(toolType)}',
       '{Escape(Convert.ToBase64String(pngBytes))}',   // BLOB 用 base64 存
       '{Escape(labelJson)}',
       '{Escape(DateTime.Now.ToString("O"))}');";

            SqliteExeHelper.Execute(sql);

            Progress.Value = idx * 100 / total;
        }
        #endregion 导出逻辑

        #region 辅助
        // 简单防注入
        private static string Escape(string s) => s.Replace("'", "''");
        #endregion
    }
}
```

**XAnyLabel.VPlugin.code_2512310845/src/legacy/ImportLabel.cs**
```csharp
// 文件: ImportLabel.cs
// 功能: 从sqlite3数据库导入蓝色工具/绿色工具标注信息和图像

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

// 运行时绑定
using Microsoft.CSharp;

// Vidi
using ViDi.NET.Interfaces.training;
using ViDi2.Common.Utilities;
using ViDi2.Data;
using ViDi2.Properties;
using ViDi2.Runtime;
using ViDi2.Training;
using ViDi2.Local;
using ViDi2;

// 屏蔽警告
#pragma warning disable CS0618

namespace JusNet472Template
{
    public partial class ExportDatabaseSummaryTool
    {
        /* ===============================================================
         * 2. 导入按钮：选择文件夹 → 从 SQLite 读回样本
         * =============================================================== */
        private void BtnImportDatabase_Click(object sender, RoutedEventArgs e)
        {
            if (!(CbWorkspace.SelectedItem is NodeHolder wh) ||
                !(CbStream.SelectedItem is NodeHolder sh) ||
                !(CbTool.SelectedItem is NodeHolder th))
            {
                MessageBox.Show("请先依次选择 Workspace → Stream → Tool！");
                return;
            }

            var tool = _control.Workspaces[wh.Name]
                               .Streams[sh.Name]
                               .Tools[th.Name];

            if (tool is ViDi2.Training.IBlueTool bt)
                ImportDatabaseToTool(bt, "Blue");
            else if (tool is ViDi2.Training.IGreenTool gt)
                ImportDatabaseToTool(gt, "Green");
            else
            {
                MessageBox.Show("仅支持 Blue/Green 工具！");
                return;
            }
        }

        #region 导入逻辑
        /* -----------------------------------------------------------
         * 公共入口：只做“覆盖确认”+“事务迭代”，具体 Blue/Green 分出去
         * ----------------------------------------------------------- */
        private void ImportDatabaseToTool(object toolObj, string toolType)
        {
            // 1. 转公共父接口
            if (!(toolObj is ViDi2.Training.ITool tool))
            {
                MessageBox.Show("仅支持 ViDi Tool 类型！");
                return;
            }

            // 2. 再确认子类型
            var blue  = tool as ViDi2.Training.IBlueTool;
            var green = tool as ViDi2.Training.IGreenTool;
            if (blue == null && green == null)
            {
                MessageBox.Show("仅支持 Blue/Green 工具！");
                return;
            }

            string dbPath = GetDbPath(tool.Name);
            if (!File.Exists(dbPath))
            {
                MessageBox.Show("数据库不存在，请先导出！\n" + dbPath);
                return;
            }

            var mode = MessageBox.Show("是否“覆盖”已有样本？\n选 No 则仅增量更新。", "导入模式",
                                       MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            if (mode == MessageBoxResult.Cancel) return;
            bool overwrite = mode == MessageBoxResult.Yes;

            try
            {
                BtnImportDatabase.IsEnabled = false;
                Status.Text = "正在导入…";
                Progress.Visibility = Visibility.Visible;
                Progress.Value = 0;

                using (var conn = OpenDb(tool.Name))
                {
                    /* ---------- 1. 统计 ---------- */
                    string cntSql = "SELECT COUNT(*) FROM samples WHERE tool=$tool";
                    using (var cmd = new SqliteCommand(cntSql, conn))
                    {
                        cmd.Parameters.AddWithValue("$tool", tool.Name);
                        int total = Convert.ToInt32(cmd.ExecuteScalar());
                        if (total == 0) { MessageBox.Show("数据库中无样本！"); return; }

                        /* ---------- 2. 按类型分派 ---------- */
                        if (blue != null)
                        {   
                            // ImportBlueTool(blue, overwrite, conn, total);
                        }
                        else
                        {
                            // ImportGreenTool(green, overwrite, conn, total);
                        }
                    }
                }

                MessageBox.Show("导入完成！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("导入失败：\n" + ex.Message, "错误");
            }
            finally
            {
                BtnImportDatabase.IsEnabled = true;
                Progress.Visibility = Visibility.Collapsed;
                Status.Text = "";
                RefreshData(); // 刷新右侧文本框
            }
        }
        #endregion 导入逻辑
        
        // #region 蓝色工具
        // /* -----------------------------------------------------------
        // * 蓝色：清空→重建→写 Features
        // * ----------------------------------------------------------- */
        // private void ImportBlueTool(ViDi2.Training.IBlueTool blue,
        //                             bool overwrite,
        //                             SqliteConnection conn,
        //                             int total, 
        //                             ViDi2.Training.IStream stream = null)
        // {
        //     /* ---------- 1. 覆盖模式先清空 ---------- */
        //     if (overwrite)
        //         blue.Database.RemoveImages("");

        //     /* ---------- 2. 预读库（更新模式用） ---------- */
        //     // 获取工具所属的流
        //     if(stream != null)
        //     {
        //         stream = blue.Stream;
        //     }

        //     var existLabels = new Dictionary<string, HashSet<string>>();
        //     if (!overwrite)
        //     {
        //         foreach (var v in blue.Database.List())
        //         {
        //             var view = blue.Database.GetMarking(v) as IBlueLabeledView;
        //             if (view == null) continue;
        //             var set = new HashSet<string>(
        //                         view.LabeledFeatures?.Select(f => f.Name).ToList() ?? new List<string>());
        //             existLabels[v.SampleName] = set;
        //         }
        //     }

        //     /* ---------- 3. 逐条导入 ---------- */
        //     string selSql = @"SELECT name,image,json FROM samples
        //                     WHERE tool=$tool ORDER BY id";
        //     using (var cmd = new SqliteCommand(selSql, conn))
        //     {
        //         cmd.Parameters.AddWithValue("$tool", blue.Name);
        //         using (var r = cmd.ExecuteReader())
        //         {
        //             int idx = 0;
        //             while (r.Read())
        //             {
        //                 string name = r.GetString(0);
        //                 byte[] png  = (byte[])r[1];
        //                 string json = r.GetString(2);
        //                 var dto = JsonConvert.DeserializeObject<ImportDto>(json);

        //                 /* 重建图像 */
        //                 ViDi2.IImage img;
        //                 using (var ms = new MemoryStream(png))
        //                     img = LibraryImage.Factory.Load(ms, ViDi2.ImageFormat.PNG);

        //                 /* 1. 新建空样本 */
        //                 var sample = stream.CreateSample();   // ← 直接去掉了 .Tool
        //                 sample.AddImage(img);

        //                 /* 2. 生成视图（大小、位姿、掩模默认即可） */
        //                 var view = sample.AddView(blue,        // ← 直接去掉了 .Tool
        //                                         default(ViDi2.Size),
        //                                         default(ViDi2.Matrix),
        //                                         null); // as IBlueView

        //                 /* 3. 合并标签（更新模式） */
        //                 if (!overwrite && existLabels.TryGetValue(name, out var oldSet))
        //                     dto.labels = dto.labels.Union(oldSet).Distinct().ToList();

        //                 /* 4. 写 Features */
        //                 foreach (var f in dto.labels)
        //                     view.AddFeature(f);               // ← 用 AddFeature 代替 Features.Add

        //                 /* 进度 */
        //                 Progress.Value = (++idx * 100 / total);
        //                 System.Windows.Threading.Dispatcher.CurrentDispatcher
        //                     .Invoke(() => { }, System.Windows.Threading.DispatcherPriority.Render);
        //             }
        //         }
        //     }
        // }
        // #endregion 蓝色工具

        // #region 绿色工具
        // /* -----------------------------------------------------------
        // * 绿色：清空→重建→写 Tags
        // * ----------------------------------------------------------- */
        // private void ImportGreenTool(ViDi2.Training.IGreenTool green,
        //                             bool overwrite,
        //                             SqliteConnection conn,
        //                             int total,
        //                             ViDi2.Training.IStream stream = null)
        // {
        //     /* ---------- 1. 覆盖模式先清空 ---------- */
        //     if (overwrite)
        //         green.Database.RemoveImages("");

        //     /* ---------- 2. 预读库（更新模式用） ---------- */
        //     var existTags = new Dictionary<string, HashSet<string>>();
        //     if (!overwrite)
        //     {
        //         foreach (var v in green.Database.List())
        //         {
        //             var view = green.Database.GetMarking((FrameKey)v) as IGreenLabeledView;
        //             if (view == null) continue;
        //             var set = new HashSet<string>(view.LabeledTags ?? Array.Empty<string>());
        //             existTags[v.SampleName] = set;
        //         }
        //     }

        //     /* ---------- 3. 逐条导入 ---------- */
        //     string selSql = @"SELECT name,image,json FROM samples
        //                     WHERE tool=$tool ORDER BY id";
        //     using (var cmd = new SqliteCommand(selSql, conn))
        //     {
        //         cmd.Parameters.AddWithValue("$tool", green.Name);
        //         using (var r = cmd.ExecuteReader())
        //         {
        //             int idx = 0;
        //             while (r.Read())
        //             {
        //                 string name = r.GetString(0);
        //                 byte[] png  = (byte[])r[1];
        //                 string json = r.GetString(2);
        //                 var dto = JsonConvert.DeserializeObject<ImportDto>(json);

        //                 /* 重建图像 */
        //                 ViDi2.IImage img;
        //                 using (var ms = new MemoryStream(png))
        //                     img = LibraryImage.Factory.Load(ms, ViDi2.ImageFormat.PNG);

        //                 /* 1. 新建空样本 */
        //                 var sample = green.Tool.CreateSample(name);
        //                 sample.AddImage(img);

        //                 /* 2. 生成视图 */
        //                 var view = sample.AddView(green.Tool,
        //                                         default(ViDi2.Size),
        //                                         null,
        //                                         null) as IGreenView;

        //                 /* 3. 合并标签（更新模式） */
        //                 if (!overwrite && existTags.TryGetValue(name, out var oldSet))
        //                     dto.labels = dto.labels.Union(oldSet).Distinct().ToList();

        //                 /* 4. 写 Tags */
        //                 foreach (var t in dto.labels)
        //                     view.Tags(t);

        //                 /* 进度 */
        //                 Progress.Value = (++idx * 100 / total);
        //                 System.Windows.Threading.Dispatcher.CurrentDispatcher
        //                     .Invoke(() => { }, System.Windows.Threading.DispatcherPriority.Render);
        //             }
        //         }
        //     }
        // }
        // #endregion 绿色工具

    }
}
```

**XAnyLabel.VPlugin.code_2512310845/src/legacy/ImportXAnyLabel.cs**
```csharp
// 文件: ImportXAnyLabel.cs
// 功能: 导入XAnyLabeling格式的标注数据到选定的vidi工具
// 选择文件夹->导入所有json文件->XAnyLabelingDTO->VidiBlueReadDTO/VidiGreenDTO/VidiRedDTO

// 如果选择导入蓝色工具标注信息, 将矩形四点框转换为x轴作为短边的2:3比例中点旋转矩形框(VidiBlueReadDTO);
// 图片数据仅使用json中的base64数据(可能带有base64;前缀), 文件名使用{timestamp}.png;

// 用法：new ImportXAnyLabel(control, tool).Run();

// 标准库
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using Microsoft.Win32;

// JSON
using Newtonsoft.Json;

// Cognex
using ViDi2.Training;

namespace JusNet472Template
{
    public class ImportXAnyLabel
    {
        private readonly IControl _control;
        private readonly ITool    _tool;

        public ImportXAnyLabel(IControl control, ITool tool)
        {
            _control = control ?? throw new ArgumentNullException(nameof(control));
            _tool    = tool    ?? throw new ArgumentNullException(nameof(tool));
        }

        public void Run()
        {
            /* ---------- 1. 选文件夹 ---------- */
            string folder = FolderPicker.PickFolderViaFile();
            if (folder == null) return;

            /* ---------- 2. 拿到所有 json ---------- */
            var jsonFiles = Directory.GetFiles(folder, "*.json");
            if (jsonFiles.Length == 0)
            {
                MessageBox.Show("目录下未找到 *.json 文件");
                return;
            }

            /* ---------- 3. 逐个解析并转换 ---------- */
            var samples = new List<object>(jsonFiles.Length);
            foreach (string file in jsonFiles)
            {
                try
                {
                    string txt = File.ReadAllText(file);
                    var dto = JsonConvert.DeserializeObject<XAnyLabelingDTO>(txt);
                    samples.Add(ConvertToBlue(dto));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"解析失败：{Path.GetFileName(file)}\n{ex.Message}");
                    return;
                }
            }

            /* ---------- 4. 一次性写入 ViDi ---------- */
            try
            {
                // _tool.ImportSamples(samples.ToArray());
                MessageBox.Show($"导入完成，共 {samples.Count} 张图");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"ViDi 导入失败\n{ex.Message}");
            }
        }

        /* ---------- 把 DTO → VidiBlueReadDTO ---------- */
        private VidiBlueReadDTO ConvertToBlue(XAnyLabelingDTO src)
        {
            /* ---- 4.1 图片 ---- */
            string base64 = StripDataURI(src.imageData ?? "");
            byte[] pngBytes = Convert.FromBase64String(base64);
            string timeStamp = DateTime.Now.ToString("yyyyMMdd_HHmmssfff");

            /* ---- 4.2 找第一个 rotation ---- */
            var poly = src.shapes?.FirstOrDefault(s =>
                            s.shape_type == "rotation" && s.points != null && s.points.Count >= 3);
            if (poly == null)
                throw new InvalidDataException("未找到 rotation 标注");

            /* ---- 4.3 四点 → 旋转矩形 ---- */
            var pts = poly.points.Select(p => new PointF(p[0], p[1])).ToList();
            RotatedRect rr = PolygonToRotatedRect(pts);   // x 短边 + 2:3

            return new VidiBlueReadDTO
            {
                ImageBytes = pngBytes,
                FileName   = timeStamp + ".png",
                Label      = poly.label ?? "",
                CenterX    = rr.CenterX,
                CenterY    = rr.CenterY,
                Width      = rr.Width,
                Height     = rr.Height,
                Angle      = rr.Angle
            };
        }

        #region 工具函数
        private static string StripDataURI(string s)
        {
            if (s == null) return "";
            int idx = s.IndexOf("base64,", StringComparison.OrdinalIgnoreCase);
            return idx < 0 ? s : s.Substring(idx + 7);
        }

        /* 把四点 rotation → 中心旋转矩形，保证：
         * 1. x 轴为短边；2. 高:宽 = 2:3；3. 角度 0~360° */
        private static RotatedRect PolygonToRotatedRect(List<PointF> pts)
        {
            /* 简易实现：AABB → 强制 x 短边 → 2:3 */
            float minX = pts.Min(p => p.X);
            float maxX = pts.Max(p => p.X);
            float minY = pts.Min(p => p.Y);
            float maxY = pts.Max(p => p.Y);

            float w = maxX - minX;
            float h = maxY - minY;

            /* 让 x 为短边 */
            if (w > h) { float t = w; w = h; h = t; }

            /* 强制 2:3 高宽比 */
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

        private struct PointF { public float X, Y; public PointF(float x, float y) { X = x; Y = y; } }
        private struct RotatedRect { public float CenterX, CenterY, Width, Height, Angle; }
        #endregion 工具函数
    }
}
```

