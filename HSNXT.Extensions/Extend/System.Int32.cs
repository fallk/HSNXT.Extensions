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
        ///     Checks if the Int32 value is a factor of the specified factor number.
        /// </summary>
        /// <exception cref="DivideByZeroException">value is 0.</exception>
        /// <param name="value">The Int32 value to check.</param>
        /// <param name="factorNumer">The factor number.</param>
        /// <returns>Returns true if the value is a factor of the specified factor number, otherwise false.</returns>
        [PublicAPI]
        [Pure]
        public static Boolean FactorOf( this Int32 value, Int32 factorNumer )
            => factorNumer % value == 0;
    }
}


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Checks if the Int32 is even.
        /// </summary>
        /// <param name="value">The Int32 to check.</param>
        /// <returns>Returns true if the Int32 is even, otherwise false.</returns>
        [PublicAPI]
        [Pure]
        public static Boolean IsEven( this Int32 value )
            => value % 2 == 0;
    }
}


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Checks if the Int32 value is a multiple of the given factor.
        /// </summary>
        /// <exception cref="DivideByZeroException">factor is 0.</exception>
        /// <param name="value">The Int32 to check.</param>
        /// <param name="factor">The factor.</param>
        /// <returns>>Returns true if the Int32 value is a multiple of the given factor.</returns>
        [PublicAPI]
        [Pure]
        public static Boolean IsMultipleOf( this Int32 value, Int32 factor )
            => value != 0 && value % factor == 0;
    }
}


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Checks if the Int32 is odd.
        /// </summary>
        /// <param name="value">The Int32 to check.</param>
        /// <returns>Returns true if the Int32 is odd, otherwise false.</returns>
        [PublicAPI]
        [Pure]
        public static Boolean IsOdd( this Int32 value )
            => value % 2 != 0;
    }
}


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
        public static Double PercentageOf( this Int32 number, Int32 percent )
            => (Double) number * percent / 100;

        /// <summary>
        ///     Gets the specified percentage of the number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="percent">The percent.</param>
        /// <returns>Returns the specified percentage of the number</returns>
        [Pure]
        [PublicAPI]
        public static Decimal PercentageOf( this Int32 number, Decimal percent )
            => number * percent / 100;

        /// <summary>
        ///     Gets the specified percentage of the number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="percent">The percent.</param>
        /// <returns>Returns the specified percentage of the number</returns>
        [Pure]
        [PublicAPI]
        public static Double PercentageOf( this Int32 number, Double percent )
            => number * percent / 100;

        /// <summary>
        ///     Gets the specified percentage of the number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="percent">The percent.</param>
        /// <returns>Returns the specified percentage of the number</returns>
        [Pure]
        [PublicAPI]
        public static Double PercentageOf( this Int32 number, Int64 percent )
            => (Double) number * percent / 100;
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
        public static Double PercentOf( this Int32 number, Int32 total )
        {
            if ( number <= 0 )
                throw new DivideByZeroException( "The number must be greater than zero." );

            return total / (Double) number * 100;
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
        public static Double PercentOf( this Int32 number, Double total )
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
        ///     Returns a list containing all values of the given range.
        /// </summary>
        /// <exception cref="ArgumentException">The start value can not be greater than the end value.</exception>
        /// <param name="startValue">The start of the range.</param>
        /// <param name="endValue">The end of the range.</param>
        /// <returns>Returns a list containing the specified range.</returns>
        [Pure]
        [PublicAPI]
        public static List<Int32> RangeTo( this Int32 startValue, Int32 endValue )
        {
            if ( startValue > endValue )
                throw new ArgumentException( "The start value can not be greater than the end value.", nameof(startValue) );

            var list = new List<Int32>( endValue - startValue );
            for ( var i = startValue; i <= endValue; i++ )
                list.Add( i );
            return list;
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
        /// <exception cref="OverflowException">The sum is larger than <see cref="Int32.MaxValue" /></exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <param name="value">The first value.</param>
        /// <param name="values">The other values.</param>
        /// <returns>Returns the sum of the values.</returns>
        [Pure]
        [PublicAPI]
        public static Int32 Sum( this Int32 value, [NotNull] params Int32[] values )
        {
            values.ThrowIfNull( nameof(values) );

            var list = values.ToList();
            list.Add( value );
            return list.Sum();
        }

        /// <summary>
        ///     Computes the sum of a sequence of the given values.
        /// </summary>
        /// <exception cref="OverflowException">The sum is larger than <see cref="Int32.MaxValue" /></exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <param name="value">The first value.</param>
        /// <param name="values">The other values.</param>
        /// <returns>Returns the sum of the values.</returns>
        [Pure]
        [PublicAPI]
        public static Int32? Sum( this Int32? value, [NotNull] params Int32?[] values )
        {
            values.ThrowIfNull( nameof(values) );

            var list = values.ToList();
            list.Add( value );
            return list.Sum();
        }

        /// <summary>
        ///     Computes the sum of the sequence of <see cref="Int32" /> values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <exception cref="OverflowException">The sum is larger than <see cref="Int32.MaxValue" /></exception>
        /// <exception cref="ArgumentNullException">selector can not be null.</exception>
        /// <typeparam name="TSource">The type of the source values.</typeparam>
        /// <param name="value">The first value.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <param name="values">The other values.</param>
        /// <returns>Returns the sum of the projected values.</returns>
        [Pure]
        [PublicAPI]
        public static Int32 Sum<TSource>( this TSource value, [NotNull] Func<TSource, Int32> selector, [NotNull] params TSource[] values )
        {
            selector.ThrowIfNull( nameof(selector) );
            values.ThrowIfNull( nameof(values) );

            var list = values.ToList();
            list.Add( value );
            return list.Sum( selector );
        }

        /// <summary>
        ///     Computes the sum of the sequence of nullable <see cref="Int32" /> values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <exception cref="OverflowException">The sum is larger than <see cref="Int32.MaxValue" /></exception>
        /// <exception cref="ArgumentNullException">selector can not be null.</exception>
        /// <typeparam name="TSource">The type of the source values.</typeparam>
        /// <param name="value">The first value.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <param name="values">The other values.</param>
        /// <returns>Returns the sum of the projected values.</returns>
        [Pure]
        [PublicAPI]
        public static Int32? Sum<TSource>( this TSource value, [NotNull] Func<TSource, Int32?> selector, [NotNull] params TSource[] values )
        {
            selector.ThrowIfNull( nameof(selector) );
            values.ThrowIfNull( nameof(values) );

            var list = values.ToList();
            list.Add( value );
            return list.Sum( selector );
        }
    }
}