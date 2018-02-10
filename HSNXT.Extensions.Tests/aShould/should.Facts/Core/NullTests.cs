using erichexter.Should.Core.Exceptions;
using Xunit;
using Assert = erichexter.Should.Core.Assertions.Assert;

namespace erichexter.Should.Facts.Core
{
    public class NullTests
    {
        [Fact]
        public void Null()
        {
            Should.Core.Assertions.Assert.Null(null);
        }

        [Fact]
        public void NullThrowsExceptionWhenNotNull()
        {
            try
            {
                Should.Core.Assertions.Assert.Null(new object());
            }
            catch (AssertException exception)
            {
                Should.Core.Assertions.Assert.Equal("Assert.Null() Failure", exception.UserMessage);
            }
        }
    }
}