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
//using System.Collections.Generic;
//using System.Reflection;
//using JetBrains.Annotations;
//using System.Linq;
//using System.IO;
//using System.Diagnostics;
//using System.Threading.Tasks;
//using System.Collections.ObjectModel;
//using System.Text;
//using System.Globalization;
//using System.Collections;
//using System.Linq.Expressions;
//using System.Text.RegularExpressions;
//using System.Collections.Concurrent;
//using HSNXT.Internal;

//using System;
//using JetBrains.Annotations;

#endregion

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
        public static String AppendWithNewLineIfNotEmpty( [CanBeNull] this String target, [CanBeNull] String append, String newLine = null )
        {
            newLine = newLine ?? Environment.NewLine;

            if ( target.IsNotEmpty() )
                target += newLine;

            return target + append;
        }
    }
}
#region Usings

//using System;
//using System.Globalization;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
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
        public static Object ChangeType( [CanBeNull] this String value, [NotNull] Type type )
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
        public static Object ChangeType( [CanBeNull] this String value, [NotNull] Type type, [NotNull] IFormatProvider formatProvider )
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
        public static T ChangeType<T>( [CanBeNull] this String value )
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
        public static T ChangeType<T>( [CanBeNull] this String value, [NotNull] IFormatProvider formatProvider )
        {
            formatProvider.ThrowIfNull( nameof(formatProvider) );

            return (T) Convert.ChangeType( value, typeof(T), formatProvider );
        }
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
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
        public static Char CharAt( [NotNull] this String value, Int32 index )
        {
            value.ThrowIfNull( nameof(value) );

            if ( index < 0 || value.Length <= index )
                throw new ArgumentOutOfRangeException( nameof(index), index, "The given index is out of range." );

            return value[index];
        }
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Compares the given strings using <see cref="StringComparison.Ordinal" />.
        /// </summary>
        /// <param name="value">The first string to compare.</param>
        /// <param name="compareValue">The second string to compare.</param>
        /// <returns>Returns true if the given strings are equals, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean CompareOrdinal( this String value, String compareValue )
            => String.Compare( value, compareValue, StringComparison.Ordinal ) == 0;
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Compares the given strings using <see cref="StringComparison.OrdinalIgnoreCase" />.
        /// </summary>
        /// <param name="value">The first string to compare.</param>
        /// <param name="compareValue">The second string to compare.</param>
        /// <returns>Returns true if the given strings are equals, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean CompareOrdinalIgnoreCase( [CanBeNull] this String value, [CanBeNull] String compareValue )
            => String.Compare( value, compareValue, StringComparison.OrdinalIgnoreCase ) == 0;
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
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
        public static String ConcatAll( this String str, [NotNull] params String[] strings )
        {
            strings.ThrowIfNull( nameof(strings) );

            return String.Concat( str, String.Concat( strings ) );
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
        public static String ConcatAll( [NotNull] this String[] strings )
        {
            strings.ThrowIfNull( nameof(strings) );

            return String.Concat( strings );
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
        public static String ConcatAll( this String str, [NotNull] params Object[] values )
        {
            values.ThrowIfNull( nameof(values) );

            return String.Concat( str, String.Concat( values ) );
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
        public static String ConcatAll( [NotNull] this Object[] values )
        {
            values.ThrowIfNull( nameof(values) );

            return String.Concat( values );
        }
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Checks whether a specified substring occurs within the given string, or not.
        /// </summary>
        /// <exception cref="ArgumentException"> comparisonType is not a valid <see cref="System.StringComparison" /> value.</exception>
        /// <exception cref="ArgumentNullException">s can not be null.</exception>
        /// <exception cref="ArgumentNullException">value can not be null.</exception>
        /// <param name="s">The string to search in.</param>
        /// <param name="value">The string to seek.</param>
        /// <param name="stringComparison">One of the enumeration values that specifies the rules for the search.</param>
        /// <returns>Returns true if the value parameter occurs within the given string; otherwise, false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean Contains( [NotNull] this String s, [NotNull] String value, StringComparison stringComparison )
        {
            s.ThrowIfNull( nameof(s) );
            value.ThrowIfNull( nameof(value) );

            return s.IndexOf( value, stringComparison ) >= 0;
        }
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Checks if the string contains all values given.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string can not be null.</exception>
        /// <exception cref="ArgumentNullException">The values can not be null.</exception>
        /// <param name="s">The string to check.</param>
        /// <param name="values">A list of string values.</param>
        /// <returns>Returns true if the string contains all values, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean ContainsAll( [NotNull] this String s, [NotNull] params String[] values )
        {
            s.ThrowIfNull( nameof(s) );
            values.ThrowIfNull( nameof(values) );

            return values.NotAny( x => !s.Contains( x ) );
        }

        /// <summary>
        ///     Checks if the string contains all values given.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string can not be null.</exception>
        /// <exception cref="ArgumentNullException">The values can not be null.</exception>
        /// <param name="s">The string to check.</param>
        /// <param name="comparisonType">Type of the comparison.</param>
        /// <param name="values">A list of string values.</param>
        /// <returns>Returns true if the string contains all values, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean ContainsAll( [NotNull] this String s, StringComparison comparisonType, [NotNull] params String[] values )
        {
            s.ThrowIfNull( nameof(s) );
            values.ThrowIfNull( nameof(values) );

            return values.NotAny( x => s.IndexOf( x, comparisonType ) == -1 );
        }
    }
}
#region Usings

//using System;
//using System.Linq;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Checks if the string contains any of the values given.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string can not be null.</exception>
        /// <exception cref="ArgumentNullException">The values can not be null.</exception>
        /// <param name="str">The string to check.</param>
        /// <param name="values">The values to search for.</param>
        /// <returns>Returns true if the string contains any of the values given, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean ContainsAny( [NotNull] this String str, [NotNull] params String[] values )
        {
            str.ThrowIfNull( nameof(str) );
            values.ThrowIfNull( nameof(values) );

            return values.Any( str.Contains );
        }

        /// <summary>
        ///     Checks if the string contains any of the values given.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string can not be null.</exception>
        /// <exception cref="ArgumentNullException">The values can not be null.</exception>
        /// <param name="str">The string to check.</param>
        /// <param name="values">The values to search for.</param>
        /// <param name="comparisonType">The string comparison type.</param>
        /// <returns>Returns true if the string contains any of the values given, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean ContainsAny( [NotNull] this String str, StringComparison comparisonType, [NotNull] params String[] values )
        {
            str.ThrowIfNull( nameof(str) );
            values.ThrowIfNull( nameof(values) );

            return values.Any( x => str.IndexOf( x, comparisonType ) != -1 );
        }
    }
}
#region Usings

