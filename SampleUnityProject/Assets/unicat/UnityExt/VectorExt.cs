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

		public static Vector3 Round(this Vector3 self)
		{
			return new Vector3(Mathf.Round(self.x), Mathf.Round(self.y), Mathf.Round(self.z));
		}
	}
}
