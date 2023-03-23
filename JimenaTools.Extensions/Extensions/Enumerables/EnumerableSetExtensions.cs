using System;
using System.Collections.Generic;
using System.Linq;

namespace JimenaTools.Extensions.Enumerables
{
    /// <summary>
    /// Extension methods for sets
    /// </summary>
    public static class EnumerableSetExtensions
    {
        /// <summary>
        /// Fluent call of <see cref="Enumerable.Contains{TSource}(IEnumerable{TSource}, TSource)"/>.
        /// </summary>
        public static bool IsAnyOf<T>(this T item, params T[] values) => values.Contains(item);

        /// <summary>
        /// Fluent call of <see cref="Enumerable.Contains{TSource}(IEnumerable{TSource}, TSource)"/>.
        /// </summary>
        public static bool IsAnyOf<T>(this T item, IEnumerable<T> values) => values.Contains(item);

        /// <summary>
        /// Return items of first collection not contained at second one.
        /// </summary>
        public static HashSet<T> Substract<T>(this IEnumerable<T> items, IEnumerable<T> itemsToRemove)
        {
            HashSet<T> result;

            result = items.ToHashSet();
            result.ExceptWith(itemsToRemove);

            return result;
        }
    }
}
