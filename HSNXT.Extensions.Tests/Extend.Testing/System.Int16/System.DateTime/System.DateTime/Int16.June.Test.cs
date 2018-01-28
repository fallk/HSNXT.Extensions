﻿#region Usings
using HSNXT;

using System;
using Xunit;

#endregion

namespace Extend.Testing
{
    public partial class Int16ExTest
    {
        [Fact]
        public void JuneTest()
        {
            var expected = new DateTime( 2000, 6, 10 );
            var actual = Extensions.June( 10, 2000 );
            Assert.Equal( expected, actual );
        }
    }
}