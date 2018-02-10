using System;
using Xunit;
using Assert = erichexter.Should.Core.Assertions.Assert;

namespace erichexter.Should.Facts.Core
{
    public class RecordTests
    {
        public class MethodsWithoutReturnValues
        {
            [Fact]
            public void Exception()
            {
                Exception ex = Record.Exception(delegate { throw new InvalidOperationException(); });

                Should.Core.Assertions.Assert.NotNull(ex);
                Should.Core.Assertions.Assert.IsType<InvalidOperationException>(ex);
            }

            [Fact]
            public void NoException()
            {
                Exception ex = Record.Exception(delegate { });

                Should.Core.Assertions.Assert.Null(ex);
            }
        }

        public class MethodsWithReturnValues
        {
            [Fact]
            public void Exception()
            {
                StubAccessor accessor = new StubAccessor();

                Exception ex = Record.Exception(() => accessor.FailingProperty);

                Should.Core.Assertions.Assert.NotNull(ex);
                Should.Core.Assertions.Assert.IsType<InvalidOperationException>(ex);
            }

            [Fact]
            public void NoException()
            {
                StubAccessor accessor = new StubAccessor();

                Exception ex = Record.Exception(() => accessor.SuccessfulProperty);

                Should.Core.Assertions.Assert.Null(ex);
            }

            class StubAccessor
            {
                public int SuccessfulProperty { get; set; }

                public int FailingProperty
                {
                    get { throw new InvalidOperationException(); }
                }
            }
        }
    }
}