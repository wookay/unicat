// TestDateTime.cs

using System;

namespace Ext
{
	using NUnit.Framework;
	using unicat;

	[TestFixture]
	public class TestDateTimeExt
	{

		[Test]
		public void TestDateTime()
		{
			DateTime a = new DateTime(2013, 8, 22, 13, 1, 59);
			Assert.AreEqual("2013-08-22 13:01:59", a.to_s());
			Assert.AreEqual(2013, a.Year);
			Assert.AreEqual(8, a.Month);
			Assert.AreEqual(22, a.Day);
			Assert.AreEqual(13, a.Hour);
			Assert.AreEqual(1, a.Minute);
			Assert.AreEqual(59, a.Second);
			Assert.AreEqual("2013-08-22 00:00:00", a.Date.to_s());
			TimeSpan timeSpan = new TimeSpan(13, 1, 59);
			Assert.AreEqual(a, a.Date + timeSpan);
			Assert.AreEqual(a, a.tomorrow().yesterday());
			Assert.IsTrue(a.tomorrow() > a);
			Assert.IsTrue(a.yesterday() < a);
			Assert.AreEqual(DayOfWeek.Thursday, a.DayOfWeek);
			Assert.AreEqual(DayOfWeek.Friday, a.tomorrow().DayOfWeek);
			Assert.AreEqual(DayOfWeek.Wednesday, a.yesterday().DayOfWeek);

			DateTime b = Convert.ToDateTime("2013-08-22 13:01:59");
			Assert.AreEqual(a, b);
		}
	}
}
