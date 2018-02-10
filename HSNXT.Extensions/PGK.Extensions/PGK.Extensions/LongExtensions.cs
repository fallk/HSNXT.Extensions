using System;

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// 	Performs the specified action n times based on the underlying long value.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <param name = "action">The action.</param>
        public static void Times(this long value, Action action)
        {
            for (var i = 0; i < value; i++)
                action();
        }

        /// <summary>
        /// 	Performs the specified action n times based on the underlying long value.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <param name = "action">The action.</param>
        public static void Times(this long value, Action<long> action)
        {
            for (var i = 0; i < value; i++)
                action(i);
        }

        /// <summary>Checks whether the value is in range or returns the default value</summary>
        /// <param name="value">The Value</param>
        /// <param name="minValue">The minimum value</param>
        /// <param name="maxValue">The maximum value</param>
        /// <param name="defaultValue">The default value</param>
        public static long InRange(this long value, long minValue, long maxValue, long defaultValue)
        {
            return value.InRange(minValue, maxValue) ? value : defaultValue;
        }

        /// <summary>
        /// Converts the value to ordinal string. (English)
        /// </summary>
        /// <param name="i">Object value</param>
        /// <returns>Returns string containing ordinal indicator adjacent to a numeral denoting. (English)</returns>
        public static string ToOrdinal(this long i)
        {
            string suffix = "th";
            switch (i % 100)
            {
                case 11:
                case 12:
                case 13:
                    break;
                default:
                    switch (i % 10)
                    {
                        case 1:
                            suffix = "st";
                            break;
                        case 2:
                            suffix = "nd";
                            break;
                        case 3:
                            suffix = "rd";
                            break;
                    }

                    break;
            }

            return $"{i}{suffix}";
        }

        /// <summary>
        /// Converts the value to ordinal string with specified format. (English)
        /// </summary>
        /// <param name="i">Object value</param>
        /// <param name="format">A standard or custom format string that is supported by the object to be formatted.</param>
        /// <returns>Returns string containing ordinal indicator adjacent to a numeral denoting. (English)</returns>
        public static string ToOrdinal(this long i, string format)
        {
            return string.Format(format, i.ToOrdinal());
        }

        /// <summary>
        /// Gets a TimeSpan from a long number of ticks.
        /// </summary>
        /// <param name="ticks">The number of ticks the TimeSpan will contain.</param>
        /// <returns>A TimeSpan containing the specified number of ticks.</returns>
        /// <remarks>
        ///		Contributed by jceddy
        /// </remarks>
        public static TimeSpan Ticks(this long ticks)
        {
            return TimeSpan.FromTicks(ticks);
        }
    }
}