// NumberExt.cs

using System;

namespace unicat
{
	public static class NumberExt
	{
		// int
		public static string to_s(this int self)
		{
			return self.ToString();
		}
		public static int to_int(this int self)
		{
			return self;
		}
		public static float to_float(this int self)
		{
			return Convert.ToSingle(self);
		}

		// float
		public static string to_s(this float self)
		{
			return self.ToString(System.Globalization.CultureInfo.InvariantCulture) + "f";
		}
		public static int to_int(this float self)
		{
			return Convert.ToInt32(self);
		}
		public static float to_float(this float self)
		{
			return self;
		}

		// double
		public static string to_s(this double self)
		{
			return self.ToString(System.Globalization.CultureInfo.InvariantCulture);
		}
		public static int to_int(this double self)
		{
			return Convert.ToInt32(self);
		}
		public static float to_float(this double self)
		{
			return Convert.ToSingle(self);
		}
	}
}
