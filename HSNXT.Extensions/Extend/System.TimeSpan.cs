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
    public static partial class Extensions
    {
        /// <summary>
        ///     Adds the given time span to the current date time.
        /// </summary>
        /// <param name="timeSpan">The time span to add.</param>
        /// <returns>Returns the current date time with the specified time span added to it.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime Future( this TimeSpan timeSpan )
            => DateTime.Now.Add( timeSpan );
        /// <summary>
        ///     Subtracts the specified time span to the current date time.
        /// </summary>
        /// <param name="timeSpan">The time span to subtract.</param>
        /// <returns>Returns the current date time with the specified time span subtracted from it.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime Past( this TimeSpan timeSpan )
            => DateTime.Now.Subtract( timeSpan );
    }
}