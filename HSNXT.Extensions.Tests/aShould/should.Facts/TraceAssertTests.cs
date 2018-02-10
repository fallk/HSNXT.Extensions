using System;
using System.Diagnostics;
using Xunit;
using Xunit.Sdk;
using Assert = erichexter.Should.Core.Assertions.Assert;

namespace erichexter.Should.Facts.Core
{
    public class TraceAssertTests
    {
        [Fact]
        public void TraceAssertFailureWithFullDetails()
        {
            TraceAssertException ex = Should.Core.Assertions.Assert.Throws<TraceAssertException>(() => Trace.Assert(false, "message", "detailed message"));

            Should.Core.Assertions.Assert.Equal("message", ex.AssertMessage);
            Should.Core.Assertions.Assert.Equal("detailed message", ex.AssertDetailedMessage);
            Should.Core.Assertions.Assert.Equal("Debug.Assert() Failure : message" + Environment.NewLine + "Detailed Message:" + Environment.NewLine + "detailed message", ex.Message);
        }

        [Fact]
        public void TraceAssertFailureWithNoDetailedMessage()
        {
            TraceAssertException ex = Should.Core.Assertions.Assert.Throws<TraceAssertException>(() => Trace.Assert(false, "message"));

            Should.Core.Assertions.Assert.Equal("message", ex.AssertMessage);
            Should.Core.Assertions.Assert.Equal("", ex.AssertDetailedMessage);
            Should.Core.Assertions.Assert.Equal("Debug.Assert() Failure : message", ex.Message);
        }

        [Fact]
        public void TraceAssertFailureWithNoMessage()
        {
            TraceAssertException ex = Should.Core.Assertions.Assert.Throws<TraceAssertException>(() => Trace.Assert(false));

            Should.Core.Assertions.Assert.Equal("", ex.AssertMessage);
            Should.Core.Assertions.Assert.Equal("", ex.AssertDetailedMessage);
            Should.Core.Assertions.Assert.Equal("Debug.Assert() Failure", ex.Message);
        }
    }
}