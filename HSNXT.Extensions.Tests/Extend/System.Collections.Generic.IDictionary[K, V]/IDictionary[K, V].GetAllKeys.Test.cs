#region Usings
using HSNXT;

using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

#endregion

namespace Extend.Testing
{
    // ReSharper disable once InconsistentNaming
    public partial class IDictionaryExTest
    {
        [Fact]
        public void GetAllKeysTest()
        {
            var dictionary = new Dictionary<String, String>
            {
                { Extensions.GetRandomString(), Extensions.GetRandomString() },
                { Extensions.GetRandomString(), Extensions.GetRandomString() }
            };

            var allKeys = dictionary.GetAllKeys()
                                    .ToList();
            Assert.True( dictionary.All( x => allKeys.Contains( x.Key ) ) );
        }

        [Fact]
        public void GetAllKeysTestNullCheck()
        {
            Dictionary<Object, Object> dictionary = null;
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => dictionary.GetAllKeys();

            test.ShouldThrow<ArgumentNullException>();
        }
    }
}