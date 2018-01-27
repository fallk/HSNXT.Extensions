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
    public static partial class Extensions
    {
        /// <summary>
        ///     Returns the property value of a specified object.
        /// </summary>
        /// <exception cref="ArgumentNullException">propertyInfo can not be null.</exception>
        /// <exception cref="TargetInvocationException">
        ///     The object does not match the target type, or a property is an instance
        ///     property but obj is null.
        /// </exception>
        /// <param name="propertyInfo">The property information.</param>
        /// <param name="source">The object whose property value will be returned.</param>
        /// <returns>The property value of the specified object.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static object GetValueWithoutIndex( [NotNull] this PropertyInfo propertyInfo, [NotNull] object source )
        {
            propertyInfo.ThrowIfNull( nameof(propertyInfo) );
            source.ThrowIfNull( nameof(source) );

            return propertyInfo.GetValue( source );
        }
        /// <summary>
        ///     Creates a <see cref="IMemberInformation" /> based on the given <see cref="PropertyInfo" /> and parent information.
        /// </summary>
        /// <exception cref="ArgumentNullException">propertyInfo can not be null.</exception>
        /// <param name="propertyInfo">The property information.</param>
        /// <param name="parentMemberInformation">The parent of the given property.</param>
        /// <returns>Returns the new created member information.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static IMemberInformation ToMemberInformation( [NotNull] this PropertyInfo propertyInfo, [CanBeNull] IMemberInformation parentMemberInformation )
        {
            propertyInfo.ThrowIfNull( nameof(propertyInfo) );

            var path = parentMemberInformation?.MemberPath ?? parentMemberInformation?.MemberName;

            return new MemberInformation
            {
                MemberType = propertyInfo.PropertyType,
                MemberPath = path.IsNotEmpty() ? $"{path}.{propertyInfo.Name}" : propertyInfo.Name,
                MemberName = propertyInfo.Name,
                PropertyInfo = propertyInfo
            };
        }
    }
}