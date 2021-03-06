using System.Collections.Generic;
using HSNXT.JetBrains.Annotations;


namespace HSNXT
{
    /// <summary>
    ///     Interface representing a specification.
    /// </summary>
    /// <typeparam name="T">The target type of the specification.</typeparam>
    public interface ISpecification<T>
    {
        /// <summary>
        ///     Combines the current specification with the given specification using an AND link.
        /// </summary>
        /// <param name="specification">The specification to add.</param>
        /// <returns>Returns the combined specifications.</returns>
        [NotNull]
        [PublicAPI]
        ISpecification<T> And([NotNull] ISpecification<T> specification);

        /// <summary>
        ///     Checks if the given objects satisfies the specification.
        /// </summary>
        /// <param name="obj">The object to validate.</param>
        /// <returns>Returns true if the object satisfies the specification; otherwise, false.</returns>
        [PublicAPI]
        bool IsSatisfiedBy([CanBeNull] T obj);

        /// <summary>
        ///     Checks if the given objects satisfies the specification.
        /// </summary>
        /// <param name="obj">The object to validate.</param>
        /// <returns>Returns a collection of error messages.</returns>
        [NotNull]
        [PublicAPI]
        IEnumerable<string> IsSatisfiedByWithMessages([CanBeNull] T obj);

        /// <summary>
        ///     Combines the current specification with the given specification using a OR link.
        /// </summary>
        /// <param name="specification">The specification to add.</param>
        /// <returns>Returns the combined specifications.</returns>
        [NotNull]
        [PublicAPI]
        ISpecification<T> Or([NotNull] ISpecification<T> specification);

        /// <summary>
        ///     Combines the current specification with the given specification using a XOR link.
        /// </summary>
        /// <param name="specification">The specification to add.</param>
        /// <returns>Returns the combined specifications.</returns>
        [NotNull]
        [PublicAPI]
        ISpecification<T> XOr([NotNull] ISpecification<T> specification);
    }
}