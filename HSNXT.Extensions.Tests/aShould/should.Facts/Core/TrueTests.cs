using erichexter.Should.Core.Exceptions;
using Xunit;
using Assert = erichexter.Should.Core.Assertions.Assert;

namespace erichexter.Should.Facts.Core
{
    public class TrueTests
    {
        [Fact]
        public void AssertTrue()
        {
            Should.Core.Assertions.Assert.True(true);
        }

        [Fact]
        public void AssertTrueThrowsExceptionWhenFalse()
        {
            TrueException exception =
                Should.Core.Assertions.Assert.Throws<TrueException>(() => Should.Core.Assertions.Assert.True(false));

            Should.Core.Assertions.Assert.Equal("Assert.True() Failure", exception.UserMessage);
        }
    }
}