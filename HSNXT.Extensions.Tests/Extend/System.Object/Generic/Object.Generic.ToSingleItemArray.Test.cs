#region Usings

using HSNXT;
using Xunit;

#endregion

namespace Extend.Testing
{
    public partial class ObjectExTest
    {
        [Fact]
        public void ToSingleItemArrayTest()
        {
            var item = Extensions.GetRandomString();

            var actual = item.ToSingleItemArray();

            Assert.Single(actual);
            Assert.Equal(item, actual[0]);
        }
    }
}