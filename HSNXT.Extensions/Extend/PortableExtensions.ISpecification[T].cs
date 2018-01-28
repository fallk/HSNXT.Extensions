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
        ///     Combines the current specification with the given expression using an AND link.
        /// </summary>
        /// <exception cref="ArgumentNullException">specification can not be null.</exception>
        /// <exception cref="ArgumentNullException">expression can not be null.</exception>
        /// <typeparam name="T">The target type of the specification.</typeparam>
        /// <param name="specification">The current specification.</param>
        /// <param name="expression">The expression to add.</param>
        /// <param name="message">The validation error message.</param>
        /// <returns>Returns the combined specifications.</returns>
        [NotNull]
        [PublicAPI]
        public static ISpecification<T> And<T>( [NotNull] this ISpecification<T> specification,
                                                [NotNull] Func<T, bool> expression,
                                                [CanBeNull] string message = null )
        {
            specification.ThrowIfNull( nameof(specification) );
            expression.ThrowIfNull( nameof(expression) );

            var newSpecification = new ExpressionSpecification<T>( expression, message );
            return specification.And( newSpecification );
        }
        /// <summary>
        ///     Combines the current specification with the given expression using a OR link.
        /// </summary>
        /// <exception cref="ArgumentNullException">specification can not be null.</exception>
        /// <exception cref="ArgumentNullException">expression can not be null.</exception>
        /// <typeparam name="T">The target type of the specification.</typeparam>
        /// <param name="specification">The current specification.</param>
        /// <param name="expression">The expression to add.</param>
        /// <param name="message">The validation error message.</param>
        /// <returns>Returns the combined specifications.</returns>
        [NotNull]
        [PublicAPI]
        public static ISpecification<T> Or<T>( [NotNull] this ISpecification<T> specification,
                                               [NotNull] Func<T, bool> expression,
                                               [CanBeNull] string message = null )
        {
            specification.ThrowIfNull( nameof(specification) );
            expression.ThrowIfNull( nameof(expression) );

            var newSpecification = new ExpressionSpecification<T>( expression, message );
            return specification.Or( newSpecification );
        }
        /// <summary>
        ///     Combines the current specification with the given expression using a XOr link.
        /// </summary>
        /// <exception cref="ArgumentNullException">specification can not be null.</exception>
        /// <exception cref="ArgumentNullException">expression can not be null.</exception>
        /// <typeparam name="T">The target type of the specification.</typeparam>
        /// <param name="specification">The current specification.</param>
        /// <param name="expression">The expression to add.</param>
        /// <param name="message">The validation error message.</param>
        /// <returns>Returns the combined specifications.</returns>
        [NotNull]
        [PublicAPI]
        public static ISpecification<T> XOr<T>( [NotNull] this ISpecification<T> specification,
                                                [NotNull] Func<T, bool> expression,
                                                [CanBeNull] string message = null )
        {
            specification.ThrowIfNull( nameof(specification) );
            expression.ThrowIfNull( nameof(expression) );

            var newSpecification = new ExpressionSpecification<T>( expression, message );
            return specification.XOr( newSpecification );
        }
    }
}