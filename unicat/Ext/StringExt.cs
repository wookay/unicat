// StringExt.cs

using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace unicat
{
	public static class StringExt
	{
		public static string LF = "\n";
		public static string SPACE = " ";

		public static string strip(this string self)
		{
			return self.Trim();
		}

		public static string reverse(this string self)
		{
			char[] chars = self.ToCharArray();
			Array.Reverse(chars);
			return new String(chars);
		}

		public static string slice(this string self, int loc, int length)
		{
			return self.Substring(loc, length);
		}

		public static string gsub(this string self, string str, string to)
		{
			return self.Replace(str, to);
		}

		public static bool include(this string self, string str)
		{
			return self.Contains(str);
		}

		public static string[] split(this string self, string sep)
		{
			if (0 == sep.Length) {
				List<string> list = new List<string>();
				foreach (char ch in self.ToCharArray()) {
					list.Add(ch.ToString());
				}
				return list.ToArray();
			} else if (1 == sep.Length) {
				return self.Split(char.Parse(sep));
			} else {
				return Regex.Split(self, sep);
			}
		}

		public static string repeat(this string self, int n)
		{
			string ret = "";
			for (int idx = 0; idx < n; idx++) {
				ret += self;
			}
			return ret;
		}

		public static int to_int(this string self)
		{
			return (int)Convert.ToSingle(self.Replace(".", ","));
		}

		public static float to_float(this string self)
		{
			return Convert.ToSingle(self.Replace(".", ","));
		}
	}
}
