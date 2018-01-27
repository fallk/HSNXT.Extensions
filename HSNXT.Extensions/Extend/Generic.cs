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
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="object" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Executes the action specified, which the given object as parameter.
        /// </summary>
        /// <remarks>
        ///     Use this method to chain method calls on the same object.
        /// </remarks>
        /// <exception cref="ArgumentNullException">The action can not be null.</exception>
        /// <typeparam name="T">The type of the object.</typeparam>
        /// <param name="obj">The object to act on.</param>
        /// <param name="action">The action.</param>
        /// <returns>Returns the given object.</returns>
        [PublicAPI]
        [Pure]
        public static T Chain<T>( [CanBeNull] this T obj, [NotNull] Action<T> action )
        {
            action.ThrowIfNull( nameof(action) );

            action( obj );
            return obj;
        }
    }
}
﻿#region Usings

//using System;
//using System.Linq;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="object" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Return the first not null value (including <paramref name="value" />).
        /// </summary>
        /// <exception cref="ArgumentNullException">The values can not be null.</exception>
        /// <exception cref="InvalidOperationException">The array only contains null value.</exception>
        /// <typeparam name="T">The type of the values.</typeparam>
        /// <param name="value">The first value..</param>
        /// <param name="values">A list of values.</param>
        /// <returns>Returns the first not null value.</returns>
        [CanBeNull]
        [PublicAPI]
        [Pure]
        public static T Coalesce<T>( [CanBeNull] this T value, [NotNull] [ItemCanBeNull] params T[] values ) where T : class
        {
            if ( value != null )
                return value;

            values.ThrowIfNull( nameof(values) );

            return values.First( x => x != null );
        }

        /// <summary>
        ///     Return the first not null value (including <paramref name="value" />).
        /// </summary>
        /// <typeparam name="T">The type of the values.</typeparam>
        /// <param name="value">The first value.</param>
        /// <param name="value0">The second value.</param>
        /// <returns>Returns the first not null value.</returns>
        [CanBeNull]
        [PublicAPI]
        [Pure]
        public static T Coalesce<T>( [CanBeNull] this T value, [CanBeNull] T value0 ) where T : class
            => value ?? value0;
    }
}
﻿#region Usings

//using System;
//using System.Linq;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="object" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Return the first not null value (including <paramref name="value" />).
        ///     If all values are null, returns a default value.
        /// </summary>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <exception cref="ArgumentNullException">defaultValue can not be null.</exception>
        /// <typeparam name="T">The type of the values.</typeparam>
        /// <param name="value">The first value.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <param name="values">A list of values.</param>
        /// <returns>Returns the first not null value.</returns>
        [NotNull]
        [PublicAPI]
        [Pure]
        public static T CoalesceOrDefault<T>( [CanBeNull] this T value, [NotNull] T defaultValue, [NotNull] [ItemCanBeNull] params T[] values ) where T : class
        {
            defaultValue.ThrowIfNull( nameof(defaultValue) );
            values.ThrowIfNull( nameof(values) );

            if ( value != null )
                return value;

            var notNullValues = values
                .Where( x => x != null )
                .ToList();

            return notNullValues.Any() ? notNullValues.First() : defaultValue;
        }

        /// <summary>
        ///     Return the first not null value (including <paramref name="value" />).
        ///     If all values are null, returns a default value.
        /// </summary>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <exception cref="ArgumentNullException">defaultValueFactory can not be null.</exception>
        /// <typeparam name="T">The type of the values.</typeparam>
        /// <param name="value">The first value.</param>
        /// <param name="defaultValueFactory">The default value factory.</param>
        /// <param name="values">A list of values.</param>
        /// <returns>Returns the first not null value.</returns>
        [NotNull]
        [PublicAPI]
        [Pure]
        public static T CoalesceOrDefault<T>( [CanBeNull] this T value, [NotNull] Func<T> defaultValueFactory, [NotNull] [ItemCanBeNull] params T[] values )
            where T : class
        {
            defaultValueFactory.ThrowIfNull( nameof(defaultValueFactory) );
            values.ThrowIfNull( nameof(values) );

            if ( value != null )
                return value;

            var notNullValues = values
                .Where( x => x != null )
                .ToList();
            return notNullValues.Any() ? notNullValues.First() : defaultValueFactory();
        }
    }
}
﻿#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="object" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Executes the given action with the value as parameter and handles any exceptions during the execution.
        /// </summary>
        /// <exception cref="ArgumentNullException">The action can not be null.</exception>
        /// <param name="value">The value.</param>
        /// <param name="action">The action.</param>
        /// <typeparam name="T">The type of the value.</typeparam>
        /// <returns>Returns the given value as result or an exception if one is occurred.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static IExecutionResult<T> ExecuteSafe<T>( [CanBeNull] this T value, [NotNull] Action<T> action )
        {
            action.ThrowIfNull( nameof(action) );

            var result = new ExecutionResult<T>();
            try
            {
                action( value );
                result.Result = value;
            }
            catch ( Exception ex )
            {
                result.Exception = ex;
            }
            return result;
        }

        /// <summary>
        ///     Executes the given function with the value as parameter and handles any exceptions during the execution.
        /// </summary>
        /// <exception cref="ArgumentNullException">The func can not be null.</exception>
        /// <param name="value">The value.</param>
        /// <param name="func">The function.</param>
        /// <typeparam name="T">The type of the value.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <returns>Returns the result of the function or an exception if one is occurred.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static IExecutionResult<TResult> ExecuteSafe<T, TResult>( [CanBeNull] this T value, [NotNull] Func<T, TResult> func )
        {
            func.ThrowIfNull( nameof(func) );

            var result = new ExecutionResult<TResult>();
            try
            {
                result.Result = func( value );
            }
            catch ( Exception ex )
            {
                result.Exception = ex;
            }
            return result;
        }
    }
}
﻿#region Usings

