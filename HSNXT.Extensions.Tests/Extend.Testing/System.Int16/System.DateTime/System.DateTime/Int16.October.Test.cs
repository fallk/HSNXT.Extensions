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
        public void OctoberTest()
        {
            var expected = new DateTime( 2000, 10, 10 );
            var actual = Extensions.October( 10, 2000 );
            Assert.Equal( expected, actual );
        }
    }
}