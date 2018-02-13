using System;

namespace HSNXT
{
    public static partial class Extensions
    {
        public static bool IsDefaultValue(this object o)
        {
            if (!(o is ValueType)) return o == null;

            var @default = Activator.CreateInstance(o.GetType());
            return o.Equals(@default);
        }
    }
}