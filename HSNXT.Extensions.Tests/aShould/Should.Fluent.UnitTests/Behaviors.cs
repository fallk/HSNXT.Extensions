using System;
using Machine.Specifications;
using NUnit.Framework;
using erichexter.Should.Core.Exceptions;

namespace erichexter.Should.Fluent.UnitTests
{
    [Behaviors]
    public class Throws<T> where T : AssertException
    {
        protected static Exception exception;

        It should_throw_assert_exception_of_expected_type = () =>
        {
            Assert.IsNotNull(exception);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsInstanceOfType(exception, typeof(T));
        };
    }

    [Behaviors]
    public class DoesNotThrow
    {
        protected static Exception exception;
        It should_throw_not_equal_exception = () => Assert.IsNull(exception);
    }
}