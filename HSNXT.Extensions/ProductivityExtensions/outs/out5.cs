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
        /// Extends BeginRead so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// pipestream.BeginRead(buffer, offset, count, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginRead(this AnonymousPipeClientStream pipestream, Byte[] buffer, Int32 offset,
            Int32 count, AsyncCallback callback)
        {
            if (pipestream == null) throw new ArgumentNullException("pipestream");

            return pipestream.BeginRead(buffer, offset, count, callback, null);
        }

        /// <summary>
        /// Extends BeginRead so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// pipestream.BeginRead(buffer, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginRead(this AnonymousPipeClientStream pipestream, Byte[] buffer,
            AsyncCallback callback)
        {
            if (pipestream == null) throw new ArgumentNullException("pipestream");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return pipestream.BeginRead(buffer, 0, buffer.Length, callback);
        }

        /// <summary>
        /// Extends BeginWrite so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// pipestream.BeginWrite(buffer, offset, count, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginWrite(this AnonymousPipeClientStream pipestream, Byte[] buffer, Int32 offset,
            Int32 count, AsyncCallback callback)
        {
            if (pipestream == null) throw new ArgumentNullException("pipestream");

            return pipestream.BeginWrite(buffer, offset, count, callback, null);
        }

        /// <summary>
        /// Extends BeginWrite so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// pipestream.BeginWrite(buffer, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginWrite(this AnonymousPipeClientStream pipestream, Byte[] buffer,
            AsyncCallback callback)
        {
            if (pipestream == null) throw new ArgumentNullException("pipestream");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return pipestream.BeginWrite(buffer, 0, buffer.Length, callback);
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
        /// Extends BeginRead so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// pipestream.BeginRead(buffer, offset, count, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginRead(this AnonymousPipeServerStream pipestream, Byte[] buffer, Int32 offset,
            Int32 count, AsyncCallback callback)
        {
            if (pipestream == null) throw new ArgumentNullException("pipestream");

            return pipestream.BeginRead(buffer, offset, count, callback, null);
        }

        /// <summary>
        /// Extends BeginRead so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// pipestream.BeginRead(buffer, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginRead(this AnonymousPipeServerStream pipestream, Byte[] buffer,
            AsyncCallback callback)
        {
            if (pipestream == null) throw new ArgumentNullException("pipestream");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return pipestream.BeginRead(buffer, 0, buffer.Length, callback);
        }

        /// <summary>
        /// Extends BeginWrite so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// pipestream.BeginWrite(buffer, offset, count, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginWrite(this AnonymousPipeServerStream pipestream, Byte[] buffer, Int32 offset,
            Int32 count, AsyncCallback callback)
        {
            if (pipestream == null) throw new ArgumentNullException("pipestream");

            return pipestream.BeginWrite(buffer, offset, count, callback, null);
        }

        /// <summary>
        /// Extends BeginWrite so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// pipestream.BeginWrite(buffer, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginWrite(this AnonymousPipeServerStream pipestream, Byte[] buffer,
            AsyncCallback callback)
        {
            if (pipestream == null) throw new ArgumentNullException("pipestream");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return pipestream.BeginWrite(buffer, 0, buffer.Length, callback);
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
        /// Extends BeginRead so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// stream.BeginRead(buffer, offset, count, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginRead(this AuthenticatedStream stream, Byte[] buffer, Int32 offset, Int32 count,
            AsyncCallback callback)
        {
            if (stream == null) throw new ArgumentNullException("stream");

            return stream.BeginRead(buffer, offset, count, callback, null);
        }

        /// <summary>
        /// Extends BeginRead so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// stream.BeginRead(buffer, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginRead(this AuthenticatedStream stream, Byte[] buffer, AsyncCallback callback)
        {
            if (stream == null) throw new ArgumentNullException("stream");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return stream.BeginRead(buffer, 0, buffer.Length, callback);
        }

        /// <summary>
        /// Extends BeginWrite so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// stream.BeginWrite(buffer, offset, count, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginWrite(this AuthenticatedStream stream, Byte[] buffer, Int32 offset, Int32 count,
            AsyncCallback callback)
        {
            if (stream == null) throw new ArgumentNullException("stream");

            return stream.BeginWrite(buffer, offset, count, callback, null);
        }

        /// <summary>
        /// Extends BeginWrite so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// stream.BeginWrite(buffer, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginWrite(this AuthenticatedStream stream, Byte[] buffer, AsyncCallback callback)
        {
            if (stream == null) throw new ArgumentNullException("stream");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return stream.BeginWrite(buffer, 0, buffer.Length, callback);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NETSTANDARD2_0 || NET47)

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginRead so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// stream.BeginRead(buffer, offset, count, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginRead(this BufferedStream stream, Byte[] buffer, Int32 offset, Int32 count,
            AsyncCallback callback)
        {
            if (stream == null) throw new ArgumentNullException("stream");

            return stream.BeginRead(buffer, offset, count, callback, null);
        }

        /// <summary>
        /// Extends BeginRead so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// stream.BeginRead(buffer, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginRead(this BufferedStream stream, Byte[] buffer, AsyncCallback callback)
        {
            if (stream == null) throw new ArgumentNullException("stream");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return stream.BeginRead(buffer, 0, buffer.Length, callback);
        }

        /// <summary>
        /// Extends BeginWrite so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// stream.BeginWrite(buffer, offset, count, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginWrite(this BufferedStream stream, Byte[] buffer, Int32 offset, Int32 count,
            AsyncCallback callback)
        {
            if (stream == null) throw new ArgumentNullException("stream");

            return stream.BeginWrite(buffer, offset, count, callback, null);
        }

        /// <summary>
        /// Extends BeginWrite so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// stream.BeginWrite(buffer, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginWrite(this BufferedStream stream, Byte[] buffer, AsyncCallback callback)
        {
            if (stream == null) throw new ArgumentNullException("stream");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return stream.BeginWrite(buffer, 0, buffer.Length, callback);
        }
    }
}
#endif
#if (NETSTANDARD1_6 || NETSTANDARD2_0 || NET47)

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginRead so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// stream.BeginRead(buffer, offset, count, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginRead(this CryptoStream stream, Byte[] buffer, Int32 offset, Int32 count,
            AsyncCallback callback)
        {
            if (stream == null) throw new ArgumentNullException("stream");

            return stream.BeginRead(buffer, offset, count, callback, null);
        }

        /// <summary>
        /// Extends BeginRead so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// stream.BeginRead(buffer, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginRead(this CryptoStream stream, Byte[] buffer, AsyncCallback callback)
        {
            if (stream == null) throw new ArgumentNullException("stream");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return stream.BeginRead(buffer, 0, buffer.Length, callback);
        }

        /// <summary>
        /// Extends BeginWrite so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// stream.BeginWrite(buffer, offset, count, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginWrite(this CryptoStream stream, Byte[] buffer, Int32 offset, Int32 count,
            AsyncCallback callback)
        {
            if (stream == null) throw new ArgumentNullException("stream");

            return stream.BeginWrite(buffer, offset, count, callback, null);
        }

        /// <summary>
        /// Extends BeginWrite so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// stream.BeginWrite(buffer, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginWrite(this CryptoStream stream, Byte[] buffer, AsyncCallback callback)
        {
            if (stream == null) throw new ArgumentNullException("stream");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return stream.BeginWrite(buffer, 0, buffer.Length, callback);
        }
    }
}
#endif

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends GetCharCount so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// decoder.GetCharCount(bytes);
        /// </example>
        /// </summary>
        public static Int32 GetCharCount(this Decoder decoder, Byte[] bytes)
        {
            if (decoder == null) throw new ArgumentNullException("decoder");

            if (bytes == null) throw new ArgumentNullException("bytes");

            return decoder.GetCharCount(bytes, 0, bytes.Length);
        }

        /// <summary>
        /// Extends GetCharCount so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// decoder.GetCharCount(bytes, flush);
        /// </example>
        /// </summary>
        public static Int32 GetCharCount(this Decoder decoder, Byte[] bytes, Boolean flush)
        {
            if (decoder == null) throw new ArgumentNullException("decoder");

            if (bytes == null) throw new ArgumentNullException("bytes");

            return decoder.GetCharCount(bytes, 0, bytes.Length, flush);
        }

        /// <summary>
        /// Extends GetChars so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// decoder.GetChars(bytes, chars, charIndex);
        /// </example>
        /// </summary>
        public static Int32 GetChars(this Decoder decoder, Byte[] bytes, Char[] chars, Int32 charIndex)
        {
            if (decoder == null) throw new ArgumentNullException("decoder");

            if (bytes == null) throw new ArgumentNullException("bytes");

            return decoder.GetChars(bytes, 0, bytes.Length, chars, charIndex);
        }

        /// <summary>
        /// Extends GetChars so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// decoder.GetChars(bytes, chars, charIndex, flush);
        /// </example>
        /// </summary>
        public static Int32 GetChars(this Decoder decoder, Byte[] bytes, Char[] chars, Int32 charIndex, Boolean flush)
        {
            if (decoder == null) throw new ArgumentNullException("decoder");

            if (bytes == null) throw new ArgumentNullException("bytes");

            return decoder.GetChars(bytes, 0, bytes.Length, chars, charIndex, flush);
        }

        /// <summary>
        /// Extends Convert so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// decoder.Convert(bytes, chars, charIndex, charCount, flush, bytesUsed, charsUsed, completed);
        /// </example>
        /// </summary>
        public static void Convert(this Decoder decoder, Byte[] bytes, Char[] chars, Int32 charIndex, Int32 charCount,
            Boolean flush, out Int32 bytesUsed, out Int32 charsUsed, out Boolean completed)
        {
            if (decoder == null) throw new ArgumentNullException("decoder");

            if (bytes == null) throw new ArgumentNullException("bytes");

            decoder.Convert(bytes, 0, bytes.Length, chars, charIndex, charCount, flush, out bytesUsed, out charsUsed,
                out completed);
        }
    }
}
#if (NETSTANDARD2_0 || NET47)

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends BeginRead so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// deflatestream.BeginRead(array, offset, count, asyncCallback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginRead(this DeflateStream deflatestream, Byte[] array, Int32 offset, Int32 count,
            AsyncCallback asyncCallback)
        {
            if (deflatestream == null) throw new ArgumentNullException("deflatestream");

            return deflatestream.BeginRead(array, offset, count, asyncCallback, null);
        }

        /// <summary>
        /// Extends BeginRead so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// deflatestream.BeginRead(array, asyncCallback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginRead(this DeflateStream deflatestream, Byte[] array,
            AsyncCallback asyncCallback)
        {
            if (deflatestream == null) throw new ArgumentNullException("deflatestream");

            if (array == null) throw new ArgumentNullException("array");

            return deflatestream.BeginRead(array, 0, array.Length, asyncCallback);
        }

        /// <summary>
        /// Extends BeginWrite so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// deflatestream.BeginWrite(array, offset, count, asyncCallback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginWrite(this DeflateStream deflatestream, Byte[] array, Int32 offset, Int32 count,
            AsyncCallback asyncCallback)
        {
            if (deflatestream == null) throw new ArgumentNullException("deflatestream");

            return deflatestream.BeginWrite(array, offset, count, asyncCallback, null);
        }

        /// <summary>
        /// Extends BeginWrite so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// deflatestream.BeginWrite(array, asyncCallback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginWrite(this DeflateStream deflatestream, Byte[] array,
            AsyncCallback asyncCallback)
        {
            if (deflatestream == null) throw new ArgumentNullException("deflatestream");

            if (array == null) throw new ArgumentNullException("array");

            return deflatestream.BeginWrite(array, 0, array.Length, asyncCallback);
        }
    }
}
#endif

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Extends GetByteCount so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// encoder.GetByteCount(chars, flush);
        /// </example>
        /// </summary>
        public static Int32 GetByteCount(this System.Text.Encoder encoder, Char[] chars, Boolean flush)
        {
            if (encoder == null) throw new ArgumentNullException("encoder");

            if (chars == null) throw new ArgumentNullException("chars");

            return encoder.GetByteCount(chars, 0, chars.Length, flush);
        }

        /// <summary>
        /// Extends GetBytes so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// encoder.GetBytes(chars, bytes, byteIndex, flush);
        /// </example>
        /// </summary>
        public static Int32 GetBytes(this System.Text.Encoder encoder, Char[] chars, Byte[] bytes, Int32 byteIndex,
            Boolean flush)
        {
            if (encoder == null) throw new ArgumentNullException("encoder");

            if (chars == null) throw new ArgumentNullException("chars");

            return encoder.GetBytes(chars, 0, chars.Length, bytes, byteIndex, flush);
        }

        /// <summary>
        /// Extends Convert so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// encoder.Convert(chars, bytes, byteIndex, byteCount, flush, charsUsed, bytesUsed, completed);
        /// </example>
        /// </summary>
        public static void Convert(this System.Text.Encoder encoder, Char[] chars, Byte[] bytes, Int32 byteIndex,
            Int32 byteCount, Boolean flush, out Int32 charsUsed, out Int32 bytesUsed, out Boolean completed)
        {
            if (encoder == null) throw new ArgumentNullException("encoder");

            if (chars == null) throw new ArgumentNullException("chars");

            encoder.Convert(chars, 0, chars.Length, bytes, byteIndex, byteCount, flush, out charsUsed, out bytesUsed,
                out completed);
        }

