using System;
using System.Collections.Generic;
using JimenaTools.Extensions.Validations;

namespace JimenaTools.Extensions.Strings
{
    /// <summary>
    /// Set of <see cref="System.String"/> extension methods. 
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Returns the opposite to <see cref="System.String.IsNullOrWhiteSpace"/>.
        /// </summary>
        public static bool IsFilled(this string value) => !string.IsNullOrWhiteSpace(value);

        public static bool IsNullEmptyOrWhiteSpace(this string value) => string.IsNullOrWhiteSpace(value);

        /// <summary>
        /// Extension method for fluently call string.Format static method.
        /// </summary>
        public static string Format(this string text, params object[] args)
        {
            return string.Format(text, args);
        }

        /// <summary>
        /// Extension method for fluently call string.Join static method.
        /// </summary>
        public static string AsJoined(this IEnumerable<string> chunks)
        {
            return string.Join(string.Empty, chunks);
        }

        /// <summary>
        /// Extension method for fluently call string.Join static method.
        /// </summary>
        public static string AsJoinedWith(this IEnumerable<string> chunks, string separator)
        {
            separator.ShouldBeNotNull(nameof(separator));
            return string.Join(separator, chunks);
        }
    }
}
