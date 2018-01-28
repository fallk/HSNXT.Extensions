using System;
using System.Collections.Generic;
using System.Reflection;
using HSNXT.JetBrains.Annotations;
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
        public static int Age( this DateTime dateTime, [CanBeNull] DateTime? now = null )
        {
            var currentDate = now ?? DateTime.Now;
            if ( dateTime.Year == currentDate.Year )
                return 0;

            var a = ( currentDate.Year * 100 + currentDate.Month ) * 100 + currentDate.Day;
            var b = ( dateTime.Year * 100 + dateTime.Month ) * 100 + dateTime.Day;

            return ( a - b ) / 10000;
        }
        
        /// <summary>
        ///     Gets whether the given date-time values are the same day.
        /// </summary>
        /// <param name="dateTime">The first date-time value.</param>
        /// <param name="otherDateTime">The second date-time value.</param>
        /// <returns>Returns true if the given date-time values are the same day, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static bool IsSameDay( this DateTime dateTime, DateTime otherDateTime )
            => dateTime.Date == otherDateTime.Date;
        /// <summary>
        ///     Gets whether the given date-time values are the same month and year.
        /// </summary>
        /// <param name="dateTime">The first date-time value.</param>
        /// <param name="otherDateTime">The second date-time value.</param>
        /// <returns>Returns true if the given date-time values are the same month and year, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static bool IsSameMonthAndYear( this DateTime dateTime, DateTime otherDateTime )
            => dateTime.Year == otherDateTime.Year && dateTime.Month == otherDateTime.Month;
        /// <summary>
        ///     Checks if the time is equals to the given time.
        /// </summary>
        /// <param name="time">The time to check.</param>
        /// <param name="timeToCompare">The time to compare.</param>
        /// <returns>Returns true if the time is equals, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static bool IsTimeEquals( this DateTime time, DateTime timeToCompare )
            => time.TimeOfDay == timeToCompare.TimeOfDay;
        
        /// <summary>
        ///     Checks if the given day is a week day (MOnday - Friday).
        /// </summary>
        /// <param name="day">The day to check.</param>
        /// <returns>Returns true if the day is a week day, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static bool IsWeekdDay( this DateTime day )
            => day.DayOfWeek != DayOfWeek.Saturday
               && day.DayOfWeek != DayOfWeek.Sunday;
        
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
        public static Int32 Age2( this DateTime dateTime, [CanBeNull] DateTime? now = null )
        {
            var currentDate = now ?? DateTime.Now;
            if ( dateTime.Year == currentDate.Year )
                return 0;

            var a = ( currentDate.Year * 100 + currentDate.Month ) * 100 + currentDate.Day;
            var b = ( dateTime.Year * 100 + dateTime.Month ) * 100 + dateTime.Day;

            return ( a - b ) / 10000;
        }
        
        /// <summary>
        ///     Returns the last day of the current week.
        ///     Note: This method uses the given day as last day of the week.
        ///     Default is Sunday.
        /// </summary>
        /// <param name="week">The week to return the end of.</param>
        /// <param name="lastDayOfWeek">The last day of the week. Default is Sunday.</param>
        /// <returns>Returns the last day of the current week.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime EndOfWeek2( this DateTime week, DayOfWeek lastDayOfWeek = DayOfWeek.Sunday )
        {
            var currentDay = week.DayOfWeek;
            var daysLeft = lastDayOfWeek - currentDay;

            if ( daysLeft < 0 )
                daysLeft += 7;

            var endOfWeek = week.AddDays( daysLeft );

            return
                new DateTime( endOfWeek.Year, endOfWeek.Month, endOfWeek.Day ).AddDays( 1 )
                    .Subtract( 1.ToMilliseconds() );
        }
        
        /// <summary>
        ///     Returns the last moment ("23:59:59:999") of the year represented by the given date time.
        /// </summary>
        /// <param name="year">The year to return the end of.</param>
        /// <returns>Returns the last moment ("23:59:59:999") of the year represented by the given date time.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime EndOfYear2( this DateTime year )
            => new DateTime( year.Year, 12, 31, 23, 59, 59, 999 );
        
        /// <summary>
        ///     Gets the week-number of the given date-time value.
        /// </summary>
        /// <remarks>
        ///     This implementation is ISO 8601 compatible see: https://en.wikipedia.org/wiki/ISO_8601.
        ///     For .Net details see: http://stackoverflow.com/questions/11154673/get-the-correct-week-number-of-a-given-date
        ///     This presumes that weeks start with Monday.
        ///     Week 1 is the 1st week of the year with a Thursday in it.
        /// </remarks>
        /// <param name="dateTime">The date-time value.</param>
        /// <returns>Returns the number of the given week.</returns>
        [Pure]
        [PublicAPI]
        public static Int32 GetWeekOfYearInvariant( this DateTime dateTime )
        {
            // Seriously cheat.  If its Monday, Tuesday or Wednesday, then it'll 
            // be the same week# as whatever Thursday, Friday or Saturday are,
            // and we always get those right
            var day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek( dateTime );
            if ( day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday )
                dateTime = dateTime.AddDays( 3 );

            // Return the week of our adjusted day
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear( dateTime, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday );
        }
        
        /// <summary>
        ///     Returns the last day of the given week.
        /// </summary>
        /// <param name="week">The week to get the last day of.</param>
        /// <returns>Returns the last day of the given week.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime LastDayOfWeek2( this DateTime week )
            => week.DayOfWeek == DayOfWeek.Sunday
                ? new DateTime( week.Year, week.Month, week.Day )
                : new DateTime( week.Year, week.Month, week.Day ).AddDays( 7 - (Int32) week.DayOfWeek );
        
        /// <summary>
        ///     Returns the first day of the current week.
        ///     Note: This method uses the given day as first day of the week.
        ///     Default is Monday.
        /// </summary>
        /// <param name="week">The week to return the start of.</param>
        /// <param name="firstDayOfWeek">The first day of the week. Default is Monday.</param>
        /// <returns>Returns the first day of the current week.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime StartOfWeek2( this DateTime week, DayOfWeek firstDayOfWeek = DayOfWeek.Monday )
        {
            var currentDay = week.DayOfWeek;
            var daysPassed = currentDay - firstDayOfWeek;

            if ( daysPassed < 0 )
                daysPassed += 7;

            var startOfWeek = week.AddDays( -daysPassed );

            return new DateTime( startOfWeek.Year, startOfWeek.Month, startOfWeek.Day );
        }
    }
}
