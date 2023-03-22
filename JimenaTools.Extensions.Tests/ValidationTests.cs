using System;
using FluentAssertions;
using Xunit;
using JimenaTools.Extensions.Strings;

namespace JimenaTools.Extensions.Tests
{
    public class ValidationTests
    {
        [Fact]
        public void AsJoined_allows_NewLine_separator()
        {
            string response;
            string[] words;

            words = new[]
            {
                "One",
                "two",
                "three",
            };

            response = words.AsJoinedWith(Environment.NewLine);

            response.Should().Be(@"One
two
three");

        }
    }
}