using System;
using System.Globalization;
using System.Text;
using HSNXT.PGK.Extensions.SystemDependencies;

namespace HSNXT
{
    public static partial class Extensions
    {
        const int EveningEnds = 2;
        const int MorningEnds = 12;
        const int AfternoonEnds = 6;
        static readonly DateTime Date1970 = new DateTime(1970, 1, 1);

        ///<summary>
        ///	Return System UTC Offset
        ///</summary>
        public static double UtcOffset
        {
            get { return DateTime.Now.Subtract(DateTime.UtcNow).TotalHours; }
        }

        /// <summary>
        /// 	Calculates the age based on today.
        /// </summary>
        /// <param name = "dateOfBirth">The date of birth.</param>
        /// <returns>The calculated age.</returns>
        public static int CalculateAge(this DateTime dateOfBirth)
        {
            return CalculateAge(dateOfBirth, Clock.Now.Date);
        }

        /// <summary>
        /// 	Calculates the age based on a passed reference date.
        /// </summary>
        /// <param name = "dateOfBirth">The date of birth.</param>
        /// <param name = "referenceDate">The reference date to calculate on.</param>
        /// <returns>The calculated age.</returns>
        public static int CalculateAge(this DateTime dateOfBirth, DateTime referenceDate)
        {
            var years = referenceDate.Year - dateOfBirth.Year;
            if (referenceDate.Month < dateOfBirth.Month ||
                (referenceDate.Month == dateOfBirth.Month && referenceDate.Day < dateOfBirth.Day))
                --years;
            return years;
        }

        /// <summary>
        /// 	Returns the number of days in the month of the provided date.
        /// </summary>
        /// <param name = "date">The date.</param>
        /// <returns>The number of days.</returns>
        public static int GetCountDaysOfMonth(this DateTime date)
        {
            var nextMonth = date.AddMonths(1);
            return new DateTime(nextMonth.Year, nextMonth.Month, 1).AddDays(-1).Day;
        }

        /// <summary>
        /// 	Returns the first day of the month of the provided date.
        /// </summary>
        /// <param name = "date">The date.</param>
        /// <returns>The first day of the month</returns>
        public static DateTime GetFirstDayOfMonth(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1);
        }

        /// <summary>
        /// 	Returns the first day of the month of the provided date.
        /// </summary>
        /// <param name = "date">The date.</param>
        /// <param name = "dayOfWeek">The desired day of week.</param>
        /// <returns>The first day of the month</returns>
        public static DateTime GetFirstDayOfMonth(this DateTime date, DayOfWeek dayOfWeek)
        {
            var dt = date.GetFirstDayOfMonth();
            while (dt.DayOfWeek != dayOfWeek)
                dt = dt.AddDays(1);
            return dt;
        }

        /// <summary>
        /// 	Returns the last day of the month of the provided date.
        /// </summary>
        /// <param name = "date">The date.</param>
        /// <param name = "dayOfWeek">The desired day of week.</param>
        /// <returns>The date time</returns>
        public static DateTime GetLastDayOfMonth(this DateTime date, DayOfWeek dayOfWeek)
        {
            var dt = date.GetLastDayOfMonth();
            while (dt.DayOfWeek != dayOfWeek)
                dt = dt.AddDays(-1);
            return dt;
        }

        /// <summary>
        /// 	Sets the time on the specified DateTime value.
        /// </summary>
        /// <param name = "date">The base date.</param>
        /// <param name = "time">The TimeSpan to be applied.</param>
        /// <returns>
        /// 	The DateTime including the new time value
        /// </returns>
        public static DateTime SetTime(this DateTime date, TimeSpan time)
        {
            return date.Date.Add(time);
        }

        /// <summary>
        /// 	Converts a DateTime into a DateTimeOffset using the local system time zone.
        /// </summary>
        /// <param name = "localDateTime">The local DateTime.</param>
        /// <returns>The converted DateTimeOffset</returns>
        public static DateTimeOffset ToDateTimeOffset(this DateTime localDateTime)
        {
            return localDateTime.ToDateTimeOffset(null);
        }

        /// <summary>
        /// 	Converts a DateTime into a DateTimeOffset using the specified time zone.
        /// </summary>
        /// <param name = "localDateTime">The local DateTime.</param>
        /// <param name = "localTimeZone">The local time zone.</param>
        /// <returns>The converted DateTimeOffset</returns>
        public static DateTimeOffset ToDateTimeOffset(this DateTime localDateTime, TimeZoneInfo localTimeZone)
        {
            localTimeZone = (localTimeZone ?? TimeZoneInfo.Local);

            if (localDateTime.Kind != DateTimeKind.Unspecified)
                localDateTime = new DateTime(localDateTime.Ticks, DateTimeKind.Unspecified);

            return TimeZoneInfo.ConvertTimeToUtc(localDateTime, localTimeZone);
        }

