#region Usings

using HSNXT;
using System;
using FluentAssertions;
using Xunit;

#endregion

namespace Extend.Testing
{
    public partial class ActionExTest
    {
        [Fact]
        public void SafeExecuteTest()
        {
            var actual = Extensions.SafeExecute(() => { });
            Assert.True(actual);

            actual = Extensions.SafeExecute(() => throw new Exception());
            Assert.False(actual);
        }

        [Fact]
        public void SafeExecuteTest1_1()
        {
            var actual = Extensions.SafeExecute<ArgumentNullException>(() => { });
            Assert.True(actual);

            actual = Extensions.SafeExecute<ArgumentNullException>(() => throw new ArgumentNullException());
            Assert.False(actual);
        }

        [Fact]
        public void SafeExecuteTest1_2()
        {
            Action test = () => Extensions.SafeExecute<ArgumentNullException>(() => throw new OutOfMemoryException());

            test.ShouldThrow<OutOfMemoryException>();
        }

        [Fact]
        public void SafeExecuteTest1NullCheck()
        {
            Action action = null;
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => action.SafeExecute();

            test.ShouldThrow<ArgumentNullException>();
        }

        [Fact]
        public void SafeExecuteTest2_1()
        {
            var actual = Extensions.SafeExecute<ArgumentNullException, ArgumentOutOfRangeException>(() => { });
            Assert.True(actual);

            actual =
                Extensions.SafeExecute<ArgumentNullException, ArgumentOutOfRangeException>(
                    () => throw new ArgumentNullException());
            Assert.False(actual);

            actual =
                Extensions.SafeExecute<ArgumentNullException, ArgumentOutOfRangeException>(
                    () => throw new ArgumentOutOfRangeException());
            Assert.False(actual);
        }

        [Fact]
        public void SafeExecuteTest2_2()
        {
            Action test = () => Extensions.SafeExecute<ArgumentNullException, ArgumentOutOfRangeException>(
                () => throw new OutOfMemoryException());

            test.ShouldThrow<OutOfMemoryException>();
        }

        [Fact]
        public void SafeExecuteTest2NullCheck()
        {
            Action action = null;
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => action.SafeExecute();

            test.ShouldThrow<ArgumentNullException>();
        }

        [Fact]
        public void SafeExecuteTest3_1()
        {
            var actual =
                Extensions.SafeExecute<ArgumentNullException, ArgumentOutOfRangeException, InvalidCastException>(
                    () => { });
            Assert.True(actual);

            actual =
                Extensions.SafeExecute<ArgumentNullException, ArgumentOutOfRangeException, InvalidCastException>(
                    () => throw new ArgumentNullException());
            Assert.False(actual);

            actual =
                Extensions.SafeExecute<ArgumentNullException, ArgumentOutOfRangeException, InvalidCastException>(
                    () => throw new ArgumentOutOfRangeException());
            Assert.False(actual);

            actual =
                Extensions.SafeExecute<ArgumentNullException, ArgumentOutOfRangeException, InvalidCastException>(
                    () => throw new InvalidCastException());
            Assert.False(actual);
        }

        [Fact]
        public void SafeExecuteTest3_2()
        {
            Action test = () =>
                Extensions.SafeExecute<ArgumentNullException, ArgumentOutOfRangeException, InvalidCastException>(
                    () => throw new OutOfMemoryException());

            test.ShouldThrow<OutOfMemoryException>();
        }

        [Fact]
        public void SafeExecuteTest3NullCheck()
        {
            Action action = null;
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => action.SafeExecute();

            test.ShouldThrow<ArgumentNullException>();
        }

