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
        ///     Checks if the given IEnumerable is not null and contains some items.
        /// </summary>
        /// <example>
        ///     <code> 
        /// List&lt;String&gt; strings = null;
        /// Console.WriteLine( strings.AnyAndNotNull() ); // False
        /// strings = new List&lt;String&gt;();
        /// Console.WriteLine( strings.AnyAndNotNull() ); // False
        /// strings.AddRange( "1", "2", "3" );
        /// Console.WriteLine( strings.AnyAndNotNull() ); // True
        /// </code>
        /// </example>
        /// <typeparam name="T">The type of the items in the IEnumerable.</typeparam>
        /// <param name="enumerable">The IEnumerable to act on.</param>
        /// <returns>Returns true if the IEnumerable is not null or empty, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean AnyAndNotNull<T>( [CanBeNull] [ItemCanBeNull] this IEnumerable<T> enumerable )
            => enumerable != null
               && enumerable.Any();

        /// <summary>
        ///     Checks if the given IEnumerable is not null and contains some items
        ///     which mates the given predicate.
        /// </summary>
        /// <exception cref="ArgumentNullException">The predicate can not be null.</exception>
        /// <typeparam name="T">The type of the items in the IEnumerable.</typeparam>
        /// <param name="enumerable">The IEnumerable to act on.</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns>Returns true if the IEnumerable is not null or empty, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean AnyAndNotNull<T>( [CanBeNull] [ItemCanBeNull] this IEnumerable<T> enumerable, [NotNull] Func<T, Boolean> predicate )
        {
            predicate.ThrowIfNull( nameof(predicate) );

            return enumerable != null && enumerable.Any( predicate );
        }
    }
}


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Appends the given item to the given sequence.
        /// </summary>
        /// <exception cref="ArgumentNullException">source can not be null.</exception>
        /// <typeparam name="T">The type of the items in the IEnumerable.</typeparam>
        /// <param name="source">The sequence to append an item to.</param>
        /// <param name="item">The item to append.</param>
        /// <returns>The source sequence followed by the appended item.</returns>
        [Pure]
        [PublicAPI]
        [NotNull]
        public static IEnumerable<T> Append<T>( [NotNull] [ItemCanBeNull] this IEnumerable<T> source, [CanBeNull] T item )
        {
            source.ThrowIfNull( nameof(source) );

            source = source.Concat( new[] { item } );
            return source;
        }
    }
}


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     s
        ///     Checks if the IEnumerable contains all given values.
        /// </summary>
        /// <exception cref="ArgumentNullException">The enumerable can not be null.</exception>
        /// <exception cref="ArgumentNullException">The values can not be null.</exception>
        /// <typeparam name="T">The type of the items in the IEnumerable.</typeparam>
        /// <param name="enumerable">The IEnumerable to act on.</param>
        /// <param name="values">The values to search for.</param>
        /// <returns>Returns true if the IEnumerable contains all given values, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean ContainsAll<T>( [NotNull] [ItemCanBeNull] this IEnumerable<T> enumerable, [NotNull] [ItemCanBeNull] params T[] values )
        {
            enumerable.ThrowIfNull( nameof(enumerable) );
            values.ThrowIfNull( nameof(values) );

            return values.All( enumerable.Contains );
        }

        /// <summary>
        ///     s
        ///     Checks if the IEnumerable contains all values of the given IEnumerable.
        /// </summary>
        /// <exception cref="ArgumentNullException">The enumerable can not be null.</exception>
        /// <exception cref="ArgumentNullException">The values can not be null.</exception>
        /// <typeparam name="T">The type of the items in the IEnumerable.</typeparam>
        /// <param name="enumerable">The IEnumerable to act on.</param>
        /// <param name="values">The IEnumerable containing the values to search for.</param>
        /// <returns>Returns true if the IEnumerable contains all given values, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean ContainsAll<T>( [NotNull] [ItemCanBeNull] this IEnumerable<T> enumerable, [NotNull] [ItemCanBeNull] IEnumerable<T> values )
        {
            enumerable.ThrowIfNull( nameof(enumerable) );
            values.ThrowIfNull( nameof(values) );

            return values.All( enumerable.Contains );
        }
    }
}


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Checks if the IEnumerable contains any of the given values.
        /// </summary>
        /// <exception cref="ArgumentNullException">The enumerable can not be null.</exception>
        /// <exception cref="ArgumentNullException">The values can not be null.</exception>
        /// <typeparam name="T">The type of the items in the IEnumerable.</typeparam>
        /// <param name="enumerable">The IEnumerable to act on.</param>
        /// <param name="values">The values to search for.</param>
        /// <returns>Returns true if the IEnumerable contains any of the given values, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean ContainsAny<T>( [NotNull] [ItemCanBeNull] this IEnumerable<T> enumerable, [NotNull] [ItemCanBeNull] params T[] values )
        {
            enumerable.ThrowIfNull( nameof(enumerable) );
            values.ThrowIfNull( nameof(values) );

            return values.Any( enumerable.Contains );
        }

        /// <summary>
        ///     Checks if the IEnumerable contains any of the values of the given IEnumerable.
        /// </summary>
        /// <exception cref="ArgumentNullException">The enumerable can not be null.</exception>
        /// <exception cref="ArgumentNullException">The values can not be null.</exception>
        /// <typeparam name="T">The type of the items in the IEnumerable.</typeparam>
        /// <param name="enumerable">The IEnumerable to act on.</param>
        /// <param name="values">The IEnumerable containing the values to search for.</param>
        /// <returns>
        ///     Returns true if the IEnumerable contains any of the values of the given IEnumerable,
        ///     otherwise false.
        /// </returns>
        [Pure]
        [PublicAPI]
        public static Boolean ContainsAny<T>( [NotNull] [ItemCanBeNull] this IEnumerable<T> enumerable, [NotNull] [ItemCanBeNull] IEnumerable<T> values )
        {
            enumerable.ThrowIfNull( nameof(enumerable) );
            values.ThrowIfNull( nameof(values) );

            return values.Any( enumerable.Contains );
        }
    }
}


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Returns all unique items, based on the given predicate.
        /// </summary>
        /// <exception cref="ArgumentNullException">The enumerable can not be null.</exception>
        /// <exception cref="ArgumentNullException">The predicate can not be null.</exception>
        /// <param name="enumerable">The IEnumerable.</param>
        /// <param name="predicate">The Predicate.</param>
        /// <typeparam name="T">The type of the items in the IEnumerable.</typeparam>
        /// <typeparam name="TKey">The input type of the predicate.</typeparam>
        [Pure]
        [PublicAPI]
        [NotNull]
        public static IEnumerable<T> Distinct<T, TKey>( [NotNull] [ItemCanBeNull] this IEnumerable<T> enumerable, [NotNull] Func<T, TKey> predicate )
        {
            enumerable.ThrowIfNull( nameof(enumerable) );
            predicate.ThrowIfNull( nameof(predicate) );

            return enumerable.GroupBy( predicate )
                             .Select( g => g )
                             .Select( x => x.First() );
        }
    }
}


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Ensures that the given <see cref="IEnumerable{T}" /> is not null.
        /// </summary>
        /// <typeparam name="T">The type of the items in the IEnumerable.</typeparam>
        /// <param name="enumerable">The IEnumerable.</param>
        /// <returns>Returns the given IEnumerable if it's not null, otherwise an empty array of type T.</returns>
        [NotNull]
        [PublicAPI]
        [Pure]
        public static IEnumerable<T> EnsureNotNull<T>( [CanBeNull] [ItemCanBeNull] this IEnumerable<T> enumerable )
            => enumerable ?? new T[0];
    }
}


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Produces the set difference of two sequences by using the specified
        ///     <see cref="System.Collections.Generic.IEqualityComparer{TKey}" /> to compare values.
        /// </summary>
        /// <exception cref="ArgumentNullException">first can not be null.</exception>
        /// <exception cref="ArgumentNullException">second can not be null.</exception>
        /// <exception cref="ArgumentNullException">keySelector can not be null.</exception>
        /// <typeparam name="TSource">The type of the items to compare.</typeparam>
        /// <typeparam name="TKey">The type of the item keys.</typeparam>
        /// <param name="first">
        ///     An <see cref="System.Collections.Generic.IEnumerable{TSource}" /> whose elements that are not also
        ///     in <paramref name="second" /> will be returned.
        /// </param>
        /// <param name="second">
        ///     An <see cref="System.Collections.Generic.IEnumerable{TSource}" /> whose elements that also occur
        ///     in the first sequence will cause those elements to be removed from the returned sequence.
        /// </param>
        /// <param name="keySelector">A function used to select the key of the items to compare.</param>
        /// <param name="comparer">
        ///     An optional <see cref="System.Collections.Generic.IEqualityComparer{TKey}" /> to compare the
        ///     keys of the items.
        /// </param>
        /// <returns>A sequence that contains the set difference of the elements of two sequences.</returns>
        [Pure]
        [PublicAPI]
        [NotNull]
        public static IEnumerable<TSource> Except<TSource, TKey>( [NotNull] [ItemCanBeNull] this IEnumerable<TSource> first,
                                                                  [NotNull] [ItemCanBeNull] IEnumerable<TSource> second,
                                                                  [NotNull] Func<TSource, TKey> keySelector,
                                                                  [CanBeNull] IEqualityComparer<TKey> comparer = null )
        {
            first.ThrowIfNull( nameof(first) );
            second.ThrowIfNull( nameof(second) );
            keySelector.ThrowIfNull( nameof(keySelector) );

            var internalComparer = IEqualityComparerEx.By( keySelector, comparer );

            return first.Except( second, internalComparer );
        }
    }
}


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Executes the given action for each item in the IEnumerable in a reversed order.
        /// </summary>
        /// <exception cref="ArgumentNullException">The enumerable can not be null.</exception>
        /// <exception cref="ArgumentNullException">The action can not be null.</exception>
        /// <remarks>It's save to remove items from the IEnumerable within the loop.</remarks>
        /// <param name="enumerable">The IEnumerable to act on.</param>
        /// <param name="action">The action to execute for each item in the IEnumerable.</param>
        [PublicAPI]
        [NotNull]
        public static IEnumerable<T> ForEachReverse<T>( [NotNull] [ItemCanBeNull] this IEnumerable<T> enumerable, [NotNull] Action<T> action )
        {
            enumerable.ThrowIfNull( nameof(enumerable) );
            action.ThrowIfNull( nameof(action) );

            var list = enumerable.ToList();
            for ( var i = list.Count - 1; i >= 0; i-- )
                action( list[i] );

            return list;
        }
    }
}


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Executes the given action for each item in the IEnumerable in a reversed order.
        /// </summary>
        /// <exception cref="ArgumentNullException">The enumerable can not be null.</exception>
        /// <exception cref="NullReferenceException">The action can not be null.</exception>
        /// <remarks>It's save to remove items from the IEnumerable within the loop.</remarks>
        /// <param name="enumerable">The IEnumerable to act on.</param>
        /// <param name="action">The action to execute for each item in the IEnumerable.</param>
        [PublicAPI]
        [NotNull]
        public static async Task<IEnumerable<T>> ForEachReverseAsync<T>( [NotNull] [ItemCanBeNull] this IEnumerable<T> enumerable, [NotNull] Func<T, Task> action )
        {
            enumerable.ThrowIfNull( nameof(enumerable) );
            action.ThrowIfNull( nameof(action) );

            // ReSharper disable once PossibleMultipleEnumeration
            var list = enumerable.ToList();
            for ( var i = list.Count - 1; i >= 0; i-- )
                await action( list[i] );

            // ReSharper disable once PossibleMultipleEnumeration
            return enumerable;
        }
    }
}


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Returns the equal items of two IEnumerables, according to the specified comparer.
        ///     Beginning at the start of the IEnumerables, ending when first different item is found.
        /// </summary>
        /// <typeparam name="T">The type of the items in the IEnumerable.</typeparam>
        /// <param name="left">The first IEnumerable.</param>
        /// <param name="right">The second IEnumerable.</param>
        /// <param name="comparer">The comparer used to test items for equality.</param>
        /// <returns>
        ///     A sequence consisting of the first elements of <paramref name="left" /> that match the first elements of
        ///     <paramref name="right" />.
        ///     The resulting sequence ends when the two input sequence start to differ.
        /// </returns>
        [Pure]
        [PublicAPI]
        [NotNull]
        public static IEnumerable<T> GetEqualItemsFromStart<T>( [NotNull] [ItemCanBeNull] this IEnumerable<T> left,
                                                                [NotNull] [ItemCanBeNull] IEnumerable<T> right,
                                                                [CanBeNull] IEqualityComparer<T> comparer = null )
        {
            left.ThrowIfNull( nameof(left) );
            right.ThrowIfNull( nameof(right) );

            comparer = comparer ?? EqualityComparer<T>.Default;

            using ( IEnumerator<T> rightEnumerator = left.GetEnumerator(),
                leftEnumerator = right.GetEnumerator() )
                while ( rightEnumerator.MoveNext() && leftEnumerator.MoveNext() )
                    if ( comparer.Equals( rightEnumerator.Current, leftEnumerator.Current ) )
                        yield return rightEnumerator.Current;
                    else
                        yield break;
        }
    }
}


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Gets a random item form the given IEnumerable.
        /// </summary>
        /// <exception cref="ArgumentNullException">The enumerable can not be null.</exception>
        /// <typeparam name="T">The type of the items in the enumerable.</typeparam>
        /// <param name="enumerable">The IEnumerable.</param>
        /// <returns>Returns an random item of the given IEnumerable.</returns>
        [Pure]
        [PublicAPI]
        [CanBeNull]
        public static T GetRandomItem<T>( [NotNull] [ItemCanBeNull] this IEnumerable<T> enumerable )
        {
            enumerable.ThrowIfNull( nameof(enumerable) );

            var list = enumerable as IList<T> ?? enumerable.ToList();
            var index = RandomValueEx.GetRandomInt32( 0, list.Count );
            return list.ElementAt( index );
        }
    }
}


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Produces the set intersection of two sequences.
        /// </summary>
        /// <exception cref="ArgumentNullException">first can not be null.</exception>
        /// <exception cref="ArgumentNullException">second can not be null.</exception>
        /// <exception cref="ArgumentNullException">keySelector can not be null.</exception>
        /// <typeparam name="TSource">The type of the items to compare.</typeparam>
        /// <typeparam name="TKey">The type of the item keys.</typeparam>
        /// <param name="first">
        ///     An <see cref="System.Collections.Generic.IEnumerable{TSource}" /> whose distinct elements that also
        ///     appear in second will be returned.
        /// </param>
        /// <param name="second">
        ///     An <see cref="System.Collections.Generic.IEnumerable{TSource}" /> whose distinct elements that also
        ///     appear in the first sequence will be returned.
        /// </param>
        /// <param name="keySelector">A function used to select the key of the items to compare.</param>
        /// <param name="comparer">
        ///     An optional <see cref="System.Collections.Generic.IEqualityComparer{TKey}" /> to compare the
        ///     keys of the items.
        /// </param>
        /// <returns>Returns a sequence that contains the elements that form the set intersection of two sequences.</returns>
        [Pure]
        [PublicAPI]
        [CanBeNull]
        public static IEnumerable<TSource> Intersect<TSource, TKey>( [NotNull] [ItemCanBeNull] this IEnumerable<TSource> first,
                                                                     [NotNull] [ItemCanBeNull] IEnumerable<TSource> second,
                                                                     [NotNull] Func<TSource, TKey> keySelector,
                                                                     [CanBeNull] IEqualityComparer<TKey> comparer = null )
        {
            first.ThrowIfNull( nameof(first) );
            second.ThrowIfNull( nameof(second) );
            keySelector.ThrowIfNull( nameof(keySelector) );

            var internalComparer = IEqualityComparerEx.By( keySelector, comparer );

            return first.Intersect( second, internalComparer );
        }
    }
}


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Gets whether the IEnumerable contains at least the specified number of items matching the specified predicate.
        /// </summary>
        /// <exception cref="ArgumentNullException">The enumerable can not be null.</exception>
        /// <exception cref="ArgumentNullException">The predicate can not be null.</exception>
        /// <typeparam name="T">The type of the items in the IEnumerable.</typeparam>
        /// <param name="enumerable">The IEnumerable.</param>
        /// <param name="count">The minimum number of items.</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns>
        ///     Returns true if the IEnumerable contains at least the specified number of items matching the specified
        ///     predicate, otherwise false.
        /// </returns>
        [Pure]
        [PublicAPI]
        public static Boolean MinimumOf<T>( [NotNull] [ItemCanBeNull] this IEnumerable<T> enumerable, Int32 count, [NotNull] Func<T, Boolean> predicate )
        {
            enumerable.ThrowIfNull( nameof(enumerable) );
            predicate.ThrowIfNull( nameof(predicate) );

            return enumerable.Count( predicate ) >= count;
        }

        /// <summary>
        ///     Gets whether the IEnumerable contains at least the specified number of items.
        /// </summary>
        /// <exception cref="ArgumentNullException">The enumerable can not be null.</exception>
        /// <typeparam name="T">The type of the items in the IEnumerable.</typeparam>
        /// <param name="enumerable">The IEnumerable.</param>
        /// <param name="count">The minimum number of items.</param>
        /// <returns>Returns true if the IEnumerable contains at least the specified number of items, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean MinimumOf<T>( [NotNull] [ItemCanBeNull] this IEnumerable<T> enumerable, Int32 count )
        {
            enumerable.ThrowIfNull( nameof(enumerable) );

            return enumerable.Count() >= count;
        }
    }
}


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Determines whether the given IEnumerable contains no items, or not.
        /// </summary>
        /// <exception cref="ArgumentNullException">The enumerable can not be null.</exception>
        /// <param name="enumerable">The IEnumerable to check.</param>
        /// <typeparam name="T">The type of the items in the IEnumerable.</typeparam>
        /// <returns>Returns true if the IEnumerable doesn't contain any items, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean NotAny<T>( [NotNull] [ItemCanBeNull] this IEnumerable<T> enumerable )
        {
            enumerable.ThrowIfNull( nameof(enumerable) );

            return !enumerable.Any();
        }

        /// <summary>
        ///     Determines whether the given IEnumerable contains no items matching the given predicate, or not.
        /// </summary>
        /// <exception cref="ArgumentNullException">The enumerable can not be null.</exception>
        /// <exception cref="ArgumentNullException">The predicate can not be null.</exception>
        /// <param name="enumerable">The IEnumerable to check.</param>
        /// <param name="predicate">The predicate.</param>
        /// <typeparam name="T">The type of the items in the IEnumerable.</typeparam>
        /// <returns>Returns true if the IEnumerable doesn't contain any items, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean NotAny<T>( [NotNull] [ItemCanBeNull] this IEnumerable<T> enumerable, [NotNull] Func<T, Boolean> predicate )
        {
            enumerable.ThrowIfNull( nameof(enumerable) );
            predicate.ThrowIfNull( nameof(predicate) );

            return !enumerable.Any( predicate );
        }
    }
}


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Partitions the given sequence into blocks with the specified size.
        /// </summary>
        /// <exception cref="ArgumentNullException">source can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">size is smaller than 1.</exception>
        /// <typeparam name="T">The type of the items in the IEnumerable.</typeparam>
        /// <param name="source">The sequence to partition.</param>
        /// <param name="size">The number of items per block.</param>
        /// <returns>Returns the created blocks.</returns>
        [Pure]
        [PublicAPI]
        [NotNull]
        public static IEnumerable<IEnumerable<T>> Partition<T>( [NotNull] [ItemCanBeNull] this IEnumerable<T> source, Int32 size )
        {
            source.ThrowIfNull( nameof(source) );
            if ( size < 1 )
                throw new ArgumentOutOfRangeException( nameof(size), size, $"{nameof(size)} is out of range. Size must be > 1." );

            return source
                .WithIndex()
                .GroupBy( x => x.Index / size )
                .Select( x => x.WithoutIndex() );
        }
    }
}


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Prepends the given item to the given sequence.
        /// </summary>
        /// <exception cref="ArgumentNullException">source can not be null.</exception>
        /// <typeparam name="T">The type of the items in the IEnumerable.</typeparam>
        /// <param name="source">The sequence to prepend an item to.</param>
        /// <param name="item">The item to prepend.</param>
        /// <returns>The source sequence preceded by the prepended item.</returns>
        [Pure]
        [PublicAPI]
        [NotNull]
        public static IEnumerable<T> Prepend<T>( [NotNull] [ItemCanBeNull] this IEnumerable<T> source, [CanBeNull] T item )
        {
            source.ThrowIfNull( nameof(source) );

            return new[] { item }.Concat( source );
        }
    }
}


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Orders the items in the IEnumerable randomly.
        /// </summary>
        /// <exception cref="ArgumentNullException">The enumerable can not be null.</exception>
        /// <param name="enumerable">The IEnumerable.</param>
        /// <typeparam name="T">The type of the items in the enumerable.</typeparam>
        [Pure]
        [PublicAPI]
        [NotNull]
        public static IEnumerable<T> Randomize<T>( [NotNull] [ItemCanBeNull] this IEnumerable<T> enumerable )
        {
            enumerable.ThrowIfNull( nameof(enumerable) );

            var rnd = new Random();
            return enumerable.OrderBy( x => rnd.Next() );
        }
    }
}


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Creates a specification with the given condition and message.
        /// </summary>
        /// <exception cref="ArgumentNullException">expression can not be null.</exception>
        /// <typeparam name="T">The target type of the expression.</typeparam>
        /// <param name="enumerable">The enumerable to create the expression on.</param>
        /// <param name="expression">An expression determining whether an object matches the specification or not.</param>
        /// <param name="message">An error messaged, returned when an object doesn't match the specification.</param>
        /// <returns>Returns a specification with the given condition and message.</returns>
        [Pure]
        [PublicAPI]
        [NotNull]
        public static ISpecification<T> SpecificationForItems<T>( [CanBeNull] [ItemCanBeNull] this IEnumerable<T> enumerable,
                                                                  [NotNull] Func<T, Boolean> expression,
                                                                  [CanBeNull] String message = null )
        {
            expression.ThrowIfNull( nameof(expression) );

            return new ExpressionSpecification<T>( expression, message );
        }
    }
}


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Concatenates all the elements of a IEnumerable, using the specified separator between each element.
        /// </summary>
        /// <exception cref="ArgumentNullException">The enumerable can not be null.</exception>
        /// <typeparam name="T">The type of the items in the IEnumerable.</typeparam>
        /// <param name="enumerable">An IEnumerable that contains the elements to concatenate.</param>
        /// <param name="separator">
        ///     The string to use as a separator.
        ///     The separator is included in the returned string only if the given IEnumerable has more than one item.
        /// </param>
        /// <returns>
        ///     A string that consists of the elements in the IEnumerable delimited by the separator string.
        ///     If the given IEnumerable is empty, the method returns String.Empty.
        /// </returns>
        [Pure]
        [PublicAPI]
        [NotNull]
        public static String StringJoin<T>( [NotNull] [ItemCanBeNull] this IEnumerable<T> enumerable, String separator = "" )
        {
            enumerable.ThrowIfNull( nameof(enumerable) );

            return String.Join( separator, enumerable );
        }

        /// <summary>
        ///     Concatenates all the elements of a IEnumerable, using the specified separator between each element.
        /// </summary>
        /// <exception cref="ArgumentNullException">The enumerable can not be null.</exception>
        /// <typeparam name="T">The type of the items in the IEnumerable.</typeparam>
        /// <param name="enumerable">An IEnumerable that contains the elements to concatenate.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <param name="separator">
        ///     The string to use as a separator.
        ///     The separator is included in the returned string only if the given IEnumerable has more than one item.
        /// </param>
        /// <returns>
        ///     A string that consists of the elements in the IEnumerable delimited by the separator string.
        ///     If the given IEnumerable is empty, the method returns String.Empty.
        /// </returns>
        [Pure]
        [PublicAPI]
        [NotNull]
        public static String StringJoin<T>( [NotNull] [ItemCanBeNull] this IEnumerable<T> enumerable, [NotNull] Func<T, String> selector, String separator = "" )
        {
            enumerable.ThrowIfNull( nameof(enumerable) );
            selector.ThrowIfNull( nameof(selector) );

            return String.Join( separator, enumerable.Select( selector ) );
        }
    }
}


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Takes items from the given IEnumerable until the first item matches the specified predicate.
        /// </summary>
        /// <exception cref="ArgumentNullException">The enumerable can not be null.</exception>
        /// <exception cref="ArgumentNullException">The predicate can not be null.</exception>
        /// <param name="enumerable">The IEnumerable.</param>
        /// <param name="predicate">The predicate.</param>
        /// <typeparam name="T">The type of the items in the IEnumerable.</typeparam>
        /// <returns>Returns the items from the start of the IEnumerable until the first item matching the predicate.</returns>
        [Pure]
        [PublicAPI]
        [NotNull]
        public static IEnumerable<T> TakeUntil<T>( [NotNull] [ItemCanBeNull] this IEnumerable<T> enumerable, [NotNull] Func<T, Boolean> predicate )
        {
            enumerable.ThrowIfNull( nameof(enumerable) );
            predicate.ThrowIfNull( nameof(predicate) );

            return enumerable.TakeWhile( x => !predicate( x ) );
        }
    }
}


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Converts the IEnumerable containing the groupings into a Dictionary of those groupings.
        /// </summary>
        /// <exception cref="ArgumentNullException">The groupings can not be null.</exception>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <typeparam name="TValue">The type of the items.</typeparam>
        /// <param name="groupings">The enumeration of groupings from a GroupBy() clause.</param>
        /// <returns>
        ///     Returns a dictionary of groupings such that the key of the dictionary is TKey type and the value is List of
        ///     TValue type.
        /// </returns>
        [Pure]
        [PublicAPI]
        [NotNull]
        public static Dictionary<TKey, List<TValue>> ToDictionary<TKey, TValue>(
            [NotNull] [ItemNotNull] this IEnumerable<IGrouping<TKey, TValue>> groupings )
        {
            groupings.ThrowIfNull( nameof(groupings) );

            return groupings.ToDictionary( x => x.Key, x => x.ToList() );
        }
    }
}


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Converts the given sequence to a new <see cref="HashSet{T}" />.
        /// </summary>
        /// <exception cref="ArgumentNullException">collection can not be null.</exception>
        /// <typeparam name="T">The type of the items in the collection.</typeparam>
        /// <param name="collection">The source collection.</param>
        /// <returns>Returns the new created <see cref="HashSet{T}" />.</returns>
        public static HashSet<T> ToHashSet<T>( this IEnumerable<T> collection )
        {
            collection.ThrowIfNull( nameof(collection) );

            return new HashSet<T>( collection );
        }
    }
}


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Converts the given IEnumerable to a ObservableCollection.
        /// </summary>
        /// <exception cref="ArgumentNullException">The enumerable can not be null.</exception>
        /// <param name="enumerable">The IEnumerable.</param>
        /// <typeparam name="T">The type of the items in the IEnumerable.</typeparam>
        /// <returns>The given IEnumerable as ObservableCollection.</returns>
        [Pure]
        [PublicAPI]
        [NotNull]
        public static ObservableCollection<T> ToObservableCollection<T>( [NotNull] [ItemCanBeNull] this IEnumerable<T> enumerable )
        {
            enumerable.ThrowIfNull( nameof(enumerable) );

            return new ObservableCollection<T>( enumerable );
        }
    }
}


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Builds a tree node collection containing the items of the given collection.
        /// </summary>
        /// <exception cref="ArgumentNullException">collection can not be null.</exception>
        /// <exception cref="ArgumentNullException">idSelector can not be null.</exception>
        /// <exception cref="ArgumentNullException">parentIdSelector can not be null.</exception>
        /// <exception cref="InvalidOperationException">Found items without a matching parent.</exception>
        /// <exception cref="InvalidOperationException">Found items without a unique id.</exception>
        /// <typeparam name="TItem">The type of the items.</typeparam>
        /// <typeparam name="TKey">The type of the item key.</typeparam>
        /// <param name="collection">The collection to convert to a tree.</param>
        /// <param name="idSelector">A function used to extract the id of an item.</param>
        /// <param name="parentIdSelector">A function used to extract the id of an items parent.</param>
        /// <param name="rootId">The id of the root element.</param>
        /// <param name="equalityComparer">
        ///     A <see cref="EqualityComparer{TKey}" /> used to compare the ids of the items, or null to
        ///     use the default <see cref="EqualityComparer{TKey}" />.
        /// </param>
        /// <returns>Returns a tree representing the given collection.</returns>
        [PublicAPI]
        [NotNull]
        [Pure]
        public static ITreeNodeCollection<TItem> ToTreeNodeCollection<TItem, TKey>(
            [NotNull] this IEnumerable<TItem> collection,
            [NotNull] Func<TItem, TKey> idSelector,
            [NotNull] Func<TItem, TKey> parentIdSelector,
            [CanBeNull] TKey rootId,
            [CanBeNull] IEqualityComparer<TKey> equalityComparer = null )
        {
            collection.ThrowIfNull( nameof(collection) );
            idSelector.ThrowIfNull( nameof(idSelector) );
            parentIdSelector.ThrowIfNull( nameof(parentIdSelector) );

            var enumerable = collection as IList<TItem> ?? collection.ToList();
            equalityComparer = equalityComparer ?? EqualityComparer<TKey>.Default;

            // Get all items without a unique id
            var itemsWithSameKey = enumerable
                .Where( x => enumerable.Count( y => equalityComparer.Equals( idSelector( x ), idSelector( y ) ) ) > 1 )
                .ToList();
            if ( itemsWithSameKey.Any() )
            {
                // Found items without a unique id => throw exception
                var sb = new StringBuilder();
                sb.AppendLine( "The following items do not have a unique id:" );
                itemsWithSameKey.ForEach( x => sb.AppendLine( $"\t {x}" ) );

                throw new InvalidOperationException( sb.ToString() );
            }

            // Get all items without a matching parent
            var itemsWithNoParent = enumerable.Where( x => enumerable
                                                               .Where( y => !y.RefEquals( x ) )
                                                               .All( y => !equalityComparer.Equals( idSelector( y ), parentIdSelector( x ) ) )
                                                           && !equalityComparer.Equals( parentIdSelector( x ), rootId ) )
                                              .ToList();

            // ReSharper disable once InvertIf
            if ( itemsWithNoParent.Any() )
            {
                // Found items without a marching parent => throw exception
                var sb = new StringBuilder();
                sb.AppendLine( "Could not find a matching parent for the following items:" );
                itemsWithNoParent.ForEach( x => sb.AppendLine( $"\t {x}" ) );

                throw new InvalidOperationException( sb.ToString() );
            }

            return ToTreeNodeCollectionInternal( enumerable, idSelector, parentIdSelector, rootId, equalityComparer );
        }

        /// <summary>
        ///     Builds a tree node collection containing the items of the given collection.
        /// </summary>
        /// <typeparam name="TItem">The type of the items.</typeparam>
        /// <typeparam name="TKey">The type of the item key.</typeparam>
        /// <param name="collection">The collection to convert to a tree.</param>
        /// <param name="idSelector">A function used to extract the id of an item.</param>
        /// <param name="parentIdSelector">A function used to extract the id of an items parent.</param>
        /// <param name="rootId">The id of the root element.</param>
        /// <param name="equalityComparer">A <see cref="EqualityComparer{TKey}" /> used to compare the ids of the items.</param>
        /// <returns>Returns a tree representing the given collection.</returns>
        [NotNull]
        [Pure]
        private static ITreeNodeCollection<TItem> ToTreeNodeCollectionInternal<TItem, TKey>(
            // ReSharper disable once ParameterTypeCanBeEnumerable.Local
            [NotNull] this ICollection<TItem> collection,
            [NotNull] Func<TItem, TKey> idSelector,
            [NotNull] Func<TItem, TKey> parentIdSelector,
            [CanBeNull] TKey rootId,
            [NotNull] IEqualityComparer<TKey> equalityComparer )
        {
            var rootNodes = new TreeNodeCollection<TItem>( null );
            rootNodes.AddRange(
                collection
                    // ReSharper disable once ImplicitlyCapturedClosure
                    .Where( x => equalityComparer.Equals( parentIdSelector( x ), rootId ) )
                    .Select( x => new TreeNode<TItem>( x, null, ToTreeNodeCollectionInternal( collection, idSelector, parentIdSelector, idSelector( x ), equalityComparer ) ) ) );

            return rootNodes;
        }
    }
}


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Returns all items of the given enumerable which satisfy the given specification.
        /// </summary>
        /// <exception cref="ArgumentNullException">enumerable can not be null.</exception>
        /// <exception cref="ArgumentNullException">specification can not be null.</exception>
        /// <typeparam name="T">The type of the item in the enumerable.</typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <param name="specification">The specification.</param>
        /// <returns>Returns the items which satisfy the given specification.</returns>
        [Pure]
        [PublicAPI]
        [NotNull]
        public static IEnumerable<T> Where<T>( [NotNull] [ItemCanBeNull] this IEnumerable<T> enumerable, [NotNull] ISpecification<T> specification )
        {
            enumerable.ThrowIfNull( nameof(enumerable) );
            specification.ThrowIfNull( nameof(specification) );

            return enumerable.Where( specification.IsSatisfiedBy );
        }
    }
}


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Performs a where predicate on the IEnumerable, if the given condition is true,
        ///     otherwise returns all items of the IEnumerable.
        /// </summary>
        /// <exception cref="ArgumentNullException">The source can not be null.</exception>
        /// <exception cref="ArgumentNullException">The predicate can not be null.</exception>
        /// <typeparam name="T">The type of the items in the IEnumerable.</typeparam>
        /// <param name="source">The IEnumerable containing the items.</param>
        /// <param name="condition">The condition determining whether the where predicate gets applied or not.</param>
        /// <param name="predicate">The where predicate.</param>
        /// <returns>Returns the result of the predicate if the condition is true, otherwise the source IEnumerable.</returns>
        [Pure]
        [PublicAPI]
        [NotNull]
        public static IEnumerable<T> WhereIf<T>( [NotNull] [ItemCanBeNull] this IEnumerable<T> source,
                                                 Boolean condition,
                                                 [NotNull] Func<T, Boolean> predicate )
        {
            source.ThrowIfNull( nameof(source) );
            predicate.ThrowIfNull( nameof(predicate) );

            return condition ? source.Where( predicate ) : source;
        }

        /// <summary>
        ///     Performs a where predicate on the IEnumerable, if the given condition is true,
        ///     otherwise returns all items of the IEnumerable.
        /// </summary>
        /// <exception cref="ArgumentNullException">The source can not be null.</exception>
        /// <exception cref="ArgumentNullException">The predicate can not be null.</exception>
        /// <typeparam name="T">The type of the items in the IEnumerable.</typeparam>
        /// <param name="source">The IEnumerable containing the items.</param>
        /// <param name="condition">The condition determining whether the where predicate gets applied or not.</param>
        /// <param name="predicate">The where predicate.</param>
        /// <returns>Returns the result of the predicate if the condition is true, otherwise the source IEnumerable.</returns>
        [Pure]
        [PublicAPI]
        [NotNull]
        public static IEnumerable<T> WhereIf<T>( [NotNull] [ItemCanBeNull] this IEnumerable<T> source,
                                                 Boolean condition,
                                                 [NotNull] Func<T, Int32, Boolean> predicate )
        {
            source.ThrowIfNull( nameof(source) );
            predicate.ThrowIfNull( nameof(predicate) );

            return condition ? source.Where( predicate ) : source;
        }
    }
}


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Returns all items of the given enumerable which doesn't satisfy the given specification.
        /// </summary>
        /// <exception cref="ArgumentNullException">enumerable can not be null.</exception>
        /// <exception cref="ArgumentNullException">specification can not be null.</exception>
        /// <typeparam name="T">The type of the item in the enumerable.</typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <param name="specification">The specification.</param>
        /// <returns>Returns the items which doesn't satisfy the given specification.</returns>
        [Pure]
        [PublicAPI]
        [NotNull]
        public static IEnumerable<T> WhereNot<T>( [NotNull] [ItemCanBeNull] this IEnumerable<T> enumerable, [NotNull] ISpecification<T> specification )
        {
            enumerable.ThrowIfNull( nameof(enumerable) );
            specification.ThrowIfNull( nameof(specification) );

            return enumerable.Where( x => !specification.IsSatisfiedBy( x ) );
        }
    }
}


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Associates an index to each element of the source IEnumerable.
        /// </summary>
        /// <exception cref="ArgumentNullException">source can not be null.</exception>
        /// <typeparam name="T">The type of the items in the given IEnumerable.</typeparam>
        /// <param name="source">The source IEnumerable.</param>
        /// <returns>A sequence of elements paired with their index in the sequence.</returns>
        [Pure]
        [PublicAPI]
        [NotNull]
        public static IEnumerable<IIndexedItem<T>> WithIndex<T>( [NotNull] [ItemCanBeNull] this IEnumerable<T> source )
        {
            source.ThrowIfNull( nameof(source) );

            return source.Select( ( item, index ) => new IndexedItem<T>( index, item ) );
        }
    }
}


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Removes the indexes from a IEnumerable of indexed elements, returning only the elements themselves.
        /// </summary>
        /// <exception cref="ArgumentNullException">source can not be null.</exception>
        /// <typeparam name="T">The type of the items in the given IEnumerable.</typeparam>
        /// <param name="source">The IEnumerable to remove the indexes from.</param>
        /// <returns>A IEnumerable of elements without their associated indexes.</returns>
        [Pure]
        [PublicAPI]
        [NotNull]
        public static IEnumerable<T> WithoutIndex<T>( [NotNull] [ItemNotNull] this IEnumerable<IIndexedItem<T>> source )
        {
            source.ThrowIfNull( nameof(source) );

            return source.Select( indexed => indexed.Item );
        }
    }
}