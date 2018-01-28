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
        public void ToMinutesTest()
        {
            var value = Extensions.GetRandomInt32( 1, 100 );

            var expected = TimeSpan.FromMinutes( value );
            var actual = ( (Int16) value ).ToMinutes();
            Assert.Equal( expected, actual );
        }
    }
}