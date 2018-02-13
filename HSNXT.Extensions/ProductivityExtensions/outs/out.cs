using System;
using System.ComponentModel;
using System.Net;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Diagnostics;
using System.Data;
using System.IO;
using System.Net.NetworkInformation;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.IO.Pipes;
using Microsoft.Win32;
using System.Drawing.Printing;
using System.ComponentModel.Design.Serialization;
using System.IO.Ports;
using System.Configuration;
using System.Threading;
using System.Drawing.Design;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Resolvers;
using System.Timers;
using System.Runtime.Serialization;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.XPath;
using System.Drawing.Imaging;
using System.Net.Mail;
using System.Net.Sockets;
using System.Xml.Xsl;
using System.Globalization;
using System.Drawing;
using System.Security.Cryptography;
using System.Data.Common;
using System.Linq.Expressions;
using System.Security.Authentication.ExtendedProtection;
using System.Net.Security;
using System.Data.SqlTypes;
using System.IO.Compression;
using System.IO.IsolatedStorage;
using System.IO.MemoryMappedFiles;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using System.Collections.ObjectModel;
#if NetFX
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms.Layout;

#endif

#if (NETSTANDARD2_0 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// addingneweventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this AddingNewEventHandler addingneweventhandler, Object sender,
            AddingNewEventArgs e, AsyncCallback callback)
        {
            if (addingneweventhandler == null) throw new ArgumentNullException("addingneweventhandler");

            return addingneweventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// assemblyloadeventhandler.BeginInvoke(sender, args, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this AssemblyLoadEventHandler assemblyloadeventhandler, Object sender,
            AssemblyLoadEventArgs args, AsyncCallback callback)
        {
            if (assemblyloadeventhandler == null) throw new ArgumentNullException("assemblyloadeventhandler");

            return assemblyloadeventhandler.BeginInvoke(sender, args, callback, null);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// asynccompletedeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this AsyncCompletedEventHandler asynccompletedeventhandler,
            Object sender, AsyncCompletedEventArgs e, AsyncCallback callback)
        {
            if (asynccompletedeventhandler == null) throw new ArgumentNullException("asynccompletedeventhandler");

            return asynccompletedeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// authenticationschemeselector.BeginInvoke(httpRequest, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this AuthenticationSchemeSelector authenticationschemeselector,
            HttpListenerRequest httpRequest, AsyncCallback callback)
        {
            if (authenticationschemeselector == null) throw new ArgumentNullException("authenticationschemeselector");

            return authenticationschemeselector.BeginInvoke(httpRequest, callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// bindingcompleteeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this BindingCompleteEventHandler bindingcompleteeventhandler,
            Object sender, BindingCompleteEventArgs e, AsyncCallback callback)
        {
            if (bindingcompleteeventhandler == null) throw new ArgumentNullException("bindingcompleteeventhandler");

            return bindingcompleteeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// columnclickeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this ColumnClickEventHandler columnclickeventhandler, Object sender,
            ColumnClickEventArgs e, AsyncCallback callback)
        {
            if (columnclickeventhandler == null) throw new ArgumentNullException("columnclickeventhandler");

            return columnclickeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// columnreorderedeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this ColumnReorderedEventHandler columnreorderedeventhandler,
            Object sender, ColumnReorderedEventArgs e, AsyncCallback callback)
        {
            if (columnreorderedeventhandler == null) throw new ArgumentNullException("columnreorderedeventhandler");

            return columnreorderedeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// componenteventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this ComponentEventHandler componenteventhandler, Object sender,
            ComponentEventArgs e, AsyncCallback callback)
        {
            if (componenteventhandler == null) throw new ArgumentNullException("componenteventhandler");

            return componenteventhandler.BeginInvoke(sender, e, callback, null);
        }

#endif
#if (NET47)
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// contentsresizedeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this ContentsResizedEventHandler contentsresizedeventhandler,
            Object sender, ContentsResizedEventArgs e, AsyncCallback callback)
        {
            if (contentsresizedeventhandler == null) throw new ArgumentNullException("contentsresizedeventhandler");

            return contentsresizedeventhandler.BeginInvoke(sender, e, callback, null);
        }


