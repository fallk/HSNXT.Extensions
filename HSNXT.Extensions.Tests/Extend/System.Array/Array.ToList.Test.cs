#region Usings
using HSNXT;

using System;
using FluentAssertions;
using Xunit;

#endregion

namespace Extend.Testing
{
    public partial class ArrayExTest
    {
        [Fact]
        public void ToListTest()
        {
            Array array = new[]
            {
                "0",
                "1",
                "2"
            };
            var list = array.ToList( x => "test" + x );

            Assert.Equal( "test0", list[0] );
            Assert.Equal( "test1", list[1] );
            Assert.Equal( "test2", list[2] );
        }
    }
}