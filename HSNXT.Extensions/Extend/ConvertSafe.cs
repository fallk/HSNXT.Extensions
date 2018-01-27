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
        ///     its <see cref="Boolean" /> equivalent.
        /// </summary>
        /// <param name="value">A string containing the value to convert.</param>
        /// <param name="defaultValue">The default value, returned if the conversion fails.</param>
        /// <returns>Returns the converted value, or the given default value if the conversion failed.</returns>
        [Pure]
        [PublicAPI]
        public static bool SafeToBoolean( [CanBeNull] this string value, bool defaultValue = default(bool) )
            => value.TryParsBoolean( out var outValue ) ? outValue : defaultValue;
        /// <summary>
        ///     Tries to convert the string representation of a number to its <see cref="Byte" />
        ///     equivalent.
        /// </summary>
        /// <param name="value">
        ///     A string that contains a number to convert. The string is interpreted using
        ///     the <see cref="NumberStyles.Integer" /> numberStyle.
        ///     The string to pars.
        /// </param>
        /// <param name="defaultValue">The default value, returned if the parsing fails.</param>
        /// <returns>Returns the converted value, or the given default value if the conversion failed.</returns>
        [Pure]
        [PublicAPI]
        public static byte SafeToByte( [CanBeNull] this string value, byte defaultValue = default(byte) )
            => value.TryParsByte( out var outValue ) ? outValue : defaultValue;

        /// <summary>
        ///     Tries to convert the string representation of a number to its <see cref="Byte" />
        ///     equivalent.
        /// </summary>
        /// <exception cref="ArgumentNullException">formatProvider can not be null.</exception>
        /// <exception cref="ArgumentException">
        ///     numberStyle is not a <see cref="NumberStyles" /> value. -or-style is not a
        ///     combination of <see cref="NumberStyles.AllowHexSpecifier" /> and
        ///     <see cref="NumberStyles.HexNumber" /> values.
        /// </exception>
        /// <param name="value">
        ///     A string that contains a number to convert. The string is interpreted using
        ///     the <see cref="NumberStyles.Integer" /> numberStyle.
        ///     The string to pars.
        /// </param>
        /// <param name="numberStyle">
        ///     A bitwise combination of enumeration values that indicates the numberStyle elements
        ///     that can be present in s. A typical value to specify is <see cref="NumberStyles.Integer" />.
        /// </param>
        /// <param name="formatProvider">
        ///     An object that supplies culture-specific formatting information about s.
        ///     If formatProvider is null, the thread current culture is used.
        /// </param>
        /// <param name="defaultValue">The default value, returned if the parsing fails.</param>
        /// <returns>Returns the converted value, or the given default value if the conversion failed.</returns>
        [Pure]
        [PublicAPI]
        public static byte SafeToByte( [CanBeNull] this string value,
                                       NumberStyles numberStyle,
                                       [NotNull] IFormatProvider formatProvider,
                                       byte defaultValue = default(byte) )
        {
            formatProvider.ThrowIfNull( nameof(formatProvider) );

            return value.TryParsByte( numberStyle, formatProvider, out var outValue ) ? outValue : defaultValue;
        }
        /// <summary>
        ///     Converts the value of the specified string to its equivalent Unicode character.
        /// </summary>
        /// <param name="value">A string that contains a single character.</param>
        /// <param name="defaultValue">The default value, returned if the parsing fails.</param>
        /// <returns>Returns the converted value, or the given default value if the conversion failed.</returns>
        [Pure]
        [PublicAPI]
        public static char SafeToChar( [CanBeNull] this string value, char defaultValue = default(char) )
            => value.TryParsChar( out var outValue ) ? outValue : defaultValue;
        /// <summary>
        ///     Converts the specified string representation of a date and time to its <see cref="DateTime" /> equivalent.
        /// </summary>
        /// <param name="value">A <see cref="String" /> containing a date and time to convert.</param>
        /// <param name="defaultValue">The default value, returned if the parsing fails.</param>
        /// <returns>Returns the converted value, or the given default value if the conversion failed.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime SafeToDateTime( [CanBeNull] this string value, DateTime defaultValue = default(DateTime) )
            => value.TryParsDateTime( out var outValue ) ? outValue : defaultValue;

        /// <summary>
        ///     Converts the specified string representation of a date and time to its <see cref="DateTime" /> equivalent using the
        ///     specified culture-specific format information and formatting style.
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
        /// <param name="defaultValue">The default value, returned if the parsing fails.</param>
        /// <returns>Returns the converted value, or the given default value if the conversion failed.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime SafeToDateTime( [CanBeNull] this string value,
                                               [NotNull] IFormatProvider formatProvider,
                                               DateTimeStyles dateTimeStyle,
                                               DateTime defaultValue = default(DateTime) )
        {
            formatProvider.ThrowIfNull( nameof(formatProvider) );

            return value.TryParsDateTime( formatProvider, dateTimeStyle, out var outValue ) ? outValue : defaultValue;
        }
        /// <summary>
        ///     Converts the string representation of a number to its <see cref="Decimal" /> equivalent.
        /// </summary>
        /// <param name="value">The string representation of the number to convert.</param>
        /// <param name="defaultValue">The default value, returned if the parsing fails.</param>
        /// <returns>Returns the converted value, or the given default value if the conversion failed.</returns>
        [Pure]
        [PublicAPI]
        public static decimal SafeToDecimal( [CanBeNull] this string value, decimal defaultValue = default(decimal) )
            => value.TryParsDecimal( out var outValue ) ? outValue : defaultValue;

        /// <summary>
        ///     Converts the string representation of a number to its System.Decimal equivalent
        ///     using the specified numberStyle and culture-specific format.
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
        /// <param name="defaultValue">The default value, returned if the parsing fails.</param>
        /// <returns>Returns the converted value, or the given default value if the conversion failed.</returns>
        [Pure]
        [PublicAPI]
        public static decimal SafeToDecimal( [CanBeNull] this string value,
                                             NumberStyles numberStyle,
                                             [NotNull] IFormatProvider formatProvider,
                                             decimal defaultValue = default(decimal) )
        {
            formatProvider.ThrowIfNull( nameof(formatProvider) );

            return value.TryParsDecimal( numberStyle, formatProvider, out var outValue ) ? outValue : defaultValue;
        }
        /// <summary>
        ///     Converts the string representation of a number to its double-precision floating-point
        ///     number equivalent.
        /// </summary>
        /// <param name="value">A string containing a number to convert.</param>
        /// <param name="defaultValue">The default value, returned if the parsing fails.</param>
        /// <returns>Returns the converted value, or the given default value if the conversion failed.</returns>
        [Pure]
        [PublicAPI]
        public static double SafeToDouble( [CanBeNull] this string value, double defaultValue = default(double) )
            => value.TryParsDouble( out var outValue ) ? outValue : defaultValue;

        /// <summary>
        ///     Converts the string representation of a number in a specified numberStyle and culture-specific
        ///     format to its double-precision floating-point number equivalent.
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
        ///     An <see cref="System.IFormatProvider" /> that supplies culture-specific formatting information about value.
        /// </param>
        /// <param name="defaultValue">The default value, returned if the parsing fails.</param>
        /// <returns>Returns the converted value, or the given default value if the conversion failed.</returns>
        [Pure]
        [PublicAPI]
        public static double SafeToDouble( [CanBeNull] this string value,
                                           NumberStyles numberStyle,
                                           [NotNull] IFormatProvider formatProvider,
                                           double defaultValue = default(double) )
        {
            formatProvider.ThrowIfNull( nameof(formatProvider) );

            return value.TryParsDouble( numberStyle, formatProvider, out var outValue ) ? outValue : defaultValue;
        }
        /// <summary>
        ///     Converts the string representation of a GUID to the equivalent <see cref="Guid" /> structure.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <param name="defaultValue">
        ///     The default value, returned if the parsing fails. If not provided default will be
        ///     <see cref="Guid.Empty" />.
        /// </param>
        /// <returns>Returns the converted value, or the given default value if the conversion failed.</returns>
        [Pure]
        [PublicAPI]
        public static Guid SafeToGuid( [CanBeNull] this string value, Guid defaultValue = default(Guid) )
            => value.TryParsGuid( out var outValue ) ? outValue : defaultValue;
        /// <summary>
        ///     Converts the string representation of a number to its 16-bit signed integer
        ///     equivalent.
        /// </summary>
        /// <param name="value">A string containing a number to convert.</param>
        /// <param name="defaultValue">The default value, returned if the parsing fails.</param>
        /// <returns>Returns the converted value, or the given default value if the conversion failed.</returns>
        [Pure]
        [PublicAPI]
        public static short SafeToInt16( [CanBeNull] this string value, short defaultValue = default(short) )
            => value.TryParsInt16( out var outValue ) ? outValue : defaultValue;

        /// <summary>
        ///     Converts the string representation of a number in a specified numberStyle and culture-specific
        ///     format to its 16-bit signed integer equivalent.
        /// </summary>
        /// <exception cref="ArgumentNullException">formatProvider can not be null.</exception>
        /// <exception cref="ArgumentException">
        ///     numberStyle is not a <see cref="NumberStyles" /> value. -or-style is not a
        ///     combination of <see cref="NumberStyles.AllowHexSpecifier" /> and <see cref="NumberStyles.HexNumber" />
        ///     values.
        /// </exception>
        /// <param name="value">A string containing a number to convert.</param>
        /// <param name="numberStyle">
        ///     A bitwise combination of enumeration values that indicates the numberStyle elements
        ///     that can be present in value. A typical value to specify is <see cref="NumberStyles.Integer" />.
        /// </param>
        /// <param name="formatProvider">An object that supplies culture-specific formatting information about value.</param>
        /// <param name="defaultValue">The default value, returned if the parsing fails.</param>
        /// <returns>Returns the converted value, or the given default value if the conversion failed.</returns>
        [Pure]
        [PublicAPI]
        public static short SafeToInt16( [CanBeNull] this string value,
                                         NumberStyles numberStyle,
                                         [NotNull] IFormatProvider formatProvider,
                                         short defaultValue = default(short) )
        {
            formatProvider.ThrowIfNull( nameof(formatProvider) );

            return value.TryParsInt16( numberStyle, formatProvider, out var outValue ) ? outValue : defaultValue;
        }
        /// <summary>
        ///     Converts the string representation of a number to its 32-bit signed integer
        ///     equivalent.
        /// </summary>
        /// <param name="value">A string containing a number to convert.</param>
        /// <param name="defaultValue">The default value, returned if the parsing fails.</param>
        /// <returns>Returns the converted value, or the given default value if the conversion failed.</returns>
        [Pure]
        [PublicAPI]
        public static int SafeToInt32( [CanBeNull] this string value, int defaultValue = default(int) )
            => value.TryParsInt32( out var outValue ) ? outValue : defaultValue;

        /// <summary>
        ///     Converts the string representation of a number in a specified numberStyle and culture-specific
        ///     format to its 32-bit signed integer equivalent.
        /// </summary>
        /// <exception cref="ArgumentNullException">formatProvider can not be null.</exception>
        /// <exception cref="ArgumentException">
        ///     numberStyle is not a <see cref="NumberStyles" /> value. -or-style is not a
        ///     combination of <see cref="NumberStyles.AllowHexSpecifier" /> and <see cref="NumberStyles.HexNumber" />
        ///     values.
        /// </exception>
        /// <param name="value">A string containing a number to convert.</param>
        /// <param name="numberStyle">
        ///     A bitwise combination of enumeration values that indicates the numberStyle elements
        ///     that can be present in value. A typical value to specify is <see cref="NumberStyles.Integer" />.
        /// </param>
        /// <param name="formatProvider">An object that supplies culture-specific formatting information about value.</param>
        /// <param name="defaultValue">The default value, returned if the parsing fails.</param>
        /// <returns>Returns the converted value, or the given default value if the conversion failed.</returns>
        [Pure]
        [PublicAPI]
        public static int SafeToInt32( [CanBeNull] this string value,
                                         NumberStyles numberStyle,
                                         [NotNull] IFormatProvider formatProvider,
                                         int defaultValue = default(int) )
        {
            formatProvider.ThrowIfNull( nameof(formatProvider) );

            return value.TryParsInt32( numberStyle, formatProvider, out var outValue ) ? outValue : defaultValue;
        }
        /// <summary>
        ///     Converts the string representation of a number to its 64-bit signed integer
        ///     equivalent.
        /// </summary>
        /// <param name="value">A string containing a number to convert.</param>
        /// <param name="defaultValue">The default value, returned if the parsing fails.</param>
        /// <returns>Returns the converted value, or the given default value if the conversion failed.</returns>
        [Pure]
        [PublicAPI]
        public static long SafeToInt64( [CanBeNull] this string value, long defaultValue = default(long) )
            => value.TryParsInt64( out var outValue ) ? outValue : defaultValue;

        /// <summary>
        ///     Converts the string representation of a number in a specified numberStyle and culture-specific
        ///     format to its 64-bit signed integer equivalent.
        /// </summary>
        /// <exception cref="ArgumentNullException">formatProvider can not be null.</exception>
        /// <exception cref="ArgumentException">
        ///     numberStyle is not a <see cref="NumberStyles" /> value. -or-style is not a
        ///     combination of <see cref="NumberStyles.AllowHexSpecifier" /> and <see cref="NumberStyles.HexNumber" />
        ///     values.
        /// </exception>
        /// <param name="value">A string containing a number to convert.</param>
        /// <param name="numberStyle">
        ///     A bitwise combination of enumeration values that indicates the numberStyle elements
        ///     that can be present in value. A typical value to specify is <see cref="NumberStyles.Integer" />.
        /// </param>
        /// <param name="formatProvider">An object that supplies culture-specific formatting information about value.</param>
        /// <param name="defaultValue">The default value, returned if the parsing fails.</param>
        /// <returns>Returns the converted value, or the given default value if the conversion failed.</returns>
        [Pure]
        [PublicAPI]
        public static long SafeToInt64( [CanBeNull] this string value,
                                         NumberStyles numberStyle,
                                         [NotNull] IFormatProvider formatProvider,
                                         long defaultValue = default(long) )
        {
            formatProvider.ThrowIfNull( nameof(formatProvider) );

            return value.TryParsInt64( numberStyle, formatProvider, out var outValue ) ? outValue : defaultValue;
        }
    }
}