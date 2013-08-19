// ArrayExt.cs

using System;
using System.Collections.Generic;

namespace unicat
{
	public static class ArrayExt
	{
		public static string to_s<T>(this IEnumerable<T> self)
		{
			List<string> list = new List<string>{};
			foreach (T element in self) {
				if (element is string) {
					list.Add("\"" + element + "\"");
				} else {
					list.Add(element.ToString());
				}
			}
			return "[" + string.Join(", ", list.ToArray()) + "]";	
		}

		public static string join<T>(this IEnumerable<T> self, string sep)
		{
			List<string> list = new List<string>{};
			foreach (T element in self) {
				list.Add(element.ToString());
			}
			return string.Join(sep, list.ToArray());	
		}

		public static string join<T>(this T[] self)
		{
			return self.join("");
		}

		public static T[] sort<T>(this T[] self)
		{
			List<T> list = new List<T>(self);
			list.Sort();
			return list.ToArray();
		}
	}



	public static class ListExt
	{
		public static List<T> push<T>(this List<T> self, T element)
		{
			self.Add(element);
			return self;
		}

		public static T pop<T>(this List<T> self)
		{
			int idx = self.Count - 1;
			T ret = self[idx];
			self.RemoveAt(idx);
			return ret;
		}

		public static List<T> concat<T>(this List<T> self, T[] elements)
		{
			self.AddRange(elements);
			return self;
		}
	}
}
