using System.Collections.Generic;
using erichexter.Should.Core.Exceptions;
using Xunit;
using Assert = erichexter.Should.Core.Assertions.Assert;

namespace erichexter.Should.Facts.Core
{
    public class NotEmptyTests
    {
        [Fact]
        public void ContainerIsEmpty()
        {
            List<int> list = new List<int>();

            NotEmptyException ex =
                Should.Core.Assertions.Assert.Throws<NotEmptyException>(() => Should.Core.Assertions.Assert.NotEmpty(list));

            Should.Core.Assertions.Assert.Equal("Assert.NotEmpty() failure", ex.Message);
        }

        [Fact]
        public void ContainerIsNotEmpty()
        {
            List<int> list = new List<int>();
            list.Add(42);

            Should.Core.Assertions.Assert.NotEmpty(list);
        }
    }
}