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
			Assert.AreEqual("System.Collections.Generic.Dictionary`2[System.String,System.Int32]", d.ToString());
			Assert.AreEqual("{cat: 2, dog: 1}", d.to_s());
			Assert.AreEqual("{}", new Dictionary<string, int>(){}.to_s());
		}
	}
}
