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
        ///     Gets the specified percentage of the number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="percent">The percent.</param>
        /// <returns>Returns the specified percentage of the number</returns>
        [Pure]
        [PublicAPI]
        public static Decimal PercentageOf( this Decimal number, Int32 percent )
            => number * percent / 100;

        /// <summary>
        ///     Gets the specified percentage of the number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="percent">The percent.</param>
        /// <returns>Returns the specified percentage of the number</returns>
        [Pure]
        [PublicAPI]
        public static Decimal PercentageOf( this Decimal number, Decimal percent )
            => number * percent / 100;

        /// <summary>
        ///     Gets the specified percentage of the number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="percent">The percent.</param>
        /// <returns>Returns the specified percentage of the number</returns>
        [Pure]
        [PublicAPI]
        public static Decimal PercentageOf( this Decimal number, Int64 percent )
            => number * percent / 100;
    }
}


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Gets the percentage of the number.
        /// </summary>
        /// <exception cref="DivideByZeroException">The number must be greater than zero.</exception>
        /// <param name="number">The number.</param>
        /// <param name="total">The total value.</param>
        /// <returns>Returns the percentage of the number.</returns>
        [Pure]
        [PublicAPI]
        public static Decimal PercentOf( this Decimal number, Int32 total )
        {
            if ( number <= 0 )
                throw new DivideByZeroException( "The number must be greater than zero." );

            return total / number * 100;
        }

        /// <summary>
        ///     Gets the percentage of the number.
        /// </summary>
        /// <exception cref="DivideByZeroException">The number must be greater than zero.</exception>
        /// <param name="number">The number.</param>
        /// <param name="total">The total value.</param>
        /// <returns>Returns the percentage of the number.</returns>
        [Pure]
        [PublicAPI]
        public static Decimal PercentOf( this Decimal number, Decimal total )
        {
            if ( number <= 0 )
                throw new DivideByZeroException( "The number must be greater than zero." );

            return total / number * 100;
        }

        /// <summary>
        ///     Gets the percentage of the number.
        /// </summary>
        /// <exception cref="DivideByZeroException">The number must be greater than zero.</exception>
        /// <param name="number">The number.</param>
        /// <param name="total">The total value.</param>
        /// <returns>Returns the percentage of the number.</returns>
        [Pure]
        [PublicAPI]
        public static Decimal PercentOf( this Decimal number, Int64 total )
        {
            if ( number <= 0 )
                throw new DivideByZeroException( "The number must be greater than zero." );

            return total / number * 100;
        }
    }
}


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Computes the sum of a sequence of the given values.
        /// </summary>
        /// <exception cref="OverflowException">The sum is larger than <see cref="Decimal.MaxValue" /></exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <param name="value">The first value.</param>
        /// <param name="values">The other values.</param>
        /// <returns>Returns the sum of the values.</returns>
        [PublicAPI]
        [Pure]
        public static Decimal Sum( this Decimal value, [NotNull] params Decimal[] values )
        {
            values.ThrowIfNull( nameof(values) );

            var list = values.ToList();
            list.Add( value );
            return list.Sum();
        }

        /// <summary>
        ///     Computes the sum of a sequence of the given values.
        /// </summary>
        /// <exception cref="OverflowException">The sum is larger than <see cref="Decimal.MaxValue" /></exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <param name="value">The first value.</param>
        /// <param name="values">The other values.</param>
        /// <returns>Returns the sum of the values.</returns>
        [PublicAPI]
        [Pure]
        [CanBeNull]
        public static Decimal? Sum( [CanBeNull] this Decimal? value, [NotNull] params Decimal?[] values )
        {
            values.ThrowIfNull( nameof(values) );

            var list = values.ToList();
            list.Add( value );
            return list.Sum();
        }

        /// <summary>
        ///     Computes the sum of the sequence of <see cref="Decimal" /> values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <exception cref="OverflowException">The sum is larger than <see cref="Decimal.MaxValue" /></exception>
        /// <exception cref="ArgumentNullException">selector can not be null.</exception>
        /// <typeparam name="TSource">The type of the source values.</typeparam>
        /// <param name="value">The first value.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <param name="values">The other values.</param>
        /// <returns>Returns the sum of the projected values.</returns>
        [PublicAPI]
        [Pure]
        public static Decimal Sum<TSource>( [CanBeNull] this TSource value, [NotNull] Func<TSource, Decimal> selector, [NotNull] params TSource[] values )
        {
            selector.ThrowIfNull( nameof(selector) );
            values.ThrowIfNull( nameof(values) );

            var list = values.ToList();
            list.Add( value );
            return list.Sum( selector );
        }

        /// <summary>
        ///     Computes the sum of the sequence of nullable <see cref="Decimal" /> values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <exception cref="OverflowException">The sum is larger than <see cref="Decimal.MaxValue" /></exception>
        /// <exception cref="ArgumentNullException">selector can not be null.</exception>
        /// <typeparam name="TSource">The type of the source values.</typeparam>
        /// <param name="value">The first value.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <param name="values">The other values.</param>
        /// <returns>Returns the sum of the projected values.</returns>
        [PublicAPI]
        [Pure]
        [CanBeNull]
        public static Decimal? Sum<TSource>( [CanBeNull] this TSource value,
                                             [NotNull] Func<TSource, Decimal?> selector,
                                             [NotNull] params TSource[] values )
        {
            selector.ThrowIfNull( nameof(selector) );
            values.ThrowIfNull( nameof(values) );

            var list = values.ToList();
            list.Add( value );
            return list.Sum( selector );
        }
    }
}