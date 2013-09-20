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

			Vector2 p = new Vector2(3, 4);
			Assert.AreEqual(5, p.magnitude);
			Assert.AreEqual("(0.6, 0.8)", p.normalized.ToString());

			Vector3 v = p;
			Assert.AreEqual(new Vector3(3, 4, 0), v);

			Assert.AreEqual(new Vector2(1, 1), Vector2.one);
			Assert.AreEqual(new Vector2(1, 0), Vector2.right);
			Assert.AreEqual(new Vector2(0, 1), Vector2.up);
			Assert.AreEqual(new Vector2(0, 0), Vector2.zero);
		}

		[Test]
		public void TestVector3()
		{
			Assert.AreEqual("(0.0, 0.0, 0.0)", Vector3.zero.ToString());

			Vector3 a = new Vector3(1.1f, 1.8f, 0);
			Assert.AreEqual(new Vector3(1.1f, 1.8f, 0), a);
			Assert.AreEqual("(1.1, 1.8, 0.0)", a.ToString());

			Assert.AreEqual(new Vector3(0, 0, -1), Vector3.back);
			Assert.AreEqual(new Vector3(0, -1, 0), Vector3.down);
			Assert.AreEqual(new Vector3(0, 0, 1), Vector3.forward);
			Assert.AreEqual(new Vector3(-1, 0, 0), Vector3.left);
			Assert.AreEqual(new Vector3(1, 1, 1), Vector3.one);
			Assert.AreEqual(new Vector3(1, 0, 0), Vector3.right);
			Assert.AreEqual(new Vector3(0, 1, 0), Vector3.up);
			Assert.AreEqual(new Vector3(0, 0, 0), Vector3.zero);

			Vector3 p = new Vector3(1, 2, 3);
			Assert.AreEqual(1, p[0]);
			Assert.AreEqual(2, p[1]);
			Assert.AreEqual(3, p[2]);

			p[1] = 5;
			Assert.AreEqual(5, p[1]);

			p.Set(5, 6, 7);
			Assert.AreEqual("(5.0, 6.0, 7.0)", p.ToString());
		}
	}
}
