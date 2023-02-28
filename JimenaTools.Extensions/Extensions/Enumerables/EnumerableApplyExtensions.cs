using System;
using System.Collections.Generic;

namespace JimenaTools.Extensions.Enumerables
{
    public static class EnumerableApplyExtensions
    {
        public static IEnumerable<T> Apply<T>(this IEnumerable<T> items, Action<T> action)
        {
            foreach (T item in items)
            {
                action(item);
                yield return item;
            }
        }

        public static void AndApply<T>(this IEnumerable<T> items, Action<T> action)
        {
            foreach (T item in items)
                action(item);
        }

        public static void AndApply<T, TIgnored>(this IEnumerable<T> items, Func<T, TIgnored> action)
        {
            foreach (T item in items)
                action(item);
        }
    }
}
