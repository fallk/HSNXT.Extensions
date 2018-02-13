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
        public void DecemberTest()
        {
            var expected = new DateTime(2000, 12, 10);
            var actual = Extensions.December(10, 2000);
            Assert.Equal(expected, actual);
        }
    }
}