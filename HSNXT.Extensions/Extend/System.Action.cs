using System;
using HSNXT.JetBrains.Annotations;
using System.Linq;


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Executes the specified action if one of the given Boolean values is false,
        ///     otherwise it executes the specified true action, if one is specified.
        /// </summary>
        /// <exception cref="ArgumentNullException">falseAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <param name="falseAction">The action to execute if any of the given values is false.</param>
        /// <param name="trueAction">The action to execute if all of the given value is true.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfAnyFalse( [NotNull] this Action falseAction, [CanBeNull] Action trueAction = null, [NotNull] params bool[] values )
        {
            falseAction.ThrowIfNull( nameof(falseAction) );
            values.ThrowIfNull( nameof(values) );

            if ( values.Any( x => !x ) )
                falseAction();
            else
                trueAction?.Invoke();
        }

        /// <summary>
        ///     Executes the specified action if one of the given Boolean values is false,
        ///     otherwise it executes the specified true action, if one is specified.
        /// </summary>
        /// <exception cref="ArgumentNullException">falseAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <typeparam name="T">The type of the parameter.</typeparam>
        /// <param name="falseAction">The action to execute if any of the given values is false.</param>
        /// <param name="parameter">The parameter to pass to the action with gets executed.</param>
        /// <param name="trueAction">The action to execute if all values are true.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfAnyFalse<T>( [NotNull] this Action<T> falseAction,
                                                 [CanBeNull] T parameter,
                                                 [CanBeNull] Action<T> trueAction = null,
                                                 [NotNull] params bool[] values )
        {
            falseAction.ThrowIfNull( nameof(falseAction) );
            values.ThrowIfNull( nameof(values) );

            if ( values.Any( x => !x ) )
                falseAction( parameter );
            else
                trueAction?.Invoke( parameter );
        }

        /// <summary>
        ///     Executes the specified action if one of the given Boolean values is false,
        ///     otherwise it executes the specified true action, if one is specified.
        /// </summary>
        /// <exception cref="ArgumentNullException">falseAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <typeparam name="T1">The type of the first parameter.</typeparam>
        /// <typeparam name="T2">The type of the second parameter.</typeparam>
        /// <param name="trueAction">The action to execute if all values are true.</param>
        /// <param name="falseAction">The action to execute if any of the given values is false.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfAnyFalse<T1, T2>( [NotNull] this Action<T1, T2> falseAction,
                                                      [CanBeNull] T1 parameter1,
                                                      [CanBeNull] T2 parameter2,
                                                      [CanBeNull] Action<T1, T2> trueAction = null,
                                                      [NotNull] params bool[] values )
        {
            falseAction.ThrowIfNull( nameof(falseAction) );
            values.ThrowIfNull( nameof(values) );

            if ( values.Any( x => !x ) )
                falseAction( parameter1, parameter2 );
            else
                trueAction?.Invoke( parameter1, parameter2 );
        }

        /// <summary>
        ///     Executes the specified action if one of the given Boolean values is false,
        ///     otherwise it executes the specified true action, if one is specified.
        /// </summary>
        /// <exception cref="ArgumentNullException">falseAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <typeparam name="T1">The type of the first parameter.</typeparam>
        /// <typeparam name="T2">The type of the second parameter.</typeparam>
        /// <typeparam name="T3">The type of the third parameter.</typeparam>
        /// <param name="trueAction">The action to execute if all values are true.</param>
        /// <param name="falseAction">The action to execute if any of the given values is false.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="parameter3">The third parameter to pass to the action with gets executed.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfAnyFalse<T1, T2, T3>( [NotNull] this Action<T1, T2, T3> falseAction,
                                                          [CanBeNull] T1 parameter1,
                                                          [CanBeNull] T2 parameter2,
                                                          [CanBeNull] T3 parameter3,
                                                          [CanBeNull] Action<T1, T2, T3> trueAction = null,
                                                          [NotNull] params bool[] values )
        {
            falseAction.ThrowIfNull( nameof(falseAction) );
            values.ThrowIfNull( nameof(values) );

            if ( values.Any( x => !x ) )
                falseAction( parameter1, parameter2, parameter3 );
            else
                trueAction?.Invoke( parameter1, parameter2, parameter3 );
        }

        /// <summary>
        ///     Executes the specified action if one of the given Boolean values is false,
        ///     otherwise it executes the specified true action, if one is specified.
        /// </summary>
        /// <exception cref="ArgumentNullException">falseAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <typeparam name="T1">The type of the first parameter.</typeparam>
        /// <typeparam name="T2">The type of the second parameter.</typeparam>
        /// <typeparam name="T3">The type of the third parameter.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter.</typeparam>
        /// <param name="trueAction">The action to execute if all values are true.</param>
        /// <param name="falseAction">The action to execute if any of the given values is false.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="parameter3">The third parameter to pass to the action with gets executed.</param>
        /// <param name="parameter4">The fourth parameter to pass to the action with gets executed.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfAnyFalse<T1, T2, T3, T4>( [NotNull] this Action<T1, T2, T3, T4> falseAction,
                                                              [CanBeNull] T1 parameter1,
                                                              [CanBeNull] T2 parameter2,
                                                              [CanBeNull] T3 parameter3,
                                                              [CanBeNull] T4 parameter4,
                                                              [CanBeNull] Action<T1, T2, T3, T4> trueAction = null,
                                                              [NotNull] params bool[] values )
        {
            falseAction.ThrowIfNull( nameof(falseAction) );
            values.ThrowIfNull( nameof(values) );

            if ( values.Any( x => !x ) )
                falseAction( parameter1, parameter2, parameter3, parameter4 );
            else
                trueAction?.Invoke( parameter1, parameter2, parameter3, parameter4 );
        }

        /// <summary>
        ///     Executes the specified action if one of the given Boolean values is false.
        /// </summary>
        /// <exception cref="ArgumentNullException">falseAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <param name="falseAction">The action to execute if any of the given values is false.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfAnyFalse( [NotNull] this Action falseAction, [NotNull] params bool[] values )
        {
            falseAction.ThrowIfNull( nameof(falseAction) );
            values.ThrowIfNull( nameof(values) );

            if ( values.All( x => x ) )
                return;

            falseAction();
        }

        /// <summary>
        ///     Executes the specified action if one of the given Boolean values is false.
        /// </summary>
        /// <exception cref="ArgumentNullException">falseAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <typeparam name="T">The type of the parameter.</typeparam>
        /// <param name="falseAction">The action to execute if any of the given values is false.</param>
        /// <param name="parameter">The parameter to pass to the action with gets executed.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfAnyFalse<T>( [NotNull] this Action<T> falseAction,
                                                 [CanBeNull] T parameter,
                                                 [NotNull] params bool[] values )
        {
            falseAction.ThrowIfNull( nameof(falseAction) );
            values.ThrowIfNull( nameof(values) );

            if ( values.All( x => x ) )
                return;

            falseAction( parameter );
        }

        /// <summary>
        ///     Executes the specified action if one of the given Boolean values is false.
        /// </summary>
        /// <exception cref="ArgumentNullException">falseAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <typeparam name="T1">The type of the first parameter.</typeparam>
        /// <typeparam name="T2">The type of the second parameter.</typeparam>
        /// <param name="falseAction">The action to execute if any of the given values is false.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfAnyFalse<T1, T2>( [NotNull] this Action<T1, T2> falseAction,
                                                      [CanBeNull] T1 parameter1,
                                                      [CanBeNull] T2 parameter2,
                                                      [NotNull] params bool[] values )
        {
            falseAction.ThrowIfNull( nameof(falseAction) );
            values.ThrowIfNull( nameof(values) );

            if ( values.All( x => x ) )
                return;

            falseAction( parameter1, parameter2 );
        }

        /// <summary>
        ///     Executes the specified action if one of the given Boolean values is false.
        /// </summary>
        /// <exception cref="ArgumentNullException">falseAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <typeparam name="T1">The type of the first parameter.</typeparam>
        /// <typeparam name="T2">The type of the second parameter.</typeparam>
        /// <typeparam name="T3">The type of the third parameter.</typeparam>
        /// <param name="falseAction">The action to execute if any of the given values is false.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="parameter3">The third parameter to pass to the action with gets executed.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfAnyFalse<T1, T2, T3>( [NotNull] this Action<T1, T2, T3> falseAction,
                                                          [CanBeNull] T1 parameter1,
                                                          [CanBeNull] T2 parameter2,
                                                          [CanBeNull] T3 parameter3,
                                                          [NotNull] params bool[] values )
        {
            falseAction.ThrowIfNull( nameof(falseAction) );
            values.ThrowIfNull( nameof(values) );

            if ( values.All( x => x ) )
                return;

            falseAction( parameter1, parameter2, parameter3 );
        }

        /// <summary>
        ///     Executes the specified action if one of the given Boolean values is false.
        /// </summary>
        /// <exception cref="ArgumentNullException">falseAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <typeparam name="T1">The type of the first parameter.</typeparam>
        /// <typeparam name="T2">The type of the second parameter.</typeparam>
        /// <typeparam name="T3">The type of the third parameter.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter.</typeparam>
        /// <param name="falseAction">The action to execute if any of the given values is false.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="parameter3">The third parameter to pass to the action with gets executed.</param>
        /// <param name="parameter4">The fourth parameter to pass to the action with gets executed.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfAnyFalse<T1, T2, T3, T4>( [NotNull] this Action<T1, T2, T3, T4> falseAction,
                                                              [CanBeNull] T1 parameter1,
                                                              [CanBeNull] T2 parameter2,
                                                              [CanBeNull] T3 parameter3,
                                                              [CanBeNull] T4 parameter4,
                                                              [NotNull] params bool[] values )
        {
            falseAction.ThrowIfNull( nameof(falseAction) );
            values.ThrowIfNull( nameof(values) );

            if ( values.All( x => x ) )
                return;

            falseAction( parameter1, parameter2, parameter3, parameter4 );
        }
        /// <summary>
        ///     Executes the specified action if one of the given Boolean values is true,
        ///     otherwise it executes the specified false action, if one is specified.
        /// </summary>
        /// <exception cref="ArgumentNullException">trueAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <param name="trueAction">The action to execute if one of the values is true.</param>
        /// <param name="falseAction">The action to execute if any of the given values is false.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfAnyTrue( [NotNull] this Action trueAction,
                                             [CanBeNull] Action falseAction = null,
                                             [NotNull] params bool[] values )
        {
            trueAction.ThrowIfNull( nameof(trueAction) );
            values.ThrowIfNull( nameof(values) );

            if ( values.Any( x => x ) )
                trueAction();
            else
                falseAction?.Invoke();
        }

        /// <summary>
        ///     Executes the specified action if one of the given Boolean values is true,
        ///     otherwise it executes the specified false action, if one is specified.
        /// </summary>
        /// <exception cref="ArgumentNullException">True action can not be null, if any value is true.</exception>
        /// <typeparam name="T">The type of the parameter.</typeparam>
        /// <param name="trueAction">The action to execute if one of the values is true.</param>
        /// <param name="falseAction">The action to execute if any of the given values is false.</param>
        /// <param name="parameter">The parameter to pass to the action with gets executed.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfAnyTrue<T>( [NotNull] this Action<T> trueAction,
                                                [CanBeNull] T parameter,
                                                [CanBeNull] Action<T> falseAction = null,
                                                [NotNull] params bool[] values )
        {
            trueAction.ThrowIfNull( nameof(trueAction) );
            values.ThrowIfNull( nameof(values) );

            if ( values.Any( x => x ) )
                trueAction( parameter );
            else
                falseAction?.Invoke( parameter );
        }

        /// <summary>
        ///     Executes the specified action if one of the given Boolean values is true,
        ///     otherwise it executes the specified false action, if one is specified.
        /// </summary>
        /// <exception cref="ArgumentNullException">True action can not be null, if any value is true.</exception>
        /// <typeparam name="T1">The type of the first parameter.</typeparam>
        /// <typeparam name="T2">The type of the second parameter.</typeparam>
        /// <param name="trueAction">The action to execute if one of the values is true.</param>
        /// <param name="falseAction">The action to execute if any of the given values is false.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfAnyTrue<T1, T2>( [NotNull] this Action<T1, T2> trueAction,
                                                     [CanBeNull] T1 parameter1,
                                                     [CanBeNull] T2 parameter2,
                                                     [CanBeNull] Action<T1, T2> falseAction = null,
                                                     [NotNull] params bool[] values )
        {
            trueAction.ThrowIfNull( nameof(trueAction) );
            values.ThrowIfNull( nameof(values) );

            if ( values.Any( x => x ) )
                trueAction( parameter1, parameter2 );
            else
                falseAction?.Invoke( parameter1, parameter2 );
        }

        /// <summary>
        ///     Executes the specified action if one of the given Boolean values is true,
        ///     otherwise it executes the specified false action, if one is specified.
        /// </summary>
        /// <exception cref="ArgumentNullException">True action can not be null, if any value is true.</exception>
        /// <typeparam name="T1">The type of the first parameter.</typeparam>
        /// <typeparam name="T2">The type of the second parameter.</typeparam>
        /// <typeparam name="T3">The type of the third parameter.</typeparam>
        /// <param name="trueAction">The action to execute if one of the values is true.</param>
        /// <param name="falseAction">The action to execute if any of the given values is false.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="parameter3">The third parameter to pass to the action with gets executed.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfAnyTrue<T1, T2, T3>( [NotNull] this Action<T1, T2, T3> trueAction,
                                                         [CanBeNull] T1 parameter1,
                                                         [CanBeNull] T2 parameter2,
                                                         [CanBeNull] T3 parameter3,
                                                         [CanBeNull] Action<T1, T2, T3> falseAction = null,
                                                         [NotNull] params bool[] values )
        {
            trueAction.ThrowIfNull( nameof(trueAction) );
            values.ThrowIfNull( nameof(values) );

            if ( values.Any( x => x ) )
                trueAction( parameter1, parameter2, parameter3 );
            else
                falseAction?.Invoke( parameter1, parameter2, parameter3 );
        }

        /// <summary>
        ///     Executes the specified action if one of the given Boolean values is true,
        ///     otherwise it executes the specified false action, if one is specified.
        /// </summary>
        /// <exception cref="ArgumentNullException">True action can not be null, if any value is true.</exception>
        /// <typeparam name="T1">The type of the first parameter.</typeparam>
        /// <typeparam name="T2">The type of the second parameter.</typeparam>
        /// <typeparam name="T3">The type of the third parameter.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter.</typeparam>
        /// <param name="trueAction">The action to execute if one of the values is true.</param>
        /// <param name="falseAction">The action to execute if any of the given values is false.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="parameter3">The third parameter to pass to the action with gets executed.</param>
        /// <param name="parameter4">The fourth parameter to pass to the action with gets executed.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfAnyTrue<T1, T2, T3, T4>( [NotNull] this Action<T1, T2, T3, T4> trueAction,
                                                             [CanBeNull] T1 parameter1,
                                                             [CanBeNull] T2 parameter2,
                                                             [CanBeNull] T3 parameter3,
                                                             [CanBeNull] T4 parameter4,
                                                             [CanBeNull] Action<T1, T2, T3, T4> falseAction = null,
                                                             [NotNull] params bool[] values )
        {
            trueAction.ThrowIfNull( nameof(trueAction) );
            values.ThrowIfNull( nameof(values) );

            if ( values.Any( x => x ) )
                trueAction( parameter1, parameter2, parameter3, parameter4 );
            else
                falseAction?.Invoke( parameter1, parameter2, parameter3, parameter4 );
        }

        /// <summary>
        ///     Executes the specified action if one of the given Boolean values is true.
        /// </summary>
        /// <exception cref="ArgumentNullException">True action can not be null, if any value is true.</exception>
        /// <param name="trueAction">The action to execute if one of the values is true.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfAnyTrue( [NotNull] this Action trueAction, [NotNull] params bool[] values )
        {
            trueAction.ThrowIfNull( nameof(trueAction) );
            values.ThrowIfNull( nameof(values) );

            if ( !values.Any( x => x ) )
                return;

            trueAction();
        }

        /// <summary>
        ///     Executes the specified action if one of the given Boolean values is true.
        /// </summary>
        /// <exception cref="ArgumentNullException">True action can not be null, if any value is true.</exception>
        /// <typeparam name="T">The type of the parameter.</typeparam>
        /// <param name="trueAction">The action to execute if one of the values is true.</param>
        /// <param name="parameter">The parameter to pass to the action with gets executed.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfAnyTrue<T>( [NotNull] this Action<T> trueAction,
                                                [CanBeNull] T parameter,
                                                [NotNull] params bool[] values )
        {
            trueAction.ThrowIfNull( nameof(trueAction) );
            values.ThrowIfNull( nameof(values) );

            if ( !values.Any( x => x ) )
                return;

            trueAction( parameter );
        }

        /// <summary>
        ///     Executes the specified action if one of the given Boolean values is true.
        /// </summary>
        /// <exception cref="ArgumentNullException">True action can not be null, if any value is true.</exception>
        /// <typeparam name="T1">The type of the first parameter.</typeparam>
        /// <typeparam name="T2">The type of the second parameter.</typeparam>
        /// <param name="trueAction">The action to execute if one of the values is true.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfAnyTrue<T1, T2>( [NotNull] this Action<T1, T2> trueAction,
                                                     [CanBeNull] T1 parameter1,
                                                     [CanBeNull] T2 parameter2,
                                                     [NotNull] params bool[] values )
        {
            trueAction.ThrowIfNull( nameof(trueAction) );
            values.ThrowIfNull( nameof(values) );

            if ( !values.Any( x => x ) )
                return;

            trueAction( parameter1, parameter2 );
        }

        /// <summary>
        ///     Executes the specified action if one of the given Boolean values is true.
        /// </summary>
        /// <exception cref="ArgumentNullException">True action can not be null, if any value is true.</exception>
        /// <typeparam name="T1">The type of the first parameter.</typeparam>
        /// <typeparam name="T2">The type of the second parameter.</typeparam>
        /// <typeparam name="T3">The type of the third parameter.</typeparam>
        /// <param name="trueAction">The action to execute if one of the values is true.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="parameter3">The third parameter to pass to the action with gets executed.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfAnyTrue<T1, T2, T3>( [NotNull] this Action<T1, T2, T3> trueAction,
                                                         [CanBeNull] T1 parameter1,
                                                         [CanBeNull] T2 parameter2,
                                                         [CanBeNull] T3 parameter3,
                                                         [NotNull] params bool[] values )
        {
            trueAction.ThrowIfNull( nameof(trueAction) );
            values.ThrowIfNull( nameof(values) );

            if ( !values.Any( x => x ) )
                return;

            trueAction( parameter1, parameter2, parameter3 );
        }

        /// <summary>
        ///     Executes the specified action if one of the given Boolean values is true.
        /// </summary>
        /// <exception cref="ArgumentNullException">True action can not be null, if any value is true.</exception>
        /// <typeparam name="T1">The type of the first parameter.</typeparam>
        /// <typeparam name="T2">The type of the second parameter.</typeparam>
        /// <typeparam name="T3">The type of the third parameter.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter.</typeparam>
        /// <param name="trueAction">The action to execute if one of the values is true.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="parameter3">The third parameter to pass to the action with gets executed.</param>
        /// <param name="parameter4">The fourth parameter to pass to the action with gets executed.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfAnyTrue<T1, T2, T3, T4>( [NotNull] this Action<T1, T2, T3, T4> trueAction,
                                                             [CanBeNull] T1 parameter1,
                                                             [CanBeNull] T2 parameter2,
                                                             [CanBeNull] T3 parameter3,
                                                             [CanBeNull] T4 parameter4,
                                                             [NotNull] params bool[] values )
        {
            trueAction.ThrowIfNull( nameof(trueAction) );
            values.ThrowIfNull( nameof(values) );

            if ( !values.Any( x => x ) )
                return;

            trueAction( parameter1, parameter2, parameter3, parameter4 );
        }
        /// <summary>
        ///     Executes the specified action if the given Boolean values are false,
        ///     otherwise it executes the specified true action, if one is specified.
        /// </summary>
        /// <exception cref="ArgumentNullException">falseAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <param name="trueAction">The action to execute if any of the given values is true.</param>
        /// <param name="falseAction">The action to execute if the given values are false.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfFalse( [NotNull] this Action falseAction, [CanBeNull] Action trueAction = null, [NotNull] params bool[] values )
        {
            falseAction.ThrowIfNull( nameof(falseAction) );
            values.ThrowIfNull( nameof(values) );

            if ( values.NotAny( x => x ) )
                falseAction();
            else
                trueAction?.Invoke();
        }

        /// <summary>
        ///     Executes the specified action if the given Boolean values are false,
        ///     otherwise it executes the specified true action, if one is specified.
        /// </summary>
        /// <exception cref="ArgumentNullException">falseAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <typeparam name="T">The type of the parameter.</typeparam>
        /// <param name="trueAction">The action to execute if any of the given values is true.</param>
        /// <param name="falseAction">The action to execute if the given values are false.</param>
        /// <param name="parameter">The parameter to pass to the action with gets executed.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfFalse<T>( [NotNull] this Action<T> falseAction,
                                              [CanBeNull] T parameter,
                                              [CanBeNull] Action<T> trueAction = null,
                                              [NotNull] params bool[] values )
        {
            falseAction.ThrowIfNull( nameof(falseAction) );
            values.ThrowIfNull( nameof(values) );

            if ( values.NotAny( x => x ) )
                falseAction( parameter );
            else
                trueAction?.Invoke( parameter );
        }

        /// <summary>
        ///     Executes the specified action if the given Boolean values are false,
        ///     otherwise it executes the specified true action, if one is specified.
        /// </summary>
        /// <exception cref="ArgumentNullException">falseAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <typeparam name="T1">The type of the first parameter.</typeparam>
        /// <typeparam name="T2">The type of the second parameter.</typeparam>
        /// <param name="trueAction">The action to execute if any of the given values is true.</param>
        /// <param name="falseAction">The action to execute if the given values are false.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfFalse<T1, T2>( [NotNull] this Action<T1, T2> falseAction,
                                                   [CanBeNull] T1 parameter1,
                                                   [CanBeNull] T2 parameter2,
                                                   [CanBeNull] Action<T1, T2> trueAction = null,
                                                   [NotNull] params bool[] values )
        {
            falseAction.ThrowIfNull( nameof(falseAction) );
            values.ThrowIfNull( nameof(values) );

            if ( values.NotAny( x => x ) )
                falseAction( parameter1, parameter2 );
            else
                trueAction?.Invoke( parameter1, parameter2 );
        }

        /// <summary>
        ///     Executes the specified action if the given Boolean values are false,
        ///     otherwise it executes the specified true action, if one is specified.
        /// </summary>
        /// <exception cref="ArgumentNullException">falseAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <typeparam name="T1">The type of the first parameter.</typeparam>
        /// <typeparam name="T2">The type of the second parameter.</typeparam>
        /// <typeparam name="T3">The type of the third parameter.</typeparam>
        /// <param name="trueAction">The action to execute if any of the given values is true.</param>
        /// <param name="falseAction">The action to execute if the given values are false.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="parameter3">The third parameter to pass to the action with gets executed.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfFalse<T1, T2, T3>( [NotNull] this Action<T1, T2, T3> falseAction,
                                                       [CanBeNull] T1 parameter1,
                                                       [CanBeNull] T2 parameter2,
                                                       [CanBeNull] T3 parameter3,
                                                       [CanBeNull] Action<T1, T2, T3> trueAction = null,
                                                       [NotNull] params bool[] values )
        {
            falseAction.ThrowIfNull( nameof(falseAction) );
            values.ThrowIfNull( nameof(values) );

            if ( values.NotAny( x => x ) )
                falseAction( parameter1, parameter2, parameter3 );
            else
                trueAction?.Invoke( parameter1, parameter2, parameter3 );
        }

        /// <summary>
        ///     Executes the specified action if the given Boolean values are false,
        ///     otherwise it executes the specified true action, if one is specified.
        /// </summary>
        /// <exception cref="ArgumentNullException">falseAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <typeparam name="T1">The type of the first parameter.</typeparam>
        /// <typeparam name="T2">The type of the second parameter.</typeparam>
        /// <typeparam name="T3">The type of the third parameter.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter.</typeparam>
        /// <param name="trueAction">The action to execute if any of the given values is true.</param>
        /// <param name="falseAction">The action to execute if the given values are false.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="parameter3">The third parameter to pass to the action with gets executed.</param>
        /// <param name="parameter4">The fourth parameter to pass to the action with gets executed.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfFalse<T1, T2, T3, T4>( [NotNull] this Action<T1, T2, T3, T4> falseAction,
                                                           [CanBeNull] T1 parameter1,
                                                           [CanBeNull] T2 parameter2,
                                                           [CanBeNull] T3 parameter3,
                                                           [CanBeNull] T4 parameter4,
                                                           [CanBeNull] Action<T1, T2, T3, T4> trueAction = null,
                                                           [NotNull] params bool[] values )
        {
            falseAction.ThrowIfNull( nameof(falseAction) );
            values.ThrowIfNull( nameof(values) );

            if ( values.NotAny( x => x ) )
                falseAction( parameter1, parameter2, parameter3, parameter4 );
            else
                trueAction?.Invoke( parameter1, parameter2, parameter3, parameter4 );
        }

        /// <summary>
        ///     Executes the specified action if the given Boolean values are false.
        /// </summary>
        /// <exception cref="ArgumentNullException">falseAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <param name="falseAction">The action to execute if the given values are false.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfFalse( [NotNull] this Action falseAction, [NotNull] params bool[] values )
        {
            falseAction.ThrowIfNull( nameof(falseAction) );
            values.ThrowIfNull( nameof(values) );

            if ( !values.NotAny( x => x ) )
                return;

            falseAction();
        }

        /// <summary>
        ///     Executes the specified action if the given Boolean values are false.
        /// </summary>
        /// <exception cref="ArgumentNullException">falseAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <typeparam name="T">The type of the parameter.</typeparam>
        /// <param name="falseAction">The action to execute if the given values are false.</param>
        /// <param name="parameter">The parameter to pass to the action with gets executed.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfFalse<T>( [NotNull] this Action<T> falseAction,
                                              [CanBeNull] T parameter,
                                              [NotNull] params bool[] values )
        {
            falseAction.ThrowIfNull( nameof(falseAction) );
            values.ThrowIfNull( nameof(values) );

            if ( !values.NotAny( x => x ) )
                return;

            falseAction( parameter );
        }

        /// <summary>
        ///     Executes the specified action if the given Boolean values are false.
        /// </summary>
        /// <exception cref="ArgumentNullException">falseAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <typeparam name="T1">The type of the first parameter.</typeparam>
        /// <typeparam name="T2">The type of the second parameter.</typeparam>
        /// <param name="falseAction">The action to execute if the given values are false.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfFalse<T1, T2>( [NotNull] this Action<T1, T2> falseAction,
                                                   [CanBeNull] T1 parameter1,
                                                   [CanBeNull] T2 parameter2,
                                                   [NotNull] params bool[] values )
        {
            falseAction.ThrowIfNull( nameof(falseAction) );
            values.ThrowIfNull( nameof(values) );

            if ( !values.NotAny( x => x ) )
                return;

            falseAction( parameter1, parameter2 );
        }

        /// <summary>
        ///     Executes the specified action if the given Boolean values are false.
        /// </summary>
        /// <exception cref="ArgumentNullException">falseAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <typeparam name="T1">The type of the first parameter.</typeparam>
        /// <typeparam name="T2">The type of the second parameter.</typeparam>
        /// <typeparam name="T3">The type of the third parameter.</typeparam>
        /// <param name="falseAction">The action to execute if the given values are false.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="parameter3">The third parameter to pass to the action with gets executed.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfFalse<T1, T2, T3>( [NotNull] this Action<T1, T2, T3> falseAction,
                                                       [CanBeNull] T1 parameter1,
                                                       [CanBeNull] T2 parameter2,
                                                       [CanBeNull] T3 parameter3,
                                                       [NotNull] params bool[] values )
        {
            falseAction.ThrowIfNull( nameof(falseAction) );
            values.ThrowIfNull( nameof(values) );

            if ( !values.NotAny( x => x ) )
                return;

            falseAction( parameter1, parameter2, parameter3 );
        }

        /// <summary>
        ///     Executes the specified action if the given Boolean values are false.
        /// </summary>
        /// <exception cref="ArgumentNullException">falseAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <typeparam name="T1">The type of the first parameter.</typeparam>
        /// <typeparam name="T2">The type of the second parameter.</typeparam>
        /// <typeparam name="T3">The type of the third parameter.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter.</typeparam>
        /// <param name="falseAction">The action to execute if the given values are false.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="parameter3">The third parameter to pass to the action with gets executed.</param>
        /// <param name="parameter4">The fourth parameter to pass to the action with gets executed.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfFalse<T1, T2, T3, T4>( [NotNull] this Action<T1, T2, T3, T4> falseAction,
                                                           [CanBeNull] T1 parameter1,
                                                           [CanBeNull] T2 parameter2,
                                                           [CanBeNull] T3 parameter3,
                                                           [CanBeNull] T4 parameter4,
                                                           [NotNull] params bool[] values )
        {
            falseAction.ThrowIfNull( nameof(falseAction) );
            values.ThrowIfNull( nameof(values) );

            if ( !values.NotAny( x => x ) )
                return;

            falseAction( parameter1, parameter2, parameter3, parameter4 );
        }
        /// <summary>
        ///     Executes the specified action if the given Boolean values are true,
        ///     otherwise it executes the specified false action, if one is specified.
        /// </summary>
        /// <exception cref="ArgumentNullException">trueAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <param name="trueAction">The action to execute if the given values are true.</param>
        /// <param name="falseAction">The action to execute if any of the given values is false.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfTrue( [NotNull] this Action trueAction, [CanBeNull] Action falseAction, [NotNull] params bool[] values )
        {
            trueAction.ThrowIfNull( nameof(trueAction) );
            values.ThrowIfNull( nameof(values) );

            if ( values.All( x => x ) )
                trueAction();
            else
                falseAction?.Invoke();
        }

        /// <summary>
        ///     Executes the specified action if the given Boolean values are true,
        ///     otherwise it executes the specified false action, if one is specified.
        /// </summary>
        /// <exception cref="ArgumentNullException">trueAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <typeparam name="T">The type of the parameter.</typeparam>
        /// <param name="trueAction">The action to execute if the given values are true.</param>
        /// <param name="parameter">The parameter to pass to the action with gets executed.</param>
        /// <param name="falseAction">The action to execute if any of the given values is false.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfTrue<T>( [NotNull] this Action<T> trueAction,
                                             [CanBeNull] T parameter,
                                             [CanBeNull] Action<T> falseAction,
                                             [NotNull] params bool[] values )
        {
            trueAction.ThrowIfNull( nameof(trueAction) );
            values.ThrowIfNull( nameof(values) );

            if ( values.All( x => x ) )
                trueAction( parameter );
            else
                falseAction?.Invoke( parameter );
        }

        /// <summary>
        ///     Executes the specified action if the given Boolean values are true,
        ///     otherwise it executes the specified false action, if one is specified.
        /// </summary>
        /// <exception cref="ArgumentNullException">trueAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <typeparam name="T1">The type of the first parameter.</typeparam>
        /// <typeparam name="T2">The type of the second parameter.</typeparam>
        /// <param name="trueAction">The action to execute if the given values are true.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="falseAction">The action to execute if any of the given values is false.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfTrue<T1, T2>( [NotNull] this Action<T1, T2> trueAction,
                                                  [CanBeNull] T1 parameter1,
                                                  [CanBeNull] T2 parameter2,
                                                  [CanBeNull] Action<T1, T2> falseAction,
                                                  [NotNull] params bool[] values )
        {
            trueAction.ThrowIfNull( nameof(trueAction) );
            values.ThrowIfNull( nameof(values) );

            if ( values.All( x => x ) )
                trueAction( parameter1, parameter2 );
            else
                falseAction?.Invoke( parameter1, parameter2 );
        }

        /// <summary>
        ///     Executes the specified action if the given Boolean values are true,
        ///     otherwise it executes the specified false action, if one is specified.
        /// </summary>
        /// <exception cref="ArgumentNullException">trueAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <typeparam name="T1">The type of the first parameter.</typeparam>
        /// <typeparam name="T2">The type of the second parameter.</typeparam>
        /// <typeparam name="T3">The type of the third parameter.</typeparam>
        /// <param name="trueAction">The action to execute if the given values are true.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="parameter3">The third parameter to pass to the action with gets executed.</param>
        /// <param name="falseAction">The action to execute if any of the given values is false.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfTrue<T1, T2, T3>( [NotNull] this Action<T1, T2, T3> trueAction,
                                                      [CanBeNull] T1 parameter1,
                                                      [CanBeNull] T2 parameter2,
                                                      [CanBeNull] T3 parameter3,
                                                      [CanBeNull] Action<T1, T2, T3> falseAction,
                                                      [NotNull] params bool[] values )
        {
            trueAction.ThrowIfNull( nameof(trueAction) );
            values.ThrowIfNull( nameof(values) );

            if ( values.All( x => x ) )
                trueAction( parameter1, parameter2, parameter3 );
            else
                falseAction?.Invoke( parameter1, parameter2, parameter3 );
        }

        /// <summary>
        ///     Executes the specified action if the given Boolean values are true,
        ///     otherwise it executes the specified false action, if one is specified.
        /// </summary>
        /// <exception cref="ArgumentNullException">trueAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <typeparam name="T1">The type of the first parameter.</typeparam>
        /// <typeparam name="T2">The type of the second parameter.</typeparam>
        /// <typeparam name="T3">The type of the third parameter.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter.</typeparam>
        /// <param name="trueAction">The action to execute if the given values are true.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="parameter3">The third parameter to pass to the action with gets executed.</param>
        /// <param name="parameter4">The fourth parameter to pass to the action with gets executed.</param>
        /// <param name="falseAction">The action to execute if any of the given values is false.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfTrue<T1, T2, T3, T4>( [NotNull] this Action<T1, T2, T3, T4> trueAction,
                                                          [CanBeNull] T1 parameter1,
                                                          [CanBeNull] T2 parameter2,
                                                          [CanBeNull] T3 parameter3,
                                                          [CanBeNull] T4 parameter4,
                                                          [CanBeNull] Action<T1, T2, T3, T4> falseAction,
                                                          [NotNull] params bool[] values )
        {
            trueAction.ThrowIfNull( nameof(trueAction) );
            values.ThrowIfNull( nameof(values) );

            if ( values.All( x => x ) )
                trueAction( parameter1, parameter2, parameter3, parameter4 );
            else
                falseAction?.Invoke( parameter1, parameter2, parameter3, parameter4 );
        }

        /// <summary>
        ///     Executes the specified action if the given Boolean values are true.
        /// </summary>
        /// <exception cref="ArgumentNullException">trueAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <param name="trueAction">The action to execute if the given values are true.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfTrue( [NotNull] this Action trueAction, [NotNull] params bool[] values )
        {
            trueAction.ThrowIfNull( nameof(trueAction) );
            values.ThrowIfNull( nameof(values) );

            if ( !values.All( x => x ) )
                return;

            trueAction();
        }

        /// <summary>
        ///     Executes the specified action if the given Boolean values are true.
        /// </summary>
        /// <exception cref="ArgumentNullException">trueAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <typeparam name="T">The type of the parameter.</typeparam>
        /// <param name="trueAction">The action to execute if the given values are true.</param>
        /// <param name="parameter">The parameter to pass to the action with gets executed.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfTrue<T>( [NotNull] this Action<T> trueAction,
                                             [CanBeNull] T parameter,
                                             [NotNull] params bool[] values )
        {
            trueAction.ThrowIfNull( nameof(trueAction) );
            values.ThrowIfNull( nameof(values) );

            if ( !values.All( x => x ) )
                return;

            trueAction( parameter );
        }

        /// <summary>
        ///     Executes the specified action if the given Boolean values are true.
        /// </summary>
        /// <exception cref="ArgumentNullException">trueAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <typeparam name="T1">The type of the first parameter.</typeparam>
        /// <typeparam name="T2">The type of the second parameter.</typeparam>
        /// <param name="trueAction">The action to execute if the given values are true.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfTrue<T1, T2>( [NotNull] this Action<T1, T2> trueAction,
                                                  [CanBeNull] T1 parameter1,
                                                  [CanBeNull] T2 parameter2,
                                                  [NotNull] params bool[] values )
        {
            trueAction.ThrowIfNull( nameof(trueAction) );
            values.ThrowIfNull( nameof(values) );

            if ( !values.All( x => x ) )
                return;

            trueAction( parameter1, parameter2 );
        }

        /// <summary>
        ///     Executes the specified action if the given Boolean values are true.
        /// </summary>
        /// <exception cref="ArgumentNullException">trueAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <typeparam name="T1">The type of the first parameter.</typeparam>
        /// <typeparam name="T2">The type of the second parameter.</typeparam>
        /// <typeparam name="T3">The type of the third parameter.</typeparam>
        /// <param name="trueAction">The action to execute if the given values are true.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="parameter3">The third parameter to pass to the action with gets executed.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfTrue<T1, T2, T3>( [NotNull] this Action<T1, T2, T3> trueAction,
                                                      [CanBeNull] T1 parameter1,
                                                      [CanBeNull] T2 parameter2,
                                                      [CanBeNull] T3 parameter3,
                                                      [NotNull] params bool[] values )
        {
            trueAction.ThrowIfNull( nameof(trueAction) );
            values.ThrowIfNull( nameof(values) );

            if ( !values.All( x => x ) )
                return;

            trueAction( parameter1, parameter2, parameter3 );
        }

        /// <summary>
        ///     Executes the specified action if the given Boolean values are true.
        /// </summary>
        /// <exception cref="ArgumentNullException">trueAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <typeparam name="T1">The type of the first parameter.</typeparam>
        /// <typeparam name="T2">The type of the second parameter.</typeparam>
        /// <typeparam name="T3">The type of the third parameter.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter.</typeparam>
        /// <param name="trueAction">The action to execute if the given values are true.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="parameter3">The third parameter to pass to the action with gets executed.</param>
        /// <param name="parameter4">The fourth parameter to pass to the action with gets executed.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfTrue<T1, T2, T3, T4>( [NotNull] this Action<T1, T2, T3, T4> trueAction,
                                                          [CanBeNull] T1 parameter1,
                                                          [CanBeNull] T2 parameter2,
                                                          [CanBeNull] T3 parameter3,
                                                          [CanBeNull] T4 parameter4,
                                                          [NotNull] params bool[] values )
        {
            trueAction.ThrowIfNull( nameof(trueAction) );
            values.ThrowIfNull( nameof(values) );

            if ( !values.All( x => x ) )
                return;

            trueAction( parameter1, parameter2, parameter3, parameter4 );
        }
        /// <summary>
        ///     Executes the given action inside of a try catch block and catches all exceptions.
        /// </summary>
        /// <exception cref="ArgumentNullException">action can not be null.</exception>
        /// <param name="action">The action to execute.</param>
        /// <returns>Returns true if the action was executed without an exception, otherwise false.</returns>
        [PublicAPI]
        public static bool SafeExecute( [NotNull] this Action action )
        {
            action.ThrowIfNull( nameof(action) );

            try
            {
                action();

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        ///     Executes the given action inside of a try catch block. Catches exceptions of the given type.
        /// </summary>
        /// <exception cref="ArgumentNullException">action can not be null.</exception>
        /// <typeparam name="TException">The type of the exception.</typeparam>
        /// <param name="action">The action to execute.</param>
        /// <returns>Returns true if the action was executed without an exception, otherwise false.</returns>
        [PublicAPI]
        public static bool SafeExecute<TException>( [NotNull] this Action action ) where TException : Exception
            => action.SafeExecute( typeof(TException) );

        /// <summary>
        ///     Executes the given action inside of a try catch block. Catches exceptions of the given types.
        /// </summary>
        /// <exception cref="ArgumentNullException">action can not be null.</exception>
        /// <typeparam name="TException1">The first exception type to catch.</typeparam>
        /// <typeparam name="TException2">The second exception type to catch.</typeparam>
        /// <param name="action">The action to execute.</param>
        /// <returns>Returns true if the action was executed without an exception, otherwise false.</returns>
        [PublicAPI]
        public static bool SafeExecute<TException1, TException2>( [NotNull] this Action action )
            where TException1 : Exception
            where TException2 : Exception
            => action.SafeExecute( typeof(TException1), typeof(TException2) );

        /// <summary>
        ///     Executes the given action inside of a try catch block. Catches exceptions of the given types.
        /// </summary>
        /// <exception cref="ArgumentNullException">action can not be null.</exception>
        /// <typeparam name="TException1">The first exception type to catch.</typeparam>
        /// <typeparam name="TException2">The second exception type to catch.</typeparam>
        /// <typeparam name="TException3">The third exception type to catch.</typeparam>
        /// <param name="action">The action to execute.</param>
        /// <returns>Returns true if the action was executed without an exception, otherwise false.</returns>
        [PublicAPI]
        public static bool SafeExecute<TException1, TException2, TException3>( [NotNull] this Action action )
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            => action.SafeExecute( typeof(TException1), typeof(TException2), typeof(TException3) );

        /// <summary>
        ///     Executes the given action inside of a try catch block. Catches exceptions of the given types.
        /// </summary>
        /// <exception cref="ArgumentNullException">action can not be null.</exception>
        /// <typeparam name="TException1">The first exception type to catch.</typeparam>
        /// <typeparam name="TException2">The second exception type to catch.</typeparam>
        /// <typeparam name="TException3">The third exception type to catch.</typeparam>
        /// <typeparam name="TException4">The fourth exception type to catch.</typeparam>
        /// <param name="action">The action to execute.</param>
        /// <returns>Returns true if the action was executed without an exception, otherwise false.</returns>
        [PublicAPI]
        public static bool SafeExecute<TException1, TException2, TException3, TException4>( [NotNull] this Action action )
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception
            => action.SafeExecute( typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4) );

        /// <summary>
        ///     Executes the given action inside of a try catch block. Catches all exception types contained in the given list of
        ///     exception types.
        /// </summary>
        /// <exception cref="ArgumentNullException">action can not be null.</exception>
        /// <exception cref="ArgumentNullException">exceptionsToCatch can not be null.</exception>
        /// <param name="action">The action to execute.</param>
        /// <param name="exceptionsToCatch">A list of exception types to catch.</param>
        /// <returns>Returns true if the action was executed without an exception, otherwise false.</returns>
        [PublicAPI]
        public static bool SafeExecute( [NotNull] this Action action, [NotNull] params Type[] exceptionsToCatch )
        {
            action.ThrowIfNull( nameof(action) );
            exceptionsToCatch.ThrowIfNull( nameof(exceptionsToCatch) );

            try
            {
                action();
                return true;
            }
            catch ( Exception ex )
            {
                if ( exceptionsToCatch.NotAny( x => x == ex.GetType() ) )
                    throw;
                return false;
            }
        }
        /// <summary>
        ///     Executes the given action inside of a try catch block and catches all exception expect the specified type.
        /// </summary>
        /// <exception cref="ArgumentNullException">action can not be null.</exception>
        /// <typeparam name="TException">The type of the exception to throw.</typeparam>
        /// <param name="action">The action to execute.</param>
        /// <returns>Returns true if the action was executed without an exception, otherwise false.</returns>
        [PublicAPI]
        public static bool SafeExecuteExcept<TException>( this Action action )
            where TException : Exception => action.SafeExecuteExcept( typeof(TException) );

        /// <summary>
        ///     Executes the given action inside of a try catch block and catches all exception expect the specified types.
        /// </summary>
        /// <exception cref="ArgumentNullException">action can not be null.</exception>
        /// <typeparam name="TException1">The first exception type to throw.</typeparam>
        /// <typeparam name="TException2">The second exception type to throw.</typeparam>
        /// <param name="action">The action to execute.</param>
        /// <returns>Returns true if the action was executed without an exception, otherwise false.</returns>
        public static bool SafeExecuteExcept<TException1, TException2>( this Action action )
            where TException1 : Exception
            where TException2 : Exception => action.SafeExecuteExcept( typeof(TException1), typeof(TException2) );

        /// <summary>
        ///     Executes the given action inside of a try catch block and catches all exception expect the specified types.
        /// </summary>
        /// <exception cref="ArgumentNullException">action can not be null.</exception>
        /// <typeparam name="TException1">The first exception type to throw.</typeparam>
        /// <typeparam name="TException2">The second exception type to throw.</typeparam>
        /// <typeparam name="TException3">The third exception type to throw.</typeparam>
        /// <param name="action">The action to execute.</param>
        /// <returns>Returns true if the action was executed without an exception, otherwise false.</returns>
        public static bool SafeExecuteExcept<TException1, TException2, TException3>( this Action action )
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception => action.SafeExecuteExcept( typeof(TException1), typeof(TException2), typeof(TException3) );

        /// <summary>
        ///     Executes the given action inside of a try catch block and catches all exception expect the specified types.
        /// </summary>
        /// <exception cref="ArgumentNullException">action can not be null.</exception>
        /// <typeparam name="TException1">The first exception type to throw.</typeparam>
        /// <typeparam name="TException2">The second exception type to throw.</typeparam>
        /// <typeparam name="TException3">The third exception type to throw.</typeparam>
        /// <typeparam name="TException4">The fourth exception type to throw.</typeparam>
        /// <param name="action">The action to execute.</param>
        /// <returns>Returns true if the action was executed without an exception, otherwise false.</returns>
        public static bool SafeExecuteExcept<TException1, TException2, TException3, TException4>( this Action action )
            where TException1 : Exception
            where TException2 : Exception
            where TException3 : Exception
            where TException4 : Exception => action.SafeExecuteExcept( typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4) );

        /// <summary>
        ///     Executes the given action inside of a try catch block and catches all exception expect the given ones.
        /// </summary>
        /// <exception cref="ArgumentNullException">action can not be null.</exception>
        /// <exception cref="ArgumentNullException">exceptionsToThrow can not be null.</exception>
        /// <param name="action">The action to execute.</param>
        /// <param name="exceptionsToThrow">The exceptions to throw.</param>
        /// <returns>Returns true if the action was executed without an exception, otherwise false.</returns>
        public static bool SafeExecuteExcept( this Action action, params Type[] exceptionsToThrow )
        {
            action.ThrowIfNull( nameof(action) );
            exceptionsToThrow.ThrowIfNull( nameof(exceptionsToThrow) );

            try
            {
                action();
                return true;
            }
            catch ( Exception ex )
            {
                if ( exceptionsToThrow.Any( x => x == ex.GetType() ) )
                    throw;
                return false;
            }
        }
    }
}