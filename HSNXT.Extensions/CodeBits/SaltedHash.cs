﻿#region --- License & Copyright Notice ---

/*
CodeBits Code Snippets
Copyright (c) 2012-2017 Jeevan James
All rights reserved.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

#endregion

/* Documentation: http://codebits.codeplex.com/wikipage?title=SaltedHash */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace HSNXT
{
    /// <summary>
    ///     Encapsulates the functionality required to compute and verify salted hashes.
    /// </summary>
    public sealed partial class SaltedHash
    {
        /// <summary>
        ///     Computes a salted hash from the given password.
        /// </summary>
        /// <param name="password">The password from which to compute the salted hash</param>
        /// <returns>A SaltedHash instance containing the hash and salt values</returns>
        public static SaltedHash Compute(string password)
        {
            var saltBytes = new byte[32];
            new RNGCryptoServiceProvider().GetNonZeroBytes(saltBytes);
            var salt = Convert.ToBase64String(saltBytes);
            var passwordAndSaltBytes = Concat(password, saltBytes);
            var hash = ComputeHash(passwordAndSaltBytes);
            return new SaltedHash(hash, salt);
        }

        /// <summary>
        ///     Verifies that the a password matches the specified hash and salt values
        /// </summary>
        /// <param name="password">The password to check</param>
        /// <param name="hash">The hash value to check against</param>
        /// <param name="salt">The salt value to check against</param>
        /// <returns>True if the specified password matches the salted hash</returns>
        public static bool Verify(string password, string hash, string salt)
        {
            var saltBytes = Convert.FromBase64String(salt);
            var passwordAndSaltBytes = Concat(password, saltBytes);
            var hashAttempt = ComputeHash(passwordAndSaltBytes);
            return hash == hashAttempt;
        }

        private static string ComputeHash(byte[] bytes)
        {
            return Convert.ToBase64String(SHA256.Create().ComputeHash(bytes));
        }

        private static byte[] Concat(string password, IEnumerable<byte> saltBytes)
        {
            var passwordBytes = Encoding.UTF8.GetBytes(password);
            return passwordBytes.Concat(saltBytes).ToArray();
        }
    }

    public sealed partial class SaltedHash
    {
        private SaltedHash(string hash, string salt)
        {
            Hash = hash;
            Salt = salt;
        }

        /// <summary>
        ///     The computed hash value as a base-64 encoded string
        /// </summary>
        public string Hash { get; }

        /// <summary>
        ///     The computed salt value as a base-64 encoded string
        /// </summary>
        public string Salt { get; }
    }
}