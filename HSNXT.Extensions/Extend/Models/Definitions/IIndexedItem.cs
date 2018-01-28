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