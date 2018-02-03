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

namespace HSNXT
{
    public static partial class Extensions
	{
		/// <summary>
		/// Adds the range specified to the dictionary specified, using the key producer func to produce the key values.
		/// If the key already exists, the key's value is overwritten with the value to add.
		/// </summary>
		/// <typeparam name="TKey">The type of the key.</typeparam>
		/// <typeparam name="TValue">The type of the value.</typeparam>
		/// <param name="container">The container.</param>
		/// <param name="keyProducerFunc">The key producer func.</param>
		/// <param name="rangeToAdd">The range to add.</param>
		public static void AddRange<TKey, TValue>(this IDictionary<TKey, TValue> container, Func<TValue, TKey> keyProducerFunc, IEnumerable<TValue> rangeToAdd)
		{
			if (keyProducerFunc == null)
			{
				throw new ArgumentNullException(nameof(keyProducerFunc));
			}

			if (container == null || rangeToAdd == null)
			{
				return;
			}

			foreach (TValue toAdd in rangeToAdd)
			{
				container[keyProducerFunc(toAdd)] = toAdd;
			}
		}

		/// <summary>
		/// Gets the value for the key from the dictionary specified, or null / default(TValue) if key not found or the key is null.
		/// </summary>
		/// <typeparam name="TKey">The type of the key.</typeparam>
		/// <typeparam name="TValue">The type of the value.</typeparam>
		/// <param name="dictionary">The dictionary.</param>
		/// <param name="key">The key.</param>
		/// <returns>the value for the key from the dictionary specified, or null / default(TValue) if key not found or the key is null.</returns>
		public static TValue GetValue<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key)
		{
			TValue toReturn;
			if (key == null || !dictionary.TryGetValue(key, out toReturn))
			{
				toReturn = default(TValue);
			}

			return toReturn;
		}

#if NETSTANDARD1_0
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'IEnumerableable.ToCollection<T>(IEnumerable<T>)'
		public static Collection<T> ToCollection<T>(this IEnumerable<T> enumerable)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'IEnumerableable.ToCollection<T>(IEnumerable<T>)'
		{
			if (enumerable == null) throw new ArgumentNullException(nameof(enumerable));

			var list = enumerable as IList<T>;
			if (list != null)
			{
				return new Collection<T>(list);
			}
			var collection = new Collection<T>();
			collection.AddRange(enumerable);

			return collection;
		}
#endif

#if (NETSTANDARD2_0 || NETSTANDARD2_0 || NETSTANDARD1_4 || NETSTANDARD1_3 || NETCOREAPP1_0 || NETCOREAPP1_1 || NET47)
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'IEnumerableable.ToAssemblies(IEnumerable<string>)'
		public static IEnumerable<Assembly> ToAssemblies(this IEnumerable<string> filenames)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'IEnumerableable.ToAssemblies(IEnumerable<string>)'
		{
			foreach (var f in filenames)
			{
				Assembly loadFrom;
#if (NETSTANDARD2_0)
				var dir = Directory.GetCurrentDirectory();
#endif
				try
				{
#if (NETSTANDARD2_0)
					Directory.SetCurrentDirectory(Path.GetDirectoryName(f));
					loadFrom = Assembly.Load(new AssemblyName(Path.GetFileNameWithoutExtension(f)));
#elif (!NETSTANDARD1_0 && ! NETSTANDARD1_1 && !NETSTANDARD1_2)
					loadFrom = Assembly.LoadFrom(f);
#endif
				}
				catch (BadImageFormatException)
				{
					// ignore anything that can't be loaded
					continue;
				}
				catch (ReflectionTypeLoadException)
				{
					// ignore anything that can't be loaded
					continue;
				}
#if (NETSTANDARD2_0)
				finally
				{
					Directory.SetCurrentDirectory(dir);
				}
#endif
				yield return loadFrom;
			}
		}
#endif

