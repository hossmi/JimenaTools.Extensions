using System;
using FluentAssertions;
using JimenaTools.Extensions.Strings;
using Xunit;

namespace JimenaTools.Extensions.Tests
{
    public class ValidationTests
    {
        [Fact]
        public void Can_merge_strings_using_NewLine_as_separator()
        {
            string response;
            string[] words;

            words = new[]
            {
                "One",
                "two",
                "three",
            };

            response = words.MergedWith(Environment.NewLine);

            response.Should().Be(@"One
two
three");

        }
    }
}