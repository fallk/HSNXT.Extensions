#region Usings
using HSNXT;

using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

#endregion

namespace Extend.Testing
{
    public partial class ObjectExTest
    {
        [Fact]
        public void IsInTest()
        {
            var array = Extensions.GetRandomStrings()
                                     .ToArray();
            var value = array[0];

            var actual = value.IsIn( array );
            Assert.True( actual );

            value = Extensions.GetRandomString();
            actual = value.IsIn( array );
            Assert.False( actual );
        }

        [Fact]
        public void IsInTest1()
        {
            var list = Extensions.GetRandomStrings();
            var value = list[0];

            var actual = value.IsIn( list );
            Assert.True( actual );

            value = Extensions.GetRandomString();
            actual = value.IsIn( list );
            Assert.False( actual );
        }

        [Fact]
        public void IsInTest1NullCheck()
        {
            IEnumerable<String> enumerable = null;
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => "".IsIn( enumerable );

            test.ShouldThrow<ArgumentNullException>();
        }

        [Fact]
        public void IsInTestNullCheck()
        {
            String[] array = null;
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => "".IsIn( array );

            test.ShouldThrow<ArgumentNullException>();
        }
    }
}