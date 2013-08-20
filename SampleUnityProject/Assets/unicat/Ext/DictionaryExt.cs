// DictionaryExt.cs

using System.Collections.Generic;

namespace unicat
{
	public static class DictionaryExt
	{
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
