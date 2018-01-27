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
        ///     Returns a list containing all values of the given range.
        /// </summary>
        /// <exception cref="ArgumentException">The start value can not be greater than the end value.</exception>
        /// <param name="startValue">The start of the range.</param>
        /// <param name="endValue">The end of the range.</param>
        /// <returns>Returns a list containing the specified range.</returns>
        [Pure]
        [PublicAPI]
        public static List<int> RangeTo( this int startValue, int endValue )
        {
            if ( startValue > endValue )
                throw new ArgumentException( "The start value can not be greater than the end value.", nameof(startValue) );

            var list = new List<int>( endValue - startValue );
            for ( var i = startValue; i <= endValue; i++ )
                list.Add( i );
            return list;
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
        public static int Sum( this int value, [NotNull] params int[] values )
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
        public static int? Sum( this int? value, [NotNull] params int?[] values )
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
        public static int Sum<TSource>( this TSource value, [NotNull] Func<TSource, int> selector, [NotNull] params TSource[] values )
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
        public static int? Sum<TSource>( this TSource value, [NotNull] Func<TSource, int?> selector, [NotNull] params TSource[] values )
        {
            selector.ThrowIfNull( nameof(selector) );
            values.ThrowIfNull( nameof(values) );

            var list = values.ToList();
            list.Add( value );
            return list.Sum( selector );
        }
    }
}