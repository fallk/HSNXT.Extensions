using System;
using erichexter.Should.Core.Exceptions;
using Xunit;
using Assert = erichexter.Should.Core.Assertions.Assert;

namespace erichexter.Should.Facts.Core
{
    public class LessThanTests
    {
        DateTime today = DateTime.Today;
        DateTime tomorrow = DateTime.Today.AddDays(1);

        [Fact]
        public void One_is_less_than_two_should_pass()
        {
            Should.Core.Assertions.Assert.LessThan(1, 2);
        }

        [Fact]
        public void Two_is_not_less_than_one_should_fail()
        {
            Should.Core.Assertions.Assert.Throws<LessThanException>(() => Should.Core.Assertions.Assert.LessThan(2, 1));
        }

        [Fact]
        public void Today_is_less_than_tomorrow_should_pass()
        {
            Should.Core.Assertions.Assert.LessThan(today, tomorrow);
        }

        [Fact]
        public void Tomorrow_is_not_less_than_today_should_fail()
        {
            Should.Core.Assertions.Assert.Throws<LessThanException>(() =>
                Should.Core.Assertions.Assert.LessThan(tomorrow, today));
        }

        [Fact]
        public void a_is_less_than_b_should_pass()
        {
            Should.Core.Assertions.Assert.LessThan("a", "b");
        }

        [Fact]
        public void b_is_not_less_than_a_should_fail()
        {
            Should.Core.Assertions.Assert.Throws<LessThanException>(() =>
                Should.Core.Assertions.Assert.LessThan("b", "a"));
        }

        [Fact]
        public void A_is_less_than_a_using_case_sensitive_ordinal_comparer_should_pass()
        {
            Should.Core.Assertions.Assert.LessThan("A", "a", StringComparer.Ordinal);
        }

        [Fact]
        public void A_is_not_less_than_a_using_case_insensitive_ordinal_comparer_should_fail()
        {
            Should.Core.Assertions.Assert.Throws<LessThanException>(() =>
                Should.Core.Assertions.Assert.LessThan("A", "a", StringComparer.OrdinalIgnoreCase));
        }
    }
}