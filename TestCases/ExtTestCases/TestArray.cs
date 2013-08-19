// TestArray.cs

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
			string[] abc = new string[] {"a", "b", "c"};
			Assert.AreEqual("abc", abc.join());
			Assert.AreEqual("abc", abc.join(""));
			Assert.AreEqual("a,b,c", abc.join(","));

			string[] bca = new string[] {"b", "c", "a"};
			Assert.AreEqual(abc, bca.sort());
			Assert.AreEqual(new string[] {"b", "c", "a"}, bca);
		}
	}
}
