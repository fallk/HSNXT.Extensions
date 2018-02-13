namespace HSNXT
{
    using System;

    /// <remarks>
    /// These extensions were created by Fredrik Kalseth, 
    /// http://iridescence.no/
    /// 
    /// For details about these extensions, visit
    /// http://iridescence.no/Posts/A-Set-of-Useful-Extension-Methods-for-DateTime.aspx
    /// </remarks>   
    public static partial class Extensions
    {
        /// <summary>
        /// Gets a DateTime representing midnight on the current date
        /// </summary>
        /// <param name="current">The current date</param>
        public static DateTime Midnight(this DateTime current)
        {
            return new DateTime(current.Year, current.Month, current.Day);
        }

        /// <summary>
        /// Gets a DateTime representing noon on the current date
        /// </summary>
        /// <param name="current">The current date</param>
        public static DateTime Noon(this DateTime current)
        {
            return new DateTime(current.Year, current.Month, current.Day, 12, 0, 0);
        }
    }
}