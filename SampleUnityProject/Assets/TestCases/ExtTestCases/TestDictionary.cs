// TestDictionary.cs

using System.Collections.Generic;

namespace Ext
{
	using NUnit.Framework;
	using unicat;

	[TestFixture]
	public class TestDictionaryExt
	{

		[Test]
		public void TestDictionary()
		{
			Dictionary<string, int> d = new Dictionary<string, int>() {
				{"cat", 2},
				{"dog", 1},
			};
			Assert.AreEqual(new string[] {"cat", "dog"}, d.Keys);
			Assert.AreEqual(new int[] {2, 1}, d.Values);
			Assert.AreEqual(new string[] {"cat", "dog"}, d.keys());
			Assert.AreEqual(new int[] {2, 1}, d.values());
			Assert.AreEqual("System.Collections.Generic.Dictionary`2[System.String,System.Int32]", d.ToString());
			Assert.AreEqual("{cat: 2, dog: 1}", d.to_s());
			Assert.AreEqual("{}", new Dictionary<string, int>(){}.to_s());

			Assert.AreEqual(true, d.hasKey("dog"));
			Assert.AreEqual(false, d.hasKey("apple"));

			Assert.AreEqual(1, d.fetch("dog"));
			Assert.AreEqual(null, d.fetch("apple"));

			Assert.AreEqual(2, d.Count);

			d.store("horse", 5);
			Assert.AreEqual("{cat: 2, dog: 1, horse: 5}", d.to_s());
			Assert.AreEqual(3, d.Count);

			d.delete("apple");
			Assert.AreEqual("{cat: 2, dog: 1, horse: 5}", d.to_s());

			d.delete("cat");
			Assert.AreEqual("{dog: 1, horse: 5}", d.to_s());
			Assert.AreEqual(2, d.Count);

			Dictionary<string, int> e = new Dictionary<string, int>() {
                {"cow", 7},
            };
			d.merge(e);
			Assert.AreEqual("{cow: 7, dog: 1, horse: 5}", d.to_s());
			Assert.AreEqual(3, d.Count);
			
			d.clear();
			Assert.AreEqual(0, d.Count);
		}
	}
}
