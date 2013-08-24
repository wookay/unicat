// TestRect.cs

namespace Ext
{
	using NUnit.Framework;
	using UnityEngine;

	[TestFixture]
	public class TestUnityRect
	{

		[Test]
		public void TestRect()
		{
			Rect rect = new Rect(0, 5, 100, 200);
			Assert.AreEqual(0, rect.x);
			Assert.AreEqual(5, rect.y);
			Assert.AreEqual(100, rect.width);
			Assert.AreEqual(200, rect.height);
			Assert.AreEqual(new Vector2(50f, 105f), rect.center);
			Assert.AreEqual("(x:0.00, y:5.00, width:100.00, height:200.00)", rect.ToString());

			Assert.AreEqual(true, rect.Contains(new Vector2(1, 10)));
			Assert.AreEqual(true, rect.Contains(new Vector3(1, 10, 1)));
			Assert.AreEqual(false, rect.Contains(new Vector2(200, 1)));

			RectOffset offset = new RectOffset(0, 10, 0, 10);
			Assert.AreEqual("RectOffset (l:0 r:10 t:0 b:10)", offset.ToString());
		}
	}
}
