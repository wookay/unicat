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
				} else if (element is string[]) {
					list.Add(ArrayExt.to_s((IEnumerable<string>)element));
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

		public static T[] reverse<T>(this T[] self)
		{
			List<T> list = new List<T>(self);
			T[] ary = list.ToArray();
			Array.Reverse(ary);
			return ary;
		}

		public static T[] sort<T>(this T[] self)
		{
			List<T> list = new List<T>(self);
			list.Sort();
			return list.ToArray();
		}

		public static T[] slice<T>(this T[] self, int loc, int length)
		{
			List<T> list = new List<T>{};
			int count = self.Length;
			for	(int idx = loc; idx < loc + length; idx++)
			{
				if (count > idx) {
					list.Add(self[idx]);
				}
			}
			return list.ToArray();
		}

		public static bool include<T>(this T[] self, T element)
		{
			return 0 <= Array.IndexOf(self, element);
		}

		public static int sum(this int[] self)
		{
			int num = 0;
			foreach (int element in self) {
				num += element;
			}
			return num;
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

		public static bool include<T>(this List<T> self, T element)
		{
			return self.Contains(element);
		}

		public static List<T> concat<T>(this List<T> self, T[] elements)
		{
			self.AddRange(elements);
			return self;
		}

		public static void clear<T>(this List<T> self)
		{
			self.Clear();
		}
	}
}
