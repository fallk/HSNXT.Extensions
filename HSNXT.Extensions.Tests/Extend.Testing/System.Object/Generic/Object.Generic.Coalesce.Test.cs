#region Usings
using HSNXT;

using System;
using FluentAssertions;
using Xunit;

#endregion

namespace Extend.Testing
{
    public partial class ObjectExTest
    {
        [Fact]
        public void CoalesceTest()
        {
            var expected = Extensions.GetRandomString();
            var actual = Extensions.Coalesce( null, null, null, null, expected, "Test2" );

            Assert.Equal( expected, actual );
        }

        [Fact]
        public void CoalesceTest1()
        {
            var expected = Extensions.GetRandomString();
            var actual = Extensions.Coalesce( null, null, null, null, expected, "Test2" );

            Assert.Equal( expected, actual );
        }

        [Fact]
        public void CoalesceTest2()
        {
            var expected = Extensions.GetRandomString();
            var actual = expected.Coalesce( null, null, null, expected, "Test2" );

            Assert.Equal( expected, actual );
        }

        [Fact]
        public void CoalesceTest3()
        {
            var expected = Extensions.GetRandomString();
            var actual = expected.Coalesce( "Test2" );

            Assert.Equal( expected, actual );
        }

        [Fact]
        public void CoalesceTest4()
        {
            var expected = Extensions.GetRandomString();
            String value = null;
            // ReSharper disable once ExpressionIsAlwaysNull
            var actual = expected.Coalesce( value );

            Assert.Equal( expected, actual );
        }

        [Fact]
        public void CoalesceTest5()
        {
            var expected = Extensions.GetRandomString();
            String value = null;
            // ReSharper disable once ExpressionIsAlwaysNull
            var actual = value.Coalesce( expected );

            Assert.Equal( expected, actual );
        }

        [Fact]
        public void CoalesceTestInvalidOperationCheck()
        {
            Object[] array = null;
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            // ReSharper disable once ExpressionIsAlwaysNull
            Action test = () => Extensions.Coalesce( null, array, null );

            test.ShouldNotThrow();
        }

        [Fact]
        public void CoalesceTestNullCheck()
        {
            String s = null;
            String[] array = null;
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            // ReSharper disable once ExpressionIsAlwaysNull
            Action test = () => s.Coalesce( array );

            test.ShouldThrow<NullReferenceException>();
        }
    }
}