//using System;
//using System.Linq;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Extracts parts of the input string, based on the predicate given.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string can not be null.</exception>
        /// <exception cref="ArgumentNullException">The predicate can not be null.</exception>
        /// <param name="str">The string to extract.</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns>The extracted parts of the input string.</returns>
        [Pure]
        [PublicAPI]
        public static String Extract( [NotNull] this String str, [NotNull] Func<Char, Boolean> predicate )
        {
            str.ThrowIfNull( nameof(str) );
            predicate.ThrowIfNull( nameof(predicate) );

            return new String( str.ToCharArray()
                                  .Where( predicate )
                                  .ToArray() );
        }
    }
}
#region Usings

//using System;
//using System.Linq;
//using JetBrains.Annotations;

#endregion

#region Usings

//using System;
//using System.Linq;
//using JetBrains.Annotations;

#endregion

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
        public static String ExtractNumbers( [NotNull] this String str )
        {
            str.ThrowIfNull( nameof(str) );

            return new String( str.ToCharArray()
                                  .Where( x => x.IsNumber() )
                                  .ToArray() );
        }
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
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
        public static String F( [NotNull] this String format, [NotNull] params Object[] args )
        {
            format.ThrowIfNull( nameof(format) );
            args.ThrowIfNull( nameof(args) );

            return String.Format( format, args );
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
        public static String F( [NotNull] this String format, [NotNull] IFormatProvider formatProvider, [NotNull] params Object[] args )
        {
            format.ThrowIfNull( nameof(format) );
            formatProvider.ThrowIfNull( nameof(formatProvider) );
            args.ThrowIfNull( nameof(args) );

            return String.Format( formatProvider, format, args );
        }
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
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
        public static String FormatFileExtension( [NotNull] this String fileExtension )
        {
            fileExtension.ThrowIfNull( nameof(fileExtension) );

            if ( fileExtension.IsEmpty() )
                throw new ArgumentException( "Can not format a empty string to a file extension.", nameof(fileExtension) );

            if ( !fileExtension.StartsWith( ".", StringComparison.Ordinal ) )
                fileExtension = fileExtension.Insert( 0, "." );
            return fileExtension.ToLower();
        }
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
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
        public static String GetAfter( [NotNull] this String s, [NotNull] String value, Int32 startIndex = 0 )
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
        public static String GetAfter( [NotNull] this String s, [NotNull] String value, Int32 startIndex, Int32 length )
        {
            s.ThrowIfNull( nameof(s) );
            value.ThrowIfNull( nameof(value) );

            if ( startIndex < 0 || length < 0 || startIndex + length > s.Length )
                throw new ArgumentOutOfRangeException( nameof(length), "The specified range is invalid." );

            s = s.Substring( startIndex, length );
            return !s.Contains( value )
                ? String.Empty
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
        public static String GetAfter( [NotNull] this String s, Char value, Int32 startIndex = 0 )
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
        public static String GetAfter( [NotNull] this String s, Char value, Int32 startIndex, Int32 length )
        {
            s.ThrowIfNull( nameof(s) );

            if ( startIndex < 0 || length < 0 || startIndex + length > s.Length )
                throw new ArgumentOutOfRangeException( nameof(length), "The specified range is invalid." );

            s = s.Substring( startIndex, length );
            var valueIndex = s.IndexOf( value );
            return valueIndex < 0
                ? String.Empty
                : s.Substring( valueIndex + 1 );
        }
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
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
        public static String GetBefore( [NotNull] this String s, String value, Int32 startIndex = 0 )
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
        public static String GetBefore( [NotNull] this String s, [NotNull] String value, Int32 startIndex, Int32 length )
        {
            s.ThrowIfNull( nameof(s) );
            value.ThrowIfNull( nameof(value) );

            if ( startIndex < 0 || length < 0 || startIndex + length > s.Length )
                throw new ArgumentOutOfRangeException( nameof(length), "The specified range is invalid." );

            s = s.Substring( startIndex, length );
            return !s.Contains( value )
                ? String.Empty
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
        public static String GetBefore( [NotNull] this String s, Char value, Int32 startIndex = 0 )
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
        public static String GetBefore( [NotNull] this String s, Char value, Int32 startIndex, Int32 length )
        {
            s.ThrowIfNull( nameof(s) );

            if ( startIndex < 0 || length < 0 || startIndex + length > s.Length )
                throw new ArgumentOutOfRangeException( nameof(length), "The specified range is invalid." );

            s = s.Substring( startIndex, length );
            var valueIndex = s.IndexOf( value );
            return valueIndex < 0
                ? String.Empty
                : s.Substring( 0, valueIndex );
        }
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
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
        public static String GetBetween( [NotNull] this String s, [NotNull] String before, [NotNull] String after, Int32 startIndex = 0 )
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
        public static String GetBetween( [NotNull] this String s, [NotNull] String before, [NotNull] String after, Int32 startIndex, Int32 length )
        {
            s.ThrowIfNull( nameof(s) );
            before.ThrowIfNull( nameof(before) );
            after.ThrowIfNull( nameof(after) );

            if ( startIndex < 0 || startIndex + length > s.Length )
                throw new ArgumentOutOfRangeException( nameof(length), "The specified range is invalid." );

            s = s.Substring( startIndex, length );

            var beforeIndex = s.IndexOf( before, StringComparison.Ordinal );
            if ( beforeIndex < 0 )
                return String.Empty;

            var actualStartIndex = beforeIndex + before.Length;
            var afterIndex = s.IndexOf( after, actualStartIndex, StringComparison.Ordinal );
            return afterIndex < 0 ? String.Empty : s.Substring( actualStartIndex, afterIndex - actualStartIndex );
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
        public static String GetBetween( [NotNull] this String s, Char before, Char after, Int32 startIndex = 0 )
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
        public static String GetBetween( [NotNull] this String s, Char before, Char after, Int32 startIndex, Int32 length )
        {
            s.ThrowIfNull( nameof(s) );

            if ( startIndex < 0 || length < 0 || startIndex + length > s.Length )
                throw new ArgumentOutOfRangeException( nameof(length), "The specified range is invalid." );

            s = s.Substring( startIndex, length );

            var beforeIndex = s.IndexOf( before );
            if ( beforeIndex < 0 )
                return String.Empty;

            var actualStartIndex = beforeIndex + 1;
            var afterIndex = s.IndexOf( after, actualStartIndex );
            return afterIndex < 0
                ? String.Empty
                : s.Substring( actualStartIndex, afterIndex - actualStartIndex );
        }
    }
}
#region Usings

//using System;
//using System.Collections.Generic;
//using System.IO;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Enumerates all lines in the given string.
        /// </summary>
        /// <param name="value">The string whose lines are to be enumerated.</param>
        /// <exception cref="ArgumentNullException">value can not be null.</exception>
        /// <returns>An enumerable sequence of lines in this string.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static IEnumerable<String> GetLines( [NotNull] this String value )
        {
            value.ThrowIfNull( nameof(value) );

            using ( var reader = new StringReader( value ) )
            {
                String line;
                while ( ( line = reader.ReadLine() ) != null )
                    yield return line;
            }
        }
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Returns the input value if it's not empty, otherwise the alternative value.
        /// </summary>
        /// <param name="value">The input string.</param>
        /// <param name="alternativeValue">The alternative value.</param>
        /// <returns>The input or the alternative value.</returns>
        [CanBeNull]
        [Pure]
        [PublicAPI]
        public static String IfNotEmpty( [CanBeNull] this String value, [CanBeNull] String alternativeValue )
            => !value.IsEmpty() ? value : alternativeValue;
    }
}
#region Usings

