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
        ///     Appends the given text to the string.
        ///     Adds a newline before <paramref name="append" />, if <paramref name="target" /> is not null.
        /// </summary>
        /// <param name="target">The string to append to.</param>
        /// <param name="append">The string to append.</param>
        /// <param name="newLine">The new line string to use.</param>
        /// <returns>Returns the concatenated string.</returns>
        [Pure]
        [PublicAPI]
        public static string AppendWithNewLineIfNotEmpty( [CanBeNull] this string target, [CanBeNull] string append, string newLine = null )
        {
            newLine = newLine ?? Environment.NewLine;

            if ( target.IsNotEmpty() )
                target += newLine;

            return target + append;
        }
        /// <summary>
        ///     Returns an object of the specified type and whose value is equivalent to
        ///     the specified object.
        /// </summary>
        /// <exception cref="ArgumentNullException">type can not be null.</exception>
        /// <exception cref="OverflowException">value represents a number that is out of the range of conversionType.</exception>
        /// <exception cref="FormatException">value is not in a format recognized by conversionType.</exception>
        /// <exception cref="InvalidCastException">
        ///     This conversion is not supported. -or-value is null and conversionType is
        ///     a value type.-or-value does not implement the System.IConvertible interface.
        /// </exception>
        /// <param name="value">An object that implements the System.IConvertible interface.</param>
        /// <param name="type">The type of object to return.</param>
        /// <returns>
        ///     An object whose type is conversionType and whose value is equivalent to value.-or-A
        ///     null reference (Nothing in Visual Basic), if value is null and conversionType
        ///     is not a value type.
        /// </returns>
        [Pure]
        [PublicAPI]
        public static object ChangeType( [CanBeNull] this string value, [NotNull] Type type )
            => value.ChangeType( type, CultureInfo.InvariantCulture );

        /// <summary>
        ///     Returns an object of the specified type and whose value is equivalent to
        ///     the specified object.
        /// </summary>
        /// <exception cref="ArgumentNullException">type can not be null.</exception>
        /// <exception cref="ArgumentNullException">formatProvider can not be null.</exception>
        /// <exception cref="OverflowException">value represents a number that is out of the range of conversionType.</exception>
        /// <exception cref="FormatException">value is not in a format recognized by conversionType.</exception>
        /// <exception cref="InvalidCastException">
        ///     This conversion is not supported. -or-value is null and conversionType is
        ///     a value type.-or-value does not implement the System.IConvertible interface.
        /// </exception>
        /// <param name="value">An object that implements the System.IConvertible interface.</param>
        /// <param name="type">The type of object to return.</param>
        /// <param name="formatProvider"> An object that supplies culture-specific formatting information.</param>
        /// <returns>
        ///     An object whose type is conversionType and whose value is equivalent to value.-or-A
        ///     null reference (Nothing in Visual Basic), if value is null and conversionType
        ///     is not a value type.
        /// </returns>
        [Pure]
        [PublicAPI]
        public static object ChangeType( [CanBeNull] this string value, [NotNull] Type type, [NotNull] IFormatProvider formatProvider )
        {
            type.ThrowIfNull( nameof(type) );
            formatProvider.ThrowIfNull( nameof(formatProvider) );

            return Convert.ChangeType( value, type, formatProvider );
        }

        /// <summary>
        ///     Returns an object of the specified type and whose value is equivalent to
        ///     the specified object.
        /// </summary>
        /// <typeparam name="T">The target type.</typeparam>
        /// <exception cref="OverflowException">value represents a number that is out of the range of conversionType.</exception>
        /// <exception cref="FormatException">value is not in a format recognized by conversionType.</exception>
        /// <exception cref="InvalidCastException">
        ///     This conversion is not supported. -or-value is null and conversionType is
        ///     a value type.-or-value does not implement the System.IConvertible interface.
        /// </exception>
        /// <param name="value">An object that implements the System.IConvertible interface.</param>
        /// <returns>
        ///     An object whose type is conversionType and whose value is equivalent to value.-or-A
        ///     null reference (Nothing in Visual Basic), if value is null and conversionType
        ///     is not a value type.
        /// </returns>
        [Pure]
        [PublicAPI]
        public static T ChangeType<T>( [CanBeNull] this string value )
            => (T) Convert.ChangeType( value, typeof(T) );

        /// <summary>
        ///     Returns an object of the specified type and whose value is equivalent to
        ///     the specified object.
        /// </summary>
        /// <typeparam name="T">The target type.</typeparam>
        /// <exception cref="ArgumentNullException">type can not be null.</exception>
        /// <exception cref="ArgumentNullException">formatProvider can not be null.</exception>
        /// <exception cref="OverflowException">value represents a number that is out of the range of conversionType.</exception>
        /// <exception cref="FormatException">value is not in a format recognized by conversionType.</exception>
        /// <exception cref="InvalidCastException">
        ///     This conversion is not supported. -or-value is null and conversionType is
        ///     a value type.-or-value does not implement the System.IConvertible interface.
        /// </exception>
        /// <param name="value">An object that implements the System.IConvertible interface.</param>
        /// <param name="formatProvider"> An object that supplies culture-specific formatting information.</param>
        /// <returns>
        ///     An object whose type is conversionType and whose value is equivalent to value.-or-A
        ///     null reference (Nothing in Visual Basic), if value is null and conversionType
        ///     is not a value type.
        /// </returns>
        [Pure]
        [PublicAPI]
        public static T ChangeType<T>( [CanBeNull] this string value, [NotNull] IFormatProvider formatProvider )
        {
            formatProvider.ThrowIfNull( nameof(formatProvider) );

            return (T) Convert.ChangeType( value, typeof(T), formatProvider );
        }
        /// <summary>
        ///     Gets the character of the given string at the specified position.
        /// </summary>
        /// <exception cref="ArgumentNullException">value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">The given index is out of range.</exception>
        /// <param name="value">The string.</param>
        /// <param name="index">The index.</param>
        /// <returns>Returns the character at the specified position.</returns>
        [Pure]
        [PublicAPI]
        public static char CharAt( [NotNull] this string value, int index )
        {
            value.ThrowIfNull( nameof(value) );

            if ( index < 0 || value.Length <= index )
                throw new ArgumentOutOfRangeException( nameof(index), index, "The given index is out of range." );

            return value[index];
        }
        /// <summary>
        ///     Compares the given strings using <see cref="StringComparison.OrdinalIgnoreCase" />.
        /// </summary>
        /// <param name="value">The first string to compare.</param>
        /// <param name="compareValue">The second string to compare.</param>
        /// <returns>Returns true if the given strings are equals, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static bool CompareOrdinalIgnoreCase( [CanBeNull] this string value, [CanBeNull] string compareValue )
            => string.Compare( value, compareValue, StringComparison.OrdinalIgnoreCase ) == 0;
        /// <summary>
        ///     Concatenates all given strings.
        /// </summary>
        /// <exception cref="ArgumentNullException">strings can not be null.</exception>
        /// <param name="str">The first string to concatenate.</param>
        /// <param name="strings">All strings to concatenate.</param>
        /// <returns>The concatenation of all strings.</returns>
        [Pure]
        [NotNull]
        [PublicAPI]
        public static string ConcatAll( this string str, [NotNull] params string[] strings )
        {
            strings.ThrowIfNull( nameof(strings) );

            return string.Concat( str, string.Concat( strings ) );
        }

        /// <summary>
        ///     Concatenates all given strings.
        /// </summary>
        /// <exception cref="ArgumentNullException">strings can not be null.</exception>
        /// <param name="strings">All strings to concatenate.</param>
        /// <returns>The concatenation of all strings.</returns>
        [Pure]
        [NotNull]
        [PublicAPI]
        public static string ConcatAll( [NotNull] this string[] strings )
        {
            strings.ThrowIfNull( nameof(strings) );

            return string.Concat( strings );
        }

        /// <summary>
        ///     Concatenates all given values.
        /// </summary>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <param name="str">The first string to concatenate.</param>
        /// <param name="values">All values to concatenate.</param>
        /// <returns>The concatenation of all values.</returns>
        [Pure]
        [NotNull]
        [PublicAPI]
        public static string ConcatAll( this string str, [NotNull] params object[] values )
        {
            values.ThrowIfNull( nameof(values) );

            return string.Concat( str, string.Concat( values ) );
        }

        /// <summary>
        ///     Concatenates all given values.
        /// </summary>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <param name="values">All values to concatenate.</param>
        /// <returns>The concatenation of all values.</returns>
        [Pure]
        [NotNull]
        [PublicAPI]
        public static string ConcatAll( [NotNull] this object[] values )
        {
            values.ThrowIfNull( nameof(values) );

            return string.Concat( values );
        }
    }
}




namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Extracts all numbers of the input string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string can not be null.</exception>
        /// <param name="str">The string to extract the numbers from.</param>
        /// <returns>The extracted numbers.</returns>
        [Pure]
        [NotNull]
        [PublicAPI]
        public static string ExtractNumbers( [NotNull] this string str )
        {
            str.ThrowIfNull( nameof(str) );

            return new string( str.ToCharArray()
                                  .Where( x => x.IsNumber() )
                                  .ToArray() );
        }
        /// <summary>
        ///     Replaces the format item in a specified <see cref="String" /> with the <see cref="String" /> representation of a
        ///     corresponding <see cref="Object" /> in a specified array.
        /// </summary>
        /// <exception cref="ArgumentNullException">The format string can not be null.</exception>
        /// <exception cref="ArgumentNullException">The arguments can not be null.</exception>
        /// <exception cref="FormatException">
        ///     Format is invalid.-or- The index of a format item is less than zero, or greater than
        ///     or equal to the length of the args array.
        /// </exception>
        /// <param name="format">The <see cref="String" /> containing the format items.</param>
        /// <param name="args">The array containing all the corresponding values.</param>
        /// <returns>
        ///     A copy of format in which the format items have been replaced by the <see cref="String"></see>
        ///     representation of the corresponding objects in <paramref name="args" />.
        /// </returns>
        [StringFormatMethod( "format" )]
        [Pure]
        [NotNull]
        [PublicAPI]
        public static string F( [NotNull] this string format, [NotNull] params object[] args )
        {
            format.ThrowIfNull( nameof(format) );
            args.ThrowIfNull( nameof(args) );

            return string.Format( format, args );
        }

        /// <summary>
        ///     Replaces the format item in a specified <see cref="String" /> with the <see cref="String" /> representation of a
        ///     corresponding <see cref="Object" /> in a specified array.
        /// </summary>
        /// <exception cref="ArgumentNullException">The format string can not be null.</exception>
        /// <exception cref="ArgumentNullException">The arguments can not be null.</exception>
        /// <exception cref="FormatException">
        ///     Format is invalid.-or- The index of a format item is less than zero, or greater than
        ///     or equal to the length of the args array.
        /// </exception>
        /// <param name="format">The <see cref="String" /> containing the format items.</param>
        /// <param name="args">The array containing all the corresponding values.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns>
        ///     A copy of format in which the format items have been replaced by the <see cref="String"></see>
        ///     representation of the corresponding objects in <paramref name="args" />.
        /// </returns>
        [StringFormatMethod( "format" )]
        [Pure]
        [NotNull]
        [PublicAPI]
        public static string F( [NotNull] this string format, [NotNull] IFormatProvider formatProvider, [NotNull] params object[] args )
        {
            format.ThrowIfNull( nameof(format) );
            formatProvider.ThrowIfNull( nameof(formatProvider) );
            args.ThrowIfNull( nameof(args) );

            return string.Format( formatProvider, format, args );
        }
        /// <summary>
        ///     Formats the given file extension.
        /// </summary>
        /// <remarks>
        ///     Formatted extension will have the following format: ".txt".
        /// </remarks>
        /// <param name="fileExtension">The file extension to format.</param>
        /// <exception cref="ArgumentNullException">The file extension can not be null.</exception>
        /// <exception cref="ArgumentException">Can not format a empty string to a file extension.</exception>
        /// <returns>The correct formatted file extension.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static string FormatFileExtension( [NotNull] this string fileExtension )
        {
            fileExtension.ThrowIfNull( nameof(fileExtension) );

            if ( fileExtension.IsEmpty() )
                throw new ArgumentException( "Can not format a empty string to a file extension.", nameof(fileExtension) );

            if ( !fileExtension.StartsWith( ".", StringComparison.Ordinal ) )
                fileExtension = fileExtension.Insert( 0, "." );
            return fileExtension.ToLower();
        }
        /// <summary>
        ///     Gets the part of the string after the specified value, starting at the given start index.
        /// </summary>
        /// <exception cref="ArgumentNullException">s can not be null.</exception>
        /// <exception cref="ArgumentNullException">value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">The specified start index is invalid.</exception>
        /// <param name="s">The input string.</param>
        /// <param name="value">The value to search.</param>
        /// <param name="startIndex">The start index of the substring.</param>
        /// <returns>The string after the specified value.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static string GetAfter( [NotNull] this string s, [NotNull] string value, int startIndex = 0 )
        {
            s.ThrowIfNull( nameof(s) );

            return s.GetAfter( value, startIndex, s.Length - startIndex );
        }

        /// <summary>
        ///     Gets the part of the string after the specified value, starting at the given start index
        ///     and ending after the specified number of characters.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string can not be null.</exception>
        /// <exception cref="ArgumentNullException">value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">The specified range is invalid.</exception>
        /// <param name="s">The input string.</param>
        /// <param name="value">The value to search.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <param name="length">The length of the string, from the start index.</param>
        /// <returns>The string after the specified value.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static string GetAfter( [NotNull] this string s, [NotNull] string value, int startIndex, int length )
        {
            s.ThrowIfNull( nameof(s) );
            value.ThrowIfNull( nameof(value) );

            if ( startIndex < 0 || length < 0 || startIndex + length > s.Length )
                throw new ArgumentOutOfRangeException( nameof(length), "The specified range is invalid." );

            s = s.Substring( startIndex, length );
            return !s.Contains( value )
                ? string.Empty
                : s.Substring( s.IndexOf( value, StringComparison.Ordinal ) + value.Length );
        }

        /// <summary>
        ///     Gets the part of the string after the specified value, starting at the given start index.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">The specified start index is invalid.</exception>
        /// <param name="s">The input string.</param>
        /// <param name="value">The value to search.</param>
        /// <param name="startIndex">The start index of the substring.</param>
        /// <returns>The string after the specified value.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static string GetAfter( [NotNull] this string s, char value, int startIndex = 0 )
        {
            s.ThrowIfNull( nameof(s) );

            return s.GetAfter( value, startIndex, s.Length - startIndex );
        }

        /// <summary>
        ///     Gets the part of the string after the specified value, starting at the given start index
        ///     and ending after the specified number of characters.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">The specified range is invalid.</exception>
        /// <param name="s">The input string.</param>
        /// <param name="value">The value to search.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <param name="length">The length of the string, from the start index.</param>
        /// <returns>The string after the specified value.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static string GetAfter( [NotNull] this string s, char value, int startIndex, int length )
        {
            s.ThrowIfNull( nameof(s) );

            if ( startIndex < 0 || length < 0 || startIndex + length > s.Length )
                throw new ArgumentOutOfRangeException( nameof(length), "The specified range is invalid." );

            s = s.Substring( startIndex, length );
            var valueIndex = s.IndexOf( value );
            return valueIndex < 0
                ? string.Empty
                : s.Substring( valueIndex + 1 );
        }
        /// <summary>
        ///     Gets the part of the string before the specified value, starting at the given start index.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string can not be null.</exception>
        /// <exception cref="ArgumentNullException">value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">The specified start index is invalid.</exception>
        /// <param name="s">The input string.</param>
        /// <param name="value">The value to search for.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <returns>
        ///     The part of the string before the specified value, starting at the given start index.
        ///     Or an empty string if the given string doesn't contain the given value.
        /// </returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static string GetBefore( [NotNull] this string s, string value, int startIndex = 0 )
        {
            s.ThrowIfNull( nameof(s) );

            return s.GetBefore( value, startIndex, s.Length - startIndex );
        }

        /// <summary>
        ///     Gets the part of the string before the specified value, starting at the given start index
        ///     and ending after the specified number of characters.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string can not be null.</exception>
        /// <exception cref="ArgumentNullException">value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">The specified range is invalid.</exception>
        /// <param name="s">The input string.</param>
        /// <param name="value">The value to search for.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <param name="length">The length of the string, from the start index.</param>
        /// <returns>
        ///     The part of the string before the specified value, starting at the given start index.
        ///     Or an empty string if the given string doesn't contain the given value.
        /// </returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static string GetBefore( [NotNull] this string s, [NotNull] string value, int startIndex, int length )
        {
            s.ThrowIfNull( nameof(s) );
            value.ThrowIfNull( nameof(value) );

            if ( startIndex < 0 || length < 0 || startIndex + length > s.Length )
                throw new ArgumentOutOfRangeException( nameof(length), "The specified range is invalid." );

            s = s.Substring( startIndex, length );
            return !s.Contains( value )
                ? string.Empty
                : s.Substring( 0, s.IndexOf( value, StringComparison.Ordinal ) );
        }

        /// <summary>
        ///     Gets the part of the string before the specified value, starting at the given start index.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">The specified start index is invalid.</exception>
        /// <param name="s">The input string.</param>
        /// <param name="value">The value to search for.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <returns>
        ///     The part of the string before the specified value, starting at the given start index.
        ///     Or an empty string if the given string doesn't contain the given value.
        /// </returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static string GetBefore( [NotNull] this string s, char value, int startIndex = 0 )
        {
            s.ThrowIfNull( nameof(s) );

            return s.GetBefore( value, startIndex, s.Length - startIndex );
        }

        /// <summary>
        ///     Gets the part of the string before the specified value, starting at the given start index
        ///     and ending after the specified number of characters.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">The specified range is invalid.</exception>
        /// <param name="s">The input string.</param>
        /// <param name="value">The value to search for.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <param name="length">The length of the string, from the start index.</param>
        /// <returns>
        ///     The part of the string before the specified value, starting at the given start index.
        ///     Or an empty string if the given string doesn't contain the given value.
        /// </returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static string GetBefore( [NotNull] this string s, char value, int startIndex, int length )
        {
            s.ThrowIfNull( nameof(s) );

            if ( startIndex < 0 || length < 0 || startIndex + length > s.Length )
                throw new ArgumentOutOfRangeException( nameof(length), "The specified range is invalid." );

            s = s.Substring( startIndex, length );
            var valueIndex = s.IndexOf( value );
            return valueIndex < 0
                ? string.Empty
                : s.Substring( 0, valueIndex );
        }
        /// <summary>
        ///     Gets the part of the input string between the before and after value, starting at the given start index.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string can not be null.</exception>
        /// <exception cref="ArgumentNullException">value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">The specified start index is invalid.</exception>
        /// <param name="s">The input string.</param>
        /// <param name="before">The before value.</param>
        /// <param name="after">The after value.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <returns>The part of the string between the before and after value.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static string GetBetween( [NotNull] this string s, [NotNull] string before, [NotNull] string after, int startIndex = 0 )
        {
            s.ThrowIfNull( nameof(s) );

            return s.GetBetween( before, after, startIndex, s.Length - startIndex );
        }

        /// <summary>
        ///     Gets the part of the input string between the before and after value, starting at the given start index,
        ///     and ending after the specified number of characters.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string can not be null.</exception>
        /// <exception cref="ArgumentNullException">value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">The specified range is invalid.</exception>
        /// <param name="s">The input string.</param>
        /// <param name="before">The before value.</param>
        /// <param name="after">The after value.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <param name="length">The length of the string, from the start index.</param>
        /// <returns>The part of the string between the before and after value.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static string GetBetween( [NotNull] this string s, [NotNull] string before, [NotNull] string after, int startIndex, int length )
        {
            s.ThrowIfNull( nameof(s) );
            before.ThrowIfNull( nameof(before) );
            after.ThrowIfNull( nameof(after) );

            if ( startIndex < 0 || startIndex + length > s.Length )
                throw new ArgumentOutOfRangeException( nameof(length), "The specified range is invalid." );

            s = s.Substring( startIndex, length );

            var beforeIndex = s.IndexOf( before, StringComparison.Ordinal );
            if ( beforeIndex < 0 )
                return string.Empty;

            var actualStartIndex = beforeIndex + before.Length;
            var afterIndex = s.IndexOf( after, actualStartIndex, StringComparison.Ordinal );
            return afterIndex < 0 ? string.Empty : s.Substring( actualStartIndex, afterIndex - actualStartIndex );
        }

        /// <summary>
        ///     Gets the part of the input string between the before and after value, starting at the given start index.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string can not be null.</exception>
        /// <exception cref="ArgumentNullException">value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">The specified start index is invalid.</exception>
        /// <param name="s">The input string.</param>
        /// <param name="before">The before value.</param>
        /// <param name="after">The after value.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <returns>The part of the string between the before and after value.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static string GetBetween( [NotNull] this string s, char before, char after, int startIndex = 0 )
        {
            s.ThrowIfNull( nameof(s) );

            return s.GetBetween( before, after, startIndex, s.Length - startIndex );
        }

        /// <summary>
        ///     Gets the part of the input string between the before and after value, starting at the given start index,
        ///     and ending after the specified number of characters.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string can not be null.</exception>
        /// <exception cref="ArgumentNullException">value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">The specified range is invalid.</exception>
        /// <param name="s">The input string.</param>
        /// <param name="before">The before value.</param>
        /// <param name="after">The after value.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <param name="length">The length of the string, from the start index.</param>
        /// <returns>The part of the string between the before and after value.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static string GetBetween( [NotNull] this string s, char before, char after, int startIndex, int length )
        {
            s.ThrowIfNull( nameof(s) );

            if ( startIndex < 0 || length < 0 || startIndex + length > s.Length )
                throw new ArgumentOutOfRangeException( nameof(length), "The specified range is invalid." );

            s = s.Substring( startIndex, length );

            var beforeIndex = s.IndexOf( before );
            if ( beforeIndex < 0 )
                return string.Empty;

            var actualStartIndex = beforeIndex + 1;
            var afterIndex = s.IndexOf( after, actualStartIndex );
            return afterIndex < 0
                ? string.Empty
                : s.Substring( actualStartIndex, afterIndex - actualStartIndex );
        }
        /// <summary>
        ///     Enumerates all lines in the given string.
        /// </summary>
        /// <param name="value">The string whose lines are to be enumerated.</param>
        /// <exception cref="ArgumentNullException">value can not be null.</exception>
        /// <returns>An enumerable sequence of lines in this string.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static IEnumerable<string> GetLines( [NotNull] this string value )
        {
            value.ThrowIfNull( nameof(value) );

            using ( var reader = new StringReader( value ) )
            {
                string line;
                while ( ( line = reader.ReadLine() ) != null )
                    yield return line;
            }
        }
        /// <summary>
        ///     Returns the input value if it's not empty, otherwise the alternative value.
        /// </summary>
        /// <param name="value">The input string.</param>
        /// <param name="alternativeValue">The alternative value.</param>
        /// <returns>The input or the alternative value.</returns>
        [CanBeNull]
        [Pure]
        [PublicAPI]
        public static string IfNotEmpty( [CanBeNull] this string value, [CanBeNull] string alternativeValue )
            => !value.IsEmpty() ? value : alternativeValue;
        
        /// <summary>
        ///     Removes all characters which aren't letters.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string can not be null.</exception>
        /// <param name="str">The input string.</param>
        /// <returns>A new string containing the letters of the input string.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static string KeepLetters( [NotNull] this string str )
        {
            str.ThrowIfNull( nameof(str) );

            return new string( str.ToCharArray()
                                  .Where( x => x.IsLetter() )
                                  .ToArray() );
        }
        /// <summary>
        ///     Removes all characters which aren't letters or numbers.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string can not be null.</exception>
        /// <param name="str">The input string.</param>
        /// <returns>A new string containing the letters and numbers of the input string.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static string KeepLettersAndNumbers( [NotNull] this string str )
        {
            str.ThrowIfNull( nameof(str) );

            return new string( str.ToCharArray()
                                  .Where( x => x.IsNumber() || x.IsLetter() )
                                  .ToArray() );
        }
        /// <summary>
        ///     Removes all characters which aren't numbers.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string can not be null.</exception>
        /// <param name="str">The input string.</param>
        /// <returns>A new string containing the numbers of the input string.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static string KeepNumbers( [NotNull] this string str )
        {
            str.ThrowIfNull( nameof(str) );

            return new string( str.ToCharArray()
                                  .Where( x => x.IsNumber() )
                                  .ToArray() );
        }
        /// <summary>
        ///     Returns a string which only contains the characters matching the given predicate.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string can not be null.</exception>
        /// <exception cref="ArgumentNullException">The predicate can not be null.</exception>
        /// <param name="str">The input string.</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns>Returns a string which only contains the characters matching the given predicate.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static string KeepWhere( [NotNull] this string str, [NotNull] Func<char, bool> predicate )
        {
            str.ThrowIfNull( nameof(str) );
            predicate.ThrowIfNull( nameof(predicate) );

            return new string( str.ToCharArray()
                                  .Where( predicate )
                                  .ToArray() );
        }
        /// <summary>
        ///     Removes all letters from the given string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string can not be null.</exception>
        /// <param name="str">The input string.</param>
        /// <returns>The given string without any letters.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static string RemoveLetters( [NotNull] this string str )
        {
            str.ThrowIfNull( nameof(str) );

            return new string( str.ToCharArray()
                                  .Where( x => !x.IsLetter() )
                                  .ToArray() );
        }
        /// <summary>
        ///     Removes all letters and numbers from the given string.
        /// </summary>
        /// <exception cref="ArgumentNullException">s can not be null.</exception>
        /// <param name="s">The input string.</param>
        /// <returns>The given string without any letters or numbers.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static string RemoveLettersAndNumbers( [NotNull] this string s )
        {
            s.ThrowIfNull( nameof(s) );

            return new string( s.ToCharArray()
                                .Where( x => !x.IsNumber() && !x.IsLetter() )
                                .ToArray() );
        }
        /// <summary>
        ///     Removes all numbers from the given string.
        /// </summary>
        /// <exception cref="ArgumentNullException">s can not be null.</exception>
        /// <param name="s">The input string.</param>
        /// <returns>The given string without any numbers.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static string RemoveNumbers( [NotNull] this string s )
        {
            s.ThrowIfNull( nameof(s) );

            return new string( s.ToCharArray()
                                .Where( x => !x.IsNumber() )
                                .ToArray() );
        }
        /// <summary>
        ///     Replaces a single character at the specified position with the specified replacement character.
        /// </summary>
        /// <exception cref="ArgumentNullException">value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">index doesn't refer to a valid position within the string.</exception>
        /// <param name="value">The string in which a character will be replaced.</param>
        /// <param name="index">The position of the character to replace.</param>
        /// <param name="replace">The replacement character.</param>
        /// <returns>Returns the string with the replaced character.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static string ReplaceAt( [NotNull] this string value, int index, char replace )
        {
            value.ThrowIfNull( nameof(value) );

            if ( index < 0 || value.Length <= index )
                throw new ArgumentOutOfRangeException( nameof(index), index, "The given index is out of range." );

            var chars = value.ToCharArray();
            chars[index] = replace;

            return new string( chars );
        }
        /// <summary>
        ///     Tries to create a new <see cref="CultureInfo" /> with the given name.
        /// </summary>
        /// <param name="name">The name of the culture.</param>
        /// <returns>Returns the <see cref="CultureInfo" /> with the given name, or null if the culture is not supported.</returns>
        [Pure]
        [PublicAPI]
        public static CultureInfo SafeToCultureInfo( [NotNull] this string name )
        {
            try
            {
                return new CultureInfo( name );
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        ///     Tries to create a new <see cref="CultureInfo" /> with the given name.
        /// </summary>
        /// <param name="name">The name of the culture.</param>
        /// <param name="fallbackCulture">The culture returned if the culture with the given name is not supported.</param>
        /// <returns>Returns the <see cref="CultureInfo" /> with the given name, or <paramref name="fallbackCulture" />.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static CultureInfo SafeToCultureInfo( [NotNull] this string name, CultureInfo fallbackCulture )
        {
            try
            {
                return new CultureInfo( name );
            }
            catch
            {
                return fallbackCulture;
            }
        }
        /// <summary>
        ///     Returns a string array that contains the substrings in this string that are
        ///     delimited by elements of a specified string array. A parameter specifies
        ///     whether to return empty array elements.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string can not be null.</exception>
        /// <exception cref="ArgumentNullException">The separator can not be null.</exception>
        /// <param name="value">The string to split.</param>
        /// <param name="separators">
        ///     An array of strings that delimit the substrings in this string, an empty
        ///     array that contains no delimiters, or null.
        /// </param>
        /// <param name="stringSplitOption">
        ///     <see cref="System.StringSplitOptions.RemoveEmptyEntries" /> to omit empty array elements
        ///     from the array returned; or System.StringSplitOptions.None to include empty
        ///     array elements in the array returned.
        /// </param>
        /// <returns>
        ///     Returns an array whose elements contain the substrings in this string that are delimited
        ///     by one or more strings in separator.
        /// </returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static string[] Split( [NotNull] this string value,
                                      StringSplitOptions stringSplitOption,
                                      [NotNull] params string[] separators )
        {
            value.ThrowIfNull( nameof(value) );
            separators.ThrowIfNull( nameof(separators) );

            return value.Split( separators, stringSplitOption );
        }
        /// <summary>
        ///     Splits the given string at each line break (<see cref="Environment.NewLine" />).
        /// </summary>
        /// <exception cref="ArgumentNullException">value can not be null.</exception>
        /// <param name="value">The string to split.</param>
        /// <param name="stringSplitOptions">
        ///     <see cref="System.StringSplitOptions.RemoveEmptyEntries" /> to omit empty array elements
        ///     from the array returned; or System.StringSplitOptions.None to include empty
        ///     array elements in the array returned.
        /// </param>
        /// <returns>
        ///     Returns an array whose elements contain the substrings in this string that are delimited by
        ///     <see cref="Environment.NewLine" />.
        /// </returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static string[] SplitLines( [NotNull] this string value, StringSplitOptions stringSplitOptions )
        {
            value.ThrowIfNull( nameof(value) );

            return value.Split( new[]
                                {
                                    Environment.NewLine
                                },
                                stringSplitOptions );
        }

        /// <summary>
        ///     Splits the given string at each line break (<see cref="Environment.NewLine" />).
        /// </summary>
        /// <exception cref="ArgumentNullException">value can not be null.</exception>
        /// <param name="value">The string to split.</param>
        /// <returns>
        ///     Returns an array whose elements contain the substrings in this string that are delimited by
        ///     <see cref="Environment.NewLine" />.
        /// </returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static string[] SplitLines( [NotNull] this string value )
            => value.SplitLines( StringSplitOptions.RemoveEmptyEntries );
    }
}




namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Returns the specified number of characters from the start of the string.
        ///     Checks if the given length is valid, if not it uses the length of the string.
        /// </summary>
        /// <exception cref="ArgumentNullException">s can not be null.</exception>
        /// <param name="s">The string to get the substring of.</param>
        /// <param name="length">The number of characters.</param>
        /// <returns>Returns the specified number of characters from the start of the string.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static string SubstringLeftSafe( [NotNull] this string s, int length )
        {
            s.ThrowIfNull( nameof(s) );

            return s.Substring( 0, Math.Min( length, s.Length ) );
        }

        /// <summary>
        ///     Returns the specified number of characters from the start index.
        ///     Checks if the given start index and length is valid, if not it uses the length of the string.
        /// </summary>
        /// <exception cref="ArgumentNullException">s can not be null.</exception>
        /// <param name="s">The string to get the substring of.</param>
        /// <param name="startIndex">The start index.</param>
        /// <param name="length">The number of characters.</param>
        /// <returns>Returns the specified number of characters from the start index of the string.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static string SubstringLeftSafe( [NotNull] this string s, int startIndex, int length )
        {
            s.ThrowIfNull( nameof(s) );

            return s.Substring( Math.Min( startIndex, s.Length ),
                                Math.Min( length, Math.Max( s.Length - startIndex, 0 ) ) );
        }
    }
}




namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Returns the specified number of characters from the end of the string.
        ///     Checks if the given length is valid, if not it uses the length of the string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string can not be null.</exception>
        /// <param name="str">The string to get the substring of.</param>
        /// <param name="length">The number of characters.</param>
        /// <returns>Returns the specified number of characters from the end of the string.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static string SubstringRightSafe( [NotNull] this string str, int length )
        {
            str.ThrowIfNull( nameof(str) );

            return str.Substring( Math.Max( 0, str.Length - length ) );
        }
        /// <summary>
        ///     Returns a specified number of characters from the start of the given value
        ///     and removes the returned characters from the value.
        /// </summary>
        /// <param name="value">
        ///     The source value.
        /// </param>
        /// <param name="count">The numbers of characters to return.</param>
        /// <exception cref="ArgumentNullException">value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Count must be smaller than the length of the given value.</exception>
        /// <returns>A <see cref="String" /> that contains the specified number of chars. </returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static string TakeAndRemove( this int count, [NotNull] ref string value )
        {
            value.ThrowIfNull( nameof(value) );

            if ( count > value.Length )
                throw new ArgumentOutOfRangeException( nameof(count),
                                                       "Count must be smaller than the length of the given value." );

            var returnValue = new string( value.ToCharArray()
                                               .Take( count )
                                               .ToArray() );
            value = value.Remove( 0, count );
            return returnValue;
        }
        /// <summary>
        ///     Creates a new <see cref="CultureInfo" /> with the given name.
        /// </summary>
        /// <exception cref="ArgumentNullException">name can not be null.</exception>
        /// <exception cref="CultureNotFoundException">Culture is not supported.</exception>
        /// <param name="name">The name of the culture.</param>
        /// <returns>Returns the <see cref="CultureInfo" /> with the given name.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static CultureInfo ToCultureInfo( [NotNull] this string name )
        {
            name.ThrowIfNull( nameof(name) );

            return new CultureInfo( name );
        }
        /// <summary>
        ///     Truncates the given string to the specified maximum length and adds the specified
        ///     suffix to the end of the truncated string.
        /// </summary>
        /// <param name="str">The string to truncate.</param>
        /// <param name="maxLength">The maximum length of the truncated string.</param>
        /// <param name="suffix">The suffix of the truncated string.</param>
        /// <returns>The truncated string.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static string Truncate2( [CanBeNull] this string str, int maxLength, string suffix = "..." )
        {
            // ReSharper disable once PossibleNullReferenceException
            if ( str.IsEmpty() || str.Length <= maxLength )
                // ReSharper disable once AssignNullToNotNullAttribute
                return str;

            return str.Substring( 0, Math.Max( 0, maxLength - suffix.Length ) )
                      .ConcatAll( suffix );
        }
        /// <summary>
        ///     Tries to convert a string value to an enum.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <typeparam name="T">The type of the enum.</typeparam>
        /// <param name="value">The String value to convert.</param>
        /// <param name="ignoreCase">Determines whether or not to ignore the casing of the string.</param>
        /// <param name="outValue">The output value.</param>
        /// <returns>Returns the converted enum value.</returns>
        [Pure]
        [PublicAPI]
        public static bool TryToEnum<T>( [CanBeNull] string value, out T outValue, bool ignoreCase = true ) where T : struct
            => Enum.TryParse( value, ignoreCase, out outValue );
        /// <summary>
        ///     Converts the given wild-card pattern to a RegEx.
        /// </summary>
        /// <param name="pattern">A wild-card pattern.</param>
        /// <returns>Returns the equivalent RegEx.</returns>
        [Pure]
        [NotNull]
        public static string WildcardToRegex( [NotNull] this string pattern )
        {
            pattern.ThrowIfNull( nameof(pattern) );

            return "^" + Regex.Escape( pattern )
                              .Replace( @"\*", ".*" )
                              .Replace( @"\?", "." )
                   + "$";
        }
    }
}