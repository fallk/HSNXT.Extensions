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
    /// <summary>
    ///     Interface representing an item with an index.
    /// </summary>
    /// <typeparam name="T">The type of the item</typeparam>
    public interface IIndexedItem<T>
    {
        #region Properties

        /// <summary>
        ///     Gets the index of the item.
        /// </summary>
        /// <value>The index of the item.</value>
        int Index { get; }

        /// <summary>
        ///     Gets the item.
        /// </summary>
        /// <value>The item.</value>
        T Item { get; }

        #endregion
    }
}