//using System;
//using System.Linq;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Checks if the string is alpha.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string can not be null.</exception>
        /// <param name="str">The string to check.</param>
        /// <returns>Returns true if the string is alpha only, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean IsAlpha( [NotNull] this String str )
        {
            str.ThrowIfNull( nameof(str) );

            return str.ToCharArray()
                      .All( x => x.IsLetter() );
        }
    }
}
#region Usings

//using System;
//using System.Linq;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Checks if the string is alpha numeric.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string can not be null.</exception>
        /// <param name="str">The string to check.</param>
        /// <returns>Returns true if the string is alpha numeric, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean IsAlphaNumeric( [NotNull] this String str )
        {
            str.ThrowIfNull( nameof(str) );

            return str.ToCharArray()
                      .All( x => x.IsLetter() || x.IsNumber() );
        }
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Gets whether the given <see cref="String" /> is empty or not.
        /// </summary>
        /// <param name="str">The <see cref="String" /> to check.</param>
        /// <returns>A value of true if the given <see cref="String" /> is empty, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean IsEmpty( [CanBeNull] this String str )
            => String.IsNullOrEmpty( str ) || String.IsNullOrWhiteSpace( str );
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Gets whether the given <see cref="String" /> is empty or not.
        /// </summary>
        /// <param name="input">The <see cref="String" /> to check.</param>
        /// <returns>A value of true if the given <see cref="String" /> is not empty, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean IsNotEmpty( [CanBeNull] this String input )
            => !IsEmpty( input );
    }
}
#region Usings

