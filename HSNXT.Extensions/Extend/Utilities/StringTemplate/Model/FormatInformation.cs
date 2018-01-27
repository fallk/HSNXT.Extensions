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


namespace HSNXT.Internal
{
    /// <summary>
    ///     Class representing information about a format.
    /// </summary>
    public class FormatInformation
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the format.
        /// </summary>
        /// <value>The format.</value>
        public string Format { get; }

        /// <summary>
        ///     Gets or sets the name of the value/property.
        /// </summary>
        /// <value>The name of the value/property.</value>
        public string ValueName { get; }

        #endregion

        #region Ctor

        /// <summary>
        ///     Initializes a new instance of the <see cref="FormatInformation" /> class.
        /// </summary>
        /// <exception cref="ArgumentNullException">valueName can not be null.</exception>
        /// <param name="valueName">The name of the value.</param>
        /// <param name="format">The format.</param>
        public FormatInformation( [NotNull] string valueName, [CanBeNull] string format )
        {
            valueName.ThrowIfNull( nameof(valueName) );

            Format = format;
            ValueName = valueName;
        }

        #endregion
    }
}