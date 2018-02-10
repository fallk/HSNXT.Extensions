﻿using erichexter.Should.Core.Exceptions;
using Xunit;

namespace erichexter.Should.Facts
{
    public class DoubleAssertionExtension_Facts
    {
        [Fact]
        public void ShouldEqual_succeeds_when_numbers_are_within_tolerance()
        {
            double d = 100.0;
            d.ShouldEqual(100.1, 0.1);
        }

        [Fact]
        public void ShouldEqual_fails_when_numbers_are_outside_tolerance()
        {
            double d = 100.0;

            Assert.Throws<EqualException>(() =>
            {
                d.ShouldEqual(100.2, 0.1);
            });
        }

        [Fact]
        public void ShouldEqual_accepts_a_message_to_describe_failure()
        {
            double d = 1.0;

            var ex = Assert.Throws<EqualException>(() =>
            {
                d.ShouldEqual(2.0, 0, "custom failure message");
            });

            Assert.Contains(@"custom failure message", ex.Message);
        }

        [Fact]
        public void ShouldNotEqual_fails_when_numbers_are_within_tolerance()
        {
            double d = 100.0;

            Assert.Throws<NotEqualException>(() =>
            {
                d.ShouldNotEqual(100.1, 0.2);
            });
        }

        [Fact]
        public void ShouldNotEqual_succeeds_when_numbers_are_outside_tolerance()
        {
            double d = 100.0;
            d.ShouldNotEqual(100.2, 0.1);
        }

        [Fact]
        public void ShouldNotEqual_accepts_a_message_to_describe_failure()
        {
            double d = 1.0;

            var ex = Assert.Throws<NotEqualException>(() =>
            {
                d.ShouldNotEqual(1.0, 0, "custom failure message");
            });

            Assert.Contains(@"custom failure message", ex.Message);
        }
    }
}