//using System;
//using System.Linq;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Checks if the string is numeric.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string can not be null.</exception>
        /// <param name="str">The string to check.</param>
        /// <returns>Returns true if the string is numeric only, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean IsNumeric( [NotNull] this String str )
        {
            str.ThrowIfNull( nameof(str) );

            return str.ToCharArray()
                      .All( x => x.IsNumber() );
        }
    }
}
#region Usings

//using System;
//using System.Collections.Generic;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Concatenates all the elements of a string array, using the specified separator between each element.
        /// </summary>
        /// <exception cref="ArgumentNullException">The values can not be null.</exception>
        /// <param name="separator">
        ///     The string to use as a separator.
        ///     Is included in the returned string only if it has more than one element.
        /// </param>
        /// <param name="values">An array that contains the elements to concatenate.</param>
        /// <returns>
        ///     A string that consists of the elements in  delimited by the  string.
        ///     If is an empty array, the method returns String.Empty.
        /// </returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static String Join( [NotNull] this String separator, [NotNull] String[] values )
        {
            separator.ThrowIfNull( nameof(separator) );
            values.ThrowIfNull( nameof(values) );

            return String.Join( separator, values );
        }

        /// <summary>
        ///     Concatenates all the elements of a object array, using the specified separator between each element.
        /// </summary>
        /// <exception cref="ArgumentNullException">The values can not be null.</exception>
        /// <param name="separator">
        ///     The string to use as a separator.
        ///     Is included in the returned string only if it has more than one element.
        /// </param>
        /// <param name="values">An array that contains the elements to concatenate.</param>
        /// <returns>
        ///     A string that consists of the elements in  delimited by the  string.
        ///     If is an empty array, the method returns String.Empty.
        /// </returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static String Join( [NotNull] this String separator, [NotNull] Object[] values )
        {
            separator.ThrowIfNull( nameof(separator) );
            values.ThrowIfNull( nameof(values) );

            return String.Join( separator, values );
        }

        /// <summary>
        ///     Concatenates all the elements of a IEnumerable, using the specified separator between each element.
        /// </summary>
        /// <exception cref="ArgumentNullException">The values can not be null.</exception>
        /// <typeparam name="T">The type of the items in the IEnumerable.</typeparam>
        /// <param name="separator">
        ///     The string to use as a separator.
        ///     Is included in the returned string only if it has more than one element.
        /// </param>
        /// <param name="values">An IEnumerable that contains the elements to concatenate.</param>
        /// <returns>
        ///     A string that consists of the elements in  delimited by the string.
        ///     If is an empty IEnumerable, the method returns String.Empty.
        /// </returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static String Join<T>( [NotNull] this String separator, [NotNull] IEnumerable<T> values )
        {
            separator.ThrowIfNull( nameof(separator) );
            values.ThrowIfNull( nameof(values) );

            return String.Join( separator, values );
        }

        /// <summary>
        ///     Concatenates all the elements of a string array, using the specified separator between each element.
        /// </summary>
        /// <exception cref="ArgumentNullException">The values can not be null.</exception>
        /// <param name="separator">
        ///     The string to use as a separator.
        ///     Is included in the returned string only if it has more than one element.
        /// </param>
        /// <param name="values">An array that contains the elements to concatenate.</param>
        /// <param name="startIndex">The first element in to use.</param>
        /// <param name="count">The number of elements of to use.</param>
        /// <returns>
        ///     A string that consists of the elements in  delimited by the  string.
        ///     If is an empty array, the method returns String.Empty.
        /// </returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static String Join( [NotNull] this String separator, [NotNull] String[] values, Int32 startIndex, Int32 count )
        {
            separator.ThrowIfNull( nameof(separator) );
            values.ThrowIfNull( nameof(values) );

            return String.Join( separator, values, startIndex, count );
        }
    }
}
#region Usings

