#region Usings
using HSNXT;

using System;
using FluentAssertions;
using Xunit;

#endregion

namespace Extend.Testing
{
    public class IndexedItemTest
    {
        [Fact]
        public void CtorTest()
        {
            var index = Extensions.GetRandomInt32();
            var value = Extensions.GetRandomString();
            var target = new IndexedItem<String>( index, value );

            target.Index.Should()
                  .Be( index );
            target.Item.Should()
                  .Be( value );
        }
    }
}