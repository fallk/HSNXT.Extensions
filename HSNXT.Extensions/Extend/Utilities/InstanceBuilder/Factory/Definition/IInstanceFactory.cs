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
    /// <summary>
    ///     Interface representing a value factory.
    /// </summary>
    public interface IInstanceFactory
    {
        #region Properties

        /// <summary>
        ///     Gets the name of the factory.
        /// </summary>
        /// <value>The name of the factory.</value>
        string FactoryName { get; }

        /// <summary>
        ///     Gets the description of the factory.
        /// </summary>
        /// <value>The description of the factory.</value>
        string FactoryDescription { get; }

        /// <summary>
        ///     Gets the selection rules of the factory.
        /// </summary>
        /// <value>The selection rules of the factory.</value>
        List<IMemberSelectionRule> SelectionRules { get; }

        #endregion

        /// <summary>
        ///     Adds the given <see cref="IMemberSelectionRule" /> to the factory.
        /// </summary>
        /// <exception cref="ArgumentNullException">memberSelectionRule can not be null.</exception>
        /// <param name="memberSelectionRule">The <see cref="IMemberSelectionRule" /> to add.</param>
        /// <returns>Returns the modified factory.</returns>
        [PublicAPI]
        [NotNull]
        IInstanceFactory AddSelectionRule( [NotNull] IMemberSelectionRule memberSelectionRule );

        /// <summary>
        ///     Gets the value for the given <see cref="IMemberInformation" />.
        /// </summary>
        /// <exception cref="ArgumentNullException">memberSelectionRule can not be null.</exception>
        /// <param name="memberInformation">Information about the member to create a value for.</param>
        /// <returns>Returns the created value.</returns>
        [PublicAPI]
        [CanBeNull]
        object CreateValue( [NotNull] IMemberInformation memberInformation );
    }
}