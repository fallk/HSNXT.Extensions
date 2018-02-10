using System;
using erichexter.Should.Core.Exceptions;
using Xunit;
using Assert = erichexter.Should.Core.Assertions.Assert;

namespace erichexter.Should.Facts.Core
{
    public class NotEqualTests
    {
        [Fact]
        public void NotEqualFailsString()
        {
            try
            {
                Should.Core.Assertions.Assert.NotEqual("actual", "actual");
            }
            catch (NotEqualException exception)
            {
                Should.Core.Assertions.Assert.Equal("Assert.NotEqual() Failure", exception.UserMessage);
            }
        }

        [Fact]
        public void NotEqualWithCustomComparer()
        {
            string expected = "TestString";
            string actual = "testString";

            Should.Core.Assertions.Assert.False(actual == expected);
            Should.Core.Assertions.Assert.Equal(expected, actual, StringComparer.CurrentCultureIgnoreCase);
            Should.Core.Assertions.Assert.NotEqual(expected, actual, StringComparer.CurrentCulture);
        }

        [Fact]
        public void ValuesNotEqual()
        {
            Should.Core.Assertions.Assert.NotEqual("bob", "jim");
        }
    }
}