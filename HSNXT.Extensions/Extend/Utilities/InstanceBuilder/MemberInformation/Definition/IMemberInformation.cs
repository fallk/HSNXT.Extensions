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
    ///     Interface exposing information about a member.
    /// </summary>
    public interface IMemberInformation
    {
        #region Properties

        /// <summary>
        ///     Gets the name of the member.
        /// </summary>
        /// <value>The name of the member.</value>
        string MemberName { get; }

        /// <summary>
        ///     Gets the member path of the member.
        /// </summary>
        /// <value>The member path of the member.</value>
        string MemberPath { get; }

        /// <summary>
        ///     Gets the type of the member.
        /// </summary>
        /// <value>The type of the member.</value>
        Type MemberType { get; }

        /// <summary>
        ///     Gets or sets a reference to the member.
        /// </summary>
        /// <remarks>
        ///     Not always set.
        /// </remarks>
        /// <value>A reference to the member.</value>
        object MemberObject { get; }

        /// <summary>
        ///     Gets the property info representing the member.
        /// </summary>
        /// <remarks>
        ///     Not always set.
        /// </remarks>
        /// <value>The property info representing the member.</value>
        PropertyInfo PropertyInfo { get; }

        #endregion
    }
}