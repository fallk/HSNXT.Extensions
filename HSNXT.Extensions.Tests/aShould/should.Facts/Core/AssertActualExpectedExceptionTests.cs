using System;
using erichexter.Should.Core.Exceptions;
using Xunit;
using Assert = erichexter.Should.Core.Assertions.Assert;

namespace erichexter.Should.Facts.Core
{
    public class AssertActualExpectedExceptionTests
    {
        [Fact]
        public void ActualValueWrapsForMultiline()
        {
            string expectedMessage =
                "Message" + Environment.NewLine +
                "Position: First difference is at position 0" + Environment.NewLine +
                "Expected: expected" + Environment.NewLine +
                "Actual:   line 1" + Environment.NewLine +
                "          line 2";

            AssertActualExpectedException ex =
                new AssertActualExpectedException(
                    "expected",
                    "line 1" + Environment.NewLine + "line 2",
                    "Message");

            Should.Core.Assertions.Assert.Equal(expectedMessage, ex.Message);
        }

        [Fact]
        public void ArraysShowDifferencePoint()
        {
            int[] actualValue = new int[] { 1, 2, 3, 4, 5 };
            int[] expectedValue = new int[] { 1, 2, 5, 7, 9 };

            string expectedMessage =
                "Message" + Environment.NewLine +
                "Position: First difference is at position 2" + Environment.NewLine +
                "Expected: System.Int32[] { 1, 2, 5, 7, 9 }" + Environment.NewLine +
                "Actual:   System.Int32[] { 1, 2, 3, 4, 5 }";

            AssertActualExpectedException ex =
                new AssertActualExpectedException(expectedValue, actualValue, "Message");

            Should.Core.Assertions.Assert.Equal(expectedMessage, ex.Message);
        }

        [Fact]
        public void ExpectedAndActualAreUsedInMessage()
        {
            string expectedMessage =
                "Message" + Environment.NewLine +
                "Expected: 2" + Environment.NewLine +
                "Actual:   1";

            AssertActualExpectedException ex =
                new AssertActualExpectedException(2, 1, "Message");

            Should.Core.Assertions.Assert.Equal(expectedMessage, ex.Message);
        }

        [Fact]
        public void ExpectedValueWrapsForMultiline()
        {
            string expectedMessage =
                "Message" + Environment.NewLine +
                "Position: First difference is at position 0" + Environment.NewLine +
                "Expected: line 1" + Environment.NewLine +
                "          line 2" + Environment.NewLine +
                "Actual:   actual";

            AssertActualExpectedException ex =
                new AssertActualExpectedException(
                    "line 1" + Environment.NewLine + "line 2",
                    "actual",
                    "Message");

            Should.Core.Assertions.Assert.Equal(expectedMessage, ex.Message);
        }

        [Fact]
        public void OneStringAddsValueToEndOfTheOtherString()
        {
            string actualValue = "first test";
            string expectedValue = "first test 1";
            string expectedMessage =
                "Message" + Environment.NewLine +
                "Position: First difference is at position 10" + Environment.NewLine +
                "Expected: first test 1" + Environment.NewLine +
                "Actual:   first test";

            AssertActualExpectedException ex =
                new AssertActualExpectedException(expectedValue, actualValue, "Message");

            Should.Core.Assertions.Assert.Equal(expectedMessage, ex.Message);
        }

        [Fact]
        public void OneStringOneNullDoesNotShowDifferencePoint()
        {
            string actualValue = null;
            string expectedValue = "first test 1";
            string expectedMessage =
                "Message" + Environment.NewLine +
                "Expected: first test 1" + Environment.NewLine +
                "Actual:   (null)";

            AssertActualExpectedException ex =
                new AssertActualExpectedException(expectedValue, actualValue, "Message");

            Should.Core.Assertions.Assert.Equal(expectedMessage, ex.Message);
        }

        [Fact]
        public void PreservesExpectedAndActual()
        {
            AssertActualExpectedException ex =
                new AssertActualExpectedException(2, 1, null);

            Should.Core.Assertions.Assert.Equal("1", ex.Actual);
            Should.Core.Assertions.Assert.Equal("2", ex.Expected);
            Should.Core.Assertions.Assert.Null(ex.UserMessage);
        }

        [Fact]
        public void StringsDifferInTheMiddle()
        {
            string actualValue = "first test";
            string expectedValue = "first failure";
            string expectedMessage =
                "Message" + Environment.NewLine +
                "Position: First difference is at position 6" + Environment.NewLine +
                "Expected: first failure" + Environment.NewLine +
                "Actual:   first test";

            AssertActualExpectedException ex =
                new AssertActualExpectedException(expectedValue, actualValue, "Message");

            Should.Core.Assertions.Assert.Equal(expectedMessage, ex.Message);
        }

        [Fact]
        public void SameVisibleValueDifferentTypes()
        {
            string expectedMessage =
                "Message" + Environment.NewLine +
                "Expected: 1 (System.String)" + Environment.NewLine +
                "Actual:   1 (System.Int32)";

            AssertActualExpectedException ex =
                new AssertActualExpectedException("1", 1, "Message");

            Should.Core.Assertions.Assert.Equal(expectedMessage, ex.Message);
        }

        [Fact]
        public void DifferentVisibleValueDifferentTypes()
        {
            string expectedMessage =
                "Message" + Environment.NewLine +
                "Expected: 2" + Environment.NewLine +
                "Actual:   1";

            AssertActualExpectedException ex =
                new AssertActualExpectedException("2", 1, "Message");

            Should.Core.Assertions.Assert.Equal(expectedMessage, ex.Message);
        }
    }
}