#region Usings
using HSNXT;

using System;
using Xunit;

#endregion

namespace Extend.Testing
{
    public partial class DateTimeExTest
    {
        [Fact]
        public void LastDayOfWeekTest()
        {
            var dateTime = new DateTime( 2014, 3, 30 );
            var actual = dateTime.LastDayOfWeek2();

            Assert.Equal( dateTime, actual );

            dateTime = new DateTime( 2014, 3, 28 );
            actual = dateTime.LastDayOfWeek2();

            Assert.Equal( new DateTime( 2014, 3, 30 ), actual );
        }
    }
}