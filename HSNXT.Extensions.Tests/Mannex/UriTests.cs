#region License, Terms and Author(s)
//
// Mannex - Extension methods for .NET
// Copyright (c) 2009 Atif Aziz. All rights reserved.
//
//  Author(s):
//
//      Atif Aziz, http://www.raboof.com
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion

using HSNXT;

namespace Mannex.Tests
{
    #region Imports

    using System;
    using System.Collections.Specialized;
    using System.Net;
    using Xunit;

    #endregion

    public class UriTests2
    {
        [Fact]
        public void IsHttpOrHttpsFailsWithNullThis()
        {
            Assert.Throws<ArgumentNullException>(() => Extensions.IsHttpOrHttps(null));
        }

        [Fact]
        public void IsHttpOrHttpsFalseForFtp()
        {
            Assert.False(new Uri("ftp://www.example.com/").IsHttpOrHttps());
        }

        [Fact]
        public void IsHttpOrHttpsTrueForHttp()
        {
            Assert.True(new Uri("http://www.example.com/").IsHttpOrHttps());
        }

        [Fact]
        public void IsHttpOrHttpsTrueForHttps()
        {
            Assert.True(new Uri("https://www.example.com/").IsHttpOrHttps());
        }

        [Fact]
        public void TryGetUserNamePasswordFailsWithNullThis()
        {
            Assert.Throws<ArgumentNullException>(() => Extensions.TryGetUserNamePassword(null));
        }
 
        static void ATryGetUserNamePassword(string url, NetworkCredential expectedCredential)
        {
            var result = new Uri(url).TryGetUserNamePassword();
            if (expectedCredential == null) 
                return;
            Assert.NotNull(result);
            Assert.Equal(expectedCredential.UserName, result.UserName);
            Assert.Equal(expectedCredential.Password, result.Password);
        }

        [Fact]
        public void BTryGetUserNamePassword()
        {
            ATryGetUserNamePassword(
                "http://johndoe:secret@www.example.com/", 
                new NetworkCredential("johndoe", "secret"));

            ATryGetUserNamePassword(
                "http://www.example.com/", 
                null);

            ATryGetUserNamePassword(
                "http://john%3adoe:sec%3aret@www.example.com/", 
                new NetworkCredential("john:doe", "sec:ret"));            

            ATryGetUserNamePassword(
                "http://johndoe@www.example.com/", 
                new NetworkCredential("johndoe", (string) null));

            ATryGetUserNamePassword(
                "http://:secret@www.example.com/", 
                null);

            ATryGetUserNamePassword(
                "http://:@www.example.com/",
                null);
        }
 
        [Fact]
        public void GetUserNamePasswordFailsWithNullThis()
        {
            Assert.Throws<ArgumentNullException>(() => Extensions.GetUserNamePassword(null));
        }

        static void CGetUserNamePassword(string url)
        {
            DGetUserNamePassword(url, null);
        }

        static void DGetUserNamePassword(string url, NetworkCredential expectedCredential)
        {
            var credential = new Uri(url).GetUserNamePassword();
            Assert.NotNull(credential);
            Assert.Equal(expectedCredential.UserName, credential.UserName);
            Assert.Equal(expectedCredential.Password, credential.Password);
        }

        [Fact]
        public void EGetUserNamePassword()
        {
            DGetUserNamePassword("http://johndoe:secret@www.example.com/", 
                new NetworkCredential("johndoe", "secret"));

            DGetUserNamePassword("http://john%3adoe:sec%3aret@www.example.com/", 
                new NetworkCredential("john:doe", "sec:ret"));

            DGetUserNamePassword("http://johndoe@www.example.com/",
                new NetworkCredential("johndoe", (string) null));
        }
 
        [Fact]
        public void GetUserNamePasswordFailsWhenUserInfoAbsent()
        {
            var e = Assert.Throws<ArgumentException>(() => CGetUserNamePassword("http://www.example.com/"));
            Assert.Equal("http://www.example.com/ is missing user credentials.", e.Message);
        }
 
        [Fact]
        public void GetUserNamePasswordFailsWithPasswordOnly()
        {
            var e = Assert.Throws<ArgumentException>(() => CGetUserNamePassword("http://:secret@www.example.com/"));
            Assert.Equal("http://:secret@www.example.com/ is missing user credentials.", e.Message);
        }

        [Fact]
        public void GetUserNamePasswordFailsWithEmptyUserNameAndPassword()
        {
            var e = Assert.Throws<ArgumentException>(() => CGetUserNamePassword("http://:@www.example.com/"));
            Assert.Equal("http://:@www.example.com/ is missing user credentials.", e.Message);
        }

        [Fact]
        public void TrySplitUserNamePasswordFailsWithNullThis()
        {
            Assert.Throws<ArgumentNullException>(() => Extensions.TrySplitUserNamePassword<object>(null, delegate { throw new NotImplementedException(); }));
        }

        static void FTrySplitUserNamePassword(string url, string expectedUrl, NetworkCredential expectedCredential)
        {
            var result = new Uri(url).TrySplitUserNamePassword((url2, credential) => new { Url = url2, Credential = credential });
            Assert.NotNull(result);
            Assert.NotNull(result.Url);
            Assert.Equal(new Uri(expectedUrl), result.Url);
            if (expectedCredential != null)
            {
                Assert.NotNull(result.Credential);
                Assert.Equal(expectedCredential.UserName, result.Credential.UserName);
                Assert.Equal(expectedCredential.Password, result.Credential.Password);
            }
            else
            {
                Assert.Null(result.Credential);
            }
        }
        
