// ArrayExt.cs

using System;

namespace unicat
{
	public static class ArrayExt
	{
		public static string join(this string[] self)
		{
			return string.Join("", self);
		}

		public static string join(this string[] self, string sep)
		{
			return string.Join(sep, self);	
		}

		public static string[] sort(this string[] self)
		{
			string[] ary = (string[])self.Clone();
			Array.Sort(ary);
			return ary;	
		}
	}
}
