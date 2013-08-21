// HashSetExt.cs

using System.Collections.Generic;

namespace unicat
{
	public static class HashSetExt
	{
		public static T[] to_a<T>(this HashSet<T> self)
		{
			List<T> list = new List<T>{};
			foreach (T element in self) {
				list.Add(element);
			}
			return list.ToArray();	
		}

		public static string to_s<T>(this HashSet<T> self)
		{
			List<string> list = new List<string>{};
			foreach (T element in self) {
				list.Add(element.ToString());
			}
			return "{" + string.Join(", ", list.ToArray()) + "}";
		}

		public static HashSet<T> intersection<T>(this HashSet<T> self, HashSet<T> other)
		{
			HashSet<T> set = new HashSet<T>(self);
			set.IntersectWith(other);
			return set;
		}
	}
}
