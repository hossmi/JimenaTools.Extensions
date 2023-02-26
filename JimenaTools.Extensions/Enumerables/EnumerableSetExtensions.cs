using System;
using System.Collections.Generic;
using System.Linq;

namespace JimenaTools.Extensions.Enumerables
{
    public static class EnumerableSetExtensions
    {
        public static bool IsAnyOf<T>(this T item, params T[] values)
        {
            return values.Contains(item);
        }

        public static bool IsAnyOf<T>(this T item, IEnumerable<T> values)
        {
            return values.Contains(item);
        }

        public static HashSet<T> Substract<T>(this IEnumerable<T> items, IEnumerable<T> itemsToRemove)
        {
            HashSet<T> result;

            result = items.ToHashSet();
            result.ExceptWith(itemsToRemove);

            return result;
        }
    }
}
