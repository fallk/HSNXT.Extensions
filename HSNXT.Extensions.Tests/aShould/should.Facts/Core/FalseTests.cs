using erichexter.Should.Core.Exceptions;
using Xunit;
using Assert = erichexter.Should.Core.Assertions.Assert;

namespace erichexter.Should.Facts.Core
{
    public class FalseTests
    {
        [Fact]
        public void AssertFalse()
        {
            Should.Core.Assertions.Assert.False(false);
        }

        [Fact]
        public void AssertFalseThrowsExceptionWhenTrue()
        {
            try
            {
                Should.Core.Assertions.Assert.False(true);
            }
            catch (AssertException exception)
            {
                Should.Core.Assertions.Assert.Equal("Assert.False() Failure", exception.UserMessage);
            }
        }
    }
}