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
    /// <summary>
    ///     Class containing some extension methods for <see cref="IDictionary{TKey,TValue}" />.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public static partial class Extensions
    {
        /// <summary>
        ///     Adds the given key value pair to the dictionary, if it not already contains the key.
        /// </summary>
        /// <exception cref="ArgumentNullException">The dictionary can not be null.</exception>
        /// <exception cref="ArgumentNullException">The key can not be null.</exception>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <typeparam name="TValue">the type of the value.</typeparam>
        /// <param name="dictionary">The dictionary to which the item should get added.</param>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        /// <returns>True if the item was added to the dictionary, otherwise false.</returns>
        [PublicAPI]
        public static Boolean AddIfNotContainsKey<TKey, TValue>( [NotNull] this IDictionary<TKey, TValue> dictionary,
                                                                 [NotNull] TKey key,
                                                                 TValue value )
        {
            dictionary.ThrowIfNull( nameof(dictionary) );
            key.ThrowIfNull( nameof(key) );

            if ( dictionary.ContainsKey( key ) )
                return false;

            dictionary.Add( key, value );
            return true;
        }

        /// <summary>
        ///     Adds the given key value pair to the dictionary, if it not already contains the key.
        /// </summary>
        /// <exception cref="ArgumentNullException">dictionary can not be null.</exception>
        /// <exception cref="ArgumentNullException">key can not be null.</exception>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <typeparam name="TValue">the type of the value.</typeparam>
        /// <param name="dictionary">The dictionary to which the item should get added.</param>
        /// <param name="keyValuePair">The KeyValuePair to add.</param>
        /// <returns>True if the item was added to the dictionary, otherwise false.</returns>
        [PublicAPI]
        public static Boolean AddIfNotContainsKey<TKey, TValue>( [NotNull] this IDictionary<TKey, TValue> dictionary,
                                                                 KeyValuePair<TKey, TValue> keyValuePair )
        {
            dictionary.ThrowIfNull( nameof(dictionary) );
            keyValuePair.Key.ThrowIfNull( nameof(keyValuePair.Key) );

            if ( dictionary.ContainsKey( keyValuePair.Key ) )
                return false;

            dictionary.Add( keyValuePair );
            return true;
        }

        /// <summary>
        ///     Adds the key and value returned by the given factory to the dictionary, if it not already contains the key.
        /// </summary>
        /// <exception cref="ArgumentNullException">The dictionary can not be null.</exception>
        /// <exception cref="ArgumentNullException">The key can not be null.</exception>
        /// <exception cref="ArgumentNullException">The factory can not be null.</exception>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <typeparam name="TValue">the type of the value.</typeparam>
        /// <param name="dictionary">The dictionary to which the item should get added.</param>
        /// <param name="key">The key.</param>
        /// <param name="valueFactory">The factory which creates the value for the key value pair.</param>
        /// <returns>True if the item was added to the dictionary, otherwise false.</returns>
        [PublicAPI]
        public static Boolean AddIfNotContainsKey<TKey, TValue>( [NotNull] this IDictionary<TKey, TValue> dictionary,
                                                                 [NotNull] TKey key,
                                                                 [NotNull] Func<TValue> valueFactory )
        {
            dictionary.ThrowIfNull( nameof(dictionary) );
            key.ThrowIfNull( nameof(key) );
            valueFactory.ThrowIfNull( nameof(valueFactory) );

            if ( dictionary.ContainsKey( key ) )
                return false;

            dictionary.Add( key, valueFactory() );
            return true;
        }

        /// <summary>
        ///     Adds the key and value returned by the given factory to the dictionary, if it not already contains the key.
        /// </summary>
        /// <exception cref="ArgumentNullException">The dictionary can not be null.</exception>
        /// <exception cref="ArgumentNullException">The key can not be null.</exception>
        /// <exception cref="ArgumentNullException">The factory can not be null.</exception>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <typeparam name="TValue">the type of the value.</typeparam>
        /// <param name="dictionary">The dictionary to which the item should get added.</param>
        /// <param name="key">The key.</param>
        /// <param name="valueFactory">The factory which creates the value for the key value pair.</param>
        /// <returns>True if the item was added to the dictionary, otherwise false.</returns>
        [PublicAPI]
        public static Boolean AddIfNotContainsKey<TKey, TValue>( [NotNull] this IDictionary<TKey, TValue> dictionary,
                                                                 [NotNull] TKey key,
                                                                 [NotNull] Func<TKey, TValue> valueFactory )
        {
            dictionary.ThrowIfNull( nameof(dictionary) );
            key.ThrowIfNull( nameof(key) );
            valueFactory.ThrowIfNull( nameof(valueFactory) );

            if ( dictionary.ContainsKey( key ) )
                return false;

            dictionary.Add( key, valueFactory( key ) );
            return true;
        }
    }
}


namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="IDictionary{TKey,TValue}" />.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public static partial class Extensions
    {
        /// <summary>
        ///     Adds the given key value pair to the dictionary, if the key does not already exist,
        ///     otherwise updates the value of the given key in the dictionary.
        /// </summary>
        /// <exception cref="ArgumentNullException">dictionary can not be null.</exception>
        /// <exception cref="ArgumentNullException">key can not be null.</exception>
        /// <typeparam name="TKey">Type of the key.</typeparam>
        /// <typeparam name="TValue">Type of the value.</typeparam>
        /// <param name="dictionary">The dictionary to work on.</param>
        /// <param name="key">The key to be added or whose value should be updated.</param>
        /// <param name="value">The value to be added or updated.</param>
        /// <returns>The new value for the key.</returns>
        [PublicAPI]
        public static TValue AddOrUpdate<TKey, TValue>( [NotNull] this IDictionary<TKey, TValue> dictionary,
                                                        [NotNull] TKey key,
                                                        TValue value )
        {
            dictionary.ThrowIfNull( nameof(dictionary) );
            key.ThrowIfNull( nameof(key) );

            if ( dictionary.ContainsKey( key ) )
                dictionary[key] = value;
            else
                dictionary.Add( key, value );

            return dictionary[key];
        }

        /// <summary>
        ///     Adds the given key value pair to the dictionary, if the key does not already exist,
        ///     otherwise updates the value of the given key in the dictionary.
        /// </summary>
        /// <exception cref="ArgumentNullException">dictionary can not be null.</exception>
        /// <exception cref="ArgumentNullException">key can not be null.</exception>
        /// <typeparam name="TKey">Type of the key.</typeparam>
        /// <typeparam name="TValue">Type of the value.</typeparam>
        /// <param name="dictionary">The dictionary to work on.</param>
        /// <param name="keyValuePair">The KeyValuePair to be added or updated.</param>
        /// <returns>The new value for the key.</returns>
        [PublicAPI]
        public static TValue AddOrUpdate<TKey, TValue>( [NotNull] this IDictionary<TKey, TValue> dictionary,
                                                        KeyValuePair<TKey, TValue> keyValuePair )
        {
            dictionary.ThrowIfNull( nameof(dictionary) );
            keyValuePair.Key.ThrowIfNull( nameof(keyValuePair.Key) );

            if ( dictionary.ContainsKey( keyValuePair.Key ) )
                dictionary[keyValuePair.Key] = keyValuePair.Value;
            else
                dictionary.Add( keyValuePair );

            return dictionary[keyValuePair.Key];
        }

        /// <summary>
        ///     Adds the given key and the value created by the value factory to the dictionary, if the key does not already exist,
        ///     otherwise updates the value of the given key in the dictionary.
        /// </summary>
        /// <exception cref="ArgumentNullException">dictionary can not be null.</exception>
        /// <exception cref="ArgumentNullException">key can not be null.</exception>
        /// <exception cref="ArgumentNullException">valueFactory can not be null.</exception>
        /// <typeparam name="TKey">Type of the key.</typeparam>
        /// <typeparam name="TValue">Type of the value.</typeparam>
        /// <param name="dictionary">The Dictionary to work on.</param>
        /// <param name="key">The Key.</param>
        /// <param name="valueFactory">The factory which creates the value for the key value pair.</param>
        /// <returns>The new value for the key.</returns>
        [PublicAPI]
        public static TValue AddOrUpdate<TKey, TValue>( [NotNull] this IDictionary<TKey, TValue> dictionary,
                                                        [NotNull] TKey key,
                                                        [NotNull] Func<TValue> valueFactory )
        {
            dictionary.ThrowIfNull( nameof(dictionary) );
            key.ThrowIfNull( nameof(key) );
            valueFactory.ThrowIfNull( nameof(valueFactory) );

            if ( dictionary.ContainsKey( key ) )
                dictionary[key] = valueFactory();
            else
                dictionary.Add( key, valueFactory() );

            return dictionary[key];
        }

        /// <summary>
        ///     Adds the given key and the value created by the value factory to the dictionary, if the key does not already exist,
        ///     otherwise updates the value of the given key in the dictionary.
        /// </summary>
        /// <typeparam name="TKey">Type of the key.</typeparam>
        /// <typeparam name="TValue">Type of the value.</typeparam>
        /// <param name="dictionary">The Dictionary to work on.</param>
        /// <param name="key">The Key.</param>
        /// <param name="valueFactory">The factory which creates the value for the key value pair.</param>
        /// <returns>The new value for the key.</returns>
        [PublicAPI]
        public static TValue AddOrUpdate<TKey, TValue>( [NotNull] this IDictionary<TKey, TValue> dictionary,
                                                        [NotNull] TKey key,
                                                        [NotNull] Func<TKey, TValue> valueFactory )
        {
            dictionary.ThrowIfNull( nameof(dictionary) );
            key.ThrowIfNull( nameof(key) );
            valueFactory.ThrowIfNull( nameof(valueFactory) );

            if ( dictionary.ContainsKey( key ) )
                dictionary[key] = valueFactory( key );
            else
                dictionary.Add( key, valueFactory( key ) );

            return dictionary[key];
        }
    }
}


namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="IDictionary{TKey,TValue}" />.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public static partial class Extensions
    {
        /// <summary>
        ///     Adds the values of the given dictionary to the dictionary.
        /// </summary>
        /// <exception cref="ArgumentNullException">The dictionary can not be null.</exception>
        /// <exception cref="ArgumentNullException">The other dictionary can not be null.</exception>
        /// <param name="dictionary">The dictionary to add the items to.</param>
        /// <param name="otherDictionary">The dictionary containing the items to add.</param>
        /// <typeparam name="TKey">The type of the keys.</typeparam>
        /// <typeparam name="TValue">The type of the values.</typeparam>
        /// <returns>Returns the dictionary containing all the items..</returns>
        [PublicAPI]
        public static IDictionary<TKey, TValue> AddRange<TKey, TValue>( [NotNull] this IDictionary<TKey, TValue> dictionary,
                                                                        [NotNull] IDictionary<TKey, TValue> otherDictionary )
        {
            dictionary.ThrowIfNull( nameof(dictionary) );
            otherDictionary.ThrowIfNull( nameof(otherDictionary) );

            otherDictionary.ForEach( x => dictionary.Add( x.Key, x.Value ) );
            return dictionary;
        }
    }
}


namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="IDictionary{TKey,TValue}" />.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public static partial class Extensions
    {
        /// <summary>
        ///     Concatenates the given sequences.
        /// </summary>
        /// <exception cref="ArgumentNullException">dictionary can not be null.</exception>
        /// <exception cref="ArgumentNullException">dictionaries can not be null.</exception>
        /// <exception cref="ArgumentException">An element with the same key already exists in the dictionary.</exception>
        /// <typeparam name="TValue">The type of the values.</typeparam>
        /// <typeparam name="TKey">The type of the keys.</typeparam>
        /// <param name="dictionary">The first dictionary to concatenate.</param>
        /// <param name="dictionaries">The other dictionaries to concatenate.</param>
        /// <returns>
        ///     Returns an <see cref="IDictionary{TKey,TValue}" /> that contains the concatenated elements of the given
        ///     sequences.
        /// </returns>
        [PublicAPI]
        [NotNull]
        public static IDictionary<TValue, TKey> ConcatAllToDictionary<TValue, TKey>(
            [NotNull] this IDictionary<TValue, TKey> dictionary,
            [NotNull] [ItemCanBeNull] params IDictionary<TValue, TKey>[] dictionaries )
        {
            dictionary.ThrowIfNull( nameof(dictionary) );
            dictionaries.ThrowIfNull( nameof(dictionaries) );

            var result = dictionary;
            dictionaries.ForEach( x =>
            {
                if ( x == null )
                    return;
                x.ForEach( y => result.Add( y.Key, y.Value ) );
            } );

            return result;
        }
    }
}


namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="IDictionary{TKey,TValue}" />.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public static partial class Extensions
    {
        /// <summary>
        ///     Concatenates the given sequences in a safe manner.
        /// </summary>
        /// <remarks>
        ///     Duplicated key are getting removed.
        /// </remarks>
        /// <exception cref="ArgumentNullException">dictionary can not be null.</exception>
        /// <exception cref="ArgumentNullException">dictionaries can not be null.</exception>
        /// <typeparam name="TValue">The type of the values.</typeparam>
        /// <typeparam name="TKey">The type of the keys.</typeparam>
        /// <param name="dictionary">The first dictionary to concatenate.</param>
        /// <param name="dictionaries">The other dictionaries to concatenate.</param>
        /// <returns>
        ///     Returns an <see cref="IDictionary{TKey,TValue}" /> that contains the concatenated elements of the given
        ///     sequences.
        /// </returns>
        [PublicAPI]
        [NotNull]
        public static IDictionary<TValue, TKey> ConcatAllToDictionarySafe<TValue, TKey>(
            [NotNull] this IDictionary<TValue, TKey> dictionary,
            [NotNull] [ItemCanBeNull] params IDictionary<TValue, TKey>[] dictionaries )
        {
            dictionary.ThrowIfNull( nameof(dictionary) );
            dictionaries.ThrowIfNull( nameof(dictionaries) );

            var result = dictionary;
            dictionaries.ForEach( x =>
            {
                if ( x == null )
                    return;

                x.ForEach( y =>
                {
                    if ( !result.ContainsKey( y.Key ) )
                        result.Add( y.Key, y.Value );
                } );
            } );

            return result;
        }
    }
}


namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="IDictionary{TKey,TValue}" />.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public static partial class Extensions
    {
        /// <summary>
        ///     Concatenates the given sequences.
        /// </summary>
        /// <exception cref="ArgumentNullException">first can not be null.</exception>
        /// <exception cref="ArgumentNullException">second can not be null.</exception>
        /// <exception cref="ArgumentException">An element with the same key already exists in the dictionary.</exception>
        /// <typeparam name="TValue">The type of the values.</typeparam>
        /// <typeparam name="TKey">The type of the keys.</typeparam>
        /// <param name="first">The first sequence to concatenate.</param>
        /// <param name="second">The second sequence to concatenate.</param>
        /// <returns>
        ///     Returns an <see cref="IDictionary{TKey,TValue}" /> that contains the concatenated elements of the two input
        ///     sequences.
        /// </returns>
        [PublicAPI]
        [NotNull]
        [Pure]
        public static IDictionary<TValue, TKey> ConcatToDictionary<TValue, TKey>(
            [NotNull] this IEnumerable<KeyValuePair<TValue, TKey>> first,
            [NotNull] IEnumerable<KeyValuePair<TValue, TKey>> second )
        {
            first.ThrowIfNull( nameof(first) );
            second.ThrowIfNull( nameof(second) );

            return first
                .Concat( second )
                .ToDictionary( x => x.Key, x => x.Value );
        }
    }
}


namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="IDictionary{TKey,TValue}" />.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public static partial class Extensions
    {
        /// <summary>
        ///     Concatenates the given sequences in a safe manner.
        /// </summary>
        /// <remarks>
        ///     Duplicated key are getting removed.
        /// </remarks>
        /// <exception cref="ArgumentNullException">first can not be null.</exception>
        /// <exception cref="ArgumentNullException">second can not be null.</exception>
        /// <typeparam name="TValue">The type of the values.</typeparam>
        /// <typeparam name="TKey">The type of the keys.</typeparam>
        /// <param name="first">The first sequence to concatenate.</param>
        /// <param name="second">The second sequence to concatenate.</param>
        /// <returns>
        ///     Returns an <see cref="IDictionary{TKey,TValue}" /> that contains the concatenated elements of the two input
        ///     sequences.
        /// </returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static IDictionary<TValue, TKey> ConcatToDictionarySafe<TValue, TKey>(
            [NotNull] this IEnumerable<KeyValuePair<TValue, TKey>> first,
            [NotNull] IEnumerable<KeyValuePair<TValue, TKey>> second )
        {
            first.ThrowIfNull( nameof(first) );
            second.ThrowIfNull( nameof(second) );

            return first
                .Concat( second )
                .GroupBy( x => x.Key )
                .ToDictionary( x => x.Key,
                               x => x.First()
                                     .Value );
        }
    }
}


namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="IDictionary{TKey,TValue}" />.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public static partial class Extensions
    {
        /// <summary>
        ///     Checks if the dictionary contains all given keys.
        /// </summary>
        /// <exception cref="ArgumentNullException">The dictionary can not be null.</exception>
        /// <exception cref="ArgumentNullException">The keys can not be null.</exception>
        /// <typeparam name="TKey">Type of the key.</typeparam>
        /// <typeparam name="TValue">Type of the value.</typeparam>
        /// <param name="dictionary">The Dictionary to act on.</param>
        /// <param name="keys">A list of keys.</param>
        /// <returns>Returns true if the dictionary contains all keys.</returns>
        [PublicAPI]
        [Pure]
        public static Boolean ContainsAllKey<TKey, TValue>( [NotNull] this IDictionary<TKey, TValue> dictionary,
                                                            [NotNull] [ItemNotNull] params TKey[] keys )
        {
            dictionary.ThrowIfNull( nameof(dictionary) );
            keys.ThrowIfNull( nameof(keys) );

            return keys.All( dictionary.ContainsKey );
        }

        /// <summary>
        ///     Checks if the dictionary contains all given keys.
        /// </summary>
        /// <exception cref="ArgumentNullException">The dictionary can not be null.</exception>
        /// <exception cref="ArgumentNullException">The keys can not be null.</exception>
        /// <typeparam name="TKey">Type of the key.</typeparam>
        /// <typeparam name="TValue">Type of the value.</typeparam>
        /// <param name="dictionary">The Dictionary to act on.</param>
        /// <param name="keys">A list of keys.</param>
        /// <returns>Returns true if the dictionary contains all keys.</returns>
        [PublicAPI]
        [Pure]
        public static Boolean ContainsAllKey<TKey, TValue>( [NotNull] this IDictionary<TKey, TValue> dictionary,
                                                            [NotNull] [ItemNotNull] IEnumerable<TKey> keys )
        {
            dictionary.ThrowIfNull( nameof(dictionary) );
            keys.ThrowIfNull( nameof(keys) );

            return keys.All( dictionary.ContainsKey );
        }
    }
}


namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="IDictionary{TKey,TValue}" />.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public static partial class Extensions
    {
        /// <summary>
        ///     Checks if the dictionary contains any of the given keys.
        /// </summary>
        /// <exception cref="ArgumentNullException">The dictionary can not be null.</exception>
        /// <exception cref="ArgumentNullException">The keys can not be null.</exception>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="dictionary">The dictionary to act on.</param>
        /// <param name="keys">A list of keys.</param>
        /// <returns>Returns true if the dictionary contains any of the given keys, otherwise false.</returns>
        [PublicAPI]
        [Pure]
        public static Boolean ContainsAnyKey<TKey, TValue>( [NotNull] this IDictionary<TKey, TValue> dictionary,
                                                            [NotNull] [ItemNotNull] params TKey[] keys )
        {
            dictionary.ThrowIfNull( nameof(dictionary) );
            keys.ThrowIfNull( nameof(keys) );

            return keys.Any( dictionary.ContainsKey );
        }

        /// <summary>
        ///     Checks if the dictionary contains any of the given keys.
        /// </summary>
        /// <exception cref="ArgumentNullException">The dictionary can not be null.</exception>
        /// <exception cref="ArgumentNullException">The keys can not be null.</exception>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="dictionary">The dictionary to act on.</param>
        /// <param name="keys">A list of keys.</param>
        /// <returns>Returns true if the dictionary contains any of the given keys, otherwise false.</returns>
        [PublicAPI]
        [Pure]
        public static Boolean ContainsAnyKey<TKey, TValue>( [NotNull] this IDictionary<TKey, TValue> dictionary,
                                                            [NotNull] [ItemNotNull] IEnumerable<TKey> keys )
        {
            dictionary.ThrowIfNull( nameof(dictionary) );
            keys.ThrowIfNull( nameof(keys) );

            return keys.Any( dictionary.ContainsKey );
        }
    }
}


namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="IDictionary{TKey,TValue}" />.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public static partial class Extensions
    {
        /// <summary>
        ///     Gets all keys of the given dictionary.
        /// </summary>
        /// <exception cref="ArgumentNullException">The dictionary can not be null.</exception>
        /// <typeparam name="TKey">Type of the key.</typeparam>
        /// <typeparam name="TValue">Type of the value.</typeparam>
        /// <param name="dictionary">The Dictionary to act on.</param>
        /// <returns>Returns all keys of the given dictionary.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static IEnumerable<TKey> GetAllKeys<TKey, TValue>( [NotNull] this IDictionary<TKey, TValue> dictionary )
        {
            dictionary.ThrowIfNull( nameof(dictionary) );

            return dictionary.Select( x => x.Key );
        }
    }
}


namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="IDictionary{TKey,TValue}" />.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public static partial class Extensions
    {
        /// <summary>
        ///     Gets all keys of the given dictionary as list.
        /// </summary>
        /// <exception cref="ArgumentNullException">The dictionary can not be null.</exception>
        /// <typeparam name="TKey">Type of the key.</typeparam>
        /// <typeparam name="TValue">Type of the value.</typeparam>
        /// <param name="dictionary">The Dictionary to act on.</param>
        /// <returns>Returns all keys of the given dictionary as list.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static List<TKey> GetAllKeysAsList<TKey, TValue>( [NotNull] this IDictionary<TKey, TValue> dictionary )
        {
            dictionary.ThrowIfNull( nameof(dictionary) );

            return dictionary.Select( x => x.Key )
                             .ToList();
        }
    }
}


namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="IDictionary{TKey,TValue}" />.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public static partial class Extensions
    {
        /// <summary>
        ///     Adds the given key value pair to the dictionary if the key does not already exist.
        /// </summary>
        /// <exception cref="ArgumentNullException">The dictionary can not be null.</exception>
        /// <exception cref="ArgumentNullException">The key can not be null.</exception>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="dictionary">The dictionary to act on.</param>
        /// <param name="key">The key of the element to add.</param>
        /// <param name="value">The value to be added, if the key does not already exist.</param>
        /// <returns>
        ///     Returns the value for the key.
        ///     This will be either the existing value for the key if the key is already in the
        ///     dictionary, or the new value if the key was not in the dictionary.
        /// </returns>
        [PublicAPI]
        [MustUseReturnValue]
        [CanBeNull]
        public static TValue GetOrAdd<TKey, TValue>( [NotNull] this IDictionary<TKey, TValue> dictionary, [NotNull] TKey key, TValue value )
        {
            dictionary.ThrowIfNull( nameof(dictionary) );
            key.ThrowIfNull( nameof(key) );

            if ( !dictionary.ContainsKey( key ) )
                dictionary.Add( key, value );

            return dictionary[key];
        }

        /// <summary>
        ///     Adds the given key value pair to the dictionary if the key does not already exist.
        /// </summary>
        /// <exception cref="ArgumentNullException">The dictionary can not be null.</exception>
        /// <exception cref="ArgumentNullException">The key can not be null.</exception>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="dictionary">The dictionary to act on.</param>
        /// <param name="keyValuePair">The key value pair to add or get.</param>
        /// <returns>
        ///     Returns the value for the key.
        ///     This will be either the existing value for the key if the key is already in the
        ///     dictionary, or the new value if the key was not in the dictionary.
        /// </returns>
        [PublicAPI]
        [MustUseReturnValue]
        [CanBeNull]
        public static TValue GetOrAdd<TKey, TValue>( [NotNull] this IDictionary<TKey, TValue> dictionary,
                                                     KeyValuePair<TKey, TValue> keyValuePair )
        {
            dictionary.ThrowIfNull( nameof(dictionary) );
            keyValuePair.Key.ThrowIfNull( nameof(keyValuePair.Key) );

            if ( !dictionary.ContainsKey( keyValuePair.Key ) )
                dictionary.Add( keyValuePair );

            return keyValuePair.Value;
        }

        /// <summary>
        ///     Adds the key value pair to the dictionary, by using the specified function, if the key does not already exist.
        /// </summary>
        /// <exception cref="ArgumentNullException">The dictionary can not be null.</exception>
        /// <exception cref="ArgumentNullException">The factory can not be null.</exception>
        /// <exception cref="ArgumentNullException">The key can not be null.</exception>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="dictionary">The dictionary to act on.</param>
        /// <param name="key">The key of the element to add.</param>
        /// <param name="valueFactory">TThe function used to generate a value for the key.</param>
        /// <returns>
        ///     Returns the value for the key. This will be either the existing value for the key if the key is already in the
        ///     dictionary, or the new value for the key as returned by value factory if the key was not in the dictionary.
        /// </returns>
        [PublicAPI]
        [MustUseReturnValue]
        [CanBeNull]
        public static TValue GetOrAdd<TKey, TValue>( [NotNull] this IDictionary<TKey, TValue> dictionary,
                                                     [NotNull] TKey key,
                                                     [NotNull] Func<TValue> valueFactory )
        {
            dictionary.ThrowIfNull( nameof(dictionary) );
            key.ThrowIfNull( nameof(key) );
            valueFactory.ThrowIfNull( nameof(valueFactory) );

            if ( !dictionary.ContainsKey( key ) )
                dictionary.Add( key, valueFactory() );

            return dictionary[key];
        }

        /// <summary>
        ///     Adds the key value pair to the dictionary, by using the specified function, if the key does not already exist.
        /// </summary>
        /// <exception cref="ArgumentNullException">The dictionary can not be null.</exception>
        /// <exception cref="ArgumentNullException">The factory can not be null.</exception>
        /// <exception cref="ArgumentNullException">The key can not be null.</exception>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="dictionary">The dictionary to act on.</param>
        /// <param name="key">The key of the element to add.</param>
        /// <param name="valueFactory">TThe function used to generate a value for the key.</param>
        /// <returns>
        ///     Returns the value for the key. This will be either the existing value for the key if the key is already in the
        ///     dictionary, or the new value for the key as returned by value factory if the key was not in the dictionary.
        /// </returns>
        [PublicAPI]
        [MustUseReturnValue]
        [CanBeNull]
        public static TValue GetOrAdd<TKey, TValue>( [NotNull] this IDictionary<TKey, TValue> dictionary,
                                                     [NotNull] TKey key,
                                                     [NotNull] Func<TKey, TValue> valueFactory )
        {
            dictionary.ThrowIfNull( nameof(dictionary) );
            key.ThrowIfNull( nameof(key) );
            valueFactory.ThrowIfNull( nameof(valueFactory) );

            if ( !dictionary.ContainsKey( key ) )
                dictionary.Add( key, valueFactory( key ) );

            return dictionary[key];
        }
    }
}


namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="IDictionary{TKey,TValue}" />.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public static partial class Extensions
    {
        /// <summary>
        ///     Concatenates all the elements of a first  using the specified separator between each element.
        /// </summary>
        /// <exception cref="ArgumentNullException">The first can not be null.</exception>
        /// <typeparam name="TValue">The type of the values in the first.</typeparam>
        /// <typeparam name="TKey">The type of the keys in the first.</typeparam>
        /// <param name="dictionary">A first that contains the elements to concatenate.</param>
        /// <param name="keyValueSeparator">The string to use as a separator between each key and value.</param>
        /// <param name="separator">
        ///     The string to use as a separator.
        ///     The separator is included in the returned string only if the given first has more than one item.
        /// </param>
        /// <returns>
        ///     A string that consists of the elements in the first delimited by the separator string.
        ///     If the given first is empty, the method returns String.Empty.
        /// </returns>
        [PublicAPI]
        [NotNull]
        [Pure]
        public static String StringJoin<TValue, TKey>( [NotNull] this IDictionary<TValue, TKey> dictionary,
                                                       [CanBeNull] String keyValueSeparator = "=",
                                                       [CanBeNull] String separator = "" )
        {
            dictionary.ThrowIfNull( nameof(dictionary) );

            return dictionary.Select( x => x.Key + keyValueSeparator + x.Value )
                             .StringJoin( separator );
        }
    }
}