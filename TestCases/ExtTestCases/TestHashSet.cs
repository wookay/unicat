// TestHashSet.cs

using System.Collections.Generic;

namespace Ext
{
	using NUnit.Framework;
	using unicat;

	[TestFixture]
	public class TestHashSetExt
	{

		[Test]
		public void TestNumberSet()
		{
			HashSet<int> a = new HashSet<int>{1, 2, 3};
      		HashSet<int> b = new HashSet<int>{2, 5};
			Assert.AreEqual("{1, 2, 3}", a.to_s());
			Assert.AreEqual("{2, 5}", b.to_s());
			Assert.AreEqual("System.Collections.Generic.HashSet`1[System.Int32]", a.ToString());
			Assert.AreEqual("{}", new HashSet<int>().to_s());

			HashSet<int> d = new HashSet<int>{1, 2, 3};
			d.IntersectWith(b);
			Assert.AreEqual("{2}", d.to_s());
			Assert.AreEqual(true, d.SetEquals(new HashSet<int>{2}));

			HashSet<int> c = a.intersection(b);
			Assert.AreEqual("{2}", c.to_s());
			Assert.AreEqual("{1, 2, 3}", a.to_s());
			Assert.AreEqual(new int[]{1, 2, 3}, a.to_a());
			Assert.AreEqual(new int[]{3, 5, 1}, new HashSet<int>{3,5,1}.to_a());
		}

		[Test]
		public void TestStringSet()
		{
			HashSet<string> a = new HashSet<string>{"a", "b", "c"};
			HashSet<string> b = new HashSet<string>{"b", "e"};
			Assert.AreEqual("{a, b, c}", a.to_s());
			Assert.AreEqual("{b, e}", b.to_s());

			HashSet<string> c = a.intersection(b);
			Assert.AreEqual("{b}", c.to_s());
			Assert.AreEqual("{a, b, c}", a.to_s());

			string[] e = new string[]{"a", "b", "c"};
			Assert.AreEqual(true, new HashSet<string>(e).SetEquals(a));
		}
	}
}
