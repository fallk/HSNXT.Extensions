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
        public void ToGuidInvalidFormatTest()
        {
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => "InvalidFormat".ToGuid();

            test.ShouldNotThrow();
        }

        [Fact]
        public void ToGuidNullTest()
        {
            String value = null;

            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => value.ToGuid();

            test.ShouldNotThrow();
        }

        [Fact]
        public void ToGuidTest()
        {
            var value = Guid.NewGuid();
            var actual = value.ToString()
                              .ToGuid();

            actual
                .Should()
                .Be( value );
        }
    }
}