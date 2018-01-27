#region Usings
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

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="double" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Returns whether the specified number evaluates to negative or positive infinity.
        /// </summary>
        /// <param name="value">The double to check.</param>
        /// <returns>Returns true if the given double is infinity, otherwise false.</returns>
        [PublicAPI]
        [Pure]
        public static Boolean IsInfinity( this Double value )
            => Double.IsInfinity( value );
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="double" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Returns whether the specified value is not a number.
        /// </summary>
        /// <param name="value">The double to check.</param>
        /// <returns>Returns true if the value is not a number, otherwise false.</returns>
        [PublicAPI]
        [Pure]
        public static Boolean IsNaN( this Double value )
            => Double.IsNaN( value );
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="double" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Returns whether the specified number evaluates to negative infinity.
        /// </summary>
        /// <param name="value">The double to check.</param>
        /// <returns>Returns true if the given double is negative infinity, otherwise false.</returns>
        [PublicAPI]
        [Pure]
        public static Boolean IsNegativeInfinity( this Double value )
            => Double.IsNegativeInfinity( value );
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="double" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Returns whether the specified number evaluates to positive infinity.
        /// </summary>
        /// <param name="value">The double to check.</param>
        /// <returns>Returns true if the given double is positive infinity, otherwise false.</returns>
        [PublicAPI]
        [Pure]
        public static Boolean IsPositiveInfinity( this Double value )
            => Double.IsPositiveInfinity( value );
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="double" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Gets the specified percentage of the number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="percent">The percent.</param>
        /// <returns>Returns the specified percentage of the number</returns>
        [PublicAPI]
        [Pure]
        public static Double PercentageOf( this Double number, Int32 percent )
            => number * percent / 100;

        /// <summary>
        ///     Gets the specified percentage of the number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="percent">The percent.</param>
        /// <returns>Returns the specified percentage of the number</returns>
        [PublicAPI]
        [Pure]
        public static Double PercentageOf( this Double number, Double percent )
            => number * percent / 100;

        /// <summary>
        ///     Gets the specified percentage of the number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="percent">The percent.</param>
        /// <returns>Returns the specified percentage of the number</returns>
        [PublicAPI]
        [Pure]
        public static Double PercentageOf( this Double number, Int64 percent )
            => number * percent / 100;
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="double" />.
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
        [PublicAPI]
        [Pure]
        public static Double PercentOf( this Double number, Int32 total )
            => total / number * 100;

        /// <summary>
        ///     Gets the percentage of the number.
        /// </summary>
        /// <exception cref="DivideByZeroException">The number must be greater than zero.</exception>
        /// <param name="number">The number.</param>
        /// <param name="total">The total value.</param>
        /// <returns>Returns the percentage of the number.</returns>
        [PublicAPI]
        [Pure]
        public static Double PercentOf( this Double number, Double total )
            => total / number * 100;

        /// <summary>
        ///     Gets the percentage of the number.
        /// </summary>
        /// <exception cref="DivideByZeroException">The number must be greater than zero.</exception>
        /// <param name="number">The number.</param>
        /// <param name="total">The total value.</param>
        /// <returns>Returns the percentage of the number.</returns>
        [PublicAPI]
        [Pure]
        public static Double PercentOf( this Double number, Int64 total )
            => total / number * 100;
    }
}
#region Usings

//using System;
//using System.Linq;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="int" />.
    /// </summary>
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
        public static Double Sum( this Double value, [NotNull] params Double[] values )
        {
            values.ThrowIfNull( nameof(values) );

            var list = values.ToList();
            list.Add( value );
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
        public static Double? Sum( [CanBeNull] this Double? value, [NotNull] params Double?[] values )
        {
            values.ThrowIfNull( nameof(values) );

            var list = values.ToList();
            list.Add( value );
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
        public static Double Sum<TSource>( [CanBeNull] this TSource value, [NotNull] Func<TSource, Double> selector, [NotNull] params TSource[] values )
        {
            selector.ThrowIfNull( nameof(selector) );
            values.ThrowIfNull( nameof(values) );

            var list = values.ToList();
            list.Add( value );
            return list.Sum( selector );
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
        public static Double? Sum<TSource>( [CanBeNull] this TSource value, [NotNull] Func<TSource, Double?> selector, [NotNull] params TSource[] values )
        {
            selector.ThrowIfNull( nameof(selector) );
            values.ThrowIfNull( nameof(values) );

            var list = values.ToList();
            list.Add( value );
            return list.Sum( selector );
        }
    }
}