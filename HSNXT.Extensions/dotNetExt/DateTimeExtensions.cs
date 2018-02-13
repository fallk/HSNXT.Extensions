//Copyright (c) Chris Pietschmann 2012 (http://pietschsoft.com)
//All rights reserved.
//Licensed under the GNU Library General Public License (LGPL)
//License can be found here: http://www.codeplex.com/dotNetExt/license

using System;

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Rounds the DateTime to the nearest specified number of minutes
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="minutes"></param>
        /// <returns></returns>
        public static DateTime RoundToNearest(this DateTime dt, int minutes)
        {
            return dt.RoundToNearest(minutes.Minutes());
        }

        /// <summary>
        /// Rounds the DateTime to the nearest specifie TimeSpan internal
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="timeSpan"></param>
        /// <returns></returns>
        public static DateTime RoundToNearest(this DateTime dt, TimeSpan timeSpan)
        {
            var roundDown = false;
            var mod = (dt.Ticks % timeSpan.Ticks);
            if (mod != 0 && mod < (timeSpan.Ticks / 2))
            {
                roundDown = true;
            }

            var ticks = (((dt.Ticks + timeSpan.Ticks - 1) / timeSpan.Ticks) - (roundDown ? 1 : 0)) * timeSpan.Ticks;

            var addticks = ticks - dt.Ticks;

            return dt.AddTicks(addticks);
        }

        /// <summary>
        /// Returns the number of milliseconds from January 1st, 1970 until the specified DateTime
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static double MillisecondsSince1970(this DateTime dt)
        {
            return dt.Subtract(new DateTime(1970, 1, 1, 0, 0, 0)).TotalMilliseconds;
        }

        /// <summary>
        /// Returns the DateTime of the previous week day before the given DateTime.
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime PreviousWeekDay(this DateTime dt)
        {
            var dayOfWeek = dt.DayOfWeek;
            double daysToAdd = -1;

            if (dayOfWeek == DayOfWeek.Monday)
            {
                daysToAdd = -3;
            }
            else if (dayOfWeek == DayOfWeek.Sunday)
            {
                daysToAdd = -2;
            }

            return dt.AddDays(daysToAdd);
        }
    }
}