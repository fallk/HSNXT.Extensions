using System;
using HSNXT.JetBrains.Annotations;


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
        public static TimeSpan ToDays(this double value)
            => TimeSpan.FromDays(value);

        /// <summary>
        ///     Returns the given Double value as hours.
        /// </summary>
        /// <param name="value">The Double value.</param>
        /// <returns>Returns the given Double value as hours.</returns>
        [Pure]
        [PublicAPI]
        public static TimeSpan ToHours(this double value)
            => TimeSpan.FromHours(value);

        /// <summary>
        ///     Returns the given Double value as milliseconds.
        /// </summary>
        /// <param name="value">The Double value.</param>
        /// <returns>Returns the given Double value as milliseconds.</returns>
        [Pure]
        [PublicAPI]
        public static TimeSpan ToMilliseconds(this double value)
            => TimeSpan.FromMilliseconds(value);

        /// <summary>
        ///     Returns the given Double value as minutes.
        /// </summary>
        /// <param name="value">The Double value.</param>
        /// <returns>Returns the given Double value as minutes.</returns>
        [Pure]
        [PublicAPI]
        public static TimeSpan ToMinutes(this double value)
            => TimeSpan.FromMinutes(value);

        /// <summary>
        ///     Returns the given Double value as seconds.
        /// </summary>
        /// <param name="value">The Double value.</param>
        /// <returns>Returns the given Double value as seconds.</returns>
        [Pure]
        [PublicAPI]
        public static TimeSpan ToSeconds(this double value)
            => TimeSpan.FromSeconds(value);

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
        public static TimeSpan ToDays(this short value)
            => TimeSpan.FromDays(value);

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
        public static TimeSpan ToHours(this short value)
            => TimeSpan.FromHours(value);

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
        public static TimeSpan ToMilliseconds(this short value)
            => TimeSpan.FromMilliseconds(value);

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
        public static TimeSpan ToMinutes(this short value)
            => TimeSpan.FromMinutes(value);

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
        public static TimeSpan ToSeconds(this short value)
            => TimeSpan.FromSeconds(value);

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
        public static TimeSpan ToDays(this int value)
            => TimeSpan.FromDays(value);

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
        public static TimeSpan ToHours(this int value)
            => TimeSpan.FromHours(value);

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
        public static TimeSpan ToMilliseconds(this int value)
            => TimeSpan.FromMilliseconds(value);

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
        public static TimeSpan ToMinutes(this int value)
            => TimeSpan.FromMinutes(value);

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
        public static TimeSpan ToSeconds(this int value)
            => TimeSpan.FromSeconds(value);

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
        public static TimeSpan ToDays(this long value)
            => TimeSpan.FromDays(value);

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
        public static TimeSpan ToHours(this long value)
            => TimeSpan.FromHours(value);

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
        public static TimeSpan ToMilliseconds(this long value)
            => TimeSpan.FromMilliseconds(value);

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
        public static TimeSpan ToMinutes(this long value)
            => TimeSpan.FromMinutes(value);

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
        public static TimeSpan ToSeconds(this long value)
            => TimeSpan.FromSeconds(value);
    }
}