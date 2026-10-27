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