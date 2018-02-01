#region Usings
using HSNXT;

using Xunit;

#endregion

namespace Extend.Testing
{
    public partial class Int32ExTest
    {
        [Fact]
        public void IsMultipleOfTest()
        {
            var value = Extensions.GetRandomInt32();
            var factor = Extensions.GetRandomInt32();

            var expected = value % factor == 0;
            var actual = value.IsMultipleOf( factor );
            Assert.Equal( expected, actual );

            value = 10;
            factor = 2;

            actual = value.IsMultipleOf( factor );
            Assert.True( actual );

            value = 10;
            factor = 3;

            actual = value.IsMultipleOf( factor );
            Assert.False( actual );
        }
    }
}