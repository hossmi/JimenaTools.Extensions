using System.Collections.Generic;
using JimenaTools.Extensions.Validations;

namespace JimenaTools.Extensions.Strings
{
    public static class StringExtensions
    {
        public static bool IsFilled(this string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }

        public static string Format(this string text, params object[] args)
        {
            return string.Format(text, args);
        }

        public static string AsJoined(this IEnumerable<string> chunks)
        {
            return string.Join(string.Empty, chunks);
        }

        public static string AsJoinedWith(this IEnumerable<string> chunks, string separator)
        {
            separator.ShouldBeFilled(nameof(separator));
            return string.Join(separator, chunks);
        }
    }
}
