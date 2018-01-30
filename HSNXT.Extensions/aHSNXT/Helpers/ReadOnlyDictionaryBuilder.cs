using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HSNXT
{
    /// <inheritdoc />
    /// <summary>
    /// Helper class for creating ReadOnlyDictionary objects. Just use it like a normal dictionary, then cast it to a
    /// ReadOnlyDictionary when needed.
    /// </summary>
    public class ReadOnlyDictionaryBuilder<TKey, TVal> : Dictionary<TKey, TVal>
    {
        public static implicit operator ReadOnlyDictionary<TKey, TVal>(ReadOnlyDictionaryBuilder<TKey, TVal> self) =>
            new ReadOnlyDictionary<TKey, TVal>(self);
    }
}