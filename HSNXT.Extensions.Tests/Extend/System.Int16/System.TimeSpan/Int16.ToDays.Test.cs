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
        public void ToDaysTest()
        {
            var value = Extensions.GetRandomInt32(1, 100);

            var expected = TimeSpan.FromDays(value);
            var actual = ((Int16) value).ToDays();
            Assert.Equal(expected, actual);
        }
    }
}