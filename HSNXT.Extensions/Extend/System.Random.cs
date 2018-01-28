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
        ///     Returns randomly one of the given values.
        /// </summary>
        /// <exception cref="ArgumentNullException">The random can not be null.</exception>
        /// <exception cref="ArgumentNullException">The values can not be null.</exception>
        /// <typeparam name="T">The type of the values.</typeparam>
        /// <param name="random">The random to use.</param>
        /// <param name="values">A list of values.</param>
        /// <returns>Returns randomly one of the given values.</returns>
        [CanBeNull]
        [Pure]
        [PublicAPI]
        public static T RandomOne<T>( [NotNull] this Random random, [NotNull] params T[] values )
        {
            random.ThrowIfNull( nameof(random) );
            values.ThrowIfNull( nameof(values) );

            return values[random.Next( values.Length )];
        }

        /// <summary>
        ///     Returns randomly one of the given values.
        /// </summary>
        /// <exception cref="ArgumentNullException">The random can not be null.</exception>
        /// <exception cref="ArgumentNullException">The values can not be null.</exception>
        /// <typeparam name="T">The type of the values.</typeparam>
        /// <param name="random">The random to use.</param>
        /// <param name="values">A IEnumerable containing the values.</param>
        /// <returns>Returns randomly one of the given values.</returns>
        [CanBeNull]
        [Pure]
        [PublicAPI]
        public static T RandomOne<T>( [NotNull] this Random random, [NotNull] IEnumerable<T> values )
        {
            random.ThrowIfNull( nameof(random) );
            values.ThrowIfNull( nameof(values) );

            var enumerable = values as T[] ?? values.ToArray();
            return enumerable.ElementAt( random.Next( enumerable.Length ) );
        }
    }
}