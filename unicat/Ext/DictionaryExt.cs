// DictionaryExt.cs

using System.Collections.Generic;

namespace unicat
{
	public static class DictionaryExt
	{
		public static bool hasKey<K,V>(this Dictionary<K,V> self, K key)
		{
			return self.ContainsKey(key);
		}

		public static void merge<K,V>(this Dictionary<K,V> self, Dictionary<K,V> other)
		{
			foreach (KeyValuePair<K,V> pair in other) {
				self[pair.Key] = pair.Value;
			}	
		}

		public static V store<K,V>(this Dictionary<K,V> self, K key, V val)
		{
			self[key] = val;
			return val;
		}

		public static object fetch<K,V>(this Dictionary<K,V> self, K key)
		{
			V val;
			bool found = self.TryGetValue(key, out val);
			if (found) {
				return val;
			} else {
				return null;
			}
		}

		public static object delete<K,V>(this Dictionary<K,V> self, K key)
		{
			V val;
			bool found = self.TryGetValue(key, out val);
			if (found) {
				self.Remove(key);
				return val;	
			} else {
				return null;
			}
		}

		public static string to_s<K,V>(this Dictionary<K,V> self)
		{
			List<string> list = new List<string>{};
			foreach (KeyValuePair<K,V> pair in self) {
				list.Add(string.Format("{0}: {1}", pair.Key, pair.Value));
			}
			return "{" + string.Join(", ", list.ToArray()) + "}";
		}

		public static void clear<K,V>(this Dictionary<K,V> self)
		{
			self.Clear();
		}

		public static K[] keys<K,V>(this Dictionary<K,V> self)
		{
			List<K> list = new List<K>{};
			foreach (K key in self.Keys) {
				list.Add(key);
			}
			return list.ToArray();
		}

		public static V[] values<K,V>(this Dictionary<K,V> self)
		{
			List<V> list = new List<V>{};
			foreach (V val in self.Values) {
				list.Add(val);
			}
			return list.ToArray();
		}
	}
}
