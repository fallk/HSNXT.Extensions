#region Usings
using HSNXT;

using System;
using FluentAssertions;
using Xunit;

#endregion

namespace Extend.Testing
{
    public partial class Int32ExTest
    {
        [Fact]
        public void ToMillisecondsTest()
        {
            var value = Extensions.GetRandomInt32( 1, 100 );

            var expected = TimeSpan.FromMilliseconds( value );
            var actual = value.ToMilliseconds();

            actual
                .Should()
                .Be( expected );
        }
    }
}