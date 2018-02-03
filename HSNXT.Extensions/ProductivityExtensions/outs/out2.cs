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

#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// appdomaininitializer.BeginInvoke(args, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this AppDomainInitializer appdomaininitializer, String[] args, AsyncCallback callback)
		{
			if(appdomaininitializer == null) throw new ArgumentNullException("appdomaininitializer");

			return appdomaininitializer.BeginInvoke(args, callback, null);
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
		/// Extends GetValue so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// appsettingsreader.GetValue&lt;int&gt;(key);
		/// </example>
		/// </summary>
		public static T GetValue<T>(this AppSettingsReader appsettingsreader, String key)
		{
			if(appsettingsreader == null) throw new ArgumentNullException("appsettingsreader");

			return (T)appsettingsreader.GetValue(key, typeof(T));
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
        /// asynccallback.BeginInvoke(ar, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this AsyncCallback asynccallback, IAsyncResult ar,
            AsyncCallback callback)
        {
            if (asynccallback == null) throw new ArgumentNullException("asynccallback");

            return asynccallback.BeginInvoke(ar, callback, null);
        }
    }
}
#if (NETSTANDARD2_0 || NET47)

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends ChangeType so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// binder.ChangeType&lt;int&gt;(value, culture);
        /// </example>
        /// </summary>
        public static T ChangeType<T>(this Binder binder, Object value, System.Globalization.CultureInfo culture)
        {
            if (binder == null) throw new ArgumentNullException("binder");

            return (T) binder.ChangeType(value, typeof(T), culture);
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
        /// canceleventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this CancelEventHandler canceleventhandler, Object sender,
            CancelEventArgs e, AsyncCallback callback)
        {
            if (canceleventhandler == null) throw new ArgumentNullException("canceleventhandler");

            return canceleventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke&lt;T&gt; so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// comparison.BeginInvoke&lt;T&gt;(x, y, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke<T>(this Comparison<T> comparison, T x, T y, AsyncCallback callback)
        {
            if (comparison == null) throw new ArgumentNullException("comparison");

            return comparison.BeginInvoke(x, y, callback, null);
        }
    }
}
#if (NETSTANDARD2_0 || NET47)

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// contextcallback.BeginInvoke(state, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this ContextCallback contextcallback, Object state,
            AsyncCallback callback)
        {
            if (contextcallback == null) throw new ArgumentNullException("contextcallback");

            return contextcallback.BeginInvoke(state, callback, null);
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
		/// controleventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ControlEventHandler controleventhandler, Object sender, ControlEventArgs e, AsyncCallback callback)
		{
			if(controleventhandler == null) throw new ArgumentNullException("controleventhandler");

			return controleventhandler.BeginInvoke(sender, e, callback, null);
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
        /// Extends BeginInvoke&lt;TInput, TOutput&gt; so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// converter.BeginInvoke&lt;TInput, TOutput&gt;(input, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke<TInput, TOutput>(this Converter<TInput, TOutput> converter, TInput input,
            AsyncCallback callback)
        {
            if (converter == null) throw new ArgumentNullException("converter");

            return converter.BeginInvoke(input, callback, null);
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
		/// converteventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ConvertEventHandler converteventhandler, Object sender, ConvertEventArgs e, AsyncCallback callback)
		{
			if(converteventhandler == null) throw new ArgumentNullException("converteventhandler");

			return converteventhandler.BeginInvoke(sender, e, callback, null);
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
		/// crossappdomaindelegate.BeginInvoke(callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this CrossAppDomainDelegate crossappdomaindelegate, AsyncCallback callback)
		{
			if(crossappdomaindelegate == null) throw new ArgumentNullException("crossappdomaindelegate");

			return crossappdomaindelegate.BeginInvoke(callback, null);
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
		/// crosscontextdelegate.BeginInvoke(callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this CrossContextDelegate crosscontextdelegate, AsyncCallback callback)
		{
			if(crosscontextdelegate == null) throw new ArgumentNullException("crosscontextdelegate");

			return crosscontextdelegate.BeginInvoke(callback, null);
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
        /// Adds a generic Add&lt;T&gt; to DataColumnCollection to avoid Add(typeof(T), "columnName")
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataColumnCollection"></param>
        /// <param name="columnName"></param>
        public static void Add<T>(this DataColumnCollection dataColumnCollection, string columnName)
        {
            if (dataColumnCollection == null)
            {
                throw new ArgumentNullException(nameof(dataColumnCollection));
            }

            dataColumnCollection.Add(columnName, typeof(T));
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
		/// dateboldeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DateBoldEventHandler dateboldeventhandler, Object sender, DateBoldEventArgs e, AsyncCallback callback)
		{
			if(dateboldeventhandler == null) throw new ArgumentNullException("dateboldeventhandler");

			return dateboldeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// daterangeeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DateRangeEventHandler daterangeeventhandler, Object sender, DateRangeEventArgs e, AsyncCallback callback)
		{
			if(daterangeeventhandler == null) throw new ArgumentNullException("daterangeeventhandler");

			return daterangeeventhandler.BeginInvoke(sender, e, callback, null);
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
        /// doworkeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this DoWorkEventHandler doworkeventhandler, Object sender,
            DoWorkEventArgs e, AsyncCallback callback)
        {
            if (doworkeventhandler == null) throw new ArgumentNullException("doworkeventhandler");

            return doworkeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// drageventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DragEventHandler drageventhandler, Object sender, DragEventArgs e, AsyncCallback callback)
		{
			if(drageventhandler == null) throw new ArgumentNullException("drageventhandler");

			return drageventhandler.BeginInvoke(sender, e, callback, null);
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
		/// drawitemeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DrawItemEventHandler drawitemeventhandler, Object sender, DrawItemEventArgs e, AsyncCallback callback)
		{
			if(drawitemeventhandler == null) throw new ArgumentNullException("drawitemeventhandler");

			return drawitemeventhandler.BeginInvoke(sender, e, callback, null);
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
        /// elapsedeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this ElapsedEventHandler elapsedeventhandler, Object sender,
            ElapsedEventArgs e, AsyncCallback callback)
        {
            if (elapsedeventhandler == null) throw new ArgumentNullException("elapsedeventhandler");

            return elapsedeventhandler.BeginInvoke(sender, e, callback, null);
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
        /// erroreventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this ErrorEventHandler erroreventhandler, Object sender,
            ErrorEventArgs e, AsyncCallback callback)
        {
            if (erroreventhandler == null) throw new ArgumentNullException("erroreventhandler");

            return erroreventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#endif

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke&lt;TEventArgs&gt; so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// eventhandler.BeginInvoke&lt;TEventArgs&gt;(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke<TEventArgs>(this EventHandler<TEventArgs> eventhandler, Object sender,
            TEventArgs e, AsyncCallback callback) where TEventArgs : EventArgs
        {
            if (eventhandler == null) throw new ArgumentNullException("eventhandler");

            return eventhandler.BeginInvoke(sender, e, callback, null);
        }
    }
}
#if (NETSTANDARD2_0 || NET47)

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends Convert so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// formatterconverter.Convert&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T Convert<T>(this FormatterConverter formatterconverter, Object value)
        {
            if (formatterconverter == null) throw new ArgumentNullException("formatterconverter");

            return (T) formatterconverter.Convert(value, typeof(T));
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
		/// headerhandler.BeginInvoke(headers, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this HeaderHandler headerhandler, Header[] headers, AsyncCallback callback)
		{
			if(headerhandler == null) throw new ArgumentNullException("headerhandler");

			return headerhandler.BeginInvoke(headers, callback, null);
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
		/// helpeventhandler.BeginInvoke(sender, hlpevent, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this HelpEventHandler helpeventhandler, Object sender, HelpEventArgs hlpevent, AsyncCallback callback)
		{
			if(helpeventhandler == null) throw new ArgumentNullException("helpeventhandler");

			return helpeventhandler.BeginInvoke(sender, hlpevent, callback, null);
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
        /// Extends BeginGetContext so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// httplistener.BeginGetContext(callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginGetContext(this HttpListener httplistener, AsyncCallback callback)
        {
            if (httplistener == null) throw new ArgumentNullException("httplistener");

            return httplistener.BeginGetContext(callback, null);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47 || NETCOREAPP1_0 || NETCOREAPP1_1 || NETCOREAPP2_0)

namespace HSNXT.PRI.ProductivityExtensions
{
    public interface IAwaitable : INotifyCompletion
    {
        IAwaitable GetAwaiter();
        bool IsCompleted { get; }
        void GetResult();
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends Convert so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// iformatterconverter.Convert&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T Convert<T>(this IFormatterConverter iformatterconverter, Object value)
        {
            if (iformatterconverter == null) throw new ArgumentNullException("iformatterconverter");

            return (T) iformatterconverter.Convert(value, typeof(T));
        }
    }
}
#endif

namespace HSNXT.PRI.ProductivityExtensions.ReflectionExtensions
{
    /// <summary>
    /// class that contains information about an IL Instruction
    /// </summary>
    public class IlInstruction
    {
        /// <summary>
        /// construct an IlInstruction based on the OpCode
        /// </summary>
        /// <param name="code"></param>
        public IlInstruction(OpCode code)
        {
            Code = code;
        }

        /// <summary>
        /// Opcode of the instruction
        /// </summary>
        public OpCode Code { get; set; }

        /// <summary>
        /// Optional operand of the instruction
        /// </summary>
        public object Operand { get; set; }
    }
}
#if (NETSTANDARD2_0 || NETSTANDARD1_2 || NETSTANDARD1_1 || NET47)

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Checks if an <see cref="IPAddress"/> is IPv4 link local or not
        /// </summary>
        /// <param name="ipAddress">IPAddress to check</param>
        /// <returns>true if IP address is an IPv4 link local address</returns>
        public static bool IsIPv4LinkLocal(this IPAddress ipAddress)
        {
            if (ipAddress == null)
            {
                throw new ArgumentNullException(nameof(ipAddress));
            }

            byte[] ipBytes = ipAddress.GetAddressBytes();
            return ipBytes[0] == 169 && ipBytes[1] == 254;
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
		/// itemcheckeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ItemCheckEventHandler itemcheckeventhandler, Object sender, ItemCheckEventArgs e, AsyncCallback callback)
		{
			if(itemcheckeventhandler == null) throw new ArgumentNullException("itemcheckeventhandler");

			return itemcheckeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// itemdrageventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ItemDragEventHandler itemdrageventhandler, Object sender, ItemDragEventArgs e, AsyncCallback callback)
		{
			if(itemdrageventhandler == null) throw new ArgumentNullException("itemdrageventhandler");

			return itemdrageventhandler.BeginInvoke(sender, e, callback, null);
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
		/// keyeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this KeyEventHandler keyeventhandler, Object sender, KeyEventArgs e, AsyncCallback callback)
		{
			if(keyeventhandler == null) throw new ArgumentNullException("keyeventhandler");

			return keyeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// keypresseventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this KeyPressEventHandler keypresseventhandler, Object sender, KeyPressEventArgs e, AsyncCallback callback)
		{
			if(keypresseventhandler == null) throw new ArgumentNullException("keypresseventhandler");

			return keypresseventhandler.BeginInvoke(sender, e, callback, null);
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
		/// labelediteventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this LabelEditEventHandler labelediteventhandler, Object sender, LabelEditEventArgs e, AsyncCallback callback)
		{
			if(labelediteventhandler == null) throw new ArgumentNullException("labelediteventhandler");

			return labelediteventhandler.BeginInvoke(sender, e, callback, null);
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
		/// layouteventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this LayoutEventHandler layouteventhandler, Object sender, LayoutEventArgs e, AsyncCallback callback)
		{
			if(layouteventhandler == null) throw new ArgumentNullException("layouteventhandler");

			return layouteventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
#endif

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends CopyTo&lt;T&gt; so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// list.CopyTo&lt;T&gt;(index, array);
        /// </example>
        /// </summary>
        public static void CopyTo<T>(this List<T> list, Int32 index, T[] array)
        {
            if (list == null) throw new ArgumentNullException("list");

            if (array == null) throw new ArgumentNullException("array");

            list.CopyTo(index, array, 0, array.Length);
        }
    }
}

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// matchevaluator.BeginInvoke(match, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this MatchEvaluator matchevaluator, Match match, AsyncCallback callback)
        {
            if (matchevaluator == null) throw new ArgumentNullException("matchevaluator");

            return matchevaluator.BeginInvoke(match, callback, null);
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
		/// methodinvoker.BeginInvoke(callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this MethodInvoker methodinvoker, AsyncCallback callback)
		{
			if(methodinvoker == null) throw new ArgumentNullException("methodinvoker");

			return methodinvoker.BeginInvoke(callback, null);
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
		/// Adds a public class to the module encapsulated by the <paramref name="moduleBuilder"/> of name <paramref name="name"/>
		/// </summary>
		/// <param name="moduleBuilder"><seealso cref="ModuleBuilder"/> to add class to</param>
		/// <param name="name">Name of the class</param>
		/// <returns>TypeBuilder object that encapsulates the new class.</returns>
		public static TypeBuilder DefineClass(this ModuleBuilder moduleBuilder, string name)
		{
			return moduleBuilder.DefineType(name, TypeAttributes.Class | TypeAttributes.Public);
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
		/// mouseeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this MouseEventHandler mouseeventhandler, Object sender, MouseEventArgs e, AsyncCallback callback)
		{
			if(mouseeventhandler == null) throw new ArgumentNullException("mouseeventhandler");

			return mouseeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// navigateeventhandler.BeginInvoke(sender, ne, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this NavigateEventHandler navigateeventhandler, Object sender, NavigateEventArgs ne, AsyncCallback callback)
		{
			if(navigateeventhandler == null) throw new ArgumentNullException("navigateeventhandler");

			return navigateeventhandler.BeginInvoke(sender, ne, callback, null);
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
		/// objectcreationdelegate.BeginInvoke(aggregator, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ObjectCreationDelegate objectcreationdelegate, IntPtr aggregator, AsyncCallback callback)
		{
			if(objectcreationdelegate == null) throw new ArgumentNullException("objectcreationdelegate");

			return objectcreationdelegate.BeginInvoke(aggregator, callback, null);
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
		/// painteventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this PaintEventHandler painteventhandler, Object sender, PaintEventArgs e, AsyncCallback callback)
		{
			if(painteventhandler == null) throw new ArgumentNullException("painteventhandler");

			return painteventhandler.BeginInvoke(sender, e, callback, null);
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
        /// parameterizedthreadstart.BeginInvoke(obj, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this ParameterizedThreadStart parameterizedthreadstart, Object obj,
            AsyncCallback callback)
        {
            if (parameterizedthreadstart == null) throw new ArgumentNullException("parameterizedthreadstart");

            return parameterizedthreadstart.BeginInvoke(obj, callback, null);
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
		/// popupeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this PopupEventHandler popupeventhandler, Object sender, PopupEventArgs e, AsyncCallback callback)
		{
			if(popupeventhandler == null) throw new ArgumentNullException("popupeventhandler");

			return popupeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
#endif

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke&lt;T&gt; so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// predicate.BeginInvoke&lt;T&gt;(obj, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke<T>(this Predicate<T> predicate, T obj, AsyncCallback callback)
        {
            if (predicate == null) throw new ArgumentNullException("predicate");

            return predicate.BeginInvoke(obj, callback, null);
        }
    }
}
#if (NETSTANDARD2_0 || NET47)

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// printeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this PrintEventHandler printeventhandler, Object sender,
            PrintEventArgs e, AsyncCallback callback)
        {
            if (printeventhandler == null) throw new ArgumentNullException("printeventhandler");

            return printeventhandler.BeginInvoke(sender, e, callback, null);
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
        /// propertychangedeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this PropertyChangedEventHandler propertychangedeventhandler,
            Object sender, PropertyChangedEventArgs e, AsyncCallback callback)
        {
            if (propertychangedeventhandler == null) throw new ArgumentNullException("propertychangedeventhandler");

            return propertychangedeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// questioneventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this QuestionEventHandler questioneventhandler, Object sender, QuestionEventArgs e, AsyncCallback callback)
		{
			if(questioneventhandler == null) throw new ArgumentNullException("questioneventhandler");

			return questioneventhandler.BeginInvoke(sender, e, callback, null);
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
        /// refresheventhandler.BeginInvoke(e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this RefreshEventHandler refresheventhandler, RefreshEventArgs e,
            AsyncCallback callback)
        {
            if (refresheventhandler == null) throw new ArgumentNullException("refresheventhandler");

            return refresheventhandler.BeginInvoke(e, callback, null);
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
        /// renamedeventhandler.BeginInvoke(sender, e, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this RenamedEventHandler renamedeventhandler, Object sender,
            RenamedEventArgs e, AsyncCallback callback)
        {
            if (renamedeventhandler == null) throw new ArgumentNullException("renamedeventhandler");

            return renamedeventhandler.BeginInvoke(sender, e, callback, null);
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
        /// resolveeventhandler.BeginInvoke(sender, args, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this ResolveEventHandler resolveeventhandler, Object sender,
            ResolveEventArgs args, AsyncCallback callback)
        {
            if (resolveeventhandler == null) throw new ArgumentNullException("resolveeventhandler");

            return resolveeventhandler.BeginInvoke(sender, args, callback, null);
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
		/// scrolleventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ScrollEventHandler scrolleventhandler, Object sender, ScrollEventArgs e, AsyncCallback callback)
		{
			if(scrolleventhandler == null) throw new ArgumentNullException("scrolleventhandler");

			return scrolleventhandler.BeginInvoke(sender, e, callback, null);
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
        /// Extends GetValue so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// serializationinfo.GetValue&lt;int&gt;(name);
        /// </example>
        /// </summary>
        public static T GetValue<T>(this SerializationInfo serializationinfo, String name)
        {
            if (serializationinfo == null) throw new ArgumentNullException("serializationinfo");

            return (T) serializationinfo.GetValue(name, typeof(T));
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
		/// serialpinchangedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this SerialPinChangedEventHandler serialpinchangedeventhandler, Object sender, SerialPinChangedEventArgs e, AsyncCallback callback)
		{
			if(serialpinchangedeventhandler == null) throw new ArgumentNullException("serialpinchangedeventhandler");

			return serialpinchangedeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// sessionendedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this SessionEndedEventHandler sessionendedeventhandler, Object sender, SessionEndedEventArgs e, AsyncCallback callback)
		{
			if(sessionendedeventhandler == null) throw new ArgumentNullException("sessionendedeventhandler");

			return sessionendedeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// sessionendingeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this SessionEndingEventHandler sessionendingeventhandler, Object sender, SessionEndingEventArgs e, AsyncCallback callback)
		{
			if(sessionendingeventhandler == null) throw new ArgumentNullException("sessionendingeventhandler");

			return sessionendingeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// sessionswitcheventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this SessionSwitchEventHandler sessionswitcheventhandler, Object sender, SessionSwitchEventArgs e, AsyncCallback callback)
		{
			if(sessionswitcheventhandler == null) throw new ArgumentNullException("sessionswitcheventhandler");

			return sessionswitcheventhandler.BeginInvoke(sender, e, callback, null);
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
		/// settingchangingeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this SettingChangingEventHandler settingchangingeventhandler, Object sender, SettingChangingEventArgs e, AsyncCallback callback)
		{
			if(settingchangingeventhandler == null) throw new ArgumentNullException("settingchangingeventhandler");

			return settingchangingeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// settingssavingeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this SettingsSavingEventHandler settingssavingeventhandler, Object sender, System.ComponentModel.CancelEventArgs e, AsyncCallback callback)
		{
			if(settingssavingeventhandler == null) throw new ArgumentNullException("settingssavingeventhandler");

			return settingssavingeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// splittereventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this SplitterEventHandler splittereventhandler, Object sender, SplitterEventArgs e, AsyncCallback callback)
		{
			if(splittereventhandler == null) throw new ArgumentNullException("splittereventhandler");

			return splittereventhandler.BeginInvoke(sender, e, callback, null);
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
		/// sqlrowupdatingeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this SqlRowUpdatingEventHandler sqlrowupdatingeventhandler, Object sender, SqlRowUpdatingEventArgs e, AsyncCallback callback)
		{
			if(sqlrowupdatingeventhandler == null) throw new ArgumentNullException("sqlrowupdatingeventhandler");

			return sqlrowupdatingeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
#endif

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends CopyTo so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// text.CopyTo(sourceIndex, destination);
        /// </example>
        /// </summary>
        public static void CopyTo(this String text, Int32 sourceIndex, Char[] destination)
        {
            if (text == null) throw new ArgumentNullException("text");

            if (destination == null) throw new ArgumentNullException("destination");

            text.CopyTo(sourceIndex, destination, 0, destination.Length);
        }
    }
}

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends CopyTo so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// stringbuilder.CopyTo(sourceIndex, destination);
        /// </example>
        /// </summary>
        public static void CopyTo(this StringBuilder stringbuilder, Int32 sourceIndex, Char[] destination)
        {
            if (stringbuilder == null) throw new ArgumentNullException("stringbuilder");

            if (destination == null) throw new ArgumentNullException("destination");

            stringbuilder.CopyTo(sourceIndex, destination, 0, destination.Length);
        }
    }
}
#if (NETSTANDARD2_0 || NET47)

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// threadstart.BeginInvoke(callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this ThreadStart threadstart, AsyncCallback callback)
        {
            if (threadstart == null) throw new ArgumentNullException("threadstart");

            return threadstart.BeginInvoke(callback, null);
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
		/// timerelapsedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this TimerElapsedEventHandler timerelapsedeventhandler, Object sender, TimerElapsedEventArgs e, AsyncCallback callback)
		{
			if(timerelapsedeventhandler == null) throw new ArgumentNullException("timerelapsedeventhandler");

			return timerelapsedeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// treevieweventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this TreeViewEventHandler treevieweventhandler, Object sender, TreeViewEventArgs e, AsyncCallback callback)
		{
			if(treevieweventhandler == null) throw new ArgumentNullException("treevieweventhandler");

			return treevieweventhandler.BeginInvoke(sender, e, callback, null);
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
        /// typefilter.BeginInvoke(m, filterCriteria, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this TypeFilter typefilter, Type m, Object filterCriteria,
            AsyncCallback callback)
        {
            if (typefilter == null) throw new ArgumentNullException("typefilter");

            return typefilter.BeginInvoke(m, filterCriteria, callback, null);
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
		/// uicueseventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this UICuesEventHandler uicueseventhandler, Object sender, UICuesEventArgs e, AsyncCallback callback)
		{
			if(uicueseventhandler == null) throw new ArgumentNullException("uicueseventhandler");

			return uicueseventhandler.BeginInvoke(sender, e, callback, null);
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
		/// updowneventhandler.BeginInvoke(source, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this UpDownEventHandler updowneventhandler, Object source, UpDownEventArgs e, AsyncCallback callback)
		{
			if(updowneventhandler == null) throw new ArgumentNullException("updowneventhandler");

			return updowneventhandler.BeginInvoke(source, e, callback, null);
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
        /// waitcallback.BeginInvoke(state, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this WaitCallback waitcallback, Object state, AsyncCallback callback)
        {
            if (waitcallback == null) throw new ArgumentNullException("waitcallback");

            return waitcallback.BeginInvoke(state, callback, null);
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
        /// Extends ValueAs so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// xmlatomicvalue.ValueAs&lt;int&gt;(nsResolver);
        /// </example>
        /// </summary>
        public static T ValueAs<T>(this XmlAtomicValue xmlatomicvalue, System.Xml.IXmlNamespaceResolver nsResolver)
        {
            if (xmlatomicvalue == null) throw new ArgumentNullException("xmlatomicvalue");

            return (T) xmlatomicvalue.ValueAs(typeof(T), nsResolver);
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
        /// xmlresolver.GetEntity&lt;int&gt;(absoluteUri, role);
        /// </example>
        /// </summary>
        public static T GetEntity<T>(this XmlResolver xmlresolver, Uri absoluteUri, String role)
        {
            if (xmlresolver == null) throw new ArgumentNullException("xmlresolver");

            return (T) xmlresolver.GetEntity(absoluteUri, role, typeof(T));
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
        /// Extends Find so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// xmlschemas.Find&lt;int&gt;(name);
        /// </example>
        /// </summary>
        public static T Find<T>(this XmlSchemas xmlschemas, System.Xml.XmlQualifiedName name)
        {
            if (xmlschemas == null) throw new ArgumentNullException("xmlschemas");

            return (T) xmlschemas.Find(name, typeof(T));
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
        /// xmlurlresolver.GetEntity&lt;int&gt;(absoluteUri, role);
        /// </example>
        /// </summary>
        public static T GetEntity<T>(this XmlUrlResolver xmlurlresolver, Uri absoluteUri, String role)
        {
            if (xmlurlresolver == null) throw new ArgumentNullException("xmlurlresolver");

            return (T) xmlurlresolver.GetEntity(absoluteUri, role, typeof(T));
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
        /// xmlvaluegetter.BeginInvoke(callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this XmlValueGetter xmlvaluegetter, AsyncCallback callback)
        {
            if (xmlvaluegetter == null) throw new ArgumentNullException("xmlvaluegetter");

            return xmlvaluegetter.BeginInvoke(callback, null);
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
        /// Extends ValueAs so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// xpathitem.ValueAs&lt;int&gt;(nsResolver);
        /// </example>
        /// </summary>
        public static T ValueAs<T>(this XPathItem xpathitem, System.Xml.IXmlNamespaceResolver nsResolver)
        {
            if (xpathitem == null) throw new ArgumentNullException("xpathitem");

            return (T) xpathitem.ValueAs(typeof(T), nsResolver);
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
        /// Extends ValueAs so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// xpathnavigator.ValueAs&lt;int&gt;(nsResolver);
        /// </example>
        /// </summary>
        public static T ValueAs<T>(this XPathNavigator xpathnavigator, System.Xml.IXmlNamespaceResolver nsResolver)
        {
            if (xpathnavigator == null) throw new ArgumentNullException("xpathnavigator");

            return (T) xpathnavigator.ValueAs(typeof(T), nsResolver);
        }
    }
}
#endif