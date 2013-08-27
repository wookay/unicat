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
		public void TestFloor()
		{
			Vector3 v = new Vector3(1.1f, 1.9f, 1.5f);
			Assert.AreEqual(Vector3.one, v.floor());
		}
	}
}
