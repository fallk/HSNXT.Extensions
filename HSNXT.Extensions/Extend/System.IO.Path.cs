using System;
using HSNXT.JetBrains.Annotations;
using System.IO;


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Gets the extension of the given file.
        /// </summary>
        /// <exception cref="ArgumentNullException">The file name can not be null.</exception>
        /// <param name="fileName">The name of the file.</param>
        /// <returns>The file extension.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static string GetFileExtension([NotNull] this string fileName)
        {
            fileName.ThrowIfNull(nameof(fileName));

            return Path.GetExtension(fileName);
        }
    }
}