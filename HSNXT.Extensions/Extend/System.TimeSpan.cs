using System;
using HSNXT.JetBrains.Annotations;


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Adds the given time span to the current date time.
        /// </summary>
        /// <param name="timeSpan">The time span to add.</param>
        /// <returns>Returns the current date time with the specified time span added to it.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime Future(this TimeSpan timeSpan)
            => DateTime.Now.Add(timeSpan);

        /// <summary>
        ///     Subtracts the specified time span to the current date time.
        /// </summary>
        /// <param name="timeSpan">The time span to subtract.</param>
        /// <returns>Returns the current date time with the specified time span subtracted from it.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime Past(this TimeSpan timeSpan)
            => DateTime.Now.Subtract(timeSpan);
    }
}