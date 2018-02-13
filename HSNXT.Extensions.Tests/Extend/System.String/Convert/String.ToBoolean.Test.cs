#region Usings

using HSNXT;
using System;
using FluentAssertions;
using Xunit;

#endregion

namespace Extend.Testing
{
    public partial class StringExTest
    {
        [Fact]
        public void ToBooleanInvalidFormatTest()
        {
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => "invalidValue".ToBoolean();

            test.ShouldNotThrow();
        }

        [Fact]
        public void ToBooleanNullTest()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => Extensions.ToBoolean(null);

            test.ShouldNotThrow();
        }

        [Fact]
        public void ToBooleanTest()
        {
            var value = Extensions.GetRandomBoolean();
            var actual = value.ToString()
                .ToBoolean();

            actual
                .Should()
                .Be(value);
        }
    }
}