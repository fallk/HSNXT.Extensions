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
        public void CompareOrdinalIgnoreNullTest()
        {
            var left = Extensions.GetRandomString();
            String right = null;

            // ReSharper disable once ExpressionIsAlwaysNull
            var actual = left.CompareOrdinalIgnoreCase( right );

            actual
                .Should()
                .BeFalse();
        }

        [Fact]
        public void CompareOrdinalIgnoreNullTest1()
        {
            String left = null;
            var right = Extensions.GetRandomString();

            // ReSharper disable once ExpressionIsAlwaysNull
            var actual = left.CompareOrdinalIgnoreCase( right );

            actual
                .Should()
                .BeFalse();
        }

        [Fact]
        public void CompareOrdinalIgnoreTest()
        {
            var value1 = Extensions.GetRandomString();
            var value2 = value1;

            var actual = value1.CompareOrdinalIgnoreCase( value2 );
            Assert.True( actual );

            value2 = value1.ToUpper();
            actual = value1.CompareOrdinalIgnoreCase( value2 );
            Assert.True( actual );

            value2 = Extensions.GetRandomString();
            actual = value1.CompareOrdinalIgnoreCase( value2 );
            Assert.False( actual );
        }
    }
}