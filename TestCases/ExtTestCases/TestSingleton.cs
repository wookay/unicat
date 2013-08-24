// TestSingleton.cs

using System;

namespace Ext
{
	using NUnit.Framework;

	[TestFixture]
	public class TestSingleton
	{
		[Test]
		public void TestSharedInstance()
		{
			Single a = Single.sharedInstance;
			Single b = Single.sharedInstance;
			Assert.AreEqual(a, b);
		}
	}


	// singleton class
	public class Single
	{
		private static Single instance;
		public Single()
		{
			if (null == instance) {
				instance = this;
			}
		}
		public static Single sharedInstance
		{
			get {
				if (null == instance) {
					new Single();
				}
				return instance;
			}
		}
	}
}
