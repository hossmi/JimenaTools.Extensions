using System;
using FluentAssertions;
using JimenaTools.Extensions.Strings;
using Xunit;

namespace JimenaTools.Extensions.Tests
{
    public class EnumerableSetExtensionsTests
    {
        [Fact]
        public void String_is_not_empty()
        {
            string text = "Lorem ipsum";

            text.IsNullEmptyOrWhiteSpace().Should().BeFalse();
        }

        [Fact]
        public void String_is_empty()
        {
            string text = "";

            text.IsNullEmptyOrWhiteSpace().Should().BeTrue();
        }

        [Fact]
        public void String_with_new_line_is_empty()
        {
            string text = Environment.NewLine;

            text.IsNullEmptyOrWhiteSpace().Should().BeTrue();
        }

        [Fact]
        public void String_with_spaces_is_empty()
        {
            string text = "   ";

            text.IsNullEmptyOrWhiteSpace().Should().BeTrue();
        }

        [Fact]
        public void String_with_spaces_tabs_and_line_breaks_is_empty()
        {
            string text = @"  
    
  
    ";

            text.IsNullEmptyOrWhiteSpace().Should().BeTrue();
        }
    }
}