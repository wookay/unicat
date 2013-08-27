// TestCamera.cs

namespace Ext
{
	using NUnit.Framework;
	using UnityEngine;

	[TestFixture]
	public class TestUnityCamera
	{

		[Test]
		public void TestScreenToWorldPoint()
		{
			Camera camera = Camera.main;
			Vector3 screenPoint = camera.WorldToScreenPoint(new Vector3(1,1,0));
			Vector3 worldPoint = camera.ScreenToWorldPoint(screenPoint);
			Assert.AreEqual("(1.0, 1.0, 0.0)", worldPoint.ToString());
		}
	}
}
