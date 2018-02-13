using System;
using System.Collections.Generic;
using erichexter.Should.Core.Exceptions;
using Xunit;
using Assert = erichexter.Should.Core.Assertions.Assert;

namespace erichexter.Should.Facts.Core
{
    public class ContainsTests
    {
        [Fact]
        public void CanFindNullInContainer()
        {
            List<object> list = new List<object> {16, null, "Hi there"};

            Should.Core.Assertions.Assert.Contains(null, list);
        }

        [Fact]
        public void CanSearchForSubstrings()
        {
            Should.Core.Assertions.Assert.Contains("wor", "Hello, world!");
        }

        [Fact]
        public void CanSearchForSubstringsCaseInsensitive()
        {
            Should.Core.Assertions.Assert.Contains("WORLD", "Hello, world!",
                StringComparison.InvariantCultureIgnoreCase);
        }

        [Fact]
        public void CanUseComparer()
        {
            List<int> list = new List<int> {42};

            Should.Core.Assertions.Assert.Contains(43, list, new MyComparer());
        }

        [Fact]
        public void ItemInContainer()
        {
            List<int> list = new List<int> {42};

            Should.Core.Assertions.Assert.Contains(42, list);
        }

        [Fact]
        public void ItemNotInContainer()
        {
            List<int> list = new List<int>();

            ContainsException ex =
                Should.Core.Assertions.Assert.Throws<ContainsException>(() =>
                    Should.Core.Assertions.Assert.Contains(42, list));

            Should.Core.Assertions.Assert.Equal("Assert.Contains() failure: Not found: 42", ex.Message);
        }

        [Fact]
        public void NullsAllowedInContainer()
        {
            List<object> list = new List<object> {null, 16, "Hi there"};

            Should.Core.Assertions.Assert.Contains("Hi there", list);
        }

        [Fact]
        public void SubstringContainsIsCaseSensitiveByDefault()
        {
            Should.Core.Assertions.Assert.Throws<ContainsException>(() =>
                Should.Core.Assertions.Assert.Contains("WORLD", "Hello, world!"));
        }

        [Fact]
        public void SubstringNotFound()
        {
            Should.Core.Assertions.Assert.Throws<ContainsException>(() =>
                Should.Core.Assertions.Assert.Contains("hey", "Hello, world!"));
        }

        class MyComparer : IEqualityComparer<int>
        {
            public bool Equals(int x, int y)
            {
                return true;
            }

            public int GetHashCode(int obj)
            {
                throw new NotImplementedException();
            }
        }
    }
}