#endif
#if (NETSTANDARD2_0 || NET47)


        /// <summary>
        /// Tests if <paramref name="t"/> has any custom attributes defined with the type name <paramref name="attr"/>
        /// </summary>
        /// <param name="t">The provider to check for types with given attribute type names.</param>
        /// <param name="attr">Name of the attribute to check fo</param>
        /// <returns>true - <paramref name="t"/> has the attribute defined.
        /// false - <paramref name="t"/> does not have the attribute defined.</returns>
        public static bool ContainsAttribute(this ICustomAttributeProvider t, string attr)
        {
            if (t == null)
            {
                throw new ArgumentNullException(nameof(t));
            }

            return t.GetCustomAttributes(true).Any(i => i.GetType().Name == attr);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// datagridviewcelleventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this DataGridViewCellEventHandler datagridviewcelleventhandler,
            Object sender, DataGridViewCellEventArgs e, AsyncCallback callback)
        {
            if (datagridviewcelleventhandler == null) throw new ArgumentNullException("datagridviewcelleventhandler");

            return datagridviewcelleventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// datagridviewroweventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this DataGridViewRowEventHandler datagridviewroweventhandler,
            Object sender, DataGridViewRowEventArgs e, AsyncCallback callback)
        {
            if (datagridviewroweventhandler == null) throw new ArgumentNullException("datagridviewroweventhandler");

            return datagridviewroweventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// datareceivedeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this DataReceivedEventHandler datareceivedeventhandler, Object sender,
            DataReceivedEventArgs e, AsyncCallback callback)
        {
            if (datareceivedeventhandler == null) throw new ArgumentNullException("datareceivedeventhandler");

            return datareceivedeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// datarowchangeeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this DataRowChangeEventHandler datarowchangeeventhandler, Object sender,
            DataRowChangeEventArgs e, AsyncCallback callback)
        {
            if (datarowchangeeventhandler == null) throw new ArgumentNullException("datarowchangeeventhandler");

            return datarowchangeeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// datatablecleareventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this DataTableClearEventHandler datatablecleareventhandler,
            Object sender, DataTableClearEventArgs e, AsyncCallback callback)
        {
            if (datatablecleareventhandler == null) throw new ArgumentNullException("datatablecleareventhandler");

            return datatablecleareventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// datatablenewroweventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this DataTableNewRowEventHandler datatablenewroweventhandler,
            Object sender, DataTableNewRowEventArgs e, AsyncCallback callback)
        {
            if (datatablenewroweventhandler == null) throw new ArgumentNullException("datatablenewroweventhandler");

            return datatablenewroweventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// designereventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this DesignerEventHandler designereventhandler, Object sender,
            DesignerEventArgs e, AsyncCallback callback)
        {
            if (designereventhandler == null) throw new ArgumentNullException("designereventhandler");

            return designereventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// drawlistviewitemeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this DrawListViewItemEventHandler drawlistviewitemeventhandler,
            Object sender, DrawListViewItemEventArgs e, AsyncCallback callback)
        {
            if (drawlistviewitemeventhandler == null) throw new ArgumentNullException("drawlistviewitemeventhandler");

            return drawlistviewitemeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// drawtooltipeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this DrawToolTipEventHandler drawtooltipeventhandler, Object sender,
            DrawToolTipEventArgs e, AsyncCallback callback)
        {
            if (drawtooltipeventhandler == null) throw new ArgumentNullException("drawtooltipeventhandler");

            return drawtooltipeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// drawtreenodeeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this DrawTreeNodeEventHandler drawtreenodeeventhandler, Object sender,
            DrawTreeNodeEventArgs e, AsyncCallback callback)
        {
            if (drawtreenodeeventhandler == null) throw new ArgumentNullException("drawtreenodeeventhandler");

            return drawtreenodeeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// entrywritteneventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this EntryWrittenEventHandler entrywritteneventhandler, Object sender,
            EntryWrittenEventArgs e, AsyncCallback callback)
        {
            if (entrywritteneventhandler == null) throw new ArgumentNullException("entrywritteneventhandler");

            return entrywritteneventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// filesystemeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this FileSystemEventHandler filesystemeventhandler, Object sender,
            FileSystemEventArgs e, AsyncCallback callback)
        {
            if (filesystemeventhandler == null) throw new ArgumentNullException("filesystemeventhandler");

            return filesystemeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// fillerroreventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this FillErrorEventHandler fillerroreventhandler, Object sender,
            FillErrorEventArgs e, AsyncCallback callback)
        {
            if (fillerroreventhandler == null) throw new ArgumentNullException("fillerroreventhandler");

            return fillerroreventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// formclosedeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this FormClosedEventHandler formclosedeventhandler, Object sender,
            FormClosedEventArgs e, AsyncCallback callback)
        {
            if (formclosedeventhandler == null) throw new ArgumentNullException("formclosedeventhandler");

            return formclosedeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// formclosingeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this FormClosingEventHandler formclosingeventhandler, Object sender,
            FormClosingEventArgs e, AsyncCallback callback)
        {
            if (formclosingeventhandler == null) throw new ArgumentNullException("formclosingeventhandler");

            return formclosingeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// givefeedbackeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this GiveFeedbackEventHandler givefeedbackeventhandler, Object sender,
            GiveFeedbackEventArgs e, AsyncCallback callback)
        {
            if (givefeedbackeventhandler == null) throw new ArgumentNullException("givefeedbackeventhandler");

            return givefeedbackeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// handledeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this HandledEventHandler handledeventhandler, Object sender,
            HandledEventArgs e, AsyncCallback callback)
        {
            if (handledeventhandler == null) throw new ArgumentNullException("handledeventhandler");

            return handledeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// htmlelementerroreventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this HtmlElementErrorEventHandler htmlelementerroreventhandler,
            Object sender, HtmlElementErrorEventArgs e, AsyncCallback callback)
        {
            if (htmlelementerroreventhandler == null) throw new ArgumentNullException("htmlelementerroreventhandler");

            return htmlelementerroreventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// htmlelementeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this HtmlElementEventHandler htmlelementeventhandler, Object sender,
            HtmlElementEventArgs e, AsyncCallback callback)
        {
            if (htmlelementeventhandler == null) throw new ArgumentNullException("htmlelementeventhandler");

            return htmlelementeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// httpcontinuedelegate.BeginInvoke(StatusCode, httpHeaders, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this HttpContinueDelegate httpcontinuedelegate, Int32 StatusCode,
            WebHeaderCollection httpHeaders, AsyncCallback callback)
        {
            if (httpcontinuedelegate == null) throw new ArgumentNullException("httpcontinuedelegate");

            return httpcontinuedelegate.BeginInvoke(StatusCode, httpHeaders, callback, null);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginGetClientCertificate so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// httplistenerrequest.BeginGetClientCertificate(requestCallback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginGetClientCertificate(this HttpListenerRequest httplistenerrequest,
            AsyncCallback requestCallback)
        {
            if (httplistenerrequest == null) throw new ArgumentNullException("httplistenerrequest");

            return httplistenerrequest.BeginGetClientCertificate(requestCallback, null);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NETSTANDARD1_4 || NETSTANDARD1_3 || NETSTANDARD1_2 || NETSTANDARD1_1 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends ToType so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// iconvertible.ToType&lt;int&gt;(provider);
        /// </example>
        /// </summary>
        public static T ToType<T>(this IConvertible iconvertible, IFormatProvider provider)
        {
            if (iconvertible == null) throw new ArgumentNullException("iconvertible");

            return (T) iconvertible.ToType(typeof(T), provider);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// invalidateeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this InvalidateEventHandler invalidateeventhandler, Object sender,
            InvalidateEventArgs e, AsyncCallback callback)
        {
            if (invalidateeventhandler == null) throw new ArgumentNullException("invalidateeventhandler");

            return invalidateeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginGetUnicastAddresses so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// ipglobalproperties.BeginGetUnicastAddresses(callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginGetUnicastAddresses(this IPGlobalProperties ipglobalproperties,
            AsyncCallback callback)
        {
            if (ipglobalproperties == null) throw new ArgumentNullException("ipglobalproperties");

            return ipglobalproperties.BeginGetUnicastAddresses(callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// itemchangedeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this ItemChangedEventHandler itemchangedeventhandler, Object sender,
            ItemChangedEventArgs e, AsyncCallback callback)
        {
            if (itemchangedeventhandler == null) throw new ArgumentNullException("itemchangedeventhandler");

            return itemchangedeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// itemcheckedeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this ItemCheckedEventHandler itemcheckedeventhandler, Object sender,
            ItemCheckedEventArgs e, AsyncCallback callback)
        {
            if (itemcheckedeventhandler == null) throw new ArgumentNullException("itemcheckedeventhandler");

            return itemcheckedeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// linkclickedeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this LinkClickedEventHandler linkclickedeventhandler, Object sender,
            LinkClickedEventArgs e, AsyncCallback callback)
        {
            if (linkclickedeventhandler == null) throw new ArgumentNullException("linkclickedeventhandler");

            return linkclickedeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// listchangedeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this ListChangedEventHandler listchangedeventhandler, Object sender,
            ListChangedEventArgs e, AsyncCallback callback)
        {
            if (listchangedeventhandler == null) throw new ArgumentNullException("listchangedeventhandler");

            return listchangedeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// maskinputrejectedeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this MaskInputRejectedEventHandler maskinputrejectedeventhandler,
            Object sender, MaskInputRejectedEventArgs e, AsyncCallback callback)
        {
            if (maskinputrejectedeventhandler == null) throw new ArgumentNullException("maskinputrejectedeventhandler");

            return maskinputrejectedeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// measureitemeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this MeasureItemEventHandler measureitemeventhandler, Object sender,
            MeasureItemEventArgs e, AsyncCallback callback)
        {
            if (measureitemeventhandler == null) throw new ArgumentNullException("measureitemeventhandler");

            return measureitemeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// memberfilter.BeginInvoke(m, filterCriteria, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this MemberFilter memberfilter, MemberInfo m, Object filterCriteria,
            AsyncCallback callback)
        {
            if (memberfilter == null) throw new ArgumentNullException("memberfilter");

            return memberfilter.BeginInvoke(m, filterCriteria, callback, null);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// mergefailedeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this MergeFailedEventHandler mergefailedeventhandler, Object sender,
            MergeFailedEventArgs e, AsyncCallback callback)
        {
            if (mergefailedeventhandler == null) throw new ArgumentNullException("mergefailedeventhandler");

            return mergefailedeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// messagesurrogatefilter.BeginInvoke(key, value, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this MessageSurrogateFilter messagesurrogatefilter, String key,
            Object value, AsyncCallback callback)
        {
            if (messagesurrogatefilter == null) throw new ArgumentNullException("messagesurrogatefilter");

            return messagesurrogatefilter.BeginInvoke(key, value, callback, null);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// moduleresolveeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this ModuleResolveEventHandler moduleresolveeventhandler, Object sender,
            ResolveEventArgs e, AsyncCallback callback)
        {
            if (moduleresolveeventhandler == null) throw new ArgumentNullException("moduleresolveeventhandler");

            return moduleresolveeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// nodelabelediteventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this NodeLabelEditEventHandler nodelabelediteventhandler, Object sender,
            NodeLabelEditEventArgs e, AsyncCallback callback)
        {
            if (nodelabelediteventhandler == null) throw new ArgumentNullException("nodelabelediteventhandler");

            return nodelabelediteventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// notifycollectionchangedeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(
            this NotifyCollectionChangedEventHandler notifycollectionchangedeventhandler, Object sender,
            NotifyCollectionChangedEventArgs e, AsyncCallback callback)
        {
            if (notifycollectionchangedeventhandler == null)
                throw new ArgumentNullException("notifycollectionchangedeventhandler");

            return notifycollectionchangedeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// odbcinfomessageeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this OdbcInfoMessageEventHandler odbcinfomessageeventhandler,
            Object sender, OdbcInfoMessageEventArgs e, AsyncCallback callback)
        {
            if (odbcinfomessageeventhandler == null) throw new ArgumentNullException("odbcinfomessageeventhandler");

            return odbcinfomessageeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// odbcrowupdatedeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this OdbcRowUpdatedEventHandler odbcrowupdatedeventhandler,
            Object sender, OdbcRowUpdatedEventArgs e, AsyncCallback callback)
        {
            if (odbcrowupdatedeventhandler == null) throw new ArgumentNullException("odbcrowupdatedeventhandler");

            return odbcrowupdatedeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// odbcrowupdatingeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this OdbcRowUpdatingEventHandler odbcrowupdatingeventhandler,
            Object sender, OdbcRowUpdatingEventArgs e, AsyncCallback callback)
        {
            if (odbcrowupdatingeventhandler == null) throw new ArgumentNullException("odbcrowupdatingeventhandler");

            return odbcrowupdatingeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// oledbinfomessageeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this OleDbInfoMessageEventHandler oledbinfomessageeventhandler,
            Object sender, OleDbInfoMessageEventArgs e, AsyncCallback callback)
        {
            if (oledbinfomessageeventhandler == null) throw new ArgumentNullException("oledbinfomessageeventhandler");

            return oledbinfomessageeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// oledbrowupdatedeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this OleDbRowUpdatedEventHandler oledbrowupdatedeventhandler,
            Object sender, OleDbRowUpdatedEventArgs e, AsyncCallback callback)
        {
            if (oledbrowupdatedeventhandler == null) throw new ArgumentNullException("oledbrowupdatedeventhandler");

            return oledbrowupdatedeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// oledbrowupdatingeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this OleDbRowUpdatingEventHandler oledbrowupdatingeventhandler,
            Object sender, OleDbRowUpdatingEventArgs e, AsyncCallback callback)
        {
            if (oledbrowupdatingeventhandler == null) throw new ArgumentNullException("oledbrowupdatingeventhandler");

            return oledbrowupdatingeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// onchangeeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this OnChangeEventHandler onchangeeventhandler, Object sender,
            SqlNotificationEventArgs e, AsyncCallback callback)
        {
            if (onchangeeventhandler == null) throw new ArgumentNullException("onchangeeventhandler");

            return onchangeeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// pingcompletedeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this PingCompletedEventHandler pingcompletedeventhandler, Object sender,
            PingCompletedEventArgs e, AsyncCallback callback)
        {
            if (pingcompletedeventhandler == null) throw new ArgumentNullException("pingcompletedeventhandler");

            return pingcompletedeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// pipestreamimpersonationworker.BeginInvoke(callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this PipeStreamImpersonationWorker pipestreamimpersonationworker,
            AsyncCallback callback)
        {
            if (pipestreamimpersonationworker == null) throw new ArgumentNullException("pipestreamimpersonationworker");

            return pipestreamimpersonationworker.BeginInvoke(callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// powermodechangedeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this PowerModeChangedEventHandler powermodechangedeventhandler,
            Object sender, PowerModeChangedEventArgs e, AsyncCallback callback)
        {
            if (powermodechangedeventhandler == null) throw new ArgumentNullException("powermodechangedeventhandler");

            return powermodechangedeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// previewkeydowneventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this PreviewKeyDownEventHandler previewkeydowneventhandler,
            Object sender, PreviewKeyDownEventArgs e, AsyncCallback callback)
        {
            if (previewkeydowneventhandler == null) throw new ArgumentNullException("previewkeydowneventhandler");

            return previewkeydowneventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// printpageeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this PrintPageEventHandler printpageeventhandler, Object sender,
            PrintPageEventArgs e, AsyncCallback callback)
        {
            if (printpageeventhandler == null) throw new ArgumentNullException("printpageeventhandler");

            return printpageeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// propertytabchangedeventhandler.BeginInvoke(s, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this PropertyTabChangedEventHandler propertytabchangedeventhandler,
            Object s, PropertyTabChangedEventArgs e, AsyncCallback callback)
        {
            if (propertytabchangedeventhandler == null)
                throw new ArgumentNullException("propertytabchangedeventhandler");

            return propertytabchangedeventhandler.BeginInvoke(s, e, callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// querycontinuedrageventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this QueryContinueDragEventHandler querycontinuedrageventhandler,
            Object sender, QueryContinueDragEventArgs e, AsyncCallback callback)
        {
            if (querycontinuedrageventhandler == null) throw new ArgumentNullException("querycontinuedrageventhandler");

            return querycontinuedrageventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// resolvenameeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this ResolveNameEventHandler resolvenameeventhandler, Object sender,
            ResolveNameEventArgs e, AsyncCallback callback)
        {
            if (resolvenameeventhandler == null) throw new ArgumentNullException("resolvenameeventhandler");

            return resolvenameeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NET40 || NET45)
namespace HSNXT
{
    public static partial class Extensions
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// serialdatareceivedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this SerialDataReceivedEventHandler serialdatareceivedeventhandler, Object sender, SerialDataReceivedEventArgs e, AsyncCallback callback)
		{
			if(serialdatareceivedeventhandler == null) throw new ArgumentNullException("serialdatareceivedeventhandler");

			return serialdatareceivedeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
#endif
#if (NET40 || NET45)
namespace HSNXT
{
    public static partial class Extensions
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// serialerrorreceivedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this SerialErrorReceivedEventHandler serialerrorreceivedeventhandler, Object sender, SerialErrorReceivedEventArgs e, AsyncCallback callback)
		{
			if(serialerrorreceivedeventhandler == null) throw new ArgumentNullException("serialerrorreceivedeventhandler");

			return serialerrorreceivedeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// settingsloadedeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this SettingsLoadedEventHandler settingsloadedeventhandler,
            Object sender, SettingsLoadedEventArgs e, AsyncCallback callback)
        {
            if (settingsloadedeventhandler == null) throw new ArgumentNullException("settingsloadedeventhandler");

            return settingsloadedeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// splittercanceleventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this SplitterCancelEventHandler splittercanceleventhandler,
            Object sender, SplitterCancelEventArgs e, AsyncCallback callback)
        {
            if (splittercanceleventhandler == null) throw new ArgumentNullException("splittercanceleventhandler");

            return splittercanceleventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NETSTANDARD1_6 || NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// sqlinfomessageeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this SqlInfoMessageEventHandler sqlinfomessageeventhandler,
            Object sender, SqlInfoMessageEventArgs e, AsyncCallback callback)
        {
            if (sqlinfomessageeventhandler == null) throw new ArgumentNullException("sqlinfomessageeventhandler");

            return sqlinfomessageeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NETSTANDARD1_6 || NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// sqlrowscopiedeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this SqlRowsCopiedEventHandler sqlrowscopiedeventhandler, Object sender,
            SqlRowsCopiedEventArgs e, AsyncCallback callback)
        {
            if (sqlrowscopiedeventhandler == null) throw new ArgumentNullException("sqlrowscopiedeventhandler");

            return sqlrowscopiedeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// sqlrowupdatedeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this SqlRowUpdatedEventHandler sqlrowupdatedeventhandler, Object sender,
            SqlRowUpdatedEventArgs e, AsyncCallback callback)
        {
            if (sqlrowupdatedeventhandler == null) throw new ArgumentNullException("sqlrowupdatedeventhandler");

            return sqlrowupdatedeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// statechangeeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this StateChangeEventHandler statechangeeventhandler, Object sender,
            StateChangeEventArgs e, AsyncCallback callback)
        {
            if (statechangeeventhandler == null) throw new ArgumentNullException("statechangeeventhandler");

            return statechangeeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// tabcontrolcanceleventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this TabControlCancelEventHandler tabcontrolcanceleventhandler,
            Object sender, TabControlCancelEventArgs e, AsyncCallback callback)
        {
            if (tabcontrolcanceleventhandler == null) throw new ArgumentNullException("tabcontrolcanceleventhandler");

            return tabcontrolcanceleventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// tabcontroleventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this TabControlEventHandler tabcontroleventhandler, Object sender,
            TabControlEventArgs e, AsyncCallback callback)
        {
            if (tabcontroleventhandler == null) throw new ArgumentNullException("tabcontroleventhandler");

            return tabcontroleventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// threadexceptioneventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this ThreadExceptionEventHandler threadexceptioneventhandler,
            Object sender, ThreadExceptionEventArgs e, AsyncCallback callback)
        {
            if (threadexceptioneventhandler == null) throw new ArgumentNullException("threadexceptioneventhandler");

            return threadexceptioneventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NETSTANDARD1_4 || NETSTANDARD1_3 || NETSTANDARD1_2 || NETSTANDARD1_1 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// timercallback.BeginInvoke(state, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this TimerCallback timercallback, Object state, AsyncCallback callback)
        {
            if (timercallback == null) throw new ArgumentNullException("timercallback");

            return timercallback.BeginInvoke(state, callback, null);
        }
    }
}
#endif
#if (NET40 || NET45)
namespace HSNXT
{
    public static partial class Extensions
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// toolboxitemcreatorcallback.BeginInvoke(serializedObject, format, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ToolboxItemCreatorCallback toolboxitemcreatorcallback, Object serializedObject, String format, AsyncCallback callback)
		{
			if(toolboxitemcreatorcallback == null) throw new ArgumentNullException("toolboxitemcreatorcallback");

			return toolboxitemcreatorcallback.BeginInvoke(serializedObject, format, callback, null);
		}

	}
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// toolstripitemeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this ToolStripItemEventHandler toolstripitemeventhandler, Object sender,
            ToolStripItemEventArgs e, AsyncCallback callback)
        {
            if (toolstripitemeventhandler == null) throw new ArgumentNullException("toolstripitemeventhandler");

            return toolstripitemeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// toolstriprendereventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this ToolStripRenderEventHandler toolstriprendereventhandler,
            Object sender, ToolStripRenderEventArgs e, AsyncCallback callback)
        {
            if (toolstriprendereventhandler == null) throw new ArgumentNullException("toolstriprendereventhandler");

            return toolstriprendereventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// treeviewcanceleventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this TreeViewCancelEventHandler treeviewcanceleventhandler,
            Object sender, TreeViewCancelEventArgs e, AsyncCallback callback)
        {
            if (treeviewcanceleventhandler == null) throw new ArgumentNullException("treeviewcanceleventhandler");

            return treeviewcanceleventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// typevalidationeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this TypeValidationEventHandler typevalidationeventhandler,
            Object sender, TypeValidationEventArgs e, AsyncCallback callback)
        {
            if (typevalidationeventhandler == null) throw new ArgumentNullException("typevalidationeventhandler");

            return typevalidationeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// unhandledexceptioneventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this UnhandledExceptionEventHandler unhandledexceptioneventhandler,
            Object sender, UnhandledExceptionEventArgs e, AsyncCallback callback)
        {
            if (unhandledexceptioneventhandler == null)
                throw new ArgumentNullException("unhandledexceptioneventhandler");

            return unhandledexceptioneventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NET40 || NET45)
namespace HSNXT
{
    public static partial class Extensions
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// userpreferencechangedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this UserPreferenceChangedEventHandler userpreferencechangedeventhandler, Object sender, UserPreferenceChangedEventArgs e, AsyncCallback callback)
		{
			if(userpreferencechangedeventhandler == null) throw new ArgumentNullException("userpreferencechangedeventhandler");

			return userpreferencechangedeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
#endif
#if (NET40 || NET45)
namespace HSNXT
{
    public static partial class Extensions
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// userpreferencechangingeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this UserPreferenceChangingEventHandler userpreferencechangingeventhandler, Object sender, UserPreferenceChangingEventArgs e, AsyncCallback callback)
		{
			if(userpreferencechangingeventhandler == null) throw new ArgumentNullException("userpreferencechangingeventhandler");

			return userpreferencechangingeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
#endif
#if (NETSTANDARD2_0 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// validationeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this ValidationEventHandler validationeventhandler, Object sender,
            ValidationEventArgs e, AsyncCallback callback)
        {
            if (validationeventhandler == null) throw new ArgumentNullException("validationeventhandler");

            return validationeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// waitortimercallback.BeginInvoke(state, timedOut, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this WaitOrTimerCallback waitortimercallback, Object state,
            Boolean timedOut, AsyncCallback callback)
        {
            if (waitortimercallback == null) throw new ArgumentNullException("waitortimercallback");

            return waitortimercallback.BeginInvoke(state, timedOut, callback, null);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// xmlattributeeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this XmlAttributeEventHandler xmlattributeeventhandler, Object sender,
            XmlAttributeEventArgs e, AsyncCallback callback)
        {
            if (xmlattributeeventhandler == null) throw new ArgumentNullException("xmlattributeeventhandler");

            return xmlattributeeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// xmlelementeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this XmlElementEventHandler xmlelementeventhandler, Object sender,
            XmlElementEventArgs e, AsyncCallback callback)
        {
            if (xmlelementeventhandler == null) throw new ArgumentNullException("xmlelementeventhandler");

            return xmlelementeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// xmlnodechangedeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this XmlNodeChangedEventHandler xmlnodechangedeventhandler,
            Object sender, XmlNodeChangedEventArgs e, AsyncCallback callback)
        {
            if (xmlnodechangedeventhandler == null) throw new ArgumentNullException("xmlnodechangedeventhandler");

            return xmlnodechangedeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// xmlnodeeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this XmlNodeEventHandler xmlnodeeventhandler, Object sender,
            XmlNodeEventArgs e, AsyncCallback callback)
        {
            if (xmlnodeeventhandler == null) throw new ArgumentNullException("xmlnodeeventhandler");

            return xmlnodeeventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends GetEntity so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// xmlpreloadedresolver.GetEntity&lt;int&gt;(absoluteUri, role);
        /// </example>
        /// </summary>
        public static T GetEntity<T>(this XmlPreloadedResolver xmlpreloadedresolver, Uri absoluteUri, String role)
        {
            if (xmlpreloadedresolver == null) throw new ArgumentNullException("xmlpreloadedresolver");

            return (T) xmlpreloadedresolver.GetEntity(absoluteUri, role, typeof(T));
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends GetEntity so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// xmlsecureresolver.GetEntity&lt;int&gt;(absoluteUri, role);
        /// </example>
        /// </summary>
        public static T GetEntity<T>(this XmlSecureResolver xmlsecureresolver, Uri absoluteUri, String role)
        {
            if (xmlsecureresolver == null) throw new ArgumentNullException("xmlsecureresolver");

            return (T) xmlsecureresolver.GetEntity(absoluteUri, role, typeof(T));
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// xmlserializationfixupcallback.BeginInvoke(fixup, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this XmlSerializationFixupCallback xmlserializationfixupcallback,
            Object fixup, AsyncCallback callback)
        {
            if (xmlserializationfixupcallback == null) throw new ArgumentNullException("xmlserializationfixupcallback");

            return xmlserializationfixupcallback.BeginInvoke(fixup, callback, null);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// xmlserializationreadcallback.BeginInvoke(callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this XmlSerializationReadCallback xmlserializationreadcallback,
            AsyncCallback callback)
        {
            if (xmlserializationreadcallback == null) throw new ArgumentNullException("xmlserializationreadcallback");

            return xmlserializationreadcallback.BeginInvoke(callback, null);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// xmlserializationwritecallback.BeginInvoke(o, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this XmlSerializationWriteCallback xmlserializationwritecallback,
            Object o, AsyncCallback callback)
        {
            if (xmlserializationwritecallback == null) throw new ArgumentNullException("xmlserializationwritecallback");

            return xmlserializationwritecallback.BeginInvoke(o, callback, null);
        }
    }
}
#endif