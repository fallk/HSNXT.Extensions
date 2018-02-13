using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using erichexter.Should.Fluent;

namespace HSNXT.PGK.Extensions.Tests
{
    [TestClass]
    public class LongExtensionsTest
    {
        [TestMethod]
        public void TestIsEven()
        {
            /* positive testing */
            long testValue = 4;
            Assert.IsTrue(testValue.IsEven());
            /* negative testing */
            testValue = 3;
            Assert.IsFalse(testValue.IsEven());
        }

        [TestMethod]
        public void TestIsOdd()
        {
            /* positive testing */
            long testValue = 3;
            Assert.IsTrue(testValue.IsOdd());
            /* negative testing */
            testValue = 4;
            Assert.IsFalse(testValue.IsOdd());
        }

        [TestMethod]
        public void TestInRange()
        {
            // Arrange
            var value = 5;
            var defaultValue = 9;
            // Act
            var no = value.InRange(6, 10);
            var yes = value.InRange(0, 10);
            var result = value.InRange(6, 10, defaultValue);
            // Assert
            no.Should().Be.False();
            yes.Should().Be.True();
            result.Should().Equal(defaultValue);
        }

        [TestMethod]
        public void TestToOrdinal()
        {
            string s3000001 = "3000001st";
            long i3000001 = 3000001;

            Assert.AreEqual(s3000001, i3000001.ToOrdinal());
        }

        [TestMethod]
        public void TestDays()
        {
            long val = 4L;
            TimeSpan span1 = val.Days();
            TimeSpan span2 = TimeSpan.FromDays(val);

            span1.Should().Equal(span2);
        }

        [TestMethod]
        public void TestHours()
        {
            long val = 20L;
            TimeSpan span1 = val.Hours();
            TimeSpan span2 = TimeSpan.FromHours(val);

            span1.Should().Equal(span2);
        }

        [TestMethod]
        public void TestMilliseconds()
        {
            long val = 91313L;
            TimeSpan span1 = val.Milliseconds();
            TimeSpan span2 = TimeSpan.FromMilliseconds(val);

            span1.Should().Equal(span2);
        }

        [TestMethod]
        public void TestMinutes()
        {
            long val = 678L;
            TimeSpan span1 = val.Minutes();
            TimeSpan span2 = TimeSpan.FromMinutes(val);

            span1.Should().Equal(span2);
        }

        [TestMethod]
        public void TestSeconds()
        {
            long val = 4182L;
            TimeSpan span1 = val.Seconds();
            TimeSpan span2 = TimeSpan.FromSeconds(val);

            span1.Should().Equal(span2);
        }

        [TestMethod]
        public void TestTicks()
        {
            long val = -660394L;
            TimeSpan span1 = val.Ticks();
            TimeSpan span2 = TimeSpan.FromTicks(val);

            span1.Should().Equal(span2);
        }
    }
}