		/// <summary>
		/// Create a single multicast delegate from a collection of delegates
		/// </summary>
		/// <typeparam name="T1">Type of parameter to delegate</typeparam>
		/// <typeparam name="T2">Type of return of the delegate</typeparam>
		/// <param name="coll">The collection of delegates</param>
		/// <returns></returns>
		public static Func<T1, T2> Sum<T1, T2>(this IEnumerable<Func<T1, T2>> coll)
		{
			if (coll == null || !coll.Any())
			{
				throw new ArgumentException("Collection should not be empty or null.", nameof(coll));
			}
			Func<T1, T2> result = coll.ElementAt(0);
			foreach (var d in coll.Skip(1))
				result += d;
			return result;
		}
//#endif
//#endif
	}
}
#endif//////////////////////////////////////////////////////////////////////
// BCLExtensions is (c) 2010 Solutions Design. All rights reserved.
// http://www.sd.nl
//////////////////////////////////////////////////////////////////////
// COPYRIGHTS:
// Copyright (c) 2010 Solutions Design. All rights reserved.
//
// The BCLExtensions library sourcecode and its accompanying tools, tests and support code
// are released under the following license: (BSD2)
// ----------------------------------------------------------------------
// Redistribution and use in source and binary forms, with or without modification,
// are permitted provided that the following conditions are met:
//
// 1) Redistributions of source code must retain the above copyright notice, this list of
//    conditions and the following disclaimer.
// 2) Redistributions in binary form must reproduce the above copyright notice, this list of
//    conditions and the following disclaimer in the documentation and/or other materials
//    provided with the distribution.
//
// THIS SOFTWARE IS PROVIDED BY SOLUTIONS DESIGN ``AS IS'' AND ANY EXPRESS OR IMPLIED WARRANTIES,
// INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A
// PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL SOLUTIONS DESIGN OR CONTRIBUTORS BE LIABLE FOR
// ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT
// NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR
// BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT,
// STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE
// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
//
// The views and conclusions contained in the software and documentation are those of the authors
// and should not be interpreted as representing official policies, either expressed or implied,
// of Solutions Design.
//
//////////////////////////////////////////////////////////////////////
// Contributers to the code:
// - Frans Bouma [FB]
//////////////////////////////////////////////////////////////////////

namespace PRI.ProductivityExtensions.IListExtensions
{
	/// <summary>
	/// class that contains extension methods that extend <seealso cref="IList{T}"/>
	/// </summary>
	public static class IListable
	{
		/// <summary>
		/// Swaps the values at indexA and indexB.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="source">The source.</param>
		/// <param name="indexA">The index for A.</param>
		/// <param name="indexB">The index for B.</param>
		public static void SwapValues<T>(this IList<T> source, int indexA, int indexB)
		{
			if (source == null)
			{
				throw new ArgumentNullException(nameof(source));
			}

			if (indexA < uint.MinValue || indexA >= source.Count)
			{
				throw new IndexOutOfRangeException("indexA is out of range");
			}

			if (indexB < uint.MinValue || indexB >= source.Count)
			{
				throw new IndexOutOfRangeException("indexB is out of range");
			}

			if (indexA == indexB)
			{
				return;
			}

			T tempValue = source[indexA];
			source[indexA] = source[indexB];
			source[indexB] = tempValue;
		}

		/// <summary>
		/// Searches for the element specified in the sorted list specified using binary search http://en.wikipedia.org/wiki/Binary_search. The algorithm
		/// is re-implemented here to be able to search in any sorted IList implementing data structure (.NET's BCL only implements BinarySearch on arrays and
		/// List(Of T). If no IComparer(Of T) is available, try using Algorithmia's ComparisonBasedComparer,
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="sortedList">The sorted list.</param>
		/// <param name="element">The element.</param>
		/// <param name="comparer">The comparer.</param>
		/// <returns>The index of the element searched or the bitwise complement of the index of the next element that is larger than
		/// <i>element</i> or if there is no larger element the bitwise complement of Count. Bitwise complements have their original bits negated. Use
		/// the '~' operator in C# to get the real value. Bitwise complements are used to avoid returning a value which is in the range of valid indices so
		/// callers can't check whether the value returned is an index or if the element wasn't found. If the value returned is negative, the bitwise complement
		/// can be used as index to insert the element in the sorted list to keep the list sorted</returns>
		/// <remarks>Assumes that sortedList is sorted ascending. If you pass in a descending sorted list, be sure the comparer is adjusted as well.</remarks>
		public static int BinarySearch<T>(this IList<T> sortedList, T element, IComparer<T> comparer)
		{
			if (sortedList == null)
			{
				throw new ArgumentNullException(nameof(sortedList));
			}

			if (sortedList.Count <= 0)
			{
				return -1;
			}

			int left = 0;
			int right = sortedList.Count - 1;
			while (left <= right)
			{
				// determine the index in the list to compare with. This is the middle of the segment we're searching in.
				int index = left + ((right - left) / 2);
				int compareResult = comparer.Compare(sortedList[index], element);
				if (compareResult == 0)
				{
					// found it, done. Return the index
					return index;
				}

				if (compareResult < 0)
				{
					// element is bigger than the element at index, so we can skip all elements at the left of index including the element at index.
					left = index + 1;
				}
				else
				{
					// element is smaller than the element at index, so we can skip all elements at the right of index including the element at index.
					right = index - 1;
				}
			}

			return ~left;
		}
	}
}#if (NETSTANDARD2_0 || NET47)

