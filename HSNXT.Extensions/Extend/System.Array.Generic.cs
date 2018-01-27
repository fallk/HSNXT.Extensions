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
        ///     Sets a range of elements in the array to zero, to false, or to null, depending on the element type.
        /// </summary>
        /// <exception cref="ArgumentNullException">The array can not be null.</exception>
        /// <typeparam name="T">The type of the items in the array.</typeparam>
        /// <param name="array">The array whose elements need to be cleared.</param>
        /// <param name="index">The starting index of the range of elements to clear.</param>
        /// <param name="length">The number of elements to clear.</param>
        /// <returns>Returns the cleared array.</returns>
        [NotNull]
        [PublicAPI]
        public static T[] Clear<T>( [NotNull] this T[] array, Int32 index, Int32 length )
        {
            array.ThrowIfNull( nameof(array) );

            Array.Clear( array, index, length );
            return array;
        }

        /// <summary>
        ///     Clears the given array.
        /// </summary>
        /// <exception cref="ArgumentNullException">The array can not be null.</exception>
        /// <typeparam name="T">The type of the items in the array.</typeparam>
        /// <param name="array">The array to clear.</param>
        /// <returns>Returns the cleared array.</returns>
        [NotNull]
        [PublicAPI]
        public static T[] ClearAll<T>( [NotNull] this T[] array )
        {
            array.ThrowIfNull( nameof(array) );

            Array.Clear( array, 0, array.Length );
            return array;
        }

        /// <summary>
        ///     Searches for the specified object and returns the index of its first occurrence in a one-dimensional array.
        /// </summary>
        /// <exception cref="ArgumentNullException">Array can not be null.</exception>
        /// <typeparam name="T">The type of the items in the array.</typeparam>
        /// <param name="array">The one-dimensional  to search.</param>
        /// <param name="value">The object to locate in <paramref name="array" />.</param>
        /// <returns>
        ///     The index of the first occurrence of  within the entire , if found; otherwise, the lower bound of the array
        ///     minus 1.
        /// </returns>
        [PublicAPI]
        [Pure]
        public static Int32 IndexOf<T>( [NotNull] this T[] array, [CanBeNull] T value )
        {
            array.ThrowIfNull( nameof(array) );

            return Array.IndexOf( array, value );
        }

        /// <summary>
        ///     Searches for the specified object in a range of elements of a one dimensional array, and returns the index of its
        ///     first occurrence. The range extends from a specified index to the end of the array.
        /// </summary>
        /// <exception cref="ArgumentNullException">Array can not be null.</exception>
        /// <typeparam name="T">The type of the items in the array.</typeparam>
        /// <param name="array">The one-dimensional  to search.</param>
        /// <param name="value">The object to locate in <paramref name="array" />.</param>
        /// <param name="startIndex">The starting index of the search. 0 (zero) is valid in an empty array.</param>
        /// <returns>
        ///     The index of the first occurrence of  within the range of elements in  that extends from  to the last element,
        ///     if found; otherwise, the lower bound of the array minus 1.
        /// </returns>
        [PublicAPI]
        [Pure]
        public static Int32 IndexOf<T>( [NotNull] this T[] array, [CanBeNull] T value, Int32 startIndex )
        {
            array.ThrowIfNull( nameof(array) );

            return Array.IndexOf( array, value, startIndex );
        }

        /// <summary>
        ///     Searches for the specified object in a range of elements of a one-dimensional array, and returns the index of its
        ///     first occurrence. The range extends from a specified index for a specified number of elements.
        /// </summary>
        /// <exception cref="ArgumentNullException">Array can not be null.</exception>
        /// <typeparam name="T">The type of the items in the array.</typeparam>
        /// <param name="array">The one-dimensional  to search.</param>
        /// <param name="value">The object to locate in <paramref name="array" />.</param>
        /// <param name="startIndex">The starting index of the search. 0 (zero) is valid in an empty array.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>
        ///     The index of the first occurrence of  within the range of elements in  that starts at  and contains the
        ///     number of elements specified in , if found; otherwise, the lower bound of the array minus 1.
        /// </returns>
        [PublicAPI]
        [Pure]
        public static Int32 IndexOf<T>( [NotNull] this T[] array, [CanBeNull] T value, Int32 startIndex, Int32 count )
        {
            array.ThrowIfNull( nameof(array) );

            return Array.IndexOf( array, value, startIndex, count );
        }

        /// <summary>
        ///     Searches for the specified object and returns the index of the last occurrence within the entire
        ///     <see cref="Array" />.
        /// </summary>
        /// <exception cref="ArgumentNullException">array can not be null.</exception>
        /// <typeparam name="T">The type of the items in the array.</typeparam>
        /// <param name="array">The one-dimensional  to search.</param>
        /// <param name="value">The object to locate in .</param>
        /// <returns>
        ///     The index of the last occurrence of  within the entire , if found; otherwise, the lower bound of the array
        ///     minus 1.
        /// </returns>
        [PublicAPI]
        [Pure]
        public static Int32 LastIndexOf<T>( [NotNull] this T[] array, [CanBeNull] T value )
        {
            array.ThrowIfNull( nameof(array) );

            return Array.LastIndexOf( array, value );
        }

        /// <summary>
        ///     Searches for the specified object and returns the index of the last occurrence within the range of elements in the
        ///     <see cref="Array" /> that extends from the first element to the specified index.
        /// </summary>
        /// <exception cref="ArgumentNullException">array can not be null.</exception>
        /// <typeparam name="T">The type of the items in the array.</typeparam>
        /// <param name="array">The one-dimensional  to search.</param>
        /// <param name="value">The object to locate in .</param>
        /// <param name="startIndex">The starting index of the backward search.</param>
        /// <returns>
        ///     The index of the last occurrence of  within the range of elements in  that extends from the first element to ,
        ///     if found; otherwise, the lower bound of the array minus 1.
        /// </returns>
        [PublicAPI]
        [Pure]
        public static Int32 LastIndexOf<T>( [NotNull] this T[] array, [CanBeNull] T value, Int32 startIndex )
        {
            array.ThrowIfNull( nameof(array) );

            return Array.LastIndexOf( array, value, startIndex );
        }

        /// <summary>
        ///     Searches for the specified object and returns the index of the last occurrence within the range of elements in the
        ///     <see cref="Array" /> that contains the specified number of elements and ends at the specified index.
        /// </summary>
        /// <exception cref="ArgumentNullException">array can not be null.</exception>
        /// <typeparam name="T">The type of the items in the array.</typeparam>
        /// <param name="array">The one-dimensional  to search.</param>
        /// <param name="value">The object to locate in .</param>
        /// <param name="startIndex">The starting index of the backward search.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>
        ///     The index of the last occurrence of  within the range of elements in  that contains the number of elements
        ///     specified in  and ends at , if found; otherwise, the lower bound of the array minus 1.
        /// </returns>
        [PublicAPI]
        [Pure]
        public static Int32 LastIndexOf<T>( [NotNull] this T[] array, [CanBeNull] T value, Int32 startIndex, Int32 count )
        {
            array.ThrowIfNull( nameof(array) );

            return Array.LastIndexOf( array, value, startIndex, count );
        }

        /// <summary>
        ///     Populates the given array with the specified value.
        /// </summary>
        /// <exception cref="ArgumentNullException">array can not be null.</exception>
        /// <typeparam name="T">The type of the items in the array.</typeparam>
        /// <param name="array">The array.</param>
        /// <param name="value">The value.</param>
        /// <returns>Returns the given array.</returns>
        [PublicAPI]
        public static T[] Populate<T>( [NotNull] this T[] array, [CanBeNull] T value )
        {
            array.ThrowIfNull( nameof(array) );

            for ( var i = 0; i < array.Length; i++ )
                array[i] = value;

            return array;
        }

        /// <summary>
        ///     Resizes the given array to the specified size.
        /// </summary>
        /// <exception cref="ArgumentNullException">The array can not be null.</exception>
        /// <typeparam name="T">The type of the items in the array.</typeparam>
        /// <param name="array">The array to resize.</param>
        /// <param name="newSize">The new size of the array.</param>
        /// <returns>Returns the given array with the new size.</returns>
        [PublicAPI]
        public static T[] Resize<T>( [NotNull] this T[] array, Int32 newSize )
        {
            // ReSharper disable once AccessToModifiedClosure
            array.ThrowIfNull( nameof(array) );

            Array.Resize( ref array, newSize );
            return array;
        }

        /// <summary>
        ///     Reverses the sequence of the elements in the entire one-dimensional array.
        /// </summary>
        /// <exception cref="ArgumentNullException">The array can not be null.</exception>
        /// <typeparam name="T">The type of the items in the array.</typeparam>
        /// <param name="array">The one-dimensional array to reverse.</param>
        /// <returns>Returns the reversed array.</returns>
        [PublicAPI]
        public static T[] Reverse<T>( [NotNull] this T[] array )
        {
            array.ThrowIfNull( nameof(array) );

            Array.Reverse( array );
            return array;
        }

        /// <summary>
        ///     Reverses the sequence of the elements in a range of elements in the one-dimensional .
        /// </summary>
        /// <exception cref="ArgumentNullException">The array can not be null.</exception>
        /// <typeparam name="T">The type of the items in the array.</typeparam>
        /// <param name="array">The one-dimensional array to reverse.</param>
        /// <param name="index">The starting index of the section to reverse.</param>
        /// <param name="length">The number of elements in the section to reverse.</param>
        /// <returns>Returns the reversed array.</returns>
        [PublicAPI]
        public static T[] Reverse<T>( [NotNull] this T[] array, Int32 index, Int32 length )
        {
            array.ThrowIfNull( nameof(array) );

            Array.Reverse( array, index, length );
            return array;
        }

        /// <summary>
        ///     Copies the specified range of items from the source array to the given target array.
        /// </summary>
        /// <exception cref="ArgumentNullException">array can not be null.</exception>
        /// <exception cref="ArgumentNullException">targetArray can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">The start index must be greater or equals to zero.</exception>
        /// <exception cref="ArgumentOutOfRangeException">The number of items to copy must be greater or equals to zero.</exception>
        /// <exception cref="ArgumentOutOfRangeException">The start index cannot be greater than the length of the given array.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     The number of items to copy cannot be greater than the length of the
        ///     target array.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     The number of items to copy cannot be greater than the length of the
        ///     source array (minus the start index).
        /// </exception>
        /// <typeparam name="T">The type of the items in the array.</typeparam>
        /// <param name="array">The source array.</param>
        /// <param name="startIndex">The start index of the items range.</param>
        /// <param name="itemsToCpoy">The number of items to copy, starting at the given start index.</param>
        /// <param name="targetArray">The target array.</param>
        /// <returns>Returns the target array.</returns>
        [PublicAPI]
        [NotNull]
        public static T[] Slice<T>( [NotNull] this T[] array, Int32 startIndex, Int32 itemsToCpoy, [NotNull] T[] targetArray )
        {
            array.ThrowIfNull( nameof(array) );
            targetArray.ThrowIfNull( nameof(targetArray) );

            if ( startIndex < 0 )
                throw new ArgumentOutOfRangeException( array.GetName( x => startIndex ),
                                                       "The start index must be greater or equals to zero." );

            if ( itemsToCpoy < 0 )
                throw new ArgumentOutOfRangeException( array.GetName( x => itemsToCpoy ),
                                                       "The number of items to copy must be greater or equals to zero." );

            if ( startIndex > array.Length )
                throw new ArgumentOutOfRangeException( array.GetName( x => startIndex ),
                                                       "The start index cannot be greater than the length of the given array." );

            if ( itemsToCpoy > targetArray.Length )
                throw new ArgumentOutOfRangeException( array.GetName( x => itemsToCpoy ),
                                                       "The number of items to copy cannot be greater than the length of the target array." );

            if ( itemsToCpoy > array.Length - startIndex )
                throw new ArgumentOutOfRangeException( array.GetName( x => itemsToCpoy ),
                                                       "The number of items to copy cannot be greater than the length of the source array (minus the start index)." );

            for ( var i = 0; i < itemsToCpoy; ++i )
                targetArray[i] = array[startIndex + i];

            return targetArray;
        }

        /// <summary>
        ///     Copies the specified range of items from the source array to the given target array.
        /// </summary>
        /// <exception cref="ArgumentNullException">array can not be null.</exception>
        /// <exception cref="ArgumentNullException">targetArray can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">The start index must be greater or equals to zero.</exception>
        /// <exception cref="ArgumentOutOfRangeException">The number of items to copy must be greater or equals to zero.</exception>
        /// <exception cref="ArgumentOutOfRangeException">The start index cannot be greater than the length of the given array.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     The number of items to copy cannot be greater than the length of the
        ///     source array (minus the start index).
        /// </exception>
        /// <typeparam name="T">The type of the items in the array.</typeparam>
        /// <param name="array">The source array.</param>
        /// <param name="startIndex">The start index of the items range.</param>
        /// <param name="itemsToCpoy">The number of items to copy, starting at the given start index.</param>
        /// <returns>Returns the target array.</returns>
        [PublicAPI]
        [NotNull]
        public static T[] Slice<T>( [NotNull] this T[] array, Int32 startIndex, Int32 itemsToCpoy )
        {
            var targetArray = new T[itemsToCpoy];
            return array.Slice( startIndex, itemsToCpoy, targetArray );
        }

        /// <summary>
        ///     Copies the specified range of items from the source array to the given target array.
        /// </summary>
        /// <exception cref="ArgumentNullException">array can not be null.</exception>
        /// <exception cref="ArgumentNullException">targetArray can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">The number of items to copy must be greater or equals to zero.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     The number of items to copy cannot be greater than the length of the
        ///     target array.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     The number of items to copy cannot be greater than the length of the
        ///     source array.
        /// </exception>
        /// <typeparam name="T">The type of the items in the array.</typeparam>
        /// <param name="array">The source array.</param>
        /// <param name="itemsToCpoy">The number of items to copy, starting at the given start index.</param>
        /// <param name="targetArray">The target array.</param>
        /// <returns>Returns the target array.</returns>
        [PublicAPI]
        [NotNull]
        public static T[] Slice<T>( [NotNull] this T[] array, Int32 itemsToCpoy, [NotNull] T[] targetArray )
            => array.Slice( 0, itemsToCpoy, targetArray );

        /// <summary>
        ///     Copies the specified range of items from the source array to the given target array.
        /// </summary>
        /// <exception cref="ArgumentNullException">array can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">The number of items to copy must be greater or equals to zero.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     The number of items to copy cannot be greater than the length of the
        ///     source array.
        /// </exception>
        /// <typeparam name="T">The type of the items in the array.</typeparam>
        /// <param name="array">The source array.</param>
        /// <param name="itemsToCpoy">The number of items to copy, starting at the given start index.</param>
        /// <returns>Returns the target array.</returns>
        [PublicAPI]
        [NotNull]
        public static T[] Slice<T>( [NotNull] this T[] array, Int32 itemsToCpoy )
        {
            var targetArray = new T[itemsToCpoy];
            return array.Slice( 0, itemsToCpoy, targetArray );
        }

        /// <summary>
        ///     Converts the given array to a list using the specified selector.
        /// </summary>
        /// <exception cref="ArgumentNullException">items can not be null.</exception>
        /// <exception cref="ArgumentNullException">selector can not be null.</exception>
        /// <param name="items">The array containing the items.</param>
        /// <param name="selector">The selector.</param>
        /// <typeparam name="TArray">The type of the items in the array.</typeparam>
        /// <typeparam name="TResult">The type of the items in the list.</typeparam>
        /// <returns>The items of the array as list.</returns>
        [PublicAPI]
        [NotNull]
        [Pure]
        public static List<TResult> ToGenericList<TArray, TResult>( [NotNull] this TArray[] items, [NotNull] Func<TArray, TResult> selector )
        {
            items.ThrowIfNull( nameof(items) );
            selector.ThrowIfNull( nameof(selector) );

            return items
                .Select( selector )
                .ToList();
        }
    }
}