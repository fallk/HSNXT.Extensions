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
        public void SeptemberTest()
        {
            var expected = new DateTime( 2000, 9, 10 );
            var actual = Extensions.September( 10, 2000 );
            Assert.Equal( expected, actual );
        }
    }
}