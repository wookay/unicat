// TestVectorExt.cs

namespace Ext
{
	using NUnit.Framework;
	using UnityEngine;
	using unicat;

	[TestFixture]
	public class TestUnityVectorExt
	{

		[Test]
		public void TestVector()
		{
			Vector3 v = new Vector3(1.1f, 1.9f, 0);
			Assert.AreEqual("(1.1, 1.9, 0.0)", v.to_s());
			Assert.AreEqual(new Vector3(1, 2, 0), v.Round());
		}
	}
}