namespace HSNXT
{
    public static partial class Extensions
	{
		/// <summary>
		/// Extends BeginAuthenticateAsClient so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// sslstream.BeginAuthenticateAsClient(targetHost, asyncCallback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginAuthenticateAsClient(this SslStream sslstream, String targetHost, AsyncCallback asyncCallback)
		{
			if(sslstream == null) throw new ArgumentNullException("sslstream");

			return sslstream.BeginAuthenticateAsClient(targetHost, asyncCallback, null);
		}

		/// <summary>
		/// Extends BeginAuthenticateAsClient so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// sslstream.BeginAuthenticateAsClient(targetHost, clientCertificates, enabledSslProtocols, checkCertificateRevocation, asyncCallback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginAuthenticateAsClient(this SslStream sslstream, String targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, Boolean checkCertificateRevocation, AsyncCallback asyncCallback)
		{
			if(sslstream == null) throw new ArgumentNullException("sslstream");

			return sslstream.BeginAuthenticateAsClient(targetHost, clientCertificates, enabledSslProtocols, checkCertificateRevocation, asyncCallback, null);
		}

		/// <summary>
		/// Extends BeginAuthenticateAsServer so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// sslstream.BeginAuthenticateAsServer(serverCertificate, asyncCallback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginAuthenticateAsServer(this SslStream sslstream, System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, AsyncCallback asyncCallback)
		{
			if(sslstream == null) throw new ArgumentNullException("sslstream");

			return sslstream.BeginAuthenticateAsServer(serverCertificate, asyncCallback, null);
		}

		/// <summary>
		/// Extends BeginAuthenticateAsServer so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// sslstream.BeginAuthenticateAsServer(serverCertificate, clientCertificateRequired, enabledSslProtocols, checkCertificateRevocation, asyncCallback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginAuthenticateAsServer(this SslStream sslstream, System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, Boolean clientCertificateRequired, System.Security.Authentication.SslProtocols enabledSslProtocols, Boolean checkCertificateRevocation, AsyncCallback asyncCallback)
		{
			if(sslstream == null) throw new ArgumentNullException("sslstream");

			return sslstream.BeginAuthenticateAsServer(serverCertificate, clientCertificateRequired, enabledSslProtocols, checkCertificateRevocation, asyncCallback, null);
		}

		/// <summary>
		/// Extends BeginRead so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// sslstream.BeginRead(buffer, offset, count, asyncCallback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginRead(this SslStream sslstream, Byte[] buffer, Int32 offset, Int32 count, AsyncCallback asyncCallback)
		{
			if(sslstream == null) throw new ArgumentNullException("sslstream");

			return sslstream.BeginRead(buffer, offset, count, asyncCallback, null);
		}

		/// <summary>
		/// Extends BeginRead so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// sslstream.BeginRead(buffer, asyncCallback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginRead(this SslStream sslstream, Byte[] buffer, AsyncCallback asyncCallback)
		{
			if(sslstream == null) throw new ArgumentNullException("sslstream");

			if(buffer == null) throw new ArgumentNullException("buffer");

			return sslstream.BeginRead(buffer, 0, buffer.Length, asyncCallback);
		}

		/// <summary>
		/// Extends BeginWrite so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// sslstream.BeginWrite(buffer, offset, count, asyncCallback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginWrite(this SslStream sslstream, Byte[] buffer, Int32 offset, Int32 count, AsyncCallback asyncCallback)
		{
			if(sslstream == null) throw new ArgumentNullException("sslstream");

			return sslstream.BeginWrite(buffer, offset, count, asyncCallback, null);
		}

