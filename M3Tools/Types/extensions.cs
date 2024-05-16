using System;
using System.Text.RegularExpressions;

namespace SPPBC.M3Tools.Types.Extensions
{
	static class StringExtensions
	{
		public static string FormatPhone(this string value)
		{
			return Regex.Replace(value, $@"{My.Settings.Default.PhoneRegex}", "($1) $2-$3");
		}

		public static string ToBase64String(this string value)
		{
			return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(value));
		}

		public static string FromBase64String(this string value)
		{
			return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(value));
		}
	}

	static class DoubleExtensions
	{
		public static string FormatPrice(this double value)
		{
			return $"{value:C2}";
		}
	}

	static class DecimalExtensions
	{
		public static string FormatPrice(this decimal value)
		{
			return $"{value:C2}";
		}
	}
}
