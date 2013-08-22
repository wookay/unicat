// DateTimeExt.cs

using System;

namespace unicat
{
	public static class DateTimeExt
	{
		public static string to_s(this DateTime self)
        {
			return self.ToString("yyyy-MM-dd HH:mm:ss");
		}

		public static DateTime tomorrow(this DateTime self)
        {
			return self.AddDays(1);
		}

		public static DateTime yesterday(this DateTime self)
        {
			return self.AddDays(-1);
		}
	}
}
