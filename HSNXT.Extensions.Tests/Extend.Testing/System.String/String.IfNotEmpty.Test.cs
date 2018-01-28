#region Usings
using HSNXT;

using Xunit;

#endregion

namespace Extend.Testing
{
    public partial class StringExTest
    {
        [Fact]
        public void IfEmptyTest()
        {
            var actual = Extensions.IfNotEmpty( null, "test" );
            Assert.Equal( null, actual );

            actual = "".IfNotEmpty( "test" );
            Assert.Equal( "test", actual );

            actual = "   ".IfNotEmpty( "test" );
            Assert.Equal( "   ", actual );

            actual = "abc".IfNotEmpty( "test" );
            Assert.Equal( "abc", actual );
        }
    }
}