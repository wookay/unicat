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

		[Test]
		public void TestReflectionInvoke()
		{
			MethodInfo toUpper = typeof(string).GetMethod("ToUpper", Type.EmptyTypes);
			Assert.AreEqual("System.String ToUpper()", toUpper.ToString());
			Assert.AreEqual("ABC", toUpper.Invoke("abc", null));
			Assert.AreEqual("", toUpper.Invoke("", null));

			MethodInfo indexOf = typeof(string).GetMethod("IndexOf", new Type[]{ typeof(string) });
			Assert.AreEqual("Int32 IndexOf(System.String)", indexOf.ToString());
			Assert.AreEqual(0, indexOf.Invoke("abc", new[]{"ab"}));
			Assert.AreEqual(1, indexOf.Invoke("abc", new[]{"bc"}));
			Assert.AreEqual(-1, indexOf.Invoke("abc", new[]{"cd"}));
		}

		[Test]
		public void TestSingleton()
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
