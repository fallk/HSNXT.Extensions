#region Usings
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

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="IEnumerable{T}" />.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public static class IEnumerableStringEx
    {
        /// <summary>
        ///     Returns a path combined out of the items in the given IEnumerable.
        /// </summary>
        /// <exception cref="ArgumentNullException">The enumerable can not be null.</exception>
        /// <param name="enumerable">The IEnumerable to act on.</param>
        /// <returns>The combined path.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String PathCombine( [NotNull] [ItemCanBeNull] this IEnumerable<String> enumerable )
        {
            enumerable.ThrowIfNull( nameof(enumerable) );

            return Path.Combine( enumerable.ToArray() );
        }
    }
}