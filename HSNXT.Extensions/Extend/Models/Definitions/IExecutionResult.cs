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
    ///     Interface representing the result of a safe method execution.
    /// </summary>
    public interface IExecutionResult<T>
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the exception.
        /// </summary>
        /// <value>The exception.</value>
        Exception Exception { get; set; }

        /// <summary>
        ///     Gets or sets the result.
        /// </summary>
        /// <value>The result.</value>
        T Result { get; set; }

        #endregion
    }
}