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
        ///     Gets whether a <see cref="Regex" /> with the specified pattern finds a match in the specified input
        ///     <see cref="String" />.
        /// </summary>
        /// <exception cref="ArgumentNullException">The input can not be null.</exception>
        /// <exception cref="ArgumentNullException">The pattern can not be null.</exception>
        /// <param name="input">The <see cref="String" /> to search for a match.</param>
        /// <param name="pattern">The regular expression pattern used by the <see cref="Regex" />.</param>
        /// <returns>A value of true if the regular expression finds a match, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean IsMatch( [NotNull] this String input, [NotNull] String pattern )
        {
            input.ThrowIfNull( nameof(input) );
            pattern.ThrowIfNull( nameof(pattern) );

            return Regex.IsMatch( input, pattern );
        }

        /// <summary>
        ///     Gets whether a <see cref="Regex" /> with the specified pattern finds a match in the specified input
        ///     <see cref="String" />.
        /// </summary>
        /// <exception cref="ArgumentNullException">The input can not be null.</exception>
        /// <exception cref="ArgumentNullException">The pattern can not be null.</exception>
        /// <param name="input">The <see cref="String" /> to search for a match.</param>
        /// <param name="pattern">The regular expression pattern used by the <see cref="Regex" />.</param>
        /// <param name="options">The regular expression options used by the <see cref="Regex" />.</param>
        /// <returns>A value of true if the regular expression finds a match, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean IsMatch( [NotNull] this String input, [NotNull] String pattern, RegexOptions options )
        {
            input.ThrowIfNull( nameof(input) );
            pattern.ThrowIfNull( nameof(pattern) );

            return Regex.IsMatch( input, pattern, options );
        }

        /// <summary>
        ///     Gets whether a <see cref="Regex" /> with the specified pattern finds a match in the specified input
        ///     <see cref="String" />.
        /// </summary>
        /// <exception cref="ArgumentNullException">The input can not be null.</exception>
        /// <exception cref="ArgumentNullException">The pattern can not be null.</exception>
        /// <param name="input">The <see cref="String" /> to search for a match.</param>
        /// <param name="pattern">The regular expression pattern used by the <see cref="Regex" />.</param>
        /// <param name="options">The regular expression options used by the <see cref="Regex" />.</param>
        /// <param name="timeOut">The timeout for the match operation.</param>
        /// <returns>A value of true if the regular expression finds a match, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean IsMatch( [NotNull] this String input, [NotNull] String pattern, RegexOptions options, TimeSpan timeOut )
        {
            input.ThrowIfNull( nameof(input) );
            pattern.ThrowIfNull( nameof(pattern) );

            return Regex.IsMatch( input, pattern, options, timeOut );
        }

        /// <summary>
        ///     Gets whether a <see cref="System.Text.RegularExpressions" /> with the specified pattern finds not a match in the
        ///     specified input <see cref="String" />.
        /// </summary>
        /// <exception cref="ArgumentNullException">The input can not be null.</exception>
        /// <exception cref="ArgumentNullException">The pattern can not be null.</exception>
        /// <param name="input">The <see cref="String" /> to search for a match.</param>
        /// <param name="pattern">The regular expression pattern used by the <see cref="Regex" />.</param>
        /// <returns>A value of true if the regular expression doesn't find a match, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean IsNotMatch( [NotNull] this String input, [NotNull] String pattern )
        {
            input.ThrowIfNull( nameof(input) );
            pattern.ThrowIfNull( nameof(pattern) );

            return !IsMatch( input, pattern );
        }

        /// <summary>
        ///     Gets whether a <see cref="Regex" /> with the specified pattern finds not a match in the specified input
        ///     <see cref="String" />.
        /// </summary>
        /// <exception cref="ArgumentNullException">The input can not be null.</exception>
        /// <exception cref="ArgumentNullException">The pattern can not be null.</exception>
        /// <param name="input">The <see cref="String" /> to search for a match.</param>
        /// <param name="pattern">The regular expression pattern used by the <see cref="Regex" />.</param>
        /// <param name="options">The regular expression options used by the <see cref="Regex" />.</param>
        /// <returns>A value of true if the regular expression doesn't find a match, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean IsNotMatch( [NotNull] this String input, [NotNull] String pattern, RegexOptions options )
        {
            input.ThrowIfNull( nameof(input) );
            pattern.ThrowIfNull( nameof(pattern) );

            return !IsMatch( input, pattern, options );
        }

        /// <summary>
        ///     Gets whether a <see cref="Regex" /> with the specified pattern finds not a match in the specified input
        ///     <see cref="String" />.
        /// </summary>
        /// <exception cref="ArgumentNullException">The input can not be null.</exception>
        /// <exception cref="ArgumentNullException">The pattern can not be null.</exception>
        /// <param name="input">The <see cref="String" /> to search for a match.</param>
        /// <param name="pattern">The regular expression pattern used by the <see cref="Regex" />.</param>
        /// <param name="options">The regular expression options used by the <see cref="Regex" />.</param>
        /// <param name="timeOut">The timeout for the match operation.</param>
        /// <returns>A value of true if the regular expression doesn't find a match, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean IsNotMatch( [NotNull] this String input, [NotNull] String pattern, RegexOptions options, TimeSpan timeOut )
        {
            input.ThrowIfNull( nameof(input) );
            pattern.ThrowIfNull( nameof(pattern) );

            return !IsMatch( input, pattern, options, timeOut );
        }

        /// <summary>
        ///     Searches the specified input string for the first occurrence of the specified regular expression.
        /// </summary>
        /// <exception cref="ArgumentNullException">input can not be null.</exception>
        /// <exception cref="ArgumentNullException">pattern can not be null.</exception>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <returns>An object that contains information about the match.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static Match Match( [NotNull] this String input, [NotNull] String pattern )
        {
            input.ThrowIfNull( nameof(input) );
            input.ThrowIfNull( nameof(pattern) );

            return Regex.Match( input, pattern );
        }

        /// <summary>
        ///     Searches the input string for the first occurrence of the specified regular expression, using the specified
        ///     matching options.
        /// </summary>
        /// <exception cref="ArgumentNullException">input can not be null.</exception>
        /// <exception cref="ArgumentNullException">pattern can not be null.</exception>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
        /// <returns>An object that contains information about the match.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static Match Match( [NotNull] this String input, [NotNull] String pattern, RegexOptions options )
        {
            input.ThrowIfNull( nameof(input) );
            input.ThrowIfNull( nameof(pattern) );

            return Regex.Match( input, pattern, options );
        }

        /// <summary>
        ///     Searches the input string for the first occurrence of the specified regular expression, using the specified
        ///     matching options.
        /// </summary>
        /// <exception cref="ArgumentNullException">input can not be null.</exception>
        /// <exception cref="ArgumentNullException">pattern can not be null.</exception>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
        /// <param name="timeOut">The timeout for the regular expression operation.</param>
        /// <returns>An object that contains information about the match.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static Match Match( [NotNull] this String input, [NotNull] String pattern, RegexOptions options, TimeSpan timeOut )
        {
            input.ThrowIfNull( nameof(input) );
            input.ThrowIfNull( nameof(pattern) );
            timeOut.ThrowIfNull( nameof(timeOut) );

            return Regex.Match( input, pattern, options, timeOut );
        }

        /// <summary>
        ///     Searches the specified input string for all occurrences of a specified regular expression.
        /// </summary>
        /// <exception cref="ArgumentNullException">input can not be null.</exception>
        /// <exception cref="ArgumentNullException">pattern can not be null.</exception>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <returns>
        ///     A collection of the  objects found by the search. If no matches are found, the method returns an empty
        ///     collection object.
        /// </returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static MatchCollection Matches( [NotNull] this String input, [NotNull] String pattern )
        {
            input.ThrowIfNull( nameof(input) );
            pattern.ThrowIfNull( nameof(pattern) );

            return Regex.Matches( input, pattern );
        }

        /// <summary>
        ///     Searches the specified input string for all occurrences of a specified regular expression, using the
        ///     specified matching options.
        /// </summary>
        /// <exception cref="ArgumentNullException">input can not be null.</exception>
        /// <exception cref="ArgumentNullException">pattern can not be null.</exception>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <param name="options">A bitwise combination of the enumeration values that specify options for matching.</param>
        /// <returns>
        ///     A collection of the  objects found by the search. If no matches are found, the method returns an empty
        ///     collection object.
        /// </returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static MatchCollection Matches( [NotNull] this String input, [NotNull] String pattern, RegexOptions options )
        {
            input.ThrowIfNull( nameof(input) );
            pattern.ThrowIfNull( nameof(pattern) );

            return Regex.Matches( input, pattern, options );
        }

        /// <summary>
        ///     Searches the specified input string for all occurrences of a specified regular expression, using the
        ///     specified matching options.
        /// </summary>
        /// <exception cref="ArgumentNullException">input can not be null.</exception>
        /// <exception cref="ArgumentNullException">pattern can not be null.</exception>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <param name="options">A bitwise combination of the enumeration values that specify options for matching.</param>
        /// <param name="timeOut">The timeout for the regular expression operation.</param>
        /// <returns>
        ///     A collection of the  objects found by the search. If no matches are found, the method returns an empty
        ///     collection object.
        /// </returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static MatchCollection Matches( [NotNull] this String input, [NotNull] String pattern, RegexOptions options, TimeSpan timeOut )
        {
            input.ThrowIfNull( nameof(input) );
            pattern.ThrowIfNull( nameof(pattern) );
            timeOut.ThrowIfNull( nameof(timeOut) );

            return Regex.Matches( input, pattern, options, timeOut );
        }
    }
}