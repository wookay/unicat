// TestNumber.cs

namespace Ext
{
	using NUnit.Framework;
	using unicat;

	[TestFixture]
	public class TestNumberExt
	{

		[Test]
		public void TestNumber()
		{
			Assert.AreEqual("1", 1.ToString());
			Assert.AreEqual("3.14", 3.14f.ToString(System.Globalization.CultureInfo.InvariantCulture));
			Assert.AreEqual("3.14", 3.14.ToString(System.Globalization.CultureInfo.InvariantCulture));

			Assert.AreEqual("1", 1.to_s());
			Assert.AreEqual(1, 1.to_int());
			Assert.AreEqual(1.0f, 1.to_float());

			Assert.AreEqual("3.14f", 3.14f.to_s());
			Assert.AreEqual(3, 3.14f.to_int());
			Assert.AreEqual(3.14f, 3.14f.to_float());

			Assert.AreEqual("3.14", 3.14.to_s());
			Assert.AreEqual(3, 3.14.to_int());
			Assert.AreEqual(3.14f, 3.14.to_float());
		}
	}
}
