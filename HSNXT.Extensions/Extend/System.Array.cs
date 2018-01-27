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
#region Usings
//using System;
//using System.Collections.Generic;
//using System.Reflection;
//using JetBrains.Annotations;
//using System.Linq;
//using System.IO;
//using System.Diagnostics;
//using System.Threading.Tasks;
//using System.Collections.ObjectModel;
//using System.Text;
//using System.Globalization;
//using System.Collections;
//using System.Linq.Expressions;
//using System.Text.RegularExpressions;
//using System.Collections.Concurrent;
//using HSNXT.Internal;

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="Array" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Sets a range of elements in the array to zero, to false, or to null, depending on the element type.
        /// </summary>
        /// <exception cref="ArgumentNullException">array can not be null.</exception>
        /// <param name="array">The array whose elements need to be cleared.</param>
        /// <param name="index">The starting index of the range of elements to clear.</param>
        /// <param name="length">The number of elements to clear.</param>
        [PublicAPI]
        public static void Clear( [NotNull] this Array array, Int32 index, Int32 length )
        {
            array.ThrowIfNull( nameof(array) );

            Array.Clear( array, index, length );
        }
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="Array" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Clears the given array.
        /// </summary>
        /// <exception cref="ArgumentNullException">The array can not be null.</exception>
        /// <param name="array">The array to clear.</param>
        [PublicAPI]
        public static void ClearAll( [NotNull] this Array array )
        {
            array.ThrowIfNull( nameof(array) );

            Array.Clear( array, 0, array.Length );
        }
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="Array" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Copies a range of elements from an array starting at the first element and pastes them into another array starting
        ///     at the first element. The length is specified as a 32-bit integer.
        /// </summary>
        /// <exception cref="ArgumentNullException">source array can not be null.</exception>
        /// <exception cref="ArgumentNullException">destination array can not be null.</exception>
        /// <param name="sourceArray">The array that contains the data to copy.</param>
        /// <param name="destinationArray">The array that receives the data.</param>
        /// <param name="length">A 32-bit integer that represents the number of elements to copy.</param>
        [PublicAPI]
        public static void Copy( [NotNull] this Array sourceArray, [NotNull] Array destinationArray, Int32 length )
        {
            sourceArray.ThrowIfNull( nameof(sourceArray) );
            destinationArray.ThrowIfNull( nameof(destinationArray) );

            Array.Copy( sourceArray, destinationArray, length );
        }

        /// <summary>
        ///     Copies a range of elements from an array starting at the specified source index and pastes them to another array
        ///     starting at the specified destination index. The length and the indexes are specified as 32-bit integers.
        /// </summary>
        /// <exception cref="ArgumentNullException">Source array can not be null.</exception>
        /// <exception cref="ArgumentNullException">destination array can not be null.</exception>
        /// <param name="sourceArray">The array that contains the data to copy.</param>
        /// <param name="sourceIndex">A 32-bit integer that represents the index in the  at which copying begins.</param>
        /// <param name="destinationArray">The array that receives the data.</param>
        /// <param name="destinationIndex">A 32-bit integer that represents the index in the  at which storing begins.</param>
        /// <param name="length">A 32-bit integer that represents the number of elements to copy.</param>
        [PublicAPI]
        public static void Copy( [NotNull] this Array sourceArray,
                                 Int32 sourceIndex,
                                 [NotNull] Array destinationArray,
                                 Int32 destinationIndex,
                                 Int32 length )
        {
            sourceArray.ThrowIfNull( nameof(sourceArray) );
            destinationArray.ThrowIfNull( nameof(destinationArray) );

            Array.Copy( sourceArray, sourceIndex, destinationArray, destinationIndex, length );
        }
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="Array" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Searches for the specified object and returns the index of its first occurrence in a one-dimensional array.
        /// </summary>
        /// <exception cref="ArgumentNullException">Array can not be null.</exception>
        /// <param name="array">The one-dimensional  to search.</param>
        /// <param name="value">The object to locate in <paramref name="array" />.</param>
        /// <returns>
        ///     The index of the first occurrence of value in array, if found; otherwise, the lower bound of the array minus 1.
        /// </returns>
        [PublicAPI]
        [Pure]
        public static Int32 IndexOf( [NotNull] this Array array, [CanBeNull] Object value )
        {
            array.ThrowIfNull( nameof(array) );

            return Array.IndexOf( array, value );
        }

        /// <summary>
        ///     Searches for the specified object in a range of elements of a one-dimensional array, and returns the index of its
        ///     first occurrence. The range extends from a specified index to the end of the array.
        /// </summary>
        /// <exception cref="ArgumentNullException">Array can not be null.</exception>
        /// <param name="array">The one-dimensional  to search.</param>
        /// <param name="value">The object to locate in <paramref name="array" />.</param>
        /// <param name="startIndex">The starting index of the search. 0 (zero) is valid in an empty array.</param>
        /// <returns>
        ///     The index of the first occurrence of value, if it’s found, within the range of elements in array that extends from
        ///     startIndex to the last element; otherwise, the lower bound of the array minus 1.
        /// </returns>
        [PublicAPI]
        [Pure]
        public static Int32 IndexOf( [NotNull] this Array array, [CanBeNull] Object value, Int32 startIndex )
        {
            array.ThrowIfNull( nameof(array) );

            return Array.IndexOf( array, value, startIndex );
        }

        /// <summary>
        ///     Searches for the specified object in a range of elements of a one-dimensional array, and returns the index of ifs
        ///     first occurrence. The range extends from a specified index for a specified number of elements.
        /// </summary>
        /// <exception cref="ArgumentNullException">Array can not be null.</exception>
        /// <param name="array">The one-dimensional  to search.</param>
        /// <param name="value">The object to locate in <paramref name="array" />.</param>
        /// <param name="startIndex">The starting index of the search. 0 (zero) is valid in an empty array.</param>
        /// <param name="count">The number of elements to search.</param>
        /// <returns>
        ///     The index of the first occurrence of value, if it’s found, in the array from index startIndex to startIndex + count
        ///     - 1; otherwise, the lower bound of the array minus 1.
        /// </returns>
        [PublicAPI]
        [Pure]
        public static Int32 IndexOf( [NotNull] this Array array, [CanBeNull] Object value, Int32 startIndex, Int32 count )
        {
            array.ThrowIfNull( nameof(array) );

            return Array.IndexOf( array, value, startIndex, count );
        }
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="Array" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Searches for the specified object and returns the index of the last occurrence within the entire one-dimensional
        ///     Array.
        /// </summary>
        /// <exception cref="ArgumentNullException">Array can not be null.</exception>
        /// <param name="array">The one-dimensional  to search.</param>
        /// <param name="value">The object to locate in .</param>
        /// <returns>
        ///     The index of the last occurrence of  within the entire , if found; otherwise, the lower bound of the array
        ///     minus 1.
        /// </returns>
        [PublicAPI]
        [Pure]
        public static Int32 LastIndexOf( [NotNull] this Array array, [CanBeNull] Object value )
        {
            array.ThrowIfNull( nameof(array) );

            return Array.LastIndexOf( array, value );
        }

        /// <summary>
        ///     Searches for the specified object and returns the index of the last occurrence within the range of elements in the
        ///     one-dimensional Array that extends from the first element to the specified index.
        /// </summary>
        /// <exception cref="ArgumentNullException">Array can not be null.</exception>
        /// <param name="array">The one-dimensional  to search.</param>
        /// <param name="value">The object to locate in .</param>
        /// <param name="startIndex">The starting index of the backward search.</param>
        /// <returns>
        ///     The index of the last occurrence of  within the range of elements in  that extends from the first element to ,
        ///     if found; otherwise, the lower bound of the array minus 1.
        /// </returns>
        [PublicAPI]
        [Pure]
        public static Int32 LastIndexOf( [NotNull] this Array array, [CanBeNull] Object value, Int32 startIndex )
        {
            array.ThrowIfNull( nameof(array) );

            return Array.LastIndexOf( array, value, startIndex );
        }

        /// <summary>
        ///     Searches for the specified object and returns the index of the last occurrence within the range of elements in the
        ///     one-dimensional
        ///     Array that contains the specified number of elements and ends at the specified index.
        /// </summary>
        /// <exception cref="ArgumentNullException">Array can not be null.</exception>
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
        public static Int32 LastIndexOf( [NotNull] this Array array, [CanBeNull] Object value, Int32 startIndex, Int32 count )
        {
            array.ThrowIfNull( nameof(array) );

            return Array.LastIndexOf( array, value, startIndex, count );
        }
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="Array" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Reverses the sequence of the elements in the entire one-dimensional array.
        /// </summary>
        /// <exception cref="ArgumentNullException">array can not be null.</exception>
        /// <param name="array">The one-dimensional array to reverse.</param>
        [PublicAPI]
        public static void Reverse( [NotNull] this Array array )
        {
            array.ThrowIfNull( nameof(array) );

            Array.Reverse( array );
        }

        /// <summary>
        ///     Reverses the sequence of the elements in a range of elements in the one-dimensional array.
        /// </summary>
        /// <exception cref="ArgumentNullException">array can not be null.</exception>
        /// <param name="array">The one-dimensional array to reverse.</param>
        /// <param name="index">The starting index of the section to reverse.</param>
        /// <param name="length">The number of elements in the section to reverse.</param>
        [PublicAPI]
        public static void Reverse( [NotNull] this Array array, Int32 index, Int32 length )
        {
            array.ThrowIfNull( nameof(array) );

            Array.Reverse( array, index, length );
        }
    }
}
#region Usings

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="Array" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Converts the given array to a list using the specified selector.
        /// </summary>
        /// <exception cref="ArgumentNullException">items can not be null.</exception>
        /// <exception cref="ArgumentNullException">selector can not be null.</exception>
        /// <param name="items">The array containing the items.</param>
        /// <param name="selector">The selector.</param>
        /// <typeparam name="T">The type of the items in the list.</typeparam>
        /// <returns>The items of the array as list.</returns>
        [PublicAPI]
        [Pure]
        public static List<T> ToList<T>( [NotNull] this Array items, [NotNull] Func<Object, T> selector )
        {
            items.ThrowIfNull( nameof(items) );
            selector.ThrowIfNull( nameof(selector) );

            return ( from Object item in items
                     select selector( item ) ).ToList();
        }
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="Array" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Checks if the given index is within the array or not.
        /// </summary>
        /// <exception cref="ArgumentNullException">array can not be null.</exception>
        /// <param name="array">The array to check.</param>
        /// <param name="index">a Zero-based index.</param>
        /// <returns>Returns a value of true if the index is within the array, otherwise false.</returns>
        [PublicAPI]
        [Pure]
        public static Boolean WithinIndex( [NotNull] this Array array, Int32 index )
        {
            array.ThrowIfNull( nameof(array) );

            return index >= 0 && index < array.Length;
        }
    }
}