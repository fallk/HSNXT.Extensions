#region Usings
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

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="object" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Cast the given object to the specified type.
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        /// <param name="obj">The object to cast.</param>
        /// <returns>The object as the specified type.</returns>
        [CanBeNull]
        [Pure]
        [PublicAPI]
        public static T As<T>( [CanBeNull] this Object obj )
            => (T) obj;
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="object" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Gets whether the given <see cref="Object" /> is NOT null or not.
        /// </summary>
        /// <param name="obj">The <see cref="Object" /> to check.</param>
        /// <returns>A value of true if the <see cref="Object" /> is NOT null, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean IsNotNull( [CanBeNull] this Object obj )
            => obj != null;
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="object" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Gets whether the given <see cref="Object" /> is null or not.
        /// </summary>
        /// <param name="obj">The <see cref="Object" /> to check.</param>
        /// <returns>A value of true if the <see cref="Object" /> is null, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean IsNull( [CanBeNull] this Object obj )
            => obj == null;
    }
}
#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="object" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Determines whether the specified objects instances are the same instance.
        /// </summary>
        /// <exception cref="ArgumentNullException">The first object can not be null.</exception>
        /// <exception cref="ArgumentNullException">The second object can not be null.</exception>
        /// <param name="obj0">The first object to compare.</param>
        /// <param name="obj1">The second object  to compare.</param>
        /// <returns>Returns true if the objects are the same instance.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean RefEquals( [NotNull] this Object obj0, [NotNull] Object obj1 )
        {
            obj0.ThrowIfNull( nameof(obj0) );
            obj1.ThrowIfNull( nameof(obj1) );

            return ReferenceEquals( obj0, obj1 );
        }
    }
}