#if (NETSTANDARD2_0 || NET47)

#if (NETSTANDARD2_0 || NET47)
        /// <summary>
        /// Extends BeginRead so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// filestream.BeginRead(array, offset, numBytes, userCallback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginRead(this FileStream filestream, Byte[] array, Int32 offset, Int32 numBytes,
            AsyncCallback userCallback)
        {
            if (filestream == null) throw new ArgumentNullException("filestream");

            return filestream.BeginRead(array, offset, numBytes, userCallback, null);
        }

        /// <summary>
        /// Extends BeginRead so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// filestream.BeginRead(array, userCallback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginRead(this FileStream filestream, Byte[] array, AsyncCallback userCallback)
        {
            if (filestream == null) throw new ArgumentNullException("filestream");

            if (array == null) throw new ArgumentNullException("array");

            return filestream.BeginRead(array, 0, array.Length, userCallback);
        }

        /// <summary>
        /// Extends BeginWrite so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// filestream.BeginWrite(array, offset, numBytes, userCallback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginWrite(this FileStream filestream, Byte[] array, Int32 offset, Int32 numBytes,
            AsyncCallback userCallback)
        {
            if (filestream == null) throw new ArgumentNullException("filestream");

            return filestream.BeginWrite(array, offset, numBytes, userCallback, null);
        }

        /// <summary>
        /// Extends BeginWrite so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// filestream.BeginWrite(array, userCallback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginWrite(this FileStream filestream, Byte[] array, AsyncCallback userCallback)
        {
            if (filestream == null) throw new ArgumentNullException("filestream");

            if (array == null) throw new ArgumentNullException("array");

            return filestream.BeginWrite(array, 0, array.Length, userCallback);
        }
#endif

#endif
#if (NETSTANDARD2_0 || NETSTANDARD1_2 || NETSTANDARD1_1 || NET47)

