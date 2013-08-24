// TestQuaternion.cs

namespace Ext
{
	using NUnit.Framework;
	using UnityEngine;

	[TestFixture]
	public class TestUnityQuaternion
	{

		[Test]
		public void TestQuaternion()
		{
			Assert.AreEqual("(0.0, 0.0, 0.0, 1.0)", Quaternion.identity.ToString());
		}
	}
}
