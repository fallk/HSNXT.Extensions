#region Usings
using HSNXT;

using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

#endregion

namespace Extend.Testing
{
    public partial class CollectionTExTest
    {
        [Fact]
        public void RemoveIfTest()
        {
            var list = new List<String>();
            var valueToRemove = Extensions.GetRandomString();
            list.Add( valueToRemove );

            Assert.Single( list );

            var result = list.RemoveIf( valueToRemove, x => false );
            Assert.Single( list );
            Assert.Same( list, result );

            list.RemoveIf( valueToRemove, x => true );
            Assert.Empty( list );
        }

        [Fact]
        public void RemoveIfTestNullCheck()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => Extensions.RemoveIf( null, "", x => true );

            test.ShouldThrow<NullReferenceException>();
        }

        [Fact]
        public void RemoveIfTestNullCheck1()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => new List<String>().RemoveIf( "", null );

            test.ShouldThrow<NullReferenceException>();
        }
    }
}