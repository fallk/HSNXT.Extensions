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
        public IndexedItem(int index, T item)
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
        public int Index { get; }

        /// <summary>
        ///     Gets the item.
        /// </summary>
        /// <value>The item.</value>
        public T Item { get; }

        #endregion
    }
}