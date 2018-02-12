using System;
using System.Collections.Generic;
using System.Linq;

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// The Entries() method returns a new IEnumerable object that contains the key/value pairs for each index in the IEnumerable.
        /// </summary>
        /// <param name="self">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains the elements to get the entries of.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="self" />.</typeparam>
        /// <returns>A new IEnumerable object.</returns>
        public static IEnumerable<(int, T)> Entries<T>(this IEnumerable<T> self)
        {
            var i = 0;
            foreach (var x in self)
            {
                yield return (i, x);
                i++;
            }
        }
        /// <summary>Determines whether all elements of a sequence satisfy a condition.</summary>
        /// <param name="self">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains the elements to apply the predicate to.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="self" />.</typeparam>
        /// <returns>
        /// <see langword="true" /> if every element of the source sequence passes the test in the specified predicate, or if the sequence is empty; otherwise, <see langword="false" />.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="self" /> or <paramref name="predicate" /> is <see langword="null" />.</exception>
        public static bool Every<T>(this IEnumerable<T> self, Func<T, bool> predicate) => self.All(predicate);


        /// <summary>
        /// The fill() method fills all the elements of an array from a start index to an end index with a static value.
        /// </summary>
        /// <param name="arr">The array to fill</param>
        /// <param name="value">The value to fill with</param>
        /// <typeparam name="T">Type of the array</typeparam>
        /// <returns>The same array</returns>
        public static T[] Fill<T>(this T[] arr, T value)
        {
            for (var i = arr.Length - 1; i >= 0; i--)
            {
                arr[i] = value;
            }

            return arr;
        }
        
        /// <summary>
        /// The fill() method fills all the elements of a list from a start index to an end index with a static value.
        /// </summary>
        /// <param name="arr">The list to fill</param>
        /// <param name="value">The value to fill with</param>
        /// <typeparam name="T">Type of the list</typeparam>
        /// <returns>The same list</returns>
        public static IList<T> Fill<T>(this IList<T> arr, T value)
        {
            for (var i = arr.Count - 1; i >= 0; i--)
            {
                arr[i] = value;
            }

            return arr;
        }

        /// <summary>Returns the first element of the sequence that satisfies a condition or a default value if no such element is found.</summary>
        /// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return an element from.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>
        /// <see langword="default" />(<typeparam name="TSource" />) if <paramref name="source" /> is empty or if no element passes the test specified by <paramref name="predicate" />; otherwise, the first element in <paramref name="source" /> that passes the test specified by <paramref name="predicate" />.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="predicate" /> is <see langword="null" />.</exception>
        public static TSource Find<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate) =>
            source.FirstOrDefault(predicate);

        /// <summary>The findIndex() method returns the index of the first element in the array that satisfies the
        /// provided testing function. Otherwise -1 is returned.</summary>
        /// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return an element index from.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>
        /// -1 if <paramref name="source" /> is empty or if no element passes the test specified by <paramref name="predicate" />; otherwise, the position of first element in <paramref name="source" /> that passes the test specified by <paramref name="predicate" />.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="predicate" /> is <see langword="null" />.</exception>
        public static int FindIndex<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            if (source == null)
                throw new ArgumentNullException(nameof (source));
            if (predicate == null)
                throw new ArgumentNullException(nameof (predicate));

            var i = 0;
            foreach (var source1 in source)
            {
                if (predicate(source1))
                    return i;
                i++;
            }
            return -1;
        }

        /// <summary>Determines whether a sequence contains a specified element by using the default equality comparer.</summary>
        /// <param name="source">A sequence in which to locate a value.</param>
        /// <param name="value">The value to locate in the sequence.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>
        /// <see langword="true" /> if the source sequence contains an element that has the specified value; otherwise, <see langword="false" />.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> is <see langword="null" />.</exception>
        public static bool Includes<TSource>(this IEnumerable<TSource> source, TSource value) => source.Contains(value);

        public static IEnumerable<int> Keys<T>(this IEnumerable<T> self)
        {
            var i = 0;
            foreach (var x in self)
            {
                yield return i;
                i++;
            }
        }

        /// <summary>Determines whether any element of a sequence satisfies a condition.</summary>
        /// <param name="self">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose elements to apply the predicate to.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="self" />.</typeparam>
        /// <returns>
        /// <see langword="true" /> if any elements in the source sequence pass the test in the specified predicate; otherwise, <see langword="false" />.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="self" /> or <paramref name="predicate" /> is <see langword="null" />.</exception>
        public static bool Some<T>(this IEnumerable<T> self, Func<T, bool> predicate) => self.Any(predicate);

    }
}