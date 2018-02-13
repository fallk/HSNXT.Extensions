#region Usings

using HSNXT;
using System;
using Xunit;

#endregion

namespace Extend.Testing
{
    public partial class ObjectExTest
    {
        [Fact]
        public void IsDefaultTest()
        {
            var value = default(String);
            // ReSharper disable once ExpressionIsAlwaysNull
            var actual = value.IsDefault();
            Assert.True(actual);

            value = Extensions.GetRandomString();
            actual = value.IsDefault();
            Assert.False(actual);
        }
    }
}