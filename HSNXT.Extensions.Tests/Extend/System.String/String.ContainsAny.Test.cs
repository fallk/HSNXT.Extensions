﻿#region Usings

using HSNXT;
using System;
using FluentAssertions;
using Xunit;

#endregion

namespace Extend.Testing
{
    public partial class StringExTest
    {
        [Fact]
        public void ContainsAnyTest()
        {
            var actual = "test012".ContainsAny("0", "1", "2", "abcd");
            Assert.True(actual);
        }

        [Fact]
        public void ContainsAnyTest1()
        {
            var actual = "ABC".ContainsAny(StringComparison.OrdinalIgnoreCase, "a", "b", "c", "abcd");
            Assert.True(actual);
        }

        [Fact]
        public void ContainsAnyTest1NullCheck()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => Extensions.ContainsAny(null, StringComparison.CurrentCulture, "");

            test.ShouldThrow<NullReferenceException>();
        }

        [Fact]
        public void ContainsAnyTest1NullCheck1()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => "".ContainsAny(StringComparison.CurrentCulture, null);

            test.ShouldThrow<NullReferenceException>();
        }

        [Fact]
        public void ContainsAnyTestNullCheck()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => Extensions.ContainsAny(null, "");

            test.ShouldThrow<NullReferenceException>();
        }

        [Fact]
        public void ContainsAnyTestNullCheck1()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => "".ContainsAny((string) null);

            test.ShouldThrow<ArgumentNullException>();
        }
    }
}