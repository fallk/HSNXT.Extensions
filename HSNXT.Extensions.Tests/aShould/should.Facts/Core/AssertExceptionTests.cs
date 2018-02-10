using erichexter.Should.Core.Exceptions;
using Xunit;
using Assert = erichexter.Should.Core.Assertions.Assert;

namespace erichexter.Should.Facts.Core
{
    public class AssertExceptionTests
    {
        [Fact]
        public void PreservesUserMessage()
        {
            AssertException ex = new AssertException("UserMessage");

            Should.Core.Assertions.Assert.Equal("UserMessage", ex.UserMessage);
        }

        [Fact]
        public void UserMessageIsTheMessage()
        {
            AssertException ex = new AssertException("UserMessage");

            Should.Core.Assertions.Assert.Equal(ex.UserMessage, ex.Message);
        }
    }
}