		/// <summary>
		/// Extends BeginWrite so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// sslstream.BeginWrite(buffer, asyncCallback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginWrite(this SslStream sslstream, Byte[] buffer, AsyncCallback asyncCallback)
		{
			if(sslstream == null) throw new ArgumentNullException("sslstream");

			if(buffer == null) throw new ArgumentNullException("buffer");

			return sslstream.BeginWrite(buffer, 0, buffer.Length, asyncCallback);
		}

	}
}
#endif

namespace HSNXT
{
    public static partial class Extensions
	{
#if (NETSTANDARD2_0 || NET47)
		/// <summary>
		/// Extends BeginRead so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// stream.BeginRead(buffer, callback, state);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginRead(this Stream stream, Byte[] buffer, AsyncCallback callback, Object state)
		{
			if(stream == null) throw new ArgumentNullException("stream");

			if(buffer == null) throw new ArgumentNullException("buffer");

			return stream.BeginRead(buffer, 0, buffer.Length, callback, state);
		}

		/// <summary>
		/// Extends BeginRead so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// stream.BeginRead(buffer, offset, count, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginRead(this Stream stream, Byte[] buffer, Int32 offset, Int32 count, AsyncCallback callback)
		{
			if(stream == null) throw new ArgumentNullException("stream");

			return stream.BeginRead(buffer, offset, count, callback, null);
		}

		/// <summary>
		/// Extends BeginRead so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// stream.BeginRead(buffer, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginRead(this Stream stream, Byte[] buffer, AsyncCallback callback)
		{
			if(stream == null) throw new ArgumentNullException("stream");

			if(buffer == null) throw new ArgumentNullException("buffer");

			return stream.BeginRead(buffer, 0, buffer.Length, callback);
		}

		/// <summary>
		/// Extends BeginWrite so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// stream.BeginWrite(buffer, callback, state);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginWrite(this Stream stream, Byte[] buffer, AsyncCallback callback, Object state)
		{
			if(stream == null) throw new ArgumentNullException("stream");

			if(buffer == null) throw new ArgumentNullException("buffer");

			return stream.BeginWrite(buffer, 0, buffer.Length, callback, state);
		}

		/// <summary>
		/// Extends BeginWrite so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// stream.BeginWrite(buffer, offset, count, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginWrite(this Stream stream, Byte[] buffer, Int32 offset, Int32 count, AsyncCallback callback)
		{
			if(stream == null) throw new ArgumentNullException("stream");

			return stream.BeginWrite(buffer, offset, count, callback, null);
		}

		/// <summary>
		/// Extends BeginWrite so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// stream.BeginWrite(buffer, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginWrite(this Stream stream, Byte[] buffer, AsyncCallback callback)
		{
			if(stream == null) throw new ArgumentNullException("stream");

			if(buffer == null) throw new ArgumentNullException("buffer");

			return stream.BeginWrite(buffer, 0, buffer.Length, callback);
		}
#endif

		/// <summary>
		/// Extends Read so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// stream.Read(buffer);
		/// </example>
		/// </summary>
		public static Int32 Read(this Stream stream, Byte[] buffer)
		{
			if(stream == null) throw new ArgumentNullException("stream");

			if(buffer == null) throw new ArgumentNullException("buffer");

			return stream.Read(buffer, 0, buffer.Length);
		}

		/// <summary>
		/// Extends Write so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// stream.Write(buffer);
		/// </example>
		/// </summary>
		public static void Write(this Stream stream, Byte[] buffer)
		{
			if(stream == null) throw new ArgumentNullException("stream");

			if(buffer == null) throw new ArgumentNullException("buffer");

			stream.Write(buffer, 0, buffer.Length);
		}

	}
}
﻿//////////////////////////////////////////////////////////////////////
// BCLExtensions is (c) 2010 Solutions Design. All rights reserved.
// http://www.sd.nl
//////////////////////////////////////////////////////////////////////
// COPYRIGHTS:
// Copyright (c) 2010 Solutions Design. All rights reserved.
//
// The BCLExtensions library sourcecode and its accompanying tools, tests and support code
// are released under the following license: (BSD2)
// ----------------------------------------------------------------------
// Redistribution and use in source and binary forms, with or without modification,
// are permitted provided that the following conditions are met:
//
// 1) Redistributions of source code must retain the above copyright notice, this list of
//    conditions and the following disclaimer.
// 2) Redistributions in binary form must reproduce the above copyright notice, this list of
//    conditions and the following disclaimer in the documentation and/or other materials
//    provided with the distribution.
//
// THIS SOFTWARE IS PROVIDED BY SOLUTIONS DESIGN ``AS IS'' AND ANY EXPRESS OR IMPLIED WARRANTIES,
// INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A
// PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL SOLUTIONS DESIGN OR CONTRIBUTORS BE LIABLE FOR
// ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT
// NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR
// BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT,
// STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE
// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
//
// The views and conclusions contained in the software and documentation are those of the authors
// and should not be interpreted as representing official policies, either expressed or implied,
// of Solutions Design.
//
//////////////////////////////////////////////////////////////////////
// Contributers to the code:
// - Frans Bouma [FB]
//////////////////////////////////////////////////////////////////////

