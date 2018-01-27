﻿#region Usings
using HSNXT;

using System;
using Xunit;

#endregion

namespace Extend.Testing
{
    public partial class DecimalExTest
    {
        [Fact]
        public void PercentageOfTest()
        {
            var number = new Decimal( 1000 );
            const Int32 expected = 500;
            var actual = number.PercentageOf( 50 );

            Assert.Equal( expected, actual );
        }

        [Fact]
        public void PercentageOfTest1()
        {
            var number = new Decimal( 1000 );
            const Int32 expected = 500;
            var actual = number.PercentageOf( new Decimal( 50 ) );

            Assert.Equal( expected, actual );
        }

        [Fact]
        public void PercentageOfTest2()
        {
            var number = new Decimal( 1000 );
            const Int32 expected = 500;
            var actual = number.PercentageOf( (Int64) 50 );

            Assert.Equal( expected, actual );
        }
    }
}