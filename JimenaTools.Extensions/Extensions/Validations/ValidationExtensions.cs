using System;
using JimenaTools.Extensions.Exceptions;

namespace JimenaTools.Extensions.Validations
{
    public static class ValidationExtensions
    {
        public static T ShouldBeNotNull<T>(this T item, string paramName = null)
            where T : class
        {
            if (item == null)
                throw paramName != null
                    ? new ArgumentNullException(paramName)
                    : new ArgumentNullException();

            return item;
        }

        public static string ShouldBeFilled(this string text, string paramName = null)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new RequiredStringArgumentException(paramName);

            return text;
        }

        public static T ShouldBeNonDefaultValue<T>(this T value, string paramName = null)
            where T : struct, IComparable<T>
        {
            if (value.CompareTo(default) == 0)
                throw new NonDefaultValueArgumentException<T>(paramName);

            return value;
        }
    }
}
