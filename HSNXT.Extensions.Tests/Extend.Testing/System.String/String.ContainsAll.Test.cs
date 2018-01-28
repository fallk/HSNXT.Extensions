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
        public void ContainsAllTest()
        {
            var actual = "test012".ContainsAll( "0", "1", "2" );
            Assert.True( actual );
        }

        [Fact]
        public void ContainsAllTest1()
        {
            var actual = "ABC".ContainsAll( StringComparison.OrdinalIgnoreCase, "a", "b", "c" );
            Assert.True( actual );
        }

        [Fact]
        public void ContainsAllTest1NullCheck()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => Extensions.ContainsAll( null, StringComparison.CurrentCulture, "" );

            test.ShouldThrow<NullReferenceException>();
        }

        [Fact]
        public void ContainsAllTest1NullCheck1()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => "".ContainsAll( StringComparison.CurrentCulture, null );

            test.ShouldThrow<NullReferenceException>();
        }

        [Fact]
        public void ContainsAllTestNullCheck()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => Extensions.ContainsAll( null, "" );

            test.ShouldThrow<NullReferenceException>();
        }

        [Fact]
        public void ContainsAllTestNullCheck1()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => "".ContainsAll( null );

            test.ShouldThrow<NullReferenceException>();
        }
    }
}