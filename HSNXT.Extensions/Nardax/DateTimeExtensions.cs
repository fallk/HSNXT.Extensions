using System;

namespace HSNXT
{
    public static partial class Extensions
    {
        public static DateTime Floor(this DateTime dateTime, TimeSpan timeSpan)
        {
            var ticks = dateTime.Ticks / timeSpan.Ticks;
            return new DateTime(ticks * timeSpan.Ticks);
        }

        public static DateTime Round(this DateTime dateTime, TimeSpan timeSpan)
        {
            var ticks = (dateTime.Ticks + (timeSpan.Ticks / 2) + 1) / timeSpan.Ticks;
            return new DateTime(ticks * timeSpan.Ticks);
        }

        public static DateTime Ceiling(this DateTime dateTime, TimeSpan timeSpan)
        {
            var ticks = (dateTime.Ticks + timeSpan.Ticks - 1) / timeSpan.Ticks;
            return new DateTime(ticks * timeSpan.Ticks);
        }

        public static DateTime Min(this DateTime dateTime, DateTime value)
        {
            return dateTime <= value ? dateTime : value;
        }

        public static DateTime Max(this DateTime dateTime, DateTime value)
        {
            return dateTime >= value ? dateTime : value;
        }

        public static int MinutesFrom(this DateTime dateTime, DateTime from)
        {
            var timeSpan = (dateTime - from);
            return Convert.ToInt32(timeSpan.TotalMinutes);
        }

        public static int SecondsFrom(this DateTime dateTime, DateTime from)
        {
            var timeSpan = (dateTime - from);
            return Convert.ToInt32(timeSpan.TotalSeconds);
        }

        public static DateTime GetUnixEpoch()
        {
            return new DateTime(1970, 1, 1);
        }

        public static int MinutesFromUnixEpoch(this DateTime dateTime)
        {
            return dateTime.MinutesFrom(GetUnixEpoch());
        }

        public static int SecondsFromUnixEpoch(this DateTime dateTime)
        {
            return dateTime.SecondsFrom(GetUnixEpoch());
        }

        public static double MillisecondOfDay(this DateTime dateTime)
        {
            return dateTime.TimeOfDay.TotalMilliseconds;
        }
    }
}