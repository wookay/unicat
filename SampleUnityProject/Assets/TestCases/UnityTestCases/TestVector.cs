// TestVector.cs

namespace Ext
{
	using NUnit.Framework;
	using UnityEngine;

	[TestFixture]
	public class TestUnityVector
	{

		[Test]
		public void TestVector2()
		{
			Assert.AreEqual("(0.0, 0.0)", Vector2.zero.ToString());

			Vector2 a = new Vector2(3, 5);
			Vector2 b = new Vector2(2, 3);
			Assert.AreEqual("(5.0, 8.0)", (a+b).ToString());
			Assert.AreEqual("(1.0, 2.0)", (a-b).ToString());
		}

		[Test]
		public void TestVector3()
		{
			Assert.AreEqual("(0.0, 0.0, 0.0)", Vector3.zero.ToString());

			Vector3 a = new Vector3(1.1f, 1.8f, 0);
			Assert.AreEqual(new Vector3(1.1f, 1.8f, 0), a);
			Assert.AreEqual("(1.1, 1.8, 0.0)", a.ToString());
		}
	}
}
