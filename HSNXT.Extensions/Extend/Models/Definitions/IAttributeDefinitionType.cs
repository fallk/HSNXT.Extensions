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
    ///     Interface representing the attribute definitions of a type.
    /// </summary>
    /// <typeparam name="T">The type of the attributes.</typeparam>
    public interface IAttributeDefinitionType<T> where T : Attribute
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        Type Type { get; set; }

        /// <summary>
        ///     Gets or sets the attributes.
        /// </summary>
        /// <value>The attributes.</value>
        IEnumerable<T> Attributes { get; set; }

        #endregion
    }
}