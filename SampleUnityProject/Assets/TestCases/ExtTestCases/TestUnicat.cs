// TestUnicat.cs

using System.Collections.Generic;

namespace Ext
{
	using NUnit.Framework;
	using unicat;

	[TestFixture]
	public class TestUnicat
	{
		[Test]
		public void TestNumber()
		{
			Assert.AreEqual(3.14f, 3.14f.to_s().to_float());
			Assert.AreEqual(3, 3.14f.to_s().to_int());
		}

		[Test]
		public void TestHashSet()
		{
			Assert.AreEqual(new int[]{1, 3, 5}, new HashSet<int>{3,5,1}.to_a().sort());
		}
	}
}
