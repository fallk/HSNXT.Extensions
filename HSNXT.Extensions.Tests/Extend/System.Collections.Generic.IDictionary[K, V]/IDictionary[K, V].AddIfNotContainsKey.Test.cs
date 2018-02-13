#region Usings

using HSNXT;
using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

#endregion

namespace Extend.Testing
{
    // ReSharper disable once InconsistentNaming
    public partial class IDictionaryExTest
    {
        [Fact]
        public void AddIfNotContainsKey1TestNullCheck()
        {
            var keyValuePair = new KeyValuePair<Object, Object>();
            Action test = () => new Dictionary<Object, Object>().AddIfNotContainsKey(keyValuePair);

            test.ShouldThrow<ArgumentNullException>();
        }

        [Fact]
        public void AddIfNotContainsKey1TestNullCheck1()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => Extensions.AddIfNotContainsKey(null, new KeyValuePair<Object, Object>());

            test.ShouldThrow<ArgumentNullException>();
        }

        [Fact]
        public void AddIfNotContainsKeyTest()
        {
            var key = Extensions.GetRandomString();
            var dic = new Dictionary<String, String>();

            var result = dic.AddIfNotContainsKey(key, Extensions.GetRandomString());
            Assert.True(result);
            Assert.Single(dic);

            result = dic.AddIfNotContainsKey(key, Extensions.GetRandomString());
            Assert.False(result);
            Assert.Single(dic);
        }

        [Fact]
        public void AddIfNotContainsKeyTest1()
        {
            var dic = new Dictionary<String, String>();
            var key = Extensions.GetRandomString();
            var keyValuePair = new KeyValuePair<String, String>(key, Extensions.GetRandomString());

            var result = dic.AddIfNotContainsKey(keyValuePair);
            Assert.True(result);
            Assert.Single(dic);

            result = dic.AddIfNotContainsKey(keyValuePair);
            Assert.False(result);
            Assert.Single(dic);
        }

        [Fact]
        public void AddIfNotContainsKeyTest2()
        {
            var key = Extensions.GetRandomString();
            var dic = new Dictionary<String, String>();

            var result = dic.AddIfNotContainsKey(key, Extensions.GetRandomString);
            Assert.True(result);
            Assert.Single(dic);

            result = dic.AddIfNotContainsKey(key, Extensions.GetRandomString);
            Assert.False(result);
            Assert.Single(dic);
        }

        [Fact]
        public void AddIfNotContainsKeyTest2NullCheck()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => Extensions.AddIfNotContainsKey(null, new Object(), () => new Object());

            test.ShouldThrow<NullReferenceException>();
        }

        [Fact]
        public void AddIfNotContainsKeyTest2NullCheck1()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => new Dictionary<Object, Object>().AddIfNotContainsKey(null, () => new Object());

            test.ShouldThrow<ArgumentNullException>();
        }

        [Fact]
        public void AddIfNotContainsKeyTest2NullCheck2()
        {
            Func<Object> func = null;
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => new Dictionary<Object, Object>().AddIfNotContainsKey(new Object(), func);

            test.ShouldThrow<NullReferenceException>();
        }

        [Fact]
        public void AddIfNotContainsKeyTest3()
        {
            var key = Extensions.GetRandomString();
            var dic = new Dictionary<String, String>();

            var result = dic.AddIfNotContainsKey(key, x => Extensions.GetRandomString());
            Assert.True(result);
            Assert.Single(dic);

            result = dic.AddIfNotContainsKey(key, x => Extensions.GetRandomString());
            Assert.False(result);
            Assert.Single(dic);
        }

        [Fact]
        public void AddIfNotContainsKeyTest3NullCheck()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => Extensions.AddIfNotContainsKey(null, new Object(), x => new Object());

            test.ShouldThrow<NullReferenceException>();
        }

        [Fact]
        public void AddIfNotContainsKeyTest3NullCheck1()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => new Dictionary<Object, Object>().AddIfNotContainsKey(null, x => new Object());

            test.ShouldThrow<ArgumentNullException>();
        }

        [Fact]
        public void AddIfNotContainsKeyTest3NullCheck2()
        {
            Func<Object, Object> func = null;
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => new Dictionary<Object, Object>().AddIfNotContainsKey(new Object(), func);

            test.ShouldThrow<NullReferenceException>();
        }

        [Fact]
        public void AddIfNotContainsKeyTestNullCheck()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => Extensions.AddIfNotContainsKey(null, new Object(), new Object());

            test.ShouldThrow<NullReferenceException>();
        }

        [Fact]
        public void AddIfNotContainsKeyTestNullCheck1()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => new Dictionary<Object, Object>().AddIfNotContainsKey(null, new Object());

            test.ShouldThrow<ArgumentNullException>();
        }
    }
}