using System;
using HSNXT.JetBrains.Annotations;
using System.Linq;


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Computes the sum of a sequence of the given values.
        /// </summary>
        /// <exception cref="OverflowException">The sum is larger than <see cref="Double.MaxValue" /></exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <param name="value">The first value.</param>
        /// <param name="values">The other values.</param>
        /// <returns>Returns the sum of the values.</returns>
        [PublicAPI]
        [Pure]
        public static double Sum(this double value, [NotNull] params double[] values)
        {
            values.ThrowIfNull(nameof(values));

            var list = values.ToList();
            list.Add(value);
            return list.Sum();
        }

        /// <summary>
        ///     Computes the sum of a sequence of the given values.
        /// </summary>
        /// <exception cref="OverflowException">The sum is larger than <see cref="Double.MaxValue" /></exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <param name="value">The first value.</param>
        /// <param name="values">The other values.</param>
        /// <returns>Returns the sum of the values.</returns>
        [PublicAPI]
        [Pure]
        [CanBeNull]
        public static double? Sum([CanBeNull] this double? value, [NotNull] params double?[] values)
        {
            values.ThrowIfNull(nameof(values));

            var list = values.ToList();
            list.Add(value);
            return list.Sum();
        }

        /// <summary>
        ///     Computes the sum of the sequence of <see cref="Double" /> values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <exception cref="OverflowException">The sum is larger than <see cref="Double.MaxValue" /></exception>
        /// <exception cref="ArgumentNullException">selector can not be null.</exception>
        /// <typeparam name="TSource">The type of the source values.</typeparam>
        /// <param name="value">The first value.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <param name="values">The other values.</param>
        /// <returns>Returns the sum of the projected values.</returns>
        [PublicAPI]
        [Pure]
        public static double Sum<TSource>([CanBeNull] this TSource value, [NotNull] Func<TSource, double> selector,
            [NotNull] params TSource[] values)
        {
            selector.ThrowIfNull(nameof(selector));
            values.ThrowIfNull(nameof(values));

            var list = values.ToList();
            list.Add(value);
            return list.Sum(selector);
        }

        /// <summary>
        ///     Computes the sum of the sequence of nullable <see cref="Double" /> values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <exception cref="OverflowException">The sum is larger than <see cref="Double.MaxValue" /></exception>
        /// <exception cref="ArgumentNullException">selector can not be null.</exception>
        /// <typeparam name="TSource">The type of the source values.</typeparam>
        /// <param name="value">The first value.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <param name="values">The other values.</param>
        /// <returns>Returns the sum of the projected values.</returns>
        [PublicAPI]
        [Pure]
        [CanBeNull]
        public static double? Sum<TSource>([CanBeNull] this TSource value, [NotNull] Func<TSource, double?> selector,
            [NotNull] params TSource[] values)
        {
            selector.ThrowIfNull(nameof(selector));
            values.ThrowIfNull(nameof(values));

            var list = values.ToList();
            list.Add(value);
            return list.Sum(selector);
        }
    }
}