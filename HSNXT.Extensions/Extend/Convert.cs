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
        ///     Converts the value of a specified object to an equivalent Boolean value.
        /// </summary>
        /// <exception cref="FormatException">
        ///     value is a string that does not equal <see cref="System.Boolean.TrueString" /> or
        ///     <see cref="System.Boolean.FalseString" />.
        /// </exception>
        /// <exception cref="InvalidCastException">
        ///     value does not implement the IConvertible interface.
        ///     The conversion of value to a <see cref="System.Boolean" /> is not supported.
        /// </exception>
        /// <param name="obj">An object that implements the System.IConvertible interface, or null..</param>
        /// <returns>
        ///     true or false, which reflects the value returned by invoking the
        ///     System.IConvertible.ToBoolean(System.IFormatProvider) method for the underlying type of value.
        ///     If value is null, the method returns false.
        /// </returns>
        [PublicAPI]
        [Pure]
        public static Boolean ToBoolean( [CanBeNull] this Object obj )
            => Convert.ToBoolean( obj );

        /// <summary>
        ///     Converts the value of the specified object to an equivalent Boolean value, using the specified culture-specific
        ///     formatting information.
        /// </summary>
        /// <exception cref="FormatException">
        ///     value is a string that does not equal <see cref="System.Boolean.TrueString" /> or
        ///     <see cref="System.Boolean.FalseString" />.
        /// </exception>
        /// <exception cref="InvalidCastException">
        ///     value does not implement the IConvertible interface.
        ///     The conversion of value to a <see cref="System.Boolean" /> is not supported.
        /// </exception>
        /// <param name="obj">An object that implements the System.IConvertible interface, or null.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns>
        ///     true or false, which reflects the value returned by invoking the
        ///     System.IConvertible.ToBoolean(System.IFormatProvider) method for the underlying type of value.
        ///     If value is null, the method returns false.
        /// </returns>
        [PublicAPI]
        [Pure]
        public static Boolean ToBoolean( [CanBeNull] this Object obj, IFormatProvider formatProvider )
            => Convert.ToBoolean( obj, formatProvider );
        /// <summary>
        ///     Converts the value of the specified object to an 8-bit unsigned integer.
        /// </summary>
        /// <exception cref="FormatException">value is not in the property format for a <see cref="Byte" /> value.</exception>
        /// <exception cref="InvalidCastException">
        ///     value does not implement System.IConvertible. -or-Conversion from value to the
        ///     <see cref="Byte" /> type is not supported.
        /// </exception>
        /// <exception cref="OverflowException">
        ///     value represents a number that is less than <see cref="Byte.MinValue" /> or
        ///     greater than <see cref="Byte.MaxValue" />.
        /// </exception>
        /// <param name="obj">An object that implements the System.IConvertible interface.</param>
        /// <returns>An 8-bit unsigned integer that is equivalent to value, or zero if value is null.</returns>
        [Pure]
        [PublicAPI]
        public static Byte ToByte( [CanBeNull] this Object obj )
            => Convert.ToByte( obj, CultureInfo.CurrentCulture );

        /// <summary>
        ///     Converts the value of the specified object to an 8-bit unsigned integer, using the specified culture-specific
        ///     formatting information.
        /// </summary>
        /// <exception cref="FormatException">value is not in the property format for a <see cref="Byte" /> value.</exception>
        /// <exception cref="InvalidCastException">
        ///     value does not implement System.IConvertible. -or-Conversion from value to the
        ///     <see cref="Byte" /> type is not supported.
        /// </exception>
        /// <exception cref="OverflowException">
        ///     value represents a number that is less than <see cref="Byte.MinValue" /> or
        ///     greater than <see cref="Byte.MaxValue" />.
        /// </exception>
        /// <param name="obj">An object that implements the System.IConvertible interface.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns>An 8-bit unsigned integer that is equivalent to value, or zero if value is null.</returns>
        [Pure]
        [PublicAPI]
        public static Byte ToByte( [CanBeNull] this Object obj, [CanBeNull] IFormatProvider formatProvider )
            => Convert.ToByte( obj, formatProvider );
        /// <summary>
        ///     Converts the value of the specified object to a Unicode character.
        /// </summary>
        /// <exception cref="ArgumentNullException">value is a null <see cref="String" />.</exception>
        /// <exception cref="InvalidCastException">
        ///     value does not implement the System.IConvertible interface.
        ///     Or the conversion of value to a <see cref="Char" /> is not supported.
        /// </exception>
        /// <exception cref="OverflowException">
        ///     value is less than <see cref="Char.MinValue" /> or greater than <see cref="Char.MaxValue" />.
        /// </exception>
        /// <param name="obj">An object that implements the System.IConvertible interface.</param>
        /// <returns>
        ///     A Unicode character that is equivalent to value, or <see cref="Char.MinValue" /> if value is null.
        /// </returns>
        [Pure]
        [PublicAPI]
        public static Char ToChar( [CanBeNull] this Object obj )
            => Convert.ToChar( obj );

        /// <summary>
        ///     Converts the value of the specified object to its equivalent Unicode character, using the specified
        ///     culture-specific formatting information.
        /// </summary>
        /// <exception cref="ArgumentNullException">value is a null <see cref="String" />.</exception>
        /// <exception cref="InvalidCastException">
        ///     value does not implement the System.IConvertible interface.
        ///     Or the conversion of value to a <see cref="Char" /> is not supported.
        /// </exception>
        /// <exception cref="OverflowException">
        ///     value is less than <see cref="Char.MinValue" /> or greater than <see cref="Char.MaxValue" />.
        /// </exception>
        /// <param name="obj">An object that implements the System.IConvertible interface.</param>
        /// <param name="provider">A format provider.</param>
        /// <returns>
        ///     A Unicode character that is equivalent to value, or <see cref="Char.MinValue" /> if value is null.
        /// </returns>
        [Pure]
        [PublicAPI]
        public static Char ToChar( [CanBeNull] this Object obj, IFormatProvider provider )
            => Convert.ToChar( obj, provider );
        /// <summary>
        ///     Converts the value of the specified object to a System.DateTime object.
        /// </summary>
        /// <exception cref="FormatException">value is not a valid date and time value.</exception>
        /// <exception cref="InvalidCastException">
        ///     value does not implement the System.IConvertible interface.
        ///     Or the conversion is not supported.
        /// </exception>
        /// <param name="obj">An object that implements the System.IConvertible interface, or null.</param>
        /// <returns>
        ///     The date and time equivalent of the value of value, or a date and time equivalent of
        ///     <see cref="DateTime.MinValue" />
        ///     if value is null.
        /// </returns>
        [Pure]
        [PublicAPI]
        public static DateTime ToDateTime( [CanBeNull] this Object obj )
            => Convert.ToDateTime( obj );

        /// <summary>
        ///     Converts the value of the specified object to a System.DateTime object, using the specified culture-specific
        ///     formatting information.
        /// </summary>
        /// <exception cref="FormatException">value is not a valid date and time value.</exception>
        /// <exception cref="InvalidCastException">
        ///     value does not implement the System.IConvertible interface.
        ///     Or the conversion is not supported.
        /// </exception>
        /// <param name="obj">An object that implements the System.IConvertible interface, or null.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns>
        ///     The date and time equivalent of the value of value, or a date and time equivalent of
        ///     <see cref="DateTime.MinValue" />
        ///     if value is null.
        /// </returns>
        [Pure]
        [PublicAPI]
        public static DateTime ToDateTime( [CanBeNull] this Object obj, [CanBeNull] IFormatProvider formatProvider )
            => Convert.ToDateTime( obj, formatProvider );
        /// <summary>
        ///     Converts the value of the specified object to an equivalent decimal number.
        /// </summary>
        /// <exception cref="FormatException">value is not in an appropriate format for a <see cref="Decimal" /> type.</exception>
        /// <exception cref="InvalidCastException">
        ///     value does not implement the System.IConvertible interface. -or-The conversion
        ///     is not supported.
        /// </exception>
        /// <exception cref="OverflowException">
        ///     value represents a number that is less than <see cref="Decimal.MinValue" /> or greater than
        ///     <see cref="Decimal.MaxValue" />.
        /// </exception>
        /// <param name="obj">An object that implements the System.IConvertible interface, or null.</param>
        /// <returns>A decimal number that is equivalent to value, or 0 (zero) if value is null.</returns>
        [Pure]
        [PublicAPI]
        public static Decimal ToDecimal( [CanBeNull] this Object obj )
            => Convert.ToDecimal( obj );

        /// <summary>
        ///     Converts the value of the specified object to an equivalent decimal number, using the specified culture-specific
        ///     formatting information.
        /// </summary>
        /// <exception cref="FormatException">value is not in an appropriate format for a <see cref="Decimal" /> type.</exception>
        /// <exception cref="InvalidCastException">
        ///     value does not implement the System.IConvertible interface. -or-The conversion
        ///     is not supported.
        /// </exception>
        /// <exception cref="OverflowException">
        ///     value represents a number that is less than <see cref="Decimal.MinValue" /> or greater than
        ///     <see cref="Decimal.MaxValue" />.
        /// </exception>
        /// <param name="obj">An object that implements the System.IConvertible interface, or null.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns>A decimal number that is equivalent to value, or 0 (zero) if value is null.</returns>
        [Pure]
        [PublicAPI]
        public static Decimal ToDecimal( [CanBeNull] this Object obj, [CanBeNull] IFormatProvider formatProvider )
            => Convert.ToDecimal( obj, formatProvider );
        /// <summary>
        ///     Converts the value of the specified object to a double-precision floating-point number.
        /// </summary>
        /// <exception cref="FormatException">value is not in an appropriate format for a <see cref="Double" /> type.</exception>
        /// <exception cref="InvalidCastException">
        ///     value does not implement the System.IConvertible interface.
        ///     Or the conversion is not supported.
        /// </exception>
        /// <exception cref="OverflowException">
        ///     value represents a number that is less than <see cref="Double.MinValue" /> or greater than
        ///     <see cref="Double.MaxValue" />.
        /// </exception>
        /// <param name="obj">An object that implements the System.IConvertible interface, or null.</param>
        /// <returns>A double-precision floating-point number that is equivalent to value, or zero if value is null.</returns>
        [Pure]
        [PublicAPI]
        public static Double ToDouble( [CanBeNull] this Object obj )
            => Convert.ToDouble( obj );

        /// <summary>
        ///     Converts the value of the specified object to an double-precision floating-point number, using the specified
        ///     culture-specific formatting information.
        /// </summary>
        /// <exception cref="FormatException">value is not in an appropriate format for a <see cref="Double" /> type.</exception>
        /// <exception cref="InvalidCastException">
        ///     value does not implement the System.IConvertible interface.
        ///     Or the conversion is not supported.
        /// </exception>
        /// <exception cref="OverflowException">
        ///     value represents a number that is less than <see cref="Double.MinValue" /> or greater than
        ///     <see cref="Double.MaxValue" />.
        /// </exception>
        /// <param name="obj">An object that implements the System.IConvertible interface, or null.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns>A double-precision floating-point number that is equivalent to value, or zero if value is null.</returns>
        [Pure]
        [PublicAPI]
        public static Double ToDouble( [CanBeNull] this Object obj, [CanBeNull] IFormatProvider formatProvider )
            => Convert.ToDouble( obj, formatProvider );
        /// <summary>
        ///     Converts the value of the specified object to a 16-bit signed integer.
        /// </summary>
        /// <exception cref="FormatException">value is not in an appropriate format for an <see cref="Int16" /> type.</exception>
        /// <exception cref="InvalidCastException">
        ///     value does not implement the System.IConvertible interface.
        ///     Or the conversion is not supported.
        /// </exception>
        /// <exception cref="OverflowException">
        ///     value represents a number that is less than <see cref="Int16.MinValue" /> or greater than
        ///     <see cref="Int16.MaxValue" />.
        /// </exception>
        /// <param name="obj">An object that implements the System.IConvertible interface, or null.</param>
        /// <returns>A 16-bit signed integer that is equivalent to value, or zero if value is null.</returns>
        [Pure]
        [PublicAPI]
        public static Int16 ToInt16( [CanBeNull] this Object obj )
            => Convert.ToInt16( obj );

        /// <summary>
        ///     Converts the specified string representation of a number to an equivalent 16-bit signed integer, using the
        ///     specified culture-specific formatting information.
        /// </summary>
        /// <exception cref="FormatException">value is not in an appropriate format for an <see cref="Int16" /> type.</exception>
        /// <exception cref="InvalidCastException">
        ///     value does not implement the System.IConvertible interface.
        ///     Or the conversion is not supported.
        /// </exception>
        /// <exception cref="OverflowException">
        ///     value represents a number that is less than <see cref="Int16.MinValue" /> or greater than
        ///     <see cref="Int16.MaxValue" />.
        /// </exception>
        /// <param name="obj">An object that implements the System.IConvertible interface, or null.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns>A 16-bit signed integer that is equivalent to value, or zero if value is null.</returns>
        [Pure]
        [PublicAPI]
        public static Int16 ToInt16( [CanBeNull] this Object obj, [CanBeNull] IFormatProvider formatProvider )
            => Convert.ToInt16( obj, formatProvider );
        /// <summary>
        ///     Converts the value of the specified object to a 32-bit signed integer.
        /// </summary>
        /// <exception cref="FormatException">value is not in an appropriate format for an <see cref="Int32" /> type.</exception>
        /// <exception cref="InvalidCastException">
        ///     value does not implement the System.IConvertible interface.
        ///     Or the conversion is not supported.
        /// </exception>
        /// <exception cref="OverflowException">
        ///     value represents a number that is less than <see cref="Int32.MinValue" /> or greater than
        ///     <see cref="Int32.MaxValue" />.
        /// </exception>
        /// <param name="obj">An object that implements the System.IConvertible interface, or null.</param>
        /// <returns>A 32-bit signed integer that is equivalent to value, or zero if value is null.</returns>
        [Pure]
        [PublicAPI]
        public static Int32 ToInt32( [CanBeNull] this Object obj )
            => Convert.ToInt32( obj );

        /// <summary>
        ///     Converts the specified string representation of a number to an equivalent 32-bit signed integer, using the
        ///     specified culture-specific formatting information.
        /// </summary>
        /// <exception cref="FormatException">value is not in an appropriate format for an <see cref="Int32" /> type.</exception>
        /// <exception cref="InvalidCastException">
        ///     value does not implement the System.IConvertible interface.
        ///     Or the conversion is not supported.
        /// </exception>
        /// <exception cref="OverflowException">
        ///     value represents a number that is less than <see cref="Int32.MinValue" /> or greater than
        ///     <see cref="Int32.MaxValue" />.
        /// </exception>
        /// <param name="obj">An object that implements the System.IConvertible interface, or null.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns>A 32-bit signed integer that is equivalent to value, or zero if value is null.</returns>
        [Pure]
        [PublicAPI]
        public static Int32 ToInt32( [CanBeNull] this Object obj, [CanBeNull] IFormatProvider formatProvider )
            => Convert.ToInt32( obj, formatProvider );
        /// <summary>
        ///     Converts the value of the specified object to a 64-bit signed integer.
        /// </summary>
        /// <exception cref="FormatException">value is not in an appropriate format for an <see cref="Int64" /> type.</exception>
        /// <exception cref="InvalidCastException">
        ///     value does not implement the System.IConvertible interface.
        ///     Or the conversion is not supported.
        /// </exception>
        /// <exception cref="OverflowException">
        ///     value represents a number that is less than <see cref="Int64.MinValue" /> or greater than
        ///     <see cref="Int64.MaxValue" />.
        /// </exception>
        /// <param name="obj">An object that implements the System.IConvertible interface, or null.</param>
        /// <returns>A 64-bit signed integer that is equivalent to value, or zero if value is null.</returns>
        [Pure]
        [PublicAPI]
        public static Int64 ToInt64( [CanBeNull] this Object obj )
            => Convert.ToInt64( obj );

        /// <summary>
        ///     Converts the specified string representation of a number to an equivalent 64-bit signed integer, using the
        ///     specified culture-specific formatting information.
        /// </summary>
        /// <exception cref="FormatException">value is not in an appropriate format for an <see cref="Int64" /> type.</exception>
        /// <exception cref="InvalidCastException">
        ///     value does not implement the System.IConvertible interface.
        ///     Or the conversion is not supported.
        /// </exception>
        /// <exception cref="OverflowException">
        ///     value represents a number that is less than <see cref="Int64.MinValue" /> or greater than
        ///     <see cref="Int64.MaxValue" />.
        /// </exception>
        /// <param name="obj">An object that implements the System.IConvertible interface, or null.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns>A 64-bit signed integer that is equivalent to value, or zero if value is null.</returns>
        [Pure]
        [PublicAPI]
        public static Int64 ToInt64( [CanBeNull] this Object obj, [CanBeNull] IFormatProvider formatProvider )
            => Convert.ToInt64( obj, formatProvider );
    }
}
﻿

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="string" />.
    /// </summary>
    [PublicAPI]
    public static partial class Extensions
    {
        /// <summary>
        ///     Converts the given string to a boolean.
        /// </summary>
        /// <remarks>
        ///     The framework does not know a culture specific convert method, so does this library.
        /// </remarks>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="FormatException">Value is not equal to System.Boolean.TrueString or System.Boolean.FalseString.</exception>
        /// <param name="value">The string to convert.</param>
        /// <returns>Returns the boolean.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean ToBoolean( [NotNull] this String value )
        {
            value.ThrowIfNull( nameof(value) );

            return Boolean.Parse( value );
        }
        /// <summary>
        ///     Converts the given string to a byte.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentNullException">The format provider can not be null.</exception>
        /// <exception cref="FormatException">The value is not of the correct format.</exception>
        /// <exception cref="OverflowException">
        ///     The value represents a number less than System.Byte.MinValue or greater than
        ///     System.Byte.MaxValue.
        /// </exception>
        /// <param name="value">The string to convert.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns>Returns a byte value that is equivalent to the number contained in value.</returns>
        [Pure]
        [PublicAPI]
        public static Byte ToByte( [NotNull] this String value, [NotNull] IFormatProvider formatProvider )
        {
            value.ThrowIfNull( nameof(value) );
            formatProvider.ThrowIfNull( nameof(formatProvider) );

            return Byte.Parse( value, formatProvider );
        }
        /// <summary>
        ///     Converts the first character of a specified string to a Unicode character.
        /// </summary>
        /// <remarks>
        ///     The framework does not know a culture specific convert method, so does this library.
        /// </remarks>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="FormatException">The length of value is not 1.</exception>
        /// <param name="value">A string of length 1.</param>
        /// <returns>Returns a Unicode character that is equivalent to the first and only character in value.</returns>
        [Pure]
        [PublicAPI]
        public static Char ToChar( [NotNull] this String value )
        {
            value.ThrowIfNull( nameof(value) );

            return Convert.ToChar( value );
        }
        /// <summary>
        ///     Converts the given string to a date time value.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="FormatException">Value does not contain a valid string representation of a date and time.</exception>
        /// <param name="value">The string to convert.</param>
        /// <returns>Returns the date time value.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime ToDateTime( [NotNull] this String value )
        {
            value.ThrowIfNull( nameof(value) );

            return DateTime.Parse( value, CultureInfo.InvariantCulture );
        }
        /// <summary>
        ///     Converts the given string to a decimal.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="FormatException">The value is not in the correct format.</exception>
        /// <exception cref="OverflowException">
        ///     value represents a number less than <see cref="Decimal.MinValue" /> or greater than
        ///     <see cref="Decimal.MaxValue" />.
        /// </exception>
        /// <param name="value">The string to convert.</param>
        /// <returns>The decimal.</returns>
        [Pure]
        [PublicAPI]
        public static Decimal ToDecimal( [NotNull] this String value )
        {
            value.ThrowIfNull( nameof(value) );

            return Decimal.Parse( value );
        }

        /// <summary>
        ///     Converts the given string to a decimal.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentNullException">The format provider can not be null.</exception>
        /// <exception cref="FormatException">The value is not in the correct format.</exception>
        /// <exception cref="OverflowException">
        ///     value represents a number less than <see cref="Decimal.MinValue" /> or greater than
        ///     <see cref="Decimal.MaxValue" />.
        /// </exception>
        /// <param name="value">The string to convert.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns>The decimal.</returns>
        [Pure]
        [PublicAPI]
        public static Decimal ToDecimal( [NotNull] this String value, [NotNull] IFormatProvider formatProvider )
        {
            value.ThrowIfNull( nameof(value) );
            formatProvider.ThrowIfNull( nameof(formatProvider) );

            return Decimal.Parse( value, formatProvider );
        }
        /// <summary>
        ///     Converts the given string to a double.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="FormatException">value does not represent a number in a valid format.</exception>
        /// <exception cref="OverflowException">
        ///     value represents a number that is less than <see cref="Double.MinValue" /> or
        ///     greater than <see cref="Double.MaxValue" />.
        /// </exception>
        /// <param name="value">The string to convert.</param>
        /// <returns>The double.</returns>
        [Pure]
        [PublicAPI]
        public static Double ToDouble( [NotNull] this String value )
        {
            value.ThrowIfNull( nameof(value) );

            return Double.Parse( value );
        }

        /// <summary>
        ///     Converts the given string to a double.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentNullException">The format provider can not be null.</exception>
        /// <exception cref="FormatException">value does not represent a number in a valid format.</exception>
        /// <exception cref="OverflowException">
        ///     value represents a number that is less than <see cref="Double.MinValue" /> or
        ///     greater than <see cref="Double.MaxValue" />.
        /// </exception>
        /// <param name="value">The string to convert.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns>The double.</returns>
        [Pure]
        [PublicAPI]
        public static Double ToDouble( [NotNull] this String value, [NotNull] IFormatProvider formatProvider )
        {
            value.ThrowIfNull( nameof(value) );
            formatProvider.ThrowIfNull( nameof(formatProvider) );

            return Double.Parse( value, formatProvider );
        }
        /// <summary>
        ///     Converts the given string to a GUID.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="FormatException">value is not in a recognized format.</exception>
        /// <param name="value">The string to convert.</param>
        /// <returns>Returns the converted GUID.</returns>
        [Pure]
        [PublicAPI]
        public static Guid ToGuid( [NotNull] this String value )
        {
            value.ThrowIfNull( nameof(value) );

            return Guid.Parse( value );
        }
        /// <summary>
        ///     Converts the given string to a Int16.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="FormatException">value  s not in the correct format.</exception>
        /// <exception cref="OverflowException">
        ///     value represents a number less than <see cref="Int16.MinValue" /> or greater than
        ///     <see cref="Int16.MaxValue" />.
        /// </exception>
        /// <param name="value">The string to convert.</param>
        /// <returns>Returns the converted Int16.</returns>
        [Pure]
        [PublicAPI]
        public static Int16 ToInt16( [NotNull] this String value )
        {
            value.ThrowIfNull( nameof(value) );

            return Int16.Parse( value );
        }

        /// <summary>
        ///     Converts the given string to a Int16.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentNullException">The format provider can not be null.</exception>
        /// <exception cref="FormatException">value  s not in the correct format.</exception>
        /// <exception cref="OverflowException">
        ///     value represents a number less than <see cref="Int16.MinValue" /> or greater than
        ///     <see cref="Int16.MaxValue" />.
        /// </exception>
        /// <param name="value">The string to convert.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns>Returns the converted Int16.</returns>
        [Pure]
        [PublicAPI]
        public static Int16 ToInt16( [NotNull] this String value, [NotNull] IFormatProvider formatProvider )
        {
            value.ThrowIfNull( nameof(value) );
            formatProvider.ThrowIfNull( nameof(formatProvider) );

            return Int16.Parse( value, formatProvider );
        }
        /// <summary>
        ///     Converts the given string to a Int32.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="FormatException">value  s not in the correct format.</exception>
        /// <exception cref="OverflowException">
        ///     value represents a number less than <see cref="Int32.MinValue" /> or greater than
        ///     <see cref="Int32.MaxValue" />.
        /// </exception>
        /// <param name="value">The string to convert.</param>
        /// <returns>Returns the converted Int32.</returns>
        [Pure]
        [PublicAPI]
        public static Int32 ToInt32( [NotNull] this String value )
        {
            value.ThrowIfNull( nameof(value) );

            return Int32.Parse( value );
        }

        /// <summary>
        ///     Converts the given string to a Int32.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentNullException">The format provider can not be null.</exception>
        /// <exception cref="FormatException">value  s not in the correct format.</exception>
        /// <exception cref="OverflowException">
        ///     value represents a number less than <see cref="Int32.MinValue" /> or greater than
        ///     <see cref="Int32.MaxValue" />.
        /// </exception>
        /// <param name="value">The string to convert.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns>Returns the converted Int32.</returns>
        [Pure]
        [PublicAPI]
        public static Int32 ToInt32( [NotNull] this String value, [NotNull] IFormatProvider formatProvider )
        {
            value.ThrowIfNull( nameof(value) );
            formatProvider.ThrowIfNull( nameof(formatProvider) );

            return Int32.Parse( value, formatProvider );
        }
        /// <summary>
        ///     Converts the given string to a Int64.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="FormatException">value  s not in the correct format.</exception>
        /// <exception cref="OverflowException">
        ///     value represents a number less than <see cref="Int64.MinValue" /> or greater than
        ///     <see cref="Int64.MaxValue" />.
        /// </exception>
        /// <param name="value">The string to convert.</param>
        /// <returns>Returns the converted Int64.</returns>
        [Pure]
        [PublicAPI]
        public static Int64 ToInt64( [NotNull] this String value )
        {
            value.ThrowIfNull( nameof(value) );

            return Int64.Parse( value );
        }

        /// <summary>
        ///     Converts the given string to a Int64.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentNullException">The format provider can not be null.</exception>
        /// <exception cref="FormatException">value  s not in the correct format.</exception>
        /// <exception cref="OverflowException">
        ///     value represents a number less than <see cref="Int64.MinValue" /> or greater than
        ///     <see cref="Int64.MaxValue" />.
        /// </exception>
        /// <param name="value">The string to convert.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns>Returns the converted Int64.</returns>
        [Pure]
        [PublicAPI]
        public static Int64 ToInt64( [NotNull] this String value, [NotNull] IFormatProvider formatProvider )
        {
            value.ThrowIfNull( nameof(value) );
            formatProvider.ThrowIfNull( nameof(formatProvider) );

            return Int64.Parse( value, formatProvider );
        }
    }
}