// TestRandom.cs

using System;
using System.Collections.Generic;

namespace Ext
{
	using NUnit.Framework;
	using unicat;

	[TestFixture]
	public class TestRandomExt
	{

		[Test]
		public void TestRandom()
		{
            Dictionary<int, int> d = new Dictionary<int,int>{};
            int max = 50;
            int times = 1000;
            for (int idx = 0; idx < times; idx++) {
                int num = Random.get(max);
                int count = 0;
                d.TryGetValue(num, out count);
                d[num] = count+1;
            }
            Assert.AreEqual(max, d.Count);
            Assert.AreEqual(times, d.values().sum());
		}
	}
}
