// TestArray.cs

using System.Collections.Generic;

namespace Ext
{
	using NUnit.Framework;
	using unicat;

	[TestFixture]
	public class TestArrayExt
	{

		[Test]
		public void TestArray()
		{
			int[] oneTwoThree = new int[] {1, 2, 3};
			Assert.AreEqual("System.Int32[]", oneTwoThree.ToString());
			Assert.AreEqual("[]", new int[]{}.to_s());
			Assert.AreEqual("[1, 2, 3]", oneTwoThree.to_s());
			Assert.AreEqual("123", oneTwoThree.join());
			Assert.AreEqual("1,2,3", oneTwoThree.join(","));
			Assert.AreEqual(3, oneTwoThree.Length);

			int[] twoThreeOne = new int[] {2, 3, 1};
			Assert.AreEqual(oneTwoThree, twoThreeOne.sort());
			Assert.AreEqual(new int[] {2, 3, 1}, twoThreeOne);
	
			string[] abc = new string[] {"a", "b", "c"};
			Assert.AreEqual("System.String[]", abc.ToString());
			Assert.AreEqual("[\"a\", \"b\", \"c\"]", abc.to_s());
			Assert.AreEqual("abc", abc.join());
			Assert.AreEqual("abc", abc.join(""));
			Assert.AreEqual("a,b,c", abc.join(","));
			Assert.AreEqual("a", abc.slice(0, 1).join(","));
			Assert.AreEqual(new string[]{}, abc.slice(0, -1));
			Assert.AreEqual(new string[]{}, abc.slice(3, 1));
			Assert.AreEqual("b,c", abc.slice(1, 2).join(","));
			Assert.AreEqual("b,c", abc.slice(1, 3).join(","));
			Assert.IsTrue(abc.include("a"));
			Assert.IsTrue(abc.include("b"));
			Assert.IsFalse(abc.include("ff"));

			string[] bca = new string[] {"b", "c", "a"};
			Assert.AreEqual(abc, bca.sort());
			Assert.AreEqual(new string[] {"b", "c", "a"}, bca);
			Assert.AreEqual(new string[] {"b", "c", "a"}, bca);

			Assert.AreEqual("c b a", abc.reverse().join(" "));
			Assert.AreEqual("a b c", abc.join(" "));
			Assert.AreEqual(abc, abc.reverse().reverse());
		}

		[Test]
		public void TestList()
		{
			List<string> list = new List<string>{"a", "b", "c"};
			string[] abc = new string[] {"a", "b", "c"};
			Assert.AreEqual(abc, list.ToArray());
			Assert.AreEqual("[\"a\", \"b\", \"c\"]", list.to_s());
			Assert.AreEqual(3, list.Count);
			list.push("d");
			Assert.AreEqual("a, b, c, d", list.join(", "));
			Assert.IsTrue(list.include("a"));
			Assert.IsTrue(list.include("b"));
			Assert.IsFalse(list.include("ff"));
			list.concat(new string[]{"e", "f"});
			Assert.AreEqual("a, b, c, d, e, f", list.join(", "));
			Assert.AreEqual(6, list.Count);

			Assert.AreEqual("f", list.pop());
			Assert.AreEqual("a, b, c, d, e", list.join(", "));
			Assert.AreEqual(5, list.Count);

			list.clear();
			Assert.AreEqual(0, list.Count);
		}
	}
}
