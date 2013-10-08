// RandomExt.cs

using System;

namespace unicat
{
	public static class Random
	{
		public static int get(int num)
		{
			System.Random rand = new System.Random(Guid.NewGuid().GetHashCode());
			return rand.Next(num);
		}
	}
}