//using System;
//using System.Linq;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Removes all characters which aren't letters.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string can not be null.</exception>
        /// <param name="str">The input string.</param>
        /// <returns>A new string containing the letters of the input string.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static String KeepLetters( [NotNull] this String str )
        {
            str.ThrowIfNull( nameof(str) );

            return new String( str.ToCharArray()
                                  .Where( x => x.IsLetter() )
                                  .ToArray() );
        }
    }
}
#region Usings

//using System;
//using System.Linq;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Removes all characters which aren't letters or numbers.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string can not be null.</exception>
        /// <param name="str">The input string.</param>
        /// <returns>A new string containing the letters and numbers of the input string.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static String KeepLettersAndNumbers( [NotNull] this String str )
        {
            str.ThrowIfNull( nameof(str) );

            return new String( str.ToCharArray()
                                  .Where( x => x.IsNumber() || x.IsLetter() )
                                  .ToArray() );
        }
    }
}
#region Usings

//using System;
//using System.Linq;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Removes all characters which aren't numbers.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string can not be null.</exception>
        /// <param name="str">The input string.</param>
        /// <returns>A new string containing the numbers of the input string.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static String KeepNumbers( [NotNull] this String str )
        {
            str.ThrowIfNull( nameof(str) );

            return new String( str.ToCharArray()
                                  .Where( x => x.IsNumber() )
                                  .ToArray() );
        }
    }
}
#region Usings

