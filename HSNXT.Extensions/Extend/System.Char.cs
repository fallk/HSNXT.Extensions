using System;
using System.Collections.Generic;
using System.Reflection;
using HSNXT.JetBrains.Annotations;
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
        ///     Indicates whether the specified Unicode character is categorized as a decimal digit.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>True if the given char is a decimal digit, otherwise false.</returns>
        [PublicAPI]
        [Pure]
        public static bool IsDigit( this char c )
            => char.IsDigit( c );
        /// <summary>
        ///     Indicates whether the specified Unicode character is categorized as a Unicode letter.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>True if the given char is a letter, otherwise false.</returns>
        [PublicAPI]
        [Pure]
        public static bool IsLetter( this char c )
            => char.IsLetter( c );
        /// <summary>
        ///     Indicates whether the specified Unicode character is categorized as a letter or a decimal digit.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>True if the given char is a letter or a decimal digit, otherwise false.</returns>
        [PublicAPI]
        [Pure]
        public static bool IsLetterOrDigit( this char c )
            => char.IsLetterOrDigit( c );
        /// <summary>
        ///     Indicates whether the specified Unicode character is categorized as a lowercase letter.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>True if the given char is a lowercase letter, otherwise false.</returns>
        [PublicAPI]
        [Pure]
        public static bool IsLower( this char c )
            => char.IsLower( c );
        /// <summary>
        ///     Indicates whether the specified Unicode character is categorized as a number.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>True if the given char is a number, otherwise false.</returns>
        [PublicAPI]
        [Pure]
        public static bool IsNumber( this char c )
            => char.IsNumber( c );
        /// <summary>
        ///     Indicates whether the specified Unicode character is categorized as an uppercase letter.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>True if the given char is an uppercase letter, otherwise false.</returns>
        [PublicAPI]
        [Pure]
        public static bool IsUpper( this char c )
            => char.IsUpper( c );
        /// <summary>
        ///     Indicates whether the specified Unicode character is categorized as white space.
        /// </summary>
        /// <param name="c">The Unicode character to evaluate.</param>
        /// <returns>True if the given char is a white space, otherwise false.</returns>
        [PublicAPI]
        [Pure]
        public static bool IsWhiteSpace( this char c )
            => char.IsWhiteSpace( c );
        /// <summary>
        ///     Repeats the given Char the specified number of times.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">repeatCount is less than zero.</exception>
        /// <param name="c">The Char to repeat.</param>
        /// <param name="repeatCount">Number of repeats.</param>
        /// <returns>The repeated Char as String.</returns>
        [PublicAPI]
        [Pure]
        public static string Repeat( this char c, int repeatCount )
            => new string( c, repeatCount );
        /// <summary>
        ///     Converts the value of a Unicode character to its lowercase equivalent.
        /// </summary>
        /// <param name="c">The Unicode character to convert.</param>
        /// <returns>
        ///     The lowercase equivalent of <paramref name="c" />, or the unchanged value of <paramref name="c" />, if
        ///     <paramref name="c" /> is already lowercase or not alphabetic.
        /// </returns>
        [PublicAPI]
        [Pure]
        public static char ToLower( this char c )
            => char.ToLower( c );
        /// <summary>
        ///     Converts the value of a Unicode character to its uppercase equivalent.
        /// </summary>
        /// <param name="c">The Unicode character to convert.</param>
        /// <returns>
        ///     The uppercase equivalent of <paramref name="c" />, or the unchanged value of <paramref name="c" /> if
        ///     <paramref name="c" /> is already uppercase, has no uppercase equivalent, or is not alphabetic.
        /// </returns>
        [PublicAPI]
        [Pure]
        public static char ToUpper( this char c )
            => char.ToUpper( c );
    }
}