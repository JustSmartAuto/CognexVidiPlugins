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