//using System;
//using System.Linq;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
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
        public static String KeepWhere( [NotNull] this String str, [NotNull] Func<Char, Boolean> predicate )
        {
            str.ThrowIfNull( nameof(str) );
            predicate.ThrowIfNull( nameof(predicate) );

            return new String( str.ToCharArray()
                                  .Where( predicate )
                                  .ToArray() );
        }
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Returns a string containing a specified number of characters from the left side of a string.
        /// </summary>
        /// <exception cref="ArgumentNullException">value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">count is less than 0 or greater than the length of the given string.</exception>
        /// <param name="value">The string from which the leftmost characters are returned.</param>
        /// <param name="count">The number of characters to return.</param>
        /// <returns>Returns a string containing a specified number of characters from the left side of the given string.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static String Left( [NotNull] this String value, Int32 count )
        {
            value.ThrowIfNull( nameof(value) );

            if ( count < 0 || value.Length < count )
                throw new ArgumentOutOfRangeException( nameof(count), count, "The specified amount of characters is out of range." );

            return value.Substring( 0, count );
        }
    }
}
#region Usings

//using System;
//using System.Linq;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Removes all letters from the given string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string can not be null.</exception>
        /// <param name="str">The input string.</param>
        /// <returns>The given string without any letters.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static String RemoveLetters( [NotNull] this String str )
        {
            str.ThrowIfNull( nameof(str) );

            return new String( str.ToCharArray()
                                  .Where( x => !x.IsLetter() )
                                  .ToArray() );
        }
    }
}
#region Usings

//using System;
//using System.Linq;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Removes all letters and numbers from the given string.
        /// </summary>
        /// <exception cref="ArgumentNullException">s can not be null.</exception>
        /// <param name="s">The input string.</param>
        /// <returns>The given string without any letters or numbers.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static String RemoveLettersAndNumbers( [NotNull] this String s )
        {
            s.ThrowIfNull( nameof(s) );

            return new String( s.ToCharArray()
                                .Where( x => !x.IsNumber() && !x.IsLetter() )
                                .ToArray() );
        }
    }
}
#region Usings

//using System;
//using System.Linq;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Removes all numbers from the given string.
        /// </summary>
        /// <exception cref="ArgumentNullException">s can not be null.</exception>
        /// <param name="s">The input string.</param>
        /// <returns>The given string without any numbers.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static String RemoveNumbers( [NotNull] this String s )
        {
            s.ThrowIfNull( nameof(s) );

            return new String( s.ToCharArray()
                                .Where( x => !x.IsNumber() )
                                .ToArray() );
        }
    }
}
#region Usings

//using System;
//using System.Linq;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Removes some characters from the given string, based on the predicate specified.
        /// </summary>
        /// <exception cref="ArgumentNullException">s can not be null.</exception>
        /// <exception cref="ArgumentNullException">predicate can not be null.</exception>
        /// <param name="s">The input string.</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns>Returns the input string without any of the removed characters.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static String RemoveWhere( [NotNull] this String s, [NotNull] Func<Char, Boolean> predicate )
        {
            s.ThrowIfNull( nameof(s) );
            predicate.ThrowIfNull( nameof(predicate) );

            return new String( s.ToCharArray()
                                .Where( x => !predicate( x ) )
                                .ToArray() );
        }
    }
}
#region Usings

