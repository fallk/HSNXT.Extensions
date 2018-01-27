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
        ///     Tries to convert the specified string representation of a logical value to
        ///     its <see cref="Boolean" /> equivalent. A return value indicates whether the conversion
        ///     succeeded or failed.
        /// </summary>
        /// <param name="value">A string containing the value to convert.</param>
        /// <param name="outValue">
        ///     When this method returns, if the conversion succeeded, contains true if value
        ///     is equal to <see cref="Boolean.TrueString" /> or false if value is equal to <see cref="Boolean.FalseString" />.
        ///     If the conversion failed, contains false. The conversion fails if value is
        ///     null or is not equal to the value of either the <see cref="Boolean.TrueString" />
        ///     or <see cref="Boolean.FalseString" /> field.
        /// </param>
        /// <returns>Returns true if the parsing was successful, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean TryParsBoolean( [CanBeNull] this String value, out Boolean outValue )
            => Boolean.TryParse( value, out outValue );

        /// <summary>
        ///     Tries to convert the string representation of a number to its <see cref="Byte" />
        ///     equivalent, and returns a value that indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="value">
        ///     A string that contains a number to convert. The string is interpreted using
        ///     the <see cref="NumberStyles.Integer" /> numberStyle.
        ///     The string to pars.
        /// </param>
        /// <param name="outValue">
        ///     The parsed value.
        ///     When this method returns, contains the <see cref="Byte" /> value equivalent to the
        ///     number contained in s if the conversion succeeded, or zero if the conversion
        ///     failed. This parameter is passed uninitialized.
        /// </param>
        /// <returns>Returns true if the parsing was successful, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean TryParsByte( [CanBeNull] this String value, out Byte outValue )
            => Byte.TryParse( value, out outValue );

        /// <summary>
        ///     Converts the string representation of a number in a specified numberStyle and culture-specific
        ///     format to its <see cref="Byte" /> equivalent. A return value indicates whether the
        ///     conversion succeeded or failed.
        /// </summary>
        /// <exception cref="ArgumentNullException">formatProvider can not be null.</exception>
        /// <exception cref="ArgumentException">
        ///     numberStyle is not a <see cref="NumberStyles" /> value. -or-style is not a
        ///     combination of <see cref="NumberStyles.AllowHexSpecifier" /> and
        ///     <see cref="NumberStyles.HexNumber" /> values.
        /// </exception>
        /// <param name="value">
        ///     A string containing a number to convert. The string is interpreted using
        ///     the numberStyle specified by numberStyle.
        /// </param>
        /// <param name="numberStyle">
        ///     A bitwise combination of enumeration values that indicates the numberStyle elements
        ///     that can be present in s. A typical value to specify is <see cref="NumberStyles.Integer" />.
        /// </param>
        /// <param name="formatProvider">
        ///     An object that supplies culture-specific formatting information about s.
        ///     If formatProvider is null, the thread current culture is used.
        /// </param>
        /// <param name="outValue">
        ///     When this method returns, contains the 8-bit unsigned integer value equivalent
        ///     to the number contained in s if the conversion succeeded, or zero if the
        ///     conversion failed. The conversion fails if the s parameter is null or <see cref="String.Empty" />,
        ///     is not of the correct format, or represents a number less than <see cref="Byte.MinValue" />
        ///     or greater than <see cref="Byte.MaxValue" />. This parameter is passed uninitialized.
        /// </param>
        /// <returns>Returns true if the parsing was successful, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean TryParsByte( [CanBeNull] this String value,
                                           NumberStyles numberStyle,
                                           [NotNull] IFormatProvider formatProvider,
                                           out Byte outValue )
        {
            formatProvider.ThrowIfNull( nameof(formatProvider) );

            return Byte.TryParse( value, numberStyle, formatProvider, out outValue );
        }

        /// <summary>
        ///     Converts the value of the specified string to its equivalent Unicode character.
        ///     A return code indicates whether the conversion succeeded or failed.
        /// </summary>
        /// <param name="value">A string that contains a single character.</param>
        /// <param name="outValue">
        ///     When this method returns, contains a Unicode character equivalent to the
        ///     sole character in s, if the conversion succeeded, or an undefined value if
        ///     the conversion failed. The conversion fails if the s parameter is null or
        ///     the length of s is not 1. This parameter is passed uninitialized.
        /// </param>
        /// <returns>Returns true if the parsing was successful, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean TryParsChar( [CanBeNull] this String value, out Char outValue )
            => Char.TryParse( value, out outValue );

        /// <summary>
        ///     Converts the specified string representation of a date and time to its <see cref="DateTime" /> equivalent and
        ///     returns a value that
        ///     indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="value">A <see cref="String" /> containing a date and time to convert.</param>
        /// <param name="result">
        ///     When this method returns, contains the <see cref="DateTime" /> value equivalent to the date and time contained in
        ///     <paramref name="value" />, if the conversion succeeded, or <see cref="DateTime.MinValue" /> if the conversion
        ///     failed. The conversion fails if the <paramref name="value" />
        ///     parameter is null, is an empty string (""), or does not contain a valid string representation of a date and time.
        ///     This parameter is passed uninitialized.
        /// </param>
        /// <returns>Returns true if the s parameter was converted successfully; otherwise, false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean TryParsDateTime( [CanBeNull] this String value, out DateTime result )
            => DateTime.TryParse( value, out result );

        /// <summary>
        ///     Converts the specified string representation of a date and time to its <see cref="DateTime" /> equivalent using the
        ///     specified culture-specific format information and formatting style, and returns a value that indicates whether the
        ///     conversion succeeded.
        /// </summary>
        /// <exception cref="ArgumentNullException">The format provider can not be null.</exception>
        /// <exception cref="ArgumentException">
        ///     dateTimeStyle is not a valid <see cref="DateTimeStyles" /> value.-or-styles contains
        ///     an invalid combination of <see cref="DateTimeStyles" /> values (for example, both
        ///     <see cref="DateTimeStyles.AssumeLocal" /> and <see cref="DateTimeStyles.AssumeUniversal" />).
        /// </exception>
        /// <param name="value">A <see cref="String" />containing a date and time to convert.</param>
        /// <param name="formatProvider">
        ///     An object that supplies culture-specific formatting information about
        ///     <paramref name="value" />.
        /// </param>
        /// <param name="dateTimeStyle">
        ///     A bitwise combination of enumeration values that defines how to interpret the parsed date in relation to the
        ///     current time zone or the current date.
        ///     A typical value to specify is <see cref="DateTimeStyles.None" />.
        /// </param>
        /// <param name="result">
        ///     When this method returns, contains the <see cref="DateTime" /> value equivalent to the date and time contained in
        ///     <paramref name="value" />, if the conversion succeeded, or <see cref="DateTime.MinValue" /> if the conversion
        ///     failed. The conversion fails if the <paramref name="value" /> parameter is
        ///     null, is an empty string (""), or does not contain a valid string representation of a date and time.
        ///     This parameter is passed uninitialized.
        /// </param>
        /// <returns>Returns true if the s parameter was converted successfully; otherwise, false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean TryParsDateTime( [CanBeNull] this String value,
                                               [NotNull] IFormatProvider formatProvider,
                                               DateTimeStyles dateTimeStyle,
                                               out DateTime result )
        {
            formatProvider.ThrowIfNull( nameof(formatProvider) );

            return DateTime.TryParse( value, formatProvider, dateTimeStyle, out result );
        }

        /// <summary>
        ///     Converts the specified string representation of a date and time to its DateTime equivalent using the specified
        ///     format,
        ///     culture-specific format information, and style.
        ///     The format of the string representation must match the specified format exactly.
        ///     The method returns a value that indicates whether the conversion succeeded.
        /// </summary>
        /// <exception cref="ArgumentNullException">format can not be null.</exception>
        /// <exception cref="ArgumentNullException">format provider can not be null.</exception>
        /// <exception cref="ArgumentException">
        ///     dateTimeStyle is not a valid <see cref="DateTimeStyles" /> value.-or-styles
        ///     contains an invalid combination of <see cref="DateTimeStyles" /> values (for example, both
        ///     <see cref="DateTimeStyles.AssumeLocal" /> and <see cref="DateTimeStyles.AssumeUniversal" />).
        /// </exception>
        /// <param name="value">A <see cref="String" /> containing a date and time to convert.</param>
        /// <param name="format">The required format of s. See the Remarks section for more information.</param>
        /// <param name="formatProvider">
        ///     An object that supplies culture-specific formatting information about
        ///     <paramref name="value" />.
        /// </param>
        /// <param name="dateTimeStyle">
        ///     A bitwise combination of one or more enumeration values that indicate the permitted format
        ///     of <paramref name="value" />.
        /// </param>
        /// <param name="outValue">
        ///     When this method returns, contains the s<see cref="DateTime" /> value equivalent to the date and time contained in
        ///     <paramref name="value" />,
        ///     if the conversion succeeded, or <see cref="DateTime.MinValue" /> if the conversion failed.
        ///     The conversion fails if either the s or format parameter is null, is an empty string, or does not contain a date
        ///     and time that correspond to the pattern specified in format.
        ///     This parameter is passed uninitialized.
        /// </param>
        /// <returns>Returns true if the parsing was successful, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean TryParsDateTimeExact( [CanBeNull] this String value,
                                                    [NotNull] String format,
                                                    [NotNull] IFormatProvider formatProvider,
                                                    DateTimeStyles dateTimeStyle,
                                                    out DateTime outValue )
        {
            format.ThrowIfNull( nameof(format) );
            formatProvider.ThrowIfNull( nameof(formatProvider) );

            return DateTime.TryParseExact( value, format, formatProvider, dateTimeStyle, out outValue );
        }

        /// <summary>
        ///     Converts the specified string representation of a date and time to its <see cref="DateTime" /> equivalent using the
        ///     specified array of formats,
        ///     culture-specific format information, and style. The format of the string representation must match at least one of
        ///     the specified formats exactly.
        ///     The method returns a value that indicates whether the conversion succeeded.
        /// </summary>
        /// <remarks>
        ///     The DateTime.TryParseExact(String, String[], IFormatProvider, DateTimeStyles, DateTime) method parses the string
        ///     representation
        ///     of a date that matches any one of the patterns assigned to the formats parameter.
        ///     It is like the DateTime.ParseExact(String, String[], IFormatProvider, DateTimeStyles) method, except the
        ///     TryParseExact method does not throw an exception if the conversion fails.
        /// </remarks>
        /// <exception cref="ArgumentNullException">formats can not be null.</exception>
        /// <exception cref="ArgumentNullException">format provider can not be null.</exception>
        /// <exception cref="ArgumentException">
        ///     dateTimeStyle is not a valid <see cref="DateTimeStyles" /> value.-or-styles
        ///     contains an invalid combination of <see cref="DateTimeStyles" /> values (for example, both
        ///     <see cref="DateTimeStyles.AssumeLocal" /> and <see cref="DateTimeStyles.AssumeUniversal" />).
        /// </exception>
        /// <param name="value">A <see cref="String" /> containing a date and time to convert.</param>
        /// <param name="formats">An array of allowable formats of s. See the Remarks section for more information.</param>
        /// <param name="formatProvider">
        ///     An object that supplies culture-specific formatting information about
        ///     <paramref name="value" />.
        /// </param>
        /// <param name="dateTimeStyle">
        ///     A bitwise combination of one or more enumeration values that indicate the permitted format
        ///     of <paramref name="value" />.
        /// </param>
        /// <param name="outValue">
        ///     When this method returns, contains the s<see cref="DateTime" /> value equivalent to the date and time contained in
        ///     <paramref name="value" />,
        ///     if the conversion succeeded, or <see cref="DateTime.MinValue" /> if the conversion failed.
        ///     The conversion fails if either the s or format parameter is null, is an empty string, or does not contain a date
        ///     and time that correspond to the pattern specified in format.
        ///     This parameter is passed uninitialized.
        /// </param>
        /// <returns>Returns true if the parsing was successful, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean TryParsDateTimeExact( [CanBeNull] this String value,
                                                    [NotNull] String[] formats,
                                                    [NotNull] IFormatProvider formatProvider,
                                                    DateTimeStyles dateTimeStyle,
                                                    out DateTime outValue )
        {
            formats.ThrowIfNull( nameof(formats) );
            formatProvider.ThrowIfNull( nameof(formatProvider) );

            return DateTime.TryParseExact( value, formats, formatProvider, dateTimeStyle, out outValue );
        }

        /// <summary>
        ///     Converts the string representation of a number to its <see cref="Decimal" /> equivalent.
        ///     A return value indicates whether the conversion succeeded or failed.
        /// </summary>
        /// <param name="value">The string representation of the number to convert.</param>
        /// <param name="outValue">
        ///     The parsed value.
        ///     When this method returns, contains the <see cref="Decimal" /> number that is equivalent
        ///     to the numeric value contained in s, if the conversion succeeded, or is zero
        ///     if the conversion failed. The conversion fails if the s parameter is null
        ///     or System.String.Empty, is not a number in a valid format, or represents
        ///     a number less than <see cref="Decimal.MinValue" /> or greater than <see cref="Decimal.MaxValue" />.
        ///     This parameter is passed uninitialized.
        /// </param>
        /// <returns>Returns true if the parsing was successful, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean TryParsDecimal( [CanBeNull] this String value, out Decimal outValue )
            => Decimal.TryParse( value, out outValue );

        /// <summary>
        ///     Converts the string representation of a number to its System.Decimal equivalent
        ///     using the specified numberStyle and culture-specific format. A return value indicates
        ///     whether the conversion succeeded or failed.
        /// </summary>
        /// <exception cref="ArgumentNullException">formatProvider can not be null.</exception>
        /// <exception cref="ArgumentException">
        ///     numberStyle is not a System.Globalization.NumberStyles value. -or-style is the
        ///     <see cref="NumberStyles.AllowHexSpecifier" />  value.
        /// </exception>
        /// <param name="value">The string representation of the number to convert.</param>
        /// <param name="numberStyle">
        ///     A bitwise combination of enumeration values that indicates the permitted
        ///     format of value. A typical value to specify is System.Globalization.NumberStyles.Number.
        /// </param>
        /// <param name="formatProvider">An object that supplies culture-specific parsing information about value.</param>
        /// <param name="outValue">
        ///     When this method returns, contains the System.Decimal number that is equivalent
        ///     to the numeric value contained in s, if the conversion succeeded, or is zero
        ///     if the conversion failed. The conversion fails if the s parameter is null
        ///     or System.String.Empty, is not in a format compliant with numberStyle, or represents
        ///     a number less than System.Decimal.MinValue or greater than System.Decimal.MaxValue.
        ///     This parameter is passed uninitialized.
        /// </param>
        /// <returns>Returns true if the parsing was successful, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean TryParsDecimal( [CanBeNull] this String value,
                                              NumberStyles numberStyle,
                                              [NotNull] IFormatProvider formatProvider,
                                              out Decimal outValue )
        {
            formatProvider.ThrowIfNull( nameof(formatProvider) );

            return Decimal.TryParse( value, numberStyle, CultureInfo.InvariantCulture, out outValue );
        }

        /// <summary>
        ///     Converts the string representation of a number to its double-precision floating-point
        ///     number equivalent. A return value indicates whether the conversion succeeded
        ///     or failed.
        /// </summary>
        /// <param name="value">A string containing a number to convert.</param>
        /// <param name="outValue">
        ///     When this method returns, contains the double-precision floating-point number
        ///     equivalent of the <paramref name="value" /> parameter, if the conversion succeeded, or zero if the
        ///     conversion failed. The conversion fails if the <paramref name="value" /> parameter is null or
        ///     <see cref="String.Empty" />,
        ///     is not a number in a valid format, or represents a number less than <see cref="Double.MinValue" />
        ///     or greater than <see cref="Double.MaxValue" />. This parameter is passed uninitialized.
        /// </param>
        /// <returns>Returns true if the parsing was successful, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean TryParsDouble( [CanBeNull] this String value, out Double outValue )
            => Double.TryParse( value, out outValue );

        /// <summary>
        ///     Converts the string representation of a number in a specified numberStyle and culture-specific
        ///     format to its double-precision floating-point number equivalent. A return
        ///     value indicates whether the conversion succeeded or failed.
        /// </summary>
        /// <exception cref="ArgumentException">
        ///     numberStyle is not a <see cref="NumberStyles" /> value. -or-numberStyle includes
        ///     the <see cref="NumberStyles.AllowHexSpecifier" /> value.
        /// </exception>
        /// <exception cref="ArgumentNullException">formatProvider can not be null.</exception>
        /// <param name="value">A string containing a number to convert.</param>
        /// <param name="numberStyle">
        ///     A bitwise combination of <see cref="NumberStyles" /> values that indicates
        ///     the permitted format of <paramref name="value" />. A typical value to specify is <see cref="NumberStyles.Float" />
        ///     combined with <see cref="NumberStyles.AllowThousands" />.
        /// </param>
        /// <param name="formatProvider">
        ///     An <see cref="System.IFormatProvider" /> that supplies culture-specific formatting information about
        ///     <paramref name="value" />.
        /// </param>
        /// <param name="outValue">
        ///     When this method returns, contains a double-precision floating-point number
        ///     equivalent of the numeric value or symbol contained in <paramref name="value" />, if the conversion
        ///     succeeded, or zero if the conversion failed. The conversion fails if the
        ///     <paramref name="value" /> parameter is null or <see cref="String.Empty" />, is not in a format compliant
        ///     with numberStyle, represents a number less than <see cref="SByte.MinValue" /> or greater
        ///     than <see cref="SByte.MaxValue" />, or if numberStyle is not a valid combination of <see cref="NumberStyles" />
        ///     enumerated constants. This parameter is passed uninitialized.
        /// </param>
        /// <returns>Returns true if the parsing was successful, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean TryParsDouble( [CanBeNull] this String value,
                                             NumberStyles numberStyle,
                                             [NotNull] IFormatProvider formatProvider,
                                             out Double outValue )
        {
            formatProvider.ThrowIfNull( nameof(formatProvider) );

            return Double.TryParse( value, numberStyle, formatProvider, out outValue );
        }

        /// <summary>
        ///     Converts the string representation of a GUID to the equivalent <see cref="Guid" /> structure.
        /// </summary>
        /// <param name="value">The GUID to convert.</param>
        /// <param name="outValue">
        ///     The structure that will contain the parsed value. If the method returns true,result contains a
        ///     valid <see cref="Guid" />. If the method returns false, result equals <see cref="Guid.Empty" />.
        /// </param>
        /// <returns>Returns true if the parse operation was successful; otherwise, false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean TryParsGuid( [CanBeNull] this String value, out Guid outValue )
            => Guid.TryParse( value, out outValue );

        /// <summary>
        ///     Converts the string representation of a number to its 16-bit signed integer
        ///     equivalent. A return value indicates whether the conversion succeeded or
        ///     failed.
        /// </summary>
        /// <param name="value">A string containing a number to convert.</param>
        /// <param name="outValue">
        ///     When this method returns, contains the 16-bit signed integer value equivalent
        ///     to the number contained in s, if the conversion succeeded, or zero if the
        ///     conversion failed. The conversion fails if the s parameter is null or <see cref="String.Empty" />,
        ///     is not of the correct format, or represents a number less than <see cref="Int16.MinValue" />
        ///     or greater than <see cref="Int16.MaxValue" />. This parameter is passed uninitialized.
        /// </param>
        /// <returns>Returns true if the parsing was successful, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean TryParsInt16( [CanBeNull] this String value, out Int16 outValue )
            => Int16.TryParse( value, out outValue );

        /// <summary>
        ///     Converts the string representation of a number in a specified numberStyle and culture-specific
        ///     format to its 16-bit signed integer equivalent. A return value indicates
        ///     whether the conversion succeeded or failed.
        /// </summary>
        /// <exception cref="ArgumentNullException">formatProvider can not be null.</exception>
        /// <exception cref="ArgumentException">
        ///     numberStyle is not a <see cref="NumberStyles" /> value. -or-style is not a
        ///     combination of <see cref="NumberStyles.AllowHexSpecifier" /> and <see cref="NumberStyles.HexNumber" />
        ///     values.
        /// </exception>
        /// <param name="value">
        ///     A string containing a number to convert.
        /// </param>
        /// <param name="numberStyle">
        ///     A bitwise combination of enumeration values that indicates the numberStyle elements
        ///     that can be present in value. A typical value to specify is <see cref="NumberStyles.Integer" />.
        /// </param>
        /// <param name="formatProvider">An object that supplies culture-specific formatting information about value.</param>
        /// <param name="outValue">
        ///     When this method returns, contains the 16-bit signed integer value equivalent
        ///     to the number contained in s, if the conversion succeeded, or zero if the
        ///     conversion failed. The conversion fails if the s parameter is null or <see cref="System.String.Empty" />,
        ///     is not in a format compliant with numberStyle, or represents a number less than
        ///     <see cref="System.Int16.MinValue" /> or greater than <see cref="System.Int16.MaxValue" />. This parameter
        ///     is passed uninitialized.
        /// </param>
        /// <returns>Returns true if the parsing was successful, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean TryParsInt16( [CanBeNull] this String value,
                                            NumberStyles numberStyle,
                                            [NotNull] IFormatProvider formatProvider,
                                            out Int16 outValue )
        {
            formatProvider.ThrowIfNull( nameof(formatProvider) );

            return Int16.TryParse( value, numberStyle, formatProvider, out outValue );
        }

        /// <summary>
        ///     Converts the string representation of a number to its 32-bit signed integer
        ///     equivalent. A return value indicates whether the conversion succeeded or
        ///     failed.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <param name="value">A string containing a number to convert.</param>
        /// <param name="outValue">
        ///     When this method returns, contains the 32-bit signed integer value equivalent
        ///     to the number contained in s, if the conversion succeeded, or zero if the
        ///     conversion failed. The conversion fails if the s parameter is null or <see cref="String.Empty" />,
        ///     is not of the correct format, or represents a number less than <see cref="Int32.MinValue" />
        ///     or greater than <see cref="Int32.MaxValue" />. This parameter is passed uninitialized.
        /// </param>
        /// <returns>Returns true if the parsing was successful, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean TryParsInt32( [CanBeNull] this String value, out Int32 outValue )
            => Int32.TryParse( value, out outValue );

        /// <summary>
        ///     Converts the string representation of a number in a specified numberStyles and culture-specific
        ///     format to its 32-bit signed integer equivalent. A return value indicates
        ///     whether the conversion succeeded or failed.
        /// </summary>
        /// <exception cref="ArgumentNullException">formatProvider can not be null.</exception>
        /// <exception cref="ArgumentException">
        ///     numberStyle is not a <see cref="System.Globalization.NumberStyles" /> value. -or-style is not a
        ///     combination of <see cref="System.Globalization.NumberStyles.AllowHexSpecifier" /> and
        ///     <see cref="System.Globalization.NumberStyles.HexNumber" /> values.
        /// </exception>
        /// <param name="value">
        ///     A string containing a number to convert. The string is interpreted using
        /// </param>
        /// <param name="numberStyles">
        ///     A bitwise combination of enumeration values that indicates the numberStyles elements
        ///     that can be present in value. A typical value to specify is <see cref="NumberStyles.Integer" />.
        /// </param>
        /// <param name="formatProvider">An object that supplies culture-specific formatting information about value.</param>
        /// <param name="outValue">
        ///     When this method returns, contains the 32-bit signed integer value equivalent
        ///     to the number contained in s, if the conversion succeeded, or zero if the
        ///     conversion failed. The conversion fails if the s parameter is null or <see cref="String.Empty" />,
        ///     is not in a format compliant with numberStyles, or represents a number less than
        ///     <see cref="Int32.MinValue" /> or greater than <see cref="Int32.MaxValue" />. This parameter
        ///     is passed uninitialized.
        /// </param>
        /// <returns>Returns true if the parsing was successful, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean TryParsInt32( [CanBeNull] this String value,
                                            NumberStyles numberStyles,
                                            [NotNull] IFormatProvider formatProvider,
                                            out Int32 outValue )
        {
            formatProvider.ThrowIfNull( nameof(formatProvider) );

            return Int32.TryParse( value, numberStyles, formatProvider, out outValue );
        }

        /// <summary>
        ///     Converts the string representation of a number to its 64-bit signed integer
        ///     equivalent. A return value indicates whether the conversion succeeded or
        ///     failed.
        /// </summary>
        /// <param name="value">A string containing a number to convert.</param>
        /// <param name="outValue">
        ///     When this method returns, contains the 64-bit signed integer value equivalent
        ///     to the number contained in s, if the conversion succeeded, or zero if the
        ///     conversion failed. The conversion fails if the s parameter is null or <see cref="String.Empty" />,
        ///     is not of the correct format, or represents a number less than <see cref="Int64.MinValue" />
        ///     or greater than <see cref="Int64.MaxValue" />. This parameter is passed uninitialized.
        /// </param>
        /// <returns>Returns true if the parsing was successful, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean TryParsInt64( [CanBeNull] this String value, out Int64 outValue )
            => Int64.TryParse( value, out outValue );

        /// <summary>
        ///     Converts the string representation of a number in a specified numberStyle and culture-specific
        ///     format to its 64-bit signed integer equivalent. A return value indicates
        ///     whether the conversion succeeded or failed.
        /// </summary>
        /// <exception cref="ArgumentNullException">formatProvider can not be null.</exception>
        /// <exception cref="ArgumentException">
        ///     numberStyle is not a <see cref="System.Globalization.NumberStyles" /> value. -or-style is not a
        ///     combination of <see cref="System.Globalization.NumberStyles.AllowHexSpecifier" /> and
        ///     <see cref="System.Globalization.NumberStyles.HexNumber" /> values.
        /// </exception>
        /// <param name="value">
        ///     A string containing a number to convert. The string is interpreted using
        /// </param>
        /// <param name="numberStyle">
        ///     A bitwise combination of enumeration values that indicates the numberStyle elements
        ///     that can be present in value. A typical value to specify is <see cref="NumberStyles.Integer" />.
        /// </param>
        /// <param name="formatProvider">An object that supplies culture-specific formatting information about value.</param>
        /// <param name="outValue">
        ///     When this method returns, contains the 64-bit signed integer value equivalent
        ///     to the number contained in s, if the conversion succeeded, or zero if the
        ///     conversion failed. The conversion fails if the s parameter is null or <see cref="String.Empty" />,
        ///     is not in a format compliant with numberStyle, or represents a number less than
        ///     <see cref="Int64.MinValue" /> or greater than <see cref="Int64.MaxValue" />. This parameter
        ///     is passed uninitialized.
        /// </param>
        /// <returns>Returns true if the parsing was successful, otherwise false.</returns>
        public static Boolean TryParsInt64( [CanBeNull] this String value,
                                            NumberStyles numberStyle,
                                            [NotNull] IFormatProvider formatProvider,
                                            out Int64 outValue )
        {
            formatProvider.ThrowIfNull( nameof(formatProvider) );

            return Int64.TryParse( value, numberStyle, formatProvider, out outValue );
        }
    }
}