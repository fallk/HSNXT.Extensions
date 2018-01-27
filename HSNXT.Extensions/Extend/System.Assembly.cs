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
        ///     Gets the types defined in the given assembly.
        /// </summary>
        /// <exception cref="ArgumentNullException">assembly can not be null.</exception>
        /// <param name="assembly">The assembly to get the types of.</param>
        /// <returns>Returns the types defined in the given assembly.</returns>
        [Pure]
        [PublicAPI]
        public static IEnumerable<Type> GetDefinedTypes( [NotNull] this Assembly assembly )
        {
            assembly.ThrowIfNull( nameof(assembly) );

            return assembly
                .DefinedTypes
                .Select( x => x.AsType() )
                .ToArray();
        }
        /// <summary>
        ///     Gets all types of the given assemblies which is decorated with an attribute of the specified type.
        /// </summary>
        /// <exception cref="ArgumentNullException">assemblies can not be null.</exception>
        /// <typeparam name="T">The type of the attribute.</typeparam>
        /// <param name="assemblies">The assemblies to search in.</param>
        /// <returns>Returns the found types and their attributes.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static IEnumerable<IAttributeDefinitionType<T>> GetTypesWithAttribute<T>( [NotNull] params Assembly[] assemblies ) where T : Attribute
            => GetTypesWithAttribute<T>( false, null, assemblies );

        /// <summary>
        ///     Gets all types of the given assemblies which is decorated with an attribute of the specified type.
        /// </summary>
        /// <exception cref="ArgumentNullException">assemblies can not be null.</exception>
        /// <typeparam name="T">The type of the attribute.</typeparam>
        /// <param name="inherit">
        ///     true to search this member's inheritance chain to find the attributes; otherwise, false. This
        ///     parameter is ignored for properties and events; see Remarks.
        /// </param>
        /// <param name="assemblies">The assemblies to search in.</param>
        /// <returns>Returns the found types and their attributes.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static IEnumerable<IAttributeDefinitionType<T>> GetTypesWithAttribute<T>( bool inherit, [NotNull] params Assembly[] assemblies ) where T : Attribute
            => GetTypesWithAttribute<T>( inherit, null, assemblies );

        /// <summary>
        ///     Gets all types of the given assemblies which is decorated with an attribute of the specified type and are sub
        ///     classes of the specified base type.
        /// </summary>
        /// <exception cref="ArgumentNullException">assemblies can not be null.</exception>
        /// <typeparam name="T">The type of the attribute.</typeparam>
        /// <param name="inherit">
        ///     true to search this member's inheritance chain to find the attributes; otherwise, false. This
        ///     parameter is ignored for properties and events; see Remarks.
        /// </param>
        /// <param name="baseType">The base type to search for, or null.</param>
        /// <param name="assemblies">The assemblies to search in.</param>
        /// <returns>Returns the found types and their attributes.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static IEnumerable<IAttributeDefinitionType<T>> GetTypesWithAttribute<T>( bool inherit, Type baseType, [NotNull] params Assembly[] assemblies )
            where T : Attribute
        {
            assemblies.ThrowIfNull( nameof(assemblies) );

            var attributeType = typeof(T);
            var result = new List<AttributeDefinitionType<T>>();

            assemblies
                .ForEach( x => x.DefinedTypes
                                .Where( y => baseType == null || y.IsSubclassOf( baseType ) )
                                .ForEach( y =>
                                {
                                    var attributes = y.GetCustomAttributes( attributeType, inherit )
                                                      .ToArray();
                                    if ( attributes.NotAny() )
                                        return;

                                    result.Add( new AttributeDefinitionType<T>
                                    {
                                        Type = y.AsType(),
                                        Attributes = attributes
                                            .Cast<T>()
                                            .ToList()
                                    } );
                                } ) );

            return result;
        }
    }
}