#if (NETSTANDARD2_0 || NET47)
        /// <summary>
        /// Extends BeginRead so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// gzipstream.BeginRead(array, offset, count, asyncCallback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginRead(this GZipStream gzipstream, Byte[] array, Int32 offset, Int32 count,
            AsyncCallback asyncCallback)
        {
            if (gzipstream == null) throw new ArgumentNullException("gzipstream");

            return gzipstream.BeginRead(array, offset, count, asyncCallback, null);
        }

        /// <summary>
        /// Extends BeginRead so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// gzipstream.BeginRead(array, asyncCallback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginRead(this GZipStream gzipstream, Byte[] array, AsyncCallback asyncCallback)
        {
            if (gzipstream == null) throw new ArgumentNullException("gzipstream");

            if (array == null) throw new ArgumentNullException("array");

            return gzipstream.BeginRead(array, 0, array.Length, asyncCallback);
        }

        /// <summary>
        /// Extends BeginWrite so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// gzipstream.BeginWrite(array, offset, count, asyncCallback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginWrite(this GZipStream gzipstream, Byte[] array, Int32 offset, Int32 count,
            AsyncCallback asyncCallback)
        {
            if (gzipstream == null) throw new ArgumentNullException("gzipstream");

            return gzipstream.BeginWrite(array, offset, count, asyncCallback, null);
        }

        /// <summary>
        /// Extends BeginWrite so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// gzipstream.BeginWrite(array, asyncCallback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginWrite(this GZipStream gzipstream, Byte[] array, AsyncCallback asyncCallback)
        {
            if (gzipstream == null) throw new ArgumentNullException("gzipstream");

            if (array == null) throw new ArgumentNullException("array");

            return gzipstream.BeginWrite(array, 0, array.Length, asyncCallback);
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
#if (NETSTANDARD2_0 || NET47)
        /// <summary>
        /// Extends TransformBlock so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// hashalgorithm.TransformBlock(inputBuffer, outputBuffer, outputOffset);
        /// </example>
        /// </summary>
        public static Int32 TransformBlock(this HashAlgorithm hashalgorithm, Byte[] inputBuffer, Byte[] outputBuffer,
            Int32 outputOffset)
        {
            if (hashalgorithm == null) throw new ArgumentNullException("hashalgorithm");

            if (inputBuffer == null) throw new ArgumentNullException("inputBuffer");

            return hashalgorithm.TransformBlock(inputBuffer, 0, inputBuffer.Length, outputBuffer, outputOffset);
        }

        /// <summary>
        /// Extends TransformFinalBlock so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// hashalgorithm.TransformFinalBlock(inputBuffer);
        /// </example>
        /// </summary>
        public static Byte[] TransformFinalBlock(this HashAlgorithm hashalgorithm, Byte[] inputBuffer)
        {
            if (hashalgorithm == null) throw new ArgumentNullException("hashalgorithm");

            if (inputBuffer == null) throw new ArgumentNullException("inputBuffer");

            return hashalgorithm.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);
        }
#endif
    }
}
#endif

#if (NETSTANDARD2_0 || NET47)
//////////////////////////////////////////////////////////////////////
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
// 	- Frans Bouma [FB]
//////////////////////////////////////////////////////////////////////

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// A safe close routine for a database connection, which can also dispose the connection, if required.
        /// </summary>
        /// <param name="toClose">the connection to close</param>
        /// <param name="dispose">if set to true, it will also dispose the connection.</param>
        // PR: was an extension on DbConnection without a default on dispose
        public static void SafeClose(this IDbConnection toClose, bool dispose = false)
        {
            if (toClose == null)
            {
                return;
            }

            if (toClose.State != ConnectionState.Closed)
            {
                toClose.Close();
            }

            if (dispose)
            {
                toClose.Dispose();
            }
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
        /// Extends BeginRead so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// isolatedstoragefilestream.BeginRead(buffer, offset, numBytes, userCallback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginRead(this IsolatedStorageFileStream isolatedstoragefilestream, Byte[] buffer,
            Int32 offset, Int32 numBytes, AsyncCallback userCallback)
        {
            if (isolatedstoragefilestream == null) throw new ArgumentNullException("isolatedstoragefilestream");

            return isolatedstoragefilestream.BeginRead(buffer, offset, numBytes, userCallback, null);
        }

        /// <summary>
        /// Extends BeginRead so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// isolatedstoragefilestream.BeginRead(buffer, userCallback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginRead(this IsolatedStorageFileStream isolatedstoragefilestream, Byte[] buffer,
            AsyncCallback userCallback)
        {
            if (isolatedstoragefilestream == null) throw new ArgumentNullException("isolatedstoragefilestream");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return isolatedstoragefilestream.BeginRead(buffer, 0, buffer.Length, userCallback);
        }

        /// <summary>
        /// Extends BeginWrite so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// isolatedstoragefilestream.BeginWrite(buffer, offset, numBytes, userCallback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginWrite(this IsolatedStorageFileStream isolatedstoragefilestream, Byte[] buffer,
            Int32 offset, Int32 numBytes, AsyncCallback userCallback)
        {
            if (isolatedstoragefilestream == null) throw new ArgumentNullException("isolatedstoragefilestream");

            return isolatedstoragefilestream.BeginWrite(buffer, offset, numBytes, userCallback, null);
        }

        /// <summary>
        /// Extends BeginWrite so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// isolatedstoragefilestream.BeginWrite(buffer, userCallback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginWrite(this IsolatedStorageFileStream isolatedstoragefilestream, Byte[] buffer,
            AsyncCallback userCallback)
        {
            if (isolatedstoragefilestream == null) throw new ArgumentNullException("isolatedstoragefilestream");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return isolatedstoragefilestream.BeginWrite(buffer, 0, buffer.Length, userCallback);
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
        /// Extends BeginRead so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// stream.BeginRead(buffer, offset, count, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginRead(this MemoryMappedViewStream stream, Byte[] buffer, Int32 offset,
            Int32 count, AsyncCallback callback)
        {
            if (stream == null) throw new ArgumentNullException("stream");

            return stream.BeginRead(buffer, offset, count, callback, null);
        }

        /// <summary>
        /// Extends BeginRead so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// stream.BeginRead(buffer, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginRead(this MemoryMappedViewStream stream, Byte[] buffer, AsyncCallback callback)
        {
            if (stream == null) throw new ArgumentNullException("stream");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return stream.BeginRead(buffer, 0, buffer.Length, callback);
        }

        /// <summary>
        /// Extends BeginWrite so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// stream.BeginWrite(buffer, offset, count, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginWrite(this MemoryMappedViewStream stream, Byte[] buffer, Int32 offset,
            Int32 count, AsyncCallback callback)
        {
            if (stream == null) throw new ArgumentNullException("stream");

            return stream.BeginWrite(buffer, offset, count, callback, null);
        }

        /// <summary>
        /// Extends BeginWrite so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// stream.BeginWrite(buffer, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginWrite(this MemoryMappedViewStream stream, Byte[] buffer, AsyncCallback callback)
        {
            if (stream == null) throw new ArgumentNullException("stream");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return stream.BeginWrite(buffer, 0, buffer.Length, callback);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NETSTANDARD1_2 || NETSTANDARD1_1 || NETSTANDARD1_0 || NET47)

namespace HSNXT
{
    public static partial class Extensions
    {
#if (NETSTANDARD2_0 || NET47)
        /// <summary>
        /// Extends BeginRead so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// stream.BeginRead(buffer, offset, count, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginRead(this MemoryStream stream, Byte[] buffer, Int32 offset, Int32 count,
            AsyncCallback callback)
        {
            if (stream == null) throw new ArgumentNullException("stream");

            return stream.BeginRead(buffer, offset, count, callback, null);
        }

        /// <summary>
        /// Extends BeginRead so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// stream.BeginRead(buffer, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginRead(this MemoryStream stream, Byte[] buffer, AsyncCallback callback)
        {
            if (stream == null) throw new ArgumentNullException("stream");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return stream.BeginRead(buffer, 0, buffer.Length, callback);
        }

