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
        ///     Converts the DateTime value to a full date time string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The format info can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="formatInfo">The date time format info.</param>
        /// <returns>The given value converted to a full date time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static string ToFullDateTimeString( this DateTime dateTime, [NotNull] DateTimeFormatInfo formatInfo )
        {
            formatInfo.ThrowIfNull( nameof(formatInfo) );

            return dateTime.ToString( "F", formatInfo );
        }

        /// <summary>
        ///     Converts the DateTime value to a long date short time string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The format info can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="formatInfo">The date time format info.</param>
        /// <returns>The given value converted to a long date short time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static string ToLongDateShortTimeString( this DateTime dateTime, [NotNull] DateTimeFormatInfo formatInfo )
        {
            formatInfo.ThrowIfNull( nameof(formatInfo) );

            return dateTime.ToString( "f", formatInfo );
        }

        /// <summary>
        ///     Converts the DateTime value to a long date time string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The format info can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="formatInfo">The date time format info.</param>
        /// <returns>The given value converted to a long date time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static string ToLongDateString( this DateTime dateTime, [NotNull] DateTimeFormatInfo formatInfo )
        {
            formatInfo.ThrowIfNull( nameof(formatInfo) );

            return dateTime.ToString( "D", formatInfo );
        }

        /// <summary>
        ///     Converts the DateTime value to a long time string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The format info can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="formatInfo">The date time format info.</param>
        /// <returns>The given value converted to a long time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static string ToLongTimeString( this DateTime dateTime, [NotNull] DateTimeFormatInfo formatInfo )
        {
            formatInfo.ThrowIfNull( nameof(formatInfo) );

            return dateTime.ToString( "T", formatInfo );
        }

        /// <summary>
        ///     Converts the DateTime value to a month day string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The format info can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="formatInfo">The date time format info.</param>
        /// <returns>The given value converted to a month day string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static string ToMonthDayString( this DateTime dateTime, [NotNull] DateTimeFormatInfo formatInfo )
        {
            formatInfo.ThrowIfNull( nameof(formatInfo) );

            return dateTime.ToString( "m", formatInfo );
        }

        /// <summary>
        ///     Converts the DateTime value to a month string.
        /// </summary>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <returns>The given value converted to a year month string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static string ToMonthString( this DateTime dateTime )
            => dateTime.ToString( "MMMM", DateTimeFormatInfo.CurrentInfo );

        /// <summary>
        ///     Converts the DateTime value to a month string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The format info can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="formatInfo">The date time format info.</param>
        /// <returns>The given value converted to year month string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static string ToMonthString( this DateTime dateTime, [NotNull] DateTimeFormatInfo formatInfo )
        {
            formatInfo.ThrowIfNull( nameof(formatInfo) );

            return dateTime.ToString( "MMMM", formatInfo );
        }

        /// <summary>
        ///     Converts the DateTime value to a month string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The culture can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="culture">The culture.</param>
        /// <returns>The given value converted to a year month string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static string ToMonthString( this DateTime dateTime, [NotNull] CultureInfo culture )
        {
            culture.ThrowIfNull( nameof(culture) );

            return dateTime.ToString( "MMMM", culture );
        }

        /// <summary>
        ///     Converts the DateTime value to a short date long time string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The format info can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="formatInfo">The date time format info.</param>
        /// <returns>The given value converted to a short date long time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static string ToShortDateLongTimeString( this DateTime dateTime, [NotNull] DateTimeFormatInfo formatInfo )
        {
            formatInfo.ThrowIfNull( nameof(formatInfo) );

            return dateTime.ToString( "G", formatInfo );
        }

        /// <summary>
        ///     Converts the DateTime value to a short date string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The format info can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="formatInfo">The date time format info.</param>
        /// <returns>The given value converted to a short date string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static string ToShortDateString( this DateTime dateTime, [NotNull] DateTimeFormatInfo formatInfo )
        {
            dateTime.ThrowIfNull( nameof(dateTime) );
            formatInfo.ThrowIfNull( nameof(formatInfo) );

            return dateTime.ToString( "d", formatInfo );
        }

        /// <summary>
        ///     Converts the DateTime value to a short date time string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The format info can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="formatInfo">The date time format info.</param>
        /// <returns>The given value converted to a short date time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static string ToShortDateTimeString( this DateTime dateTime, [NotNull] DateTimeFormatInfo formatInfo )
        {
            formatInfo.ThrowIfNull( nameof(formatInfo) );

            return dateTime.ToString( "g", formatInfo );
        }

        /// <summary>
        ///     Converts the DateTime value to a short time string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The format info can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="formatInfo">The date time format info.</param>
        /// <returns>The given value converted to a short time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static string ToShortTimeString( this DateTime dateTime, [NotNull] DateTimeFormatInfo formatInfo )
        {
            formatInfo.ThrowIfNull( nameof(formatInfo) );

            return dateTime.ToString( "t", formatInfo );
        }

        /// <summary>
        ///     Converts the DateTime value to a sortable date time string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The format info can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="formatInfo">The date time format info.</param>
        /// <returns>The given value converted to a sortable date time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static string ToSortableDateTimeString( this DateTime dateTime, [NotNull] DateTimeFormatInfo formatInfo )
        {
            formatInfo.ThrowIfNull( nameof(formatInfo) );

            return dateTime.ToString( "s", formatInfo );
        }

        /// <summary>
        ///     Converts the DateTime value to a universal sortable date time string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The format info can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="formatInfo">The date time format info.</param>
        /// <returns>The given value converted to a universal sortable date time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static string ToUniversalSortableDateTimeString( this DateTime dateTime, [NotNull] DateTimeFormatInfo formatInfo )
        {
            formatInfo.ThrowIfNull( nameof(formatInfo) );

            return dateTime.ToString( "u", formatInfo );
        }

        /// <summary>
        ///     Converts the DateTime value to a universal sortable long date time string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The format info can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="formatInfo">The date time format info.</param>
        /// <returns>The given value converted to a universal sortable long date time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static string ToUniversalSortableLongDateTimeString( this DateTime dateTime, [NotNull] DateTimeFormatInfo formatInfo )
        {
            formatInfo.ThrowIfNull( nameof(formatInfo) );

            return dateTime.ToString( "U", formatInfo );
        }

        /// <summary>
        ///     Converts the DateTime value to year month string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The format info can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="formatInfo">The date time format info.</param>
        /// <returns>The given value converted to year month string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static string ToYearMonthString( this DateTime dateTime, [NotNull] DateTimeFormatInfo formatInfo )
        {
            formatInfo.ThrowIfNull( nameof(formatInfo) );

            return dateTime.ToString( "y", formatInfo );
        }
    }
}