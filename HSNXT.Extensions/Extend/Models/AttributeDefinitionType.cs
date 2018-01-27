#region Usings
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

//using System;
//using System.Collections.Generic;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class representing a type and it's attributes of a specific type.
    /// </summary>
    /// <typeparam name="T">The type of the attributes.</typeparam>
    public class AttributeDefinitionType<T> : IAttributeDefinitionType<T> where T : Attribute
    {
        #region Implementation of IAttributeDefinitionType<T>

        /// <summary>
        ///     Gets or sets the attributes.
        /// </summary>
        /// <value>The attributes.</value>
        public IEnumerable<T> Attributes { get; set; }

        /// <summary>
        ///     Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public Type Type { get; set; }

        #endregion
    }
}