        [Fact]
        public void GTrySplitUserNamePassword()
        {
            FTrySplitUserNamePassword(
                "http://johndoe:secret@www.example.com/", 
                "http://www.example.com/", 
                new NetworkCredential("johndoe", "secret"));

            FTrySplitUserNamePassword(
                "http://www.example.com/", 
                "http://www.example.com/", 
                null);

            FTrySplitUserNamePassword(
                "http://john%3adoe:sec%3aret@www.example.com/", 
                "http://www.example.com/", 
                new NetworkCredential("john:doe", "sec:ret"));            

            FTrySplitUserNamePassword(
                "http://johndoe@www.example.com/", 
                "http://www.example.com/",
                new NetworkCredential("johndoe", (string) null));

            FTrySplitUserNamePassword(
                "http://:secret@www.example.com/", 
                "http://www.example.com/", 
                null);

            FTrySplitUserNamePassword(
                "http://:@www.example.com/",
                "http://www.example.com/",
                null);
        }
 
        [Fact]
        public void SplitUserNamePasswordFailsWithNullThis()
        {
            Assert.Throws<ArgumentNullException>(() => Extensions.SplitUserNamePassword<object>(null, delegate { throw new NotImplementedException(); }));
        }

        static void HSplitUserNamePassword(string url)
        {
            DGetUserNamePassword(url, null);
        }

        static void ISplitUserNamePassword(string url, string expectedUrl, NetworkCredential expectedCredential)
        {
            var result = new Uri(url).SplitUserNamePassword((url2, credential) => new { Url = url2, Credential = credential });
            Assert.NotNull(result);
            Assert.NotNull(result.Url);
            Assert.Equal(new Uri(expectedUrl), result.Url);
            Assert.NotNull(result.Credential);
            Assert.Equal(expectedCredential.UserName, result.Credential.UserName);
            Assert.Equal(expectedCredential.Password, result.Credential.Password);
        }

        [Fact]
        public void JSplitUserNamePassword()
        {
            ISplitUserNamePassword("http://johndoe:secret@www.example.com/", 
                "http://www.example.com/",
                new NetworkCredential("johndoe", "secret"));

            ISplitUserNamePassword("http://john%3adoe:sec%3aret@www.example.com/", 
                "http://www.example.com/",
                new NetworkCredential("john:doe", "sec:ret"));

            ISplitUserNamePassword("http://johndoe@www.example.com/", 
                "http://www.example.com/",
                new NetworkCredential("johndoe", (string) null));
        }
 
        [Fact]
        public void SplitUserNamePasswordFailsWhenUserInfoAbsent()
        {
            var e = Assert.Throws<ArgumentException>(() => HSplitUserNamePassword("http://www.example.com/"));
            Assert.Equal("http://www.example.com/ is missing user credentials.", e.Message);
        }
 
        [Fact]
        public void SplitUserNamePasswordFailsWithPasswordOnly()
        {
            var e = Assert.Throws<ArgumentException>(() => HSplitUserNamePassword("http://:secret@www.example.com/"));
            Assert.Equal("http://:secret@www.example.com/ is missing user credentials.", e.Message);
        }

        [Fact]
        public void SplitUserNamePasswordFailsWithEmptyUserNameAndPassword()
        {
            var e = Assert.Throws<ArgumentException>(() => HSplitUserNamePassword("http://:@www.example.com/"));
            Assert.Equal("http://:@www.example.com/ is missing user credentials.", e.Message);
        }

        [Fact]
        public void RemoveUserNamePasswordFailsWithNullThis()
        {
            Assert.Throws<ArgumentNullException>(() => Extensions.RemoveUserNamePassword(null));
        }
 
        [Fact]
        public void RemoveUserNamePasswordReturnsNewUriWithUserNamePasswordRemoved()
        {
            var url = new Uri("http://johndoe:secret@www.example.com/").RemoveUserNamePassword();
            Assert.Equal(new Uri("http://www.example.com/"), url);
        }

        [Fact]
        public void MergeQueryFailsWithNullUri()
        {
            var e = Assert.Throws<ArgumentNullException>(() => Extensions.MergeQuery(null, null));
            Assert.Equal("uri", e.ParamName);
        }

        [Fact]
        public void MergeQueryWithNullCollectionReturnsOriginalUrl()
        {
            var url = new Uri("http://www.example.com/?query");
            var result = url.MergeQuery(null);
            Assert.Equal(url, result);
        }

        [Fact]
        public void MergeQuerySinglePair()
        {
            var url = new Uri("http://www.example.com/?a=1&b=2&c=3");
            var result = url.MergeQuery(new NameValueCollection
            {
                { "b", "foo" },
                { "d", "bar" },
            });
            Assert.Equal(new Uri("http://www.example.com/?a=1&b=foo&c=3&d=bar"), result);
        }

        [Fact]
        public void MergeQueryMultiValue()
        {
            var url = new Uri("http://www.example.com/?a=1&b=2&c=3");
            var result = url.MergeQuery(new NameValueCollection
            {
                { "b", "foo" },
                { "b", "bar" },
            });
            Assert.Equal(new Uri("http://www.example.com/?a=1&b=foo&b=bar&c=3"), result);
        }

        [Fact]
        public void MergeQueryNullValue()
        {
            var url = new Uri("http://www.example.com/?a=1&b=2&c=3");
            var result = url.MergeQuery(new NameValueCollection
            {
                { "b", null },
            });
            Assert.Equal(new Uri("http://www.example.com/?a=1&c=3"), result);
        }

        [Fact]
        public void MergeQueryWithBlankInitialQuery()
        {
            var url = new Uri("http://www.example.com/");
            var result = url.MergeQuery(new NameValueCollection
            {
                { "a", "foo" },
                { "b", "bar" },
                { "c", "baz" },
            });
            Assert.Equal(new Uri("http://www.example.com/?a=foo&b=bar&c=baz"), result);
        }
    }
}