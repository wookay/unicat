// TestLinq.cs

using System.Linq;
using System.Collections.Generic;

namespace Ext
{
	using NUnit.Framework;

	[TestFixture]
	public class TestLinqExt
	{

		[Test]
		public void TestLinq()
		{
			int[] a = new int[]{ 1, 2, 3, 4, 5};
			Assert.AreEqual(new int[]{1,2}, a.Where(n => n < 3).ToArray());

			string[] b = new string[]{ "apple", "banana", "" };
			Assert.AreEqual(new string[]{"a", "b"},
				b.Where(s => s.Length > 0)
				 .Select(s => s[0].ToString())
				 .ToArray()
			);
		}

		[Test]
		public void TestDictionaryToList()
		{
			 Dictionary<string, int> d = new Dictionary<string, int>() {
				{"cat", 2},
				{"dog", 1},
			};
			List<KeyValuePair<string, int>> list = d.ToList();
			Assert.AreEqual(new List<KeyValuePair<string,int>>{
					new KeyValuePair<string, int>("cat", 2),
					new KeyValuePair<string, int>("dog", 1)
				}, list);
			Assert.AreEqual(2, list.Count);
			Assert.AreEqual(d, list.ToDictionary(
					(pair) => pair.Key,
					(pair) => pair.Value));
		}
	}
}
