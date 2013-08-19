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
		}
	}
}
