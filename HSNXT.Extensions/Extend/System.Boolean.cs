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
        ///     Executes the specified action if the given Boolean is false,
        ///     otherwise it executes the specified alternative action, if one is specified.
        /// </summary>
        /// <exception cref="ArgumentNullException">action can not be null.</exception>
        /// <param name="value">The Boolean to check.</param>
        /// <param name="action">The action to execute if the given value is false.</param>
        /// <param name="alternativeAction">The action to execute if the given value is true.></param>
        /// <returns>Returns the given boolean value.</returns>
        [PublicAPI]
        [Pure]
        public static Boolean IfFalse( this Boolean value, [NotNull] Action action, [CanBeNull] Action alternativeAction = null )
        {
            action.ThrowIfNull( nameof(action) );

            if ( !value )
                action();
            else
                alternativeAction?.Invoke();

            return value;
        }

        /// <summary>
        ///     Executes the specified action if the given Boolean is false,
        ///     otherwise it executes the specified alternative action, if one is specified.
        /// </summary>
        /// <exception cref="ArgumentNullException">action can not be null.</exception>
        /// <typeparam name="T">The type of the parameter.</typeparam>
        /// <param name="value">The Boolean to check.</param>
        /// <param name="parameter">The parameter to pass to the action with gets executed.</param>
        /// <param name="action">The action to execute if the given value is false.</param>
        /// <param name="alternativeAction">The action to execute if the given value is true.></param>
        /// <returns>Returns the given boolean value.</returns>
        [PublicAPI]
        [Pure]
        public static Boolean IfFalse<T>( this Boolean value, [CanBeNull] T parameter, [NotNull] Action<T> action, [CanBeNull] Action<T> alternativeAction = null )
        {
            action.ThrowIfNull( nameof(action) );

            if ( !value )
                action( parameter );
            else
                alternativeAction?.Invoke( parameter );

            return value;
        }

        /// <summary>
        ///     Executes the specified action if the given Boolean is false,
        ///     otherwise it executes the specified alternative action, if one is specified.
        /// </summary>
        /// <exception cref="ArgumentNullException">action can not be null.</exception>
        /// <typeparam name="T1">The type of the first parameter.</typeparam>
        /// <typeparam name="T2">The type of the second parameter.</typeparam>
        /// <param name="value">The Boolean to check.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="action">The action to execute if the given value is false.</param>
        /// <param name="alternativeAction">The action to execute if the given value is true.></param>
        /// <returns>Returns the given boolean value.</returns>
        [PublicAPI]
        [Pure]
        public static Boolean IfFalse<T1, T2>( this Boolean value,
                                               [CanBeNull] T1 parameter1,
                                               [CanBeNull] T2 parameter2,
                                               [NotNull] Action<T1, T2> action,
                                               [CanBeNull] Action<T1, T2> alternativeAction = null )
        {
            action.ThrowIfNull( nameof(action) );

            if ( !value )
                action( parameter1, parameter2 );
            else
                alternativeAction?.Invoke( parameter1, parameter2 );

            return value;
        }

        /// <summary>
        ///     Executes the specified action if the given Boolean is false,
        ///     otherwise it executes the specified alternative action, if one is specified.
        /// </summary>
        /// <exception cref="ArgumentNullException">action can not be null.</exception>
        /// <typeparam name="T1">The type of the first parameter.</typeparam>
        /// <typeparam name="T2">The type of the second parameter.</typeparam>
        /// <typeparam name="T3">The type of the third parameter.</typeparam>
        /// <param name="value">The Boolean to check.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="parameter3">The third parameter to pass to the action with gets executed.</param>
        /// <param name="action">The action to execute if the given value is false.</param>
        /// <param name="alternativeAction">The action to execute if the given value is true.></param>
        /// <returns>Returns the given boolean value.</returns>
        [PublicAPI]
        [Pure]
        public static Boolean IfFalse<T1, T2, T3>( this Boolean value,
                                                   [CanBeNull] T1 parameter1,
                                                   [CanBeNull] T2 parameter2,
                                                   [CanBeNull] T3 parameter3,
                                                   [NotNull] Action<T1, T2, T3> action,
                                                   [CanBeNull] Action<T1, T2, T3> alternativeAction = null )
        {
            action.ThrowIfNull( nameof(action) );

            if ( !value )
                action( parameter1, parameter2, parameter3 );
            else
                alternativeAction?.Invoke( parameter1, parameter2, parameter3 );

            return value;
        }

        /// <summary>
        ///     Executes the specified action if the given Boolean is false,
        ///     otherwise it executes the specified alternative action, if one is specified.
        /// </summary>
        /// <exception cref="ArgumentNullException">action can not be null.</exception>
        /// <typeparam name="T1">The type of the first parameter.</typeparam>
        /// <typeparam name="T2">The type of the second parameter.</typeparam>
        /// <typeparam name="T3">The type of the third parameter.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter.</typeparam>
        /// <param name="value">The Boolean to check.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="parameter3">The third parameter to pass to the action with gets executed.</param>
        /// <param name="parameter4">The fourth parameter to pass to the action with gets executed.</param>
        /// <param name="action">The action to execute if the given value is false.</param>
        /// <param name="alternativeAction">The action to execute if the given value is true.></param>
        /// <returns>Returns the given boolean value.</returns>
        [PublicAPI]
        [Pure]
        public static Boolean IfFalse<T1, T2, T3, T4>( this Boolean value,
                                                       [CanBeNull] T1 parameter1,
                                                       [CanBeNull] T2 parameter2,
                                                       [CanBeNull] T3 parameter3,
                                                       [CanBeNull] T4 parameter4,
                                                       [NotNull] Action<T1, T2, T3, T4> action,
                                                       [CanBeNull] Action<T1, T2, T3, T4> alternativeAction = null )
        {
            action.ThrowIfNull( nameof(action) );

            if ( value )
                alternativeAction?.Invoke( parameter1, parameter2, parameter3, parameter4 );
            else
                action( parameter1, parameter2, parameter3, parameter4 );

            return value;
        }
    }
}


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Executes the specified action if the given Boolean is true,
        ///     otherwise it executes the specified alternative action, if one is specified.
        /// </summary>
        /// <exception cref="ArgumentNullException">action can not be null.</exception>
        /// <param name="value">The Boolean to check.</param>
        /// <param name="action">The action to execute if the given value is true.</param>
        /// <param name="alternativeAction">The action to execute if the given value is false.</param>
        /// <returns>Returns the given boolean value.</returns>
        [PublicAPI]
        [Pure]
        public static Boolean IfTrue( this Boolean value, [NotNull] Action action, [CanBeNull] Action alternativeAction = null )
        {
            action.ThrowIfNull( nameof(action) );

            if ( value )
                action();
            else
                alternativeAction?.Invoke();

            return value;
        }

        /// <summary>
        ///     Executes the specified action if the given Boolean is true,
        ///     otherwise it executes the specified alternative action, if one is specified.
        /// </summary>
        /// <exception cref="ArgumentNullException">action can not be null.</exception>
        /// <typeparam name="T">The type of the parameter.</typeparam>
        /// <param name="value">The Boolean to check.</param>
        /// <param name="parameter">The parameter to pass to the action with gets executed.</param>
        /// <param name="action">The action to execute if the given value is true.</param>
        /// <param name="alternativeAction">The action to execute if the given value is false.</param>
        /// <returns>Returns the given boolean value.</returns>
        [PublicAPI]
        [Pure]
        public static Boolean IfTrue<T>( this Boolean value,
                                         [CanBeNull] T parameter,
                                         [NotNull] Action<T> action,
                                         [CanBeNull] Action<T> alternativeAction = null )
        {
            action.ThrowIfNull( nameof(action) );

            if ( value )
                action( parameter );
            else
                alternativeAction?.Invoke( parameter );

            return value;
        }

        /// <summary>
        ///     Executes the specified action if the given Boolean is true,
        ///     otherwise it executes the specified alternative action, if one is specified.
        /// </summary>
        /// <exception cref="ArgumentNullException">action can not be null.</exception>
        /// <typeparam name="T1">The type of the first parameter.</typeparam>
        /// <typeparam name="T2">The type of the second parameter.</typeparam>
        /// <param name="value">The Boolean to check.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="action">The action to execute if the given value is true.</param>
        /// <param name="alternativeAction">The action to execute if the given value is false.</param>
        /// <returns>Returns the given boolean value.</returns>
        [PublicAPI]
        [Pure]
        public static Boolean IfTrue<T1, T2>( this Boolean value,
                                              [CanBeNull] T1 parameter1,
                                              [CanBeNull] T2 parameter2,
                                              [NotNull] Action<T1, T2> action,
                                              [CanBeNull] Action<T1, T2> alternativeAction = null )
        {
            action.ThrowIfNull( nameof(action) );

            if ( value )
                action( parameter1, parameter2 );
            else
                alternativeAction?.Invoke( parameter1, parameter2 );

            return value;
        }

        /// <summary>
        ///     Executes the specified action if the given Boolean is true,
        ///     otherwise it executes the specified alternative action, if one is specified.
        /// </summary>
        /// <exception cref="ArgumentNullException">action can not be null.</exception>
        /// <typeparam name="T1">The type of the first parameter.</typeparam>
        /// <typeparam name="T2">The type of the second parameter.</typeparam>
        /// <typeparam name="T3">The type of the third parameter.</typeparam>
        /// <param name="value">The Boolean to check.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="parameter3">The third parameter to pass to the action with gets executed.</param>
        /// <param name="action">The action to execute if the given value is true.</param>
        /// <param name="alternativeAction">The action to execute if the given value is false.</param>
        /// <returns>Returns the given boolean value.</returns>
        [PublicAPI]
        [Pure]
        public static Boolean IfTrue<T1, T2, T3>( this Boolean value,
                                                  [CanBeNull] T1 parameter1,
                                                  [CanBeNull] T2 parameter2,
                                                  [CanBeNull] T3 parameter3,
                                                  [NotNull] Action<T1, T2, T3> action,
                                                  [CanBeNull] Action<T1, T2, T3> alternativeAction = null )
        {
            action.ThrowIfNull( nameof(action) );

            if ( value )
                action( parameter1, parameter2, parameter3 );
            else
                alternativeAction?.Invoke( parameter1, parameter2, parameter3 );

            return value;
        }

        /// <summary>
        ///     Executes the specified action if the given Boolean is true,
        ///     otherwise it executes the specified alternative action, if one is specified.
        /// </summary>
        /// <exception cref="ArgumentNullException">action can not be null.</exception>
        /// <typeparam name="T1">The type of the first parameter.</typeparam>
        /// <typeparam name="T2">The type of the second parameter.</typeparam>
        /// <typeparam name="T3">The type of the third parameter.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter.</typeparam>
        /// <param name="value">The Boolean to check.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="parameter3">The third parameter to pass to the action with gets executed.</param>
        /// <param name="parameter4">The fourth parameter to pass to the action with gets executed.</param>
        /// <param name="action">The action to execute if the given value is true.</param>
        /// <param name="alternativeAction">The action to execute if the given value is false.</param>
        /// <returns>Returns the given boolean value.</returns>
        [PublicAPI]
        [Pure]
        public static Boolean IfTrue<T1, T2, T3, T4>( this Boolean value,
                                                      [CanBeNull] T1 parameter1,
                                                      [CanBeNull] T2 parameter2,
                                                      [CanBeNull] T3 parameter3,
                                                      [CanBeNull] T4 parameter4,
                                                      [NotNull] Action<T1, T2, T3, T4> action,
                                                      [CanBeNull] Action<T1, T2, T3, T4> alternativeAction = null )
        {
            action.ThrowIfNull( nameof(action) );

            if ( value )
                action( parameter1, parameter2, parameter3, parameter4 );
            else
                alternativeAction?.Invoke( parameter1, parameter2, parameter3, parameter4 );

            return value;
        }
    }
}


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Returns the true or false value based on the given Boolean value.
        /// </summary>
        /// <param name="value">The Boolean to check</param>
        /// <param name="trueValue">The true value to be returned if the given value is true.</param>
        /// <param name="falseValue">The false value to be returned if the given value is false.</param>
        /// <returns>The true value if the given Boolean is true, otherwise the false value.</returns>
        [PublicAPI]
        [Pure]
        [CanBeNull]
        public static T SelectValue<T>( this Boolean value, [CanBeNull] T trueValue, [CanBeNull] T falseValue )
            => value ? trueValue : falseValue;
    }
}