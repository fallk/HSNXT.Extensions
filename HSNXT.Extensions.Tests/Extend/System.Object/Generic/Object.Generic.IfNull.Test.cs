#region Usings

using HSNXT;
using Xunit;

#endregion

namespace Extend.Testing
{
    public partial class ObjectExTest
    {
        [Fact]
        public void IfNullTest()
        {
            var expected = Extensions.GetRandomString();

            var actual = Extensions.IfNull(null, expected);
            Assert.Equal(expected, actual);

            actual = expected.IfNull((string) null);
            Assert.Equal(expected, actual);
        }
    }
}