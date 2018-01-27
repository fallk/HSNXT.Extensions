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
    ///     Class representing an item with an index.
    /// </summary>
    /// <typeparam name="T">The type of the item.</typeparam>
    public class IndexedItem<T> : IIndexedItem<T>
    {
        #region Ctor

        /// <summary>
        ///     Initializes a new instance of the <see cref="IndexedItem{T}" /> class.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="item">The item.</param>
        public IndexedItem( Int32 index, T item )
        {
            Index = index;
            Item = item;
        }

        #endregion

        #region Implementation of IIndexedItem<T>

        /// <summary>
        ///     Gets the index of the item.
        /// </summary>
        /// <value>The index of the item.</value>
        public Int32 Index { get; }

        /// <summary>
        ///     Gets the item.
        /// </summary>
        /// <value>The item.</value>
        public T Item { get; }

        #endregion
    }
}