        [Fact]
        public void SafeExecuteTest4_1()
        {
            var actual =
                Extensions
                    .SafeExecute
                    <ArgumentNullException, ArgumentOutOfRangeException, InvalidCastException, InvalidOperationException
                    >(() => { });
            Assert.True(actual);

            actual =
                Extensions
                    .SafeExecute
                    <ArgumentNullException, ArgumentOutOfRangeException, InvalidCastException, InvalidOperationException
                    >(() => throw new ArgumentNullException());
            Assert.False(actual);

            actual =
                Extensions
                    .SafeExecute
                    <ArgumentNullException, ArgumentOutOfRangeException, InvalidCastException, InvalidOperationException
                    >(() => throw new ArgumentOutOfRangeException());
            Assert.False(actual);

            actual =
                Extensions
                    .SafeExecute
                    <ArgumentNullException, ArgumentOutOfRangeException, InvalidCastException, InvalidOperationException
                    >(() => throw new InvalidCastException());
            Assert.False(actual);

            actual =
                Extensions
                    .SafeExecute
                    <ArgumentNullException, ArgumentOutOfRangeException, InvalidCastException, InvalidOperationException
                    >(() => throw new InvalidOperationException());
            Assert.False(actual);
        }

        [Fact]
        public void SafeExecuteTest4_2()
        {
            Action test = () => Extensions
                .SafeExecute
                <ArgumentNullException, ArgumentOutOfRangeException, InvalidCastException, InvalidOperationException
                >(
                    () => throw new OutOfMemoryException());

            test.ShouldThrow<OutOfMemoryException>();
        }

        [Fact]
        public void SafeExecuteTest4NullCheck()
        {
            Action action = null;
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => action.SafeExecute();

            test.ShouldThrow<ArgumentNullException>();
        }

        [Fact]
        public void SafeExecuteTest5_1()
        {
            var actual =
                Extensions
                    .SafeExecute(() => { },
                        typeof(ArgumentNullException),
                        typeof(ArgumentOutOfRangeException),
                        typeof(InvalidCastException),
                        typeof(InvalidOperationException),
                        typeof(ArithmeticException));
            Assert.True(actual);

            actual =
                Extensions
                    .SafeExecute(() => throw new ArgumentNullException(),
                        typeof(ArgumentNullException),
                        typeof(ArgumentOutOfRangeException),
                        typeof(InvalidCastException),
                        typeof(InvalidOperationException),
                        typeof(ArithmeticException));
            Assert.False(actual);

            actual =
                Extensions
                    .SafeExecute(() => throw new ArgumentOutOfRangeException(),
                        typeof(ArgumentNullException),
                        typeof(ArgumentOutOfRangeException),
                        typeof(InvalidCastException),
                        typeof(InvalidOperationException),
                        typeof(ArithmeticException));
            Assert.False(actual);

            actual =
                Extensions
                    .SafeExecute(() => throw new InvalidCastException(),
                        typeof(ArgumentNullException),
                        typeof(ArgumentOutOfRangeException),
                        typeof(InvalidCastException),
                        typeof(InvalidOperationException),
                        typeof(ArithmeticException));
            Assert.False(actual);

            actual = Extensions.SafeExecute(() => throw new InvalidOperationException(),
                typeof(ArgumentNullException),
                typeof(ArgumentOutOfRangeException),
                typeof(InvalidCastException),
                typeof(InvalidOperationException),
                typeof(ArithmeticException));
            Assert.False(actual);

            actual = Extensions.SafeExecute(() => throw new ArithmeticException(),
                typeof(ArgumentNullException),
                typeof(ArgumentOutOfRangeException),
                typeof(InvalidCastException),
                typeof(InvalidOperationException),
                typeof(ArithmeticException));
            Assert.False(actual);
        }

        [Fact]
        public void SafeExecuteTest5_2()
        {
            Action test = () => Extensions.SafeExecute(() => throw new OutOfMemoryException(),
                typeof(ArgumentNullException),
                typeof(ArgumentOutOfRangeException),
                typeof(InvalidCastException),
                typeof(InvalidOperationException));

            test.ShouldThrow<OutOfMemoryException>();
        }

        [Fact]
        public void SafeExecuteTest5NullCheck()
        {
            Action action = null;
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => action.SafeExecute(typeof(Exception), typeof(ArgumentException));

            test.ShouldThrow<ArgumentNullException>();
        }

        [Fact]
        public void SafeExecuteTest5NullCheck1()
        {
            Action action = () => { };
            Type[] types = null;
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => action.SafeExecute(types);

            test.ShouldThrow<ArgumentNullException>();
        }

        [Fact]
        public void SafeExecuteTestNullCheck()
        {
            Action action = null;
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => action.SafeExecute();

            test.ShouldThrow<ArgumentNullException>();
        }
    }
}