//Copyright (c) Chris Pietschmann 2012 (http://pietschsoft.com)
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
        /// Returns a read-only Encrypted stream from the original stream using the specified Algorithm.
        /// </summary>
        /// <typeparam name="Algorithm">The SymmetricAlgorithm to use for Encryption</typeparam>
        /// <param name="stream">Required. The stream to Encrypt</param>
        /// <param name="key">Required. The Encryption Key</param>
        /// <param name="iv">Optional. The Initialization Vector for the symmetric algorithm</param>
        /// <returns>Returns a read-only cryptographic stream from the original stream.</returns>
        public static System.IO.Stream Encrypt<Algorithm>(this System.IO.Stream stream, byte[] key, byte[] iv = null)
            where Algorithm : SymmetricAlgorithm
        {
            var alg = Activator.CreateInstance<Algorithm>();
            alg.Key = key;
            alg.IV = iv ?? key;
            var encryptor = alg.CreateEncryptor();
            return new CryptoStream(stream, encryptor, CryptoStreamMode.Read);
        }

        /// <summary>
        /// Returns a read-only Decrypted stream from the original stream using the specified Algorithm.
        /// </summary>
        /// <typeparam name="Algorithm"></typeparam>
        /// <param name="stream"></param>
        /// <param name="key"></param>
        /// /// <param name="iv">Optional. The Initialization Vector for the symmetric algorithm</param>
        /// <returns></returns>
        public static System.IO.Stream Decrypt<Algorithm>(this System.IO.Stream stream, byte[] key, byte[] iv = null)
            where Algorithm : SymmetricAlgorithm
        {
            var alg = Activator.CreateInstance<Algorithm>();
            alg.Key = key;
            alg.IV = iv ?? key;
            var encryptor = alg.CreateDecryptor();
            return new CryptoStream(stream, encryptor, CryptoStreamMode.Read);
        }
    }
}
