using System;
using System.Collections.Generic;
using HSNXT.JetBrains.Annotations;
using System.Linq;


namespace HSNXT
{
    /// <summary>
    ///     OR specification.
    /// </summary>
    /// <typeparam name="T">The target type of the specification.</typeparam>
    public class OrSpecification<T> : OperatorSpecification<T>
    {
        #region Ctor

        /// <summary>
        ///     Initialize a new instance of the <see cref="OrSpecification{T}" /> class.
        /// </summary>
        /// <exception cref="ArgumentNullException">left can not be null.</exception>
        /// <exception cref="ArgumentNullException">right can not be null.</exception>
        /// <param name="left">The left specification.</param>
        /// <param name="right">The right specification.</param>
        public OrSpecification([NotNull] ISpecification<T> left, [NotNull] ISpecification<T> right)
            : base(left, right)
        {
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
            => Left.IsSatisfiedBy(obj) || Right.IsSatisfiedBy(obj);

        /// <summary>
        ///     Checks if the given objects satisfies the specification.
        /// </summary>
        /// <param name="obj">The object to validate.</param>
        /// <returns>Returns a collection of error messages.</returns>
        [PublicAPI]
        public override IEnumerable<string> IsSatisfiedByWithMessages(T obj)
        {
            var leftResult = Left.IsSatisfiedByWithMessages(obj)
                .ToList();
            var rightResult = Right.IsSatisfiedByWithMessages(obj)
                .ToList();

            if (leftResult.NotAny() || rightResult.NotAny())
                return new string[0];

            return leftResult.Concat(rightResult);
        }

        #endregion
    }
}