//using System;
//using System.Text;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Repeats the given string a specified number of times.
        /// </summary>
        /// <param name="s">The input string.</param>
        /// <param name="repeatCount">The number of repeats.</param>
        /// <returns>Returns the repeated string.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static String Repeat( this String s, Int32 repeatCount )
        {
            if ( s.IsEmpty() )
                return String.Empty;

            if ( s.Length == 1 )
                return new String( s[0], repeatCount );

            var sb = new StringBuilder( repeatCount * s.Length );
            while ( repeatCount-- > 0 )
                sb.Append( s );

            return sb.ToString();
        }
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
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
        public static String ReplaceAt( [NotNull] this String value, Int32 index, Char replace )
        {
            value.ThrowIfNull( nameof(value) );

            if ( index < 0 || value.Length <= index )
                throw new ArgumentOutOfRangeException( nameof(index), index, "The given index is out of range." );

            var chars = value.ToCharArray();
            chars[index] = replace;

            return new String( chars );
        }
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Replace all given values by an empty string.
        /// </summary>
        /// <exception cref="ArgumentNullException">s can not be null.</exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <param name="s">The input string.</param>
        /// <param name="values">A list of all values to replace.</param>
        /// <returns>Returns a string with all specified values replaced by an empty string.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static String ReplaceByEmpty( [NotNull] this String s, [NotNull] params String[] values )
        {
            s.ThrowIfNull( nameof(s) );
            values.ThrowIfNull( nameof(values) );

            values.ForEach( x => s = s.Replace( x, String.Empty ) );
            return s;
        }
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Reverses the given string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string can not be null.</exception>
        /// <param name="s">The string to reverse.</param>
        /// <returns>Returns the reversed string.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static String Reverse( [NotNull] this String s )
        {
            s.ThrowIfNull( nameof(s) );

            return s.Length <= 1
                ? s
                : new String( s.ToCharArray()
                               .Reverse() );
        }
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Returns a string containing a specified number of characters from the right side of a string.
        /// </summary>
        /// <param name="count">The number of characters to return.</param>
        /// <exception cref="ArgumentNullException">value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">count is less than 0 or greater than the length of the string.</exception>
        /// <param name="value">The string from which the rightmost characters are returned.</param>
        /// <returns>Returns a string containing a specified number of characters from the right side of a string.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static String Right( [NotNull] this String value, Int32 count )
        {
            value.ThrowIfNull( nameof(value) );

            if ( count < 0 || value.Length < count )
                throw new ArgumentOutOfRangeException( nameof(count), count, "The specified amount of characters is out of range." );

            return value.Substring( value.Length - count, count );
        }
    }
}
#region Usings

