// TestLinq.cs

using System.Linq;

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
	}
}
