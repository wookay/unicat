// TestColor.cs

namespace Ext
{
	using NUnit.Framework;
	using UnityEngine;

	[TestFixture]
	public class TestUnityColor
	{

		[Test]
		public void TestColor()
		{
			Color red = Color.red;
			Assert.AreEqual("RGBA(1.000, 0.000, 0.000, 1.000)", red.ToString());
			Assert.AreEqual(1f, red.r);
			Assert.AreEqual(0f, red.g);
			Assert.AreEqual(0f, red.b);
			Assert.AreEqual(1f, red.a);
			Assert.AreEqual(red, new Color(1,0,0,1));
		}
	}
}
