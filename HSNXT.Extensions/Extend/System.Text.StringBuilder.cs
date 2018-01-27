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
    ///     Class containing some extension methods for <see cref="StringBuilder" />.
    /// </summary>
    public static class StringBuilderEx
    {
        /// <summary>
        ///     Appends a formated line to the given string builder.
        /// </summary>
        /// <exception cref="ArgumentNullException">The string builder can not be null.</exception>
        /// <exception cref="ArgumentNullException">The format can not be null.</exception>
        /// <exception cref="ArgumentNullException">The arguments can not be null.</exception>
        /// <param name="sb">The string builder to append the line to.</param>
        /// <param name="format">The <see cref="String" /> containing the format items.</param>
        /// <param name="args">The array containing all the corresponding values.</param>
        /// <returns>Returns the string builder.</returns>
        [NotNull]
        [PublicAPI]
        public static StringBuilder AppendLineFormat( [NotNull] this StringBuilder sb, [NotNull] String format, [NotNull] params Object[] args )
        {
            sb.ThrowIfNull( nameof(sb) );
            format.ThrowIfNull( nameof(format) );
            args.ThrowIfNull( nameof(args) );

            return sb.AppendLine( format.F( args ) );
        }
    }
}