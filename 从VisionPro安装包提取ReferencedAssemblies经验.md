# 从 VisionPro 安装包提取 ReferencedAssemblies 与 CHM 文档经验

> 场景：手头有 Cognex VisionPro 安装包目录（MSI + CAB），需要从中提取特定文件而非安装整个软件。本文记录两次提取实践：一是 `ReferencedAssemblies` 文件夹（.NET 编译用引用程序集），二是全部 CHM 帮助文档。

## 背景

项目源码声明依赖 Cognex VisionPro 95.1，本机已安装版本为 59.2（`C:\Program Files\Cognex\VisionPro`）。为获取匹配的引用程序集，从 VisionPro 9.26 SR1 安装包中提取 `ReferencedAssemblies`。

- 安装包目录：`VisionPro_9_26_SR1\`
- 目标输出：项目根目录下 `ReferencedAssemblies\`（137 个文件，90 个 .dll + 47 个 .xml，约 1029 MB）
- 程序集版本：95.1.0.0（与 MSI File 表 Version 列一致）

## 安装包结构分析

```
VisionPro_9_26_SR1\
├── Cognex VisionPro x64 (R) 9.26 SR1.msi   ← 主安装数据库（13 MB）
├── vpro.cab                                  ← 主程序文件（2 GB，跨2卷）
├── vpro~1.cab                                ← 主程序文件续卷（780 MB）
├── samples.cab / sample3d.cab / handeye.cab  ← 示例与文档
├── doc.cab / dsfldcal.cab / dlruntm.cab
├── a5000v.cab
├── setup.exe / Setup.ini
├── drivers\                                   ← 采集卡驱动
├── ISSetupPrerequisites\                     ← .NET 4.8 / VC++ Redist / pylon / CodeMeter
└── vprolocalizeddocs\
```

关键发现：
- 安装包是 InstallShield 制作的 MSI + CAB 格式，不是已安装目录的拷贝
- 顶层只有 `drivers`、`ISSetupPrerequisites`、`vprolocalizeddocs` 三个子目录，**没有** `ReferencedAssemblies` 目录
- 目标文件封装在 `vpro.cab` 内，CAB 内文件使用令牌名（如 `_D41B66122B13683AB10E4537F062AE05`），不保留目录路径

## 尝试过的方案与踩坑

### 方案一：7-Zip 直接解压 CAB（失败）

用 7-Zip 列出 `vpro.cab` 内容，文件名全是令牌或截断名：

```
_D41B66122B13683AB10E4537F062AE05    cognex.visionpro.quickbuild.06
_B93478DB00520B3FD4568EF2BB67CDAF    cognex.visionpro.quickbuild.1
```

CAB 不保留目录层级，无法直接按 `ReferencedAssemblies` 路径筛选文件。

### 方案二：查询 MSI 数据库表映射（部分成功，但无法闭环）

用 WindowsInstaller COM 对象查询 MSI 的 `Directory`、`Component`、`File` 三张表，试图还原"令牌名 → 真实文件名 → 目标目录"的映射链。

**可用的 MSI SQL 限制**（踩坑）：

| 限制 | 说明 |
| --- | --- |
| 不支持 `LIKE` | `WHERE Directory LIKE '%Reference%'` 报语法错误，需 `SELECT *` 后在 PowerShell 中过滤 |
| 不支持 `IN` | `WHERE Directory_ IN (...)` 同样失败，需取全部行后 PS 过滤 |
| 列名用反引号包裹 | `` SELECT `Directory`, `Directory_Parent` FROM `Directory` `` |
| `SELECT *` 可用 | 需按字段序号 `StringData(n)` 读取 |

**路径含中文导致 COM 打不开 MSI**：

```
$wi.OpenDatabase("d:\JustSmart\...\Cognex VisionPro x64.msi", 0)
# 报错: OpenDatabase,DatabasePath,OpenMode
```

解决：将 13 MB 的 MSI 复制到无中文的路径 `C:\Temp\vp.msi` 再查询（CAB 不需要，查询数据库表只需 MSI 文件本身）。

**查询结果**：

- `Directory` 表 819 条，其中 45 条 `REFERENCEDASSEMBLIES.*` 目录
- `Component` 表 1798 条，其中 93 条组件的 `Directory_` 指向 ReferencedAssemblies
- `File` 表 3638 条，但用 93 条组件的 GUID 去 File 表的 `Component_` 字段匹配 → **0 条命中**

原因：ReferencedAssemblies 下的 .NET 程序集通过 `MsiAssembly` 表（673 条）注册，File 表的 `Component_` 引用的组件名与 Component 表中的 ReferencedAssemblies 组件名格式不一致（后者带 GUID 后缀），直接匹配断链。继续深挖 MsiAssembly 表交叉映射成本高，放弃此方案。

### 方案三：msiexec /a 行政安装（成功）

`msiexec /a` 是 MSI 的行政安装模式，按数据库表完整还原目录结构、从 CAB 解压全部文件到目标目录，**不执行安装动作**（不写注册表、不创建快捷方式）。

```powershell
$target = "C:\Temp\VP_Extract"
New-Item -ItemType Directory -Path $target -Force
$msi = "d:\JustSmart\261010优易达安全带\VisionPro_9_26_SR1\Cognex VisionPro x64 (R) 9.26 SR1.msi"
$proc = Start-Process -FilePath "msiexec.exe" `
    -ArgumentList "/a `"$msi`" /qn TARGETDIR=`"$target`"" `
    -Wait -PassThru
Write-Host "Exit code: $($proc.ExitCode)"
```

