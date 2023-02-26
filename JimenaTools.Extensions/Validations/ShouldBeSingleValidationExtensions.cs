using System;
using System.Collections.Generic;
using System.Linq;

namespace JimenaTools.Extensions.Validations
{
    public static class ShouldBeSingleValidationExtensions
    {
        public static T ShouldBeSingle<T>(this IEnumerable<T> items, Func<Exception> getException)
        {
            T[] result;

            result = items
                .ShouldBeNotNull(nameof(items))
                .Take(2)
                .ToArray();

            if (result.Length == 1)
                return result[0];

            throw getException();
        }

        public static T ShouldBeSingle<T>(this IEnumerable<T> items, Func<IEnumerable<T>, Exception> getException)
        {
            T[] result;

            result = items
                .ShouldBeNotNull(nameof(items))
                .Take(2)
                .ToArray();

            if (result.Length == 1)
                return result[0];

            throw getException(items);
        }

        public static T ShouldBeSingleOrDefault<T>(this IEnumerable<T> items, Func<Exception> getException)
        {
            T[] result;

            result = items
                .ShouldBeNotNull(nameof(items))
                .Take(2)
                .ToArray();

            if (result.Length == 0)
                return default;

            if (result.Length == 1)
                return result[0];

            throw getException();
        }

        public static T ShouldBeSingleOrDefault<T>(this IEnumerable<T> items, Func<IEnumerable<T>, Exception> getException)
        {
            T[] result;

            result = items
                .ShouldBeNotNull(nameof(items))
                .Take(2)
                .ToArray();

            if (result.Length == 0)
                return default;

            if (result.Length == 1)
                return result[0];

            throw getException(items);
        }
    }
}
