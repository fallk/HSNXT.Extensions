using System;
using erichexter.Should.Core.Exceptions;
using Xunit;
using Assert = erichexter.Should.Core.Assertions.Assert;

namespace erichexter.Should.Facts.Core
{
    public class IsNotTypeTests
    {
        [Fact]
        public void IsNotType()
        {
            InvalidCastException expected = new InvalidCastException();
            Should.Core.Assertions.Assert.IsNotType(typeof(Exception), expected);
            Should.Core.Assertions.Assert.IsNotType<Exception>(expected);
        }

        [Fact]
        public void IsNotTypeThrowsExceptionWhenWrongType()
        {
            AssertException exception =
                Should.Core.Assertions.Assert.Throws<IsNotTypeException>(() => Should.Core.Assertions.Assert.IsNotType<InvalidCastException>(new InvalidCastException()));

            Should.Core.Assertions.Assert.Equal("Assert.IsNotType() Failure", exception.UserMessage);
        }
    }
}