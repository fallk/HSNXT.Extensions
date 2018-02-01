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
        public void SubstringLeftTest()
        {
            var actual = "testabc".SubstringLeft( 4 );
            Assert.Equal( "test", actual );
        }

        [Fact]
        public void SubstringLeftTestNullCheck()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => Extensions.SubstringLeft( null, 1 );

            test.ShouldThrow<NullReferenceException>();
        }
    }
}