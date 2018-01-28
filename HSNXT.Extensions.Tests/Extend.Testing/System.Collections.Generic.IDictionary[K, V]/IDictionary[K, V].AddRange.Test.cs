#region Usings
using HSNXT;

using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

#endregion

namespace Extend.Testing
{
    // ReSharper disable once InconsistentNaming
    public partial class IDictionaryExTest
    {
        [Fact]
        public void AddRangeTest()
        {
            var dictionary = new Dictionary<String, String>
            {
                { Extensions.GetRandomString(), Extensions.GetRandomString() },
                { Extensions.GetRandomString(), Extensions.GetRandomString() }
            };

            var otherDictionary = new Dictionary<String, String>
            {
                { Extensions.GetRandomString(), Extensions.GetRandomString() },
                { Extensions.GetRandomString(), Extensions.GetRandomString() }
            };

            Assert.Equal( 2, dictionary.Count );

            var actual = dictionary.AddRange( otherDictionary );
            actual
                .Should()
                .BeSameAs( dictionary );
            Assert.Equal( 4, dictionary.Count );
            Assert.True( dictionary.ContainAll( otherDictionary ) );
        }

        [Fact]
        public void AddRangeTestNullCheck()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => Extensions.AddRange( null, new Dictionary<Object, Object>() );

            test.ShouldThrow<ArgumentNullException>();
        }

        [Fact]
        public void AddRangeTestNullCheck1()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => new Dictionary<Object, Object>().AddRange( null );

            test.ShouldThrow<ArgumentNullException>();
        }
    }
}