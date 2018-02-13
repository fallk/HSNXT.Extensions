#region Usings

using HSNXT;
using Xunit;

#endregion

namespace Extend.Testing
{
    public partial class StringExTest
    {
        [Fact]
        public void IsEmptyTest()
        {
            var value = "";
            Assert.True(value.IsEmpty());

            value = null;
            Assert.False(value.IsEmpty());

            value = "   ";
            Assert.False(value.IsEmpty());

            value = Extensions.GetRandomString();
            Assert.False(value.IsEmpty());
        }
    }
}