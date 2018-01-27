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
#region Usings
//using System;
//using System.Collections.Generic;
//using System.Reflection;
//using JetBrains.Annotations;
//using System.Linq;
//using System.IO;
//using System.Diagnostics;
//using System.Threading.Tasks;
//using System.Collections.ObjectModel;
//using System.Text;
//using System.Globalization;
//using System.Collections;
//using System.Linq.Expressions;
//using System.Text.RegularExpressions;
//using System.Collections.Concurrent;
//using HSNXT.Internal;

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="EventHandler" /> and <see cref="EventHandler{T}" />.
    /// </summary>
    public static class EventHandlerEx
    {
        /// <summary>
        ///     Raises the given <see cref="EventHandler" /> with
        ///     <paramref name="sender" />as sender and
        ///     <paramref name="e" />as argument.
        /// </summary>
        /// <param name="eventHandler">The <see cref="EventHandler" /> to raise.</param>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The event arguments.</param>
        /// <returns>Returns the given event handler.</returns>
        [Pure]
        [PublicAPI]
        public static EventHandler Raise( [CanBeNull] this EventHandler eventHandler, [CanBeNull] [NoEnumeration] Object sender, [CanBeNull] EventArgs e )
        {
            eventHandler?.Invoke( sender, e );

            return eventHandler;
        }

        /// <summary>
        ///     Raises the given <see cref="EventHandler" /> with
        ///     <paramref name="sender" />as sender and
        ///     <paramref name="e" />as argument.
        /// </summary>
        /// <typeparam name="T">The type of the event arguments.</typeparam>
        /// <param name="eventHandler">The <see cref="EventHandler" /> to raise.</param>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The event arguments.</param>
        /// <returns>Returns the given event handler.</returns>
        [Pure]
        [PublicAPI]
        public static EventHandler<T> Raise<T>( [CanBeNull] this EventHandler<T> eventHandler, [CanBeNull] [NoEnumeration] Object sender, [CanBeNull] T e )
            where T : EventArgs
        {
            eventHandler?.Invoke( sender, e );

            return eventHandler;
        }
    }
}