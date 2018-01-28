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
        public void IsAlphaTest()
        {
            var actual = "test".IsAlpha();
            Assert.True( actual );

            actual = "1test".IsAlpha();
            Assert.False( actual );
        }

        [Fact]
        public void IsAlphaTestNullCheck()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => Extensions.IsAlpha( null );

            test.ShouldThrow<ArgumentNullException>();
        }
    }
}