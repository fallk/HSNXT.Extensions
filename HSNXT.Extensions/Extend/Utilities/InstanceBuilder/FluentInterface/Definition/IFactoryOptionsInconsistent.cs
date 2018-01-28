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
    /// <summary>
    ///     Interface representing a not configured factory.
    /// </summary>
    /// <remarks>
    ///     Some selection rules must be defined before the factory is valid.
    /// </remarks>
    /// <typeparam name="T">The type of the object to create.</typeparam>
    public interface IFactoryOptionsInconsistent<T> where T : class
    {
        /// <summary>
        ///     Factory will be used to create values for members matching the specified options.
        /// </summary>
        /// <param name="configurationFunc">Function used to configure the factory.</param>
        /// <returns>Returns the modified create instance options.</returns>
        [PublicAPI]
        [NotNull]
        IFactoryOptionsConstistent<T> For( [NotNull] Func<IIncludeExcludeOptions<T>, IIncludeExcludeOptions<T>> configurationFunc );

        /// <summary>
        ///     Factory will be used to create values for members matching the given predicate.
        /// </summary>
        /// <param name="predicate">The predicate used to find the members which should get created by the factory.</param>
        /// <returns>Returns the modified create instance options.</returns>
        [PublicAPI]
        [NotNull]
        IFactoryOptionsConstistent<T> For( [NotNull] Func<IMemberInformation, bool> predicate );

        /// <summary>
        ///     Factory will NOT be used to create values for members matching the specified options.
        /// </summary>
        /// <param name="configurationFunc">Function used to configure the factory.</param>
        /// <returns>Returns the modified create instance options.</returns>
        [PublicAPI]
        [NotNull]
        IFactoryOptionsConstistent<T> NotFor( [NotNull] Func<IIncludeExcludeOptions<T>, IIncludeExcludeOptions<T>> configurationFunc );

        /// <summary>
        ///     Factory will NOT be used to create values for members matching the given predicate.
        /// </summary>
        /// <param name="predicate">The predicate used to find the members which should NOT get created by the factory.</param>
        /// <returns>Returns the modified create instance options.</returns>
        [PublicAPI]
        [NotNull]
        IFactoryOptionsConstistent<T> NotFor( [NotNull] Func<IMemberInformation, bool> predicate );
    }
}