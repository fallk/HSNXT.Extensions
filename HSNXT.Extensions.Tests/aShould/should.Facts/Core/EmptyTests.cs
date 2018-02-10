using System;
using System.Collections.Generic;
using erichexter.Should.Core.Exceptions;
using Xunit;
using Assert = erichexter.Should.Core.Assertions.Assert;

namespace erichexter.Should.Facts.Core
{
    public class EmptyTests
    {
        public class Containers
        {
            [Fact]
            public void IsEmpty()
            {
                List<int> list = new List<int>();

                Should.Core.Assertions.Assert.Empty(list);
            }

            [Fact]
            public void IsNotEmpty()
            {
                List<int> list = new List<int>();
                list.Add(42);

                EmptyException ex = Should.Core.Assertions.Assert.Throws<EmptyException>(() => Should.Core.Assertions.Assert.Empty(list));

                Should.Core.Assertions.Assert.Equal("Assert.Empty() failure", ex.Message);
            }

            [Fact]
            public void NullIsNotEmpty()
            {
                Should.Core.Assertions.Assert.Throws<ArgumentNullException>(() => Should.Core.Assertions.Assert.Empty(null));
            }
        }

        public class Strings
        {
            [Fact]
            public void IsEmpty()
            {
                Should.Core.Assertions.Assert.Empty("");
            }

            [Fact]
            public void IsNotEmpty()
            {
                EmptyException ex = Should.Core.Assertions.Assert.Throws<EmptyException>(() => Should.Core.Assertions.Assert.Empty("Foo"));

                Should.Core.Assertions.Assert.Equal("Assert.Empty() failure", ex.Message);
            }
        }
    }
}