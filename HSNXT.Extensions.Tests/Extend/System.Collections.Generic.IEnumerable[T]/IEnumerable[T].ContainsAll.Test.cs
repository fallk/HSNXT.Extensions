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
        public void ContainsAllTest()
        {
            var list = new List<String> { "test", "test1" };

            Assert.True( list.ContainsAllThese( "test" ) );
            Assert.True( list.ContainsAllThese( "test", "test1" ) );
            Assert.False( list.ContainsAllThese( "test", "test1", "test2" ) );
        }

        [Fact]
        public void ContainsAllTest1()
        {
            var list = new List<String> { "test", "test1" };

            Assert.True( list.ContainAll( new List<String> { "test" } ) );
            Assert.True( list.ContainAll( list ) );
            Assert.False( list.ContainAll( new List<String> { "test", "test1", "test2" } ) );
        }

        [Fact]
        public void ContainsAllTest1NullCheck()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => Extensions.ContainAll( null, new List<String>() );

            test.ShouldThrow<ArgumentNullException>();
        }

        [Fact]
        public void ContainsAllTest1NullCheck1()
        {
            IEnumerable<Object> enumerable = null;
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => new List<Object>().ContainAll( enumerable );

            test.ShouldThrow<ArgumentNullException>();
        }

        [Fact]
        public void ContainsAllTestNullCheck()
        {
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => Extensions.ContainsAllThese( null, new Object(), new Object() );

            test.ShouldThrow<ArgumentNullException>();
        }

        [Fact]
        public void ContainsAllTestNullCheck1()
        {
            Object[] array = null;
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => new List<Object>().ContainAll( array );

            test.ShouldThrow<ArgumentNullException>();
        }
    }
}