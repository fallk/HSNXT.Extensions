using System.Collections;
using erichexter.Should.Fluent.Model;

namespace erichexter.Should.Fluent
{
    public static class BeCollectionExtensions
    {
        public static ICollection Empty(this IBe<ICollection> be)
        {
            return be.Should.Apply(
                (t, a) => a.AreEqual(0, t.Count),
                (t, a) => a.AreNotEqual(0, t.Count));
        }

        public static ICollection Null(this IBe<ICollection> be)
        {
            return Check.IsNull(be.Should);
        }
    }
}