using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Replace any instances of individual elements in <paramref name="chars"/> with <paramref name="c"/>
        /// in <paramref name="text"/>.
        /// </summary>
        /// <param name="text">string to search within.</param>
        /// <param name="chars">individual characters to search for.</param>
        /// <param name="c">character to replace any found characters with.</param>
        /// <returns></returns>
#if (NET47)
        public static string ReplaceEach(this string text, IEnumerable<char> chars, char c)
        {
            return string.Join(c.ToString(System.Globalization.CultureInfo.InvariantCulture),
                text.Split(chars.ToArray()));
        }
#else
        public static string ReplaceEach(this string text, IEnumerable<char> chars, char c)
        {
            return string.Join(
                c.ToString(),
                text.Split(chars.ToArray()));
        }
#endif


        /// <summary>
        /// Convert a string value to an int.
        /// </summary>
        /// <param name="source"></param>
        /// <returns>null if textual value is not an int or the int value.</returns>
        public static int? ToIntOrNull(this string source)
        {
            int results;
            if (!int.TryParse(source, out results))
            {
                return null;
            }

            return results;
        }

        /// <summary>
        /// Convert a string value to an int.
        /// </summary>
        /// <param name="source"></param>
        /// <returns>0 if textual value is not an int or the int value.</returns>
        public static int ToIntOrDefault(this string source)
        {
            int results;
            return !int.TryParse(source, out results) ? default(int) : results;
        }

        /// <summary>
        /// Convert a string value to a long.
        /// </summary>
        /// <param name="source"></param>
        /// <returns>null if textual value is not a long or the long value.</returns>
        public static long? ToLongOrNull(this string source)
        {
            long results;
            if (!long.TryParse(source, out results))
            {
                return null;
            }

            return results;
        }

        /// <summary>
        /// Convert a string value to a long.
        /// </summary>
        /// <param name="source"></param>
        /// <returns>0L if textual value is not a long or the long value.</returns>
        public static long ToLongOrDefault(this string source)
        {
            long results;
            if (!long.TryParse(source, out results))
            {
                return default(long);
            }

            return results;
        }

        /// <summary>
        /// Convert a string value to a DateTime.
        /// </summary>
        /// <param name="source"></param>
        /// <returns>null if textual value is not a DateTime or the DateTime value.</returns>
        public static DateTime? ToDateTimeOrNull(this string source)
        {
            DateTime results;
            if (!DateTime.TryParse(source, out results))
            {
                return null;
            }

            return results;
        }

        /// <summary>
        /// Convert a string value to a TimeSpan.
        /// </summary>
        /// <param name="source"></param>
        /// <returns>null if textual value is not a TimeSpan or the TimeSpan value.</returns>
        public static TimeSpan? ToTimeSpanOrNull(this string source)
        {
            TimeSpan time;
            if (TimeSpan.TryParse(source, out time))
            {
                return time;
            }

            return null;
        }

        /// <summary>
        /// Convert a string value to double.
        /// </summary>
        /// <param name="source"></param>
        /// <returns>null if textual value is not a double or the double value.</returns>
        public static double? ToDoubleOrNull(this string source)
        {
            double results;
            if (!double.TryParse(source, out results))
            {
                return null;
            }

            return results;
        }

        /// <summary>
        /// Convert a string value to double.
        /// </summary>
        /// <param name="source"></param>
        /// <returns>0d if textual value is not a double or the double value.</returns>
        public static double ToDoubleOrDefault(this string source)
        {
            double results;
            if (!double.TryParse(source, out results))
            {
                return default(double);
            }

            return results;
        }

        /// <summary>
        /// Convert a string value to decimal.
        /// </summary>
        /// <param name="source"></param>
        /// <returns>null if textual value is not a decimal or the decimal value.</returns>
        public static decimal? ToDecimalOrNull(this string source)
        {
            decimal results;
            if (!decimal.TryParse(source, out results))
            {
                return null;
            }

            return results;
        }

        /// <summary>
        /// Convert a string value to decimal.
        /// </summary>
        /// <param name="source"></param>
        /// <returns>0M if textual value is not a decimal or the decimal value.</returns>
        public static decimal ToDecimalOrDefault(this string source)
        {
            decimal results;
            return !decimal.TryParse(source, out results) ? default(decimal) : results;
        }

        /// <summary>
        /// conert a string to a boolean. Ignore-compare of "True" for true, and "False" for false.
        /// </summary>
        /// <param name="source"></param>
        /// <returns>null if non-boolean textual value or true/false</returns>
        public static bool? ToBoolOrNull(this string source)
        {
            bool results;
            if (!bool.TryParse(source, out results))
            {
                return null;
            }

            return results;
        }

        /// <summary>
        /// Convert a string to a GUID
        /// </summary>
        /// <param name="source"></param>
        /// <returns>GUID or null if non-GUID textual value.</returns>
        public static Guid? ToGuidOrNull(this string source)
        {
            if (string.IsNullOrEmpty(source))
            {
                return null;
            }

            try
            {
                return new Guid(source);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Get the first "Word" in a string--separated by space.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string FirstWord(this string value)
        {
            if (value == null)
            {
                return null;
            }

            var x = value.IndexOf(" ", StringComparison.Ordinal);
            return x != -1 ? value.Substring(0, x) : value;
        }
    }
}