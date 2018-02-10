using erichexter.Should.Core.Exceptions;
using Xunit;
using Assert = erichexter.Should.Core.Assertions.Assert;

namespace erichexter.Should.Facts.Core
{
    public class NotSameTests
    {
        [Fact]
        public void NotSameFailsWith()
        {
            object actual = new object();

            try
            {
                Should.Core.Assertions.Assert.NotSame(actual, actual);
            }
            catch (NotSameException exception)
            {
                Should.Core.Assertions.Assert.Equal("Assert.NotSame() Failure", exception.UserMessage);
            }
        }

        [Fact]
        public void ValuesAreNotTheSame()
        {
            Should.Core.Assertions.Assert.NotSame("bob", "jim");
        }

        [Fact]
        public void ValuesAreTheSame()
        {
            string jim = "jim";

            Should.Core.Assertions.Assert.Throws<NotSameException>(() => Should.Core.Assertions.Assert.NotSame(jim, jim));
        }

        [Fact]
        public void ValueTypesGetBoxedTwice()
        {
            int index = 0;

            Should.Core.Assertions.Assert.NotSame(index, index);
        }
    }
}