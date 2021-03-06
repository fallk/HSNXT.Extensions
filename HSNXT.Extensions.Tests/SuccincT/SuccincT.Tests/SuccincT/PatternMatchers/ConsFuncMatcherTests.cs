﻿using NUnit.Framework;
using HSNXT.SuccincT.PatternMatchers;
using System.Collections.Generic;
using System.Linq;
using static NUnit.Framework.Assert;

namespace HSNXT.SuccincTTests.SuccincT.PatternMatchers
{
    [TestFixture]
    public class ConsFuncMatcherTests
    {
        [Test]
        public void EmptyList_CanBeMatchedWithEmpty()
        {
            var list = new List<int>();
            var result = list.Match().To<int>()
                .Empty().Do(0)
                .Single().Do(1)
                .Result();
            AreEqual(0, result);
        }

        [Test]
        public void EmptyList_ThrowsExceptionWhenNoEmptyClauseSupplied()
        {
            var list = new List<int>();
            Throws<NoMatchException>(() => list.Match().To<int>()
                .Single().Do(0)
                .Cons().Do(1)
                .Result());
        }

        [Test]
        public void SingleItemList_CanBeMatchedWithSingle()
        {
            var list = new List<int> {1};
            var result = list.Match().To<bool>()
                .Empty().Do(false)
                .Single().Do(true)
                .Result();
            IsTrue(result);
        }

        [Test]
        public void SingleItemList_CanBeMatchedWithSingleWithResultViaLambda()
        {
            var list = new List<int> {1};
            var result = list.Match().To<bool>()
                .Empty().Do(false)
                .Single().Do(x => x == 1)
                .Result();
            IsTrue(result);
        }

        [Test]
        public void SingleItemList_CanBeMatchedWithWhere()
        {
            var list = new List<int> {1};
            var result = list.Match().To<bool>()
                .Single().Where(x => x == 1).Do(true)
                .Single().Do(false)
                .Result();
            IsTrue(result);
        }

        [Test]
        public void SingleItemList_CanBeMatchedWithWhereWithResultViaLambda()
        {
            var list = new List<int> {1};
            var result = list.Match().To<bool>()
                .Single().Where(x => x == 1).Do(x => x == 1)
                .Single().Do(false)
                .Result();
            IsTrue(result);
        }

        [Test]
        public void SingleItemList_CanBeMatchedWhenWhereDoesntMatch()
        {
            var list = new List<int> {0};
            var result = list.Match().To<bool>()
                .Single().Where(x => x == 1).Do(true)
                .Single().Do(false)
                .Result();
            IsFalse(result);
        }

        [Test]
        public void SingleItemList_ThrowsExceptionWhenNoSingleClauseSupplied()
        {
            var list = new List<int> {1};
            Throws<NoMatchException>(() => list.Match().To<int>()
                .Empty().Do(0)
                .Cons().Do(1)
                .Result());
        }

        [Test]
        public void SingleItemList_ThrowsExceptionWhenNoSingleClauseMatches()
        {
            var list = new List<int> {1};
            Throws<NoMatchException>(() => list.Match().To<int>()
                .Single().Where(x => x == 0).Do(0)
                .Result());
        }

        [Test]
        public void TwoItemList_CanBeMatchedWithCons()
        {
            var list = new List<int> {1, 2};
            var result = list.Match().To<int>()
                .Cons().Do((h, t) => h + t.First())
                .Result();
            AreEqual(3, result);
        }

        [Test]
        public void TwoItemList_CanBeMatchedWithConsUsingValue()
        {
            var list = new List<int> {1, 2};
            var result = list.Match().To<bool>()
                .Empty().Do(false)
                .Single().Do(false)
                .Cons().Do(true)
                .Result();
            IsTrue(result);
        }

        [Test]
        public void MultiItemList_CanBeMatchedWithConsWithWhere()
        {
            var list = new List<int> {1, 2, 3, 4};
            var result = list.Match().To<int>()
                .Cons().Where((h, t) => t.Count() == 3).Do((x, y) => 1)
                .Cons().Do(2)
                .Result();
            AreEqual(1, result);
        }

