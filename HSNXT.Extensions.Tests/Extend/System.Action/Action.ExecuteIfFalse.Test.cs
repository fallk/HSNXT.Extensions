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
        public void ExecuteIfFalseTest()
        {
            // Case 1
            var falseActionExecuted = false;
            var trueActionExecuted = false;
            Extensions.ExecuteIfFalse(() => falseActionExecuted = true, null, false, false);

            Assert.True(falseActionExecuted);
            Assert.False(trueActionExecuted);

            // Case 2
            // ReSharper disable once HeuristicUnreachableCode
            falseActionExecuted = false;
            Extensions.ExecuteIfFalse(() => falseActionExecuted = true, () => trueActionExecuted = true, false, false);

            Assert.True(falseActionExecuted);
            Assert.False(trueActionExecuted);

            // Case 3
            falseActionExecuted = false;
            trueActionExecuted = false;
            Extensions.ExecuteIfFalse(() => falseActionExecuted = true, () => trueActionExecuted = true, true, false);

            Assert.False(falseActionExecuted);
            Assert.True(trueActionExecuted);

            // Case 4
            falseActionExecuted = false;
            trueActionExecuted = false;
            Extensions.ExecuteIfFalse(() => falseActionExecuted = true, null, true, false);

            Assert.False(falseActionExecuted);
            Assert.False(trueActionExecuted);

            // Case 5
            falseActionExecuted = false;
            trueActionExecuted = false;
            Extensions.ExecuteIfFalse(() => falseActionExecuted = true, null, true, false);

            Assert.False(falseActionExecuted);
            Assert.False(trueActionExecuted);
        }

        [Fact]
        public void ExecuteIfFalseTest1()
        {
            var parameter = Extensions.GetRandomString();

            // Case 1
            var falseActionExecuted = false;
            var trueActionExecuted = false;
            Extensions.ExecuteIfFalse(
                x => falseActionExecuted = x == parameter,
                parameter,
                null,
                false,
                false);

            Assert.True(falseActionExecuted);
            Assert.False(trueActionExecuted);

            // Case 2
            // ReSharper disable once HeuristicUnreachableCode
            falseActionExecuted = false;
            Extensions.ExecuteIfFalse(
                x => falseActionExecuted = x == parameter,
                parameter,
                x => trueActionExecuted = x == parameter,
                false,
                false);

            Assert.True(falseActionExecuted);
            Assert.False(trueActionExecuted);

            // Case 3
            falseActionExecuted = false;
            trueActionExecuted = false;
            Extensions.ExecuteIfFalse(
                x => falseActionExecuted = x == parameter,
                parameter,
                x => trueActionExecuted = x == parameter,
                true,
                false);

            Assert.False(falseActionExecuted);
            Assert.True(trueActionExecuted);

            // Case 4
            falseActionExecuted = false;
            trueActionExecuted = false;
            Extensions.ExecuteIfFalse(
                x => falseActionExecuted = x == parameter,
                parameter,
                null,
                true,
                false);

            Assert.False(falseActionExecuted);
            Assert.False(trueActionExecuted);

            // Case 5
            falseActionExecuted = false;
            trueActionExecuted = false;
            Extensions.ExecuteIfFalse(x => falseActionExecuted = x == parameter, parameter, null, true, false);

            Assert.False(falseActionExecuted);
            Assert.False(trueActionExecuted);
        }

        [Fact]
        public void ExecuteIfFalseTest1NullCheck()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => Extensions.ExecuteIfFalse(null, Extensions.GetRandomString(), null, false, false);

            test.ShouldThrow<ArgumentNullException>();
        }

        [Fact]
        public void ExecuteIfFalseTest2()
        {
            var parameter1 = Extensions.GetRandomString();
            var parameter2 = Extensions.GetRandomString();

            // Case 1
            var falseActionExecuted = false;
            var trueActionExecuted = false;
            Extensions.ExecuteIfFalse(
                (p1, p2) => falseActionExecuted = p1 == parameter1 && p2 == parameter2,
                parameter1,
                parameter2,
                null,
                false,
                false);

            Assert.True(falseActionExecuted);
            Assert.False(trueActionExecuted);

            // Case 2
            // ReSharper disable once HeuristicUnreachableCode
            falseActionExecuted = false;
            Extensions.ExecuteIfFalse(
                (p1, p2) => falseActionExecuted = p1 == parameter1 && p2 == parameter2,
                parameter1,
                parameter2,
                (p1, p2) => trueActionExecuted = p1 == parameter1 && p2 == parameter2,
                false,
                false);

            Assert.True(falseActionExecuted);
            Assert.False(trueActionExecuted);

            // Case 3
            falseActionExecuted = false;
            trueActionExecuted = false;
            Extensions.ExecuteIfFalse(
                (p1, p2) => falseActionExecuted = p1 == parameter1 && p2 == parameter2,
                parameter1,
                parameter2,
                (p1, p2) => trueActionExecuted = p1 == parameter1 && p2 == parameter2,
                true,
                false);

            Assert.False(falseActionExecuted);
            Assert.True(trueActionExecuted);

            // Case 4
            falseActionExecuted = false;
            trueActionExecuted = false;
            Extensions.ExecuteIfFalse(
                (p1, p2) => falseActionExecuted = p1 == parameter1 && p2 == parameter2,
                parameter1,
                parameter2,
                null,
                true,
                false);

            Assert.False(falseActionExecuted);
            Assert.False(trueActionExecuted);

            // Case 5
            falseActionExecuted = false;
            trueActionExecuted = false;
            Extensions.ExecuteIfFalse((p1, p2) => falseActionExecuted = p1 == parameter1 && p2 == parameter2,
                parameter1,
                parameter2,
                null,
                true,
                false);

            Assert.False(falseActionExecuted);
            Assert.False(trueActionExecuted);
        }

        [Fact]
        public void ExecuteIfFalseTest2NullCheck()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => Extensions.ExecuteIfFalse(null,
                Extensions.GetRandomString(),
                Extensions.GetRandomString(),
                null,
                false,
                false);

            test.ShouldThrow<ArgumentNullException>();
        }

        [Fact]
        public void ExecuteIfFalseTest3()
        {
            var parameter1 = Extensions.GetRandomString();
            var parameter2 = Extensions.GetRandomString();
            var parameter3 = Extensions.GetRandomString();

            // Case 1
            var falseActionExecuted = false;
            var trueActionExecuted = false;
            Extensions.ExecuteIfFalse(
                (p1, p2, p3) => falseActionExecuted = p1 == parameter1 && p2 == parameter2 && p3 == parameter3,
                parameter1,
                parameter2,
                parameter3,
                null,
                false,
                false);

            Assert.True(falseActionExecuted);
            Assert.False(trueActionExecuted);

            // Case 2
            // ReSharper disable once HeuristicUnreachableCode
            falseActionExecuted = false;
            Extensions.ExecuteIfFalse(
                (p1, p2, p3) => falseActionExecuted = p1 == parameter1 && p2 == parameter2 && p3 == parameter3,
                parameter1,
                parameter2,
                parameter3,
                (p1, p2, p3) => trueActionExecuted = p1 == parameter1 && p2 == parameter2 && p3 == parameter3,
                false,
                false);

            Assert.True(falseActionExecuted);
            Assert.False(trueActionExecuted);

            // Case 3
            falseActionExecuted = false;
            trueActionExecuted = false;
            Extensions.ExecuteIfFalse(
                (p1, p2, p3) => falseActionExecuted = p1 == parameter1 && p2 == parameter2 && p3 == parameter3,
                parameter1,
                parameter2,
                parameter3,
                (p1, p2, p3) => trueActionExecuted = p1 == parameter1 && p2 == parameter2 && p3 == parameter3,
                true,
                false);

            Assert.False(falseActionExecuted);
            Assert.True(trueActionExecuted);

            // Case 4
            falseActionExecuted = false;
            trueActionExecuted = false;
            Extensions.ExecuteIfFalse(
                (p1, p2, p3) => falseActionExecuted = p1 == parameter1 && p2 == parameter2 && p3 == parameter3,
                parameter1,
                parameter2,
                parameter3,
                null,
                true,
                false);

            Assert.False(falseActionExecuted);
            Assert.False(trueActionExecuted);

            // Case 5
            falseActionExecuted = false;
            trueActionExecuted = false;
            Extensions.ExecuteIfFalse(
                (p1, p2, p3) => falseActionExecuted = p1 == parameter1 && p2 == parameter2 && p3 == parameter3,
                parameter1,
                parameter2,
                parameter3,
                null,
                true,
                false);

            Assert.False(falseActionExecuted);
            Assert.False(trueActionExecuted);
        }

        [Fact]
        public void ExecuteIfFalseTest3NullCheck()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => Extensions.ExecuteIfFalse(null,
                Extensions.GetRandomString(),
                Extensions.GetRandomString(),
                Extensions.GetRandomString(),
                null,
                false,
                false);

            test.ShouldThrow<ArgumentNullException>();
        }

        [Fact]
        public void ExecuteIfFalseTest4()
        {
            var parameter1 = Extensions.GetRandomString();
            var parameter2 = Extensions.GetRandomString();
            var parameter3 = Extensions.GetRandomString();
            var parameter4 = Extensions.GetRandomString();

            // Case 1
            var falseActionExecuted = false;
            var trueActionExecuted = false;
            Extensions.ExecuteIfFalse(
                (p1, p2, p3, p4) =>
                    falseActionExecuted = p1 == parameter1 && p2 == parameter2 && p3 == parameter3 && p4 == parameter4,
                parameter1,
                parameter2,
                parameter3,
                parameter4,
                null,
                false,
                false);

            Assert.True(falseActionExecuted);
            Assert.False(trueActionExecuted);

            // Case 2
            // ReSharper disable once HeuristicUnreachableCode
            falseActionExecuted = false;
            Extensions.ExecuteIfFalse(
                (p1, p2, p3, p4) =>
                    falseActionExecuted = p1 == parameter1 && p2 == parameter2 && p3 == parameter3 && p4 == parameter4,
                parameter1,
                parameter2,
                parameter3,
                parameter4,
                (p1, p2, p3, p4) =>
                    trueActionExecuted = p1 == parameter1 && p2 == parameter2 && p3 == parameter3 && p4 == parameter4,
                false,
                false);

            Assert.True(falseActionExecuted);
            Assert.False(trueActionExecuted);

            // Case 3
            falseActionExecuted = false;
            trueActionExecuted = false;
            Extensions.ExecuteIfFalse(
                (p1, p2, p3, p4) =>
                    falseActionExecuted = p1 == parameter1 && p2 == parameter2 && p3 == parameter3 && p4 == parameter4,
                parameter1,
                parameter2,
                parameter3,
                parameter4,
                (p1, p2, p3, p4) =>
                    trueActionExecuted = p1 == parameter1 && p2 == parameter2 && p3 == parameter3 && p4 == parameter4,
                true,
                false);

            Assert.False(falseActionExecuted);
            Assert.True(trueActionExecuted);

            // Case 4
            falseActionExecuted = false;
            trueActionExecuted = false;
            Extensions.ExecuteIfFalse(
                (p1, p2, p3, p4) => falseActionExecuted =
                    p1 == parameter1 && p2 == parameter2 && p3 == parameter3 && p4 == parameter4,
                parameter1,
                parameter2,
                parameter3,
                parameter4,
                null,
                true,
                false);

            Assert.False(falseActionExecuted);
            Assert.False(trueActionExecuted);

            // Case 5
            falseActionExecuted = false;
            trueActionExecuted = false;
            Extensions.ExecuteIfFalse(
                (p1, p2, p3, p4) => falseActionExecuted =
                    p1 == parameter1 && p2 == parameter2 && p3 == parameter3 && p4 == parameter4,
                parameter1,
                parameter2,
                parameter3,
                parameter4,
                null,
                true,
                false);

            Assert.False(falseActionExecuted);
            Assert.False(trueActionExecuted);
        }

        [Fact]
        public void ExecuteIfFalseTest4NullCheck()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => Extensions.ExecuteIfFalse(null,
                Extensions.GetRandomString(),
                Extensions.GetRandomString(),
                Extensions.GetRandomString(),
                Extensions.GetRandomString(),
                null,
                false,
                false);

            test.ShouldThrow<ArgumentNullException>();
        }

        [Fact]
        public void ExecuteIfFalseTest5()
        {
            // Case 1
            var falseActionExecuted = false;
            Extensions.ExecuteIfFalse(() => falseActionExecuted = true, false, false);

            Assert.True(falseActionExecuted);

            // Case 2
            falseActionExecuted = false;
            Extensions.ExecuteIfFalse(() => falseActionExecuted = true, false, false);

            Assert.True(falseActionExecuted);

            // Case 3
            falseActionExecuted = false;
            Extensions.ExecuteIfFalse(() => falseActionExecuted = true, true, false);

            Assert.False(falseActionExecuted);

            // Case 4
            falseActionExecuted = false;
            Extensions.ExecuteIfFalse(() => falseActionExecuted = true, true, false);

            Assert.False(falseActionExecuted);

            // Case 5
            falseActionExecuted = false;
            Action action = () => { };
            action.ExecuteIfFalse(true, false);

            Assert.False(falseActionExecuted);
        }

        [Fact]
        public void ExecuteIfFalseTest5NullCheck()
        {
            Action action = null;
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => action.ExecuteIfFalse(false, false);

            test.ShouldThrow<ArgumentNullException>();
        }

        [Fact]
        public void ExecuteIfFalseTest6()
        {
            var parameter = Extensions.GetRandomString();

            // Case 1
            var falseActionExecuted = false;
            Extensions.ExecuteIfFalse(
                x => falseActionExecuted = x == parameter,
                parameter,
                false,
                false);

            Assert.True(falseActionExecuted);

            // Case 2
            falseActionExecuted = false;
            Extensions.ExecuteIfFalse(
                x => falseActionExecuted = x == parameter,
                parameter,
                false,
                false);

            Assert.True(falseActionExecuted);

            // Case 3
            falseActionExecuted = false;
            Extensions.ExecuteIfFalse(
                x => falseActionExecuted = x == parameter,
                parameter,
                true,
                false);

            Assert.False(falseActionExecuted);

            // Case 4
            falseActionExecuted = false;
            Extensions.ExecuteIfFalse(
                x => falseActionExecuted = x == parameter,
                parameter,
                true,
                false);

            Assert.False(falseActionExecuted);

            // Case 5
            falseActionExecuted = false;
            Action<String> action = x => { };
            action.ExecuteIfFalse(parameter, true, false);

            Assert.False(falseActionExecuted);
        }

        [Fact]
        public void ExecuteIfFalseTest6NullCheck()
        {
            Action<String> action = null;
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => action.ExecuteIfFalse(Extensions.GetRandomString(), false, false);

            test.ShouldThrow<ArgumentNullException>();
        }

        [Fact]
        public void ExecuteIfFalseTest7()
        {
            var parameter1 = Extensions.GetRandomString();
            var parameter2 = Extensions.GetRandomString();

            // Case 1
            var falseActionExecuted = false;
            Extensions.ExecuteIfFalse(
                (p1, p2) => falseActionExecuted = p1 == parameter1 && p2 == parameter2,
                parameter1,
                parameter2,
                false,
                false);

            Assert.True(falseActionExecuted);

            // Case 2
            falseActionExecuted = false;
            Extensions.ExecuteIfFalse(
                (p1, p2) => falseActionExecuted = p1 == parameter1 && p2 == parameter2,
                parameter1,
                parameter2,
                false,
                false);

            Assert.True(falseActionExecuted);

            // Case 3
            falseActionExecuted = false;
            Extensions.ExecuteIfFalse(
                (p1, p2) => falseActionExecuted = p1 == parameter1 && p2 == parameter2,
                parameter1,
                parameter2,
                true,
                false);

            Assert.False(falseActionExecuted);

            // Case 4
            falseActionExecuted = false;
            Extensions.ExecuteIfFalse(
                (p1, p2) => falseActionExecuted = p1 == parameter1 && p2 == parameter2,
                parameter1,
                parameter2,
                true,
                false);

            Assert.False(falseActionExecuted);

            // Case 5
            falseActionExecuted = false;
            Action<String, String> action = (x, y) => { };
            action.ExecuteIfFalse(parameter1, parameter2, true, false);

            Assert.False(falseActionExecuted);
        }

        [Fact]
        public void ExecuteIfFalseTest7NullCheck()
        {
            Action<String, String> action = null;
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () =>
                action.ExecuteIfFalse(Extensions.GetRandomString(), Extensions.GetRandomString(), null, false, false);

            test.ShouldThrow<ArgumentNullException>();
        }

        [Fact]
        public void ExecuteIfFalseTest8()
        {
            var parameter1 = Extensions.GetRandomString();
            var parameter2 = Extensions.GetRandomString();
            var parameter3 = Extensions.GetRandomString();

            // Case 1
            var falseActionExecuted = false;
            Extensions.ExecuteIfFalse(
                (p1, p2, p3) => falseActionExecuted = p1 == parameter1 && p2 == parameter2 && p3 == parameter3,
                parameter1,
                parameter2,
                parameter3,
                false,
                false);

            Assert.True(falseActionExecuted);

            // Case 2
            falseActionExecuted = false;
            Extensions.ExecuteIfFalse(
                (p1, p2, p3) => falseActionExecuted = p1 == parameter1 && p2 == parameter2 && p3 == parameter3,
                parameter1,
                parameter2,
                parameter3,
                false,
                false);

            Assert.True(falseActionExecuted);

            // Case 3
            falseActionExecuted = false;
            Extensions.ExecuteIfFalse(
                (p1, p2, p3) => falseActionExecuted = p1 == parameter1 && p2 == parameter2 && p3 == parameter3,
                parameter1,
                parameter2,
                parameter3,
                true,
                false);

            Assert.False(falseActionExecuted);

            // Case 4
            falseActionExecuted = false;
            Extensions.ExecuteIfFalse(
                (p1, p2, p3) => falseActionExecuted = p1 == parameter1 && p2 == parameter2 && p3 == parameter3,
                parameter1,
                parameter2,
                parameter3,
                true,
                false);

            Assert.False(falseActionExecuted);

            // Case 5
            falseActionExecuted = false;
            Action<String, String, String> action = (p1, p2, p3) =>
                falseActionExecuted = p1 == parameter1 && p2 == parameter2 && p3 == parameter3;
            action.ExecuteIfFalse(parameter1, parameter2, parameter3, true, false);

            Assert.False(falseActionExecuted);
        }

        [Fact]
        public void ExecuteIfFalseTest8NullCheck()
        {
            Action<String, String, String> action = null;
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => action.ExecuteIfFalse(Extensions.GetRandomString(),
                Extensions.GetRandomString(),
                Extensions.GetRandomString(),
                null,
                false,
                false);

            test.ShouldThrow<ArgumentNullException>();
        }

        [Fact]
        public void ExecuteIfFalseTest9()
        {
            var parameter1 = Extensions.GetRandomString();
            var parameter2 = Extensions.GetRandomString();
            var parameter3 = Extensions.GetRandomString();
            var parameter4 = Extensions.GetRandomString();

            // Case 1
            var falseActionExecuted = false;
            Extensions.ExecuteIfFalse(
                (p1, p2, p3, p4) =>
                    falseActionExecuted = p1 == parameter1 && p2 == parameter2 && p3 == parameter3 && p4 == parameter4,
                parameter1,
                parameter2,
                parameter3,
                parameter4,
                false,
                false);

            Assert.True(falseActionExecuted);

            // Case 2
            falseActionExecuted = false;
            Extensions.ExecuteIfFalse(
                (p1, p2, p3, p4) =>
                    falseActionExecuted = p1 == parameter1 && p2 == parameter2 && p3 == parameter3 && p4 == parameter4,
                parameter1,
                parameter2,
                parameter3,
                parameter4,
                false,
                false);

            Assert.True(falseActionExecuted);

            // Case 3
            falseActionExecuted = false;
            Extensions.ExecuteIfFalse(
                (p1, p2, p3, p4) =>
                    falseActionExecuted = p1 == parameter1 && p2 == parameter2 && p3 == parameter3 && p4 == parameter4,
                parameter1,
                parameter2,
                parameter3,
                parameter4,
                true,
                false);

            Assert.False(falseActionExecuted);

            // Case 4
            falseActionExecuted = false;
            Extensions.ExecuteIfFalse(
                (p1, p2, p3, p4) =>
                    falseActionExecuted = p1 == parameter1 && p2 == parameter2 && p3 == parameter3 && p4 == parameter4,
                parameter1,
                parameter2,
                parameter3,
                parameter4,
                true,
                false);

            Assert.False(falseActionExecuted);

            // Case 5
            falseActionExecuted = false;
            Action<String, String, String, String> action = (p1, p2, p3, p4) =>
                falseActionExecuted = p1 == parameter1 && p2 == parameter2 && p3 == parameter3 && p4 == parameter4;
            action.ExecuteIfFalse(parameter1, parameter2, parameter3, parameter4, true, false);

            Assert.False(falseActionExecuted);
        }

        [Fact]
        public void ExecuteIfFalseTest9NullCheck()
        {
            Action<String, String, String, String> action = null;
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => action.ExecuteIfFalse(Extensions.GetRandomString(),
                Extensions.GetRandomString(),
                Extensions.GetRandomString(),
                Extensions.GetRandomString(),
                null,
                false,
                false);

            test.ShouldThrow<ArgumentNullException>();
        }

        [Fact]
        public void ExecuteIfFalseTestNullCheck()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => Extensions.ExecuteIfFalse(null, null, false, false);

            test.ShouldThrow<ArgumentNullException>();
        }
    }
}