using System;
using System.Runtime.CompilerServices;
using erichexter.Should.Core.Exceptions;
using Xunit;
using Assert = erichexter.Should.Core.Assertions.Assert;

namespace erichexter.Should.Facts.Core
{
    public class ThrowsTests
    {
        public class DoesNotThrow
        {
            [Fact]
            public void DoesNotThrowException()
            {
                bool methodCalled = false;

                Should.Core.Assertions.Assert.DoesNotThrow(() => methodCalled = true);

                Should.Core.Assertions.Assert.True(methodCalled);
            }
        }

        public class ThrowsGenericNoReturnValue
        {
            [Fact]
            public void ExpectExceptionButCodeDoesNotThrow()
            {
                try
                {
                    Should.Core.Assertions.Assert.Throws<ArgumentException>(delegate { });
                }
                catch (AssertActualExpectedException exception)
                {
                    Should.Core.Assertions.Assert.Equal("(No exception was thrown)", exception.Actual);
                }
            }

            [Fact]
            public void ExpectExceptionButCodeThrowsDerivedException()
            {
                try
                {
                    Should.Core.Assertions.Assert.Throws<Exception>(delegate
                    {
                        throw new InvalidOperationException();
                    });
                }
                catch (AssertException exception)
                {
                    Should.Core.Assertions.Assert.Equal("Assert.Throws() Failure", exception.UserMessage);
                }
            }

            [MethodImpl(MethodImplOptions.NoInlining)]
            static void ThrowingMethod()
            {
                throw new ArgumentException();
            }

            [Fact]
            public void GotExpectedException()
            {
                ArgumentException ex =
                    Should.Core.Assertions.Assert.Throws<ArgumentException>(delegate
                    {
                        throw new ArgumentException();
                    });

                Should.Core.Assertions.Assert.NotNull(ex);
            }
        }

        public class ThrowsGenericWithReturnValue
        {
            [Fact]
            public void ExpectExceptionButCodeDoesNotThrow()
            {
                StubAccessor accessor = new StubAccessor();

                try
                {
                    Should.Core.Assertions.Assert.Throws<ArgumentException>(() => accessor.SuccessfulProperty);
                }
                catch (AssertActualExpectedException exception)
                {
                    Should.Core.Assertions.Assert.Equal("(No exception was thrown)", exception.Actual);
                }
            }

            [Fact]
            public void ExpectExceptionButCodeThrowsDerivedException()
            {
                StubAccessor accessor = new StubAccessor();

                try
                {
                    Should.Core.Assertions.Assert.Throws<Exception>(() => accessor.FailingProperty);
                }
                catch (AssertException exception)
                {
                    Should.Core.Assertions.Assert.Equal("Assert.Throws() Failure", exception.UserMessage);
                }
            }

            [Fact]
            public void GotExpectedException()
            {
                StubAccessor accessor = new StubAccessor();

                InvalidOperationException ex =
                    Should.Core.Assertions.Assert.Throws<InvalidOperationException>(() => accessor.FailingProperty);

                Should.Core.Assertions.Assert.NotNull(ex);
            }
        }

        public class ThrowsNonGenericNoReturnValue
        {
            [Fact]
            public void ExpectExceptionButCodeDoesNotThrow()
            {
                try
                {
                    Should.Core.Assertions.Assert.Throws(typeof(ArgumentException), delegate { });
                }
                catch (AssertActualExpectedException exception)
                {
                    Should.Core.Assertions.Assert.Equal("(No exception was thrown)", exception.Actual);
                }
            }

            [Fact]
            public void ExpectExceptionButCodeThrowsDerivedException()
            {
                try
                {
                    Should.Core.Assertions.Assert.Throws(typeof(Exception),
                        delegate { throw new InvalidOperationException(); });
                }
                catch (AssertException exception)
                {
                    Should.Core.Assertions.Assert.Equal("Assert.Throws() Failure", exception.UserMessage);
                }
            }

            [Fact]
            public void GotExpectedException()
            {
                Exception ex =
                    Should.Core.Assertions.Assert.Throws(typeof(ArgumentException),
                        delegate { throw new ArgumentException(); });

                Should.Core.Assertions.Assert.NotNull(ex);
                Should.Core.Assertions.Assert.IsType<ArgumentException>(ex);
            }
        }

        public class ThrowsNonGenericWithReturnValue
        {
            [Fact]
            public void ExpectExceptionButCodeDoesNotThrow()
            {
                StubAccessor accessor = new StubAccessor();

                try
                {
                    Should.Core.Assertions.Assert.Throws(typeof(ArgumentException), () => accessor.SuccessfulProperty);
                }
                catch (AssertActualExpectedException exception)
                {
                    Should.Core.Assertions.Assert.Equal("(No exception was thrown)", exception.Actual);
                }
            }

            [Fact]
            public void ExpectExceptionButCodeThrowsDerivedException()
            {
                StubAccessor accessor = new StubAccessor();

                try
                {
                    Should.Core.Assertions.Assert.Throws(typeof(Exception), () => accessor.FailingProperty);
                }
                catch (AssertException exception)
                {
                    Should.Core.Assertions.Assert.Equal("Assert.Throws() Failure", exception.UserMessage);
                }
            }

            [Fact]
            public void GotExpectedException()
            {
                StubAccessor accessor = new StubAccessor();

                Exception ex =
                    Should.Core.Assertions.Assert.Throws(typeof(InvalidOperationException),
                        () => accessor.FailingProperty);

                Should.Core.Assertions.Assert.NotNull(ex);
                Should.Core.Assertions.Assert.IsType<InvalidOperationException>(ex);
            }
        }

        class StubAccessor
        {
            public int SuccessfulProperty { get; set; }

            public int FailingProperty
            {
                get { throw new InvalidOperationException(); }
            }
        }

        private static string GetMethodFullName(Delegate @delegate)
        {
            var methodInfo = @delegate.Method.GetBaseDefinition();
            return string.Format("{0}.{1}", methodInfo.ReflectedType.FullName.Replace("+", "."), methodInfo.Name);
        }
    }
}