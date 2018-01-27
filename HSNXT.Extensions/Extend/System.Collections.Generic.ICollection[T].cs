﻿using System;
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
    /// <summary>
    ///     Class containing some extension methods for <see cref="ICollection{T}" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Adds the specified value to the given value it satisfies the predicated provided.
        /// </summary>
        /// <exception cref="ArgumentNullException">The collection can not be null.</exception>
        /// <exception cref="ArgumentNullException">The predicate can not be null.</exception>
        /// <typeparam name="T">The type of the items in the given collection..</typeparam>
        /// <param name="collection">The collection to which the item should get added.</param>
        /// <param name="predicate">The predicate.</param>
        /// <param name="value">The value to add.</param>
        /// <returns>True if the value was added to the collection, otherwise false.</returns>
        [PublicAPI]
        public static Boolean AddIf<T>( [NotNull] [ItemCanBeNull] this ICollection<T> collection, [NotNull] Func<T, Boolean> predicate, T value )
        {
            collection.ThrowIfNull( nameof(collection) );
            predicate.ThrowIfNull( nameof(predicate) );

            if ( !predicate( value ) )
                return false;

            collection.Add( value );
            return true;
        }
    }
}


namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="ICollection{T}" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Adds the given value to the collection if the collection doesn't contains it already.
        /// </summary>
        /// <exception cref="ArgumentNullException">The collection can not be null.</exception>
        /// <typeparam name="T">The type of the items in the collection.</typeparam>
        /// <param name="collection">The collection to which the item should get added.</param>
        /// <param name="value">The value. to add</param>
        /// <returns>True if the value was added to the collection, otherwise false.</returns>
        [PublicAPI]
        public static Boolean AddIfNotContains<T>( [NotNull] this ICollection<T> collection, T value )
        {
            collection.ThrowIfNull( nameof(collection) );

            if ( collection.Contains( value ) )
                return false;

            collection.Add( value );
            return true;
        }
    }
}


namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="ICollection{T}" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Adds the given range of values to the collection.
        /// </summary>
        /// <exception cref="ArgumentNullException">The collection can not be null.</exception>
        /// <exception cref="ArgumentNullException">The values can not be null.</exception>
        /// <typeparam name="T">The type of the items in the collection.</typeparam>
        /// <param name="collection">The collection to which the values should get added.</param>
        /// <param name="values">The values to add.</param>
        /// <returns>Returns the given collection.</returns>
        [PublicAPI]
        public static ICollection<T> AddRange<T>( [NotNull] this ICollection<T> collection, [NotNull] params T[] values )
        {
            collection.ThrowIfNull( nameof(collection) );
            values.ThrowIfNull( nameof(values) );

            values.ForEach( collection.Add );
            return collection;
        }

        /// <summary>
        ///     Adds the items of the given IEnumerable to the collection.
        /// </summary>
        /// <exception cref="ArgumentNullException">The collection can not be null.</exception>
        /// <exception cref="ArgumentNullException">The enumerable can not be null.</exception>
        /// <typeparam name="T">The type of the items in the collection.</typeparam>
        /// <param name="collection">The collection to which the values should get added.</param>
        /// <param name="enumerable">The IEnumerable containing the items.</param>
        /// <returns>Returns the given collection.</returns>
        [PublicAPI]
        public static ICollection<T> AddRange<T>( [NotNull] this ICollection<T> collection, [NotNull] IEnumerable<T> enumerable )
        {
            collection.ThrowIfNull( nameof(collection) );
            enumerable.ThrowIfNull( nameof(enumerable) );

            enumerable.ForEach( collection.Add );
            return collection;
        }
    }
}


namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="ICollection{T}" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Adds all given values who satisfies the predicate to the collection.
        /// </summary>
        /// <exception cref="ArgumentNullException">collection can not be null.</exception>
        /// <exception cref="ArgumentNullException">predicate can not be null.</exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <typeparam name="T">The type of the items in the collection.</typeparam>
        /// <param name="collection">The collection to which the values should get added.</param>
        /// <param name="predicate">The predicate.</param>
        /// <param name="values">The values to add.</param>
        /// <returns>Returns the given collection.</returns>
        [PublicAPI]
        [NotNull]
        public static ICollection<T> AddRangeIf<T>( [NotNull] this ICollection<T> collection,
                                                    [NotNull] Func<T, Boolean> predicate,
                                                    [NotNull] params T[] values )
        {
            collection.ThrowIfNull( nameof(collection) );
            predicate.ThrowIfNull( nameof(predicate) );
            values.ThrowIfNull( nameof(values) );

            values
                .Where( predicate )
                .ForEach( collection.Add );
            return collection;
        }

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
                                                    [NotNull] Func<T, Boolean> predicate,
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
    }
}


namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="ICollection{T}" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Adds the given values to the collection, if it not already contains it.
        /// </summary>
        /// <exception cref="ArgumentNullException">collection can not be null.</exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <typeparam name="T">The type of the items in the collection.</typeparam>
        /// <param name="collection">The collection to which the values should get added.</param>
        /// <param name="values">The values to add.</param>
        /// <returns>Returns the given collection.</returns>
        [PublicAPI]
        [NotNull]
        public static ICollection<T> AddRangeIfNotContains<T>( [NotNull] this ICollection<T> collection, [NotNull] params T[] values )
        {
            collection.ThrowIfNull( nameof(collection) );
            values.ThrowIfNull( nameof(values) );

            values.ForEach( x =>
            {
                if ( !collection.Contains( x ) )
                    collection.Add( x );
            } );
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
    }
}


namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="ICollection{T}" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Removes the given value from the collection, if it matches the predicate.
        /// </summary>
        /// <exception cref="ArgumentNullException">collection can not be null.</exception>
        /// <exception cref="ArgumentNullException">predicate can not be null.</exception>
        /// <typeparam name="T">The type of the items in the collection.</typeparam>
        /// <param name="collection">The collection to act on.</param>
        /// <param name="value">The value to remove.</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns>Returns the given collection.</returns>
        [PublicAPI]
        [NotNull]
        public static ICollection<T> RemoveIf<T>( [NotNull] this ICollection<T> collection, [CanBeNull] T value, [NotNull] Func<T, Boolean> predicate )
        {
            collection.ThrowIfNull( nameof(collection) );
            predicate.ThrowIfNull( nameof(predicate) );

            if ( predicate( value ) )
                collection.Remove( value );
            return collection;
        }
    }
}


namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="ICollection{T}" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Removes the given values from the collection.
        /// </summary>
        /// <exception cref="ArgumentNullException">The collection can not be null.</exception>
        /// <exception cref="ArgumentNullException">The values can not be null.</exception>
        /// <typeparam name="T">The type of the items in the collection.</typeparam>
        /// <param name="collection">The collection, from which the values should get removed.</param>
        /// <param name="values">The values to remove.</param>
        /// <returns>Returns the given collection.</returns>
        [PublicAPI]
        [NotNull]
        public static ICollection<T> RemoveRange<T>( [NotNull] this ICollection<T> collection, [NotNull] params T[] values )
        {
            collection.ThrowIfNull( nameof(collection) );
            values.ThrowIfNull( nameof(values) );

            values.ForEach( x => collection.Remove( x ) );
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
    }
}


namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="ICollection{T}" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Removes the given values that satisfy the predicate from the collection.
        /// </summary>
        /// <exception cref="ArgumentNullException">collection can not be null.</exception>
        /// <exception cref="ArgumentNullException">predicate can not be null.</exception>
        /// <exception cref="ArgumentNullException">values can not be null.</exception>
        /// <typeparam name="T">The type of the items in the collection.</typeparam>
        /// <param name="collection">The collection, from which the values should get removed.</param>
        /// <param name="predicate">The predicate.</param>
        /// <param name="values">The values to remove.</param>
        /// <returns>Returns the given collection.</returns>
        [PublicAPI]
        [NotNull]
        public static ICollection<T> RemoveRangeIf<T>( [NotNull] this ICollection<T> collection,
                                                       [NotNull] Func<T, Boolean> predicate,
                                                       [NotNull] params T[] values )
        {
            collection.ThrowIfNull( nameof(collection) );
            predicate.ThrowIfNull( nameof(predicate) );
            values.ThrowIfNull( nameof(values) );

            values
                .Where( predicate )
                .ForEach( x => collection.Remove( x ) );
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
                                                       [NotNull] Func<T, Boolean> predicate,
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