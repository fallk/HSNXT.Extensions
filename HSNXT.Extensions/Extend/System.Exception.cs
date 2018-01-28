using System;
using HSNXT.JetBrains.Annotations;
using System.Text;


namespace HSNXT
{
    public static partial class Extensions
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
        public static string FormatException( this Exception ex, [CanBeNull] Action<StringBuilder> action = null )
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