//using System;
//using System.Linq.Expressions;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="object" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Gets the name of the member to which the given expression points.
        /// </summary>
        /// <exception cref="ArgumentNullException">expression can not be null.</exception>
        /// <exception cref="NotSupportedException">
        ///     The given expression is of a not supported type (supported are:
        ///     <see cref="ExpressionType.MemberAccess" />, <see cref="ExpressionType.Convert" />).
        /// </exception>
        /// <typeparam name="TObject">The type of the source object.</typeparam>
        /// <typeparam name="TMember">The type of the member to which the expression points.</typeparam>
        /// <param name="obj">The source object.</param>
        /// <param name="expression">An expression pointing to the member to get the name of.</param>
        /// <returns>Returns the name of the member to which the given expression points.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static String GetName<TObject, TMember>( [CanBeNull] this TObject obj, [NotNull] Expression<Func<TObject, TMember>> expression )
        {
            expression.ThrowIfNull( nameof(expression) );

            return GetName( expression.Body );
        }

        /// <summary>
        ///     Gets the name of the member to which the given expression points.
        /// </summary>
        /// <exception cref="ArgumentNullException">expression can not be null.</exception>
        /// <exception cref="NotSupportedException">
        ///     The given expression is of a not supported type (supported are:
        ///     <see cref="ExpressionType.MemberAccess" />, <see cref="ExpressionType.Convert" />).
        /// </exception>
        /// <typeparam name="TObject">The type of the member to which the expression points.</typeparam>
        /// <typeparam name="TMember">The type of the member to which the expression points.</typeparam>
        /// <param name="obj">The object to call the method on.</param>
        /// <param name="expression">An expression pointing to the member to get the name of.</param>
        /// <returns>Returns the name of the member to which the given expression points.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static String GetName<TObject, TMember>( [CanBeNull] [NoEnumeration] this TObject obj, [NotNull] Expression<Func<TMember>> expression )
        {
            expression.ThrowIfNull( nameof(expression) );

            return GetName( expression.Body );
        }

        /// <summary>
        ///     Gets the name of the member to which the given expression points.
        /// </summary>
        /// <param name="expression">The expression pointing to the member.</param>
        /// <exception cref="NotSupportedException">
        ///     expression is not supported (expression is <see cref="ConstantExpression" /> or
        ///     <see cref="LambdaExpression" /> with an invalid body).
        /// </exception>
        /// <returns>Returns the name of the member to which the given expression points.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        private static String GetName( [NotNull] Expression expression )
        {
            if ( !expression.TryGetMemberExpression( out var memberExpression ) )
                throw new ArgumentException( "The given expression was not valid." );

            return memberExpression.Member.Name;
        }
    }
}
﻿#region Usings

