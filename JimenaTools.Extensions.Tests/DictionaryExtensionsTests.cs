using System;
using System.Collections.Generic;
using FluentAssertions;
using JimenaTools.Extensions.Enumerables;
using Xunit;

namespace JimenaTools.Extensions.Tests
{
    public class DictionaryExtensionsTests
    {
        [Fact]
        public void Can_get_dictionary_from_key_value_pairs()
        {
            IDictionary<int, string> dictionary;
            KeyValuePair<int, string>[] pairs; 
            
            pairs = new[]
            {
                new KeyValuePair<int, string>(5, "Lorem ipsum dolor sit amet"),
                new KeyValuePair<int, string>(13, "Consectetur adipiscing elit"),
                new KeyValuePair<int, string>(3, "Ut congue mauris id risus lacinia"),
                new KeyValuePair<int, string>(21, "Sed ultricies massa pretium"),
                new KeyValuePair<int, string>(34, "Nunc vulputate condimentum luctus"),
            };

            dictionary = pairs.ToDictionary();

            dictionary.Should().HaveCount(5);
            dictionary.Should().BeEquivalentTo(pairs);
        }

        [Fact]
        public void Cannot_add_pairs_with_duplicated_key()
        {
            IDictionary<int, string> dictionary;
            KeyValuePair<int, string>[] pairs;
            Action action;

            pairs = new[]
            {
                new KeyValuePair<int, string>(5, "Lorem ipsum dolor sit amet"),
                new KeyValuePair<int, string>(13, "Consectetur adipiscing elit"),
                new KeyValuePair<int, string>(3, "Ut congue mauris id risus lacinia"),
                new KeyValuePair<int, string>(21, "Sed ultricies massa pretium"),
                new KeyValuePair<int, string>(13, "Nunc vulputate condimentum luctus"),
            };

            action = () => dictionary = pairs.ToDictionary();

            action.Should().Throw<ArgumentException>();
        }
    }
}