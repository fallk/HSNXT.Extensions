using System;
using System.Collections.Generic;
using System.Reflection;
using HSNXT.JetBrains.Annotations;
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
        ///     Determines whether the specified objects instances are the same instance.
        /// </summary>
        /// <exception cref="ArgumentNullException">The first object can not be null.</exception>
        /// <exception cref="ArgumentNullException">The second object can not be null.</exception>
        /// <param name="obj0">The first object to compare.</param>
        /// <param name="obj1">The second object  to compare.</param>
        /// <returns>Returns true if the objects are the same instance.</returns>
        [Pure]
        [PublicAPI]
        public static bool RefEquals( [NotNull] this object obj0, [NotNull] object obj1 )
        {
            obj0.ThrowIfNull( nameof(obj0) );
            obj1.ThrowIfNull( nameof(obj1) );

            return ReferenceEquals( obj0, obj1 );
        }
    }
}