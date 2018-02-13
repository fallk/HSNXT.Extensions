using System;
using System.Globalization;

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>Converts the value of this instance to all the string representations supported by the standard date and time format specifiers and the specified culture-specific formatting information.</summary>
        /// <returns>A string array where each element is the representation of the value of this instance formatted with one of the standard date and time format specifiers.</returns>
        public static string[] GetDateTimeFormatsInvariant(this DateTime o)
        {
            return o.GetDateTimeFormats(CultureInfo.InvariantCulture);
        }

        /// <summary>Converts the value of this instance to all the string representations supported by the specified standard date and time format specifier.</summary>
        /// <param name="o">This object</param>
        /// <param name="format">A standard date and time format string (see Remarks). </param>
        /// <returns>A string array where each element is the representation of the value of this instance formatted with the <paramref name="format" /> standard date and time format specifier.</returns>
        /// <exception cref="T:System.FormatException">
        /// <paramref name="format" /> is not a valid standard date and time format specifier character.</exception>
        public static string[] GetDateTimeFormatsInvariant(this DateTime o, char format)
        {
            return o.GetDateTimeFormats(format, CultureInfo.InvariantCulture);
        }

        /// <summary>Converts the value of this instance to an equivalent Boolean value using the specified culture-specific formatting information.</summary>
        /// <returns>A Boolean value equivalent to the value of this instance.</returns>
        public static bool ToBooleanInvariant(this IConvertible o)
        {
            return o.ToBoolean(CultureInfo.InvariantCulture);
        }

        /// <summary>Converts the value of this instance to an equivalent Unicode character using the specified culture-specific formatting information.</summary>
        /// <returns>A Unicode character equivalent to the value of this instance.</returns>
        public static char ToCharInvariant(this IConvertible o)
        {
            return o.ToChar(CultureInfo.InvariantCulture);
        }

        /// <summary>Converts the value of this instance to an equivalent 8-bit signed integer using the specified culture-specific formatting information.</summary>
        /// <returns>An 8-bit signed integer equivalent to the value of this instance.</returns>
        public static sbyte ToSByteInvariant(this IConvertible o)
        {
            return o.ToSByte(CultureInfo.InvariantCulture);
        }

        /// <summary>Converts the value of this instance to an equivalent 8-bit unsigned integer using the specified culture-specific formatting information.</summary>
        /// <returns>An 8-bit unsigned integer equivalent to the value of this instance.</returns>
        public static byte ToByteInvariant(this IConvertible o)
        {
            return o.ToByte(CultureInfo.InvariantCulture);
        }

        /// <summary>Converts the value of this instance to an equivalent 16-bit signed integer using the specified culture-specific formatting information.</summary>
        /// <returns>An 16-bit signed integer equivalent to the value of this instance.</returns>
        public static short ToInt16Invariant(this IConvertible o)
        {
            return o.ToInt16(CultureInfo.InvariantCulture);
        }

        /// <summary>Converts the value of this instance to an equivalent 16-bit unsigned integer using the specified culture-specific formatting information.</summary>
        /// <returns>An 16-bit unsigned integer equivalent to the value of this instance.</returns>
        public static ushort ToUInt16Invariant(this IConvertible o)
        {
            return o.ToUInt16(CultureInfo.InvariantCulture);
        }

        /// <summary>Converts the value of this instance to an equivalent 32-bit signed integer using the specified culture-specific formatting information.</summary>
        /// <returns>An 32-bit signed integer equivalent to the value of this instance.</returns>
        public static int ToInt32Invariant(this IConvertible o)
        {
            return o.ToInt32(CultureInfo.InvariantCulture);
        }

        /// <summary>Converts the value of this instance to an equivalent 32-bit unsigned integer using the specified culture-specific formatting information.</summary>
        /// <returns>An 32-bit unsigned integer equivalent to the value of this instance.</returns>
        public static uint ToUInt32Invariant(this IConvertible o)
        {
            return o.ToUInt32(CultureInfo.InvariantCulture);
        }

        /// <summary>Converts the value of this instance to an equivalent 64-bit signed integer using the specified culture-specific formatting information.</summary>
        /// <returns>An 64-bit signed integer equivalent to the value of this instance.</returns>
        public static long ToInt64Invariant(this IConvertible o)
        {
            return o.ToInt64(CultureInfo.InvariantCulture);
        }

        /// <summary>Converts the value of this instance to an equivalent 64-bit unsigned integer using the specified culture-specific formatting information.</summary>
        /// <returns>An 64-bit unsigned integer equivalent to the value of this instance.</returns>
        public static ulong ToUInt64Invariant(this IConvertible o)
        {
            return o.ToUInt64(CultureInfo.InvariantCulture);
        }

        /// <summary>Converts the value of this instance to an equivalent single-precision floating-point number using the specified culture-specific formatting information.</summary>
        /// <returns>A single-precision floating-point number equivalent to the value of this instance.</returns>
        public static float ToSingleInvariant(this IConvertible o)
        {
            return o.ToSingle(CultureInfo.InvariantCulture);
        }

        /// <summary>Converts the value of this instance to an equivalent double-precision floating-point number using the specified culture-specific formatting information.</summary>
        /// <returns>A double-precision floating-point number equivalent to the value of this instance.</returns>
        public static double ToDoubleInvariant(this IConvertible o)
        {
            return o.ToDouble(CultureInfo.InvariantCulture);
        }

        /// <summary>Converts the value of this instance to an equivalent <see cref="T:System.Decimal" /> number using the specified culture-specific formatting information.</summary>
        /// <returns>A <see cref="T:System.Decimal" /> number equivalent to the value of this instance.</returns>
        public static decimal ToDecimalInvariant(this IConvertible o)
        {
            return o.ToDecimal(CultureInfo.InvariantCulture);
        }

        /// <summary>Converts the value of this instance to an equivalent <see cref="T:System.DateTime" /> using the specified culture-specific formatting information.</summary>
        /// <returns>A <see cref="T:System.DateTime" /> instance equivalent to the value of this instance.</returns>
        public static DateTime ToDateTimeInvariant(this IConvertible o)
        {
            return o.ToDateTime(CultureInfo.InvariantCulture);
        }

        /// <summary>Converts the value of this instance to an equivalent <see cref="T:System.String" /> using the specified culture-specific formatting information.</summary>
        /// <returns>A <see cref="T:System.String" /> instance equivalent to the value of this instance.</returns>
        public static string ToStringInvariant(this IConvertible o)
        {
            return o.ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>Converts the value of this instance to an <see cref="T:System.Object" /> of the specified <see cref="T:System.Type" /> that has an equivalent value, using the specified culture-specific formatting information.</summary>
        /// <param name="o">This object</param>
        /// <param name="conversionType">The <see cref="T:System.Type" /> to which the value of this instance is converted. </param>
        /// <returns>An <see cref="T:System.Object" /> instance of type <paramref name="conversionType" /> whose value is equivalent to the value of this instance.</returns>
        public static object ToTypeInvariant(this IConvertible o, Type conversionType)
        {
            return o.ToType(conversionType, CultureInfo.InvariantCulture);
        }

        /// <summary>Converts the value of this instance to an equivalent Boolean value using the specified culture-specific formatting information.</summary>
        /// <returns>A Boolean value equivalent to the value of this instance.</returns>
        public static bool ToBoolean(this IConvertible o)
        {
            return o.ToBoolean(CultureInfo.CurrentCulture);
        }

        /// <summary>Converts the value of this instance to an equivalent Unicode character using the specified culture-specific formatting information.</summary>
        /// <returns>A Unicode character equivalent to the value of this instance.</returns>
        public static char ToChar(this IConvertible o)
        {
            return o.ToChar(CultureInfo.CurrentCulture);
        }

        /// <summary>Converts the value of this instance to an equivalent 8-bit signed integer using the specified culture-specific formatting information.</summary>
        /// <returns>An 8-bit signed integer equivalent to the value of this instance.</returns>
        public static sbyte ToSByte(this IConvertible o)
        {
            return o.ToSByte(CultureInfo.CurrentCulture);
        }

        /// <summary>Converts the value of this instance to an equivalent 8-bit unsigned integer using the specified culture-specific formatting information.</summary>
        /// <returns>An 8-bit unsigned integer equivalent to the value of this instance.</returns>
        public static byte ToByte(this IConvertible o)
        {
            return o.ToByte(CultureInfo.CurrentCulture);
        }

        /// <summary>Converts the value of this instance to an equivalent 16-bit signed integer using the specified culture-specific formatting information.</summary>
        /// <returns>An 16-bit signed integer equivalent to the value of this instance.</returns>
        public static short ToInt16(this IConvertible o)
        {
            return o.ToInt16(CultureInfo.CurrentCulture);
        }

        /// <summary>Converts the value of this instance to an equivalent 16-bit unsigned integer using the specified culture-specific formatting information.</summary>
        /// <returns>An 16-bit unsigned integer equivalent to the value of this instance.</returns>
        public static ushort ToUInt16(this IConvertible o)
        {
            return o.ToUInt16(CultureInfo.CurrentCulture);
        }

        /// <summary>Converts the value of this instance to an equivalent 32-bit signed integer using the specified culture-specific formatting information.</summary>
        /// <returns>An 32-bit signed integer equivalent to the value of this instance.</returns>
        public static int ToInt32(this IConvertible o)
        {
            return o.ToInt32(CultureInfo.CurrentCulture);
        }

        /// <summary>Converts the value of this instance to an equivalent 32-bit unsigned integer using the specified culture-specific formatting information.</summary>
        /// <returns>An 32-bit unsigned integer equivalent to the value of this instance.</returns>
        public static uint ToUInt32(this IConvertible o)
        {
            return o.ToUInt32(CultureInfo.CurrentCulture);
        }

        /// <summary>Converts the value of this instance to an equivalent 64-bit signed integer using the specified culture-specific formatting information.</summary>
        /// <returns>An 64-bit signed integer equivalent to the value of this instance.</returns>
        public static long ToInt64(this IConvertible o)
        {
            return o.ToInt64(CultureInfo.CurrentCulture);
        }

        /// <summary>Converts the value of this instance to an equivalent 64-bit unsigned integer using the specified culture-specific formatting information.</summary>
        /// <returns>An 64-bit unsigned integer equivalent to the value of this instance.</returns>
        public static ulong ToUInt64(this IConvertible o)
        {
            return o.ToUInt64(CultureInfo.CurrentCulture);
        }

        /// <summary>Converts the value of this instance to an equivalent single-precision floating-point number using the specified culture-specific formatting information.</summary>
        /// <returns>A single-precision floating-point number equivalent to the value of this instance.</returns>
        public static float ToSingle(this IConvertible o)
        {
            return o.ToSingle(CultureInfo.CurrentCulture);
        }

        /// <summary>Converts the value of this instance to an equivalent double-precision floating-point number using the specified culture-specific formatting information.</summary>
        /// <returns>A double-precision floating-point number equivalent to the value of this instance.</returns>
        public static double ToDouble(this IConvertible o)
        {
            return o.ToDouble(CultureInfo.CurrentCulture);
        }

        /// <summary>Converts the value of this instance to an equivalent <see cref="T:System.Decimal" /> number using the specified culture-specific formatting information.</summary>
        /// <returns>A <see cref="T:System.Decimal" /> number equivalent to the value of this instance.</returns>
        public static decimal ToDecimal(this IConvertible o)
        {
            return o.ToDecimal(CultureInfo.CurrentCulture);
        }

        /// <summary>Converts the value of this instance to an equivalent <see cref="T:System.DateTime" /> using the specified culture-specific formatting information.</summary>
        /// <returns>A <see cref="T:System.DateTime" /> instance equivalent to the value of this instance.</returns>
        public static DateTime ToDateTime(this IConvertible o)
        {
            return o.ToDateTime(CultureInfo.CurrentCulture);
        }

        /// <summary>Converts the value of this instance to an equivalent <see cref="T:System.String" /> using the specified culture-specific formatting information.</summary>
        /// <returns>A <see cref="T:System.String" /> instance equivalent to the value of this instance.</returns>
        public static string ToString(this IConvertible o)
        {
            return o.ToString(CultureInfo.CurrentCulture);
        }

        /// <summary>Converts the value of this instance to an <see cref="T:System.Object" /> of the specified <see cref="T:System.Type" /> that has an equivalent value, using the specified culture-specific formatting information.</summary>
        /// <param name="o">This object</param>
        /// <param name="conversionType">The <see cref="T:System.Type" /> to which the value of this instance is converted. </param>
        /// <returns>An <see cref="T:System.Object" /> instance of type <paramref name="conversionType" /> whose value is equivalent to the value of this instance.</returns>
        public static object ToType(this IConvertible o, Type conversionType)
        {
            return o.ToType(conversionType, CultureInfo.CurrentCulture);
        }
    }
}