        /// <summary>
        /// 	Gets the first day of the week using the current culture.
        /// </summary>
        /// <param name = "date">The date.</param>
        /// <returns>The first day of the week</returns>
        /// <remarks>
        ///     modified by jtolar to implement culture settings
        /// </remarks>
        public static DateTime GetFirstDayOfWeek(this DateTime date)
        {
            return date.GetFirstDayOfWeek(ExtensionMethodSetting.DefaultCulture);
        }

        /// <summary>
        /// 	Gets the first day of the week using the specified culture.
        /// </summary>
        /// <param name = "date">The date.</param>
        /// <param name = "cultureInfo">The culture to determine the first weekday of a week.</param>
        /// <returns>The first day of the week</returns>
        public static DateTime GetFirstDayOfWeek(this DateTime date, CultureInfo cultureInfo)
        {
            cultureInfo = (cultureInfo ?? CultureInfo.CurrentCulture);

            var firstDayOfWeek = cultureInfo.DateTimeFormat.FirstDayOfWeek;
            while (date.DayOfWeek != firstDayOfWeek)
                date = date.AddDays(-1);

            return date;
        }

        /// <summary>
        /// 	Gets the last day of the week using the current culture.
        /// </summary>
        /// <param name = "date">The date.</param>
        /// <returns>The first day of the week</returns>
        /// <remarks>
        ///     modified by jtolar to implement culture settings
        /// </remarks>
        public static DateTime GetLastDayOfWeek(this DateTime date)
        {
            return date.GetLastDayOfWeek(ExtensionMethodSetting.DefaultCulture);
        }

        /// <summary>
        /// 	Gets the last day of the week using the specified culture.
        /// </summary>
        /// <param name = "date">The date.</param>
        /// <param name = "cultureInfo">The culture to determine the first weekday of a week.</param>
        /// <returns>The first day of the week</returns>
        public static DateTime GetLastDayOfWeek(this DateTime date, CultureInfo cultureInfo)
        {
            return date.GetFirstDayOfWeek(cultureInfo).AddDays(6);
        }

        /// <summary>
        /// 	Gets the next occurence of the specified weekday within the current week using the current culture.
        /// </summary>
        /// <param name = "date">The base date.</param>
        /// <param name = "weekday">The desired weekday.</param>
        /// <returns>The calculated date.</returns>
        /// <example>
        /// 	<code>
        /// 		var thisWeeksMonday = DateTime.Now.GetWeekday(DayOfWeek.Monday);
        /// 	</code>
        /// </example>
        /// <remarks>
        ///     modified by jtolar to implement culture settings
        /// </remarks>
        public static DateTime GetWeeksWeekday(this DateTime date, DayOfWeek weekday)
        {
            return date.GetWeeksWeekday(weekday, ExtensionMethodSetting.DefaultCulture);
        }

        /// <summary>
        /// 	Gets the next occurence of the specified weekday within the current week using the specified culture.
        /// </summary>
        /// <param name = "date">The base date.</param>
        /// <param name = "weekday">The desired weekday.</param>
        /// <param name = "cultureInfo">The culture to determine the first weekday of a week.</param>
        /// <returns>The calculated date.</returns>
        /// <example>
        /// 	<code>
        /// 		var thisWeeksMonday = DateTime.Now.GetWeekday(DayOfWeek.Monday);
        /// 	</code>
        /// </example>
        public static DateTime GetWeeksWeekday(this DateTime date, DayOfWeek weekday, CultureInfo cultureInfo)
        {
            var firstDayOfWeek = date.GetFirstDayOfWeek(cultureInfo);
            return firstDayOfWeek.GetNextWeekday(weekday);
        }

        /// <summary>
        /// 	Gets the next occurence of the specified weekday.
        /// </summary>
        /// <param name = "date">The base date.</param>
        /// <param name = "weekday">The desired weekday.</param>
        /// <returns>The calculated date.</returns>
        /// <example>
        /// 	<code>
        /// 		var lastMonday = DateTime.Now.GetNextWeekday(DayOfWeek.Monday);
        /// 	</code>
        /// </example>
        public static DateTime GetNextWeekday(this DateTime date, DayOfWeek weekday)
        {
            while (date.DayOfWeek != weekday)
                date = date.AddDays(1);
            return date;
        }