注意：
- `msiexec` 能处理含中文的 MSI 路径（与 COM 对象不同）
- MSI 必须与 CAB 文件在同一目录（msiexec 按相对路径查找 CAB）
- `/qn` 静默执行，`TARGETDIR` 指定输出根目录
- 提取约 3 GB 数据，耗时数分钟

提取后的目录结构：

```
C:\Temp\VP_Extract\
├── Program Files 64\Cognex\VisionPro\          ← 主程序
│   ├── bin\
│   ├── ReferencedAssemblies\                    ← 目标！137 个文件
│   ├── Templates\ / Images\ / ...
├── GlobalAssemblyCache\                         ← GAC 程序集
├── CommonAppData\ / Public\ / System32\ / Windows\
```

## 最终提取步骤

```powershell
# 1. 行政安装解压
$extractRoot = "C:\Temp\VP_Extract"
$msi = "d:\JustSmart\261010优易达安全带\VisionPro_9_26_SR1\Cognex VisionPro x64 (R) 9.26 SR1.msi"
msiexec /a "$msi" /qn TARGETDIR="$extractRoot"

# 2. 定位并复制 ReferencedAssemblies
$src = "$extractRoot\Program Files 64\Cognex\VisionPro\ReferencedAssemblies"
$dst = "d:\JustSmart\261010优易达安全带\ReferencedAssemblies"
Copy-Item -Path $src -Destination $dst -Recurse -Force

# 3. 清理临时解压目录
Remove-Item $extractRoot -Recurse -Force
```

## 结果

| 项目 | 值 |
| --- | --- |
| 输出路径 | `ReferencedAssemblies\` |
| 文件数 | 137（90 .dll + 47 .xml） |
| 总大小 | 1029 MB |
| 程序集版本 | 95.1.0.0 |

部分 DLL 清单：

```
Cognex.VisionPro.AutoSelect.dll       Cognex.VisionPro.Blob.dll
Cognex.VisionPro.CAD.dll              Cognex.VisionPro.CalibFix.dll
Cognex.VisionPro.CalibFixPlus.dll     Cognex.VisionPro.Caliper.dll
Cognex.VisionPro.ColorMatch.dll       Cognex.VisionPro.ColorSegmenter.dll
Cognex.VisionPro.Comm.dll            Cognex.VisionPro.DotNet.dll
...
```

---

## 实践二：提取 CHM 帮助文档

> 场景：从同一 VisionPro 9.26 SR1 安装包中提取全部 CHM 帮助文档文件，无需安装软件。

### 思路

与 ReferencedAssemblies 不同，CHM 文件分散在多个 CAB 中，且文件量小（7 个），无需 `msiexec /a` 全量解压 3 GB。改用**精准提取**：查询 MSI File 表找出 .chm 文件的 CAB 令牌名 → 查 Media 表确定令牌在哪个 CAB → 7-Zip 按令牌名从对应 CAB 单文件提取 → 重命名。

### 步骤一：查询 MSI File 表找出 .chm 文件

```powershell
# MSI 复制到无中文路径（COM 对象限制同前）
Copy-Item "...\Cognex VisionPro x64 (R) 9.26 SR1.msi" "C:\Temp\vp.msi"
$wi = New-Object -ComObject WindowsInstaller.Installer
$db = $wi.OpenDatabase("C:\Temp\vp.msi", 0)

