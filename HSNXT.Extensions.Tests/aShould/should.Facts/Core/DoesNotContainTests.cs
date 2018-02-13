using System;
using System.Collections.Generic;
using erichexter.Should.Core.Exceptions;
using Xunit;
using Assert = erichexter.Should.Core.Assertions.Assert;

namespace erichexter.Should.Facts.Core
{
    public class DoesNotContainTests
    {
        [Fact]
        public void CanSearchForNullInContainer()
        {
            List<object> list = new List<object> {16, "Hi there"};

            Should.Core.Assertions.Assert.DoesNotContain(null, list);
        }

        [Fact]
        public void CanSearchForSubstrings()
        {
            Should.Core.Assertions.Assert.DoesNotContain("hey", "Hello, world!");
        }

        [Fact]
        public void CanSearchForSubstringsCaseInsensitive()
        {
            Should.Core.Assertions.Assert.Throws<DoesNotContainException>(
                () => Should.Core.Assertions.Assert.DoesNotContain("WORLD", "Hello, world!",
                    StringComparison.InvariantCultureIgnoreCase));
        }

        [Fact]
        public void CanUseComparer()
        {
            List<int> list = new List<int>();
            list.Add(42);

            Should.Core.Assertions.Assert.DoesNotContain(42, list, new MyComparer());
        }

        [Fact]
        public void ItemInContainer()
        {
            List<int> list = new List<int> {42};

            DoesNotContainException ex =
                Should.Core.Assertions.Assert.Throws<DoesNotContainException>(() =>
                    Should.Core.Assertions.Assert.DoesNotContain(42, list));

            Should.Core.Assertions.Assert.Equal("Assert.DoesNotContain() failure: Found: 42", ex.Message);
        }

        [Fact]
        public void ItemNotInContainer()
        {
            List<int> list = new List<int>();

            Should.Core.Assertions.Assert.DoesNotContain(42, list);
        }

        [Fact]
        public void NullsAllowedInContainer()
        {
            List<object> list = new List<object> {null, 16, "Hi there"};

            Should.Core.Assertions.Assert.DoesNotContain(42, list);
        }

        [Fact]
        public void SubstringDoesNotContainIsCaseSensitiveByDefault()
        {
            Should.Core.Assertions.Assert.DoesNotContain("WORLD", "Hello, world!");
        }

        [Fact]
        public void SubstringFound()
        {
            Should.Core.Assertions.Assert.Throws<DoesNotContainException>(() =>
                Should.Core.Assertions.Assert.DoesNotContain("world", "Hello, world!"));
        }

        class MyComparer : IEqualityComparer<int>
        {
            public bool Equals(int x, int y)
            {
                return false;
            }

            public int GetHashCode(int obj)
            {
                throw new NotImplementedException();
            }
        }
    }
}