        /// <summary>
        /// 	Gets the previous occurence of the specified weekday.
        /// </summary>
        /// <param name = "date">The base date.</param>
        /// <param name = "weekday">The desired weekday.</param>
        /// <returns>The calculated date.</returns>
        /// <example>
        /// 	<code>
        /// 		var lastMonday = DateTime.Now.GetPreviousWeekday(DayOfWeek.Monday);
        /// 	</code>
        /// </example>
        public static DateTime GetPreviousWeekday(this DateTime date, DayOfWeek weekday)
        {
            while (date.DayOfWeek != weekday)
                date = date.AddDays(-1);
            return date;
        }

        /// <summary>
        /// 	Get milliseconds of UNIX area. This is the milliseconds since 1/1/1970
        /// </summary>
        /// <param name = "datetime">Up to which time.</param>
        /// <returns>number of milliseconds.</returns>
        /// <remarks>
        /// 	Contributed by blaumeister, http://www.codeplex.com/site/users/view/blaumeiser
        /// </remarks>
        public static long GetMillisecondsSince1970(this DateTime datetime)
        {
            var ts = datetime.Subtract(Date1970);
            return (long) ts.TotalMilliseconds;
        }

        /// <summary>
        /// Get milliseconds of UNIX area. This is the milliseconds since 1/1/1970
        /// </summary>
        /// <param name="dateTime">The date time.</param>
        /// <returns></returns>
        /// <remarks>This is the same as GetMillisecondsSince1970 but more descriptive</remarks>
        public static long ToUnixEpoch(this DateTime dateTime)
        {
            return GetMillisecondsSince1970(dateTime);
        }

        /// <summary>
        /// 	Adds the specified amount of weeks (=7 days gregorian calendar) to the passed date value.
        /// </summary>
        /// <param name = "date">The origin date.</param>
        /// <param name = "value">The amount of weeks to be added.</param>
        /// <returns>The enw date value</returns>
        public static DateTime AddWeeks(this DateTime date, int value)
        {
            return date.AddDays(value * 7);
        }

        ///<summary>
        ///	Get the number of days within that year.
        ///</summary>
        ///<param name = "year">The year.</param>
        ///<returns>the number of days within that year</returns>
        /// <remarks>
        /// 	Contributed by Michael T, http://about.me/MichaelTran
        ///     Modified by JTolar to implement Culture Settings
        /// </remarks>
        public static int GetDays(int year)
        {
            return GetDays(year, ExtensionMethodSetting.DefaultCulture);
        }

        ///<summary>
        ///	Get the number of days within that year. Uses the culture specified.
        ///</summary>
        ///<param name = "year">The year.</param>
        ///<param name="culture">Specific culture</param>
        ///<returns>the number of days within that year</returns>
        /// <remarks>
        /// 	Contributed by Michael T, http://about.me/MichaelTran
        ///     Modified by JTolar to implement Culture Settings
        /// </remarks>
        public static int GetDays(int year, CultureInfo culture)
        {
            var first = new DateTime(year, 1, 1, culture.Calendar);
            var last = new DateTime(year + 1, 1, 1, culture.Calendar);
            return GetDays(first, last);
        }


        ///<summary>
        ///	Get the number of days within that date year. Allows user to specify culture.
        ///</summary>
        ///<param name = "date">The date.</param>
        ///<param name="culture">Specific culture</param>
        ///<returns>the number of days within that year</returns>
        /// <remarks>
        /// 	Contributed by Michael T, http://about.me/MichaelTran
        ///     Modified by JTolar to implement Culture Settings 
        /// </remarks>
        public static int GetDays(this DateTime date)
        {
            return GetDays(date.Year, ExtensionMethodSetting.DefaultCulture);
        }

        ///<summary>
        ///	Get the number of days within that date year. Allows user to specify culture
        ///</summary>
        ///<param name = "date">The date.</param>
        ///<param name="culture">Specific culture</param>
        ///<returns>the number of days within that year</returns>
        /// <remarks>
        /// 	Contributed by Michael T, http://about.me/MichaelTran
        ///     Modified by JTolar to implement Culture Settings 
        /// </remarks>
        public static int GetDays(this DateTime date, CultureInfo culture)
        {
            return GetDays(date.Year, culture);
        }

        ///<summary>
        ///	Get the number of days between two dates.
        ///</summary>
        ///<param name = "fromDate">The origin year.</param>
        ///<param name = "toDate">To year</param>
        ///<returns>The number of days between the two years</returns>
        /// <remarks>
        /// 	Contributed by Michael T, http://about.me/MichaelTran
        /// </remarks>
        public static int GetDays(this DateTime fromDate, DateTime toDate)
        {
            return Convert.ToInt32(toDate.Subtract(fromDate).TotalDays);
        }