# File 表 Field 1=CAB令牌名 Field 3=真实文件名(可能含 短名|长名 格式) Field 8=Sequence
$view = $db.OpenView('SELECT * FROM `File`')
$view.Execute()
while ($r = $view.Fetch()) {
    $fileName = $r.StringData(3)
    if ($fileName -match '\.chm') {
        $realName = ($fileName -split '\|')[-1]  # 取长名
        # 输出: 令牌名、真实名、序列号
    }
}
```

查询结果：7 个 CHM 文件

| CAB 令牌名 | 真实文件名 | 大小 |
| --- | --- | --- |
| `visionpro.users.guide.chm` | VisionPro.Users.Guide.chm | 122 MB |
| `visionpro.documentation.chm` | VisionPro.Documentation.chm | 38 MB |
| `_E7DEC3C6FB8DE8BC7ED04F7BFD9DB6E7` | qanda.chm | 41 KB |
| `cognex.displacementsensorfie1.28F89E41_...` | Cognex.DisplacementSensorFieldCalibrator.chm | 70 MB |
| `imagefontextractor.chm` | ImageFontExtractor.chm | 1.1 MB |
| `imgedit.chm` | imgedit.chm | 325 KB |
| `cognex.cadimporttool.chm.07F71012_...` | Cognex.CADImportTool.chm | 1.3 MB |

### 步骤二：查 Media 表确定每个文件在哪个 CAB

```powershell
$view = $db.OpenView('SELECT * FROM `Media`')
# DiskId=1 LastSeq=21  Cabinet=a5000v.cab
# DiskId=3 LastSeq=73  Cabinet=doc.cab      ← 3个CHM(seq 50/52/61)
# DiskId=4 LastSeq=82  Cabinet=dsfldcal.cab ← 1个CHM(seq 79)
# DiskId=8 LastSeq=3034 Cabinet=vpro.cab     ← 2个CHM(seq 1916/1942)
# DiskId=9 LastSeq=3638 Cabinet=vpro~1.cab  ← 1个CHM(seq 3604)
```

Sequence 字段落在哪个 DiskId 的 `[1, LastSeq]` 区间，文件就在对应的 CAB 中。

### 步骤三：7-Zip 按令牌名单文件提取

```powershell
$sevenZip = "C:\Program Files\7-Zip\7z.exe"
$outDir = "...\VisionPro_9_26_SR1\CHM_Docs"

# 逐个 CAB 逐个令牌提取
& $sevenZip e "$vp\doc.cab" "visionpro.documentation.chm" "-o$outDir" -y
& $sevenZip e "$vp\dsfldcal.cab" "cognex.displacementsensorfie1.28F89E41_..." "-o$outDir" -y
& $sevenZip e "$vp\vpro.cab" "imagefontextractor.chm" "-o$outDir" -y
& $sevenZip e "$vp\vpro~1.cab" "cognex.cadimporttool.chm.07F71012_..." "-o$outDir" -y
```

### 步骤四：重命名令牌名为真实文件名

```powershell
$renameMap = @{
    "visionpro.users.guide.chm" = "VisionPro.Users.Guide.chm"
    "_E7DEC3C6FB8DE8BC7ED04F7BFD9DB6E7" = "qanda.chm"
    "cognex.displacementsensorfie1.28F89E41_..." = "Cognex.DisplacementSensorFieldCalibrator.chm"
    "cognex.cadimporttool.chm.07F71012_..." = "Cognex.CADImportTool.chm"
    # ...
}
foreach ($token in $renameMap.Keys) {
    Move-Item "$outDir\$token" "$outDir\$($renameMap[$token])" -Force
}
```

### CHM 提取结果

| 文件 | 大小 | 来源 CAB |
| --- | --- | --- |
| VisionPro.Users.Guide.chm | 122.2 MB | doc.cab |
| VisionPro.Documentation.chm | 38.0 MB | doc.cab |
| Cognex.DisplacementSensorFieldCalibrator.chm | 70.0 MB | dsfldcal.cab |
| Cognex.CADImportTool.chm | 1.2 MB | vpro~1.cab |
| ImageFontExtractor.chm | 1.1 MB | vpro.cab |
| imgedit.chm | 0.3 MB | vpro.cab |
| qanda.chm | 0.04 MB | doc.cab |

共 7 个文件，总 232.7 MB。

### 踩坑：PowerShell 管道重定向导致 7-Zip 死锁

**现象**：在 .ps1 脚本中调用 7-Zip 提取文件，无论用 `*> $null`、`| Out-Null` 还是 `Start-Process -WindowStyle Hidden`，7-Zip 均阻塞不返回，提取的文件为空，`Test-Path` 返回 false。

**根因**：PowerShell 对外部进程的 stdout/stderr 创建管道，当 7-Zip 输出量大（vpro.cab 扫描信息数百行）时，管道缓冲区写满，7-Zip 阻塞等待读取端消费，而 PowerShell 端在等待 7-Zip 退出，形成**双向死锁**。2 GB 的 vpro.cab 扫描信息尤其容易触发。

**验证**：同一命令在 Shell 工具中直接逐条运行（不做输出重定向）时，7-Zip 正常完成提取。

**解决方案**：不在脚本中对 7-Zip 做任何输出重定向，改为在 Shell 中逐条调用，或将输出重定向到文件而非管道：

```powershell
# 方案A：不重定向，直接调用（推荐，输出到控制台）
& $sevenZip e "$vp\doc.cab" "visionpro.documentation.chm" "-o$outDir" -y

