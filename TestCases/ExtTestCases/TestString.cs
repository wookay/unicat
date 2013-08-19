// TestString.cs

namespace Ext
{
	using NUnit.Framework;
	using unicat;

	[TestFixture]
	public class TestStringExt
	{

		[Test]
		public void TestString()
		{
			Assert.AreEqual("a", " a ".strip());
			Assert.AreEqual("cba", "abc".reverse());
			Assert.AreEqual("bc", "abc".slice(1, 2));
			Assert.AreEqual("abcd", "abcff".gsub("ff", "d"));
			Assert.IsTrue("abcff".include("ff"));
			Assert.IsFalse("abcff".include("gg"));
			Assert.AreEqual(new string[] {"a", "b", "c"}, "abc".split(""));
			Assert.AreEqual(new string[] {"a", "b", "c"}, "a b c".split(" "));
			Assert.AreEqual(new string[] {"a", "b", "c"}, "a, b, c".split(", "));
			Assert.AreEqual("\n", StringExt.LF);
			Assert.AreEqual(" ", StringExt.SPACE);

			Assert.AreEqual("     ", " ".repeat(5));

			Assert.AreEqual(3, "3".to_int());
			Assert.AreEqual(3, "3.14".to_int());
			Assert.AreEqual(-3, "-3".to_int());
			Assert.AreEqual(-3, "-3.14".to_int());
			Assert.AreEqual(3.14f, "3.14".to_float());
			Assert.AreEqual(-3.14f, "-3.14".to_float());

			Assert.AreEqual("a", "a".ToString());
			Assert.AreEqual("a", "a".to_s());
		}
	}
}
