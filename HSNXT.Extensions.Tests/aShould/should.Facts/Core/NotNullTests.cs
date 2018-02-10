using erichexter.Should.Core.Exceptions;
using Xunit;
using Assert = erichexter.Should.Core.Assertions.Assert;

namespace erichexter.Should.Facts.Core
{
    public class NotNullTests
    {
        [Fact]
        public void NotNull()
        {
            Should.Core.Assertions.Assert.NotNull(new object());
        }

        [Fact]
        public void NotNullThrowsException()
        {
            Should.Core.Assertions.Assert.Throws<NotNullException>(() => Should.Core.Assertions.Assert.NotNull(null));
        }
    }
}