# 方案B：输出重定向到文件，避免管道死锁
& $sevenZip e "$vp\doc.cab" "visionpro.documentation.chm" "-o$outDir" -y 2>&1 | Out-File "$outDir\7z.log"
```

## 经验总结

1. **MSI + CAB 安装包提取首选 `msiexec /a`**：一步到位还原完整目录结构，无需手动解析数据库表。CAB 内文件用令牌名且不保留路径，7-Zip 直接解压 CAB 无法还原目录层级。

2. **WindowsInstaller COM 对象不兼容中文路径**：`OpenDatabase` 对含中文/特殊字符的 MSI 路径会静默返回 null。解决：复制 MSI（13 MB，不含 CAB）到 `C:\Temp\` 等纯英文路径再查询。

3. **MSI SQL 语法限制**：不支持 `LIKE` 和 `IN`，需 `SELECT *` 或 `SELECT 全部列` 后在宿主语言（PowerShell）中过滤。列名需用反引号包裹。

4. **MSI 表映射链可能断链**：Directory → Component → File 的映射在 InstallShield 多特性包中因组件名带 GUID 后缀、MsiAssembly 表单独注册等原因，直接交叉匹配可能命中 0 条。若只需提取文件而非查询元数据，不值得深挖表关系，直接 `msiexec /a`。

5. **磁盘空间**：行政安装会解压全部 CAB 内容（本例约 3 GB），需确保目标盘有足够空间。提取后只需复制目标文件夹，其余可删除。

6. **msiexec 处理 Unicode 路径正常**：与 COM 对象不同，`msiexec /a` 命令行能正确处理含中文的 MSI 路径和 CAB 相对路径。

7. **少量文件精准提取优于全量解压**：当只需提取少数文件（如 7 个 CHM）且已知文件扩展名时，查询 File 表按扩展名过滤 + Media 表定位 CAB + 7-Zip 按令牌名单文件提取，比 `msiexec /a` 全量解压 3 GB 更快更省空间。关键：File 表 Field 1 是 CAB 令牌名、Field 3 是真实文件名（`短名|长名` 格式取后者）、Field 8 是 Sequence；Media 表 `LastSeq` 与 File 表 `Sequence` 交叉确定文件归属的 CAB。

8. **PowerShell 调用 7-Zip 的管道死锁陷阱**：在 .ps1 脚本中对 7-Zip 做任何输出管道重定向（`*> $null`、`| Out-Null`、`2>&1 | ...`）均可能导致死锁——PowerShell 创建管道接收 stdout/stderr，当 7-Zip 输出量大（大 CAB 扫描信息数百行）时管道缓冲区写满，7-Zip 阻塞等待读取端消费，PowerShell 阻塞等待 7-Zip 退出，形成双向死锁。`Start-Process -WindowStyle Hidden` 同样不可靠。解决方案：不做输出重定向直接调用，或将输出重定向到文件（`| Out-File`）而非 null 管道。