//using System;
//using System.Collections.Generic;
//using System.Linq.Expressions;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="object" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Gets the name, including a full name chain, of the member to which the given expression points.
        /// </summary>
        /// <exception cref="ArgumentNullException">expression can not be null.</exception>
        /// <exception cref="NotSupportedException">
        ///     The given expression is of a not supported type (supported are:
        ///     <see cref="ExpressionType.MemberAccess" />, <see cref="ExpressionType.Convert" />).
        /// </exception>
        /// <typeparam name="TObject">The type of the member to which the expression points.</typeparam>
        /// <param name="obj">The object to call the method on.</param>
        /// <typeparam name="TMember">The type of the member to which the expression points.</typeparam>
        /// <param name="expression">An expression pointing to the member to get the name of.</param>
        /// <returns>Returns the name, including a full name chain, of the member to which the given expression points.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static String GetNameChain<TObject, TMember>( [CanBeNull] this TObject obj, [NotNull] Expression<Func<TObject, TMember>> expression )
        {
            expression.ThrowIfNull( nameof(expression) );

            return GetNameChain( expression.Body );
        }

        /// <summary>
        ///     Gets the name, including a full name chain, of the member to which the given expression points.
        /// </summary>
        /// <exception cref="ArgumentNullException">expression can not be null.</exception>
        /// <exception cref="NotSupportedException">
        ///     The given expression is of a not supported type (supported are:
        ///     <see cref="ExpressionType.MemberAccess" />, <see cref="ExpressionType.Convert" />).
        /// </exception>
        /// <typeparam name="TObject">The type of the member to which the expression points.</typeparam>
        /// <param name="obj">The object to call the method on.</param>
        /// <typeparam name="TMember">The type of the member to which the expression points.</typeparam>
        /// <param name="expression">An expression pointing to the member to get the name of.</param>
        /// <returns>Returns the name, including a full name chain, of the member to which the given expression points.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static String GetNameChain<TObject, TMember>( [CanBeNull] this TObject obj, [NotNull] Expression<Func<TMember>> expression )
        {
            expression.ThrowIfNull( nameof(expression) );

            return GetNameChain( expression.Body );
        }

        /// <summary>
        ///     Gets the name, including a full name chain, of the member to which the given expression points.
        /// </summary>
        /// <exception cref="ArgumentNullException">expression can not be null.</exception>
        /// <exception cref="NotSupportedException">
        ///     The given expression is of a not supported type (supported are:
        ///     <see cref="ExpressionType.MemberAccess" />, <see cref="ExpressionType.Convert" />).
        /// </exception>
        /// <param name="expression">The expression pointing to the member.</param>
        /// <returns>Returns the name, including a full name chain, of the member to which the given expression points.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        private static String GetNameChain( [NotNull] this Expression expression )
        {
            expression.ThrowIfNull( nameof(expression) );

            if ( !expression.TryGetMemberExpression( out var memberExpression ) )
                throw new ArgumentException( "The given expression is not valid." );

            var memberNames = new Stack<String>();
            do
            {
                // Check if the 'inner' expression as a constant expression, if so, break the loop
                if ( memberExpression.Expression.NodeType == ExpressionType.Constant )
                {
                    if ( memberNames.NotAny() )
                        memberNames.Push( memberExpression.Member.Name );
                    break;
                }

                memberNames.Push( memberExpression.Member.Name );

                // Check if expression is pointing to lambda parameter e.g. x (x => x)
                if ( memberExpression.Expression.NodeType == ExpressionType.Parameter )
                    break;
            } while ( memberExpression.Expression.TryGetMemberExpression( out memberExpression ) );

            return memberNames.StringJoin( "." );
        }
    }
}
﻿#region Usings

//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="object" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Returns the given value if it is not null, otherwise returns the alternative value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="alternativeValue">The alternative value.</param>
        /// <typeparam name="T">The type of the values.</typeparam>
        /// <returns>Returns the value or the alternative value.</returns>
        [CanBeNull]
        [Pure]
        [PublicAPI]
        public static T IfNull<T>( [CanBeNull] this T value, [CanBeNull] T alternativeValue ) where T : class
            => value ?? alternativeValue;
    }
}
﻿#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="object" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Checks if the given value is the default value of it's type.
        /// </summary>
        /// <typeparam name="T">The type of the value.</typeparam>
        /// <param name="value">The value to check.</param>
        /// <returns>Returns true if the value is the default value of it's type.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean IsDefault<T>( [CanBeNull] this T value )
            => Equals( value, default(T) );
    }
}
﻿#region Usings

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="object" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Checks if the value is present in the given array.
        /// </summary>
        /// <exception cref="ArgumentNullException">The values can not be null.</exception>
        /// <param name="value">The value to search for.</param>
        /// <param name="values">A IEnumerable containing the values.</param>
        /// <typeparam name="T">The type of the value.</typeparam>
        /// <returns>>Returns true if the value is present in the array.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean IsIn<T>( [CanBeNull] this T value, [NotNull] params T[] values )
        {
            values.ThrowIfNull( nameof(values) );

            return Array.IndexOf( values, value ) != -1;
        }

        /// <summary>
        ///     Checks if the value is present in the given IEnumerable.
        /// </summary>
        /// <exception cref="ArgumentNullException">The values can not be null.</exception>
        /// <param name="value">The value to search for.</param>
        /// <param name="values">A IEnumerable containing the values.</param>
        /// <typeparam name="T">The type of the value.</typeparam>
        /// <returns>>Returns true if the value is present in the IEnumerable.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean IsIn<T>( [CanBeNull] this T value, [NotNull] IEnumerable<T> values )
        {
            values.ThrowIfNull( nameof(values) );

            return values.Contains( value );
        }
    }
}
﻿#region Usings

