// TestVector3.cs

namespace Ext
{
	using NUnit.Framework;
	using UnityEngine;

	[TestFixture]
	public class TestGameObject
	{

		[Test]
		public void TestVector3()
		{
			Assert.AreEqual("(0.0, 0.0, 0.0)", Vector3.zero.ToString());
		}
	}
}
