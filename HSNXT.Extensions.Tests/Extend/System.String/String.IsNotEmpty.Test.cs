﻿#region Usings

using HSNXT;
using Xunit;

#endregion

namespace Extend.Testing
{
    public partial class StringExTest
    {
        [Fact]
        public void IsNotEmptyTest()
        {
            var value = "";
            Assert.False(value.IsNotEmpty());

            value = null;
            Assert.True(value.IsNotEmpty());

            value = "   ";
            Assert.True(value.IsNotEmpty());

            value = Extensions.GetRandomString();
            Assert.True(value.IsNotEmpty());
        }
    }
}