//using System;
//using System.Collections.Generic;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="object" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Checks if the value is not present in the given array.
        /// </summary>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <param name="value">The value to search for.</param>
        /// <param name="values">A IEnumerable containing the values.</param>
        /// <typeparam name="T">The type of the value.</typeparam>
        /// <returns>>Returns true if the value is not present in the array.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean IsNotIn<T>( [CanBeNull] this T value, [NotNull] params T[] values )
            => !IsIn( value, values );

        /// <summary>
        ///     Checks if the value is not present in the given IEnumerable.
        /// </summary>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <param name="value">The value to search for.</param>
        /// <param name="values">A IEnumerable containing the values.</param>
        /// <typeparam name="T">The type of the value.</typeparam>
        /// <returns>>Returns true if the value is not present in the IEnumerable.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean IsNotIn<T>( [CanBeNull] this T value, [NotNull] IEnumerable<T> values )
            => !IsIn( value, values );
    }
}
﻿#region Usings

//using System;
//using System.Linq;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="object" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Returns the maximum value.
        /// </summary>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <typeparam name="TSource">The type of the values.</typeparam>
        /// <param name="value">The first value.</param>
        /// <param name="values">The other values.</param>
        /// <returns>Returns the maximum value.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static TSource Maximum<TSource>( [CanBeNull] this TSource value, [NotNull] params TSource[] values )
        {
            values.ThrowIfNull( nameof(values) );

            var list = values.ToList();
            list.Add( value );
            return list.Max();
        }

        /// <summary>
        ///     Returns the maximum value.
        /// </summary>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <exception cref="ArgumentNullException">selector can not be null.</exception>
        /// <typeparam name="TSource">The type of the values.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="value">The first value.</param>
        /// <param name="values">The other values.</param>
        /// <param name="selector"> A transform function to apply to each element.</param>
        /// <returns>Returns the maximum value.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static TResult Maximum<TSource, TResult>( [CanBeNull] this TSource value,
                                                         [NotNull] Func<TSource, TResult> selector,
                                                         [NotNull] params TSource[] values )
        {
            values.ThrowIfNull( nameof(values) );
            selector.ThrowIfNull( nameof(selector) );

            var list = values.ToList();
            list.Add( value );
            return list.Max( selector );
        }
    }
}
﻿#region Usings

//using System;
//using System.Linq;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="object" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Returns the minimum value.
        /// </summary>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <typeparam name="TSource">The type of the values.</typeparam>
        /// <param name="value">The first value.</param>
        /// <param name="values">The other values.</param>
        /// <returns>Returns the minimum value.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static TSource Minimum<TSource>( [CanBeNull] this TSource value, [NotNull] params TSource[] values )
        {
            values.ThrowIfNull( nameof(values) );

            var list = values.ToList();
            list.Add( value );
            return list.Min();
        }

        /// <summary>
        ///     Returns the minimum value.
        /// </summary>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <exception cref="ArgumentNullException">selector can not be null.</exception>
        /// <typeparam name="TSource">The type of the values.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="value">The first value.</param>
        /// <param name="values">The other values.</param>
        /// <param name="selector"> A transform function to apply to each element.</param>
        /// <returns>Returns the minimum value.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static TResult Minimum<TSource, TResult>( [CanBeNull] this TSource value,
                                                         [NotNull] Func<TSource, TResult> selector,
                                                         [NotNull] params TSource[] values )
        {
            values.ThrowIfNull( nameof(values) );
            selector.ThrowIfNull( nameof(selector) );

            var list = values.ToList();
            list.Add( value );
            return list.Min( selector );
        }
    }
}
﻿#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="object" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Checks if the objects satisfies the given specification.
        /// </summary>
        /// <exception cref="ArgumentNullException">specification can not be null.</exception>
        /// <typeparam name="T">The type of the object.</typeparam>
        /// <param name="obj">The object to check.</param>
        /// <param name="specification">The specification to use.</param>
        /// <returns>Returns true if the object satisfies the specification; otherwise, false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean Satisfies<T>( [CanBeNull] this T obj, [NotNull] ISpecification<T> specification )
        {
            specification.ThrowIfNull( nameof(specification) );

            return specification.IsSatisfiedBy( obj );
        }
    }
}
﻿#region Usings