//using System;
//using System.Globalization;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Tries to create a new <see cref="CultureInfo" /> with the given name.
        /// </summary>
        /// <param name="name">The name of the culture.</param>
        /// <returns>Returns the <see cref="CultureInfo" /> with the given name, or null if the culture is not supported.</returns>
        [Pure]
        [PublicAPI]
        public static CultureInfo SafeToCultureInfo( [NotNull] this String name )
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
        public static CultureInfo SafeToCultureInfo( [NotNull] this String name, CultureInfo fallbackCulture )
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
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Returns a string array that contains the substrings in this string that are
        ///     delimited by the given separator. A parameter specifies
        ///     whether to return empty array elements.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string can not be null.</exception>
        /// <exception cref="ArgumentNullException">The separator can not be null.</exception>
        /// <param name="value">The string to split.</param>
        /// <param name="separator">A string that delimit the substrings in this string.</param>
        /// <param name="stringSplitOption">
        ///     <see cref="System.StringSplitOptions.RemoveEmptyEntries" /> to omit empty array elements
        ///     from the array returned; or System.StringSplitOptions.None to include empty
        ///     array elements in the array returned.
        /// </param>
        /// <returns>
        ///     Returns an array whose elements contain the substrings in this string that are delimited by the separator.
        /// </returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static String[] Split( [NotNull] this String value,
                                      [NotNull] String separator,
                                      StringSplitOptions stringSplitOption = StringSplitOptions.None )
        {
            value.ThrowIfNull( nameof(value) );
            separator.ThrowIfNull( nameof(separator) );

            return value.Split( new[]
                                {
                                    separator
                                },
                                stringSplitOption );
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
        public static String[] Split( [NotNull] this String value,
                                      StringSplitOptions stringSplitOption,
                                      [NotNull] params String[] separators )
        {
            value.ThrowIfNull( nameof(value) );
            separators.ThrowIfNull( nameof(separators) );

            return value.Split( separators, stringSplitOption );
        }
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
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
        public static String[] SplitLines( [NotNull] this String value, StringSplitOptions stringSplitOptions )
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
        public static String[] SplitLines( [NotNull] this String value )
            => value.SplitLines( StringSplitOptions.RemoveEmptyEntries );
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

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
        public static String SubstringLeftSafe( [NotNull] this String s, Int32 length )
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
        public static String SubstringLeftSafe( [NotNull] this String s, Int32 startIndex, Int32 length )
        {
            s.ThrowIfNull( nameof(s) );

            return s.Substring( Math.Min( startIndex, s.Length ),
                                Math.Min( length, Math.Max( s.Length - startIndex, 0 ) ) );
        }
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

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
        public static String SubstringRightSafe( [NotNull] this String str, Int32 length )
        {
            str.ThrowIfNull( nameof(str) );

            return str.Substring( Math.Max( 0, str.Length - length ) );
        }
    }
}
#region Usings

//using System;
//using System.Linq;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
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
        public static String TakeAndRemove( this Int32 count, [NotNull] ref String value )
        {
            value.ThrowIfNull( nameof(value) );

            if ( count > value.Length )
                throw new ArgumentOutOfRangeException( nameof(count),
                                                       "Count must be smaller than the length of the given value." );

            var returnValue = new String( value.ToCharArray()
                                               .Take( count )
                                               .ToArray() );
            value = value.Remove( 0, count );
            return returnValue;
        }
    }
}
#region Usings

//using System;
//using System.Globalization;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
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
        public static CultureInfo ToCultureInfo( [NotNull] this String name )
        {
            name.ThrowIfNull( nameof(name) );

            return new CultureInfo( name );
        }
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Converts a string to an enumeration.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <typeparam name="T">The type of the enumeration.</typeparam>
        /// <param name="value">The String value to convert.</param>
        /// <param name="ignoreCase">Determines whether or not to ignore the casing of the string.</param>
        /// <returns>Returns the converted enumeration value.</returns>
        [Pure]
        [PublicAPI]
        public static T ToEnum<T>( [NotNull] this String value, Boolean ignoreCase = true ) where T : struct
        {
            value.ThrowIfNull( nameof(value) );

            return (T) Enum.Parse( typeof(T), value, ignoreCase );
        }
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
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
        public static String Truncate( [CanBeNull] this String str, Int32 maxLength, String suffix = "..." )
        {
            // ReSharper disable once PossibleNullReferenceException
            if ( str.IsEmpty() || str.Length <= maxLength )
                // ReSharper disable once AssignNullToNotNullAttribute
                return str;

            return str.Substring( 0, Math.Max( 0, maxLength - suffix.Length ) )
                      .ConcatAll( suffix );
        }
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
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
        public static Boolean TryToEnum<T>( [CanBeNull] String value, out T outValue, Boolean ignoreCase = true ) where T : struct
            => Enum.TryParse( value, ignoreCase, out outValue );
    }
}
#region Usings

//using System;
//using System.Text.RegularExpressions;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Converts the given wild-card pattern to a RegEx.
        /// </summary>
        /// <param name="pattern">A wild-card pattern.</param>
        /// <returns>Returns the equivalent RegEx.</returns>
        [Pure]
        [NotNull]
        public static String WildcardToRegex( [NotNull] this String pattern )
        {
            pattern.ThrowIfNull( nameof(pattern) );

            return "^" + Regex.Escape( pattern )
                              .Replace( @"\*", ".*" )
                              .Replace( @"\?", "." )
                   + "$";
        }
    }
}