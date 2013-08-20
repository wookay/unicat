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

		public static V store<K,V>(this Dictionary<K,V> self, K key, V val)
		{
			self.Add(key, val);
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

		public static V delete<K,V>(this Dictionary<K,V> self, K key)
		{
			V val;
			self.TryGetValue(key, out val);
			self.Remove(key);
			return val;	
		}

		public static string to_s<K,V>(this Dictionary<K,V> self)
		{
			List<string> list = new List<string>{};
			foreach (KeyValuePair<K,V> pair in self) {
				list.Add(string.Format("{0}: {1}", pair.Key, pair.Value));
			}
			return "{" + string.Join(", ", list.ToArray()) + "}";
		}
	}
}
