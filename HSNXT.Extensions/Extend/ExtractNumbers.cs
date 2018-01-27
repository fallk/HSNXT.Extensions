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
        ///     Extracts all Decimals from the given string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Invalid start index.</exception>
        /// <param name="value">The string to extract the decimals from.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <returns>The extracted decimals.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static List<decimal> ExtractAllDecimal( [NotNull] this string value, int startIndex = 0 )
            => new List<decimal>( ExtractAllFloatingNumbers( value, startIndex )
                                      .Select( x => x.ToDecimal() ) );

        /// <summary>
        ///     Extracts all Doubles from the given string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Invalid start index.</exception>
        /// <param name="value">The string to extract the doubles from.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <returns>The extracted doubles.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static List<double> ExtractAllDouble( [NotNull] this string value, int startIndex = 0 )
            => new List<double>( ExtractAllFloatingNumbers( value, startIndex )
                                     .Select( x => x.ToDouble() ) );

        /// <summary>
        ///     Extracts all Int16 from the given string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Invalid start index.</exception>
        /// <param name="value">The string to extract the decimal from.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <returns>The extracted Int16.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static List<short> ExtractAllInt16( [NotNull] this string value, int startIndex = 0 )
            => new List<short>( ExtractAllNumbers( value, startIndex )
                                    .Select( x => x.ToInt16() ) );

        /// <summary>
        ///     Extracts all Int32 from the given string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Invalid start index.</exception>
        /// <param name="value">The string to extract the decimal from.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <returns>The extracted Int32.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static List<int> ExtractAllInt32( [NotNull] this string value, int startIndex = 0 )
            => new List<int>( ExtractAllNumbers( value, startIndex )
                                    .Select( x => x.ToInt32() ) );

        /// <summary>
        ///     Extracts all Int64 from the given string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Invalid start index.</exception>
        /// <param name="value">The string to extract the decimal from.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <returns>The extracted Int64.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static List<long> ExtractAllInt64( [NotNull] this string value, int startIndex = 0 )
            => new List<long>( ExtractAllNumbers( value, startIndex )
                                    .Select( x => x.ToInt64() ) );

        /// <summary>
        ///     Extracts the first Decimal from the given string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Invalid start index.</exception>
        /// <param name="value">The string to extract the decimal from.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <returns>The extracted decimal.</returns>
        [Pure]
        [PublicAPI]
        public static decimal ExtractFirstDecimal( [NotNull] this string value, int startIndex = 0 )
            => ExtractFloatingNumber( value, startIndex )
                .ToDecimal();

        /// <summary>
        ///     Extracts the first double from the given string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Invalid start index.</exception>
        /// <param name="value">The string to extract the decimal from.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <returns>The extracted double.</returns>
        [Pure]
        [PublicAPI]
        public static double ExtractFirstDouble( [NotNull] this string value, int startIndex = 0 )
            => ExtractFloatingNumber( value, startIndex )
                .ToDouble();

        /// <summary>
        ///     Extracts the first Int16 from the given string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Invalid start index.</exception>
        /// <param name="value">The string to extract the decimal from.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <returns>The extracted Int16.</returns>
        [Pure]
        [PublicAPI]
        public static short ExtractFirstInt16( [NotNull] this string value, int startIndex = 0 )
            => ExtractNumber( value, startIndex )
                .ToInt16();

        /// <summary>
        ///     Extracts the first Int32 from the given string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Invalid start index.</exception>
        /// <param name="value">The string to extract the decimal from.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <returns>The extracted Int32.</returns>
        [Pure]
        [PublicAPI]
        public static int ExtractFirstInt32( [NotNull] this string value, int startIndex = 0 )
            => ExtractNumber( value, startIndex )
                .ToInt32();

        /// <summary>
        ///     Extracts the first Int64 from the given string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Invalid start index.</exception>
        /// <param name="value">The string to extract the decimal from.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <returns>The extracted Int64.</returns>
        [Pure]
        [PublicAPI]
        public static long ExtractFirstInt64( [NotNull] this string value, int startIndex = 0 )
            => ExtractNumber( value, startIndex )
                .ToInt64();

        /// <summary>
        ///     Extracts all floating point numbers from the given string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Invalid start index.</exception>
        /// <param name="value">The string to extract the decimal from.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <returns>The extracted floating point numbers as strings.</returns>
        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        [NotNull]
        [Pure]
        [PublicAPI]
        private static List<string> ExtractAllFloatingNumbers( [NotNull] this string value, int startIndex = 0 )
        {
            value.ThrowIfNull( nameof(value) );

            if ( startIndex >= value.Length || startIndex < 0 )
                throw new ArgumentOutOfRangeException( nameof(value), "Invalid start index." );

            var chars = value.Substring( startIndex )
                             .ToCharArray();
            var decimals = new List<string>();

            var sb = new StringBuilder();
            for ( var i = 0; i < chars.Length; i++ )
                if ( chars[i]
                    .IsDigit() )
                {
                    if ( sb.Length == 0 && i > 0 && chars[i - 1] == '-' )
                        sb.Append( '-' );
                    sb.Append( chars[i] );
                }
                else if ( chars[i] == '.' && !sb.ToString()
                                                .Contains( "." ) && sb.Length > 0 )
                    sb.Append( '.' );
                else if ( sb.Length > 0 )
                {
                    decimals.Add( sb.ToString() );
                    sb.Clear();
                }
            if ( sb.Length > 0 )
                decimals.Add( sb.ToString() );

            return decimals;
        }

        /// <summary>
        ///     Extracts all numbers from the given string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Invalid start index.</exception>
        /// <param name="value">The string to extract the decimal from.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <returns>The extracted numbers as string.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        private static List<string> ExtractAllNumbers( [NotNull] this string value, int startIndex = 0 )
        {
            value.ThrowIfNull( nameof(value) );

            if ( startIndex >= value.Length || startIndex < 0 )
                throw new ArgumentOutOfRangeException( nameof(value), "Invalid start index." );

            var chars = value.Substring( startIndex )
                             .ToCharArray();
            var numbers = new List<string>();

            var sb = new StringBuilder();
            for ( var i = 0; i < chars.Length; i++ )
                if ( chars[i]
                    .IsDigit() )
                {
                    if ( sb.Length == 0 && i > 0 && chars[i - 1] == '-' )
                        sb.Append( '-' );
                    sb.Append( chars[i] );
                }
                else if ( sb.Length > 0 )
                {
                    numbers.Add( sb.ToString() );
                    sb.Clear();
                }
            if ( sb.Length > 0 )
                numbers.Add( sb.ToString() );

            return numbers;
        }

        /// <summary>
        ///     Extracts the first floating point number from the given string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Invalid start index.</exception>
        /// <param name="value">The string to extract the number from.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <returns>The extracted floating point number as string.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        private static string ExtractFloatingNumber( [NotNull] this string value, int startIndex = 0 )
        {
            value.ThrowIfNull( nameof(value) );

            if ( startIndex >= value.Length || startIndex < 0 )
                throw new ArgumentOutOfRangeException( nameof(value), "Invalid start index." );

            var chars = value.Substring( startIndex )
                             .ToCharArray();
            var sb = new StringBuilder();

            for ( var i = 0; i < chars.Length; i++ )
                if ( chars[i]
                    .IsDigit() )
                {
                    if ( sb.Length == 0 && i > 0 && chars[i - 1] == '-' )
                        sb.Append( '-' );
                    sb.Append( chars[i] );
                }
                else if ( chars[i] == '.' && !sb.ToString()
                                                .Contains( "." ) && sb.Length > 0 )
                    sb.Append( '.' );
                else if ( sb.Length > 0 )
                    break;

            return sb.ToString();
        }

        /// <summary>
        ///     Extracts the first none floating point number from the given string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Invalid start index.</exception>
        /// <param name="value">The string to extract the number from.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <returns>The extracted number as string.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        private static string ExtractNumber( [NotNull] this string value, int startIndex = 0 )
        {
            value.ThrowIfNull( nameof(value) );

            if ( startIndex >= value.Length || startIndex < 0 )
                throw new ArgumentOutOfRangeException( nameof(value), "Invalid start index." );

            var chars = value.Substring( startIndex )
                             .ToCharArray();
            var sb = new StringBuilder();

            for ( var i = 0; i < chars.Length; i++ )
                if ( chars[i]
                    .IsDigit() )
                {
                    if ( sb.Length == 0 && i > 0 && chars[i - 1] == '-' )
                        sb.Append( '-' );
                    sb.Append( chars[i] );
                }
                else if ( sb.Length > 0 )
                    break;

            return sb.ToString();
        }
    }
}