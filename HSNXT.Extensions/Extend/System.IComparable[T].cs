using System;
using HSNXT.JetBrains.Annotations;


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Checks if the given value is between (inclusive) the minValue and maxValue.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentNullException">The min value can not be null.</exception>
        /// <exception cref="ArgumentNullException">The max value can not be null.</exception>
        /// <typeparam name="T">The type of the values to compare.</typeparam>
        /// <param name="value">The value to check.</param>
        /// <param name="minValue">The minimum value.</param>
        /// <param name="maxValue">The maximum value.</param>
        /// <returns>Returns true if the given value is between the minValue and maxValue, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static bool BetweenInclusive<T>([NotNull] this T value, [NotNull] T minValue, [NotNull] T maxValue)
            where T : IComparable<T>
        {
            value.ThrowIfNull(nameof(value));
            minValue.ThrowIfNull(nameof(minValue));
            maxValue.ThrowIfNull(nameof(maxValue));

            return value.CompareTo(minValue) >= 0 && value.CompareTo(maxValue) <= 0;
        }

        /// <summary>
        ///     Checks if the value is greater than the given compare value.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentNullException">The compare value can not be null.</exception>
        /// <param name="value">The value to check.</param>
        /// <param name="compareValue">The value to compare with.</param>
        /// <returns>
        ///     Returns true if the value is greater than the given compare value,
        ///     otherwise false.
        /// </returns>
        [Pure]
        [PublicAPI]
        public static bool Greater<T>([NotNull] this T value, [NotNull] T compareValue) where T : IComparable<T>
        {
            value.ThrowIfNull(nameof(value));
            compareValue.ThrowIfNull(nameof(compareValue));

            return value.CompareTo(compareValue) > 0;
        }

        /// <summary>
        ///     Checks if the value is greater or equals to the given compare value.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentNullException">The compare value can not be null.</exception>
        /// <param name="value">The value to check.</param>
        /// <param name="compareValue">The value to compare with.</param>
        /// <returns>
        ///     Returns true if the value is greater or equals to the given compare value,
        ///     otherwise false.
        /// </returns>
        [Pure]
        [PublicAPI]
        public static bool GreaterOrEquals<T>([NotNull] this T value, [NotNull] T compareValue) where T : IComparable<T>
        {
            value.ThrowIfNull(nameof(value));
            compareValue.ThrowIfNull(nameof(compareValue));

            return value.CompareTo(compareValue) >= 0;
        }

        /// <summary>
        ///     Checks if the value is smaller than the given compare value.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentNullException">The compare value can not be null.</exception>
        /// <param name="value">The value to check.</param>
        /// <param name="compareValue">The value to compare with.</param>
        /// <returns>
        ///     Returns true if the value is smaller than the given compare value,
        ///     otherwise false.
        /// </returns>
        [Pure]
        [PublicAPI]
        public static bool Smaller<T>([NotNull] this T value, [NotNull] T compareValue) where T : IComparable<T>
        {
            value.ThrowIfNull(nameof(value));
            compareValue.ThrowIfNull(nameof(compareValue));

            return value.CompareTo(compareValue) == -1;
        }

        /// <summary>
        ///     Checks if the value is smaller or equals to the given compare value.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentNullException">The compare value can not be null.</exception>
        /// <param name="value">The value to check.</param>
        /// <param name="compareValue">The value to compare with.</param>
        /// <returns>
        ///     Returns true if the value is smaller or equals to the given compare value,
        ///     otherwise false.
        /// </returns>
        [Pure]
        [PublicAPI]
        public static bool SmallerOrEquals<T>([NotNull] this T value, [NotNull] T compareValue) where T : IComparable<T>
        {
            value.ThrowIfNull(nameof(value));
            compareValue.ThrowIfNull(nameof(compareValue));

            return value.CompareTo(compareValue) <= 0;
        }
    }
}