// TestReflection.cs

using System;
using System.Reflection;

namespace Ext
{
	using NUnit.Framework;

	[TestFixture]
	public class TestReflection
	{

		[Test]
		public void TestType()
		{
			object obj = new object();
			Type type = obj.GetType();
			Assert.AreEqual(typeof(object), type);
			Assert.AreEqual("Object", type.Name);
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
		}

		[Test]
		public void TestInvoke()
		{
			MethodInfo toUpper = typeof(string).GetMethod("ToUpper", Type.EmptyTypes);
			Assert.AreEqual("ToUpper", toUpper.Name);
			Assert.AreEqual("System.String ToUpper()", toUpper.ToString());
			Assert.AreEqual("ABC", toUpper.Invoke("abc", null));
			Assert.AreEqual("", toUpper.Invoke("", null));

			MethodInfo indexOf = typeof(string).GetMethod("IndexOf", new Type[]{ typeof(string) });
			Assert.AreEqual("IndexOf", indexOf.Name);
			Assert.AreEqual("Int32 IndexOf(System.String)", indexOf.ToString());
			Assert.AreEqual(0, indexOf.Invoke("abc", new[]{"ab"}));
			Assert.AreEqual(1, indexOf.Invoke("abc", new[]{"bc"}));
			Assert.AreEqual(-1, indexOf.Invoke("abc", new[]{"cd"}));
		}
	}
}
