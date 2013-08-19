// TestUnicat.cs

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
	}
}
