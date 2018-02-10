using System;
using Xunit;
using System.Collections;
using erichexter.Should.Core.Exceptions;

namespace erichexter.Should.Facts
{
    public class ObjectAssertionExtensionFacts
    {
        [Fact]
        public void ShouldNotBeNull_accepts_a_message_to_describe_failure()
        {
            String s = null;

            var ex = Assert.Throws<NotNullException>(() =>
            {
                s.ShouldNotBeNull("custom failure message");
            });

            Assert.Equal(ex.Message, "custom failure message");
        }

        [Fact]
        public void ShouldNotBeNull_returns_a_strongly_typed_sut_to_support_optional_chaining()
        {
            String s = "foo";

            var sut = s.ShouldNotBeNull();

            Assert.IsAssignableFrom<String>(sut);
        }

        [Fact]
        public void ShouldNotBeNull_with_message_returns_a_strongly_typed_sut_to_support_optional_chaining()
        {
            String s = "foo";

            var sut = s.ShouldNotBeNull("custom failure message");

            Assert.IsAssignableFrom<String>(sut);
        }

    }
}
