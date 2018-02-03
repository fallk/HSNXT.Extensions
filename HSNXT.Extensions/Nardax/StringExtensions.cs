using System;
using System.ComponentModel;

namespace HSNXT
{
    public static partial class Extensions
    {
        public static string TruncateLeft(this string value, int maxLength)
        {
            var startIndex = value.Length - maxLength;

            return startIndex < 1 ? value : value.Substring(startIndex, maxLength);
        }

        public static string TruncateRight(this string value, int maxLength)
        {
            return value.Length < maxLength ? value : value.Substring(0, maxLength);
        }
    }
}
