#region Usings

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
        public void ExtractTest()
        {
            var actual = "abcabc".Extract(x => x == 'a');
            Assert.Equal("aa", actual);
        }

        [Fact]
        public void ExtractTestNullCheck()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => Extensions.Extract(null, y => false);

            test.ShouldThrow<NullReferenceException>();
        }

        [Fact]
        public void ExtractTestNullCheck1()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => "".Extract((Func<char, bool>) null);

            test.ShouldThrow<ArgumentNullException>();
        }
    }
}