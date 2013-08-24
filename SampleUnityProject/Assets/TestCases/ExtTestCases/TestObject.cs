// TestObject.cs

using System;

namespace Ext
{
	using NUnit.Framework;

	[TestFixture]
	public class TestSystemObject
	{
		[Test]
		public void TestObject()
		{
			object a = new object();
			Assert.AreEqual("System.Object", a.ToString());
			Assert.AreEqual(true, a is object);

			object b = new object();
			Assert.AreEqual(false, a.Equals(b));
		}
	}
}
