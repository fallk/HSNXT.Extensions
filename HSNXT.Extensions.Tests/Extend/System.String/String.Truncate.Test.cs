﻿#region Usings
using HSNXT;

using System;
using Xunit;

#endregion

namespace Extend.Testing
{
    public partial class StringExTest
    {
        [Fact]
        public void TruncateTest()
        {
            var actual = "testtest".Truncate( 7 );
            Assert.Equal( "test...", actual );
        }

        [Fact]
        public void TruncateTest1()
        {
            var actual = "testtest".Truncate( 7, "_-_" );
            Assert.Equal( "test_-_", actual );
        }

        [Fact]
        public void TruncateTest2()
        {
            var actual = "abc".Truncate( 7, "_-_" );
            Assert.Equal( "abc", actual );
        }

        [Fact]
        public void TruncateTest3()
        {
            var actual = String.Empty.Truncate( 7, "_-_" );
            Assert.Equal( String.Empty, actual );
        }
    }
}