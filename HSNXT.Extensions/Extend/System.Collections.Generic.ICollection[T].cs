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
        ///     Adds all items of the given IEnumerable who satisfies the predicate to the collection.
        /// </summary>
        /// <exception cref="ArgumentNullException">collection can not be null.</exception>
        /// <exception cref="ArgumentNullException">predicate can not be null.</exception>
        /// <exception cref="ArgumentNullException">enumerable can not be null.</exception>
        /// <typeparam name="T">The type of the items in the collection.</typeparam>
        /// <param name="collection">The collection to which the values should get added.</param>
        /// <param name="predicate">The predicate.</param>
        /// <param name="enumerable">The IEnumerable containing the items.</param>
        /// <returns>Returns the given collection.</returns>
        [PublicAPI]
        [NotNull]
        public static ICollection<T> AddRangeIf<T>( [NotNull] this ICollection<T> collection,
                                                    [NotNull] Func<T, bool> predicate,
                                                    [NotNull] IEnumerable<T> enumerable )
        {
            collection.ThrowIfNull( nameof(collection) );
            predicate.ThrowIfNull( nameof(predicate) );
            enumerable.ThrowIfNull( nameof(enumerable) );

            enumerable
                .Where( predicate )
                .ForEach( collection.Add );
            return collection;
        }
        
        /// <summary>
        ///     Adds all items of the given IEnumerable to the collection, if it not already contains it.
        /// </summary>
        /// <exception cref="ArgumentNullException">The collection can not be null.</exception>
        /// <exception cref="ArgumentNullException">The enumerable can not be null.</exception>
        /// <typeparam name="T">The type of the items in the collection.</typeparam>
        /// <param name="collection">The collection to which the values should get added.</param>
        /// <param name="enumerable">The IEnumerable containing the items.</param>
        /// <returns>Returns the given collection.</returns>
        [PublicAPI]
        [NotNull]
        public static ICollection<T> AddRangeIfNotContains<T>( [NotNull] this ICollection<T> collection, [NotNull] IEnumerable<T> enumerable )
        {
            collection.ThrowIfNull( nameof(collection) );
            enumerable.ThrowIfNull( nameof(enumerable) );

            enumerable.ForEach( x =>
            {
                if ( !collection.Contains( x ) )
                    collection.Add( x );
            } );
            return collection;
        }

        /// <summary>
        ///     Removes the given values from the collection.
        /// </summary>
        /// <exception cref="ArgumentNullException">The collection can not be null.</exception>
        /// <exception cref="ArgumentNullException">The enumerable can not be null.</exception>
        /// <typeparam name="T">The type of the items in the collection.</typeparam>
        /// <param name="collection">The collection, from which the values should get removed.</param>
        /// <param name="enumerable">A IEnumerable containing the items to remove from the collection.</param>
        /// <returns>Returns the given collection.</returns>
        [PublicAPI]
        [NotNull]
        public static ICollection<T> RemoveRange<T>( [NotNull] this ICollection<T> collection, [NotNull] IEnumerable<T> enumerable )
        {
            collection.ThrowIfNull( nameof(collection) );
            enumerable.ThrowIfNull( nameof(enumerable) );

            enumerable.ForEach( x => collection.Remove( x ) );
            return collection;
        }

        /// <summary>
        ///     Removes the items of the given IEnumerable that satisfy the predicate from the collection.
        /// </summary>
        /// <exception cref="ArgumentNullException">collection can not be null.</exception>
        /// <exception cref="ArgumentNullException">predicate can not be null.</exception>
        /// <exception cref="ArgumentNullException">enumerable can not be null.</exception>
        /// <typeparam name="T">The type of the items in the collection.</typeparam>
        /// <param name="collection">The collection, from which the values should get removed.</param>
        /// <param name="predicate">The predicate.</param>
        /// <param name="enumerable">A IEnumerable containing the items to remove from the collection.</param>
        /// <returns>Returns the given collection.</returns>
        [PublicAPI]
        [NotNull]
        public static ICollection<T> RemoveRangeIf<T>( [NotNull] this ICollection<T> collection,
                                                       [NotNull] Func<T, bool> predicate,
                                                       [NotNull] IEnumerable<T> enumerable )
        {
            collection.ThrowIfNull( nameof(collection) );
            predicate.ThrowIfNull( nameof(predicate) );
            enumerable.ThrowIfNull( nameof(enumerable) );

            enumerable
                .Where( predicate )
                .ForEach( x => collection.Remove( x ) );
            return collection;
        }
    }
}