namespace HSNXT
{
    public static partial class Extensions
	{
#if (NET47)
		/// <summary>
		/// 
		/// </summary>
		/// <param name="udpClient"></param>
		/// <param name="dgram"></param>
		/// <param name="endPoint"></param>
		/// <returns></returns>
		public static int Send(this UdpClient udpClient, byte[] dgram, IPEndPoint endPoint)
		{
			if (udpClient == null) throw new ArgumentNullException(nameof(udpClient));
			return udpClient.Send(dgram, dgram.Length, endPoint);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="udpClient"></param>
		/// <param name="dgram"></param>
		/// <returns></returns>
		public static int Send(this UdpClient udpClient, byte[] dgram)
		{
			if (udpClient == null) throw new ArgumentNullException(nameof(udpClient));
			return udpClient.Send(dgram, dgram.Length);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="udpClient"></param>
		/// <param name="dgram"></param>
		/// <param name="hostname"></param>
		/// <param name="port"></param>
		/// <returns></returns>
		public static int Send(this UdpClient udpClient, byte[] dgram, string hostname, int port)
		{
			if (udpClient == null) throw new ArgumentNullException(nameof(udpClient));
			return udpClient.Send(dgram, dgram.Length, hostname, port);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="udpClient"></param>
		/// <param name="datagram"></param>
		/// <param name="hostname"></param>
		/// <param name="port"></param>
		/// <param name="asyncCallback"></param>
		/// <returns></returns>
		public static IAsyncResult BeginSend(this UdpClient udpClient, byte[] datagram, string hostname, int port, AsyncCallback asyncCallback)
		{
			if (udpClient == null) throw new ArgumentNullException(nameof(udpClient));
			return udpClient.BeginSend(datagram, datagram.Length, hostname, port, asyncCallback, null);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="udpClient"></param>
		/// <param name="datagram"></param>
		/// <param name="hostname"></param>
		/// <param name="port"></param>
		/// <param name="asyncCallback"></param>
		/// <param name="state"></param>
		/// <returns></returns>
		public static IAsyncResult BeginSend(this UdpClient udpClient, byte[] datagram, string hostname, int port, AsyncCallback asyncCallback, object state)
		{
			if (udpClient == null) throw new ArgumentNullException(nameof(udpClient));
			return udpClient.BeginSend(datagram, datagram.Length, hostname, port, asyncCallback, state);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="udpClient"></param>
		/// <param name="datagram"></param>
		/// <param name="bytes"></param>
		/// <param name="hostname"></param>
		/// <param name="port"></param>
		/// <param name="asyncCallback"></param>
		/// <param name="state"></param>
		/// <returns></returns>
		public static IAsyncResult BeginSend(this UdpClient udpClient, byte[] datagram, int bytes, string hostname, int port, AsyncCallback asyncCallback, object state)
		{
			if (udpClient == null) throw new ArgumentNullException(nameof(udpClient));
			return udpClient.BeginSend(datagram, bytes, hostname, port, asyncCallback, state);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="udpClient"></param>
		/// <param name="datagram"></param>
		/// <param name="asyncCallback"></param>
		/// <param name="state"></param>
		/// <returns></returns>
		public static IAsyncResult BeginSend(this UdpClient udpClient, byte[] datagram, AsyncCallback asyncCallback, object state)
		{
			if (udpClient == null) throw new ArgumentNullException(nameof(udpClient));
			return udpClient.BeginSend(datagram, datagram.Length, asyncCallback, state);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="udpClient"></param>
		/// <param name="datagram"></param>
		/// <param name="bytes"></param>
		/// <param name="asyncCallback"></param>
		/// <param name="state"></param>
		/// <returns></returns>
		public static IAsyncResult BeginSend(this UdpClient udpClient, byte[] datagram, int bytes, AsyncCallback asyncCallback, object state)
		{
			if (udpClient == null) throw new ArgumentNullException(nameof(udpClient));
			return udpClient.BeginSend(datagram, bytes, asyncCallback, state);
		}

#pragma warning disable CS1572 // XML comment has a param tag for 'bytes', but there is no parameter by that name
#pragma warning disable CS1573 // Parameter 'endPoint' has no matching param tag in the XML comment for 'UdpClientable.BeginSend(UdpClient, byte[], IPEndPoint, AsyncCallback)' (but other parameters do)
#pragma warning disable CS1572 // XML comment has a param tag for 'state', but there is no parameter by that name
		/// <summary>
		/// 
		/// </summary>
		/// <param name="udpClient"></param>
		/// <param name="datagram"></param>
		/// <param name="bytes"></param>
		/// <param name="asyncCallback"></param>
		/// <param name="state"></param>
		/// <returns></returns>
		public static IAsyncResult BeginSend(this UdpClient udpClient, byte[] datagram, IPEndPoint endPoint, AsyncCallback asyncCallback)
#pragma warning restore CS1572 // XML comment has a param tag for 'state', but there is no parameter by that name
#pragma warning restore CS1573 // Parameter 'endPoint' has no matching param tag in the XML comment for 'UdpClientable.BeginSend(UdpClient, byte[], IPEndPoint, AsyncCallback)' (but other parameters do)
#pragma warning restore CS1572 // XML comment has a param tag for 'bytes', but there is no parameter by that name
		{
			if (udpClient == null) throw new ArgumentNullException(nameof(udpClient));
			return udpClient.BeginSend(datagram, datagram.Length, endPoint, asyncCallback, null);
		}

#pragma warning disable CS1572 // XML comment has a param tag for 'bytes', but there is no parameter by that name
#pragma warning disable CS1573 // Parameter 'endPoint' has no matching param tag in the XML comment for 'UdpClientable.BeginSend(UdpClient, byte[], IPEndPoint, AsyncCallback, object)' (but other parameters do)
		/// <summary>
		/// 
		/// </summary>
		/// <param name="udpClient"></param>
		/// <param name="datagram"></param>
		/// <param name="bytes"></param>
		/// <param name="asyncCallback"></param>
		/// <param name="state"></param>
		/// <returns></returns>
		public static IAsyncResult BeginSend(this UdpClient udpClient, byte[] datagram, IPEndPoint endPoint, AsyncCallback asyncCallback, object state)
#pragma warning restore CS1573 // Parameter 'endPoint' has no matching param tag in the XML comment for 'UdpClientable.BeginSend(UdpClient, byte[], IPEndPoint, AsyncCallback, object)' (but other parameters do)
#pragma warning restore CS1572 // XML comment has a param tag for 'bytes', but there is no parameter by that name
		{
			if (udpClient == null) throw new ArgumentNullException(nameof(udpClient));
			return udpClient.BeginSend(datagram, datagram.Length, endPoint, asyncCallback, state);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="udpClient"></param>
		/// <param name="datagram"></param>
		/// <param name="asyncCallback"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentNullException"></exception>
		public static IAsyncResult BeginSend(this UdpClient udpClient, byte[] datagram, AsyncCallback asyncCallback)
		{
			if (udpClient == null) throw new ArgumentNullException(nameof(udpClient));
			return udpClient.BeginSend(datagram, datagram.Length, asyncCallback);
		}
#if (NET47)
		public static Task<int> SendAsync(this UdpClient udpClient, byte[] datagram)
		{
			if (udpClient == null) throw new ArgumentNullException(nameof(udpClient));
			return udpClient.SendAsync(datagram, datagram.Length);
		}

		public static Task<int> SendAsync(this UdpClient udpClient, byte[] datagram, IPEndPoint endPoint)
		{
			if (udpClient == null) throw new ArgumentNullException(nameof(udpClient));
			return udpClient.SendAsync(datagram, datagram.Length, endPoint);
		}

		public static Task<int> SendAsync(this UdpClient udpClient, byte[] datagram, string hostname, int port)
		{
			if (udpClient == null) throw new ArgumentNullException(nameof(udpClient));
			return udpClient.SendAsync(datagram, datagram.Length, hostname, port);
		}

		public static Task<int> SendAsync(this UdpClient udpClient, byte[] datagram, DnsEndPoint dnsEndPoint)
		{
			if (udpClient == null) throw new ArgumentNullException(nameof(udpClient));
			if (dnsEndPoint == null) throw new ArgumentNullException(nameof(dnsEndPoint));
			return udpClient.SendAsync(datagram, datagram.Length, dnsEndPoint.Host, dnsEndPoint.Port);
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
		/// Extends ReadContentAs so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// xmlreader.ReadContentAs&lt;int&gt;(namespaceResolver);
		/// </example>
		/// </summary>
		public static T ReadContentAs<T>(this XmlReader xmlreader, IXmlNamespaceResolver namespaceResolver)
		{
			if(xmlreader == null) throw new ArgumentNullException("xmlreader");

			return (T)xmlreader.ReadContentAs(typeof(T), namespaceResolver);
		}

		/// <summary>
		/// Extends ReadElementContentAs so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// xmlreader.ReadElementContentAs&lt;int&gt;(namespaceResolver);
		/// </example>
		/// </summary>
		public static T ReadElementContentAs<T>(this XmlReader xmlreader, IXmlNamespaceResolver namespaceResolver)
		{
			if(xmlreader == null) throw new ArgumentNullException("xmlreader");

			return (T)xmlreader.ReadElementContentAs(typeof(T), namespaceResolver);
		}

		/// <summary>
		/// Extends ReadElementContentAs so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// xmlreader.ReadElementContentAs&lt;int&gt;(namespaceResolver, localName, namespaceURI);
		/// </example>
		/// </summary>
		public static T ReadElementContentAs<T>(this XmlReader xmlreader, IXmlNamespaceResolver namespaceResolver, String localName, String namespaceURI)
		{
			if(xmlreader == null) throw new ArgumentNullException("xmlreader");

			return (T)xmlreader.ReadElementContentAs(typeof(T), namespaceResolver, localName, namespaceURI);
		}

		/// <summary>
		/// Extends ReadContentAsBase64 so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// xmlreader.ReadContentAsBase64(buffer);
		/// </example>
		/// </summary>
		public static Int32 ReadContentAsBase64(this XmlReader xmlreader, Byte[] buffer)
		{
			if(xmlreader == null) throw new ArgumentNullException("xmlreader");

			if(buffer == null) throw new ArgumentNullException("buffer");

			return xmlreader.ReadContentAsBase64(buffer, 0, buffer.Length);
		}

		/// <summary>
		/// Extends ReadElementContentAsBase64 so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// xmlreader.ReadElementContentAsBase64(buffer);
		/// </example>
		/// </summary>
		public static Int32 ReadElementContentAsBase64(this XmlReader xmlreader, Byte[] buffer)
		{
			if(xmlreader == null) throw new ArgumentNullException("xmlreader");

			if(buffer == null) throw new ArgumentNullException("buffer");

			return xmlreader.ReadElementContentAsBase64(buffer, 0, buffer.Length);
		}

		/// <summary>
		/// Extends ReadContentAsBinHex so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// xmlreader.ReadContentAsBinHex(buffer);
		/// </example>
		/// </summary>
		public static Int32 ReadContentAsBinHex(this XmlReader xmlreader, Byte[] buffer)
		{
			if(xmlreader == null) throw new ArgumentNullException("xmlreader");

			if(buffer == null) throw new ArgumentNullException("buffer");

			return xmlreader.ReadContentAsBinHex(buffer, 0, buffer.Length);
		}

		/// <summary>
		/// Extends ReadElementContentAsBinHex so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// xmlreader.ReadElementContentAsBinHex(buffer);
		/// </example>
		/// </summary>
		public static Int32 ReadElementContentAsBinHex(this XmlReader xmlreader, Byte[] buffer)
		{
			if(xmlreader == null) throw new ArgumentNullException("xmlreader");

			if(buffer == null) throw new ArgumentNullException("buffer");

			return xmlreader.ReadElementContentAsBinHex(buffer, 0, buffer.Length);
		}

		/// <summary>
		/// Extends ReadValueChunk so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// xmlreader.ReadValueChunk(buffer);
		/// </example>
		/// </summary>
		public static Int32 ReadValueChunk(this XmlReader xmlreader, Char[] buffer)
		{
			if(xmlreader == null) throw new ArgumentNullException("xmlreader");

			if(buffer == null) throw new ArgumentNullException("buffer");

			return xmlreader.ReadValueChunk(buffer, 0, buffer.Length);
		}

	}
}
#endif