using System;
using System.Collections.Generic;
using HSNXT.JetBrains.Annotations;


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
        public static double PercentageOf( this short number, int percent )
            => (double) number * percent / 100;

        /// <summary>
        ///     Gets the specified percentage of the number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="percent">The percent.</param>
        /// <returns>Returns the specified percentage of the number</returns>
        [Pure]
        [PublicAPI]
        public static decimal PercentageOf( this short number, decimal percent )
            => number * percent / 100;

        /// <summary>
        ///     Gets the specified percentage of the number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="percent">The percent.</param>
        /// <returns>Returns the specified percentage of the number</returns>
        [Pure]
        [PublicAPI]
        public static double PercentageOf( this short number, double percent )
            => number * percent / 100;

        /// <summary>
        ///     Gets the specified percentage of the number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="percent">The percent.</param>
        /// <returns>Returns the specified percentage of the number</returns>
        [Pure]
        [PublicAPI]
        public static double PercentageOf( this short number, long percent )
            => (double) number * percent / 100;
        /// <summary>
        ///     Gets the percentage of the number.
        /// </summary>
        /// <exception cref="DivideByZeroException">The number must be greater than zero.</exception>
        /// <param name="number">The number.</param>
        /// <param name="total">The total value.</param>
        /// <returns>Returns the percentage of the number.</returns>
        [Pure]
        [PublicAPI]
        public static double PercentOf( this short number, int total )
        {
            if ( number <= 0 )
                throw new DivideByZeroException( "The number must be greater than zero." );

            return total / (double) number * 100;
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
        public static double PercentOf( this short number, double total )
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
        public static double PercentOf( this short number, long total )
        {
            if ( number <= 0 )
                throw new DivideByZeroException( "The number must be greater than zero." );

            return total / (double) number * 100;
        }
        /// <summary>
        ///     Returns a list containing all values of the given range.
        /// </summary>
        /// <exception cref="ArgumentException">The start value can not be greater than the end value.</exception>
        /// <param name="startValue">The start of the range.</param>
        /// <param name="endValue">The end of the range.</param>
        /// <returns>Returns a list containing the specified range.</returns>
        [Pure]
        [PublicAPI]
        public static List<short> RangeTo( this short startValue, short endValue )
        {
            if ( startValue > endValue )
                throw new ArgumentException( "The start value can not be greater than the end value.", nameof(startValue) );

            var list = new List<short>( endValue - startValue );
            for ( var i = startValue; i <= endValue; i++ )
                list.Add( i );
            return list;
        }
    }
}