using System;

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>Checks whether the value is in range or returns the default value</summary>
        /// <param name="value">The Value</param>
        /// <param name="minValue">The minimum value</param>
        /// <param name="maxValue">The maximum value</param>
        /// <param name="defaultValue">The default value</param>
        public static int InRange(this int value, int minValue, int maxValue, int defaultValue)
        {
            return (int) value.AsLong().InRange(minValue, maxValue, defaultValue);
        }

        /// <summary>
        /// Converts the value to ordinal string. (English)
        /// </summary>
        /// <param name="i">Object value</param>
        /// <returns>Returns string containing ordinal indicator adjacent to a numeral denoting. (English)</returns>
        public static string ToOrdinal(this int i)
        {
            return i.AsLong().ToOrdinal();
        }

        /// <summary>
        /// Converts the value to ordinal string with specified format. (English)
        /// </summary>
        /// <param name="i">Object value</param>
        /// <param name="format">A standard or custom format string that is supported by the object to be formatted.</param>
        /// <returns>Returns string containing ordinal indicator adjacent to a numeral denoting. (English)</returns>
        public static string ToOrdinal(this int i, string format)
        {
            return i.AsLong().ToOrdinal(format);
        }

        /// <summary>
        /// Returns the integer as long.
        /// </summary>
        public static long AsLong(this int i)
        {
            return i;
        }

        /// <summary>
        /// To check whether an index is in the range of the given array.
        /// </summary>
        /// <param name="index">Index to check</param>
        /// <param name="arrayToCheck">Array where to check</param>
        /// <returns></returns>
        /// <remarks>
        /// 	Contributed by Mohammad Rahman, http://mohammad-rahman.blogspot.com/
        /// </remarks>
        public static bool IsIndexInArray(this int index, Array arrayToCheck)
        {
            return index.GetArrayIndex().InRange(arrayToCheck.GetLowerBound(0), arrayToCheck.GetUpperBound(0));
        }

        /// <summary>
        /// To get Array index from a given based on a number.
        /// </summary>
        /// <param name="at">Real world postion </param>
        /// <returns></returns>
        /// <remarks>
        /// 	Contributed by Mohammad Rahman, http://mohammad-rahman.blogspot.com/
        /// 	jceddy fixed typo
        /// </remarks>
        public static int GetArrayIndex(this int at)
        {
            return at == 0 ? 0 : at - 1;
        }

        /// <summary>
        /// Gets a TimeSpan from an integer number of ticks.
        /// </summary>
        /// <param name="days">The number of ticks the TimeSpan will contain.</param>
        /// <returns>A TimeSpan containing the specified number of ticks.</returns>
        /// <remarks>
        ///		Contributed by jceddy
        /// </remarks>
        public static TimeSpan Ticks(this int ticks)
        {
            return TimeSpan.FromTicks(ticks);
        }
    }
}