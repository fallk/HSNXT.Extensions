#region Usings
using HSNXT;

using System;
using Xunit;

#endregion

namespace Extend.Testing
{
    public partial class Int16ExTest
    {
        [Fact]
        public void ToSecondsTest()
        {
            var value = Extensions.GetRandomInt32( 1, 100 );

            var expected = TimeSpan.FromSeconds( value );
            var actual = ( (Int16) value ).ToSeconds();
            Assert.Equal( expected, actual );
        }
    }
}