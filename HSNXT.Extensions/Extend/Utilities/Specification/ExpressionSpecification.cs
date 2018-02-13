using System;
using System.Collections.Generic;
using HSNXT.JetBrains.Annotations;


namespace HSNXT
{
    /// <summary>
    ///     Class representing an expression specification.
    /// </summary>
    /// <typeparam name="T">The target type of the specification.</typeparam>
    public class ExpressionSpecification<T> : Specification<T>
    {
        #region Fields

        /// <summary>
        ///     The predicate used to validate the given objects.
        /// </summary>
        private readonly Func<T, bool> _expression;

        /// <summary>
        ///     The error message.
        /// </summary>
        private readonly string _message;

        #endregion

        #region Ctor

        /// <summary>
        ///     Initialize a new instance of the <see cref="ExpressionSpecification{T}" /> class.
        /// </summary>
        /// <exception cref="ArgumentNullException">expression can not be null.</exception>
        /// <param name="expression">The validation expression.</param>
        /// <param name="message">The validation error message.</param>
        public ExpressionSpecification([NotNull] Func<T, bool> expression, [CanBeNull] string message = null)
        {
            expression.ThrowIfNull(nameof(expression));

            _expression = expression;
            _message = message;
        }

        #endregion

        #region Overrides of Specification<T>

        /// <summary>
        ///     Checks if the given objects satisfies the specification.
        /// </summary>
        /// <param name="obj">The object to validate.</param>
        /// <returns>Returns true if the object satisfies the specification; otherwise, false.</returns>
        [PublicAPI]
        public override bool IsSatisfiedBy(T obj)
            => _expression(obj);

        /// <summary>
        ///     Checks if the given objects satisfies the specification.
        /// </summary>
        /// <param name="obj">The object to validate.</param>
        /// <returns>Returns a collection of error messages.</returns>
        [PublicAPI]
        public override IEnumerable<string> IsSatisfiedByWithMessages(T obj)
        {
            var result = _expression(obj);
            if (result)
                return new string[0];

            return new List<string> {_message};
        }

        #endregion
    }
}