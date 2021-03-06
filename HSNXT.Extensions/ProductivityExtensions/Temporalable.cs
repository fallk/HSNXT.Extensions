using System;
#if (NETSTANDARD2_0 || NET47)
using System.Diagnostics.Contracts;

#endif

namespace HSNXT
{
    public static partial class Extensions
    {
        private const int DaysPerMonth = 30;

        /// <summary>
        /// Calculates a final date spanning <paramref name="source"/> after <paramref name="origin"/>
        /// <example>
        /// // calculate date/time that it will be in one hour
        /// var finalDate = new TimeSpan(0, 1, 0, 0).From(DateTime.Now);
        /// </example>
        /// </summary>
        /// <param name="source"></param>
        /// <param name="origin"></param>
        /// <returns></returns>
        public static DateTime From(this TimeSpan source, DateTime origin)
        {
            return origin + source;
        }

        /// <summary>
        /// Calculates a final date spanning <paramref name="source"/> after <paramref name="origin"/>
        /// Alias to <seealso cref="From"/>
        /// </summary>
        /// <param name="source"></param>
        /// <param name="origin"></param>
        /// <seealso cref="From"/>
        /// <returns></returns>
        public static DateTime Since(this TimeSpan source, DateTime origin)
        {
            return From(source, origin);
        }

        /// <summary>
        /// Creates a <see cref="TimeSpan"/> spanning <paramref name="source"/> months.
        /// </summary>
        /// var oneMonth = 1.Months();
        /// <param name="source"></param>
        /// <returns></returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2233:OperationsShouldNotOverflow",
            MessageId = "source*30")]
        public static TimeSpan Months(this int source)
        {
            return new TimeSpan(source * DaysPerMonth, 0, 0, 0);
        }

        /// <summary>
        /// Creates a final <see cref="DateTime"/> <paramref name="source"/> in the past
        /// <example>
        /// 50.Seconds.Ago();
        /// </example>
        /// </summary>
        /// <param name="source"></param>
        /// <param name="now">DateTime, or DateTime.Now if missing</param>
        /// <returns></returns>
        public static DateTime Ago(this TimeSpan source, DateTime now = default(DateTime))
        {
            if (now == default(DateTime))
            {
                now = DateTime.Now;
            }

            return now.Add(source.Negate());
        }

        /// <summary>
        /// Doubles a <see cref="TimeSpan"/>
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static TimeSpan Double(this TimeSpan source)
        {
            return source + source;
        }

        /// <summary>
        /// Rounds a <see cref="TimeSpan"/> to the nearest hour
        /// </summary>
        /// <param name="timeSpan"></param>
        /// <returns></returns>
        public static TimeSpan RoundToHours(this TimeSpan timeSpan)
        {
            var rounded = new TimeSpan(timeSpan.Days, timeSpan.Hours, 0, 0);
            if (timeSpan.Minutes >= 30)
            {
                rounded = rounded + 1.Hours();
            }

            return rounded;
        }

        /// <summary>
        /// Rounds a <see cref="TimeSpan"/> to the nearest minute
        /// </summary>
        /// <param name="timeSpan"></param>
        /// <returns></returns>
        public static TimeSpan RoundToMinutes(this TimeSpan timeSpan)
        {
            var rounded = new TimeSpan(timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, 0);
            if (timeSpan.Seconds >= 30)
            {
                rounded = rounded + 1.Minutes();
            }

            return rounded;
        }

        /// <summary>
        /// Rounds a <see cref="TimeSpan"/> to the nearest second
        /// </summary>
        /// <param name="timeSpan"></param>
        /// <returns></returns>
        public static TimeSpan RoundToSeconds(this TimeSpan timeSpan)
        {
            var rounded = new TimeSpan(timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
            if (timeSpan.Milliseconds >= 500)
            {
                rounded = rounded + 1.Seconds();
            }

            return rounded;
        }

        /// <summary>
        /// Creates an int of <paramref name="value"/> million.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2233:OperationsShouldNotOverflow",
            MessageId = "value*1000000")]
        public static int Million(this int value)
        {
            return value * 1000000;
        }

        /// <summary>
        /// Creates an int of <paramref name="value"/> thousand.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2233:OperationsShouldNotOverflow",
            MessageId = "value*1000")]
        public static int Thousand(this int value)
        {
            return value * 1000;
        }

        /// <summary>
        /// Creates an English string from a <see cref="TimeSpan"/> value
        /// </summary>
        /// <param name="timeSpan"></param>
        /// <returns></returns>
        public static string ToEnglishString(this TimeSpan timeSpan)
        {
            if (timeSpan.TotalDays > 1)
            {
                var round = timeSpan.RoundToHours();
                return string.Format("{0} days and {1} hours", round.Days, round.Hours);
            }

            if (timeSpan.TotalHours > 1)
            {
                var round = timeSpan.RoundToMinutes();
                return string.Format("{0} hours and {1} minutes", round.Hours, round.Minutes);
            }

            if (timeSpan.TotalMinutes > 1)
            {
                var round = timeSpan.RoundToSeconds();
                return string.Format("{0} minutes and {1} seconds", round.Minutes, round.Seconds);
            }

            if (timeSpan.TotalSeconds > 1)
            {
                return string.Format("{0} seconds", timeSpan.TotalSeconds);
            }

            return string.Format("{0} milliseconds", timeSpan.Milliseconds);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'Temporalable.ToSortableDate(DateTime)'
        public static string ToSortableDate(this DateTime dateTime)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'Temporalable.ToSortableDate(DateTime)'
        {
            return dateTime.Date.ToString("yyyy'-'MM'-'dd");
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'Temporalable.ToIsoDate(DateTime)'
        public static string ToIsoDate(this DateTime dateTime)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'Temporalable.ToIsoDate(DateTime)'
        {
            return dateTime.ToSortableDate();
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'Temporalable.ToSortableDateTime(DateTime)'
        public static string ToSortableDateTime(this DateTime dateTime)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'Temporalable.ToSortableDateTime(DateTime)'
        {
            return dateTime.ToString("s");
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'Temporalable.ToIsoDateTime(DateTime)'
        public static string ToIsoDateTime(this DateTime dateTime)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'Temporalable.ToIsoDateTime(DateTime)'
        {
            return dateTime.ToString("O");
        }
    }
}