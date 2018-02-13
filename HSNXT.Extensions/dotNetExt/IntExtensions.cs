//Copyright (c) Chris Pietschmann 2012 (http://pietschsoft.com)
//All rights reserved.
//Licensed under the GNU Library General Public License (LGPL)
//License can be found here: http://www.codeplex.com/dotNetExt/license

using System;

namespace HSNXT
{
    public static partial class Extensions
    {
#if NetFX

        #region WeekdayName

        /// <summary>
        /// Returns a string value containing the name of the specified weekday.
        /// </summary>
        /// <param name="i">The numeric designation for the weekday, from 1 through 7; 1 indicates the first day of the week and 7 indicates the last day of the week</param>
        /// <param name="abbreviation">Optional. Boolean value that indicates if the weekday name is to be abbreviated. Default is False</param>
        /// <returns></returns>
        public static string WeekdayName(this int i, bool abbreviation = false,
            DayOfWeek firstDayOfWeek = DayOfWeek.Sunday)
        {
            if (i < 1 || i > 7)
            {
                throw new ArgumentOutOfRangeException("i",
                    "Invalid value (" + i + "). Numeric weekday designation must be from 1 through 7.");
            }

            return Microsoft.VisualBasic.DateAndTime.WeekdayName(i, abbreviation,
                ConvertToFirstDayOfWeek(firstDayOfWeek));
        }

        private static Microsoft.VisualBasic.FirstDayOfWeek ConvertToFirstDayOfWeek(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Monday:
                    return Microsoft.VisualBasic.FirstDayOfWeek.Monday;
                case DayOfWeek.Tuesday:
                    return Microsoft.VisualBasic.FirstDayOfWeek.Tuesday;
                case DayOfWeek.Wednesday:
                    return Microsoft.VisualBasic.FirstDayOfWeek.Wednesday;
                case DayOfWeek.Thursday:
                    return Microsoft.VisualBasic.FirstDayOfWeek.Thursday;
                case DayOfWeek.Friday:
                    return Microsoft.VisualBasic.FirstDayOfWeek.Friday;
                case DayOfWeek.Saturday:
                    return Microsoft.VisualBasic.FirstDayOfWeek.Saturday;
                case DayOfWeek.Sunday:
                default:
                    return Microsoft.VisualBasic.FirstDayOfWeek.Sunday;
            }
        }

        #endregion

        #region "MonthName"

        /// <summary>
        /// Returns a string value containing the name of the specified month.
        /// </summary>
        /// <param name="i">The month number</param>
        /// <param name="abbreviation">Optional. Boolean value that indicates if the month name is to be abbreviated. Default is False</param>
        /// <returns></returns>
        public static string MonthName(this int i, bool abbreviation = false)
        {
            return Microsoft.VisualBasic.DateAndTime.MonthName(i, abbreviation);
        }

        #endregion

#endif
    }
}