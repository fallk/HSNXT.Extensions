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
    public partial class IEnumerableTExTest
    {
        [Fact]
        public void ContainAnyTest()
        {
            var list = new List<String> {"test", "test1"};

            Assert.True(list.ContainAny("test"));
            Assert.True(list.ContainAny("test", "test1"));
            Assert.True(list.ContainAny("test", "test1", "test2"));
            Assert.False(list.ContainAny("asdasd"));
        }

        [Fact]
        public void ContainAnyTest1()
        {
            var list = new List<String> {"test", "test1"};

            Assert.True(list.ContainAny(new List<String> {"test"}));
            Assert.True(list.ContainAny(new List<String> {"test", "test1"}));
            Assert.True(list.ContainAny(new List<String> {"test", "test1", "test2"}));
            Assert.False(list.ContainAny(new List<String> {"asdasd"}));
        }

        [Fact]
        public void ContainAnyTest1NullCheck()
        {
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => Extensions.ContainAny(null, new List<Object>());

            test.ShouldThrow<ArgumentNullException>();
        }

        [Fact]
        public void ContainAnyTest1NullCheck1()
        {
            IEnumerable<Object> enumerable = null;
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => new List<String>().ContainAny(enumerable);

            test.ShouldThrow<ArgumentNullException>();
        }

        [Fact]
        public void ContainAnyTestNullCheck()
        {
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => Extensions.ContainAny(null, new Object(), new Object());

            test.ShouldThrow<ArgumentNullException>();
        }

        [Fact]
        public void ContainAnyTestNullCheck1()
        {
            Object[] array = null;
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => new List<String>().ContainAny(array);

            test.ShouldThrow<ArgumentNullException>();
        }
    }
}