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
        public void ToSecondsTest()
        {
            var value = Extensions.GetRandomInt32( 1, 100 );

            var expected = TimeSpan.FromSeconds( value );
            var actual = value.ToSeconds();

            actual
                .Should()
                .Be( expected );
        }
    }
}