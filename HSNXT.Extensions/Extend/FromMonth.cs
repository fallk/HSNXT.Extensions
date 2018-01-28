using System;
using HSNXT.JetBrains.Annotations;


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Returns a date-time representing the specified day in April
        ///     in the specified year.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>Return a date-time representing the specified day in April in the specified year.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime April( this short day, short year )
            => new DateTime( year, 4, day );

        /// <summary>
        ///     Returns a date-time representing the specified day in August
        ///     in the specified year.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>Return a date-time representing the specified day in August in the specified year.</returns>
        /// [Pure]
        /// [PublicAPI]
        public static DateTime August( this short day, short year )
            => new DateTime( year, 8, day );

        /// <summary>
        ///     Returns a date-time representing the specified day in December
        ///     in the specified year.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>Return a date-time representing the specified day in December in the specified year.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime December( this short day, short year )
            => new DateTime( year, 12, day );

        /// <summary>
        ///     Returns a date-time representing the specified day in February
        ///     in the specified year.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>Return a date-time representing the specified day in February in the specified year.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime February( this short day, short year )
            => new DateTime( year, 2, day );

        /// <summary>
        ///     Returns a date-time representing the specified day in January
        ///     in the specified year.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>Return a date-time representing the specified day in January in the specified year.</returns>
        /// [Pure]
        /// [PublicAPI]
        public static DateTime January( this short day, short year )
            => new DateTime( year, 1, day );

        /// <summary>
        ///     Returns a date-time representing the specified day in July
        ///     in the specified year.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>Return a date-time representing the specified day in July in the specified year.</returns>
        /// [Pure]
        /// [PublicAPI]
        public static DateTime July( this short day, short year )
            => new DateTime( year, 7, day );

        /// <summary>
        ///     Returns a date-time representing the specified day in June
        ///     in the specified year.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>Return a date-time representing the specified day in June in the specified year.</returns>
        /// [Pure]
        /// [PublicAPI]
        public static DateTime June( this short day, short year )
            => new DateTime( year, 6, day );

        /// <summary>
        ///     Returns a date-time representing the specified day in March
        ///     in the specified year.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>Return a date-time representing the specified day in March in the specified year.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime March( this short day, short year )
            => new DateTime( year, 3, day );

        /// <summary>
        ///     Returns a date-time representing the specified day in May
        ///     in the specified year.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>Return a date-time representing the specified day in May in the specified year.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime May( this short day, short year )
            => new DateTime( year, 5, day );

        /// <summary>
        ///     Returns a date-time representing the specified day in November
        ///     in the specified year.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>Return a date-time representing the specified day in November in the specified year.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime November( this short day, short year )
            => new DateTime( year, 11, day );

        /// <summary>
        ///     Returns a date-time representing the specified day in October
        ///     in the specified year.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>Return a date-time representing the specified day in October in the specified year.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime October( this short day, short year )
            => new DateTime( year, 10, day );

        /// <summary>
        ///     Returns a date-time representing the specified day in September
        ///     in the specified year.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>Return a date-time representing the specified day in September in the specified year.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime September( this short day, short year )
            => new DateTime( year, 9, day );
    }
}