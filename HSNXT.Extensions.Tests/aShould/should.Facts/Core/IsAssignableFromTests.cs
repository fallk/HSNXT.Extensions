using System;
using erichexter.Should.Core.Exceptions;
using Xunit;
using Assert = erichexter.Should.Core.Assertions.Assert;

namespace erichexter.Should.Facts.Core
{
    public class IsAssignableFromTests
    {
        [Fact]
        public void IsAssignableFrom_SameType()
        {
            InvalidCastException expected = new InvalidCastException();
            Should.Core.Assertions.Assert.IsAssignableFrom(typeof(InvalidCastException), expected);
            Should.Core.Assertions.Assert.IsAssignableFrom<InvalidCastException>(expected);
        }

        [Fact]
        public void IsAssignableFrom_BaseType()
        {
            InvalidCastException expected = new InvalidCastException();
            Should.Core.Assertions.Assert.IsAssignableFrom(typeof(Exception), expected);
            Should.Core.Assertions.Assert.IsAssignableFrom<Exception>(expected);
        }

        [Fact]
        public void IsAssignableFromReturnsCastObject()
        {
            InvalidCastException expected = new InvalidCastException();
            InvalidCastException actual =
                Should.Core.Assertions.Assert.IsAssignableFrom<InvalidCastException>(expected);
            Should.Core.Assertions.Assert.Same(expected, actual);
        }

        [Fact]
        public void IsAssignableFromThrowsExceptionWhenWrongType()
        {
            AssertException exception =
                Should.Core.Assertions.Assert.Throws<IsAssignableFromException>(
                    () => Should.Core.Assertions.Assert.IsAssignableFrom<InvalidCastException>(
                        new InvalidOperationException()));

            Should.Core.Assertions.Assert.Equal("Assert.IsAssignableFrom() Failure", exception.UserMessage);
        }

        [Fact]
        public void IsAssignableFromThrowsExceptionWhenPassedNull()
        {
            Should.Core.Assertions.Assert.Throws<IsAssignableFromException>(() =>
                Should.Core.Assertions.Assert.IsAssignableFrom<object>(null));
        }
    }
}