        ///<summary>
        ///	Return a period "Morning", "Afternoon", or "Evening"
        ///</summary>
        ///<param name = "date">The date.</param>
        ///<returns>The period "morning", "afternoon", or "evening"</returns>
        /// <remarks>
        /// 	Contributed by Michael T, http://about.me/MichaelTran
        /// </remarks>
        public static string GetPeriodOfDay(this DateTime date)
        {
            var hour = date.Hour;
            if (hour < EveningEnds)
                return "evening";
            if (hour < MorningEnds)
                return "morning";
            return hour < AfternoonEnds ? "afternoon" : "evening";
        }

        /// <summary>
        /// Gets the week number for a provided date time value based on a specific culture.
        /// </summary>
        /// <param name="dateTime">The date time.</param>
        /// <param name="culture">Specific culture</param>
        /// <returns>The week number</returns>
        /// <remarks>
        ///     modified by jtolar to implement culture settings
        /// </remarks>
        public static int GetWeekOfYear(this DateTime dateTime, CultureInfo culture)
        {
            var calendar = culture.Calendar;
            var dateTimeFormat = culture.DateTimeFormat;

            return calendar.GetWeekOfYear(dateTime, dateTimeFormat.CalendarWeekRule, dateTimeFormat.FirstDayOfWeek);
        }

        /// <summary>
        ///     Indicates whether the specified date is Easter in the Christian calendar.
        /// </summary>
        /// <param name="date">Instance value.</param>
        /// <returns>True if the instance value is a valid Easter Date.</returns>
        public static bool IsEaster(this DateTime date)
        {
            int Y = date.Year;
            int a = Y % 19;
            int b = Y / 100;
            int c = Y % 100;
            int d = b / 4;
            int e = b % 4;
            int f = (b + 8) / 25;
            int g = (b - f + 1) / 3;
            int h = (19 * a + b - d - g + 15) % 30;
            int i = c / 4;
            int k = c % 4;
            int L = (32 + 2 * e + 2 * i - h - k) % 7;
            int m = (a + 11 * h + 22 * L) / 451;
            int Month = (h + L - 7 * m + 114) / 31;
            int Day = ((h + L - 7 * m + 114) % 31) + 1;

            DateTime dtEasterSunday = new DateTime(Y, Month, Day);

            return date == dtEasterSunday;
        }

        /// <summary>
        ///     Indicates whether the source DateTime is before the supplied DateTime.
        /// </summary>
        /// <param name="source">The source DateTime.</param>
        /// <param name="other">The compared DateTime.</param>
        /// <returns>True if the source is before the other DateTime, False otherwise</returns>
        public static bool IsBefore(this DateTime source, DateTime other)
        {
            return source.CompareTo(other) < 0;
        }

        /// <summary>
        ///     Indicates whether the source DateTime is before the supplied DateTime.
        /// </summary>
        /// <param name="source">The source DateTime.</param>
        /// <param name="other">The compared DateTime.</param>
        /// <returns>True if the source is before the other DateTime, False otherwise</returns>
        public static bool IsAfter(this DateTime source, DateTime other)
        {
            return source.CompareTo(other) > 0;
        }

        /// <summary>
        /// The ToFriendlyString() method represents dates in a user friendly way. 
        /// For example, when displaying a news article on a webpage, you might want 
        /// articles that were published one day ago to have their publish dates 
        /// represented as "yesterday at 12:30 PM". Or if the article was publish today, 
        /// show the date as "Today, 3:33 PM".
        /// </summary>
        /// <param name="date">The date.</param>
        /// <param name="culture">Specific Culture</param>
        /// <returns>string</returns>
        /// <remarks>
        ///     modified by jtolar to implement culture settings
        /// </remarks>/// <remarks></remarks>
        public static string ToFriendlyDateString(this DateTime date, CultureInfo culture)
        {
            var sbFormattedDate = new StringBuilder();
            if (date.Date == DateTime.Today)
            {
                sbFormattedDate.Append("Today");
            }
            else if (date.Date == DateTime.Today.AddDays(-1))
            {
                sbFormattedDate.Append("Yesterday");
            }
            else if (date.Date > DateTime.Today.AddDays(-6))
            {
                // *** Show the Day of the week
                sbFormattedDate.Append(date.ToString("dddd").ToString(culture));
            }
            else
            {
                sbFormattedDate.Append(date.ToString("MMMM dd, yyyy").ToString(culture));
            }

            //append the time portion to the output
            sbFormattedDate.Append(" at ").Append(date.ToString("t").ToLower());
            return sbFormattedDate.ToString();
        }
    }
}