using System.Collections.Generic;

namespace JimenaTools.Extensions.Enumerables
{
    public static class DictionaryExtensions
    {
        public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> items)
        {
            Dictionary<TKey, TValue> concreteDictionary; 
            IDictionary<TKey, TValue> dictionaryAsCollection;

            concreteDictionary = new Dictionary<TKey, TValue>();
            dictionaryAsCollection = concreteDictionary;

            foreach (KeyValuePair<TKey, TValue> item in items)
                dictionaryAsCollection.Add(item);

            return concreteDictionary;
        }
    }
}
