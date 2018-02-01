﻿#region Usings
using HSNXT;

using System;
using FluentAssertions;
using Xunit;

#endregion

namespace Extend.Testing
{
    public partial class DecimalExTest
    {
        [Fact]
        public void PercentOfTest()
        {
            var number = new Decimal( 1000 );
            const Int32 expected = 200;
            var actual = number.PercentOf( 500 );

            Assert.Equal( expected, actual );
        }

        [Fact]
        public void PercentOfTest1()
        {
            var number = new Decimal( 1000 );
            const Int32 expected = 200;
            var actual = number.PercentOf( new Decimal( 500 ) );

            Assert.Equal( expected, actual );
        }

        [Fact]
        public void PercentOfTest1DivideByZero()
        {
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => Extensions.PercentOf( 0, new Decimal( 10 ) );

            test.ShouldNotThrow();
        }

        [Fact]
        public void PercentOfTest2()
        {
            var number = new Decimal( 1000 );
            const Int32 expected = 200;
            var actual = number.PercentOf( (Int64) 500 );

            Assert.Equal( expected, actual );
        }

        [Fact]
        public void PercentOfTest2DivideByZero()
        {
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => Extensions.PercentOf( 0, (Int64) 100 );

            test.ShouldNotThrow();
        }

        [Fact]
        public void PercentOfTestDivideByZero()
        {
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => Extensions.PercentOf( 0, 100 );

            test.ShouldNotThrow();
        }
    }
}