        [Test]
        public void MultiItemList_CanBeMatchedWithConsWithWhereUsingValue()
        {
            var list = new List<int> {1, 2, 3, 4};
            var result = list.Match().To<int>()
                .Cons().Where((h, t) => t.Count() == 3).Do(1)
                .Cons().Do(2)
                .Result();
            AreEqual(1, result);
        }

        [Test]
        public void MultiItemList_ThrowsExceptionWhenNoConsClauseSupplied()
        {
            var list = new List<int> {1, 2, 3};
            Throws<NoMatchException>(() => list.Match().To<int>()
                .Empty().Do(0)
                .Single().Do(1)
                .Result());
        }

        [Test]
        public void MultiItemList_ThrowsExceptionWhenNoConsClauseMatches()
        {
            var list = new List<int> {1, 2, 3};
            Throws<NoMatchException>(() => list.Match().To<int>()
                .Cons().Where((x, y) => x == 0).Do(0)
                .Result());
        }

        [Test]
        public void MultiItemList_CanBeRecursivelyMatchedToCalculateLength()
        {
            var list = new List<int> {1, 2, 3, 4};
            var result = list.Match().To<int>()
                .RecursiveCons().Do((_, count) => count + 1)
                .Result();
            AreEqual(4, result);
        }

        [Test]
        public void MultiItemList_CanBeRecursivelyMatchedWithSingle()
        {
            var list = new List<int> {1, 2, 3, 4};
            var result = list.Match().To<int>()
                .Single().Do(x => x)
                .RecursiveCons().Do((item, soFar) => soFar + item)
                .Result();
            AreEqual(10, result);
        }

        [Test]
        public void MultiItemList_CanBeRecursivelyMatchedWithEmpty()
        {
            var list = new List<int> {1, 2, 3, 4};
            var result = list.Match().To<int>()
                .Empty().Do(10)
                .RecursiveCons().Do((item, soFar) => soFar + item)
                .Result();
            AreEqual(20, result);
        }

        [Test]
        public void MultiItemEnumeration_CanBeRecursivelyMatchedUsingWhere()
        {
            var list = StringEnumeration();
            var result = list.Match().To<string>()
                .Single().Do(x => x)
                .RecursiveCons().Where(x => x == "z").Do((item, soFar) => soFar + "a")
                .RecursiveCons().Where(x => x == "y").Do((item, soFar) => soFar + "b")
                .RecursiveCons().Where(x => x == "x").Do((item, soFar) => soFar + "c")
                .Result();
            AreEqual("zbc", result);
        }

        [Test]
        public void MultiItemList_CanBeRecursivelyMatchedUsingWhere()
        {
            var list = new List<string> {"a", "b", "c"};
            var result = list.Match().To<string>()
                .Single().Do(x => x)
                .RecursiveCons().Where(x => x == "a").Do((item, soFar) => soFar + "z")
                .RecursiveCons().Where(x => x == "b").Do("i")
                .RecursiveCons().Where(x => x == "c").Do((item, soFar) => soFar + "x")
                .Result();
            AreEqual("iz", result);
        }

        [Test]
        public void MultiItemIList_CanBeRecursivelyMatchedUsingWhere()
        {
            var list = StringList();
            var result = list.Match().To<string>()
                .Single().Do(x => "w")
                .RecursiveCons().Where(x => x == "a").Do((item, soFar) => soFar + "z")
                .RecursiveCons().Where(x => x == "b").Do((item, soFar) => soFar + "y")
                .RecursiveCons().Where(x => x == "c").Do((item, soFar) => soFar + "x")
                .Result();
            AreEqual("wxyz", result);
        }

        [Test]
        public void EmptyEnumeration_ThrowsWhenRecursivelyMatched()
        {
            var list = new List<int>();
            Throws<NoMatchException>(() => list.Match().To<int>()
                .RecursiveCons().Do((x, y) => 0)
                .Result());
        }

        private static IEnumerable<string> StringEnumeration()
        {
            yield return "x";
            yield return "y";
            yield return "z";
        }

        private static IList<string> StringList() => new List<string> {"a", "b", "c", "d"};
    }
}