// TestWWW.cs

namespace Ext
{
	using NUnit.Framework;
	using UnityEngine;

	[TestFixture]
	public class TestUnityWWW
	{

		[Test]
		public void TestWWW()
		{
			Assert.AreEqual("a+%26+b", WWW.EscapeURL("a & b"));
			Assert.AreEqual("a & b", WWW.UnEscapeURL("a+%26+b"));
		}
	}
}
