using System;
using erichexter.Should.Core.Exceptions;
using Xunit;
using Assert = erichexter.Should.Core.Assertions.Assert;

namespace erichexter.Should.Facts.Core
{
    public class InRangeTests
    {
        public class RangeForDoubles
        {
            [Fact]
            public void DoubleNotWithinRange()
            {
                Should.Core.Assertions.Assert.Throws<InRangeException>(() =>
                    Should.Core.Assertions.Assert.InRange(1.50, .75, 1.25));
            }

            [Fact]
            public void DoubleValueWithinRange()
            {
                Should.Core.Assertions.Assert.InRange(1.0, .75, 1.25);
            }
        }

        public class RangeForInts
        {
            [Fact]
            public void IntNotWithinRangeWithZeroActual()
            {
                Should.Core.Assertions.Assert.Throws<InRangeException>(() =>
                    Should.Core.Assertions.Assert.InRange(0, 1, 2));
            }

            [Fact]
            public void IntNotWithinRangeWithZeroMinimum()
            {
                Should.Core.Assertions.Assert.Throws<InRangeException>(() =>
                    Should.Core.Assertions.Assert.InRange(2, 0, 1));
            }

            [Fact]
            public void IntValueWithinRange()
            {
                Should.Core.Assertions.Assert.InRange(2, 1, 3);
            }
        }

        public class RangeForStrings
        {
            [Fact]
            public void StringNotWithinRange()
            {
                Should.Core.Assertions.Assert.Throws<InRangeException>(() =>
                    Should.Core.Assertions.Assert.InRange("adam", "bob", "scott"));
            }

            [Fact]
            public void StringValueWithinRange()
            {
                Should.Core.Assertions.Assert.InRange("bob", "adam", "scott");
            }
        }

        public class RangeForWithNull
        {
            [Fact]
            public void When_comparing_null_within_range_Should_throw_InRangeException()
            {
                Should.Core.Assertions.Assert.Throws<InRangeException>(() =>
                    Should.Core.Assertions.Assert.InRange(null, "a", "z"));
            }

            [Fact]
            public void When_comparing_something_in_range_high_bounded_by_a_null_Should_throw_InRangeException()
            {
                Should.Core.Assertions.Assert.Throws<InRangeException>(() =>
                    Should.Core.Assertions.Assert.InRange("m", null, "z"));
            }

            [Fact]
            public void When_comparing_something_in_range_low_bounded_by_a_null_Should_pass()
            {
                Should.Core.Assertions.Assert.InRange("m", "a", null);
            }

            [Fact]
            public void When_comparing_null_in_range_bounded_by_nulls_Should_pass()
            {
                Should.Core.Assertions.Assert.InRange((string) null, null, null);
            }
        }

        public class RangeForComparables
        {
            [Fact]
            public void When_comparing_comparables_within_range_Should_pass()
            {
                Should.Core.Assertions.Assert.InRange(new ComparableObject(1), new ComparableObject(0),
                    new ComparableObject(2));
            }

            [Fact]
            public void When_comparing_comparable_to_derived_comparables_within_range_Should_pass()
            {
                Should.Core.Assertions.Assert.InRange(new ComparableObject(1), new DerivedComparableObject(0),
                    new DerivedComparableObject(2));
            }

            [Fact]
            public void When_comparing_derived_comparable_to_comparables_within_range_Should_pass()
            {
                Should.Core.Assertions.Assert.InRange(new DerivedComparableObject(1), new ComparableObject(0),
                    new ComparableObject(2));
            }

            [Fact]
            public void When_comparing_generic_comparables_within_range_Should_pass()
            {
                Should.Core.Assertions.Assert.InRange(new GenericComparableObject(1), new GenericComparableObject(0),
                    new GenericComparableObject(2));
            }

            [Fact]
            public void When_comparing_generic_comparable_to_derived_generic_comparables_within_range_Should_pass()
            {
                Should.Core.Assertions.Assert.InRange(new GenericComparableObject(1),
                    new DerivedGenericComparableObject(0), new DerivedGenericComparableObject(2));
            }

            [Fact]
            public void When_comparing_derived_generic_comparable_to_generic_comparables_within_range_Should_pass()
            {
                Should.Core.Assertions.Assert.InRange(new DerivedGenericComparableObject(1),
                    new GenericComparableObject(0), new GenericComparableObject(2));
            }

            [Fact]
            public void When_comparing_comparables_outside_range_Should_throw_InRangeException()
            {
                Should.Core.Assertions.Assert.Throws<InRangeException>(() =>
                    Should.Core.Assertions.Assert.InRange(new ComparableObject(3), new ComparableObject(0),
                        new ComparableObject(2)));
            }

            [Fact]
            public void When_comparing_generic_comparables_outside_range_Should_throw_InRangeException()
            {
                Should.Core.Assertions.Assert.Throws<InRangeException>(() =>
                    Should.Core.Assertions.Assert.InRange(new GenericComparableObject(3),
                        new GenericComparableObject(0), new GenericComparableObject(2)));
            }

            [Fact]
            public void When_comparing_comparable_derived_comparable_outside_range_Should_throw_InRangeException()
            {
                Should.Core.Assertions.Assert.Throws<InRangeException>(() =>
                    Should.Core.Assertions.Assert.InRange(new ComparableObject(3), new DerivedComparableObject(0),
                        new DerivedComparableObject(2)));
            }

            [Fact]
            public void
                When_comparing_generic_comparable_derived_generic_comparable_outside_range_Should_throw_InRangeException()
            {
                Should.Core.Assertions.Assert.Throws<InRangeException>(() =>
                    Should.Core.Assertions.Assert.InRange(new GenericComparableObject(3),
                        new DerivedGenericComparableObject(0), new DerivedGenericComparableObject(2)));
            }

            public class ComparableObject : IComparable
            {
                public int Value { get; private set; }

                public ComparableObject(int value)
                {
                    Value = value;
                }

                public int CompareTo(object obj)
                {
                    return Value.CompareTo(((ComparableObject) obj).Value);
                }
            }

            public class DerivedComparableObject : ComparableObject
            {
                public DerivedComparableObject(int value) : base(value)
                {
                }
            }

            public class GenericComparableObject : IComparable<GenericComparableObject>
            {
                public int Value { get; private set; }

                public GenericComparableObject(int value)
                {
                    Value = value;
                }

                public int CompareTo(GenericComparableObject other)
                {
                    return Value.CompareTo(other.Value);
                }
            }

            public class DerivedGenericComparableObject : GenericComparableObject
            {
                public DerivedGenericComparableObject(int value) : base(value)
                {
                }
            }
        }
    }
}