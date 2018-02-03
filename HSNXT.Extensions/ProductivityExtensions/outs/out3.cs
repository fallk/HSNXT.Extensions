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
		/// Create a single multitask delegate from several actions.
		/// </summary>
		/// <typeparam name="T">The type of the parameter of the action that this action encapsulates. This type parameter is contravariant. That is, you can use either the type you specified or any type that is less derived. For more information about covariance and contravariance, see Covariance and Contravariance in Generics.</typeparam>
		/// <param name="coll">The collection of <seealso cref="Action{T}"/> to create a multicast delegate from.</param>
		/// <returns></returns>
		public static Action<T> Sum<T>(this IEnumerable<Action<T>> coll)
		{
			Action<T> result = coll.ElementAt(0);
			foreach (var d in coll.Skip(1))
			{
				result += d;
			}

			return result;
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
		/// activedesignereventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ActiveDesignerEventHandler activedesignereventhandler, Object sender, ActiveDesignerEventArgs e, AsyncCallback callback)
		{
			if(activedesignereventhandler == null) throw new ArgumentNullException("activedesignereventhandler");

			return activedesignereventhandler.BeginInvoke(sender, e, callback, null);
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
		/// bindingmanagerdataerroreventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this BindingManagerDataErrorEventHandler bindingmanagerdataerroreventhandler, Object sender, BindingManagerDataErrorEventArgs e, AsyncCallback callback)
		{
			if(bindingmanagerdataerroreventhandler == null) throw new ArgumentNullException("bindingmanagerdataerroreventhandler");

			return bindingmanagerdataerroreventhandler.BeginInvoke(sender, e, callback, null);
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
		/// bindipendpoint.BeginInvoke(servicePoint, remoteEndPoint, retryCount, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this BindIPEndPoint bindipendpoint, ServicePoint servicePoint, IPEndPoint remoteEndPoint, Int32 retryCount, AsyncCallback callback)
		{
			if(bindipendpoint == null) throw new ArgumentNullException("bindipendpoint");

			return bindipendpoint.BeginInvoke(servicePoint, remoteEndPoint, retryCount, callback, null);
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
		/// cachevirtualitemseventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this CacheVirtualItemsEventHandler cachevirtualitemseventhandler, Object sender, CacheVirtualItemsEventArgs e, AsyncCallback callback)
		{
			if(cachevirtualitemseventhandler == null) throw new ArgumentNullException("cachevirtualitemseventhandler");

			return cachevirtualitemseventhandler.BeginInvoke(sender, e, callback, null);
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
		/// collectionchangeeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this CollectionChangeEventHandler collectionchangeeventhandler, Object sender, CollectionChangeEventArgs e, AsyncCallback callback)
		{
			if(collectionchangeeventhandler == null) throw new ArgumentNullException("collectionchangeeventhandler");

			return collectionchangeeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// columnwidthchangedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ColumnWidthChangedEventHandler columnwidthchangedeventhandler, Object sender, ColumnWidthChangedEventArgs e, AsyncCallback callback)
		{
			if(columnwidthchangedeventhandler == null) throw new ArgumentNullException("columnwidthchangedeventhandler");

			return columnwidthchangedeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// columnwidthchangingeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ColumnWidthChangingEventHandler columnwidthchangingeventhandler, Object sender, ColumnWidthChangingEventArgs e, AsyncCallback callback)
		{
			if(columnwidthchangingeventhandler == null) throw new ArgumentNullException("columnwidthchangingeventhandler");

			return columnwidthchangingeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// componentchangedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ComponentChangedEventHandler componentchangedeventhandler, Object sender, ComponentChangedEventArgs e, AsyncCallback callback)
		{
			if(componentchangedeventhandler == null) throw new ArgumentNullException("componentchangedeventhandler");

			return componentchangedeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// componentchangingeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ComponentChangingEventHandler componentchangingeventhandler, Object sender, ComponentChangingEventArgs e, AsyncCallback callback)
		{
			if(componentchangingeventhandler == null) throw new ArgumentNullException("componentchangingeventhandler");

			return componentchangingeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// componentrenameeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ComponentRenameEventHandler componentrenameeventhandler, Object sender, ComponentRenameEventArgs e, AsyncCallback callback)
		{
			if(componentrenameeventhandler == null) throw new ArgumentNullException("componentrenameeventhandler");

			return componentrenameeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
#endif
#if (NETSTANDARD2_0 || NETSTANDARD2_0 || NETSTANDARD1_4 || NETSTANDARD1_3 || NET47)

namespace HSNXT
{
    public static partial class Extensions
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// consolecanceleventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ConsoleCancelEventHandler consolecanceleventhandler, Object sender, ConsoleCancelEventArgs e, AsyncCallback callback)
		{
			if(consolecanceleventhandler == null) throw new ArgumentNullException("consolecanceleventhandler");

			return consolecanceleventhandler.BeginInvoke(sender, e, callback, null);
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
		/// datacolumnchangeeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataColumnChangeEventHandler datacolumnchangeeventhandler, Object sender, DataColumnChangeEventArgs e, AsyncCallback callback)
		{
			if(datacolumnchangeeventhandler == null) throw new ArgumentNullException("datacolumnchangeeventhandler");

			return datacolumnchangeeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// datagridviewautosizecolumnmodeeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewAutoSizeColumnModeEventHandler datagridviewautosizecolumnmodeeventhandler, Object sender, DataGridViewAutoSizeColumnModeEventArgs e, AsyncCallback callback)
		{
			if(datagridviewautosizecolumnmodeeventhandler == null) throw new ArgumentNullException("datagridviewautosizecolumnmodeeventhandler");

			return datagridviewautosizecolumnmodeeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// datagridviewautosizecolumnsmodeeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewAutoSizeColumnsModeEventHandler datagridviewautosizecolumnsmodeeventhandler, Object sender, DataGridViewAutoSizeColumnsModeEventArgs e, AsyncCallback callback)
		{
			if(datagridviewautosizecolumnsmodeeventhandler == null) throw new ArgumentNullException("datagridviewautosizecolumnsmodeeventhandler");

			return datagridviewautosizecolumnsmodeeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// datagridviewautosizemodeeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewAutoSizeModeEventHandler datagridviewautosizemodeeventhandler, Object sender, DataGridViewAutoSizeModeEventArgs e, AsyncCallback callback)
		{
			if(datagridviewautosizemodeeventhandler == null) throw new ArgumentNullException("datagridviewautosizemodeeventhandler");

			return datagridviewautosizemodeeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// datagridviewbindingcompleteeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewBindingCompleteEventHandler datagridviewbindingcompleteeventhandler, Object sender, DataGridViewBindingCompleteEventArgs e, AsyncCallback callback)
		{
			if(datagridviewbindingcompleteeventhandler == null) throw new ArgumentNullException("datagridviewbindingcompleteeventhandler");

			return datagridviewbindingcompleteeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// datagridviewcellcanceleventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewCellCancelEventHandler datagridviewcellcanceleventhandler, Object sender, DataGridViewCellCancelEventArgs e, AsyncCallback callback)
		{
			if(datagridviewcellcanceleventhandler == null) throw new ArgumentNullException("datagridviewcellcanceleventhandler");

			return datagridviewcellcanceleventhandler.BeginInvoke(sender, e, callback, null);
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
		/// datagridviewcellcontextmenustripneededeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewCellContextMenuStripNeededEventHandler datagridviewcellcontextmenustripneededeventhandler, Object sender, DataGridViewCellContextMenuStripNeededEventArgs e, AsyncCallback callback)
		{
			if(datagridviewcellcontextmenustripneededeventhandler == null) throw new ArgumentNullException("datagridviewcellcontextmenustripneededeventhandler");

			return datagridviewcellcontextmenustripneededeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// datagridviewcellerrortextneededeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewCellErrorTextNeededEventHandler datagridviewcellerrortextneededeventhandler, Object sender, DataGridViewCellErrorTextNeededEventArgs e, AsyncCallback callback)
		{
			if(datagridviewcellerrortextneededeventhandler == null) throw new ArgumentNullException("datagridviewcellerrortextneededeventhandler");

			return datagridviewcellerrortextneededeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// datagridviewcellformattingeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewCellFormattingEventHandler datagridviewcellformattingeventhandler, Object sender, DataGridViewCellFormattingEventArgs e, AsyncCallback callback)
		{
			if(datagridviewcellformattingeventhandler == null) throw new ArgumentNullException("datagridviewcellformattingeventhandler");

			return datagridviewcellformattingeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// datagridviewcellmouseeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewCellMouseEventHandler datagridviewcellmouseeventhandler, Object sender, DataGridViewCellMouseEventArgs e, AsyncCallback callback)
		{
			if(datagridviewcellmouseeventhandler == null) throw new ArgumentNullException("datagridviewcellmouseeventhandler");

			return datagridviewcellmouseeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// datagridviewcellpaintingeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewCellPaintingEventHandler datagridviewcellpaintingeventhandler, Object sender, DataGridViewCellPaintingEventArgs e, AsyncCallback callback)
		{
			if(datagridviewcellpaintingeventhandler == null) throw new ArgumentNullException("datagridviewcellpaintingeventhandler");

			return datagridviewcellpaintingeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// datagridviewcellparsingeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewCellParsingEventHandler datagridviewcellparsingeventhandler, Object sender, DataGridViewCellParsingEventArgs e, AsyncCallback callback)
		{
			if(datagridviewcellparsingeventhandler == null) throw new ArgumentNullException("datagridviewcellparsingeventhandler");

			return datagridviewcellparsingeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// datagridviewcellstatechangedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewCellStateChangedEventHandler datagridviewcellstatechangedeventhandler, Object sender, DataGridViewCellStateChangedEventArgs e, AsyncCallback callback)
		{
			if(datagridviewcellstatechangedeventhandler == null) throw new ArgumentNullException("datagridviewcellstatechangedeventhandler");

			return datagridviewcellstatechangedeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// datagridviewcellstylecontentchangedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewCellStyleContentChangedEventHandler datagridviewcellstylecontentchangedeventhandler, Object sender, DataGridViewCellStyleContentChangedEventArgs e, AsyncCallback callback)
		{
			if(datagridviewcellstylecontentchangedeventhandler == null) throw new ArgumentNullException("datagridviewcellstylecontentchangedeventhandler");

			return datagridviewcellstylecontentchangedeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// datagridviewcelltooltiptextneededeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewCellToolTipTextNeededEventHandler datagridviewcelltooltiptextneededeventhandler, Object sender, DataGridViewCellToolTipTextNeededEventArgs e, AsyncCallback callback)
		{
			if(datagridviewcelltooltiptextneededeventhandler == null) throw new ArgumentNullException("datagridviewcelltooltiptextneededeventhandler");

			return datagridviewcelltooltiptextneededeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// datagridviewcellvalidatingeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewCellValidatingEventHandler datagridviewcellvalidatingeventhandler, Object sender, DataGridViewCellValidatingEventArgs e, AsyncCallback callback)
		{
			if(datagridviewcellvalidatingeventhandler == null) throw new ArgumentNullException("datagridviewcellvalidatingeventhandler");

			return datagridviewcellvalidatingeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// datagridviewcellvalueeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewCellValueEventHandler datagridviewcellvalueeventhandler, Object sender, DataGridViewCellValueEventArgs e, AsyncCallback callback)
		{
			if(datagridviewcellvalueeventhandler == null) throw new ArgumentNullException("datagridviewcellvalueeventhandler");

			return datagridviewcellvalueeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// datagridviewcolumndividerdoubleclickeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewColumnDividerDoubleClickEventHandler datagridviewcolumndividerdoubleclickeventhandler, Object sender, DataGridViewColumnDividerDoubleClickEventArgs e, AsyncCallback callback)
		{
			if(datagridviewcolumndividerdoubleclickeventhandler == null) throw new ArgumentNullException("datagridviewcolumndividerdoubleclickeventhandler");

			return datagridviewcolumndividerdoubleclickeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// datagridviewcolumneventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewColumnEventHandler datagridviewcolumneventhandler, Object sender, DataGridViewColumnEventArgs e, AsyncCallback callback)
		{
			if(datagridviewcolumneventhandler == null) throw new ArgumentNullException("datagridviewcolumneventhandler");

			return datagridviewcolumneventhandler.BeginInvoke(sender, e, callback, null);
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
		/// datagridviewcolumnstatechangedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewColumnStateChangedEventHandler datagridviewcolumnstatechangedeventhandler, Object sender, DataGridViewColumnStateChangedEventArgs e, AsyncCallback callback)
		{
			if(datagridviewcolumnstatechangedeventhandler == null) throw new ArgumentNullException("datagridviewcolumnstatechangedeventhandler");

			return datagridviewcolumnstatechangedeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// datagridviewdataerroreventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewDataErrorEventHandler datagridviewdataerroreventhandler, Object sender, DataGridViewDataErrorEventArgs e, AsyncCallback callback)
		{
			if(datagridviewdataerroreventhandler == null) throw new ArgumentNullException("datagridviewdataerroreventhandler");

			return datagridviewdataerroreventhandler.BeginInvoke(sender, e, callback, null);
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
		/// datagridvieweditingcontrolshowingeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewEditingControlShowingEventHandler datagridvieweditingcontrolshowingeventhandler, Object sender, DataGridViewEditingControlShowingEventArgs e, AsyncCallback callback)
		{
			if(datagridvieweditingcontrolshowingeventhandler == null) throw new ArgumentNullException("datagridvieweditingcontrolshowingeventhandler");

			return datagridvieweditingcontrolshowingeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// datagridviewrowcanceleventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewRowCancelEventHandler datagridviewrowcanceleventhandler, Object sender, DataGridViewRowCancelEventArgs e, AsyncCallback callback)
		{
			if(datagridviewrowcanceleventhandler == null) throw new ArgumentNullException("datagridviewrowcanceleventhandler");

			return datagridviewrowcanceleventhandler.BeginInvoke(sender, e, callback, null);
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
		/// datagridviewrowcontextmenustripneededeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewRowContextMenuStripNeededEventHandler datagridviewrowcontextmenustripneededeventhandler, Object sender, DataGridViewRowContextMenuStripNeededEventArgs e, AsyncCallback callback)
		{
			if(datagridviewrowcontextmenustripneededeventhandler == null) throw new ArgumentNullException("datagridviewrowcontextmenustripneededeventhandler");

			return datagridviewrowcontextmenustripneededeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// datagridviewrowdividerdoubleclickeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewRowDividerDoubleClickEventHandler datagridviewrowdividerdoubleclickeventhandler, Object sender, DataGridViewRowDividerDoubleClickEventArgs e, AsyncCallback callback)
		{
			if(datagridviewrowdividerdoubleclickeventhandler == null) throw new ArgumentNullException("datagridviewrowdividerdoubleclickeventhandler");

			return datagridviewrowdividerdoubleclickeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// datagridviewrowerrortextneededeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewRowErrorTextNeededEventHandler datagridviewrowerrortextneededeventhandler, Object sender, DataGridViewRowErrorTextNeededEventArgs e, AsyncCallback callback)
		{
			if(datagridviewrowerrortextneededeventhandler == null) throw new ArgumentNullException("datagridviewrowerrortextneededeventhandler");

			return datagridviewrowerrortextneededeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// datagridviewrowheightinfoneededeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewRowHeightInfoNeededEventHandler datagridviewrowheightinfoneededeventhandler, Object sender, DataGridViewRowHeightInfoNeededEventArgs e, AsyncCallback callback)
		{
			if(datagridviewrowheightinfoneededeventhandler == null) throw new ArgumentNullException("datagridviewrowheightinfoneededeventhandler");

			return datagridviewrowheightinfoneededeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// datagridviewrowheightinfopushedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewRowHeightInfoPushedEventHandler datagridviewrowheightinfopushedeventhandler, Object sender, DataGridViewRowHeightInfoPushedEventArgs e, AsyncCallback callback)
		{
			if(datagridviewrowheightinfopushedeventhandler == null) throw new ArgumentNullException("datagridviewrowheightinfopushedeventhandler");

			return datagridviewrowheightinfopushedeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// datagridviewrowpostpainteventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewRowPostPaintEventHandler datagridviewrowpostpainteventhandler, Object sender, DataGridViewRowPostPaintEventArgs e, AsyncCallback callback)
		{
			if(datagridviewrowpostpainteventhandler == null) throw new ArgumentNullException("datagridviewrowpostpainteventhandler");

			return datagridviewrowpostpainteventhandler.BeginInvoke(sender, e, callback, null);
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
		/// datagridviewrowprepainteventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewRowPrePaintEventHandler datagridviewrowprepainteventhandler, Object sender, DataGridViewRowPrePaintEventArgs e, AsyncCallback callback)
		{
			if(datagridviewrowprepainteventhandler == null) throw new ArgumentNullException("datagridviewrowprepainteventhandler");

			return datagridviewrowprepainteventhandler.BeginInvoke(sender, e, callback, null);
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
		/// datagridviewrowsaddedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewRowsAddedEventHandler datagridviewrowsaddedeventhandler, Object sender, DataGridViewRowsAddedEventArgs e, AsyncCallback callback)
		{
			if(datagridviewrowsaddedeventhandler == null) throw new ArgumentNullException("datagridviewrowsaddedeventhandler");

			return datagridviewrowsaddedeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// datagridviewrowsremovedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewRowsRemovedEventHandler datagridviewrowsremovedeventhandler, Object sender, DataGridViewRowsRemovedEventArgs e, AsyncCallback callback)
		{
			if(datagridviewrowsremovedeventhandler == null) throw new ArgumentNullException("datagridviewrowsremovedeventhandler");

			return datagridviewrowsremovedeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// datagridviewrowstatechangedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewRowStateChangedEventHandler datagridviewrowstatechangedeventhandler, Object sender, DataGridViewRowStateChangedEventArgs e, AsyncCallback callback)
		{
			if(datagridviewrowstatechangedeventhandler == null) throw new ArgumentNullException("datagridviewrowstatechangedeventhandler");

			return datagridviewrowstatechangedeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// datagridviewsortcompareeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewSortCompareEventHandler datagridviewsortcompareeventhandler, Object sender, DataGridViewSortCompareEventArgs e, AsyncCallback callback)
		{
			if(datagridviewsortcompareeventhandler == null) throw new ArgumentNullException("datagridviewsortcompareeventhandler");

			return datagridviewsortcompareeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// designertransactioncloseeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DesignerTransactionCloseEventHandler designertransactioncloseeventhandler, Object sender, DesignerTransactionCloseEventArgs e, AsyncCallback callback)
		{
			if(designertransactioncloseeventhandler == null) throw new ArgumentNullException("designertransactioncloseeventhandler");

			return designertransactioncloseeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// downloaddatacompletedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DownloadDataCompletedEventHandler downloaddatacompletedeventhandler, Object sender, DownloadDataCompletedEventArgs e, AsyncCallback callback)
		{
			if(downloaddatacompletedeventhandler == null) throw new ArgumentNullException("downloaddatacompletedeventhandler");

			return downloaddatacompletedeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// downloadprogresschangedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DownloadProgressChangedEventHandler downloadprogresschangedeventhandler, Object sender, DownloadProgressChangedEventArgs e, AsyncCallback callback)
		{
			if(downloadprogresschangedeventhandler == null) throw new ArgumentNullException("downloadprogresschangedeventhandler");

			return downloadprogresschangedeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// downloadstringcompletedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DownloadStringCompletedEventHandler downloadstringcompletedeventhandler, Object sender, DownloadStringCompletedEventArgs e, AsyncCallback callback)
		{
			if(downloadstringcompletedeventhandler == null) throw new ArgumentNullException("downloadstringcompletedeventhandler");

			return downloadstringcompletedeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// drawlistviewcolumnheadereventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DrawListViewColumnHeaderEventHandler drawlistviewcolumnheadereventhandler, Object sender, DrawListViewColumnHeaderEventArgs e, AsyncCallback callback)
		{
			if(drawlistviewcolumnheadereventhandler == null) throw new ArgumentNullException("drawlistviewcolumnheadereventhandler");

			return drawlistviewcolumnheadereventhandler.BeginInvoke(sender, e, callback, null);
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
		/// drawlistviewsubitemeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DrawListViewSubItemEventHandler drawlistviewsubitemeventhandler, Object sender, DrawListViewSubItemEventArgs e, AsyncCallback callback)
		{
			if(drawlistviewsubitemeventhandler == null) throw new ArgumentNullException("drawlistviewsubitemeventhandler");

			return drawlistviewsubitemeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// Extends CreateInstance so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// idesignerserializationmanager.CreateInstance&lt;int&gt;(arguments, name, addToContainer);
		/// </example>
		/// </summary>
		public static T CreateInstance<T>(this IDesignerSerializationManager idesignerserializationmanager, System.Collections.ICollection arguments, String name, Boolean addToContainer)
		{
			if(idesignerserializationmanager == null) throw new ArgumentNullException("idesignerserializationmanager");

			return (T)idesignerserializationmanager.CreateInstance(typeof(T), arguments, name, addToContainer);
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
		/// Emit code that will get the value from <paramref name="field"/>
		/// </summary>
		/// <param name="generator">Generator that will emit the instructions</param>
		/// <param name="field">Field to read</param>
		public static void EmitBackingFieldGetter(this ILGenerator generator, FieldInfo field)
		{
			generator.Emit(OpCodes.Ldarg_0);
			generator.Emit(OpCodes.Ldfld, field);
			generator.Emit(OpCodes.Ret);
		}

		/// <summary>
		/// Emit code that will set the value <paramref name="field"/> based argument on stack
		/// </summary>
		/// <param name="generator">Generator that will emit the instructions</param>
		/// <param name="field">Field to write</param>
		public static void EmitBackingFieldSetter(this ILGenerator generator, FieldInfo field)
		{
			generator.Emit(OpCodes.Ldarg_0);
			generator.Emit(OpCodes.Ldarg_1);
			generator.Emit(OpCodes.Stfld, field);
			generator.Emit(OpCodes.Ret);
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
		/// inputlanguagechangedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this InputLanguageChangedEventHandler inputlanguagechangedeventhandler, Object sender, InputLanguageChangedEventArgs e, AsyncCallback callback)
		{
			if(inputlanguagechangedeventhandler == null) throw new ArgumentNullException("inputlanguagechangedeventhandler");

			return inputlanguagechangedeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// inputlanguagechangingeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this InputLanguageChangingEventHandler inputlanguagechangingeventhandler, Object sender, InputLanguageChangingEventArgs e, AsyncCallback callback)
		{
			if(inputlanguagechangingeventhandler == null) throw new ArgumentNullException("inputlanguagechangingeventhandler");

			return inputlanguagechangingeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// Extends CreateInstance so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// instancecreationeditor.CreateInstance&lt;int&gt;(context);
		/// </example>
		/// </summary>
		public static T CreateInstance<T>(this InstanceCreationEditor instancecreationeditor, ITypeDescriptorContext context)
		{
			if(instancecreationeditor == null) throw new ArgumentNullException("instancecreationeditor");

			return (T)instancecreationeditor.CreateInstance(context, typeof(T));
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
		/// iocompletioncallback.BeginInvoke(errorCode, numBytes, pOVERLAP, callback);
		/// </example>
		/// </summary>
		public unsafe static IAsyncResult BeginInvoke(this IOCompletionCallback iocompletioncallback, UInt32 errorCode, UInt32 numBytes, NativeOverlapped* pOVERLAP, AsyncCallback callback)
		{
			if(iocompletioncallback == null) throw new ArgumentNullException("iocompletioncallback");

			return iocompletioncallback.BeginInvoke(errorCode, numBytes, pOVERLAP, callback, null);
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
		/// linklabellinkclickedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this LinkLabelLinkClickedEventHandler linklabellinkclickedeventhandler, Object sender, LinkLabelLinkClickedEventArgs e, AsyncCallback callback)
		{
			if(linklabellinkclickedeventhandler == null) throw new ArgumentNullException("linklabellinkclickedeventhandler");

			return linklabellinkclickedeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// listcontrolconverteventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ListControlConvertEventHandler listcontrolconverteventhandler, Object sender, ListControlConvertEventArgs e, AsyncCallback callback)
		{
			if(listcontrolconverteventhandler == null) throw new ArgumentNullException("listcontrolconverteventhandler");

			return listcontrolconverteventhandler.BeginInvoke(sender, e, callback, null);
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
		/// listviewitemmousehovereventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ListViewItemMouseHoverEventHandler listviewitemmousehovereventhandler, Object sender, ListViewItemMouseHoverEventArgs e, AsyncCallback callback)
		{
			if(listviewitemmousehovereventhandler == null) throw new ArgumentNullException("listviewitemmousehovereventhandler");

			return listviewitemmousehovereventhandler.BeginInvoke(sender, e, callback, null);
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
		/// listviewitemselectionchangedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ListViewItemSelectionChangedEventHandler listviewitemselectionchangedeventhandler, Object sender, ListViewItemSelectionChangedEventArgs e, AsyncCallback callback)
		{
			if(listviewitemselectionchangedeventhandler == null) throw new ArgumentNullException("listviewitemselectionchangedeventhandler");

			return listviewitemselectionchangedeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// networkaddresschangedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this NetworkAddressChangedEventHandler networkaddresschangedeventhandler, Object sender, EventArgs e, AsyncCallback callback)
		{
			if(networkaddresschangedeventhandler == null) throw new ArgumentNullException("networkaddresschangedeventhandler");

			return networkaddresschangedeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// networkavailabilitychangedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this NetworkAvailabilityChangedEventHandler networkavailabilitychangedeventhandler, Object sender, NetworkAvailabilityEventArgs e, AsyncCallback callback)
		{
			if(networkavailabilitychangedeventhandler == null) throw new ArgumentNullException("networkavailabilitychangedeventhandler");

			return networkavailabilitychangedeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// openreadcompletedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this OpenReadCompletedEventHandler openreadcompletedeventhandler, Object sender, OpenReadCompletedEventArgs e, AsyncCallback callback)
		{
			if(openreadcompletedeventhandler == null) throw new ArgumentNullException("openreadcompletedeventhandler");

			return openreadcompletedeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// openwritecompletedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this OpenWriteCompletedEventHandler openwritecompletedeventhandler, Object sender, OpenWriteCompletedEventArgs e, AsyncCallback callback)
		{
			if(openwritecompletedeventhandler == null) throw new ArgumentNullException("openwritecompletedeventhandler");

			return openwritecompletedeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// playrecordcallback.BeginInvoke(recordType, flags, dataSize, recordData, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this PlayRecordCallback playrecordcallback, EmfPlusRecordType recordType, Int32 flags, Int32 dataSize, IntPtr recordData, AsyncCallback callback)
		{
			if(playrecordcallback == null) throw new ArgumentNullException("playrecordcallback");

			return playrecordcallback.BeginInvoke(recordType, flags, dataSize, recordData, callback, null);
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
		/// progresschangedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ProgressChangedEventHandler progresschangedeventhandler, Object sender, ProgressChangedEventArgs e, AsyncCallback callback)
		{
			if(progresschangedeventhandler == null) throw new ArgumentNullException("progresschangedeventhandler");

			return progresschangedeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
#endif
#if (NETSTANDARD2_0 || NETSTANDARD2_0 || NETSTANDARD1_4 || NETSTANDARD1_3 || NET47)

namespace HSNXT
{
    public static partial class Extensions
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// propertychangingeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this PropertyChangingEventHandler propertychangingeventhandler, Object sender, PropertyChangingEventArgs e, AsyncCallback callback)
		{
			if(propertychangingeventhandler == null) throw new ArgumentNullException("propertychangingeventhandler");

			return propertychangingeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// propertyvaluechangedeventhandler.BeginInvoke(s, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this PropertyValueChangedEventHandler propertyvaluechangedeventhandler, Object s, PropertyValueChangedEventArgs e, AsyncCallback callback)
		{
			if(propertyvaluechangedeventhandler == null) throw new ArgumentNullException("propertyvaluechangedeventhandler");

			return propertyvaluechangedeventhandler.BeginInvoke(s, e, callback, null);
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
		/// propertyvalueuihandler.BeginInvoke(context, propDesc, valueUIItemList, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this PropertyValueUIHandler propertyvalueuihandler, System.ComponentModel.ITypeDescriptorContext context, System.ComponentModel.PropertyDescriptor propDesc, System.Collections.ArrayList valueUIItemList, AsyncCallback callback)
		{
			if(propertyvalueuihandler == null) throw new ArgumentNullException("propertyvalueuihandler");

			return propertyvalueuihandler.BeginInvoke(context, propDesc, valueUIItemList, callback, null);
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
		/// propertyvalueuiiteminvokehandler.BeginInvoke(context, descriptor, invokedItem, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this PropertyValueUIItemInvokeHandler propertyvalueuiiteminvokehandler, System.ComponentModel.ITypeDescriptorContext context, System.ComponentModel.PropertyDescriptor descriptor, PropertyValueUIItem invokedItem, AsyncCallback callback)
		{
			if(propertyvalueuiiteminvokehandler == null) throw new ArgumentNullException("propertyvalueuiiteminvokehandler");

			return propertyvalueuiiteminvokehandler.BeginInvoke(context, descriptor, invokedItem, callback, null);
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
		/// queryaccessibilityhelpeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this QueryAccessibilityHelpEventHandler queryaccessibilityhelpeventhandler, Object sender, QueryAccessibilityHelpEventArgs e, AsyncCallback callback)
		{
			if(queryaccessibilityhelpeventhandler == null) throw new ArgumentNullException("queryaccessibilityhelpeventhandler");

			return queryaccessibilityhelpeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// querypagesettingseventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this QueryPageSettingsEventHandler querypagesettingseventhandler, Object sender, QueryPageSettingsEventArgs e, AsyncCallback callback)
		{
			if(querypagesettingseventhandler == null) throw new ArgumentNullException("querypagesettingseventhandler");

			return querypagesettingseventhandler.BeginInvoke(sender, e, callback, null);
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
		/// retrievevirtualitemeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this RetrieveVirtualItemEventHandler retrievevirtualitemeventhandler, Object sender, RetrieveVirtualItemEventArgs e, AsyncCallback callback)
		{
			if(retrievevirtualitemeventhandler == null) throw new ArgumentNullException("retrievevirtualitemeventhandler");

			return retrievevirtualitemeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// runworkercompletedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this RunWorkerCompletedEventHandler runworkercompletedeventhandler, Object sender, RunWorkerCompletedEventArgs e, AsyncCallback callback)
		{
			if(runworkercompletedeventhandler == null) throw new ArgumentNullException("runworkercompletedeventhandler");

			return runworkercompletedeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// searchforvirtualitemeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this SearchForVirtualItemEventHandler searchforvirtualitemeventhandler, Object sender, SearchForVirtualItemEventArgs e, AsyncCallback callback)
		{
			if(searchforvirtualitemeventhandler == null) throw new ArgumentNullException("searchforvirtualitemeventhandler");

			return searchforvirtualitemeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// selectedgriditemchangedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this SelectedGridItemChangedEventHandler selectedgriditemchangedeventhandler, Object sender, SelectedGridItemChangedEventArgs e, AsyncCallback callback)
		{
			if(selectedgriditemchangedeventhandler == null) throw new ArgumentNullException("selectedgriditemchangedeventhandler");

			return selectedgriditemchangedeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// sendcompletedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this SendCompletedEventHandler sendcompletedeventhandler, Object sender, System.ComponentModel.AsyncCompletedEventArgs e, AsyncCallback callback)
		{
			if(sendcompletedeventhandler == null) throw new ArgumentNullException("sendcompletedeventhandler");

			return sendcompletedeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
#endif
#if (NETSTANDARD2_0 || NETSTANDARD2_0 || NETSTANDARD1_4 || NETSTANDARD1_3 || NET47)

namespace HSNXT
{
    public static partial class Extensions
	{
		/// <summary>
		/// Extends SetBuffer so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// socketasynceventargs.SetBuffer(buffer);
		/// </example>
		/// </summary>
		public static void SetBuffer(this SocketAsyncEventArgs socketasynceventargs, Byte[] buffer)
		{
			if(socketasynceventargs == null) throw new ArgumentNullException("socketasynceventargs");

			if(buffer == null) throw new ArgumentNullException("buffer");

			socketasynceventargs.SetBuffer(buffer, 0, buffer.Length);
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
		/// statementcompletedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this StatementCompletedEventHandler statementcompletedeventhandler, Object sender, StatementCompletedEventArgs e, AsyncCallback callback)
		{
			if(statementcompletedeventhandler == null) throw new ArgumentNullException("statementcompletedeventhandler");

			return statementcompletedeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// statusbardrawitemeventhandler.BeginInvoke(sender, sbdevent, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this StatusBarDrawItemEventHandler statusbardrawitemeventhandler, Object sender, StatusBarDrawItemEventArgs sbdevent, AsyncCallback callback)
		{
			if(statusbardrawitemeventhandler == null) throw new ArgumentNullException("statusbardrawitemeventhandler");

			return statusbardrawitemeventhandler.BeginInvoke(sender, sbdevent, callback, null);
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
		/// statusbarpanelclickeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this StatusBarPanelClickEventHandler statusbarpanelclickeventhandler, Object sender, StatusBarPanelClickEventArgs e, AsyncCallback callback)
		{
			if(statusbarpanelclickeventhandler == null) throw new ArgumentNullException("statusbarpanelclickeventhandler");

			return statusbarpanelclickeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// tablelayoutcellpainteventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this TableLayoutCellPaintEventHandler tablelayoutcellpainteventhandler, Object sender, TableLayoutCellPaintEventArgs e, AsyncCallback callback)
		{
			if(tablelayoutcellpainteventhandler == null) throw new ArgumentNullException("tablelayoutcellpainteventhandler");

			return tablelayoutcellpainteventhandler.BeginInvoke(sender, e, callback, null);
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
		/// toolbarbuttonclickeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ToolBarButtonClickEventHandler toolbarbuttonclickeventhandler, Object sender, ToolBarButtonClickEventArgs e, AsyncCallback callback)
		{
			if(toolbarbuttonclickeventhandler == null) throw new ArgumentNullException("toolbarbuttonclickeventhandler");

			return toolbarbuttonclickeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// toolboxcomponentscreatedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ToolboxComponentsCreatedEventHandler toolboxcomponentscreatedeventhandler, Object sender, ToolboxComponentsCreatedEventArgs e, AsyncCallback callback)
		{
			if(toolboxcomponentscreatedeventhandler == null) throw new ArgumentNullException("toolboxcomponentscreatedeventhandler");

			return toolboxcomponentscreatedeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// toolboxcomponentscreatingeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ToolboxComponentsCreatingEventHandler toolboxcomponentscreatingeventhandler, Object sender, ToolboxComponentsCreatingEventArgs e, AsyncCallback callback)
		{
			if(toolboxcomponentscreatingeventhandler == null) throw new ArgumentNullException("toolboxcomponentscreatingeventhandler");

			return toolboxcomponentscreatingeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// toolstriparrowrendereventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ToolStripArrowRenderEventHandler toolstriparrowrendereventhandler, Object sender, ToolStripArrowRenderEventArgs e, AsyncCallback callback)
		{
			if(toolstriparrowrendereventhandler == null) throw new ArgumentNullException("toolstriparrowrendereventhandler");

			return toolstriparrowrendereventhandler.BeginInvoke(sender, e, callback, null);
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
		/// toolstripcontentpanelrendereventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ToolStripContentPanelRenderEventHandler toolstripcontentpanelrendereventhandler, Object sender, ToolStripContentPanelRenderEventArgs e, AsyncCallback callback)
		{
			if(toolstripcontentpanelrendereventhandler == null) throw new ArgumentNullException("toolstripcontentpanelrendereventhandler");

			return toolstripcontentpanelrendereventhandler.BeginInvoke(sender, e, callback, null);
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
		/// toolstripdropdownclosedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ToolStripDropDownClosedEventHandler toolstripdropdownclosedeventhandler, Object sender, ToolStripDropDownClosedEventArgs e, AsyncCallback callback)
		{
			if(toolstripdropdownclosedeventhandler == null) throw new ArgumentNullException("toolstripdropdownclosedeventhandler");

			return toolstripdropdownclosedeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// toolstripdropdownclosingeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ToolStripDropDownClosingEventHandler toolstripdropdownclosingeventhandler, Object sender, ToolStripDropDownClosingEventArgs e, AsyncCallback callback)
		{
			if(toolstripdropdownclosingeventhandler == null) throw new ArgumentNullException("toolstripdropdownclosingeventhandler");

			return toolstripdropdownclosingeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// toolstripgriprendereventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ToolStripGripRenderEventHandler toolstripgriprendereventhandler, Object sender, ToolStripGripRenderEventArgs e, AsyncCallback callback)
		{
			if(toolstripgriprendereventhandler == null) throw new ArgumentNullException("toolstripgriprendereventhandler");

			return toolstripgriprendereventhandler.BeginInvoke(sender, e, callback, null);
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
		/// toolstripitemclickedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ToolStripItemClickedEventHandler toolstripitemclickedeventhandler, Object sender, ToolStripItemClickedEventArgs e, AsyncCallback callback)
		{
			if(toolstripitemclickedeventhandler == null) throw new ArgumentNullException("toolstripitemclickedeventhandler");

			return toolstripitemclickedeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// toolstripitemimagerendereventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ToolStripItemImageRenderEventHandler toolstripitemimagerendereventhandler, Object sender, ToolStripItemImageRenderEventArgs e, AsyncCallback callback)
		{
			if(toolstripitemimagerendereventhandler == null) throw new ArgumentNullException("toolstripitemimagerendereventhandler");

			return toolstripitemimagerendereventhandler.BeginInvoke(sender, e, callback, null);
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
		/// toolstripitemrendereventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ToolStripItemRenderEventHandler toolstripitemrendereventhandler, Object sender, ToolStripItemRenderEventArgs e, AsyncCallback callback)
		{
			if(toolstripitemrendereventhandler == null) throw new ArgumentNullException("toolstripitemrendereventhandler");

			return toolstripitemrendereventhandler.BeginInvoke(sender, e, callback, null);
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
		/// toolstripitemtextrendereventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ToolStripItemTextRenderEventHandler toolstripitemtextrendereventhandler, Object sender, ToolStripItemTextRenderEventArgs e, AsyncCallback callback)
		{
			if(toolstripitemtextrendereventhandler == null) throw new ArgumentNullException("toolstripitemtextrendereventhandler");

			return toolstripitemtextrendereventhandler.BeginInvoke(sender, e, callback, null);
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
		/// toolstrippanelrendereventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ToolStripPanelRenderEventHandler toolstrippanelrendereventhandler, Object sender, ToolStripPanelRenderEventArgs e, AsyncCallback callback)
		{
			if(toolstrippanelrendereventhandler == null) throw new ArgumentNullException("toolstrippanelrendereventhandler");

			return toolstrippanelrendereventhandler.BeginInvoke(sender, e, callback, null);
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
		/// toolstripseparatorrendereventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ToolStripSeparatorRenderEventHandler toolstripseparatorrendereventhandler, Object sender, ToolStripSeparatorRenderEventArgs e, AsyncCallback callback)
		{
			if(toolstripseparatorrendereventhandler == null) throw new ArgumentNullException("toolstripseparatorrendereventhandler");

			return toolstripseparatorrendereventhandler.BeginInvoke(sender, e, callback, null);
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
		/// treenodemouseclickeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this TreeNodeMouseClickEventHandler treenodemouseclickeventhandler, Object sender, TreeNodeMouseClickEventArgs e, AsyncCallback callback)
		{
			if(treenodemouseclickeventhandler == null) throw new ArgumentNullException("treenodemouseclickeventhandler");

			return treenodemouseclickeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// treenodemousehovereventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this TreeNodeMouseHoverEventHandler treenodemousehovereventhandler, Object sender, TreeNodeMouseHoverEventArgs e, AsyncCallback callback)
		{
			if(treenodemousehovereventhandler == null) throw new ArgumentNullException("treenodemousehovereventhandler");

			return treenodemousehovereventhandler.BeginInvoke(sender, e, callback, null);
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
		/// Extends CreateInstance so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// typedescriptionprovider.CreateInstance&lt;int&gt;(provider, argTypes, args);
		/// </example>
		/// </summary>
		public static T CreateInstance<T>(this TypeDescriptionProvider typedescriptionprovider, IServiceProvider provider, Type[] argTypes, Object[] args)
		{
			if(typedescriptionprovider == null) throw new ArgumentNullException("typedescriptionprovider");

			return (T)typedescriptionprovider.CreateInstance(provider, typeof(T), argTypes, args);
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
		/// unreferencedobjecteventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this UnreferencedObjectEventHandler unreferencedobjecteventhandler, Object sender, UnreferencedObjectEventArgs e, AsyncCallback callback)
		{
			if(unreferencedobjecteventhandler == null) throw new ArgumentNullException("unreferencedobjecteventhandler");

			return unreferencedobjecteventhandler.BeginInvoke(sender, e, callback, null);
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
		/// uploaddatacompletedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this UploadDataCompletedEventHandler uploaddatacompletedeventhandler, Object sender, UploadDataCompletedEventArgs e, AsyncCallback callback)
		{
			if(uploaddatacompletedeventhandler == null) throw new ArgumentNullException("uploaddatacompletedeventhandler");

			return uploaddatacompletedeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// uploadfilecompletedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this UploadFileCompletedEventHandler uploadfilecompletedeventhandler, Object sender, UploadFileCompletedEventArgs e, AsyncCallback callback)
		{
			if(uploadfilecompletedeventhandler == null) throw new ArgumentNullException("uploadfilecompletedeventhandler");

			return uploadfilecompletedeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// uploadprogresschangedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this UploadProgressChangedEventHandler uploadprogresschangedeventhandler, Object sender, UploadProgressChangedEventArgs e, AsyncCallback callback)
		{
			if(uploadprogresschangedeventhandler == null) throw new ArgumentNullException("uploadprogresschangedeventhandler");

			return uploadprogresschangedeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// uploadstringcompletedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this UploadStringCompletedEventHandler uploadstringcompletedeventhandler, Object sender, UploadStringCompletedEventArgs e, AsyncCallback callback)
		{
			if(uploadstringcompletedeventhandler == null) throw new ArgumentNullException("uploadstringcompletedeventhandler");

			return uploadstringcompletedeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// uploadvaluescompletedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this UploadValuesCompletedEventHandler uploadvaluescompletedeventhandler, Object sender, UploadValuesCompletedEventArgs e, AsyncCallback callback)
		{
			if(uploadvaluescompletedeventhandler == null) throw new ArgumentNullException("uploadvaluescompletedeventhandler");

			return uploadvaluescompletedeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// webbrowserdocumentcompletedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this WebBrowserDocumentCompletedEventHandler webbrowserdocumentcompletedeventhandler, Object sender, WebBrowserDocumentCompletedEventArgs e, AsyncCallback callback)
		{
			if(webbrowserdocumentcompletedeventhandler == null) throw new ArgumentNullException("webbrowserdocumentcompletedeventhandler");

			return webbrowserdocumentcompletedeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// webbrowsernavigatedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this WebBrowserNavigatedEventHandler webbrowsernavigatedeventhandler, Object sender, WebBrowserNavigatedEventArgs e, AsyncCallback callback)
		{
			if(webbrowsernavigatedeventhandler == null) throw new ArgumentNullException("webbrowsernavigatedeventhandler");

			return webbrowsernavigatedeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// webbrowsernavigatingeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this WebBrowserNavigatingEventHandler webbrowsernavigatingeventhandler, Object sender, WebBrowserNavigatingEventArgs e, AsyncCallback callback)
		{
			if(webbrowsernavigatingeventhandler == null) throw new ArgumentNullException("webbrowsernavigatingeventhandler");

			return webbrowsernavigatingeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// webbrowserprogresschangedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this WebBrowserProgressChangedEventHandler webbrowserprogresschangedeventhandler, Object sender, WebBrowserProgressChangedEventArgs e, AsyncCallback callback)
		{
			if(webbrowserprogresschangedeventhandler == null) throw new ArgumentNullException("webbrowserprogresschangedeventhandler");

			return webbrowserprogresschangedeventhandler.BeginInvoke(sender, e, callback, null);
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
		/// xmlserializationcollectionfixupcallback.BeginInvoke(collection, collectionItems, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this XmlSerializationCollectionFixupCallback xmlserializationcollectionfixupcallback, Object collection, Object collectionItems, AsyncCallback callback)
		{
			if(xmlserializationcollectionfixupcallback == null) throw new ArgumentNullException("xmlserializationcollectionfixupcallback");

			return xmlserializationcollectionfixupcallback.BeginInvoke(collection, collectionItems, callback, null);
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
		/// xsltmessageencounteredeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this XsltMessageEncounteredEventHandler xsltmessageencounteredeventhandler, Object sender, XsltMessageEncounteredEventArgs e, AsyncCallback callback)
		{
			if(xsltmessageencounteredeventhandler == null) throw new ArgumentNullException("xsltmessageencounteredeventhandler");

			return xsltmessageencounteredeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
#endif