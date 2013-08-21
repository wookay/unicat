// TestVector.cs

namespace Ext
{
	using NUnit.Framework;
	using UnityEngine;

	[TestFixture]
	public class TestVector
	{

		[Test]
		public void TestRect()
		{
			Rect rect = new Rect(0, 0, 150, 150);
			Assert.IsTrue(rect.Contains(new Vector2(1, 1)));
			Assert.IsTrue(rect.Contains(new Vector3(1, 1, 1)));
			Assert.IsFalse(rect.Contains(new Vector2(200, 1)));
		}

		[Test]
		public void TestVector2()
		{
			Assert.AreEqual("(0.0, 0.0)", Vector2.zero.ToString());
		}

		[Test]
		public void TestVector3()
		{
			Assert.AreEqual("(0.0, 0.0, 0.0)", Vector3.zero.ToString());
		}
	}
}