        /// <summary>
        /// Extends BeginWrite so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// stream.BeginWrite(buffer, offset, count, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginWrite(this MemoryStream stream, Byte[] buffer, Int32 offset, Int32 count,
            AsyncCallback callback)
        {
            if (stream == null) throw new ArgumentNullException("stream");

            return stream.BeginWrite(buffer, offset, count, callback, null);
        }

        /// <summary>
        /// Extends BeginWrite so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// stream.BeginWrite(buffer, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginWrite(this MemoryStream stream, Byte[] buffer, AsyncCallback callback)
        {
            if (stream == null) throw new ArgumentNullException("stream");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return stream.BeginWrite(buffer, 0, buffer.Length, callback);
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
        /// Extends BeginRead so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// pipestream.BeginRead(buffer, offset, count, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginRead(this NamedPipeClientStream pipestream, Byte[] buffer, Int32 offset,
            Int32 count, AsyncCallback callback)
        {
            if (pipestream == null) throw new ArgumentNullException("pipestream");

            return pipestream.BeginRead(buffer, offset, count, callback, null);
        }

        /// <summary>
        /// Extends BeginRead so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// pipestream.BeginRead(buffer, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginRead(this NamedPipeClientStream pipestream, Byte[] buffer,
            AsyncCallback callback)
        {
            if (pipestream == null) throw new ArgumentNullException("pipestream");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return pipestream.BeginRead(buffer, 0, buffer.Length, callback);
        }

        /// <summary>
        /// Extends BeginWrite so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// pipestream.BeginWrite(buffer, offset, count, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginWrite(this NamedPipeClientStream pipestream, Byte[] buffer, Int32 offset,
            Int32 count, AsyncCallback callback)
        {
            if (pipestream == null) throw new ArgumentNullException("pipestream");

            return pipestream.BeginWrite(buffer, offset, count, callback, null);
        }

        /// <summary>
        /// Extends BeginWrite so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// pipestream.BeginWrite(buffer, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginWrite(this NamedPipeClientStream pipestream, Byte[] buffer,
            AsyncCallback callback)
        {
            if (pipestream == null) throw new ArgumentNullException("pipestream");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return pipestream.BeginWrite(buffer, 0, buffer.Length, callback);
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
        /// Extends BeginWaitForConnection so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// namedpipeserverstream.BeginWaitForConnection(callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginWaitForConnection(this NamedPipeServerStream namedpipeserverstream,
            AsyncCallback callback)
        {
            if (namedpipeserverstream == null) throw new ArgumentNullException("namedpipeserverstream");

            return namedpipeserverstream.BeginWaitForConnection(callback, null);
        }

        /// <summary>
        /// Extends BeginRead so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// pipestream.BeginRead(buffer, offset, count, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginRead(this NamedPipeServerStream pipestream, Byte[] buffer, Int32 offset,
            Int32 count, AsyncCallback callback)
        {
            if (pipestream == null) throw new ArgumentNullException("pipestream");

            return pipestream.BeginRead(buffer, offset, count, callback, null);
        }

        /// <summary>
        /// Extends BeginRead so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// pipestream.BeginRead(buffer, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginRead(this NamedPipeServerStream pipestream, Byte[] buffer,
            AsyncCallback callback)
        {
            if (pipestream == null) throw new ArgumentNullException("pipestream");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return pipestream.BeginRead(buffer, 0, buffer.Length, callback);
        }

        /// <summary>
        /// Extends BeginWrite so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// pipestream.BeginWrite(buffer, offset, count, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginWrite(this NamedPipeServerStream pipestream, Byte[] buffer, Int32 offset,
            Int32 count, AsyncCallback callback)
        {
            if (pipestream == null) throw new ArgumentNullException("pipestream");

            return pipestream.BeginWrite(buffer, offset, count, callback, null);
        }

        /// <summary>
        /// Extends BeginWrite so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// pipestream.BeginWrite(buffer, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginWrite(this NamedPipeServerStream pipestream, Byte[] buffer,
            AsyncCallback callback)
        {
            if (pipestream == null) throw new ArgumentNullException("pipestream");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return pipestream.BeginWrite(buffer, 0, buffer.Length, callback);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NETSTANDARD1_2 || NETSTANDARD1_1 || NET47)

namespace HSNXT
{
    public static partial class Extensions
    {
#if (NETSTANDARD2_0 || NET47)
        /// <summary>
        /// Extends BeginRead so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// networkstream.BeginRead(buffer, offset, size, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginRead(this NetworkStream networkstream, Byte[] buffer, Int32 offset, Int32 size,
            AsyncCallback callback)
        {
            if (networkstream == null) throw new ArgumentNullException("networkstream");

            return networkstream.BeginRead(buffer, offset, size, callback, null);
        }

        /// <summary>
        /// Extends BeginRead so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// networkstream.BeginRead(buffer, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginRead(this NetworkStream networkstream, Byte[] buffer, AsyncCallback callback)
        {
            if (networkstream == null) throw new ArgumentNullException("networkstream");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return networkstream.BeginRead(buffer, 0, buffer.Length, callback);
        }

