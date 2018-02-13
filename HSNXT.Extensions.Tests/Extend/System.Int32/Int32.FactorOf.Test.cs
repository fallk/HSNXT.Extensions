#region Usings

using HSNXT;
using Xunit;

#endregion

namespace Extend.Testing
{
    public partial class Int32ExTest
    {
        [Fact]
        public void FactorOfTest()
        {
            var value = Extensions.GetRandomInt32();
            var factorNumer = Extensions.GetRandomInt32();

            var expected = factorNumer % value == 0;
            var actual = value.FactorOf(factorNumer);
            Assert.Equal(expected, actual);

            value = 10;
            factorNumer = 100;
            actual = value.FactorOf(factorNumer);
            Assert.True(actual);

            value = 11;
            factorNumer = 100;
            actual = value.FactorOf(factorNumer);
            Assert.False(actual);
        }
    }
}