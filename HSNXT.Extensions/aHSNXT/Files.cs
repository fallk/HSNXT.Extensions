using System.IO;

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Returns whether or not this file is empty.
        /// </summary>
        /// <param name="fileInfo">The file to check.</param>
        /// <returns>True if the file object is null or the file's reported length is zero, false otherwise.</returns>
        public static bool IsNullOrEmpty(this FileInfo fileInfo)
        {
            return fileInfo == null || fileInfo.Length == 0;
        }
    }
}