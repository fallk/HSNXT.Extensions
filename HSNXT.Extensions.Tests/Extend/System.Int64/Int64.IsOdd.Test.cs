#region Usings
using HSNXT;

using System;
using FluentAssertions;
using Xunit;

#endregion

namespace Extend.Testing
{
    public partial class Int64ExTest
    {
        [Fact]
        public void IsOdd0Test()
        {
            const Int64 value = 0;

            var actual = value.IsOdd();
            actual.Should()
                  .BeFalse();
        }

        [Fact]
        public void IsOddTest()
        {
            var value = Extensions.GetRandomInt32();

            var expected = value % 2 != 0;
            var actual = Extensions.IsOdd( value );
            Assert.Equal( expected, actual );
        }
    }
}