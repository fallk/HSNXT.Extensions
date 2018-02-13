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
        public void AprilTest()
        {
            var expected = new DateTime(2000, 4, 10);
            var actual = Extensions.April(10, 2000);
            Assert.Equal(expected, actual);
        }
    }
}