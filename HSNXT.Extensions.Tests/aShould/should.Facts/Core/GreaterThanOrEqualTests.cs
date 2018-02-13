using System;
using erichexter.Should.Core.Exceptions;
using Xunit;
using Assert = erichexter.Should.Core.Assertions.Assert;

namespace erichexter.Should.Facts.Core
{
    public class GreaterThanOrEqualTests
    {
        DateTime today = DateTime.Today;
        DateTime tomorrow = DateTime.Today.AddDays(1);

        [Fact]
        public void One_is_greater_than_or_equal_to_one_should_pass()
        {
            Should.Core.Assertions.Assert.GreaterThanOrEqual(1, 1);
        }

        [Fact]
        public void Two_is_greater_than_or_equal_to_one_should_pass()
        {
            Should.Core.Assertions.Assert.GreaterThanOrEqual(2, 1);
        }

        [Fact]
        public void One_is_not_greater_than_or_equal_to_two_should_fail()
        {
            Should.Core.Assertions.Assert.Throws<GreaterThanOrEqualException>(() =>
                Should.Core.Assertions.Assert.GreaterThanOrEqual(1, 2));
        }

        [Fact]
        public void Today_is_greater_than_or_equal_to_today_should_pass()
        {
            Should.Core.Assertions.Assert.GreaterThanOrEqual(today, today);
        }

        [Fact]
        public void Tomorrow_is_greater_than_or_equal_to_today_should_pass()
        {
            Should.Core.Assertions.Assert.GreaterThanOrEqual(tomorrow, today);
        }

        [Fact]
        public void Today_is_not_greater_than_or_equal_to_tomorrow_should_fail()
        {
            Should.Core.Assertions.Assert.Throws<GreaterThanOrEqualException>(() =>
                Should.Core.Assertions.Assert.GreaterThanOrEqual(today, tomorrow));
        }

        [Fact]
        public void b_is_greater_than_or_equal_to_a_should_pass()
        {
            Should.Core.Assertions.Assert.GreaterThanOrEqual("b", "a");
        }

        [Fact]
        public void a_is_not_greater_than_or_equal_to_b_should_fail()
        {
            Should.Core.Assertions.Assert.Throws<GreaterThanOrEqualException>(() =>
                Should.Core.Assertions.Assert.GreaterThanOrEqual("a", "b"));
        }

        [Fact]
        public void a_is_greater_than_or_equal_to_A_using_case_sensitive_ordinal_comparer_should_pass()
        {
            Should.Core.Assertions.Assert.GreaterThanOrEqual("a", "A", StringComparer.Ordinal);
        }

        [Fact]
        public void a_is_greater_than_or_equal_to_A_using_case_insensitive_ordinal_comparer_should_pass()
        {
            Should.Core.Assertions.Assert.GreaterThanOrEqual("a", "A", StringComparer.OrdinalIgnoreCase);
        }
    }
}