using System;
using System.Collections.Generic;
using System.Reflection;
using JetBrains.Annotations;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Text;
using System.Globalization;
using System.Collections;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Collections.Concurrent;
using HSNXT.Internal;


namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="DateTime" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Calculates the difference between the year of the current and the given date time.
        /// </summary>
        /// <remarks>
        ///     <paramref name="now" /> can be smaller than <paramref name="dateTime" />, which results in negative results.
        ///     Source from: http://stackoverflow.com/questions/9/how-do-i-calculate-someones-age-in-c
        /// </remarks>
        /// <param name="dateTime">The date time value.</param>
        /// <param name="now">The 'current' date used to calculate the age, or null to use <see cref="DateTime.Now" />.</param>
        /// <returns>The difference between the year of the current and the given date time.</returns>
        [Pure]
        [PublicAPI]
        public static Int32 Age( this DateTime dateTime, [CanBeNull] DateTime? now = null )
        {
            var currentDate = now ?? DateTime.Now;
            if ( dateTime.Year == currentDate.Year )
                return 0;

            var a = ( currentDate.Year * 100 + currentDate.Month ) * 100 + currentDate.Day;
            var b = ( dateTime.Year * 100 + dateTime.Month ) * 100 + dateTime.Day;

            return ( a - b ) / 10000;
        }
    }
}



namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="DateTime" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Gets whether the given date-time values are the same day.
        /// </summary>
        /// <param name="dateTime">The first date-time value.</param>
        /// <param name="otherDateTime">The second date-time value.</param>
        /// <returns>Returns true if the given date-time values are the same day, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean IsSameDay( this DateTime dateTime, DateTime otherDateTime )
            => dateTime.Date == otherDateTime.Date;
    }
}


namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="DateTime" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Gets whether the given date-time values are the same month and year.
        /// </summary>
        /// <param name="dateTime">The first date-time value.</param>
        /// <param name="otherDateTime">The second date-time value.</param>
        /// <returns>Returns true if the given date-time values are the same month and year, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean IsSameMonthAndYear( this DateTime dateTime, DateTime otherDateTime )
            => dateTime.Year == otherDateTime.Year && dateTime.Month == otherDateTime.Month;
    }
}


namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="DateTime" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Checks if the time is equals to the given time.
        /// </summary>
        /// <param name="time">The time to check.</param>
        /// <param name="timeToCompare">The time to compare.</param>
        /// <returns>Returns true if the time is equals, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean IsTimeEquals( this DateTime time, DateTime timeToCompare )
            => time.TimeOfDay == timeToCompare.TimeOfDay;
    }
}




namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="DateTime" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Checks if the given day is a week day (MOnday - Friday).
        /// </summary>
        /// <param name="day">The day to check.</param>
        /// <returns>Returns true if the day is a week day, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean IsWeekdDay( this DateTime day )
            => day.DayOfWeek != DayOfWeek.Saturday
               && day.DayOfWeek != DayOfWeek.Sunday;
    }
}




namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="DateTime" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Returns the first day of the next month, based on the given date-time value.
        /// </summary>
        /// <param name="dateTime">The date-time value.</param>
        /// <returns>Returns the first day of the next month, based on the given date-time value.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime NextMonthStart( this DateTime dateTime )
            => dateTime.AddMonths( 1 )
                       .StartOfMonth();
    }
}


namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="DateTime" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Gets the next week day, based on the given day.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <returns>Returns the next week day (can be <paramref name="day" /> if the given day is a week day).</returns>
        [Pure]
        [PublicAPI]
        public static DateTime NextWeekDay( this DateTime day )
        {
            while ( day.IsWeekendDay() )
                day = day.Add( 1.ToDays() );
            return day;
        }
    }
}
