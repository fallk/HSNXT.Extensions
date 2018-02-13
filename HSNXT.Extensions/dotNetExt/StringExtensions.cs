//Copyright (c) Chris Pietschmann 2013 (http://pietschsoft.com)
//All rights reserved.
//Licensed under the GNU Library General Public License (LGPL)
//License can be found here: http://www.codeplex.com/dotNetExt/license

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Returns an MD5 Hash from the specified string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ToMD5Hash(this string s)
        {
            using (var md5 = MD5.Create())
            {
                var bytes = s.ToByteArray();
                var hashBytes = md5.ComputeHash(bytes);
                var sb = new StringBuilder();
                hashBytes.Each(b => sb.Append(b.ToString("X2")));
                return sb.ToString();
            }
        }

        /// <summary>
        /// Returns a Byte Array of the String using the specified Encoding.
        /// </summary>
        /// <typeparam name="encoding">The character encoding to use to encode the String to a Byte Array.</typeparam>
        /// <param name="str">Required. The String to Convert to a Byte Array.</param>
        /// <returns>Returns a Byte Array of the String.</returns>
        public static byte[] ToByteArray<encoding>(this string str) where encoding : Encoding
        {
            Encoding enc = Activator.CreateInstance<encoding>();
            return enc.GetBytes(str);
        }

        /// <summary>
        /// Returns a Stream representation of the String using the specified Encoding.
        /// </summary>
        /// <typeparam name="encoding">The String Encoding Type to use.</typeparam>
        /// <param name="str">Required. The String to convert to a Stream.</param>
        /// <returns>Returns a Stream representation of the String.</returns>
        public static Stream ToStream<encoding>(this string str) where encoding : Encoding
        {
            return new MemoryStream(str.ToByteArray<encoding>());
        }

        /// <summary>
        /// Encrypts the String using the given Encryption Algorithm and key. Return value is also Base64 encoded.
        /// </summary>
        /// <typeparam name="Algorithm">The SymmetricAlgorithm type to use for Encryption.</typeparam>
        /// <param name="str">Required. The String to Encrypt.</param>
        /// <param name="key">The Encryption Key to use.</param>
        /// <param name="iv">Optional. The Initialization Vector for the symmetric algorithm</param>
        /// <returns>Returns the String Encrypted using the given Encryption Algorithm and key.</returns>
        public static string Encrypt<Algorithm>(this string str, string key, string iv = null)
            where Algorithm : SymmetricAlgorithm
        {
            using (var s = str.ToStream())
            {
                var encryptedStream = s.Encrypt<Algorithm>(key.ToByteArray(), iv != null ? iv.ToByteArray() : null);
                var bytes = encryptedStream.ToByteArray();
                return bytes.ToBase64String();
            }
        }

        /// <summary>
        /// Decrypts the Base64 encoded String using the given Encryption Algorithm and key.
        /// </summary>
        /// <typeparam name="Algorithm">The SymmetricAlgorithm type to use for Encryption.</typeparam>
        /// <param name="str">Required. The String to Dencrypt.</param>
        /// <param name="key">The Decryption Key.</param>
        /// <param name="iv">Optional. The Initialization Vector for the symmetric algorithm</param>
        /// <returns></returns>
        public static string Decrypt<Algorithm>(this string str, string key, string iv = null)
            where Algorithm : SymmetricAlgorithm
        {
            using (var s = new MemoryStream(Convert.FromBase64String(str)))
            {
                var decryptedStream = s.Decrypt<Algorithm>(key.ToByteArray(), iv != null ? iv.ToByteArray() : null);
                var bytes = decryptedStream.ToByteArray();
                var enc = new ASCIIEncoding();
                return enc.GetString(bytes);
            }
        }

        /// <summary>
        /// Strips out all instances of the specified string from the source string
        /// </summary>
        /// <param name="source">The source string</param>
        /// <returns>The stripped string</returns>
        public static string RemoveAll(this string source, params string[] removeStrings)
        {
            var v = source;
            foreach (var s in removeStrings)
            {
                v = v.Replace(s, string.Empty);
            }

            return v;
        }
    }
}