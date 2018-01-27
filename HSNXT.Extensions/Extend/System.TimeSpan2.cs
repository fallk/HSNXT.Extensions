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
    public static partial class Extensions
    {
        /// <summary>
        ///     Returns the given Double value as day.
        /// </summary>
        /// <param name="value">The Double value.</param>
        /// <returns>Returns the given Double value as days.</returns>
        [Pure]
        [PublicAPI]
        public static TimeSpan ToDays( this Double value )
            => TimeSpan.FromDays( value );

        /// <summary>
        ///     Returns the given Double value as hours.
        /// </summary>
        /// <param name="value">The Double value.</param>
        /// <returns>Returns the given Double value as hours.</returns>
        [Pure]
        [PublicAPI]
        public static TimeSpan ToHours( this Double value )
            => TimeSpan.FromHours( value );

        /// <summary>
        ///     Returns the given Double value as milliseconds.
        /// </summary>
        /// <param name="value">The Double value.</param>
        /// <returns>Returns the given Double value as milliseconds.</returns>
        [Pure]
        [PublicAPI]
        public static TimeSpan ToMilliseconds( this Double value )
            => TimeSpan.FromMilliseconds( value );

        /// <summary>
        ///     Returns the given Double value as minutes.
        /// </summary>
        /// <param name="value">The Double value.</param>
        /// <returns>Returns the given Double value as minutes.</returns>
        [Pure]
        [PublicAPI]
        public static TimeSpan ToMinutes( this Double value )
            => TimeSpan.FromMinutes( value );

        /// <summary>
        ///     Returns the given Double value as seconds.
        /// </summary>
        /// <param name="value">The Double value.</param>
        /// <returns>Returns the given Double value as seconds.</returns>
        [Pure]
        [PublicAPI]
        public static TimeSpan ToSeconds( this Double value )
            => TimeSpan.FromSeconds( value );

        /// <summary>
        ///     Returns a <see cref="TimeSpan" /> that represents a specified number of days, where the specification is accurate
        ///     to the nearest millisecond.
        /// </summary>
        /// <exception cref="OverflowException">
        ///     value is less than <see cref="TimeSpan.MinValue" /> or greater than <see cref="TimeSpan.MaxValue" />.
        /// </exception>
        /// <param name="value">A number of days.</param>
        /// <returns>Returns a <see cref="TimeSpan" /> representing the given value.</returns>
        [Pure]
        [PublicAPI]
        public static TimeSpan ToDays( this Int16 value )
            => TimeSpan.FromDays( value );

        /// <summary>
        ///     Returns a <see cref="TimeSpan" /> that represents a specified number of hours, where  the specification is accurate
        ///     to the nearest millisecond.
        /// </summary>
        /// <exception cref="OverflowException">
        ///     value is less than <see cref="TimeSpan.MinValue" /> or greater than <see cref="TimeSpan.MaxValue" />.
        /// </exception>
        /// <param name="value">A number of hours.</param>
        /// <returns>Returns a <see cref="TimeSpan" /> representing the given value.</returns>
        [Pure]
        [PublicAPI]
        public static TimeSpan ToHours( this Int16 value )
            => TimeSpan.FromHours( value );

        /// <summary>
        ///     Returns a <see cref="TimeSpan" /> that represents a specified number of milliseconds, where  the specification is
        ///     accurate
        ///     to the nearest millisecond.
        /// </summary>
        /// <exception cref="OverflowException">
        ///     value is less than <see cref="TimeSpan.MinValue" /> or greater than <see cref="TimeSpan.MaxValue" />.
        /// </exception>
        /// <param name="value">A number of milliseconds.</param>
        /// <returns>Returns a <see cref="TimeSpan" /> representing the given value.</returns>
        [Pure]
        [PublicAPI]
        public static TimeSpan ToMilliseconds( this Int16 value )
            => TimeSpan.FromMilliseconds( value );

        /// <summary>
        ///     Returns a <see cref="TimeSpan" /> that represents a specified number of minutes, where  the specification is
        ///     accurate
        ///     to the nearest millisecond.
        /// </summary>
        /// <exception cref="OverflowException">
        ///     value is less than <see cref="TimeSpan.MinValue" /> or greater than <see cref="TimeSpan.MaxValue" />.
        /// </exception>
        /// <param name="value">A number of minutes.</param>
        /// <returns>Returns a <see cref="TimeSpan" /> representing the given value.</returns>
        [Pure]
        [PublicAPI]
        public static TimeSpan ToMinutes( this Int16 value )
            => TimeSpan.FromMinutes( value );

        /// <summary>
        ///     Returns a <see cref="TimeSpan" /> that represents a specified number of seconds, where  the specification is
        ///     accurate
        ///     to the nearest millisecond.
        /// </summary>
        /// <exception cref="OverflowException">
        ///     value is less than <see cref="TimeSpan.MinValue" /> or greater than <see cref="TimeSpan.MaxValue" />.
        /// </exception>
        /// <param name="value">A number of seconds.</param>
        /// <returns>Returns a <see cref="TimeSpan" /> representing the given value.</returns>
        [Pure]
        [PublicAPI]
        public static TimeSpan ToSeconds( this Int16 value )
            => TimeSpan.FromSeconds( value );

        /// <summary>
        ///     Returns a <see cref="TimeSpan" /> that represents a specified number of days, where the specification is accurate
        ///     to the nearest millisecond.
        /// </summary>
        /// <exception cref="OverflowException">
        ///     value is less than <see cref="TimeSpan.MinValue" /> or greater than <see cref="TimeSpan.MaxValue" />.
        /// </exception>
        /// <param name="value">A number of days.</param>
        /// <returns>Returns a <see cref="TimeSpan" /> representing the given value.</returns>
        [Pure]
        [PublicAPI]
        public static TimeSpan ToDays( this Int32 value )
            => TimeSpan.FromDays( value );

        /// <summary>
        ///     Returns a <see cref="TimeSpan" /> that represents a specified number of hours, where  the specification is accurate
        ///     to the nearest millisecond.
        /// </summary>
        /// <exception cref="OverflowException">
        ///     value is less than <see cref="TimeSpan.MinValue" /> or greater than <see cref="TimeSpan.MaxValue" />.
        /// </exception>
        /// <param name="value">A number of hours.</param>
        /// <returns>Returns a <see cref="TimeSpan" /> representing the given value.</returns>
        [Pure]
        [PublicAPI]
        public static TimeSpan ToHours( this Int32 value )
            => TimeSpan.FromHours( value );

        /// <summary>
        ///     Returns a <see cref="TimeSpan" /> that represents a specified number of milliseconds, where  the specification is
        ///     accurate
        ///     to the nearest millisecond.
        /// </summary>
        /// <exception cref="OverflowException">
        ///     value is less than <see cref="TimeSpan.MinValue" /> or greater than <see cref="TimeSpan.MaxValue" />.
        /// </exception>
        /// <param name="value">A number of milliseconds.</param>
        /// <returns>Returns a <see cref="TimeSpan" /> representing the given value.</returns>
        [Pure]
        [PublicAPI]
        public static TimeSpan ToMilliseconds( this Int32 value )
            => TimeSpan.FromMilliseconds( value );

        /// <summary>
        ///     Returns a <see cref="TimeSpan" /> that represents a specified number of minutes, where  the specification is
        ///     accurate
        ///     to the nearest millisecond.
        /// </summary>
        /// <exception cref="OverflowException">
        ///     value is less than <see cref="TimeSpan.MinValue" /> or greater than <see cref="TimeSpan.MaxValue" />.
        /// </exception>
        /// <param name="value">A number of minutes.</param>
        /// <returns>Returns a <see cref="TimeSpan" /> representing the given value.</returns>
        [Pure]
        [PublicAPI]
        public static TimeSpan ToMinutes( this Int32 value )
            => TimeSpan.FromMinutes( value );

        /// <summary>
        ///     Returns a <see cref="TimeSpan" /> that represents a specified number of seconds, where  the specification is
        ///     accurate
        ///     to the nearest millisecond.
        /// </summary>
        /// <exception cref="OverflowException">
        ///     value is less than <see cref="TimeSpan.MinValue" /> or greater than <see cref="TimeSpan.MaxValue" />.
        /// </exception>
        /// <param name="value">A number of seconds.</param>
        /// <returns>Returns a <see cref="TimeSpan" /> representing the given value.</returns>
        [Pure]
        [PublicAPI]
        public static TimeSpan ToSeconds( this Int32 value )
            => TimeSpan.FromSeconds( value );

        /// <summary>
        ///     Returns a <see cref="TimeSpan" /> that represents a specified number of days, where the specification is accurate
        ///     to the nearest millisecond.
        /// </summary>
        /// <exception cref="OverflowException">
        ///     value is less than <see cref="TimeSpan.MinValue" /> or greater than <see cref="TimeSpan.MaxValue" />.
        /// </exception>
        /// <param name="value">A number of days.</param>
        /// <returns>Returns a <see cref="TimeSpan" /> representing the given value.</returns>
        [Pure]
        [PublicAPI]
        public static TimeSpan ToDays( this Int64 value )
            => TimeSpan.FromDays( value );

        /// <summary>
        ///     Returns a <see cref="TimeSpan" /> that represents a specified number of hours, where  the specification is accurate
        ///     to the nearest millisecond.
        /// </summary>
        /// <exception cref="OverflowException">
        ///     value is less than <see cref="TimeSpan.MinValue" /> or greater than <see cref="TimeSpan.MaxValue" />.
        /// </exception>
        /// <param name="value">A number of hours.</param>
        /// <returns>Returns a <see cref="TimeSpan" /> representing the given value.</returns>
        [Pure]
        [PublicAPI]
        public static TimeSpan ToHours( this Int64 value )
            => TimeSpan.FromHours( value );

        /// <summary>
        ///     Returns a <see cref="TimeSpan" /> that represents a specified number of milliseconds, where  the specification is
        ///     accurate
        ///     to the nearest millisecond.
        /// </summary>
        /// <exception cref="OverflowException">
        ///     value is less than <see cref="TimeSpan.MinValue" /> or greater than <see cref="TimeSpan.MaxValue" />.
        /// </exception>
        /// <param name="value">A number of milliseconds.</param>
        /// <returns>Returns a <see cref="TimeSpan" /> representing the given value.</returns>
        [Pure]
        [PublicAPI]
        public static TimeSpan ToMilliseconds( this Int64 value )
            => TimeSpan.FromMilliseconds( value );

        /// <summary>
        ///     Returns a <see cref="TimeSpan" /> that represents a specified number of minutes, where  the specification is
        ///     accurate
        ///     to the nearest millisecond.
        /// </summary>
        /// <exception cref="OverflowException">
        ///     value is less than <see cref="TimeSpan.MinValue" /> or greater than <see cref="TimeSpan.MaxValue" />.
        /// </exception>
        /// <param name="value">A number of minutes.</param>
        /// <returns>Returns a <see cref="TimeSpan" /> representing the given value.</returns>
        [Pure]
        [PublicAPI]
        public static TimeSpan ToMinutes( this Int64 value )
            => TimeSpan.FromMinutes( value );

        /// <summary>
        ///     Returns a <see cref="TimeSpan" /> that represents a specified number of seconds, where  the specification is
        ///     accurate
        ///     to the nearest millisecond.
        /// </summary>
        /// <exception cref="OverflowException">
        ///     value is less than <see cref="TimeSpan.MinValue" /> or greater than <see cref="TimeSpan.MaxValue" />.
        /// </exception>
        /// <param name="value">A number of seconds.</param>
        /// <returns>Returns a <see cref="TimeSpan" /> representing the given value.</returns>
        [Pure]
        [PublicAPI]
        public static TimeSpan ToSeconds( this Int64 value )
            => TimeSpan.FromSeconds( value );
    }
}