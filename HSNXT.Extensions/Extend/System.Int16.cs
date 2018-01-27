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
    /// <summary>
    ///     Class containing some extension methods for <see cref="short" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Checks if the Int16 value is a factor of the specified factor number.
        /// </summary>
        /// <exception cref="DivideByZeroException">value is 0.</exception>
        /// <param name="value">The Int16 value to check.</param>
        /// <param name="factorNumer">The factor number.</param>
        /// <returns>Returns true if the value is a factor of the specified factor number, otherwise false.</returns>
        [PublicAPI]
        [Pure]
        public static Boolean FactorOf( this Int16 value, Int16 factorNumer )
            => factorNumer % value == 0;
    }
}


namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="short" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Checks if the Int16 is even.
        /// </summary>
        /// <param name="value">The Int16 to check.</param>
        /// <returns>Returns true if the Int16 is even, otherwise false.</returns>
        [PublicAPI]
        [Pure]
        public static Boolean IsEven( this Int16 value )
            => value % 2 == 0;
    }
}


namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="short" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Checks if the Int16 value is a multiple of the given factor.
        /// </summary>
        /// <exception cref="DivideByZeroException">factor is 0.</exception>
        /// <param name="value">The Int16 to check.</param>
        /// <param name="factor">The factor.</param>
        /// <returns>>Returns true if the Int16 value is a multiple of the given factor.</returns>
        [PublicAPI]
        [Pure]
        public static Boolean IsMultipleOf( this Int16 value, Int16 factor )
            => value != 0 && value % factor == 0;
    }
}


namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="short" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Checks if the Int16 is odd.
        /// </summary>
        /// <param name="value">The Int16 to check.</param>
        /// <returns>Returns true if the Int16 is odd, otherwise false.</returns>
        [PublicAPI]
        [Pure]
        public static Boolean IsOdd( this Int16 value )
            => value % 2 != 0;
    }
}


namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="short" />.
    /// </summary>
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
        public static Double PercentageOf( this Int16 number, Int32 percent )
            => (Double) number * percent / 100;

        /// <summary>
        ///     Gets the specified percentage of the number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="percent">The percent.</param>
        /// <returns>Returns the specified percentage of the number</returns>
        [Pure]
        [PublicAPI]
        public static Decimal PercentageOf( this Int16 number, Decimal percent )
            => number * percent / 100;

        /// <summary>
        ///     Gets the specified percentage of the number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="percent">The percent.</param>
        /// <returns>Returns the specified percentage of the number</returns>
        [Pure]
        [PublicAPI]
        public static Double PercentageOf( this Int16 number, Double percent )
            => number * percent / 100;

        /// <summary>
        ///     Gets the specified percentage of the number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="percent">The percent.</param>
        /// <returns>Returns the specified percentage of the number</returns>
        [Pure]
        [PublicAPI]
        public static Double PercentageOf( this Int16 number, Int64 percent )
            => (Double) number * percent / 100;
    }
}


namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="short" />.
    /// </summary>
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
        public static Double PercentOf( this Int16 number, Int32 total )
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
        public static Double PercentOf( this Int16 number, Double total )
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
        public static Double PercentOf( this Int16 number, Int64 total )
        {
            if ( number <= 0 )
                throw new DivideByZeroException( "The number must be greater than zero." );

            return total / (Double) number * 100;
        }
    }
}


namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="short" />.
    /// </summary>
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
        public static List<Int16> RangeTo( this Int16 startValue, Int16 endValue )
        {
            if ( startValue > endValue )
                throw new ArgumentException( "The start value can not be greater than the end value.", nameof(startValue) );

            var list = new List<Int16>( endValue - startValue );
            for ( var i = startValue; i <= endValue; i++ )
                list.Add( i );
            return list;
        }
    }
}