        /// <summary>
        /// Extends BeginWrite so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// networkstream.BeginWrite(buffer, offset, size, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginWrite(this NetworkStream networkstream, Byte[] buffer, Int32 offset, Int32 size,
            AsyncCallback callback)
        {
            if (networkstream == null) throw new ArgumentNullException("networkstream");

            return networkstream.BeginWrite(buffer, offset, size, callback, null);
        }

        /// <summary>
        /// Extends BeginWrite so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// networkstream.BeginWrite(buffer, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginWrite(this NetworkStream networkstream, Byte[] buffer, AsyncCallback callback)
        {
            if (networkstream == null) throw new ArgumentNullException("networkstream");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return networkstream.BeginWrite(buffer, 0, buffer.Length, callback);
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
        /// Extends BeginRead so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// pipestream.BeginRead(buffer, offset, count, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginRead(this PipeStream pipestream, Byte[] buffer, Int32 offset, Int32 count,
            AsyncCallback callback)
        {
            if (pipestream == null) throw new ArgumentNullException("pipestream");

            return pipestream.BeginRead(buffer, offset, count, callback, null);
        }

        /// <summary>
        /// Extends BeginRead so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// pipestream.BeginRead(buffer, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginRead(this PipeStream pipestream, Byte[] buffer, AsyncCallback callback)
        {
            if (pipestream == null) throw new ArgumentNullException("pipestream");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return pipestream.BeginRead(buffer, 0, buffer.Length, callback);
        }

        /// <summary>
        /// Extends BeginWrite so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// pipestream.BeginWrite(buffer, offset, count, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginWrite(this PipeStream pipestream, Byte[] buffer, Int32 offset, Int32 count,
            AsyncCallback callback)
        {
            if (pipestream == null) throw new ArgumentNullException("pipestream");

            return pipestream.BeginWrite(buffer, offset, count, callback, null);
        }

        /// <summary>
        /// Extends BeginWrite so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// pipestream.BeginWrite(buffer, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginWrite(this PipeStream pipestream, Byte[] buffer, AsyncCallback callback)
        {
            if (pipestream == null) throw new ArgumentNullException("pipestream");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return pipestream.BeginWrite(buffer, 0, buffer.Length, callback);
        }
    }
}
#endif

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Compares two sequences to see if they are equal
        /// </summary>
        /// <remarks>
        /// The default <see cref="EqualityComparer&lt;T&gt;"/> for <typeparamref name="TSource"/> is used
        /// </remarks>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="offsetIntoSecond"></param>
        /// <returns></returns>
        public static bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second,
            int offsetIntoSecond)
        {
            if (first == null)
            {
                throw new ArgumentNullException(nameof(first));
            }

            if (second == null)
            {
                throw new ArgumentNullException(nameof(second));
            }

            var comparer = EqualityComparer<TSource>.Default;
            using (IEnumerator<TSource> e1 = first.GetEnumerator())
            using (IEnumerator<TSource> e2 = second.GetEnumerator())
            {
                for (int i = 0; i < offsetIntoSecond; ++i)
                {
                    e2.MoveNext();
                }

                while (e1.MoveNext())
                {
                    if (!(e2.MoveNext() && comparer.Equals(e1.Current, e2.Current)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Compare percentage equality of one collection to another
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="that"></param>
        /// <param name="equalityComparer"></param>
        /// <returns></returns>
        public static int SequenceEquality<T>(this IEnumerable<T> source, IEnumerable<T> that,
            IEqualityComparer<T> equalityComparer)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (that == null)
            {
                throw new ArgumentNullException(nameof(that));
            }

            var sourceCount = source.Count();
            if (sourceCount == 0)
            {
                return 100;
            }

            var thatCount = that.Count();
            if (thatCount == 0)
            {
                return -100;
            }

            int matches = 0;
            foreach (var e in source)
            {
                if (that.Contains(e, equalityComparer))
                {
                    matches++;
                }
            }

            int p;
            if (sourceCount >= thatCount)
            {
                if (matches == 0)
                {
                    return 100;
                }

                p = matches * 100 / sourceCount;
                return p == 100 ? 0 : p;
            }

            if (matches == 0)
            {
                return -100;
            }

            p = -matches * 100 / thatCount;
            return p == 100 ? 0 : p;
        }
    }
}
#if (NET40 || NET45)
namespace HSNXT
{
    public static partial class Extensions
	{
		/// <summary>
		/// Extends Read so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// serialport.Read(buffer);
		/// </example>
		/// </summary>
		public static Int32 Read(this SerialPort serialport, Byte[] buffer)
		{
			if(serialport == null) throw new ArgumentNullException("serialport");

			if(buffer == null) throw new ArgumentNullException("buffer");

			return serialport.Read(buffer, 0, buffer.Length);
		}

		/// <summary>
		/// Extends Read so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// serialport.Read(buffer);
		/// </example>
		/// </summary>
		public static Int32 Read(this SerialPort serialport, Char[] buffer)
		{
			if(serialport == null) throw new ArgumentNullException("serialport");

			if(buffer == null) throw new ArgumentNullException("buffer");

			return serialport.Read(buffer, 0, buffer.Length);
		}

		/// <summary>
		/// Extends Write so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// serialport.Write(buffer);
		/// </example>
		/// </summary>
		public static void Write(this SerialPort serialport, Char[] buffer)
		{
			if(serialport == null) throw new ArgumentNullException("serialport");

			if(buffer == null) throw new ArgumentNullException("buffer");

			serialport.Write(buffer, 0, buffer.Length);
		}

		/// <summary>
		/// Extends Write so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// serialport.Write(buffer);
		/// </example>
		/// </summary>
		public static void Write(this SerialPort serialport, Byte[] buffer)
		{
			if(serialport == null) throw new ArgumentNullException("serialport");

			if(buffer == null) throw new ArgumentNullException("buffer");

			serialport.Write(buffer, 0, buffer.Length);
		}

	}
}
#endif
#if (NETSTANDARD2_0 || NET47)

namespace HSNXT
{
    public static partial class Extensions
    {
#if NET45
#region based on code from http://blogs.msdn.com/b/pfxteam/archive/2011/12/15/10248293.aspx
		private sealed class SocketAwaitable : IAwaitable
		{
			private static readonly Action SENTINEL = () => { };
			private Action continuation;

			internal readonly SocketAsyncEventArgs EventArgs;

			public SocketAwaitable(SocketAsyncEventArgs eventArgs)
			{
				EventArgs = eventArgs ?? throw new ArgumentNullException(nameof(eventArgs));
				eventArgs.Completed += delegate
				{
					(continuation ?? Interlocked.CompareExchange(
						ref continuation, SENTINEL, null))?.Invoke();
				};
			}

			internal void Reset()
			{
				IsCompleted = false;
				continuation = null;
			}

			public IAwaitable GetAwaiter()
			{
				return this;
			}

			public bool IsCompleted { get; internal set; }

			public void OnCompleted(Action action)
			{
				if (continuation == SENTINEL ||
					Interlocked.CompareExchange(
						ref continuation, action, null) == SENTINEL)
				{
					Task.Run(action);
				}
			}

			public void GetResult()
			{
				if (EventArgs.SocketError != SocketError.Success)
					throw new SocketException((int)EventArgs.SocketError);
			}
		}

		private static IAwaitable SendAsync(this Socket socket,
												 SocketAwaitable awaitable)
		{
			awaitable.Reset();
			if (!socket.SendAsync(awaitable.EventArgs))
				awaitable.IsCompleted = true;
			return awaitable;
		}

		public static IAwaitable SendAsync(this Socket socket, byte[] buffer)
		{
			var args = new SocketAsyncEventArgs();
			args.SetBuffer(buffer);
			var awaitable = new SocketAwaitable(args);
			return socket.SendAsync(awaitable);
		}

		private static SocketAwaitable ReceiveAsync(this Socket socket,
													SocketAwaitable awaitable)
		{
			awaitable.Reset();
			if (!socket.ReceiveAsync(awaitable.EventArgs))
				awaitable.IsCompleted = true;
			return awaitable;
		}

		public static async Task<int> ReceiveAsync(this Socket s, byte[] buffer)
		{
			var args = new SocketAsyncEventArgs();
			args.SetBuffer(buffer);
			var awaitable = new SocketAwaitable(args);
			int totalBytesRead = 0;
			while (true)
			{
				await s.ReceiveAsync(awaitable);
				int bytesRead = args.BytesTransferred;
				if (bytesRead <= 0) break;
				totalBytesRead = bytesRead;
			}
			return totalBytesRead;
		}
#endregion msdn blog
#endif // NET4_5
    }
}
#endif
#if (NETSTANDARD1_6 || NET47)
namespace HSNXT
{
    public static partial class Extensions
	{
		/// <summary>
		/// Extends BeginExecuteNonQuery so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// sqlcommand.BeginExecuteNonQuery(callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginExecuteNonQuery(this SqlCommand sqlcommand, AsyncCallback callback)
		{
			if(sqlcommand == null) throw new ArgumentNullException("sqlcommand");

			return sqlcommand.BeginExecuteNonQuery(callback, null);
		}

		/// <summary>
		/// Extends BeginExecuteXmlReader so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// sqlcommand.BeginExecuteXmlReader(callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginExecuteXmlReader(this SqlCommand sqlcommand, AsyncCallback callback)
		{
			if(sqlcommand == null) throw new ArgumentNullException("sqlcommand");

			return sqlcommand.BeginExecuteXmlReader(callback, null);
		}

		/// <summary>
		/// Extends BeginExecuteReader so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// sqlcommand.BeginExecuteReader(callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginExecuteReader(this SqlCommand sqlcommand, AsyncCallback callback)
		{
			if(sqlcommand == null) throw new ArgumentNullException("sqlcommand");

			return sqlcommand.BeginExecuteReader(callback, null);
		}

		/// <summary>
		/// Extends BeginExecuteReader so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// sqlcommand.BeginExecuteReader(callback, behavior);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginExecuteReader(this SqlCommand sqlcommand, AsyncCallback callback, System.Data.CommandBehavior behavior)
		{
			if(sqlcommand == null) throw new ArgumentNullException("sqlcommand");

			return sqlcommand.BeginExecuteReader(callback, null, behavior);
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
		/// Extends GetBytes so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// sqldatarecord.GetBytes(ordinal, fieldOffset, buffer);
		/// </example>
		/// </summary>
		public static Int64 GetBytes(this SqlDataRecord sqldatarecord, Int32 ordinal, Int64 fieldOffset, Byte[] buffer)
		{
			if(sqldatarecord == null) throw new ArgumentNullException("sqldatarecord");

			if(buffer == null) throw new ArgumentNullException("buffer");

			return sqldatarecord.GetBytes(ordinal, fieldOffset, buffer, 0, buffer.Length);
		}

		/// <summary>
		/// Extends GetChars so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// sqldatarecord.GetChars(ordinal, fieldOffset, buffer);
		/// </example>
		/// </summary>
		public static Int64 GetChars(this SqlDataRecord sqldatarecord, Int32 ordinal, Int64 fieldOffset, Char[] buffer)
		{
			if(sqldatarecord == null) throw new ArgumentNullException("sqldatarecord");

			if(buffer == null) throw new ArgumentNullException("buffer");

			return sqldatarecord.GetChars(ordinal, fieldOffset, buffer, 0, buffer.Length);
		}

		/// <summary>
		/// Extends SetBytes so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// sqldatarecord.SetBytes(ordinal, fieldOffset, buffer);
		/// </example>
		/// </summary>
		public static void SetBytes(this SqlDataRecord sqldatarecord, Int32 ordinal, Int64 fieldOffset, Byte[] buffer)
		{
			if(sqldatarecord == null) throw new ArgumentNullException("sqldatarecord");

			if(buffer == null) throw new ArgumentNullException("buffer");

			sqldatarecord.SetBytes(ordinal, fieldOffset, buffer, 0, buffer.Length);
		}

		/// <summary>
		/// Extends SetChars so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// sqldatarecord.SetChars(ordinal, fieldOffset, buffer);
		/// </example>
		/// </summary>
		public static void SetChars(this SqlDataRecord sqldatarecord, Int32 ordinal, Int64 fieldOffset, Char[] buffer)
		{
			if(sqldatarecord == null) throw new ArgumentNullException("sqldatarecord");

			if(buffer == null) throw new ArgumentNullException("buffer");

			sqldatarecord.SetChars(ordinal, fieldOffset, buffer, 0, buffer.Length);
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
		/// Extends BeginRead so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// sqlfilestream.BeginRead(buffer, offset, count, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginRead(this SqlFileStream sqlfilestream, Byte[] buffer, Int32 offset, Int32 count, AsyncCallback callback)
		{
			if(sqlfilestream == null) throw new ArgumentNullException("sqlfilestream");

			return sqlfilestream.BeginRead(buffer, offset, count, callback, null);
		}

		/// <summary>
		/// Extends BeginRead so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// sqlfilestream.BeginRead(buffer, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginRead(this SqlFileStream sqlfilestream, Byte[] buffer, AsyncCallback callback)
		{
			if(sqlfilestream == null) throw new ArgumentNullException("sqlfilestream");

			if(buffer == null) throw new ArgumentNullException("buffer");

			return sqlfilestream.BeginRead(buffer, 0, buffer.Length, callback);
		}

		/// <summary>
		/// Extends BeginWrite so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// sqlfilestream.BeginWrite(buffer, offset, count, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginWrite(this SqlFileStream sqlfilestream, Byte[] buffer, Int32 offset, Int32 count, AsyncCallback callback)
		{
			if(sqlfilestream == null) throw new ArgumentNullException("sqlfilestream");

			return sqlfilestream.BeginWrite(buffer, offset, count, callback, null);
		}

		/// <summary>
		/// Extends BeginWrite so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// sqlfilestream.BeginWrite(buffer, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginWrite(this SqlFileStream sqlfilestream, Byte[] buffer, AsyncCallback callback)
		{
			if(sqlfilestream == null) throw new ArgumentNullException("sqlfilestream");

			if(buffer == null) throw new ArgumentNullException("buffer");

			return sqlfilestream.BeginWrite(buffer, 0, buffer.Length, callback);
		}

	}
}

#endif
#if (NET47)
#endif

namespace HSNXT
{
    public static partial class Extensions
    {
        /// from: http://blogs.msdn.com/b/pfxteam/archive/2011/06/27/10179452.aspx
        /// <summary>
        /// Converts an executing task from a TAP implementation to another that can be used in an APM implementation
        /// </summary>
        /// <typeparam name="TResult">inferred type of the result</typeparam>
        /// <param name="task"><see cref="Task&lt;TResult&gt;"/> object that is executing</param>
        /// <param name="callback"><see cref="AsyncCallback"/> from the Begin* method.</param>
        /// <param name="state">Optional state</param>
        /// <example>
        /// static IAsyncResult BeginFoo(AsyncCallback callback, object state)
        /// {
        /// 	return FooAsync().ToApm(callback, state);
        /// }
        ///
        /// static int EndFoo(IAsyncResult asyncResult)
        /// {
        ///    return ((Task&lt;int&gt;)asyncResult).Result;
        /// }
        /// </example>
        /// <returns>New task that can be cast to <see cref="IAsyncResult"/>.</returns>
        public static Task<TResult> ToApm<TResult>(this Task<TResult> task, AsyncCallback callback, object state)
        {
            if (task == null)
            {
                throw new ArgumentNullException(nameof(task));
            }

            var tcs = new TaskCompletionSource<TResult>(state);

            task.ContinueWith(
                _ =>
                {
                    if (task.IsFaulted)
                    {
                        tcs.TrySetException(task.Exception.InnerExceptions);
                    }
                    else if (task.IsCanceled)
                    {
                        tcs.TrySetCanceled();
                    }
                    else
                    {
                        tcs.TrySetResult(task.Result);
                    }

                    callback?.Invoke(tcs.Task);
                },
                CancellationToken.None,
                TaskContinuationOptions.None,
                TaskScheduler.Default);

            return tcs.Task;
        }

        /// from: http://blogs.msdn.com/b/pfxteam/archive/2011/06/27/10179452.aspx
        /// <summary>
        /// Converts an executing task from a TAP implementation to another that can be used in an APM implementation
        /// </summary>
        /// <param name="task"><see cref="Task&lt;TResult&gt;"/> object that is executing</param>
        /// <param name="callback"><see cref="AsyncCallback"/> from the Begin* method.</param>
        /// <param name="state">Optional state</param>
        /// <example>
        /// static IAsyncResult BeginFoo(AsyncCallback callback, object state)
        /// {
        /// 	return FooAsync().ToApm(callback, state);
        /// }
        ///
        /// static void EndFoo(IAsyncResult asyncResult)
        /// {
        ///    ((Task)asyncResult).Result;
        /// }
        /// </example>
        /// <returns>New task that can be cast to <see cref="IAsyncResult"/>.</returns>
        public static Task ToApm(this Task task, AsyncCallback callback, object state)
        {
            if (task == null)
            {
                throw new ArgumentNullException(nameof(task));
            }

            var tcs = new TaskCompletionSource<object>(state);

            task.ContinueWith(
                _ =>
                {
                    if (task.IsFaulted)
                    {
                        tcs.TrySetException(task.Exception.InnerExceptions);
                    }
                    else if (task.IsCanceled)
                    {
                        tcs.TrySetCanceled();
                    }
                    else
                    {
                        tcs.TrySetResult(null);
                    }

                    callback?.Invoke(tcs.Task);
                },
                CancellationToken.None,
                TaskContinuationOptions.None,
                TaskScheduler.Default);

            return tcs.Task;
        }

#if (NET47)
		public static ConfiguredTaskAwaitable ContinueOnTaskContext(this Task task)
		{
			return task.ConfigureAwait(continueOnCapturedContext: false);
		}
#endif // NET45
    }
}
#if (NET47)
#if (NET47)

#endif

namespace HSNXT
{
    public static partial class Extensions
	{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'TcpClientable.BeginConnect(TcpClient, IPEndPoint, AsyncCallback)'
		public static IAsyncResult BeginConnect(this TcpClient tcpClient, IPEndPoint endPoint, AsyncCallback asyncCallback)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'TcpClientable.BeginConnect(TcpClient, IPEndPoint, AsyncCallback)'
		{
			if (tcpClient == null) throw new ArgumentNullException(nameof(tcpClient));
			return tcpClient.BeginConnect(endPoint.Address, endPoint.Port, asyncCallback, null);
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'TcpClientable.BeginConnect(TcpClient, IPEndPoint, AsyncCallback, object)'
		public static IAsyncResult BeginConnect(this TcpClient tcpClient, IPEndPoint endPoint, AsyncCallback asyncCallback, object state)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'TcpClientable.BeginConnect(TcpClient, IPEndPoint, AsyncCallback, object)'
		{
			if (tcpClient == null) throw new ArgumentNullException(nameof(tcpClient));
			return tcpClient.BeginConnect(endPoint.Address, endPoint.Port, asyncCallback, state);
		}

#if (NET47)
		/// <summary>
		/// Connect asyncronously to <param name="endPoint"></param>
		/// </summary>
		/// <param name="tcpClient"><see cref="TcpClient"/> object to connect with</param>
		/// <param name="endPoint"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException">if <param name="endPoint"/> is not a 
		/// <see cref="DnsEndPoint"/> nor an <see cref="IPEndPoint"/></exception>
		public static Task ConnectAsync(this TcpClient tcpClient, EndPoint endPoint)
		{
			if (tcpClient == null) throw new ArgumentNullException(nameof(tcpClient));
			if (endPoint == null) throw new ArgumentNullException(nameof(endPoint));

			var dnsEndPoint = endPoint as DnsEndPoint;
			if (dnsEndPoint != null)
				return tcpClient.ConnectAsync(dnsEndPoint.Host, dnsEndPoint.Port);
			var ipEndPoint = endPoint as IPEndPoint;
			if (ipEndPoint != null)
				return tcpClient.ConnectAsync(ipEndPoint.Address, ipEndPoint.Port);
			throw new ArgumentException("Unsupported EndPoint type", nameof(endPoint));
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
#if (NETSTANDARD2_0 || NET47)
        /// <summary>
        /// Extends BeginConnect so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// tcpclient.BeginConnect(host, port, requestCallback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginConnect(this TcpClient tcpclient, String host, Int32 port,
            AsyncCallback requestCallback)
        {
            if (tcpclient == null) throw new ArgumentNullException("tcpclient");

            return tcpclient.BeginConnect(host, port, requestCallback, null);
        }

        /// <summary>
        /// Extends BeginConnect so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// tcpclient.BeginConnect(address, port, requestCallback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginConnect(this TcpClient tcpclient, System.Net.IPAddress address, Int32 port,
            AsyncCallback requestCallback)
        {
            if (tcpclient == null) throw new ArgumentNullException("tcpclient");

            return tcpclient.BeginConnect(address, port, requestCallback, null);
        }

        /// <summary>
        /// Extends BeginConnect so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// tcpclient.BeginConnect(addresses, port, requestCallback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginConnect(this TcpClient tcpclient, System.Net.IPAddress[] addresses, Int32 port,
            AsyncCallback requestCallback)
        {
            if (tcpclient == null) throw new ArgumentNullException("tcpclient");

            return tcpclient.BeginConnect(addresses, port, requestCallback, null);
        }
#endif
    }
}
#endif
#if (NET47)
namespace HSNXT
{
    public static partial class Extensions
	{
		/// <summary>
		/// Extends BeginSend so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// udpclient.BeginSend(datagram, bytes, endPoint, requestCallback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginSend(this UdpClient udpclient, Byte[] datagram, Int32 bytes, System.Net.IPEndPoint endPoint, AsyncCallback requestCallback)
		{
			if(udpclient == null) throw new ArgumentNullException("udpclient");

			return udpclient.BeginSend(datagram, bytes, endPoint, requestCallback, null);
		}

		/// <summary>
		/// Extends BeginSend so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// udpclient.BeginSend(datagram, bytes, hostname, port, requestCallback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginSend(this UdpClient udpclient, Byte[] datagram, Int32 bytes, String hostname, Int32 port, AsyncCallback requestCallback)
		{
			if(udpclient == null) throw new ArgumentNullException("udpclient");

			return udpclient.BeginSend(datagram, bytes, hostname, port, requestCallback, null);
		}

		/// <summary>
		/// Extends BeginSend so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// udpclient.BeginSend(datagram, bytes, requestCallback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginSend(this UdpClient udpclient, Byte[] datagram, Int32 bytes, AsyncCallback requestCallback)
		{
			if(udpclient == null) throw new ArgumentNullException("udpclient");

			return udpclient.BeginSend(datagram, bytes, requestCallback, null);
		}

		/// <summary>
		/// Extends BeginReceive so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// udpclient.BeginReceive(requestCallback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginReceive(this UdpClient udpclient, AsyncCallback requestCallback)
		{
			if(udpclient == null) throw new ArgumentNullException("udpclient");

			return udpclient.BeginReceive(requestCallback, null);
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
        /// Extends BeginRead so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// stream.BeginRead(buffer, offset, count, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginRead(this UnmanagedMemoryStream stream, Byte[] buffer, Int32 offset,
            Int32 count, AsyncCallback callback)
        {
            if (stream == null) throw new ArgumentNullException("stream");

            return stream.BeginRead(buffer, offset, count, callback, null);
        }

        /// <summary>
        /// Extends BeginRead so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// stream.BeginRead(buffer, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginRead(this UnmanagedMemoryStream stream, Byte[] buffer, AsyncCallback callback)
        {
            if (stream == null) throw new ArgumentNullException("stream");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return stream.BeginRead(buffer, 0, buffer.Length, callback);
        }

        /// <summary>
        /// Extends BeginWrite so that when a state object is not needed, null does not need to be passed.
        /// <example>
        /// stream.BeginWrite(buffer, offset, count, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginWrite(this UnmanagedMemoryStream stream, Byte[] buffer, Int32 offset,
            Int32 count, AsyncCallback callback)
        {
            if (stream == null) throw new ArgumentNullException("stream");

            return stream.BeginWrite(buffer, offset, count, callback, null);
        }

        /// <summary>
        /// Extends BeginWrite so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// stream.BeginWrite(buffer, callback);
        /// </example>
        /// </summary>
        public static IAsyncResult BeginWrite(this UnmanagedMemoryStream stream, Byte[] buffer, AsyncCallback callback)
        {
            if (stream == null) throw new ArgumentNullException("stream");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return stream.BeginWrite(buffer, 0, buffer.Length, callback);
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
        /// Extends ReadContentAs so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// xmlreader.ReadContentAs&lt;int&gt;(namespaceResolver);
        /// </example>
        /// </summary>
        public static T ReadContentAs<T>(this XmlNodeReader xmlreader, IXmlNamespaceResolver namespaceResolver)
        {
            if (xmlreader == null) throw new ArgumentNullException("xmlreader");

            return (T) xmlreader.ReadContentAs(typeof(T), namespaceResolver);
        }

        /// <summary>
        /// Extends ReadElementContentAs so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// xmlreader.ReadElementContentAs&lt;int&gt;(namespaceResolver);
        /// </example>
        /// </summary>
        public static T ReadElementContentAs<T>(this XmlNodeReader xmlreader, IXmlNamespaceResolver namespaceResolver)
        {
            if (xmlreader == null) throw new ArgumentNullException("xmlreader");

            return (T) xmlreader.ReadElementContentAs(typeof(T), namespaceResolver);
        }

        /// <summary>
        /// Extends ReadElementContentAs so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// xmlreader.ReadElementContentAs&lt;int&gt;(namespaceResolver, localName, namespaceURI);
        /// </example>
        /// </summary>
        public static T ReadElementContentAs<T>(this XmlNodeReader xmlreader, IXmlNamespaceResolver namespaceResolver,
            String localName, String namespaceURI)
        {
            if (xmlreader == null) throw new ArgumentNullException("xmlreader");

            return (T) xmlreader.ReadElementContentAs(typeof(T), namespaceResolver, localName, namespaceURI);
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
        /// Extends ReadChars so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// xmltextreader.ReadChars(buffer);
        /// </example>
        /// </summary>
        public static Int32 ReadChars(this XmlTextReader xmltextreader, Char[] buffer)
        {
            if (xmltextreader == null) throw new ArgumentNullException("xmltextreader");

            if (buffer == null) throw new ArgumentNullException("buffer");

            return xmltextreader.ReadChars(buffer, 0, buffer.Length);
        }

        /// <summary>
        /// Extends ReadBase64 so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// xmltextreader.ReadBase64(array);
        /// </example>
        /// </summary>
        public static Int32 ReadBase64(this XmlTextReader xmltextreader, Byte[] array)
        {
            if (xmltextreader == null) throw new ArgumentNullException("xmltextreader");

            if (array == null) throw new ArgumentNullException("array");

            return xmltextreader.ReadBase64(array, 0, array.Length);
        }

        /// <summary>
        /// Extends ReadBinHex so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// xmltextreader.ReadBinHex(array);
        /// </example>
        /// </summary>
        public static Int32 ReadBinHex(this XmlTextReader xmltextreader, Byte[] array)
        {
            if (xmltextreader == null) throw new ArgumentNullException("xmltextreader");

            if (array == null) throw new ArgumentNullException("array");

            return xmltextreader.ReadBinHex(array, 0, array.Length);
        }

        /// <summary>
        /// Extends ReadContentAs so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// xmlreader.ReadContentAs&lt;int&gt;(namespaceResolver);
        /// </example>
        /// </summary>
        public static T ReadContentAs<T>(this XmlTextReader xmlreader, IXmlNamespaceResolver namespaceResolver)
        {
            if (xmlreader == null) throw new ArgumentNullException("xmlreader");

            return (T) xmlreader.ReadContentAs(typeof(T), namespaceResolver);
        }

        /// <summary>
        /// Extends ReadElementContentAs so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// xmlreader.ReadElementContentAs&lt;int&gt;(namespaceResolver);
        /// </example>
        /// </summary>
        public static T ReadElementContentAs<T>(this XmlTextReader xmlreader, IXmlNamespaceResolver namespaceResolver)
        {
            if (xmlreader == null) throw new ArgumentNullException("xmlreader");

            return (T) xmlreader.ReadElementContentAs(typeof(T), namespaceResolver);
        }

        /// <summary>
        /// Extends ReadElementContentAs so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// xmlreader.ReadElementContentAs&lt;int&gt;(namespaceResolver, localName, namespaceURI);
        /// </example>
        /// </summary>
        public static T ReadElementContentAs<T>(this XmlTextReader xmlreader, IXmlNamespaceResolver namespaceResolver,
            String localName, String namespaceURI)
        {
            if (xmlreader == null) throw new ArgumentNullException("xmlreader");

            return (T) xmlreader.ReadElementContentAs(typeof(T), namespaceResolver, localName, namespaceURI);
        }
    }
}
#endif
#if (NETSTANDARD2_0 || NET47)

namespace HSNXT
{
    public static partial class Extensions
    {
#pragma warning disable CS0618 // 'XmlValidatingReader' is obsolete: 'Use XmlReader created by XmlReader.Create() method using appropriate XmlReaderSettings instead. http://go.microsoft.com/fwlink/?linkid=14202'
        /// <summary>
        /// Extends ReadContentAs so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// xmlreader.ReadContentAs&lt;int&gt;(namespaceResolver);
        /// </example>
        /// </summary>
        public static T ReadContentAs<T>(this XmlValidatingReader xmlreader, IXmlNamespaceResolver namespaceResolver)
#pragma warning restore CS0618 // 'XmlValidatingReader' is obsolete: 'Use XmlReader created by XmlReader.Create() method using appropriate XmlReaderSettings instead. http://go.microsoft.com/fwlink/?linkid=14202'
        {
            if (xmlreader == null) throw new ArgumentNullException("xmlreader");

            return (T) xmlreader.ReadContentAs(typeof(T), namespaceResolver);
        }

#pragma warning disable CS0618 // 'XmlValidatingReader' is obsolete: 'Use XmlReader created by XmlReader.Create() method using appropriate XmlReaderSettings instead. http://go.microsoft.com/fwlink/?linkid=14202'
        /// <summary>
        /// Extends ReadElementContentAs so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// xmlreader.ReadElementContentAs&lt;int&gt;(namespaceResolver);
        /// </example>
        /// </summary>
        public static T ReadElementContentAs<T>(this XmlValidatingReader xmlreader,
            IXmlNamespaceResolver namespaceResolver)
#pragma warning restore CS0618 // 'XmlValidatingReader' is obsolete: 'Use XmlReader created by XmlReader.Create() method using appropriate XmlReaderSettings instead. http://go.microsoft.com/fwlink/?linkid=14202'
        {
            if (xmlreader == null) throw new ArgumentNullException("xmlreader");

            return (T) xmlreader.ReadElementContentAs(typeof(T), namespaceResolver);
        }

#pragma warning disable CS0618 // 'XmlValidatingReader' is obsolete: 'Use XmlReader created by XmlReader.Create() method using appropriate XmlReaderSettings instead. http://go.microsoft.com/fwlink/?linkid=14202'
        /// <summary>
        /// Extends ReadElementContentAs so that methods that return a specific type object given a Type parameter can be
        /// used as generic method and casting is not required.
        /// <example>
        /// xmlreader.ReadElementContentAs&lt;int&gt;(namespaceResolver, localName, namespaceURI);
        /// </example>
        /// </summary>
        public static T ReadElementContentAs<T>(this XmlValidatingReader xmlreader,
            IXmlNamespaceResolver namespaceResolver, String localName, String namespaceURI)
#pragma warning restore CS0618 // 'XmlValidatingReader' is obsolete: 'Use XmlReader created by XmlReader.Create() method using appropriate XmlReaderSettings instead. http://go.microsoft.com/fwlink/?linkid=14202'
        {
            if (xmlreader == null) throw new ArgumentNullException("xmlreader");

            return (T) xmlreader.ReadElementContentAs(typeof(T), namespaceResolver, localName, namespaceURI);
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
        /// Extends WriteChars so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// xmlwriter.WriteChars(buffer);
        /// </example>
        /// </summary>
        public static void WriteChars(this XmlWriter xmlwriter, Char[] buffer)
        {
            if (xmlwriter == null) throw new ArgumentNullException("xmlwriter");

            if (buffer == null) throw new ArgumentNullException("buffer");

            xmlwriter.WriteChars(buffer, 0, buffer.Length);
        }

        /// <summary>
        /// Extends WriteRaw so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// xmlwriter.WriteRaw(buffer);
        /// </example>
        /// </summary>
        public static void WriteRaw(this XmlWriter xmlwriter, Char[] buffer)
        {
            if (xmlwriter == null) throw new ArgumentNullException("xmlwriter");

            if (buffer == null) throw new ArgumentNullException("buffer");

            xmlwriter.WriteRaw(buffer, 0, buffer.Length);
        }

        /// <summary>
        /// Extends WriteBase64 so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// xmlwriter.WriteBase64(buffer);
        /// </example>
        /// </summary>
        public static void WriteBase64(this XmlWriter xmlwriter, Byte[] buffer)
        {
            if (xmlwriter == null) throw new ArgumentNullException("xmlwriter");

            if (buffer == null) throw new ArgumentNullException("buffer");

            xmlwriter.WriteBase64(buffer, 0, buffer.Length);
        }

        /// <summary>
        /// Extends WriteBinHex so that buffer offset of 0 and call to Array.Length are not needed.
        /// <example>
        /// xmlwriter.WriteBinHex(buffer);
        /// </example>
        /// </summary>
        public static void WriteBinHex(this XmlWriter xmlwriter, Byte[] buffer)
        {
            if (xmlwriter == null) throw new ArgumentNullException("xmlwriter");

            if (buffer == null) throw new ArgumentNullException("buffer");

            xmlwriter.WriteBinHex(buffer, 0, buffer.Length);
        }
    }
}
#endif