// TestNumber.cs

using System;
using System.Collections.Generic;

namespace Ext
{
	using NUnit.Framework;
	using unicat;

	[TestFixture]
	public class TestNumberExt
	{

		[Test]
		public void TestNumber()
		{
			Assert.AreEqual("1", 1.ToString());
			Assert.AreEqual("3.14", 3.14f.ToString(System.Globalization.CultureInfo.InvariantCulture));
			Assert.AreEqual("3.14", 3.14.ToString(System.Globalization.CultureInfo.InvariantCulture));

			Assert.AreEqual("1", 1.to_s());
			Assert.AreEqual(1, 1.to_int());
			Assert.AreEqual(1.0f, 1.to_float());

			Assert.AreEqual("3.14f", 3.14f.to_s());
			Assert.AreEqual(3, 3.14f.to_int());
			Assert.AreEqual(3.14f, 3.14f.to_float());

			Assert.AreEqual("3.14", 3.14.to_s());
			Assert.AreEqual(3, 3.14.to_int());
			Assert.AreEqual(3.14f, 3.14.to_float());
		}

		[Test]
		public void TestRandom()
		{
			Dictionary<int, int> d = new Dictionary<int,int>{};
			Random rand = new Random();
			int max = 50;
			int times = 1000;
			for (int idx = 0; idx < times; idx++) {
				int num = rand.Next(max);
				//int num = rand.Next(0, 5);
				int count = 0;
				d.TryGetValue(num, out count);
				d[num] = count+1;
			}
			Assert.AreEqual(max, d.Count);
			Assert.AreEqual(times, d.values().sum());
		}
	}
}
