// VectorExt.cs

using System;
using UnityEngine;

namespace unicat
{
	public static class VectorExt
	{
		public static Vector3 floor(this Vector3 self)
		{
			return new Vector3(Mathf.Floor(self.x), Mathf.Floor(self.y), Mathf.Floor(self.z));
		}
	}
}
