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
    ///     Class containing some extension methods for <see cref="Exception" />.
    /// </summary>
    public static class ExceptionEx
    {
        /// <summary>
        ///     Formates the given exception.
        /// </summary>
        /// <exception cref="ArgumentNullException">ex can not be null.</exception>
        /// <param name="ex">The exception to format.</param>
        /// <param name="action">A optional action to add custom content.</param>
        /// <returns>Returns the formated exception.</returns>
        [PublicAPI]
        [NotNull]
        [Pure]
        public static String FormatException( this Exception ex, [CanBeNull] Action<StringBuilder> action = null )
        {
            ex.ThrowIfNull( nameof(ex) );

            var sb = new StringBuilder();
            sb.AppendLineFormat( "{0}: {1}",
                                 ex.GetType()
                                   .Name,
                                 ex.Message );

            action?.Invoke( sb );

            if ( ex.InnerException != null )
            {
                sb.AppendLineFormat( "{0} ---> {1}", Environment.NewLine, ex.InnerException.ToString() );
                sb.AppendLine( "   --- End of inner exception stack trace ---" );
            }

            sb.Append( ex.StackTrace );

            return sb.ToString();
        }
    }
}