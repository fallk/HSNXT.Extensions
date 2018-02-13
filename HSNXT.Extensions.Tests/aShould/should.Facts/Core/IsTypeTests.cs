using System;
using erichexter.Should.Core.Exceptions;
using Xunit;
using Assert = erichexter.Should.Core.Assertions.Assert;

namespace erichexter.Should.Facts.Core
{
    public class IsTypeTests
    {
        [Fact]
        public void IsType()
        {
            InvalidCastException expected = new InvalidCastException();
            Should.Core.Assertions.Assert.IsType(typeof(InvalidCastException), expected);
            Should.Core.Assertions.Assert.IsType<InvalidCastException>(expected);
        }

        [Fact]
        public void IsTypeReturnsCastObject()
        {
            InvalidCastException expected = new InvalidCastException();
            InvalidCastException actual = Should.Core.Assertions.Assert.IsType<InvalidCastException>(expected);
            Should.Core.Assertions.Assert.Same(expected, actual);
        }

        [Fact]
        public void IsTypeThrowsExceptionWhenWrongType()
        {
            AssertException exception =
                Should.Core.Assertions.Assert.Throws<IsTypeException>(() =>
                    Should.Core.Assertions.Assert.IsType<InvalidCastException>(new InvalidOperationException()));

            Should.Core.Assertions.Assert.Equal("Assert.IsType() Failure", exception.UserMessage);
        }

        [Fact]
        public void IsTypeThrowsExceptionWhenPassedNull()
        {
            Should.Core.Assertions.Assert.Throws<IsTypeException>(() =>
                Should.Core.Assertions.Assert.IsType<object>(null));
        }
    }
}