using erichexter.Should.Core.Exceptions;
using Xunit;
using Assert = erichexter.Should.Core.Assertions.Assert;

namespace erichexter.Should.Facts.Core
{
    public class NotInRangeTests
    {
        public class RangeForDoubles
        {
            [Fact]
            public void DoubleNotWithinRange()
            {
                Should.Core.Assertions.Assert.NotInRange(1.50, .75, 1.25);
            }

            [Fact]
            public void DoubleWithinRange()
            {
                Should.Core.Assertions.Assert.Throws<NotInRangeException>(() =>
                    Should.Core.Assertions.Assert.NotInRange(1.0, .75, 1.25));
            }
        }

        public class RangeForInt
        {
            [Fact]
            public void IntNotWithinRange()
            {
                Should.Core.Assertions.Assert.NotInRange(1, 2, 3);
            }

            [Fact]
            public void IntWithinRange()
            {
                Should.Core.Assertions.Assert.Throws<NotInRangeException>(() =>
                    Should.Core.Assertions.Assert.NotInRange(2, 1, 3));
            }
        }

        public class RangeForStrings
        {
            [Fact]
            public void StringNotWithNotInRange()
            {
                Should.Core.Assertions.Assert.NotInRange("adam", "bob", "scott");
            }

            [Fact]
            public void StringWithNotInRange()
            {
                Should.Core.Assertions.Assert.Throws<NotInRangeException>(() =>
                    Should.Core.Assertions.Assert.NotInRange("bob", "adam", "scott"));
            }
        }
    }
}