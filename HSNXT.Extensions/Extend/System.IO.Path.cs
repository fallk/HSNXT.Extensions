using System;
using System.Collections.Generic;
using System.Reflection;
using JetBrains.Annotations;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Text;
using System.Globalization;
using System.Collections;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Collections.Concurrent;
using HSNXT.Internal;


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
        public static String GetFileExtension( [NotNull] this String fileName )
        {
            fileName.ThrowIfNull( nameof(fileName) );

            return Path.GetExtension( fileName );
        }
    }
}