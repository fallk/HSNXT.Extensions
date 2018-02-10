using System;
using Xunit;
using Assert = erichexter.Should.Core.Assertions.Assert;
using AssertException = erichexter.Should.Core.Exceptions.AssertException;
using SameException = erichexter.Should.Core.Exceptions.SameException;

namespace erichexter.Should.Facts.Core
{
    public class SameTests
    {
        [Fact]
        public void BoxedTypesDontWork()
        {
            int index = 0;

            Should.Core.Assertions.Assert.Throws<Should.Core.Exceptions.SameException>(() => Should.Core.Assertions.Assert.Same(index, index));
        }

        [Fact]
        public void SameFailsWith()
        {
            string actual = "Abc";
            string expected = "a".ToUpperInvariant() + "bc";

            try
            {
                Should.Core.Assertions.Assert.Same(expected, actual);
            }
            catch (Exception ex)
            {
                Should.Core.Exceptions.AssertException aex = Should.Core.Assertions.Assert.IsAssignableFrom<Should.Core.Exceptions.AssertException>(ex);
                Should.Core.Assertions.Assert.Equal("Assert.Same() Failure", aex.UserMessage);
                Should.Core.Assertions.Assert.DoesNotContain("Position:", aex.Message);
            }
        }

        [Fact]
        public void ValuesAreNotTheSame()
        {
            Should.Core.Assertions.Assert.Throws<Should.Core.Exceptions.SameException>(() => Should.Core.Assertions.Assert.Same("bob", "jim"));
        }

        [Fact]
        public void ValuesAreTheSame()
        {
            string jim = "jim";

            Should.Core.Assertions.Assert.Same(jim, jim);
        }
    }
}