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
    ///     Class containing information about a member.
    /// </summary>
    public class MemberInformation : IMemberInformation
    {
        #region Overrides of Object

        /// <summary>
        ///     Creates and returns a string representation of the current exception.
        /// </summary>
        /// <returns>A string representation of the current exception.</returns>
        public override string ToString()
            => $"Name: '{MemberName}' Path '{MemberPath}' Type '{MemberType?.Namespace}.{MemberType?.Name}'";

        #endregion

        #region Implementation of IMemberInformation

        /// <summary>
        ///     Gets the name of the member.
        /// </summary>
        /// <value>The name of the member.</value>
        public string MemberName { get; set; }

        /// <summary>
        ///     Gets the member path of the member.
        /// </summary>
        /// <value>The member path of the member.</value>
        public string MemberPath { get; set; }

        /// <summary>
        ///     Gets the type of the member.
        /// </summary>
        /// <value>The type of the member.</value>
        public Type MemberType { get; set; }

        /// <summary>
        ///     Gets or sets a reference to the member.
        /// </summary>
        /// <remarks>
        ///     Can be null.
        /// </remarks>
        /// <value>A reference to the member.</value>
        public object MemberObject { get; set; }

        /// <summary>
        ///     Gets the property info representing the member.
        /// </summary>
        /// <remarks>
        ///     Not always set.
        /// </remarks>
        /// <value>The property info representing the member.</value>
        public PropertyInfo PropertyInfo { get; set; }

        #endregion
    }
}