//using System;
//using System.Collections.Generic;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="object" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Checks if the objects satisfies the given specification.
        /// </summary>
        /// <exception cref="ArgumentNullException">specification can not be null.</exception>
        /// <typeparam name="T">The type of the object.</typeparam>
        /// <param name="obj">The object to check.</param>
        /// <param name="specification">The specification to use.</param>
        /// <returns></returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static IEnumerable<String> SatisfiesWithMessages<T>( [CanBeNull] this T obj, [NotNull] ISpecification<T> specification )
        {
            specification.ThrowIfNull( nameof(specification) );

            return specification.IsSatisfiedByWithMessages( obj );
        }
    }
}
﻿#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="object" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Creates a specification with the given condition and message.
        /// </summary>
        /// <exception cref="ArgumentNullException">expression can not be null.</exception>
        /// <typeparam name="T">The target type of the expression.</typeparam>
        /// <param name="obj">The object used to create the expression. (Can be null)</param>
        /// <param name="expression">An expression determining whether an object matches the specification or not.</param>
        /// <param name="message">An error messaged, returned when an object doesn't match the specification.</param>
        /// <returns>Returns a specification with the given condition and message.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static ISpecification<T> Specification<T>( [CanBeNull] this T obj, [NotNull] Func<T, Boolean> expression, [CanBeNull] String message = null )
        {
            expression.ThrowIfNull( nameof(expression) );

            return new ExpressionSpecification<T>( expression, message );
        }
    }
}
﻿#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="object" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Swaps the given values.
        /// </summary>
        /// <typeparam name="T">The type of the values.</typeparam>
        /// <param name="obj">An object to cal the extension method on, can be null.</param>
        /// <param name="value0">The first value.</param>
        /// <param name="value1">The second value.</param>
        [PublicAPI]
        public static void Swap<T>( [CanBeNull] this Object obj, ref T value0, ref T value1 )
        {
            var temp = value0;
            value0 = value1;
            value1 = temp;
        }
    }
}
﻿#region Usings

//using System;
//using System.Diagnostics;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="object" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Throws a <see cref="ArgumentNullException" /> exception if <paramref name="obj" /> is null.
        /// </summary>
        /// <remarks>
        ///     If <paramref name="errorMessage" /> is null, this method will use the following default message:
        ///     "{object name} can not be null."
        /// </remarks>
        /// <typeparam name="TObject">The type <paramref name="obj" />.</typeparam>
        /// <param name="obj">The object to check.</param>
        /// <param name="parameterName">The name of <paramref name="obj" />.</param>
        /// <param name="errorMessage">
        ///     The text used as exception message if <paramref name="obj" /> is null.
        /// </param>
        [PublicAPI]
        [DebuggerStepThrough]
        public static void ThrowIfNull<TObject>( [NoEnumeration] [CanBeNull] this TObject obj,
                                                 [NotNull] String parameterName,
                                                 [CanBeNull] String errorMessage = null )
        {
            if ( obj != null )
                return;

            throw new ArgumentNullException( parameterName,
                                             errorMessage ?? $"{parameterName} can not be null." );
        }
    }
}
﻿#region Usings

//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="object" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Creates a array with the given value as only item.
        /// </summary>
        /// <typeparam name="T">The type of the items in the array.</typeparam>
        /// <param name="value">The value to add to the new created array.</param>
        /// <returns>Returns the new created array.</returns>
        [NotNull]
        [ItemCanBeNull]
        [Pure]
        [PublicAPI]
        public static T[] ToSingleItemArray<T>( [CanBeNull] this T value )
            => new[]
            {
                value
            };
    }
}