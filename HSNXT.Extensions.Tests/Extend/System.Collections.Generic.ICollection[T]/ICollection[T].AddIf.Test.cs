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
        public void AddIfTest()
        {
            var c = new List<String>();

            var result = c.AddIf( x => true, Extensions.GetRandomString() );
            Assert.Single( c );
            Assert.True( result );

            result = c.AddIf( x => false, Extensions.GetRandomString() );
            Assert.Single( c );
            Assert.False( result );
        }

        [Fact]
        public void AddIfTestNullCheck()
        {
            List<String> c = null;
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => c.AddIf( x => true, Extensions.GetRandomString() );

            test.ShouldThrow<NullReferenceException>();
        }

        [Fact]
        public void AddIfTestNullCheck1()
        {
            var c = new List<String>();
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => c.AddIf( null, Extensions.GetRandomString() );

            test.ShouldThrow<NullReferenceException>();
        }
    }
}