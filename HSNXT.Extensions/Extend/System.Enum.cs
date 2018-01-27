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
//using System.Collections.Generic;
//using System.Linq;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="Enum" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Gets all SET flags of the given enumeration value.
        /// </summary>
        /// <typeparam name="T">The type of the enumeration.</typeparam>
        /// <param name="enumValue">The enumeration value.</param>
        /// <returns>Returns all SET flags of the given value.</returns>
        [PublicAPI]
        [NotNull]
        [Pure]
        public static IEnumerable<T> GetFlags<T>( this Enum enumValue ) where T : struct, IConvertible
            => Enum.GetValues( enumValue.GetType() )
                   .Cast<Enum>()
                   .Where( enumValue.HasFlag )
                   .Cast<T>();
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
    ///     Class containing some extension methods for <see cref="Enum" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Gets the values of the specified enumeration as strings.
        /// </summary>
        /// <exception cref="ArgumentException">T must be an enumerated type.</exception>
        /// <typeparam name="T">The type of the enumeration.</typeparam>
        /// <returns>All values of the specified enumeration as strings.</returns>
        [Pure]
        [PublicAPI]
        [NotNull]
        public static IEnumerable<String> GetStringValues<T>() where T : struct => GetValues<T>()
            .Select( x => x.ToString() );
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
    ///     Class containing some extension methods for <see cref="Enum" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Gets a dictionary containing the string value for each value of the enumeration of the given type.
        /// </summary>
        /// <exception cref="ArgumentException">T must be an enumerated type.</exception>
        /// <typeparam name="T">The type of the enumeration.</typeparam>
        /// <returns>Returns a key value pair for each value of the specified enumeration type.</returns>
        [Pure]
        [PublicAPI]
        [NotNull]
        public static IDictionary<T, String> GetValueAndStringValue<T>() where T : struct
        {
            var values = GetValues<T>();
            return values.ToDictionary( x => x, x => x.ToString() );
        }
    }
}
#region Usings

//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="Enum" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Gets the values of the specified enumeration.
        /// </summary>
        /// <exception cref="ArgumentException">T must be an enumerated type.</exception>
        /// <typeparam name="T">The type of the enumeration.</typeparam>
        /// <returns>All values of the specified enumeration.</returns>
        [Pure]
        [PublicAPI]
        [NotNull]
        public static IEnumerable<T> GetValues<T>() where T : struct
        {
            var type = typeof(T);
            if ( !type.IsEnum() )
                throw new ArgumentException( "T must be an enumerated type." );

            return Enum.GetValues( type )
                       .OfType<T>();
        }

        /// <summary>
        ///     Gets the values of the specified enumeration.
        /// </summary>
        /// <exception cref="ArgumentNullException">type can not be null.</exception>
        /// <remarks>
        ///     How to cast returned values:
        ///     values.Cast{Object}();
        ///     values.Select( x => Convert.ChangeType( x, type ) );
        /// </remarks>
        /// <exception cref="ArgumentException">T must be an enumerated type.</exception>
        /// <param name="type">The type of the enumeration.</param>
        /// <returns>All values of the specified enumeration.</returns>
        [Pure]
        [PublicAPI]
        [NotNull]
        public static IEnumerable GetValues( [NotNull] Type type )
        {
            type.ThrowIfNull( nameof(type) );
            if ( !type.IsEnum() )
                throw new ArgumentException( "T must be an enumerated type." );

            return Enum.GetValues( type );
        }
    }
}
#region Usings

//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="Enum" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Gets all values of the specified enumeration type, expect the specified values.
        /// </summary>
        /// <exception cref="ArgumentException">T must be an enumerated type.</exception>
        /// <typeparam name="T">The type of the enumeration.</typeparam>
        /// <param name="exceptions">The values to exclude from the result.</param>
        /// <returns>Returns all values of the specified enumeration type, expect the specified values.</returns>
        [Pure]
        [PublicAPI]
        [NotNull]
        public static IEnumerable<T> GetValuesExpect<T>( [CanBeNull] params T[] exceptions ) where T : struct
        {
            var values = GetValues<T>();

            return exceptions == null
                ? values
                : values
                    .ToList()
                    .RemoveRange( exceptions );
        }

        /// <summary>
        ///     Gets all values of the specified enumeration type, expect the specified values.
        /// </summary>
        /// <remarks>
        ///     How to cast returned values:
        ///     values.Cast{Object}();
        ///     values.Select( x => Convert.ChangeType( x, type ) );
        /// </remarks>
        /// <exception cref="ArgumentException">T must be an enumerated type.</exception>
        /// <param name="type">The type of the enumeration.</param>
        /// <param name="exceptions">The values to exclude from the result.</param>
        /// <returns>Returns all values of the specified enumeration type, expect the specified values.</returns>
        [Pure]
        [PublicAPI]
        [NotNull]
        public static IEnumerable GetValuesExpect( [NotNull] Type type, [CanBeNull] params Object[] exceptions )
        {
            var values = GetValues( type )
                .OfType<Object>()
                .ToList();

            return exceptions == null ? values : values.RemoveRange( exceptions );
        }
    }
}