// VectorExt.cs

using System;
using UnityEngine;

namespace unicat
{
	public static class VectorExt
	{
		public static string to_s(this Vector3 self)
		{
			return self.ToString();
		}

		public static Vector3 floor2(this Vector3 self)
		{
			return new Vector3(Mathf.Floor(self.x), Mathf.Floor(self.y), self.z);
		}
	}
}
