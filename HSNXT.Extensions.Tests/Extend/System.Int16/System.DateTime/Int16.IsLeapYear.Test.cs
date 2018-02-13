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
        public void IsLeapYearTest()
        {
            var year = Extensions.GetRandomInt32(1990, 2015);

            var expected = DateTime.IsLeapYear(year);
            var actual = ((Int16) year).IsLeapYear();
            Assert.Equal(expected, actual);
        }
    }
}