// TestObject.cs

using System;
using System.Reflection;

namespace Ext
{
	using NUnit.Framework;

	[TestFixture]
	public class TestObjectExt
	{

		[Test]
		public void TestObject()
		{
			object a = new object();
			Assert.AreEqual("System.Object", a.ToString());
			Assert.IsTrue(a is object);
			Type type = a.GetType();
			Assert.AreEqual(typeof(object), type);
			Assert.AreEqual("System.Object", type.ToString());
			Assert.AreEqual(Type.GetType("System.Object"), type);

			ConstructorInfo[] constructorInfo = type.GetConstructors();
			Assert.AreEqual(1, constructorInfo.Length);
			Assert.AreEqual("Void .ctor()", constructorInfo[0].ToString());

			MethodInfo[] methodInfo = type.GetMethods();
			Assert.AreEqual(6, methodInfo.Length);
			Assert.AreEqual("System.Type GetType()", methodInfo[3].ToString());

			FieldInfo[] fieldInfo = type.GetFields();
			Assert.AreEqual(0, fieldInfo.Length);

			object b = new object();
			Assert.IsFalse(a.Equals(b));
		}
	}
}
