// TestMathf.cs

namespace Ext
{
	using NUnit.Framework;
	using UnityEngine;

	[TestFixture]
	public class TestUnityMathf
	{

		[Test]
		public void TestMathf()
		{
			Assert.IsTrue(Mathf.Approximately(360 / (Mathf.PI * 2), Mathf.Rad2Deg));
			Assert.IsFalse(Mathf.Approximately(3.1415f, Mathf.PI));
			Assert.IsTrue(Mathf.Approximately(3.141590f, Mathf.PI));
			Assert.IsTrue(Mathf.Approximately(1.414213f, Mathf.Sqrt(2)));

			Assert.AreEqual(1, Mathf.Min(1, 2));
			Assert.AreEqual(2, Mathf.Max(1, 2));

			Assert.AreEqual(10, Mathf.Floor(10.1f));
			Assert.AreEqual(10, Mathf.Floor(10.6f));
			Assert.AreEqual(10, Mathf.Round(10.1f));
			Assert.AreEqual(11, Mathf.Round(10.6f));
			Assert.AreEqual(11f, Mathf.Ceil(10.1f));
			Assert.AreEqual(11f, Mathf.Ceil(10.6f));

			Assert.AreEqual(5, Mathf.Abs(-5));
			Assert.AreEqual(1, Mathf.Sin(90 * Mathf.Deg2Rad));
			Assert.AreEqual(-1, Mathf.Cos(180 * Mathf.Deg2Rad));
			Assert.AreEqual(1, Mathf.Tan(45 * Mathf.Deg2Rad));

		}
	}
}
