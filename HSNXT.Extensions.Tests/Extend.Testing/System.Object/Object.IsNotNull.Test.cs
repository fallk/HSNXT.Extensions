#region Usings
using HSNXT;

using Xunit;

#endregion

namespace Extend.Testing
{
    public partial class ObjectExTest
    {
        [Fact]
        public void IsNotNullTest()
        {
            var value = Extensions.GetRandomString();
            var actual = value.IsNotNull();

            Assert.True( actual );

            value = null;
            // ReSharper disable once ExpressionIsAlwaysNull
            actual = value.IsNotNull();

            Assert.False( actual );
        }
    }
}