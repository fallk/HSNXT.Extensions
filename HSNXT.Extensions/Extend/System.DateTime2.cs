using System;
using HSNXT.JetBrains.Annotations;


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Returns the number of days in the specified month of the specified year.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <param name="month">The month.</param>
        /// <returns>
        ///     Returns the number of days of the specified month.
        ///     For example February (2), the return value is 28 or 29 depending upon whether is a leap year.
        /// </returns>
        [Pure]
        [PublicAPI]
        public static int DaysInMonth(this short year, short month)
            => DateTime.DaysInMonth(year, month);

        /// <summary>
        ///     Returns whether the given year is a leap year or not.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>Returns true if the year is a leap year, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static bool IsLeapYear(this short year)
            => DateTime.IsLeapYear(year);
    }
}