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
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing extension methods for <see cref="Lazy{T}" />.
    /// </summary>
    public static class LayzEx
    {
        /// <summary>
        ///     Disposes the value of the given lazy, if the value was created.
        /// </summary>
        /// <typeparam name="T">The type of object that is being lazily initialized.</typeparam>
        /// <param name="lazy">A see <see cref="Lazy{T}" />.</param>
        [PublicAPI]
        public static void DisposeIfIsValueCreated<T>( [CanBeNull] this Lazy<T> lazy ) where T : IDisposable
        {
            if ( lazy != null && lazy.IsValueCreated )
                lazy.Value.Dispose();
        }
    }
}