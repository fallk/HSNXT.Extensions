#region Usings

using HSNXT;
using System;
using Xunit;

#endregion

namespace Extend.Testing
{
    public partial class Int32ExTest
    {
        [Fact]
        public void IsLeapYearTest()
        {
            var year = Extensions.GetRandomInt32(1990, 2015);

            var expected = DateTime.IsLeapYear(year);
            var actual = year.IsLeapYear();
            Assert.Equal(expected, actual);
        }
    }
}