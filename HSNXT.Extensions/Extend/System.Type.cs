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
    public static partial class Extensions
    {
        /// <summary>
        ///     Gets the attributes of the proprieties of the given type.
        /// </summary>
        /// <exception cref="ArgumentNullException">type can not be null.</exception>
        /// <typeparam name="TAttribute">The type of attributes to return.</typeparam>
        /// <param name="type">The type to get the attribute definitions from.</param>
        /// <returns>Returns the attribute definitions of the given type.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static IEnumerable<AttributeDefinitionProperty<TAttribute>> GetAttributeDefinitions<TAttribute>( [NotNull] this Type type )
            where TAttribute : Attribute
        {
            type.ThrowIfNull( nameof(type) );

            return type
                .GetPublicProperties()
                .Select( x => new AttributeDefinitionProperty<TAttribute>
                {
                    Property = x,
                    Attributes = x.GetCustomAttributes( typeof(TAttribute), true )
                                  .Cast<TAttribute>()
                } )
                .Where( x => x.Attributes.Any() );
        }
        /// <summary>
        ///     Gets the <see cref="Assembly" /> in which the type is declared. For generic types, gets the
        ///     <see cref="Assembly" /> in which the generic type is defined.
        /// </summary>
        /// <exception cref="ArgumentNullException">type can not be null.</exception>
        /// <param name="type">The type to get the declaring of.</param>
        /// <returns>Returns the assembly in which the type is declared.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static Assembly GetDeclaringAssembly( [NotNull] this Type type )
        {
            type.ThrowIfNull( nameof(type) );

            return type.GetTypeInfo()
                       .Assembly;
        }
        /// <summary>
        ///     Gets the first generic argument of the given type.
        /// </summary>
        /// <exception cref="ArgumentNullException">type can not be null.</exception>
        /// <param name="type">The type to get the generic argument from.</param>
        /// <returns>Returns the first generic argument of the given type, or null if the type does not have any generic arguments.</returns>
        [CanBeNull]
        [Pure]
        [PublicAPI]
        public static Type GetGenericTypeArgument( [NotNull] this Type type )
        {
            type.ThrowIfNull( nameof(type) );

            return type.GetGenericTypeArguments()
                       .FirstOrDefault();
        }
        /// <summary>
        ///     Returns an array of <see cref="Type" /> objects that represent the type arguments of a generic type or the type
        ///     parameters of a generic type definition.
        /// </summary>
        /// <exception cref="ArgumentNullException">type can not be null.</exception>
        /// <param name="type">Thy type to get the generic arguments of.</param>
        /// <returns>
        ///     Returns an array of <see cref="Type" /> objects that represent the type arguments of a generic type. Returns
        ///     an empty array if the current type is not a generic type.
        /// </returns>
        [Pure]
        [PublicAPI]
        public static Type[] GetGenericTypeArguments( [NotNull] this Type type )
        {
            type.ThrowIfNull( nameof(type) );

            return type.GetTypeInfo()
                       .GenericTypeArguments;
        }
        /// <summary>
        ///     Gets a collection of the interfaces implemented by the given type.
        /// </summary>
        /// <exception cref="ArgumentNullException">type can not be null.</exception>
        /// <param name="type">The type to get the interface of.</param>
        /// <returns>Returns the interfaces implemented by the given type.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static IEnumerable<Type> GetImplementedInterfaces( [NotNull] this Type type )
        {
            type.ThrowIfNull( nameof(type) );

            return type
                .GetTypeInfo()
                .ImplementedInterfaces;
        }
        /// <summary>
        ///     Gets the name including namespace and assembly of the given type.
        /// </summary>
        /// <exception cref="ArgumentNullException">type can not be null.</exception>
        /// <param name="type">The type to get the name of.</param>
        /// <returns>Returns the name of the given type.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static string GetNameWithNamespace( [NotNull] this Type type )
        {
            type.ThrowIfNull( nameof(type) );

            if ( !type.IsGenericType() )
                return type.GetNameWithNamespaceSimpleType();

            // Get the type of the generic class.
            var genericType = type.GetGenericTypeDefinition();

            // Get the name of the generic class, add generic types and assembly name
            var genercArguments = type.GetGenericTypeArguments();
            var genericArgumentNames = genercArguments.Select( x => $"[{x.GetNameWithNamespace()}]" )
                                                      .StringJoin( "," );
            var genericTypeFullName = $"{genericType.FullName}[{genericArgumentNames}]";

            return $"{genericTypeFullName}, {genericType.GetAssemblyName()}";
        }

        /// <summary>
        ///     Gets the name of the assembly of the given type.
        /// </summary>
        /// <exception cref="ArgumentNullException">type can not be null.</exception>
        /// <param name="type">The type to get the assembly name of.</param>
        /// <returns>Returns the assembly name without version and key.</returns>
        [NotNull]
        [Pure]
        private static string GetAssemblyName( [NotNull] this Type type )
        {
            type.ThrowIfNull( nameof(type) );

            return type
                .GetDeclaringAssembly()
                .FullName.Split( ',' )[0];
        }

        /// <summary>
        ///     Gets the name of a type without any generic arguments.
        /// </summary>
        /// <exception cref="ArgumentNullException">type can not be null.</exception>
        /// <param name="type">The type to get the name of.</param>
        /// <returns>Returns the name and namespace of a simple type.</returns>
        [NotNull]
        [Pure]
        private static string GetNameWithNamespaceSimpleType( [NotNull] this Type type )
            => $"{type.FullName}, {type.GetAssemblyName()}";
        /// <summary>
        ///     Gets the public properties of the given type.
        /// </summary>
        /// <exception cref="ArgumentNullException">type can not be null.</exception>
        /// <param name="type">The type to get the properties of.</param>
        /// <returns>Returns the public properties of the given type.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static IEnumerable<PropertyInfo> GetPublicProperties( [NotNull] this Type type )
        {
            type.ThrowIfNull( nameof(type) );

            return type.GetRuntimeProperties()
                       .Where( x => x.GetMethod.IsPublic );
        }
        /// <summary>
        ///     Gets the property info of each public settable property of the given type.
        /// </summary>
        /// <exception cref="ArgumentNullException">type can not be null.</exception>
        /// <param name="type">The type to get the properties of.</param>
        /// <returns>Returns the property infos.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static IEnumerable<PropertyInfo> GetPublicSettableProperties( [NotNull] this Type type )
        {
            type.ThrowIfNull( nameof(type) );

            var propertyInfos = type.GetRuntimeProperties()
                                    .Where( x => x.SetMethod?.IsPublic ?? false );

            return propertyInfos.Where( x => x.CanWrite );
        }
        /// <summary>
        ///     Gets the 'inner' type from a nullable type.
        /// </summary>
        /// <exception cref="ArgumentNullException">possibleNullableType can not be null.</exception>
        /// <param name="possibleNullableType">The possible nullable type.</param>
        /// <returns>Returns the inner type, or null if the given type is not a nullable.</returns>
        [Pure]
        [PublicAPI]
        public static Type GetTypeFromNullable( [NotNull] this Type possibleNullableType )
        {
            possibleNullableType.ThrowIfNull( nameof(possibleNullableType) );

            if ( !possibleNullableType.IsGenericType() || possibleNullableType.GetGenericTypeDefinition() != typeof(Nullable<>) )
                return null;

            return possibleNullableType.GetGenericTypeArgument();
        }
        /// <summary>
        ///     Checks if the given type implements <see cref="ICollection{T}" />
        /// </summary>
        /// <exception cref="ArgumentNullException">type can not be null.</exception>
        /// <param name="type">The type to check.</param>
        /// <returns>Returns a value of true if the given type implements <see cref="ICollection{T}" />; otherwise, false.</returns>
        [Pure]
        [PublicAPI]
        public static bool ImplementsICollectionT( [NotNull] this Type type )
        {
            type.ThrowIfNull( nameof(type) );

            var isGenericType = type.IsGenericType();
            var interfaces = type.GetImplementedInterfaces();

            return isGenericType && interfaces.Any( x => x.Name == "ICollection`1" );
        }
        /// <summary>
        ///     Checks if the given type is an enumeration.
        /// </summary>
        /// <exception cref="ArgumentNullException">type can not be null.</exception>
        /// <param name="type">The type to check.</param>
        /// <returns>Returns a value of true if the given type is an enumeration; otherwise, false.</returns>
        [Pure]
        [PublicAPI]
        public static bool IsEnum( [NotNull] this Type type )
        {
            type.ThrowIfNull( nameof(type) );

            return type.GetTypeInfo()
                       .IsEnum;
        }
    }
}




namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Checks if the given type implements <see cref="ICollection{T}" />
        /// </summary>
        /// <exception cref="ArgumentNullException">type can not be null.</exception>
        /// <param name="type">The type to check.</param>
        /// <returns>Returns a value of true if the given type implements <see cref="ICollection{T}" />; otherwise, false.</returns>
        [Pure]
        [PublicAPI]
        public static bool IsICollectionT( [NotNull] this Type type )
        {
            type.ThrowIfNull( nameof(type) );

            return type.IsGenericType() && type.GetGenericTypeDefinition() == typeof(ICollection<>);
        }
        /// <summary>
        ///     Checks if the given type implements <see cref="IEnumerable{T}" />
        /// </summary>
        /// <exception cref="ArgumentNullException">type can not be null.</exception>
        /// <param name="type">The type to check.</param>
        /// <returns>Returns a value of true if the given type implements <see cref="IEnumerable{T}" />; otherwise, false.</returns>
        [Pure]
        [PublicAPI]
        public static bool IsIEnumerableT( [NotNull] this Type type )
        {
            type.ThrowIfNull( nameof(type) );

            return type.IsGenericType() && type.GetGenericTypeDefinition() == typeof(IEnumerable<>);
        }
        /// <summary>
        ///     Checks if the given type implements <see cref="IList{T}" />
        /// </summary>
        /// <exception cref="ArgumentNullException">type can not be null.</exception>
        /// <param name="type">The type to check.</param>
        /// <returns>Returns a value of true if the given type implements <see cref="IList{T}" />; otherwise, false.</returns>
        [Pure]
        [PublicAPI]
        public static bool IsIListT( [NotNull] this Type type )
        {
            type.ThrowIfNull( nameof(type) );

            return type.IsGenericType() && type.GetGenericTypeDefinition() == typeof(IList<>);
        }
        /// <summary>
        ///     Checks if th given type is a Microsoft type, based on the company attribute of it's declaring assembly.
        /// </summary>
        /// <exception cref="ArgumentNullException">type can not be null.</exception>
        /// <param name="type">The type to check.</param>
        /// <returns>Returns a value of true if the given type is a Microsoft type; otherwise, false.</returns>
        [Pure]
        [PublicAPI]
        public static bool IsMicrosoftType( [NotNull] this Type type )
        {
            type.ThrowIfNull( nameof(type) );

            var attributes = type
                .GetDeclaringAssembly()
                .GetAttributes<AssemblyCompanyAttribute>();
            return attributes.Any( x => x.Company == "Microsoft Corporation" );
        }
    }
}