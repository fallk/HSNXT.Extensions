#region Usings

using HSNXT;
using System;
using FluentAssertions;
using Xunit;

#endregion

namespace Extend.Testing
{
    public partial class Int64ExTest
    {
        [Fact]
        public void FactorOfDivideByZeroTest()
        {
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => Extensions.FactorOf(0, 100);
            test.ShouldThrow<DivideByZeroException>();
        }

        [Fact]
        public void FactorOfTest()
        {
            var value = Extensions.GetRandomInt32();
            var factorNumer = Extensions.GetRandomInt32();

            var expected = factorNumer % value == 0;
            var actual = Extensions.FactorOf(value, factorNumer);
            actual
                .Should()
                .Be(expected);

            actual = Extensions.FactorOf(10, 100);
            actual
                .Should()
                .Be(true);

            actual = Extensions.FactorOf(100, 10);
            actual
                .Should()
                .Be(false);

            actual = Extensions.FactorOf(11, 100);
            actual
                .Should()
                .Be(false);
        }
    }
}