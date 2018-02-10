using System;
using erichexter.Should.Core.Exceptions;
using Xunit;
using Assert = erichexter.Should.Core.Assertions.Assert;

namespace erichexter.Should.Facts.Core
{
    public class DoesNotThrowTests
    {
        [Fact]
        public void CorrectExceptionType()
        {
            DoesNotThrowException ex =
                Should.Core.Assertions.Assert.Throws<DoesNotThrowException>(
                    () => Should.Core.Assertions.Assert.DoesNotThrow(
                        () => { throw new NotImplementedException("Exception Message"); }));

            Should.Core.Assertions.Assert.Equal("Assert.DoesNotThrow() failure", ex.UserMessage);
            Should.Core.Assertions.Assert.Equal("(No exception)", ex.Expected);
            Should.Core.Assertions.Assert.Equal("System.NotImplementedException: Exception Message", ex.Actual);
        }

        [Fact]
        public void PassingTest()
        {
            Should.Core.Assertions.Assert.DoesNotThrow(() => { });
        }
    }
}