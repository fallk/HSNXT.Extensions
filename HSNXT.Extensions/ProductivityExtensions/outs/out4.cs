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
        /// Extends BeginInvoke&lt;T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16&gt; so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// action.BeginInvoke&lt;T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16&gt;(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 arg1, T2 arg2,
            T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13,
            T14 arg14, T15 arg15, T16 arg16, AsyncCallback callback)
        {
            if (action == null) throw new ArgumentNullException("action");

            return action.BeginInvoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13,
                arg14, arg15, arg16, callback, null);
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
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// arrayconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this ArrayConverter arrayconverter, ITypeDescriptorContext context,
            System.Globalization.CultureInfo culture, Object value)
        {
            if (arrayconverter == null) throw new ArgumentNullException("arrayconverter");

            return (T) arrayconverter.ConvertTo(context, culture, value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this ArrayConverter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
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
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// basenumberconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this BaseNumberConverter basenumberconverter, ITypeDescriptorContext context,
            System.Globalization.CultureInfo culture, Object value)
        {
            if (basenumberconverter == null) throw new ArgumentNullException("basenumberconverter");

            return (T) basenumberconverter.ConvertTo(context, culture, value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this BaseNumberConverter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NETSTANDARD1_2 || NETSTANDARD1_1 || NETSTANDARD1_0 || NET47)

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends Read so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// binaryreader.Read(buffer);
        /// </example>
        /// </summary>
        public static Int32 Read(this BinaryReader binaryreader, Char[] buffer)
        {
            if (binaryreader == null) throw new ArgumentNullException("binaryreader");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return binaryreader.Read(buffer, 0, buffer.Length);
        }

        /// <summary>
        /// Extends Read so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// binaryreader.Read(buffer);
        /// </example>
        /// </summary>
        public static Int32 Read(this BinaryReader binaryreader, Byte[] buffer)
        {
            if (binaryreader == null) throw new ArgumentNullException("binaryreader");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return binaryreader.Read(buffer, 0, buffer.Length);
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
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this BooleanConverter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this BooleanConverter typeconverter, ITypeDescriptorContext context,
            System.Globalization.CultureInfo culture, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(context, culture, value, typeof(T));
        }
    }
}
#endif

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Converts a byte array into a continuous hex string
        /// </summary>
        /// <param name="buffer">buffer that contains the bytes</param>
        /// <param name="offset">offset into the buffer to start</param>
        /// <param name="length">how many types to process</param>
        /// <returns>string of hex characters</returns>
        /// <exception cref="IndexOutOfRangeException">if <paramref name="offset"/> is less than 0 or <paramref name="length"/> is longer than the buffer</exception>
        public static string AsHexString(this byte[] buffer, int offset, int length)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int lineOctet = 0;
            for (int i = offset; i < length; ++i)
            {
                byte b = buffer[i];
                if (lineOctet > 16)
                {
                    stringBuilder.Append(Environment.NewLine);
                    lineOctet = 0;
                }

                stringBuilder.Append(string.Format("{0} ", b.ToString("X2", CultureInfo.CurrentCulture)));
            }

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Converts a byte array into a continuous hex string
        /// </summary>
        /// <param name="buffer">buffer that contains the bytes</param>
        /// <returns>string of hex characters</returns>
        public static string AsHexString(this byte[] buffer)
        {
            return AsHexString(buffer, 0, buffer.Length);
        }
    }
}
#if (NETSTANDARD2_0 || NET47)

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// basenumberconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this ByteConverter basenumberconverter, ITypeDescriptorContext context,
            System.Globalization.CultureInfo culture, Object value)
        {
            if (basenumberconverter == null) throw new ArgumentNullException("basenumberconverter");

            return (T) basenumberconverter.ConvertTo(context, culture, value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this ByteConverter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
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
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// charconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this CharConverter charconverter, ITypeDescriptorContext context,
            System.Globalization.CultureInfo culture, Object value)
        {
            if (charconverter == null) throw new ArgumentNullException("charconverter");

            return (T) charconverter.ConvertTo(context, culture, value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this CharConverter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
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
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// collectionconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this CollectionConverter collectionconverter, ITypeDescriptorContext context,
            System.Globalization.CultureInfo culture, Object value)
        {
            if (collectionconverter == null) throw new ArgumentNullException("collectionconverter");

            return (T) collectionconverter.ConvertTo(context, culture, value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this CollectionConverter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
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
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this ColorConverter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// colorconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this ColorConverter colorconverter,
            System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture,
            Object value)
        {
            if (colorconverter == null) throw new ArgumentNullException("colorconverter");

            return (T) colorconverter.ConvertTo(context, culture, value, typeof(T));
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
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// typeconverter.ConvertTo&lt;int&gt;(value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this ColumnHeaderConverter typeconverter, Object value)
		{
			if(typeconverter == null) throw new ArgumentNullException("typeconverter");

			return (T)typeconverter.ConvertTo(value, typeof(T));
		}

		/// <summary>
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// columnheaderconverter.ConvertTo&lt;int&gt;(context, culture, value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this ColumnHeaderConverter columnheaderconverter, System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, Object value)
		{
			if(columnheaderconverter == null) throw new ArgumentNullException("columnheaderconverter");

			return (T)columnheaderconverter.ConvertTo(context, culture, value, typeof(T));
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
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// referenceconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this ComponentConverter referenceconverter, ITypeDescriptorContext context,
            System.Globalization.CultureInfo culture, Object value)
        {
            if (referenceconverter == null) throw new ArgumentNullException("referenceconverter");

            return (T) referenceconverter.ConvertTo(context, culture, value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this ComponentConverter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
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
		/// Extends TransformBlock so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// cryptoapitransform.TransformBlock(inputBuffer, outputBuffer, outputOffset);
		/// </example>
		/// </summary>
		public static Int32 TransformBlock(this CryptoAPITransform cryptoapitransform, Byte[] inputBuffer, Byte[] outputBuffer, Int32 outputOffset)
		{
			if(cryptoapitransform == null) throw new ArgumentNullException("cryptoapitransform");

			if(inputBuffer == null) throw new ArgumentNullException("inputBuffer");

			return cryptoapitransform.TransformBlock(inputBuffer, 0, inputBuffer.Length, outputBuffer, outputOffset);
		}

		/// <summary>
		/// Extends TransformFinalBlock so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// cryptoapitransform.TransformFinalBlock(inputBuffer);
		/// </example>
		/// </summary>
		public static Byte[] TransformFinalBlock(this CryptoAPITransform cryptoapitransform, Byte[] inputBuffer)
		{
			if(cryptoapitransform == null) throw new ArgumentNullException("cryptoapitransform");

			if(inputBuffer == null) throw new ArgumentNullException("inputBuffer");

			return cryptoapitransform.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);
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
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// cultureinfoconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this CultureInfoConverter cultureinfoconverter, ITypeDescriptorContext context,
            System.Globalization.CultureInfo culture, Object value)
        {
            if (cultureinfoconverter == null) throw new ArgumentNullException("cultureinfoconverter");

            return (T) cultureinfoconverter.ConvertTo(context, culture, value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this CultureInfoConverter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
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
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// typeconverter.ConvertTo&lt;int&gt;(value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this CursorConverter typeconverter, Object value)
		{
			if(typeconverter == null) throw new ArgumentNullException("typeconverter");

			return (T)typeconverter.ConvertTo(value, typeof(T));
		}

		/// <summary>
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// cursorconverter.ConvertTo&lt;int&gt;(context, culture, value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this CursorConverter cursorconverter, System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, Object value)
		{
			if(cursorconverter == null) throw new ArgumentNullException("cursorconverter");

			return (T)cursorconverter.ConvertTo(context, culture, value, typeof(T));
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
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// typeconverter.ConvertTo&lt;int&gt;(value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this DataGridPreferredColumnWidthTypeConverter typeconverter, Object value)
		{
			if(typeconverter == null) throw new ArgumentNullException("typeconverter");

			return (T)typeconverter.ConvertTo(value, typeof(T));
		}

		/// <summary>
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// datagridpreferredcolumnwidthtypeconverter.ConvertTo&lt;int&gt;(context, culture, value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this DataGridPreferredColumnWidthTypeConverter datagridpreferredcolumnwidthtypeconverter, System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, Object value)
		{
			if(datagridpreferredcolumnwidthtypeconverter == null) throw new ArgumentNullException("datagridpreferredcolumnwidthtypeconverter");

			return (T)datagridpreferredcolumnwidthtypeconverter.ConvertTo(context, culture, value, typeof(T));
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
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// typeconverter.ConvertTo&lt;int&gt;(value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this DataGridViewCellStyleConverter typeconverter, Object value)
		{
			if(typeconverter == null) throw new ArgumentNullException("typeconverter");

			return (T)typeconverter.ConvertTo(value, typeof(T));
		}

		/// <summary>
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// datagridviewcellstyleconverter.ConvertTo&lt;int&gt;(context, culture, value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this DataGridViewCellStyleConverter datagridviewcellstyleconverter, System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, Object value)
		{
			if(datagridviewcellstyleconverter == null) throw new ArgumentNullException("datagridviewcellstyleconverter");

			return (T)datagridviewcellstyleconverter.ConvertTo(context, culture, value, typeof(T));
		}

	}
}
#endif//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
#if (NETSTANDARD2_0 || NET47)
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// datetimeconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this DateTimeConverter datetimeconverter, ITypeDescriptorContext context,
            System.Globalization.CultureInfo culture, Object value)
        {
            if (datetimeconverter == null) throw new ArgumentNullException("datetimeconverter");

            return (T) datetimeconverter.ConvertTo(context, culture, value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this DateTimeConverter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
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
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// datetimeoffsetconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this DateTimeOffsetConverter datetimeoffsetconverter,
            ITypeDescriptorContext context, System.Globalization.CultureInfo culture, Object value)
        {
            if (datetimeoffsetconverter == null) throw new ArgumentNullException("datetimeoffsetconverter");

            return (T) datetimeoffsetconverter.ConvertTo(context, culture, value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this DateTimeOffsetConverter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
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
        /// Extends GetBytes so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// dbdatareader.GetBytes(ordinal, dataOffset, buffer);
        /// </example>
        /// </summary>
        public static Int64 GetBytes(this DbDataReader dbdatareader, Int32 ordinal, Int64 dataOffset, Byte[] buffer)
        {
            if (dbdatareader == null) throw new ArgumentNullException("dbdatareader");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return dbdatareader.GetBytes(ordinal, dataOffset, buffer, 0, buffer.Length);
        }

        /// <summary>
        /// Extends GetChars so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// dbdatareader.GetChars(ordinal, dataOffset, buffer);
        /// </example>
        /// </summary>
        public static Int64 GetChars(this DbDataReader dbdatareader, Int32 ordinal, Int64 dataOffset, Char[] buffer)
        {
            if (dbdatareader == null) throw new ArgumentNullException("dbdatareader");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return dbdatareader.GetChars(ordinal, dataOffset, buffer, 0, buffer.Length);
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
        /// Extends GetBytes so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// dbdatarecord.GetBytes(i, dataIndex, buffer);
        /// </example>
        /// </summary>
        public static Int64 GetBytes(this DbDataRecord dbdatarecord, Int32 i, Int64 dataIndex, Byte[] buffer)
        {
            if (dbdatarecord == null) throw new ArgumentNullException("dbdatarecord");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return dbdatarecord.GetBytes(i, dataIndex, buffer, 0, buffer.Length);
        }

        /// <summary>
        /// Extends GetChars so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// dbdatarecord.GetChars(i, dataIndex, buffer);
        /// </example>
        /// </summary>
        public static Int64 GetChars(this DbDataRecord dbdatarecord, Int32 i, Int64 dataIndex, Char[] buffer)
        {
            if (dbdatarecord == null) throw new ArgumentNullException("dbdatarecord");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return dbdatarecord.GetChars(i, dataIndex, buffer, 0, buffer.Length);
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
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// decimalconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this DecimalConverter decimalconverter, ITypeDescriptorContext context,
            System.Globalization.CultureInfo culture, Object value)
        {
            if (decimalconverter == null) throw new ArgumentNullException("decimalconverter");

            return (T) decimalconverter.ConvertTo(context, culture, value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this DecimalConverter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
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
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// basenumberconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this DoubleConverter basenumberconverter, ITypeDescriptorContext context,
            System.Globalization.CultureInfo culture, Object value)
        {
            if (basenumberconverter == null) throw new ArgumentNullException("basenumberconverter");

            return (T) basenumberconverter.ConvertTo(context, culture, value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this DoubleConverter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
        }
    }
}
#endif

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends GetBytes so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// encoding.GetBytes(chars, bytes, byteIndex);
        /// </example>
        /// </summary>
        public static Int32 GetBytes(this Encoding encoding, Char[] chars, Byte[] bytes, Int32 byteIndex)
        {
            if (encoding == null) throw new ArgumentNullException("encoding");

            if (chars == null) throw new ArgumentNullException("chars");

            return encoding.GetBytes(chars, 0, chars.Length, bytes, byteIndex);
        }

        /// <summary>
        /// Extends GetChars so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// encoding.GetChars(bytes, chars, charIndex);
        /// </example>
        /// </summary>
        public static Int32 GetChars(this Encoding encoding, Byte[] bytes, Char[] chars, Int32 charIndex)
        {
            if (encoding == null) throw new ArgumentNullException("encoding");

            if (bytes == null) throw new ArgumentNullException("bytes");

            return encoding.GetChars(bytes, 0, bytes.Length, chars, charIndex);
        }
    }
}
#if (NETSTANDARD2_0 || NET47)

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// enumconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this EnumConverter enumconverter, ITypeDescriptorContext context,
            System.Globalization.CultureInfo culture, Object value)
        {
            if (enumconverter == null) throw new ArgumentNullException("enumconverter");

            return (T) enumconverter.ConvertTo(context, culture, value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this EnumConverter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
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
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this ExpandableObjectConverter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this ExpandableObjectConverter typeconverter, ITypeDescriptorContext context,
            System.Globalization.CultureInfo culture, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(context, culture, value, typeof(T));
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NETSTANDARD1_2 || NETSTANDARD1_1 || NETSTANDARD1_0 || NET47)

#if (NETSTANDARD2_0 || NET47)

#endif

namespace HSNXT
{
    public static partial class Extensions
    {
//#if NETSTANDARD1_0
        /// <summary>
        /// Converts the body of the lambda expression into the <see cref="T:System.Reflection.PropertyInfo" /> referenced by it.
        /// </summary>
        public static PropertyInfo ToPropertyInfo(this LambdaExpression expression)
        {
            var memberExpression = expression.Body as MemberExpression;
            var propertyInfo = memberExpression?.Member as PropertyInfo;

            if (propertyInfo == null) throw new ArgumentException(expression.ToString());

            return propertyInfo;
        }
//#endif

#if (NETSTANDARD2_0 || NET47)
        /// <summary>
        /// Converts the body of the lambda expression into the <see cref="T:System.Reflection.PropertyInfo" /> referenced by it.
        /// </summary>
        public static PropertyDescriptor ToPropertyDescriptor(this LambdaExpression expression)
        {
            var memberExpression = expression.Body as MemberExpression;
            var propertyInfo = memberExpression?.Member as PropertyInfo;

            if (propertyInfo == null)
            {
                throw new ArgumentException(expression.ToString());
            }

            var type = propertyInfo.DeclaringType;
            return TypeDescriptor.GetProperties(type)[propertyInfo.Name];
        }
#endif
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this ExtendedProtectionPolicyTypeConverter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// extendedprotectionpolicytypeconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this ExtendedProtectionPolicyTypeConverter extendedprotectionpolicytypeconverter,
            System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture,
            Object value)
        {
            if (extendedprotectionpolicytypeconverter == null)
                throw new ArgumentNullException("extendedprotectionpolicytypeconverter");

            return (T) extendedprotectionpolicytypeconverter.ConvertTo(context, culture, value, typeof(T));
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
        /// Extends BeginGetResponse so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// filewebrequest.BeginGetResponse(callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginGetResponse(this FileWebRequest filewebrequest, AsyncCallback callback)
        {
            if (filewebrequest == null) throw new ArgumentNullException("filewebrequest");

            return filewebrequest.BeginGetResponse(callback, null);
        }

        /// <summary>
        /// Extends BeginGetRequestStream so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// filewebrequest.BeginGetRequestStream(callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginGetRequestStream(this FileWebRequest filewebrequest, AsyncCallback callback)
        {
            if (filewebrequest == null) throw new ArgumentNullException("filewebrequest");

            return filewebrequest.BeginGetRequestStream(callback, null);
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
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this FontConverter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// fontconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this FontConverter fontconverter,
            System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture,
            Object value)
        {
            if (fontconverter == null) throw new ArgumentNullException("fontconverter");

            return (T) fontconverter.ConvertTo(context, culture, value, typeof(T));
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
        /// Extends TransformBlock so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// frombase64transform.TransformBlock(inputBuffer, outputBuffer, outputOffset);
        /// </example>
        /// </summary>
        public static Int32 TransformBlock(this FromBase64Transform frombase64transform, Byte[] inputBuffer,
            Byte[] outputBuffer, Int32 outputOffset)
        {
            if (frombase64transform == null) throw new ArgumentNullException("frombase64transform");

            if (inputBuffer == null) throw new ArgumentNullException("inputBuffer");

            return frombase64transform.TransformBlock(inputBuffer, 0, inputBuffer.Length, outputBuffer, outputOffset);
        }

        /// <summary>
        /// Extends TransformFinalBlock so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// frombase64transform.TransformFinalBlock(inputBuffer);
        /// </example>
        /// </summary>
        public static Byte[] TransformFinalBlock(this FromBase64Transform frombase64transform, Byte[] inputBuffer)
        {
            if (frombase64transform == null) throw new ArgumentNullException("frombase64transform");

            if (inputBuffer == null) throw new ArgumentNullException("inputBuffer");

            return frombase64transform.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);
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
        /// Extends BeginGetResponse so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// ftpwebrequest.BeginGetResponse(callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginGetResponse(this FtpWebRequest ftpwebrequest, AsyncCallback callback)
        {
            if (ftpwebrequest == null) throw new ArgumentNullException("ftpwebrequest");

            return ftpwebrequest.BeginGetResponse(callback, null);
        }

        /// <summary>
        /// Extends BeginGetRequestStream so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// ftpwebrequest.BeginGetRequestStream(callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginGetRequestStream(this FtpWebRequest ftpwebrequest, AsyncCallback callback)
        {
            if (ftpwebrequest == null) throw new ArgumentNullException("ftpwebrequest");

            return ftpwebrequest.BeginGetRequestStream(callback, null);
        }
    }
}
#endif

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginInvoke&lt;T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult&gt; so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// func.BeginInvoke&lt;T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult&gt;(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult
            BeginInvoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
                this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 arg1,
                T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12,
                T13 arg13, T14 arg14, T15 arg15, T16 arg16, AsyncCallback callback)
        {
            if (func == null) throw new ArgumentNullException("func");

            return func.BeginInvoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13,
                arg14, arg15, arg16, callback, null);
        }
    }
}
#if (NETSTANDARD2_0 || NET47)

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// guidconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this GuidConverter guidconverter, ITypeDescriptorContext context,
            System.Globalization.CultureInfo culture, Object value)
        {
            if (guidconverter == null) throw new ArgumentNullException("guidconverter");

            return (T) guidconverter.ConvertTo(context, culture, value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this GuidConverter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
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
        /// Extends BeginGetRequestStream so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// httpwebrequest.BeginGetRequestStream(callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginGetRequestStream(this HttpWebRequest httpwebrequest, AsyncCallback callback)
        {
            if (httpwebrequest == null) throw new ArgumentNullException("httpwebrequest");

            return httpwebrequest.BeginGetRequestStream(callback, null);
        }

        /// <summary>
        /// Extends BeginGetResponse so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// httpwebrequest.BeginGetResponse(callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginGetResponse(this HttpWebRequest httpwebrequest, AsyncCallback callback)
        {
            if (httpwebrequest == null) throw new ArgumentNullException("httpwebrequest");

            return httpwebrequest.BeginGetResponse(callback, null);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)

namespace HSNXT
{
    public static partial class Extensions
    {
#pragma warning disable CS0618 // 'IComNativeDescriptorHandler' is obsolete: 'This interface has been deprecated. Add a TypeDescriptionProvider to handle type TypeDescriptor.ComObjectType instead.  http://go.microsoft.com/fwlink/?linkid=14202'
        /// <summary>
        /// Extends GetEditor so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// icomnativedescriptorhandler.GetEditor&lt;int&gt;(component);
        /// </example>
        /// </summary>
        public static T GetEditor<T>(this IComNativeDescriptorHandler icomnativedescriptorhandler, Object component)
#pragma warning restore CS0618 // 'IComNativeDescriptorHandler' is obsolete: 'This interface has been deprecated. Add a TypeDescriptionProvider to handle type TypeDescriptor.ComObjectType instead.  http://go.microsoft.com/fwlink/?linkid=14202'
        {
            if (icomnativedescriptorhandler == null) throw new ArgumentNullException("icomnativedescriptorhandler");

            return (T) icomnativedescriptorhandler.GetEditor(component, typeof(T));
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
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this IconConverter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// iconconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this IconConverter iconconverter,
            System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture,
            Object value)
        {
            if (iconconverter == null) throw new ArgumentNullException("iconconverter");

            return (T) iconconverter.ConvertTo(context, culture, value, typeof(T));
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
        /// Extends TransformBlock so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// icryptotransform.TransformBlock(inputBuffer, outputBuffer, outputOffset);
        /// </example>
        /// </summary>
        public static Int32 TransformBlock(this ICryptoTransform icryptotransform, Byte[] inputBuffer,
            Byte[] outputBuffer, Int32 outputOffset)
        {
            if (icryptotransform == null) throw new ArgumentNullException("icryptotransform");

            if (inputBuffer == null) throw new ArgumentNullException("inputBuffer");

            return icryptotransform.TransformBlock(inputBuffer, 0, inputBuffer.Length, outputBuffer, outputOffset);
        }

        /// <summary>
        /// Extends TransformFinalBlock so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// icryptotransform.TransformFinalBlock(inputBuffer);
        /// </example>
        /// </summary>
        public static Byte[] TransformFinalBlock(this ICryptoTransform icryptotransform, Byte[] inputBuffer)
        {
            if (icryptotransform == null) throw new ArgumentNullException("icryptotransform");

            if (inputBuffer == null) throw new ArgumentNullException("inputBuffer");

            return icryptotransform.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);
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
        /// Extends GetBytes so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// idatarecord.GetBytes(i, fieldOffset, buffer);
        /// </example>
        /// </summary>
        public static Int64 GetBytes(this IDataRecord idatarecord, Int32 i, Int64 fieldOffset, Byte[] buffer)
        {
            if (idatarecord == null) throw new ArgumentNullException("idatarecord");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return idatarecord.GetBytes(i, fieldOffset, buffer, 0, buffer.Length);
        }

        /// <summary>
        /// Extends GetChars so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// idatarecord.GetChars(i, fieldoffset, buffer);
        /// </example>
        /// </summary>
        public static Int64 GetChars(this IDataRecord idatarecord, Int32 i, Int64 fieldoffset, Char[] buffer)
        {
            if (idatarecord == null) throw new ArgumentNullException("idatarecord");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return idatarecord.GetChars(i, fieldoffset, buffer, 0, buffer.Length);
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
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this ImageConverter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// imageconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this ImageConverter imageconverter,
            System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture,
            Object value)
        {
            if (imageconverter == null) throw new ArgumentNullException("imageconverter");

            return (T) imageconverter.ConvertTo(context, culture, value, typeof(T));
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
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this ImageFormatConverter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// imageformatconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this ImageFormatConverter imageformatconverter,
            System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture,
            Object value)
        {
            if (imageformatconverter == null) throw new ArgumentNullException("imageformatconverter");

            return (T) imageformatconverter.ConvertTo(context, culture, value, typeof(T));
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
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// typeconverter.ConvertTo&lt;int&gt;(value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this ImageIndexConverter typeconverter, Object value)
		{
			if(typeconverter == null) throw new ArgumentNullException("typeconverter");

			return (T)typeconverter.ConvertTo(value, typeof(T));
		}

		/// <summary>
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// imageindexconverter.ConvertTo&lt;int&gt;(context, culture, value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this ImageIndexConverter imageindexconverter, System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, Object value)
		{
			if(imageindexconverter == null) throw new ArgumentNullException("imageindexconverter");

			return (T)imageindexconverter.ConvertTo(context, culture, value, typeof(T));
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
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// typeconverter.ConvertTo&lt;int&gt;(value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this ImageKeyConverter typeconverter, Object value)
		{
			if(typeconverter == null) throw new ArgumentNullException("typeconverter");

			return (T)typeconverter.ConvertTo(value, typeof(T));
		}

		/// <summary>
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// imagekeyconverter.ConvertTo&lt;int&gt;(context, culture, value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this ImageKeyConverter imagekeyconverter, System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, Object value)
		{
			if(imagekeyconverter == null) throw new ArgumentNullException("imagekeyconverter");

			return (T)imagekeyconverter.ConvertTo(context, culture, value, typeof(T));
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
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// basenumberconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this Int16Converter basenumberconverter, ITypeDescriptorContext context,
            System.Globalization.CultureInfo culture, Object value)
        {
            if (basenumberconverter == null) throw new ArgumentNullException("basenumberconverter");

            return (T) basenumberconverter.ConvertTo(context, culture, value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this Int16Converter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
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
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// basenumberconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this Int32Converter basenumberconverter, ITypeDescriptorContext context,
            System.Globalization.CultureInfo culture, Object value)
        {
            if (basenumberconverter == null) throw new ArgumentNullException("basenumberconverter");

            return (T) basenumberconverter.ConvertTo(context, culture, value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this Int32Converter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
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
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// basenumberconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this Int64Converter basenumberconverter, ITypeDescriptorContext context,
            System.Globalization.CultureInfo culture, Object value)
        {
            if (basenumberconverter == null) throw new ArgumentNullException("basenumberconverter");

            return (T) basenumberconverter.ConvertTo(context, culture, value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this Int64Converter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
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
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// typeconverter.ConvertTo&lt;int&gt;(value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this KeysConverter typeconverter, Object value)
		{
			if(typeconverter == null) throw new ArgumentNullException("typeconverter");

			return (T)typeconverter.ConvertTo(value, typeof(T));
		}

		/// <summary>
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// keysconverter.ConvertTo&lt;int&gt;(context, culture, value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this KeysConverter keysconverter, System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, Object value)
		{
			if(keysconverter == null) throw new ArgumentNullException("keysconverter");

			return (T)keysconverter.ConvertTo(context, culture, value, typeof(T));
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
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// typeconverter.ConvertTo&lt;int&gt;(value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this LinkConverter typeconverter, Object value)
		{
			if(typeconverter == null) throw new ArgumentNullException("typeconverter");

			return (T)typeconverter.ConvertTo(value, typeof(T));
		}

		/// <summary>
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// linkconverter.ConvertTo&lt;int&gt;(context, culture, value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this LinkConverter linkconverter, System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, Object value)
		{
			if(linkconverter == null) throw new ArgumentNullException("linkconverter");

			return (T)linkconverter.ConvertTo(context, culture, value, typeof(T));
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
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// typeconverter.ConvertTo&lt;int&gt;(value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this ListBindingConverter typeconverter, Object value)
		{
			if(typeconverter == null) throw new ArgumentNullException("typeconverter");

			return (T)typeconverter.ConvertTo(value, typeof(T));
		}

		/// <summary>
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// listbindingconverter.ConvertTo&lt;int&gt;(context, culture, value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this ListBindingConverter listbindingconverter, System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, Object value)
		{
			if(listbindingconverter == null) throw new ArgumentNullException("listbindingconverter");

			return (T)listbindingconverter.ConvertTo(context, culture, value, typeof(T));
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
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// typeconverter.ConvertTo&lt;int&gt;(value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this ListViewItemConverter typeconverter, Object value)
		{
			if(typeconverter == null) throw new ArgumentNullException("typeconverter");

			return (T)typeconverter.ConvertTo(value, typeof(T));
		}

		/// <summary>
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// listviewitemconverter.ConvertTo&lt;int&gt;(context, culture, value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this ListViewItemConverter listviewitemconverter, System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, Object value)
		{
			if(listviewitemconverter == null) throw new ArgumentNullException("listviewitemconverter");

			return (T)listviewitemconverter.ConvertTo(context, culture, value, typeof(T));
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
		/// listviewvirtualitemsselectionrangechangedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ListViewVirtualItemsSelectionRangeChangedEventHandler listviewvirtualitemsselectionrangechangedeventhandler, Object sender, ListViewVirtualItemsSelectionRangeChangedEventArgs e, AsyncCallback callback)
		{
			if(listviewvirtualitemsselectionrangechangedeventhandler == null) throw new ArgumentNullException("listviewvirtualitemsselectionrangechangedeventhandler");

			return listviewvirtualitemsselectionrangechangedeventhandler.BeginInvoke(sender, e, callback, null);
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
        /// localcertificateselectioncallback.BeginInvoke(sender, targetHost, localCertificates, remoteCertificate, acceptableIssuers, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this LocalCertificateSelectionCallback localcertificateselectioncallback,
            Object sender, String targetHost,
            System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates,
            System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, String[] acceptableIssuers,
            AsyncCallback callback)
        {
            if (localcertificateselectioncallback == null)
                throw new ArgumentNullException("localcertificateselectioncallback");

            return localcertificateselectioncallback.BeginInvoke(sender, targetHost, localCertificates,
                remoteCertificate, acceptableIssuers, callback, null);
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
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this MarginsConverter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// marginsconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this MarginsConverter marginsconverter,
            System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture,
            Object value)
        {
            if (marginsconverter == null) throw new ArgumentNullException("marginsconverter");

            return (T) marginsconverter.ConvertTo(context, culture, value, typeof(T));
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
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// multilinestringconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this MultilineStringConverter multilinestringconverter,
            ITypeDescriptorContext context, System.Globalization.CultureInfo culture, Object value)
        {
            if (multilinestringconverter == null) throw new ArgumentNullException("multilinestringconverter");

            return (T) multilinestringconverter.ConvertTo(context, culture, value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this MultilineStringConverter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
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
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// nullableconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this NullableConverter nullableconverter, ITypeDescriptorContext context,
            System.Globalization.CultureInfo culture, Object value)
        {
            if (nullableconverter == null) throw new ArgumentNullException("nullableconverter");

            return (T) nullableconverter.ConvertTo(context, culture, value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this NullableConverter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
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
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// typeconverter.ConvertTo&lt;int&gt;(value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this OpacityConverter typeconverter, Object value)
		{
			if(typeconverter == null) throw new ArgumentNullException("typeconverter");

			return (T)typeconverter.ConvertTo(value, typeof(T));
		}

		/// <summary>
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// opacityconverter.ConvertTo&lt;int&gt;(context, culture, value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this OpacityConverter opacityconverter, System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, Object value)
		{
			if(opacityconverter == null) throw new ArgumentNullException("opacityconverter");

			return (T)opacityconverter.ConvertTo(context, culture, value, typeof(T));
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
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// typeconverter.ConvertTo&lt;int&gt;(value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this PaddingConverter typeconverter, Object value)
		{
			if(typeconverter == null) throw new ArgumentNullException("typeconverter");

			return (T)typeconverter.ConvertTo(value, typeof(T));
		}

		/// <summary>
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// paddingconverter.ConvertTo&lt;int&gt;(context, culture, value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this PaddingConverter paddingconverter, System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, Object value)
		{
			if(paddingconverter == null) throw new ArgumentNullException("paddingconverter");

			return (T)paddingconverter.ConvertTo(context, culture, value, typeof(T));
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
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this PointConverter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// pointconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this PointConverter pointconverter,
            System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture,
            Object value)
        {
            if (pointconverter == null) throw new ArgumentNullException("pointconverter");

            return (T) pointconverter.ConvertTo(context, culture, value, typeof(T));
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
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// typeconverter.ConvertTo&lt;int&gt;(value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this RectangleConverter typeconverter, Object value)
		{
			if(typeconverter == null) throw new ArgumentNullException("typeconverter");

			return (T)typeconverter.ConvertTo(value, typeof(T));
		}

		/// <summary>
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// rectangleconverter.ConvertTo&lt;int&gt;(context, culture, value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this RectangleConverter rectangleconverter, System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, Object value)
		{
			if(rectangleconverter == null) throw new ArgumentNullException("rectangleconverter");

			return (T)rectangleconverter.ConvertTo(context, culture, value, typeof(T));
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
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// referenceconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this ReferenceConverter referenceconverter, ITypeDescriptorContext context,
            System.Globalization.CultureInfo culture, Object value)
        {
            if (referenceconverter == null) throw new ArgumentNullException("referenceconverter");

            return (T) referenceconverter.ConvertTo(context, culture, value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this ReferenceConverter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
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
        /// remotecertificatevalidationcallback.BeginInvoke(sender, certificate, chain, sslPolicyErrors, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(
            this RemoteCertificateValidationCallback remotecertificatevalidationcallback, Object sender,
            System.Security.Cryptography.X509Certificates.X509Certificate certificate,
            System.Security.Cryptography.X509Certificates.X509Chain chain, SslPolicyErrors sslPolicyErrors,
            AsyncCallback callback)
        {
            if (remotecertificatevalidationcallback == null)
                throw new ArgumentNullException("remotecertificatevalidationcallback");

            return remotecertificatevalidationcallback.BeginInvoke(sender, certificate, chain, sslPolicyErrors,
                callback, null);
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
		/// Extends TransformBlock so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// rijndaelmanagedtransform.TransformBlock(inputBuffer, outputBuffer, outputOffset);
		/// </example>
		/// </summary>
		public static Int32 TransformBlock(this RijndaelManagedTransform rijndaelmanagedtransform, Byte[] inputBuffer, Byte[] outputBuffer, Int32 outputOffset)
		{
			if(rijndaelmanagedtransform == null) throw new ArgumentNullException("rijndaelmanagedtransform");

			if(inputBuffer == null) throw new ArgumentNullException("inputBuffer");

			return rijndaelmanagedtransform.TransformBlock(inputBuffer, 0, inputBuffer.Length, outputBuffer, outputOffset);
		}

		/// <summary>
		/// Extends TransformFinalBlock so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// rijndaelmanagedtransform.TransformFinalBlock(inputBuffer);
		/// </example>
		/// </summary>
		public static Byte[] TransformFinalBlock(this RijndaelManagedTransform rijndaelmanagedtransform, Byte[] inputBuffer)
		{
			if(rijndaelmanagedtransform == null) throw new ArgumentNullException("rijndaelmanagedtransform");

			if(inputBuffer == null) throw new ArgumentNullException("inputBuffer");

			return rijndaelmanagedtransform.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);
		}

	}
}
#endif
#if (NETSTANDARD2_0 || NETSTANDARD1_2 || NETSTANDARD1_1 || NET47)

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends ReadArray&lt;T&gt; so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// safebuffer.ReadArray&lt;T&gt;(byteOffset, array);
        /// </example>
        /// </summary>
        public static void ReadArray<T>(this SafeBuffer safebuffer, UInt64 byteOffset, T[] array) where T : struct
        {
            if (safebuffer == null) throw new ArgumentNullException("safebuffer");

            if (array == null) throw new ArgumentNullException("array");

            safebuffer.ReadArray(byteOffset, array, 0, array.Length);
        }

        /// <summary>
        /// Extends WriteArray&lt;T&gt; so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// safebuffer.WriteArray&lt;T&gt;(byteOffset, array);
        /// </example>
        /// </summary>
        public static void WriteArray<T>(this SafeBuffer safebuffer, UInt64 byteOffset, T[] array) where T : struct
        {
            if (safebuffer == null) throw new ArgumentNullException("safebuffer");

            if (array == null) throw new ArgumentNullException("array");

            safebuffer.WriteArray(byteOffset, array, 0, array.Length);
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
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// basenumberconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this SByteConverter basenumberconverter, ITypeDescriptorContext context,
            System.Globalization.CultureInfo culture, Object value)
        {
            if (basenumberconverter == null) throw new ArgumentNullException("basenumberconverter");

            return (T) basenumberconverter.ConvertTo(context, culture, value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this SByteConverter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
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
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// typeconverter.ConvertTo&lt;int&gt;(value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this SelectionRangeConverter typeconverter, Object value)
		{
			if(typeconverter == null) throw new ArgumentNullException("typeconverter");

			return (T)typeconverter.ConvertTo(value, typeof(T));
		}

		/// <summary>
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// selectionrangeconverter.ConvertTo&lt;int&gt;(context, culture, value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this SelectionRangeConverter selectionrangeconverter, System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, Object value)
		{
			if(selectionrangeconverter == null) throw new ArgumentNullException("selectionrangeconverter");

			return (T)selectionrangeconverter.ConvertTo(context, culture, value, typeof(T));
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
        /// Extends Invoke so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// servicecreatorcallback.Invoke&lt;int&gt;(container);
        /// </example>
        /// </summary>
        public static T Invoke<T>(this ServiceCreatorCallback servicecreatorcallback, IServiceContainer container)
        {
            if (servicecreatorcallback == null) throw new ArgumentNullException("servicecreatorcallback");

            return (T) servicecreatorcallback.Invoke(container, typeof(T));
        }

        /// <summary>
        /// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// servicecreatorcallback.BeginInvoke(container, serviceType, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginInvoke(this ServiceCreatorCallback servicecreatorcallback,
            IServiceContainer container, Type serviceType, AsyncCallback callback)
        {
            if (servicecreatorcallback == null) throw new ArgumentNullException("servicecreatorcallback");

            return servicecreatorcallback.BeginInvoke(container, serviceType, callback, null);
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
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// basenumberconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this SingleConverter basenumberconverter, ITypeDescriptorContext context,
            System.Globalization.CultureInfo culture, Object value)
        {
            if (basenumberconverter == null) throw new ArgumentNullException("basenumberconverter");

            return (T) basenumberconverter.ConvertTo(context, culture, value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this SingleConverter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
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
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// typeconverter.ConvertTo&lt;int&gt;(value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this SizeConverter typeconverter, Object value)
		{
			if(typeconverter == null) throw new ArgumentNullException("typeconverter");

			return (T)typeconverter.ConvertTo(value, typeof(T));
		}

		/// <summary>
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// sizeconverter.ConvertTo&lt;int&gt;(context, culture, value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this SizeConverter sizeconverter, System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, Object value)
		{
			if(sizeconverter == null) throw new ArgumentNullException("sizeconverter");

			return (T)sizeconverter.ConvertTo(context, culture, value, typeof(T));
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
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// typeconverter.ConvertTo&lt;int&gt;(value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this SizeFConverter typeconverter, Object value)
		{
			if(typeconverter == null) throw new ArgumentNullException("typeconverter");

			return (T)typeconverter.ConvertTo(value, typeof(T));
		}

		/// <summary>
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// sizefconverter.ConvertTo&lt;int&gt;(context, culture, value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this SizeFConverter sizefconverter, System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, Object value)
		{
			if(sizefconverter == null) throw new ArgumentNullException("sizefconverter");

			return (T)sizefconverter.ConvertTo(context, culture, value, typeof(T));
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
        /// Extends Read so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// sqlbytes.Read(offset, buffer);
        /// </example>
        /// </summary>
        public static Int64 Read(this SqlBytes sqlbytes, Int64 offset, Byte[] buffer)
        {
            if (sqlbytes == null) throw new ArgumentNullException("sqlbytes");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return sqlbytes.Read(offset, buffer, 0, buffer.Length);
        }

        /// <summary>
        /// Extends Write so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// sqlbytes.Write(offset, buffer);
        /// </example>
        /// </summary>
        public static void Write(this SqlBytes sqlbytes, Int64 offset, Byte[] buffer)
        {
            if (sqlbytes == null) throw new ArgumentNullException("sqlbytes");

            if (buffer == null) throw new ArgumentNullException("buffer");

            sqlbytes.Write(offset, buffer, 0, buffer.Length);
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
        /// Extends Read so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// sqlchars.Read(offset, buffer);
        /// </example>
        /// </summary>
        public static Int64 Read(this SqlChars sqlchars, Int64 offset, Char[] buffer)
        {
            if (sqlchars == null) throw new ArgumentNullException("sqlchars");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return sqlchars.Read(offset, buffer, 0, buffer.Length);
        }

        /// <summary>
        /// Extends Write so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// sqlchars.Write(offset, buffer);
        /// </example>
        /// </summary>
        public static void Write(this SqlChars sqlchars, Int64 offset, Char[] buffer)
        {
            if (sqlchars == null) throw new ArgumentNullException("sqlchars");

            if (buffer == null) throw new ArgumentNullException("buffer");

            sqlchars.Write(offset, buffer, 0, buffer.Length);
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
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this StringConverter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this StringConverter typeconverter, ITypeDescriptorContext context,
            System.Globalization.CultureInfo culture, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(context, culture, value, typeof(T));
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
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// typeconverter.ConvertTo&lt;int&gt;(value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this TableLayoutSettingsTypeConverter typeconverter, Object value)
		{
			if(typeconverter == null) throw new ArgumentNullException("typeconverter");

			return (T)typeconverter.ConvertTo(value, typeof(T));
		}

		/// <summary>
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// tablelayoutsettingstypeconverter.ConvertTo&lt;int&gt;(context, culture, value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this TableLayoutSettingsTypeConverter tablelayoutsettingstypeconverter, System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, Object value)
		{
			if(tablelayoutsettingstypeconverter == null) throw new ArgumentNullException("tablelayoutsettingstypeconverter");

			return (T)tablelayoutsettingstypeconverter.ConvertTo(context, culture, value, typeof(T));
		}

	}
}
#endif
#if (NETSTANDARD2_0 || NET47)

namespace HSNXT
{
    public static partial class Extensions
    {
#if (NETSTANDARD2_0 || NET47)
        /// <summary>
        /// Extends BeginAcceptSocket so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// tcplistener.BeginAcceptSocket(callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginAcceptSocket(this TcpListener tcplistener, AsyncCallback callback)
        {
            if (tcplistener == null) throw new ArgumentNullException("tcplistener");

            return tcplistener.BeginAcceptSocket(callback, null);
        }

        /// <summary>
        /// Extends BeginAcceptTcpClient so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// tcplistener.BeginAcceptTcpClient(callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginAcceptTcpClient(this TcpListener tcplistener, AsyncCallback callback)
        {
            if (tcplistener == null) throw new ArgumentNullException("tcplistener");

            return tcplistener.BeginAcceptTcpClient(callback, null);
        }
#endif
    }
}
#endif

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends Read so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// textreader.Read(buffer);
        /// </example>
        /// </summary>
        public static Int32 Read(this TextReader textreader, Char[] buffer)
        {
            if (textreader == null) throw new ArgumentNullException("textreader");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return textreader.Read(buffer, 0, buffer.Length);
        }

        /// <summary>
        /// Extends ReadBlock so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// textreader.ReadBlock(buffer);
        /// </example>
        /// </summary>
        public static Int32 ReadBlock(this TextReader textreader, Char[] buffer)
        {
            if (textreader == null) throw new ArgumentNullException("textreader");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return textreader.ReadBlock(buffer, 0, buffer.Length);
        }
    }
}
#if (NETSTANDARD2_0 || NET47)

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// timespanconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this TimeSpanConverter timespanconverter, ITypeDescriptorContext context,
            System.Globalization.CultureInfo culture, Object value)
        {
            if (timespanconverter == null) throw new ArgumentNullException("timespanconverter");

            return (T) timespanconverter.ConvertTo(context, culture, value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this TimeSpanConverter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
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
        /// Extends TransformBlock so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// tobase64transform.TransformBlock(inputBuffer, outputBuffer, outputOffset);
        /// </example>
        /// </summary>
        public static Int32 TransformBlock(this ToBase64Transform tobase64transform, Byte[] inputBuffer,
            Byte[] outputBuffer, Int32 outputOffset)
        {
            if (tobase64transform == null) throw new ArgumentNullException("tobase64transform");

            if (inputBuffer == null) throw new ArgumentNullException("inputBuffer");

            return tobase64transform.TransformBlock(inputBuffer, 0, inputBuffer.Length, outputBuffer, outputOffset);
        }

        /// <summary>
        /// Extends TransformFinalBlock so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// tobase64transform.TransformFinalBlock(inputBuffer);
        /// </example>
        /// </summary>
        public static Byte[] TransformFinalBlock(this ToBase64Transform tobase64transform, Byte[] inputBuffer)
        {
            if (tobase64transform == null) throw new ArgumentNullException("tobase64transform");

            if (inputBuffer == null) throw new ArgumentNullException("inputBuffer");

            return tobase64transform.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);
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
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// typeconverter.ConvertTo&lt;int&gt;(value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this TreeNodeConverter typeconverter, Object value)
		{
			if(typeconverter == null) throw new ArgumentNullException("typeconverter");

			return (T)typeconverter.ConvertTo(value, typeof(T));
		}

		/// <summary>
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// treenodeconverter.ConvertTo&lt;int&gt;(context, culture, value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this TreeNodeConverter treenodeconverter, System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, Object value)
		{
			if(treenodeconverter == null) throw new ArgumentNullException("treenodeconverter");

			return (T)treenodeconverter.ConvertTo(context, culture, value, typeof(T));
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
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// typeconverter.ConvertTo&lt;int&gt;(value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this TreeViewImageIndexConverter typeconverter, Object value)
		{
			if(typeconverter == null) throw new ArgumentNullException("typeconverter");

			return (T)typeconverter.ConvertTo(value, typeof(T));
		}

		/// <summary>
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// treeviewimageindexconverter.ConvertTo&lt;int&gt;(context, culture, value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this TreeViewImageIndexConverter treeviewimageindexconverter, System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, Object value)
		{
			if(treeviewimageindexconverter == null) throw new ArgumentNullException("treeviewimageindexconverter");

			return (T)treeviewimageindexconverter.ConvertTo(context, culture, value, typeof(T));
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
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// typeconverter.ConvertTo&lt;int&gt;(value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this TreeViewImageKeyConverter typeconverter, Object value)
		{
			if(typeconverter == null) throw new ArgumentNullException("typeconverter");

			return (T)typeconverter.ConvertTo(value, typeof(T));
		}

		/// <summary>
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// treeviewimagekeyconverter.ConvertTo&lt;int&gt;(context, culture, value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this TreeViewImageKeyConverter treeviewimagekeyconverter, System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, Object value)
		{
			if(treeviewimagekeyconverter == null) throw new ArgumentNullException("treeviewimagekeyconverter");

			return (T)treeviewimagekeyconverter.ConvertTo(context, culture, value, typeof(T));
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
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this TypeConverter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this TypeConverter typeconverter, ITypeDescriptorContext context,
            System.Globalization.CultureInfo culture, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(context, culture, value, typeof(T));
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
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typelistconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this TypeListConverter typelistconverter, ITypeDescriptorContext context,
            System.Globalization.CultureInfo culture, Object value)
        {
            if (typelistconverter == null) throw new ArgumentNullException("typelistconverter");

            return (T) typelistconverter.ConvertTo(context, culture, value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this TypeListConverter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
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
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// basenumberconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this UInt16Converter basenumberconverter, ITypeDescriptorContext context,
            System.Globalization.CultureInfo culture, Object value)
        {
            if (basenumberconverter == null) throw new ArgumentNullException("basenumberconverter");

            return (T) basenumberconverter.ConvertTo(context, culture, value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this UInt16Converter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
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
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// basenumberconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this UInt32Converter basenumberconverter, ITypeDescriptorContext context,
            System.Globalization.CultureInfo culture, Object value)
        {
            if (basenumberconverter == null) throw new ArgumentNullException("basenumberconverter");

            return (T) basenumberconverter.ConvertTo(context, culture, value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this UInt32Converter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
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
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// basenumberconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this UInt64Converter basenumberconverter, ITypeDescriptorContext context,
            System.Globalization.CultureInfo culture, Object value)
        {
            if (basenumberconverter == null) throw new ArgumentNullException("basenumberconverter");

            return (T) basenumberconverter.ConvertTo(context, culture, value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this UInt64Converter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
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
        /// Extends ReadArray&lt;T&gt; so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// unmanagedmemoryaccessor.ReadArray&lt;T&gt;(position, array);
        /// </example>
        /// </summary>
        public static Int32 ReadArray<T>(this UnmanagedMemoryAccessor unmanagedmemoryaccessor, Int64 position,
            T[] array) where T : struct
        {
            if (unmanagedmemoryaccessor == null) throw new ArgumentNullException("unmanagedmemoryaccessor");

            if (array == null) throw new ArgumentNullException("array");

            return unmanagedmemoryaccessor.ReadArray(position, array, 0, array.Length);
        }

        /// <summary>
        /// Extends WriteArray&lt;T&gt; so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// unmanagedmemoryaccessor.WriteArray&lt;T&gt;(position, array);
        /// </example>
        /// </summary>
        public static void WriteArray<T>(this UnmanagedMemoryAccessor unmanagedmemoryaccessor, Int64 position,
            T[] array) where T : struct
        {
            if (unmanagedmemoryaccessor == null) throw new ArgumentNullException("unmanagedmemoryaccessor");

            if (array == null) throw new ArgumentNullException("array");

            unmanagedmemoryaccessor.WriteArray(position, array, 0, array.Length);
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
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// uritypeconverter.ConvertTo&lt;int&gt;(context, culture, value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this UriTypeConverter uritypeconverter,
            System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture,
            Object value)
        {
            if (uritypeconverter == null) throw new ArgumentNullException("uritypeconverter");

            return (T) uritypeconverter.ConvertTo(context, culture, value, typeof(T));
        }

        /// <summary>
        /// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// typeconverter.ConvertTo&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ConvertTo<T>(this UriTypeConverter typeconverter, Object value)
        {
            if (typeconverter == null) throw new ArgumentNullException("typeconverter");

            return (T) typeconverter.ConvertTo(value, typeof(T));
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
        /// Extends BeginGetResponse so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// webrequest.BeginGetResponse(callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginGetResponse(this WebRequest webrequest, AsyncCallback callback)
        {
            if (webrequest == null) throw new ArgumentNullException("webrequest");

            return webrequest.BeginGetResponse(callback, null);
        }

        /// <summary>
        /// Extends BeginGetRequestStream so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// webrequest.BeginGetRequestStream(callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginGetRequestStream(this WebRequest webrequest, AsyncCallback callback)
        {
            if (webrequest == null) throw new ArgumentNullException("webrequest");

            return webrequest.BeginGetRequestStream(callback, null);
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
        /// Extends Get so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// xmlnametable.Get(array);
        /// </example>
        /// </summary>
        public static String Get(this XmlNameTable xmlnametable, Char[] array)
        {
            if (xmlnametable == null) throw new ArgumentNullException("xmlnametable");

            if (array == null) throw new ArgumentNullException("array");

            return xmlnametable.Get(array, 0, array.Length);
        }

        /// <summary>
        /// Extends Add so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// xmlnametable.Add(array);
        /// </example>
        /// </summary>
        public static String Add(this XmlNameTable xmlnametable, Char[] array)
        {
            if (xmlnametable == null) throw new ArgumentNullException("xmlnametable");

            if (array == null) throw new ArgumentNullException("array");

            return xmlnametable.Add(array, 0, array.Length);
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
        /// Extends ChangeType so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// xmlschemadatatype.ChangeType&lt;int&gt;(value);
        /// </example>
        /// </summary>
        public static T ChangeType<T>(this XmlSchemaDatatype xmlschemadatatype, Object value)
        {
            if (xmlschemadatatype == null) throw new ArgumentNullException("xmlschemadatatype");

            return (T) xmlschemadatatype.ChangeType(value, typeof(T));
        }

        /// <summary>
        /// Extends ChangeType so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// xmlschemadatatype.ChangeType&lt;int&gt;(value, namespaceResolver);
        /// </example>
        /// </summary>
        public static T ChangeType<T>(this XmlSchemaDatatype xmlschemadatatype, Object value,
            System.Xml.IXmlNamespaceResolver namespaceResolver)
        {
            if (xmlschemadatatype == null) throw new ArgumentNullException("xmlschemadatatype");

            return (T) xmlschemadatatype.ChangeType(value, typeof(T), namespaceResolver);
        }
    }
}
#endif