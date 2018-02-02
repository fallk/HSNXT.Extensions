/*
 Copyright (c) 2003-2017 Niels Kokholm, Peter Sestoft, and Rasmus Lystrøm
 Permission is hereby granted, free of charge, to any person obtaining a copy
 of this software and associated documentation files (the "Software"), to deal
 in the Software without restriction, including without limitation the rights
 to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 copies of the Software, and to permit persons to whom the Software is
 furnished to do so, subject to the following conditions:
 
 The above copyright notice and this permission notice shall be included in
 all copies or substantial portions of the Software.
 
 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 SOFTWARE.
*/

using System;
using HSNXT.C5;
using NUnit.Framework;
using SCG = System.Collections.Generic;

namespace HSNXT.C5UnitTests.arrays.sorted
{
    using CollectionOfInt = SortedArray<int>;

    [TestFixture(MemoryType.Normal)]
    [TestFixture(MemoryType.Strict)]
    [TestFixture(MemoryType.Safe)]
    public class GenericTesters : BaseMemoryType
    {
        [Test]
        public void TestEvents()
        {
            Func<CollectionOfInt> factory = delegate() { return new CollectionOfInt(TenEqualityComparer.Default); };
            new C5UnitTests.Templates.Events.SortedIndexedTester<CollectionOfInt>().Test(factory, MemoryType);
        }

        //[Test]
        //public void Extensible()
        //{
        //    C5UnitTests.Templates.Extensible.Clone.Tester<CollectionOfInt>();
        //    C5UnitTests.Templates.Extensible.Serialization.Tester<CollectionOfInt>();
        //}
        public GenericTesters(MemoryType memoryType)
            : base(memoryType)
        {
        }
    }

    static class Factory
    {
        public static ICollection<T> New<T>(MemoryType memoryType)
        {
            return new SortedArray<T>(memoryType);
        }
    }


    [TestFixture(MemoryType.Normal)]
    [TestFixture(MemoryType.Strict)]
    [TestFixture(MemoryType.Safe)]
    public class Formatting : BaseMemoryType
    {
        ICollection<int> coll;
        IFormatProvider rad16;

        [SetUp]
        public void Init()
        {
            coll = Factory.New<int>(MemoryType);
            rad16 = new RadixFormatProvider(16);
        }

        [TearDown]
        public void Dispose()
        {
            coll = null;
            rad16 = null;
        }

        [Test]
        public void Format()
        {
            Assert.AreEqual("{  }", coll.ToString());
            coll.AddAll(new int[] {-4, 28, 129, 65530});
            Assert.AreEqual("{ -4, 28, 129, 65530 }", coll.ToString());
            Assert.AreEqual("{ -4, 1C, 81, FFFA }", coll.ToString(null, rad16));
            Assert.AreEqual("{ -4, 28, 129... }", coll.ToString("L14", null));
            Assert.AreEqual("{ -4, 1C, 81... }", coll.ToString("L14", rad16));
        }

        public Formatting(MemoryType memoryType)
            : base(memoryType)
        {
        }
    }

    [TestFixture(MemoryType.Normal)]
    [TestFixture(MemoryType.Strict)]
    [TestFixture(MemoryType.Safe)]
    public class Ranges : BaseMemoryType
    {
        private SortedArray<int> array;

        private SCG.IComparer<int> c;


        [SetUp]
        public void Init()
        {
            c = new IC();
            array = new SortedArray<int>(c, MemoryType);
            for (var i = 1; i <= 10; i++)
            {
                array.Add(i * 2);
            }
        }


        [Test]
        public void Enumerator()
        {
            var e = array.RangeFromTo(5, 17).GetEnumerator();
            var i = 3;

            while (e.MoveNext())
            {
                Assert.AreEqual(2 * i++, e.Current);
            }

            Assert.AreEqual(9, i);
        }


        [Test]
        public void Enumerator3()
        {
            var e = array.RangeFromTo(5, 17).GetEnumerator();

            e.MoveNext();
            array.Add(67);

            Assert.Throws<CollectionModifiedException>(() => e.MoveNext());
        }


        [Test]
        public void Remove()
        {
            var all = new int[] {2, 4, 6, 8, 10, 12, 14, 16, 18, 20};

            array.RemoveRangeFrom(18);
            Assert.IsTrue(IC.eq(array, new int[] {2, 4, 6, 8, 10, 12, 14, 16}));
            array.RemoveRangeFrom(28);
            Assert.IsTrue(IC.eq(array, new int[] {2, 4, 6, 8, 10, 12, 14, 16}));
            array.RemoveRangeFrom(13);
            Assert.IsTrue(IC.eq(array, new int[] {2, 4, 6, 8, 10, 12}));
            array.RemoveRangeFrom(2);
            Assert.IsTrue(IC.eq(array));
            foreach (var i in all) array.Add(i);

            array.RemoveRangeTo(10);
            Assert.IsTrue(IC.eq(array, new int[] {10, 12, 14, 16, 18, 20}));
            array.RemoveRangeTo(2);
            Assert.IsTrue(IC.eq(array, new int[] {10, 12, 14, 16, 18, 20}));
            array.RemoveRangeTo(21);
            Assert.IsTrue(IC.eq(array));
            foreach (var i in all) array.Add(i);

            array.RemoveRangeFromTo(4, 8);
            Assert.IsTrue(IC.eq(array, 2, 8, 10, 12, 14, 16, 18, 20));
            array.RemoveRangeFromTo(14, 28);
            Assert.IsTrue(IC.eq(array, 2, 8, 10, 12));
            array.RemoveRangeFromTo(0, 9);
            Assert.IsTrue(IC.eq(array, 10, 12));
            array.RemoveRangeFromTo(0, 81);
            Assert.IsTrue(IC.eq(array));
        }

        [Test]
        public void Normal()
        {
            var all = new int[] {2, 4, 6, 8, 10, 12, 14, 16, 18, 20};

            Assert.IsTrue(IC.eq(array, all));
            Assert.IsTrue(IC.eq(array.RangeAll(), all));
            Assert.AreEqual(10, array.RangeAll().Count);
            Assert.IsTrue(IC.eq(array.RangeFrom(11), new int[] {12, 14, 16, 18, 20}));
            Assert.AreEqual(5, array.RangeFrom(11).Count);
            Assert.IsTrue(IC.eq(array.RangeFrom(12), new int[] {12, 14, 16, 18, 20}));
            Assert.IsTrue(IC.eq(array.RangeFrom(2), all));
            Assert.IsTrue(IC.eq(array.RangeFrom(1), all));
            Assert.IsTrue(IC.eq(array.RangeFrom(21), new int[] { }));
            Assert.IsTrue(IC.eq(array.RangeFrom(20), new int[] {20}));
            Assert.IsTrue(IC.eq(array.RangeTo(8), new int[] {2, 4, 6}));
            Assert.IsTrue(IC.eq(array.RangeTo(7), new int[] {2, 4, 6}));
            Assert.AreEqual(3, array.RangeTo(7).Count);
            Assert.IsTrue(IC.eq(array.RangeTo(2), new int[] { }));
            Assert.IsTrue(IC.eq(array.RangeTo(1), new int[] { }));
            Assert.IsTrue(IC.eq(array.RangeTo(3), new int[] {2}));
            Assert.IsTrue(IC.eq(array.RangeTo(20), new int[] {2, 4, 6, 8, 10, 12, 14, 16, 18}));
            Assert.IsTrue(IC.eq(array.RangeTo(21), all));
            Assert.IsTrue(IC.eq(array.RangeFromTo(7, 12), new int[] {8, 10}));
            Assert.IsTrue(IC.eq(array.RangeFromTo(6, 11), new int[] {6, 8, 10}));
            Assert.IsTrue(IC.eq(array.RangeFromTo(1, 12), new int[] {2, 4, 6, 8, 10}));
            Assert.AreEqual(5, array.RangeFromTo(1, 12).Count);
            Assert.IsTrue(IC.eq(array.RangeFromTo(2, 12), new int[] {2, 4, 6, 8, 10}));
            Assert.IsTrue(IC.eq(array.RangeFromTo(6, 21), new int[] {6, 8, 10, 12, 14, 16, 18, 20}));
            Assert.IsTrue(IC.eq(array.RangeFromTo(6, 20), new int[] {6, 8, 10, 12, 14, 16, 18}));
        }


        [Test]
        public void Backwards()
        {
            var all = new int[] {2, 4, 6, 8, 10, 12, 14, 16, 18, 20};
            var lla = new int[] {20, 18, 16, 14, 12, 10, 8, 6, 4, 2};

            Assert.IsTrue(IC.eq(array, all));
            Assert.IsTrue(IC.eq(array.RangeAll().Backwards(), lla));
            Assert.IsTrue(IC.eq(array.RangeFrom(11).Backwards(), new int[] {20, 18, 16, 14, 12}));
            Assert.IsTrue(IC.eq(array.RangeFrom(12).Backwards(), new int[] {20, 18, 16, 14, 12}));
            Assert.IsTrue(IC.eq(array.RangeFrom(2).Backwards(), lla));
            Assert.IsTrue(IC.eq(array.RangeFrom(1).Backwards(), lla));
            Assert.IsTrue(IC.eq(array.RangeFrom(21).Backwards(), new int[] { }));
            Assert.IsTrue(IC.eq(array.RangeFrom(20).Backwards(), new int[] {20}));
            Assert.IsTrue(IC.eq(array.RangeTo(8).Backwards(), new int[] {6, 4, 2}));
            Assert.IsTrue(IC.eq(array.RangeTo(7).Backwards(), new int[] {6, 4, 2}));
            Assert.IsTrue(IC.eq(array.RangeTo(2).Backwards(), new int[] { }));
            Assert.IsTrue(IC.eq(array.RangeTo(1).Backwards(), new int[] { }));
            Assert.IsTrue(IC.eq(array.RangeTo(3).Backwards(), new int[] {2}));
            Assert.IsTrue(IC.eq(array.RangeTo(20).Backwards(), new int[] {18, 16, 14, 12, 10, 8, 6, 4, 2}));
            Assert.IsTrue(IC.eq(array.RangeTo(21).Backwards(), lla));
            Assert.IsTrue(IC.eq(array.RangeFromTo(7, 12).Backwards(), new int[] {10, 8}));
            Assert.IsTrue(IC.eq(array.RangeFromTo(6, 11).Backwards(), new int[] {10, 8, 6}));
            Assert.IsTrue(IC.eq(array.RangeFromTo(1, 12).Backwards(), new int[] {10, 8, 6, 4, 2}));
            Assert.IsTrue(IC.eq(array.RangeFromTo(2, 12).Backwards(), new int[] {10, 8, 6, 4, 2}));
            Assert.IsTrue(IC.eq(array.RangeFromTo(6, 21).Backwards(), new int[] {20, 18, 16, 14, 12, 10, 8, 6}));
            Assert.IsTrue(IC.eq(array.RangeFromTo(6, 20).Backwards(), new int[] {18, 16, 14, 12, 10, 8, 6}));
        }

        [Test]
        public void Direction()
        {
            Assert.AreEqual(EnumerationDirection.Forwards, array.Direction);
            Assert.AreEqual(EnumerationDirection.Forwards, array.RangeFrom(20).Direction);
            Assert.AreEqual(EnumerationDirection.Forwards, array.RangeTo(7).Direction);
            Assert.AreEqual(EnumerationDirection.Forwards, array.RangeFromTo(1, 12).Direction);
            Assert.AreEqual(EnumerationDirection.Forwards, array.RangeAll().Direction);
            Assert.AreEqual(EnumerationDirection.Backwards, array.Backwards().Direction);
            Assert.AreEqual(EnumerationDirection.Backwards, array.RangeFrom(20).Backwards().Direction);
            Assert.AreEqual(EnumerationDirection.Backwards, array.RangeTo(7).Backwards().Direction);
            Assert.AreEqual(EnumerationDirection.Backwards, array.RangeFromTo(1, 12).Backwards().Direction);
            Assert.AreEqual(EnumerationDirection.Backwards, array.RangeAll().Backwards().Direction);
        }


        [TearDown]
        public void Dispose()
        {
            array = null;
            c = null;
        }

        public Ranges(MemoryType memoryType)
            : base(memoryType)
        {
        }
    }

    [TestFixture(MemoryType.Normal)]
    [TestFixture(MemoryType.Strict)]
    [TestFixture(MemoryType.Safe)]
    public class BagItf : BaseMemoryType
    {
        private SortedArray<int> array;


        [SetUp]
        public void Init()
        {
            array = new SortedArray<int>(new IC(), MemoryType);
            for (var i = 10; i < 20; i++)
            {
                array.Add(i);
                array.Add(i + 10);
            }
        }


        [Test]
        public void Both()
        {
            Assert.AreEqual(0, array.ContainsCount(7));
            Assert.AreEqual(1, array.ContainsCount(10));
            array.RemoveAllCopies(10);
            Assert.AreEqual(0, array.ContainsCount(10));
            array.RemoveAllCopies(7);
        }


        [TearDown]
        public void Dispose()
        {
            array = null;
        }

        public BagItf(MemoryType memoryType)
            : base(memoryType)
        {
        }
    }


    [TestFixture(MemoryType.Normal)]
    [TestFixture(MemoryType.Strict)]
    [TestFixture(MemoryType.Safe)]
    public class Div : BaseMemoryType
    {
        private SortedArray<int> array;


        [SetUp]
        public void Init()
        {
            array = new SortedArray<int>(new IC(), MemoryType);
        }

        [Test]
        public void NullEqualityComparerinConstructor1()
        {
            Assert.Throws<NullReferenceException>(() => new SortedArray<int>(null, MemoryType));
        }

        [Test]
        public void NullEqualityComparerinConstructor2()
        {
            Assert.Throws<NullReferenceException>(() => new SortedArray<int>(5, null, MemoryType));
        }

        [Test]
        public void NullEqualityComparerinConstructor3()
        {
            Assert.Throws<NullReferenceException>(() =>
                new SortedArray<int>(5, null, EqualityComparer<int>.Default, MemoryType));
        }

        [Test]
        public void NullEqualityComparerinConstructor4()
        {
            Assert.Throws<NullReferenceException>(() =>
                new SortedArray<int>(5, SCG.Comparer<int>.Default, null, MemoryType));
        }

        [Test]
        public void NullEqualityComparerinConstructor5()
        {
            Assert.Throws<NullReferenceException>(() => new SortedArray<int>(5, null, null, MemoryType));
        }

        [Test]
        public void Choose()
        {
            array.Add(7);
            Assert.AreEqual(7, array.Choose());
        }

        [Test]
        public void BadChoose()
        {
            Assert.Throws<NoSuchItemException>(() => array.Choose());
        }

        private void loadup()
        {
            for (var i = 10; i < 20; i++)
            {
                array.Add(i);
                array.Add(i + 10);
            }
        }


        [Test]
        public void NoDuplicatesEtc()
        {
            Assert.IsFalse(array.AllowsDuplicates);
            loadup();
            Assert.IsFalse(array.AllowsDuplicates);
            Assert.AreEqual(Speed.Log, array.ContainsSpeed);
            Assert.IsTrue(array.Comparer.Compare(2, 3) < 0);
            Assert.IsTrue(array.Comparer.Compare(4, 3) > 0);
            Assert.IsTrue(array.Comparer.Compare(3, 3) == 0);
        }

        [Test]
        public void Add()
        {
            Assert.IsTrue(array.Add(17));
            Assert.IsFalse(array.Add(17));
            Assert.IsTrue(array.Add(18));
            Assert.IsFalse(array.Add(18));
            Assert.AreEqual(2, array.Count);
        }


        [TearDown]
        public void Dispose()
        {
            array = null;
        }

        public Div(MemoryType memoryType)
            : base(memoryType)
        {
        }
    }


    [TestFixture(MemoryType.Normal)]
    [TestFixture(MemoryType.Strict)]
    [TestFixture(MemoryType.Safe)]
    public class FindOrAdd : BaseMemoryType
    {
        private SortedArray<KeyValuePair<int, string>> bag;


        [SetUp]
        public void Init()
        {
            bag = new SortedArray<KeyValuePair<int, string>>(new KeyValuePairComparer<int, string>(new IC()),
                MemoryType);
        }


        [TearDown]
        public void Dispose()
        {
            bag = null;
        }


        [Test]
        public void Test()
        {
            var p = new KeyValuePair<int, string>(3, "tre");

            Assert.IsFalse(bag.FindOrAdd(ref p));
            p.Value = "drei";
            Assert.IsTrue(bag.FindOrAdd(ref p));
            Assert.AreEqual("tre", p.Value);
            p.Value = "three";
            Assert.AreEqual(1, bag.ContainsCount(p));
            Assert.AreEqual("tre", bag[0].Value);
        }

        public FindOrAdd(MemoryType memoryType)
            : base(memoryType)
        {
        }
    }


    [TestFixture(MemoryType.Normal)]
    [TestFixture(MemoryType.Strict)]
    [TestFixture(MemoryType.Safe)]
    public class FindPredicate : BaseMemoryType
    {
        private SortedArray<int> list;
        Func<int, bool> pred;

        [SetUp]
        public void Init()
        {
            list = new SortedArray<int>(TenEqualityComparer.Default, MemoryType);
            pred = delegate(int i) { return i % 5 == 0; };
        }

        [TearDown]
        public void Dispose()
        {
            list = null;
        }

        [Test]
        public void Find()
        {
            int i;
            Assert.IsFalse(list.Find(pred, out i));
            list.AddAll(new int[] {4, 22, 67, 37});
            Assert.IsFalse(list.Find(pred, out i));
            list.AddAll(new int[] {45, 122, 675, 137});
            Assert.IsTrue(list.Find(pred, out i));
            Assert.AreEqual(45, i);
        }

        [Test]
        public void FindLast()
        {
            int i;
            Assert.IsFalse(list.FindLast(pred, out i));
            list.AddAll(new int[] {4, 22, 67, 37});
            Assert.IsFalse(list.FindLast(pred, out i));
            list.AddAll(new int[] {45, 122, 675, 137});
            Assert.IsTrue(list.FindLast(pred, out i));
            Assert.AreEqual(675, i);
        }

        [Test]
        public void FindIndex()
        {
            Assert.IsFalse(0 <= list.FindIndex(pred));
            list.AddAll(new int[] {4, 22, 67, 37});
            Assert.IsFalse(0 <= list.FindIndex(pred));
            list.AddAll(new int[] {45, 122, 675, 137});
            Assert.AreEqual(3, list.FindIndex(pred));
        }

        [Test]
        public void FindLastIndex()
        {
            Assert.IsFalse(0 <= list.FindLastIndex(pred));
            list.AddAll(new int[] {4, 22, 67, 37});
            Assert.IsFalse(0 <= list.FindLastIndex(pred));
            list.AddAll(new int[] {45, 122, 675, 137});
            Assert.AreEqual(7, list.FindLastIndex(pred));
        }

        public FindPredicate(MemoryType memoryType)
            : base(memoryType)
        {
        }
    }

    [TestFixture(MemoryType.Normal)]
    [TestFixture(MemoryType.Strict)]
    [TestFixture(MemoryType.Safe)]
    public class UniqueItems : BaseMemoryType
    {
        private SortedArray<int> list;

        [SetUp]
        public void Init()
        {
            list = new SortedArray<int>(MemoryType);
        }

        [TearDown]
        public void Dispose()
        {
            list = null;
        }

        [Test]
        public void Test()
        {
            Assert.IsTrue(IC.seteq(list.UniqueItems()));
            Assert.IsTrue(IC.seteq(list.ItemMultiplicities()));
            list.AddAll(new int[] {7, 9, 7});
            Assert.IsTrue(IC.seteq(list.UniqueItems(), 7, 9));
            Assert.IsTrue(IC.seteq(list.ItemMultiplicities(), 7, 1, 9, 1));
        }

        public UniqueItems(MemoryType memoryType)
            : base(memoryType)
        {
        }
    }

    [TestFixture(MemoryType.Normal)]
    [TestFixture(MemoryType.Strict)]
    [TestFixture(MemoryType.Safe)]
    public class ArrayTest : BaseMemoryType
    {
        private SortedArray<int> tree;

        int[] a;


        [SetUp]
        public void Init()
        {
            tree = new SortedArray<int>(new IC(), MemoryType);
            a = new int[10];
            for (var i = 0; i < 10; i++)
                a[i] = 1000 + i;
        }


        [TearDown]
        public void Dispose()
        {
            tree = null;
        }


        private string aeq(int[] a, params int[] b)
        {
            if (a.Length != b.Length)
                return "Lengths differ: " + a.Length + " != " + b.Length;

            for (var i = 0; i < a.Length; i++)
                if (a[i] != b[i])
                    return string.Format("{0}'th elements differ: {1} != {2}", i, a[i], b[i]);

            return "Alles klar";
        }


        [Test]
        public void ToArray()
        {
            Assert.AreEqual("Alles klar", aeq(tree.ToArray()));
            tree.Add(7);
            tree.Add(4);
            Assert.AreEqual("Alles klar", aeq(tree.ToArray(), 4, 7));
        }


        [Test]
        public void CopyTo()
        {
            tree.CopyTo(a, 1);
            Assert.AreEqual("Alles klar", aeq(a, 1000, 1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009));
            tree.Add(6);
            tree.CopyTo(a, 2);
            Assert.AreEqual("Alles klar", aeq(a, 1000, 1001, 6, 1003, 1004, 1005, 1006, 1007, 1008, 1009));
            tree.Add(4);
            tree.Add(9);
            tree.CopyTo(a, 4);
            Assert.AreEqual("Alles klar", aeq(a, 1000, 1001, 6, 1003, 4, 6, 9, 1007, 1008, 1009));
            tree.Clear();
            tree.Add(7);
            tree.CopyTo(a, 9);
            Assert.AreEqual("Alles klar", aeq(a, 1000, 1001, 6, 1003, 4, 6, 9, 1007, 1008, 7));
        }


        [Test]
        public void CopyToBad()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => tree.CopyTo(a, 11));
        }


        [Test]
        public void CopyToBad2()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => tree.CopyTo(a, -1));
        }


        [Test]
        public void CopyToTooFar()
        {
            tree.Add(3);
            tree.Add(4);
            Assert.Throws<ArgumentOutOfRangeException>(() => tree.CopyTo(a, 9));
        }

        public ArrayTest(MemoryType memoryType)
            : base(memoryType)
        {
        }
    }


    [TestFixture(MemoryType.Normal)]
    [TestFixture(MemoryType.Strict)]
    [TestFixture(MemoryType.Safe)]
    public class Combined : BaseMemoryType
    {
        private IIndexedSorted<KeyValuePair<int, int>> lst;


        [SetUp]
        public void Init()
        {
            lst = new SortedArray<KeyValuePair<int, int>>(new KeyValuePairComparer<int, int>(new IC()), MemoryType);
            for (var i = 0; i < 10; i++)
            {
                lst.Add(new KeyValuePair<int, int>(i, i + 30));
            }
        }

        [TearDown]
        public void Dispose()
        {
            lst = null;
        }


        [Test]
        public void Find()
        {
            var p = new KeyValuePair<int, int>(3, 78);

            Assert.IsTrue(lst.Find(ref p));
            Assert.AreEqual(3, p.Key);
            Assert.AreEqual(33, p.Value);
            p = new KeyValuePair<int, int>(13, 78);
            Assert.IsFalse(lst.Find(ref p));
        }


        [Test]
        public void FindOrAdd()
        {
            var p = new KeyValuePair<int, int>(3, 78);

            Assert.IsTrue(lst.FindOrAdd(ref p));
            Assert.AreEqual(3, p.Key);
            Assert.AreEqual(33, p.Value);
            p = new KeyValuePair<int, int>(13, 79);
            Assert.IsFalse(lst.FindOrAdd(ref p));
            Assert.AreEqual(13, lst[10].Key);
            Assert.AreEqual(79, lst[10].Value);
        }


        [Test]
        public void Update()
        {
            var p = new KeyValuePair<int, int>(3, 78);

            Assert.IsTrue(lst.Update(p));
            Assert.AreEqual(3, lst[3].Key);
            Assert.AreEqual(78, lst[3].Value);
            p = new KeyValuePair<int, int>(13, 78);
            Assert.IsFalse(lst.Update(p));
        }


        [Test]
        public void UpdateOrAdd1()
        {
            var p = new KeyValuePair<int, int>(3, 78);

            Assert.IsTrue(lst.UpdateOrAdd(p));
            Assert.AreEqual(3, lst[3].Key);
            Assert.AreEqual(78, lst[3].Value);
            p = new KeyValuePair<int, int>(13, 79);
            Assert.IsFalse(lst.UpdateOrAdd(p));
            Assert.AreEqual(13, lst[10].Key);
            Assert.AreEqual(79, lst[10].Value);
        }

        [Test]
        public void UpdateOrAdd2()
        {
            ICollection<String> coll = new SortedArray<String>();
            // s1 and s2 are distinct objects but contain the same text:
            String old, s1 = "abc", s2 = ("def" + s1).Substring(3);
            Assert.IsFalse(coll.UpdateOrAdd(s1, out old));
            Assert.AreEqual(null, old);
            Assert.IsTrue(coll.UpdateOrAdd(s2, out old));
            Assert.IsTrue(Object.ReferenceEquals(s1, old));
            Assert.IsFalse(Object.ReferenceEquals(s2, old));
        }

        [Test]
        public void UpdateOrAddWithExpand()
        {
            // bug20071217
            var arr = new SortedArray<double>();
            for (var i = 0; i < 50; i++)
            {
                arr.UpdateOrAdd(i + 0.1);
                arr.Add(i + 0.2);
            }

            Assert.IsTrue(arr.Count == 100);
        }

        [Test]
        public void FindOrAddWithExpand()
        {
            // bug20071217
            var arr = new SortedArray<double>();
            for (var i = 0; i < 50; i++)
            {
                var iVar = i + 0.1;
                arr.FindOrAdd(ref iVar);
                arr.Add(i * 0.2);
            }

            Assert.IsTrue(arr.Count == 100);
        }

        [Test]
        public void RemoveWithReturn()
        {
            var p = new KeyValuePair<int, int>(3, 78);

            Assert.IsTrue(lst.Remove(p, out p));
            Assert.AreEqual(3, p.Key);
            Assert.AreEqual(33, p.Value);
            Assert.AreEqual(4, lst[3].Key);
            Assert.AreEqual(34, lst[3].Value);
            p = new KeyValuePair<int, int>(13, 78);
            Assert.IsFalse(lst.Remove(p, out p));
        }

        public Combined(MemoryType memoryType)
            : base(memoryType)
        {
        }
    }


    [TestFixture(MemoryType.Normal)]
    [TestFixture(MemoryType.Strict)]
    [TestFixture(MemoryType.Safe)]
    public class Remove : BaseMemoryType
    {
        private SortedArray<int> array;


        [SetUp]
        public void Init()
        {
            array = new SortedArray<int>(new IC(), MemoryType);
            for (var i = 10; i < 20; i++)
            {
                array.Add(i);
                array.Add(i + 10);
            }
        }


        [Test]
        public void SmallTrees()
        {
            array.Clear();
            array.Add(7);
            array.Add(9);
            Assert.IsTrue(array.Remove(7));
            Assert.IsTrue(array.Check());
        }


        [Test]
        public void ByIndex()
        {
            //Remove root!
            var n = array.Count;
            var i = array[10];

            array.RemoveAt(10);
            Assert.IsTrue(array.Check());
            Assert.IsFalse(array.Contains(i));
            Assert.AreEqual(n - 1, array.Count);

            //Low end
            i = array.FindMin();
            array.RemoveAt(0);
            Assert.IsTrue(array.Check());
            Assert.IsFalse(array.Contains(i));
            Assert.AreEqual(n - 2, array.Count);

            //high end
            i = array.FindMax();
            array.RemoveAt(array.Count - 1);
            Assert.IsTrue(array.Check());
            Assert.IsFalse(array.Contains(i));
            Assert.AreEqual(n - 3, array.Count);

            //Some leaf
            i = 18;
            array.RemoveAt(7);
            Assert.IsTrue(array.Check());
            Assert.IsFalse(array.Contains(i));
            Assert.AreEqual(n - 4, array.Count);
        }


        [Test]
        public void AlmostEmpty()
        {
            //Almost empty
            array.Clear();
            array.Add(3);
            array.RemoveAt(0);
            Assert.IsTrue(array.Check());
            Assert.IsFalse(array.Contains(3));
            Assert.AreEqual(0, array.Count);
        }


        [Test]
        public void Empty()
        {
            array.Clear();

            var exception = Assert.Throws<IndexOutOfRangeException>(() => array.RemoveAt(0));
            Assert.AreEqual("Index out of range for sequenced collectionvalue", exception.Message);
        }


        [Test]
        public void HighIndex()
        {
            var exception = Assert.Throws<IndexOutOfRangeException>(() => array.RemoveAt(array.Count));
            Assert.AreEqual("Index out of range for sequenced collectionvalue", exception.Message);
        }


        [Test]
        public void LowIndex()
        {
            var exception = Assert.Throws<IndexOutOfRangeException>(() => array.RemoveAt(-1));
            Assert.AreEqual("Index out of range for sequenced collectionvalue", exception.Message);
        }


        [Test]
        public void Normal()
        {
            Assert.IsFalse(array.Remove(-20));

            //No demote case, with move_item
            Assert.IsTrue(array.Remove(20));
            Assert.IsTrue(array.Check());
            Assert.IsFalse(array.Remove(20));

            //plain case 2
            Assert.IsTrue(array.Remove(14));
            Assert.IsTrue(array.Check(), "Bad tree");

            //case 1b
            Assert.IsTrue(array.Remove(25));
            Assert.IsTrue(array.Check(), "Bad tree");

            //case 1c
            Assert.IsTrue(array.Remove(29));
            Assert.IsTrue(array.Check(), "Bad tree");

            //1a (terminating)
            Assert.IsTrue(array.Remove(10));
            Assert.IsTrue(array.Check(), "Bad tree");

            //2+1b
            Assert.IsTrue(array.Remove(12));
            Assert.IsTrue(array.Remove(11));

            //1a+1b
            Assert.IsTrue(array.Remove(18));
            Assert.IsTrue(array.Remove(13));
            Assert.IsTrue(array.Remove(15));

            //2+1c
            for (var i = 0; i < 10; i++)
                array.Add(50 - 2 * i);

            Assert.IsTrue(array.Remove(42));
            Assert.IsTrue(array.Remove(38));
            Assert.IsTrue(array.Remove(28));
            Assert.IsTrue(array.Remove(40));

            //
            Assert.IsTrue(array.Remove(16));
            Assert.IsTrue(array.Remove(23));
            Assert.IsTrue(array.Remove(17));
            Assert.IsTrue(array.Remove(19));
            Assert.IsTrue(array.Remove(50));
            Assert.IsTrue(array.Remove(26));
            Assert.IsTrue(array.Remove(21));
            Assert.IsTrue(array.Remove(22));
            Assert.IsTrue(array.Remove(24));
            for (var i = 0; i < 48; i++)
                array.Remove(i);

            //Almost empty tree:
            Assert.IsFalse(array.Remove(26));
            Assert.IsTrue(array.Remove(48));
            Assert.IsTrue(array.Check(), "Bad tree");

            //Empty tree:
            Assert.IsFalse(array.Remove(26));
            Assert.IsTrue(array.Check(), "Bad tree");
        }


        [TearDown]
        public void Dispose()
        {
            array = null;
        }

        public Remove(MemoryType memoryType)
            : base(memoryType)
        {
        }
    }


    [TestFixture(MemoryType.Normal)]
    [TestFixture(MemoryType.Strict)]
    [TestFixture(MemoryType.Safe)]
    public class PredecessorStructure : BaseMemoryType
    {
        private SortedArray<int> tree;


        [SetUp]
        public void Init()
        {
            tree = new SortedArray<int>(new IC(), MemoryType);
        }


        private void loadup()
        {
            for (var i = 0; i < 20; i++)
                tree.Add(2 * i);
        }

        [Test]
        public void FindPredecessor()
        {
            loadup();
            int res;
            Assert.IsTrue(tree.TryPredecessor(7, out res) && res == 6);
            Assert.IsTrue(tree.TryPredecessor(8, out res) && res == 6);

            //The bottom
            Assert.IsTrue(tree.TryPredecessor(1, out res) && res == 0);

            //The top
            Assert.IsTrue(tree.TryPredecessor(39, out res) && res == 38);
        }

        [Test]
        public void FindPredecessorTooLow1()
        {
            int res;
            Assert.IsFalse(tree.TryPredecessor(-2, out res));
            Assert.AreEqual(0, res);
            Assert.IsFalse(tree.TryPredecessor(0, out res));
            Assert.AreEqual(0, res);
        }

        [Test]
        public void FindWeakPredecessor()
        {
            loadup();
            int res;
            Assert.IsTrue(tree.TryWeakPredecessor(7, out res) && res == 6);
            Assert.IsTrue(tree.TryWeakPredecessor(8, out res) && res == 8);

            //The bottom
            Assert.IsTrue(tree.TryWeakPredecessor(1, out res) && res == 0);
            Assert.IsTrue(tree.TryWeakPredecessor(0, out res) && res == 0);

            //The top
            Assert.IsTrue(tree.TryWeakPredecessor(39, out res) && res == 38);
            Assert.IsTrue(tree.TryWeakPredecessor(38, out res) && res == 38);
        }

        [Test]
        public void FindWeakPredecessorTooLow1()
        {
            int res;
            Assert.IsFalse(tree.TryWeakPredecessor(-1, out res));
            Assert.AreEqual(0, res);
        }

        [Test]
        public void FindSuccessor()
        {
            loadup();
            int res;
            Assert.IsTrue(tree.TrySuccessor(7, out res) && res == 8);
            Assert.IsTrue(tree.TrySuccessor(8, out res) && res == 10);

            //The bottom
            Assert.IsTrue(tree.TrySuccessor(0, out res) && res == 2);
            Assert.IsTrue(tree.TrySuccessor(-1, out res) && res == 0);

            //The top
            Assert.IsTrue(tree.TrySuccessor(37, out res) && res == 38);
        }

        [Test]
        public void FindSuccessorTooHigh()
        {
            int res;
            Assert.IsFalse(tree.TrySuccessor(38, out res));
            Assert.AreEqual(0, res);
            Assert.IsFalse(tree.TrySuccessor(39, out res));
            Assert.AreEqual(0, res);
        }

        [Test]
        public void FindWeakSuccessor()
        {
            loadup();
            int res;
            Assert.IsTrue(tree.TryWeakSuccessor(6, out res) && res == 6);
            Assert.IsTrue(tree.TryWeakSuccessor(7, out res) && res == 8);

            //The bottom
            Assert.IsTrue(tree.TryWeakSuccessor(-1, out res) && res == 0);
            Assert.IsTrue(tree.TryWeakSuccessor(0, out res) && res == 0);

            //The top
            Assert.IsTrue(tree.TryWeakSuccessor(37, out res) && res == 38);
            Assert.IsTrue(tree.TryWeakSuccessor(38, out res) && res == 38);
        }

        [Test]
        public void FindWeakSuccessorTooHigh1()
        {
            int res;
            Assert.IsFalse(tree.TryWeakSuccessor(39, out res));
            Assert.AreEqual(0, res);
        }


        [Test]
        public void Predecessor()
        {
            loadup();
            Assert.AreEqual(6, tree.Predecessor(7));
            Assert.AreEqual(6, tree.Predecessor(8));

            //The bottom
            Assert.AreEqual(0, tree.Predecessor(1));

            //The top
            Assert.AreEqual(38, tree.Predecessor(39));
        }

        [Test]
        public void PredecessorTooLow1()
        {
            Assert.Throws<NoSuchItemException>(() => tree.Predecessor(-2));
        }


        [Test]
        public void PredecessorTooLow2()
        {
            Assert.Throws<NoSuchItemException>(() => tree.Predecessor(0));
        }

        [Test]
        public void WeakPredecessor()
        {
            loadup();
            Assert.AreEqual(6, tree.WeakPredecessor(7));
            Assert.AreEqual(8, tree.WeakPredecessor(8));

            //The bottom
            Assert.AreEqual(0, tree.WeakPredecessor(1));
            Assert.AreEqual(0, tree.WeakPredecessor(0));

            //The top
            Assert.AreEqual(38, tree.WeakPredecessor(39));
            Assert.AreEqual(38, tree.WeakPredecessor(38));
        }

        [Test]
        public void WeakPredecessorTooLow1()
        {
            Assert.Throws<NoSuchItemException>(() => tree.WeakPredecessor(-1));
        }


        [Test]
        public void Successor()
        {
            loadup();
            Assert.AreEqual(8, tree.Successor(7));
            Assert.AreEqual(10, tree.Successor(8));

            //The bottom
            Assert.AreEqual(2, tree.Successor(0));
            Assert.AreEqual(0, tree.Successor(-1));

            //The top
            Assert.AreEqual(38, tree.Successor(37));
        }


        [Test]
        public void SuccessorTooHigh1()
        {
            Assert.Throws<NoSuchItemException>(() => tree.Successor(38));
        }


        [Test]
        public void SuccessorTooHigh2()
        {
            Assert.Throws<NoSuchItemException>(() => tree.Successor(39));
        }


        [Test]
        public void WeakSuccessor()
        {
            loadup();
            Assert.AreEqual(6, tree.WeakSuccessor(6));
            Assert.AreEqual(8, tree.WeakSuccessor(7));

            //The bottom
            Assert.AreEqual(0, tree.WeakSuccessor(-1));
            Assert.AreEqual(0, tree.WeakSuccessor(0));

            //The top
            Assert.AreEqual(38, tree.WeakSuccessor(37));
            Assert.AreEqual(38, tree.WeakSuccessor(38));
        }

        [Test]
        public void WeakSuccessorTooHigh1()
        {
            Assert.Throws<NoSuchItemException>(() => tree.WeakSuccessor(39));
        }


        [TearDown]
        public void Dispose()
        {
            tree = null;
        }

        public PredecessorStructure(MemoryType memoryType)
            : base(memoryType)
        {
        }
    }


    [TestFixture(MemoryType.Normal)]
    [TestFixture(MemoryType.Strict)]
    [TestFixture(MemoryType.Safe)]
    public class PriorityQueue : BaseMemoryType
    {
        private SortedArray<int> tree;


        [SetUp]
        public void Init()
        {
            tree = new SortedArray<int>(new IC(), MemoryType);
        }


        private void loadup()
        {
            foreach (var i in new int[] {1, 2, 3, 4})
                tree.Add(i);
        }


        [Test]
        public void Normal()
        {
            loadup();
            Assert.AreEqual(1, tree.FindMin());
            Assert.AreEqual(4, tree.FindMax());
            Assert.AreEqual(1, tree.DeleteMin());
            Assert.AreEqual(4, tree.DeleteMax());
            Assert.IsTrue(tree.Check(), "Bad tree");
            Assert.AreEqual(2, tree.FindMin());
            Assert.AreEqual(3, tree.FindMax());
            Assert.AreEqual(2, tree.DeleteMin());
            Assert.AreEqual(3, tree.DeleteMax());
            Assert.IsTrue(tree.Check(), "Bad tree");
        }


        [Test]
        public void Empty1()
        {
            Assert.Throws<NoSuchItemException>(() => tree.FindMin());
        }


        [Test]
        public void Empty2()
        {
            Assert.Throws<NoSuchItemException>(() => tree.FindMax());
        }


        [Test]
        public void Empty3()
        {
            Assert.Throws<NoSuchItemException>(() => tree.DeleteMin());
        }


        [Test]
        public void Empty4()
        {
            Assert.Throws<NoSuchItemException>(() => tree.DeleteMax());
        }


        [TearDown]
        public void Dispose()
        {
            tree = null;
        }

        public PriorityQueue(MemoryType memoryType)
            : base(memoryType)
        {
        }
    }


    [TestFixture(MemoryType.Normal)]
    [TestFixture(MemoryType.Strict)]
    [TestFixture(MemoryType.Safe)]
    public class IndexingAndCounting : BaseMemoryType
    {
        private SortedArray<int> array;


        [SetUp]
        public void Init()
        {
            array = new SortedArray<int>(new IC(), MemoryType);
        }


        private void populate()
        {
            array.Add(30);
            array.Add(50);
            array.Add(10);
            array.Add(70);
        }


        [Test]
        public void ToArray()
        {
            populate();

            var a = array.ToArray();

            Assert.AreEqual(4, a.Length);
            Assert.AreEqual(10, a[0]);
            Assert.AreEqual(30, a[1]);
            Assert.AreEqual(50, a[2]);
            Assert.AreEqual(70, a[3]);
        }


        [Test]
        public void GoodIndex()
        {
            Assert.AreEqual(~0, array.IndexOf(20));
            Assert.AreEqual(~0, array.LastIndexOf(20));
            populate();
            Assert.AreEqual(10, array[0]);
            Assert.AreEqual(30, array[1]);
            Assert.AreEqual(50, array[2]);
            Assert.AreEqual(70, array[3]);
            Assert.AreEqual(0, array.IndexOf(10));
            Assert.AreEqual(1, array.IndexOf(30));
            Assert.AreEqual(2, array.IndexOf(50));
            Assert.AreEqual(3, array.IndexOf(70));
            Assert.AreEqual(~1, array.IndexOf(20));
            Assert.AreEqual(~0, array.IndexOf(0));
            Assert.AreEqual(~4, array.IndexOf(90));
            Assert.AreEqual(0, array.LastIndexOf(10));
            Assert.AreEqual(1, array.LastIndexOf(30));
            Assert.AreEqual(2, array.LastIndexOf(50));
            Assert.AreEqual(3, array.LastIndexOf(70));
            Assert.AreEqual(~1, array.LastIndexOf(20));
            Assert.AreEqual(~0, array.LastIndexOf(0));
            Assert.AreEqual(~4, array.LastIndexOf(90));
        }


        [Test]
        public void IndexTooLarge()
        {
            populate();
            Assert.Throws<IndexOutOfRangeException>(() => Console.WriteLine(array[4]));
        }


        [Test]
        public void IndexTooSmall()
        {
            populate();
            Assert.Throws<IndexOutOfRangeException>(() => Console.WriteLine(array[-1]));
        }


        [Test]
        public void FilledTreeOutsideInput()
        {
            populate();
            Assert.AreEqual(0, array.CountFrom(90));
            Assert.AreEqual(0, array.CountFromTo(-20, 0));
            Assert.AreEqual(0, array.CountFromTo(80, 100));
            Assert.AreEqual(0, array.CountTo(0));
            Assert.AreEqual(4, array.CountTo(90));
            Assert.AreEqual(4, array.CountFromTo(-20, 90));
            Assert.AreEqual(4, array.CountFrom(0));
        }


        [Test]
        public void FilledTreeIntermediateInput()
        {
            populate();
            Assert.AreEqual(3, array.CountFrom(20));
            Assert.AreEqual(1, array.CountFromTo(20, 40));
            Assert.AreEqual(2, array.CountTo(40));
        }


        [Test]
        public void FilledTreeMatchingInput()
        {
            populate();
            Assert.AreEqual(3, array.CountFrom(30));
            Assert.AreEqual(2, array.CountFromTo(30, 70));
            Assert.AreEqual(0, array.CountFromTo(50, 30));
            Assert.AreEqual(0, array.CountFromTo(50, 50));
            Assert.AreEqual(0, array.CountTo(10));
            Assert.AreEqual(2, array.CountTo(50));
        }


        [Test]
        public void CountEmptyTree()
        {
            Assert.AreEqual(0, array.CountFrom(20));
            Assert.AreEqual(0, array.CountFromTo(20, 40));
            Assert.AreEqual(0, array.CountTo(40));
        }


        [TearDown]
        public void Dispose()
        {
            array = null;
        }

        public IndexingAndCounting(MemoryType memoryType)
            : base(memoryType)
        {
        }
    }


    namespace ModificationCheck
    {
        [TestFixture(MemoryType.Normal)]
        [TestFixture(MemoryType.Strict)]
        [TestFixture(MemoryType.Safe)]
        public class Enumerator : BaseMemoryType
        {
            private SortedArray<int> tree;

            private SCG.IEnumerator<int> e;


            [SetUp]
            public void Init()
            {
                tree = new SortedArray<int>(new IC(), MemoryType);
                for (var i = 0; i < 10; i++)
                {
                    tree.Add(i);
                }

                e = tree.GetEnumerator();
            }


            [Test]
            public void CurrentAfterModification()
            {
                e.MoveNext();
                tree.Add(34);
                Assert.AreEqual(0, e.Current);
            }


            [Test]
            public void MoveNextAfterAdd()
            {
                e.MoveNext();
                tree.Add(34);

                Assert.Throws<CollectionModifiedException>(() => e.MoveNext());
            }

            [Test]
            public void MoveNextAfterRemove()
            {
                e.MoveNext();
                tree.Remove(34);

                Assert.Throws<CollectionModifiedException>(() => e.MoveNext());
            }


            [Test]
            public void MoveNextAfterClear()
            {
                e.MoveNext();
                tree.Clear();

                Assert.Throws<CollectionModifiedException>(() => e.MoveNext());
            }


            [TearDown]
            public void Dispose()
            {
                tree = null;
                e = null;
            }

            public Enumerator(MemoryType memoryType)
                : base(memoryType)
            {
            }
        }

        [TestFixture(MemoryType.Normal)]
        [TestFixture(MemoryType.Strict)]
        [TestFixture(MemoryType.Safe)]
        public class RangeEnumerator : BaseMemoryType
        {
            private SortedArray<int> tree;

            private SCG.IEnumerator<int> e;


            [SetUp]
            public void Init()
            {
                tree = new SortedArray<int>(new IC(), MemoryType);
                for (var i = 0; i < 10; i++)
                    tree.Add(i);

                e = tree.RangeFromTo(3, 7).GetEnumerator();
            }


            [Test]
            public void CurrentAfterModification()
            {
                e.MoveNext();
                tree.Add(34);
                Assert.AreEqual(3, e.Current);
            }


            [Test]
            public void MoveNextAfterAdd()
            {
                tree.Add(34);

                Assert.Throws<CollectionModifiedException>(() => e.MoveNext());
            }


            [Test]
            public void MoveNextAfterRemove()
            {
                tree.Remove(34);

                Assert.Throws<CollectionModifiedException>(() => e.MoveNext());
            }


            [Test]
            public void MoveNextAfterClear()
            {
                tree.Clear();

                Assert.Throws<CollectionModifiedException>(() => e.MoveNext());
            }


            [TearDown]
            public void Dispose()
            {
                tree = null;
                e = null;
            }

            public RangeEnumerator(MemoryType memoryType)
                : base(memoryType)
            {
            }
        }
    }

    namespace HigherOrder
    {
        internal class CubeRoot : IComparable<int>
        {
            private int c;


            internal CubeRoot(int c)
            {
                this.c = c;
            }


            public int CompareTo(int that)
            {
                return c - that * that * that;
            }

            public bool Equals(int that)
            {
                return c == that * that * that;
            }
        }


        class Interval : IComparable<int>
        {
            private int b, t;


            internal Interval(int b, int t)
            {
                this.b = b;
                this.t = t;
            }


            public int CompareTo(int that)
            {
                return that < b ? 1 :
                    that > t ? -1 : 0;
            }

            public bool Equals(int that)
            {
                return that >= b && that <= t;
            }
        }


        [TestFixture(MemoryType.Normal)]
        [TestFixture(MemoryType.Strict)]
        [TestFixture(MemoryType.Safe)]
        public class Simple : BaseMemoryType
        {
            private SortedArray<int> array;

            private SCG.IComparer<int> ic;


            [SetUp]
            public void Init()
            {
                ic = new IC();
                array = new SortedArray<int>(ic, MemoryType);
            }


            private bool never(int i)
            {
                return false;
            }


            private bool always(int i)
            {
                return true;
            }


            private bool even(int i)
            {
                return i % 2 == 0;
            }


            private string themap(int i)
            {
                return string.Format("AA {0,4} BB", i);
            }


            private string badmap(int i)
            {
                return string.Format("AA {0} BB", i);
            }


            private int appfield1;

            private int appfield2;


            private void apply(int i)
            {
                appfield1++;
                appfield2 += i * i;
            }


            [Test]
            public void Apply()
            {
                var simple1 = new Simple(MemoryType);

                array.Apply(new Action<int>(simple1.apply));
                Assert.AreEqual(0, simple1.appfield1);
                Assert.AreEqual(0, simple1.appfield2);

                var simple2 = new Simple(MemoryType);

                for (var i = 0; i < 10; i++) array.Add(i);

                array.Apply(new Action<int>(simple2.apply));
                Assert.AreEqual(10, simple2.appfield1);
                Assert.AreEqual(285, simple2.appfield2);
            }


            [Test]
            public void All()
            {
                Assert.IsTrue(array.All(new Func<int, bool>(never)));
                Assert.IsTrue(array.All(new Func<int, bool>(even)));
                Assert.IsTrue(array.All(new Func<int, bool>(always)));
                for (var i = 0; i < 10; i++) array.Add(i);

                Assert.IsFalse(array.All(new Func<int, bool>(never)));
                Assert.IsFalse(array.All(new Func<int, bool>(even)));
                Assert.IsTrue(array.All(new Func<int, bool>(always)));
                array.Clear();
                for (var i = 0; i < 10; i++) array.Add(i * 2);

                Assert.IsFalse(array.All(new Func<int, bool>(never)));
                Assert.IsTrue(array.All(new Func<int, bool>(even)));
                Assert.IsTrue(array.All(new Func<int, bool>(always)));
                array.Clear();
                for (var i = 0; i < 10; i++) array.Add(i * 2 + 1);

                Assert.IsFalse(array.All(new Func<int, bool>(never)));
                Assert.IsFalse(array.All(new Func<int, bool>(even)));
                Assert.IsTrue(array.All(new Func<int, bool>(always)));
            }


            [Test]
            public void Exists()
            {
                Assert.IsFalse(array.Exists(new Func<int, bool>(never)));
                Assert.IsFalse(array.Exists(new Func<int, bool>(even)));
                Assert.IsFalse(array.Exists(new Func<int, bool>(always)));
                for (var i = 0; i < 10; i++) array.Add(i);

                Assert.IsFalse(array.Exists(new Func<int, bool>(never)));
                Assert.IsTrue(array.Exists(new Func<int, bool>(even)));
                Assert.IsTrue(array.Exists(new Func<int, bool>(always)));
                array.Clear();
                for (var i = 0; i < 10; i++) array.Add(i * 2);

                Assert.IsFalse(array.Exists(new Func<int, bool>(never)));
                Assert.IsTrue(array.Exists(new Func<int, bool>(even)));
                Assert.IsTrue(array.Exists(new Func<int, bool>(always)));
                array.Clear();
                for (var i = 0; i < 10; i++) array.Add(i * 2 + 1);

                Assert.IsFalse(array.Exists(new Func<int, bool>(never)));
                Assert.IsFalse(array.Exists(new Func<int, bool>(even)));
                Assert.IsTrue(array.Exists(new Func<int, bool>(always)));
            }


            [Test]
            public void FindAll()
            {
                Assert.AreEqual(0, array.FindAll(new Func<int, bool>(never)).Count);
                for (var i = 0; i < 10; i++)
                    array.Add(i);

                Assert.AreEqual(0, array.FindAll(new Func<int, bool>(never)).Count);
                Assert.AreEqual(10, array.FindAll(new Func<int, bool>(always)).Count);
                Assert.AreEqual(5, array.FindAll(new Func<int, bool>(even)).Count);
                Assert.IsTrue(((SortedArray<int>) array.FindAll(new Func<int, bool>(even))).Check());
            }


            [Test]
            public void Map()
            {
                Assert.AreEqual(0, array.Map(new Func<int, string>(themap), new SC()).Count);
                for (var i = 0; i < 11; i++)
                    array.Add(i * i * i);

                var res = array.Map(new Func<int, string>(themap), new SC());

                Assert.IsTrue(((SortedArray<string>) res).Check());
                Assert.AreEqual(11, res.Count);
                Assert.AreEqual("AA    0 BB", res[0]);
                Assert.AreEqual("AA   27 BB", res[3]);
                Assert.AreEqual("AA  125 BB", res[5]);
                Assert.AreEqual("AA 1000 BB", res[10]);
            }


            [Test]
            public void BadMap()
            {
                for (var i = 0; i < 11; i++)
                {
                    array.Add(i * i * i);
                }

                var exception = Assert.Throws<ArgumentException>(() =>
                {
                    ISorted<string> res = array.Map(new Func<int, string>(badmap), new SC());
                });
                Assert.AreEqual("mapper not monotonic", exception.Message);
            }


            [Test]
            public void Cut()
            {
                for (var i = 0; i < 10; i++)
                    array.Add(i);

                int low, high;
                bool lval, hval;

                Assert.IsTrue(array.Cut(new CubeRoot(27), out low, out lval, out high, out hval));
                Assert.IsTrue(lval && hval);
                Assert.AreEqual(4, high);
                Assert.AreEqual(2, low);
                Assert.IsFalse(array.Cut(new CubeRoot(30), out low, out lval, out high, out hval));
                Assert.IsTrue(lval && hval);
                Assert.AreEqual(4, high);
                Assert.AreEqual(3, low);
            }


            [Test]
            public void CutInt()
            {
                for (var i = 0; i < 10; i++)
                    array.Add(2 * i);

                int low, high;
                bool lval, hval;

                Assert.IsFalse(array.Cut(new IC(3), out low, out lval, out high, out hval));
                Assert.IsTrue(lval && hval);
                Assert.AreEqual(4, high);
                Assert.AreEqual(2, low);
                Assert.IsTrue(array.Cut(new IC(6), out low, out lval, out high, out hval));
                Assert.IsTrue(lval && hval);
                Assert.AreEqual(8, high);
                Assert.AreEqual(4, low);
            }


            [Test]
            public void CutInterval()
            {
                for (var i = 0; i < 10; i++)
                    array.Add(2 * i);

                int lo, hi;
                bool lv, hv;

                Assert.IsTrue(array.Cut(new Interval(5, 9), out lo, out lv, out hi, out hv));
                Assert.IsTrue(lv && hv);
                Assert.AreEqual(10, hi);
                Assert.AreEqual(4, lo);
                Assert.IsTrue(array.Cut(new Interval(6, 10), out lo, out lv, out hi, out hv));
                Assert.IsTrue(lv && hv);
                Assert.AreEqual(12, hi);
                Assert.AreEqual(4, lo);
                for (var i = 0; i < 100; i++)
                    array.Add(2 * i);

                array.Cut(new Interval(77, 105), out lo, out lv, out hi, out hv);
                Assert.IsTrue(lv && hv);
                Assert.AreEqual(106, hi);
                Assert.AreEqual(76, lo);
                array.Cut(new Interval(5, 7), out lo, out lv, out hi, out hv);
                Assert.IsTrue(lv && hv);
                Assert.AreEqual(8, hi);
                Assert.AreEqual(4, lo);
                array.Cut(new Interval(80, 110), out lo, out lv, out hi, out hv);
                Assert.IsTrue(lv && hv);
                Assert.AreEqual(112, hi);
                Assert.AreEqual(78, lo);
            }


            [Test]
            public void UpperCut()
            {
                for (var i = 0; i < 10; i++)
                    array.Add(i);

                int l, h;
                bool lv, hv;

                Assert.IsFalse(array.Cut(new CubeRoot(1000), out l, out lv, out h, out hv));
                Assert.IsTrue(lv && !hv);
                Assert.AreEqual(9, l);
                Assert.IsFalse(array.Cut(new CubeRoot(-50), out l, out lv, out h, out hv));
                Assert.IsTrue(!lv && hv);
                Assert.AreEqual(0, h);
            }


            [TearDown]
            public void Dispose()
            {
                ic = null;
                array = null;
            }

            public Simple(MemoryType memoryType)
                : base(memoryType)
            {
            }
        }
    }


    namespace MultiOps
    {
        [TestFixture(MemoryType.Normal)]
        [TestFixture(MemoryType.Strict)]
        [TestFixture(MemoryType.Safe)]
        public class AddAll : BaseMemoryType
        {
            private int sqr(int i)
            {
                return i * i;
            }


            SortedArray<int> array;


            [SetUp]
            public void Init()
            {
                array = new SortedArray<int>(new IC(), MemoryType);
            }


            [Test]
            public void EmptyEmpty()
            {
                array.AddAll(new FunEnumerable(0, new Func<int, int>(sqr)));
                Assert.AreEqual(0, array.Count);
                Assert.IsTrue(array.Check());
            }


            [Test]
            public void SomeEmpty()
            {
                for (var i = 4; i < 9; i++) array.Add(i);

                array.AddAll(new FunEnumerable(0, new Func<int, int>(sqr)));
                Assert.AreEqual(5, array.Count);
                Assert.IsTrue(array.Check());
            }


            [Test]
            public void EmptySome()
            {
                array.AddAll(new FunEnumerable(4, new Func<int, int>(sqr)));
                Assert.AreEqual(4, array.Count);
                Assert.IsTrue(array.Check());
                Assert.AreEqual(0, array[0]);
                Assert.AreEqual(1, array[1]);
                Assert.AreEqual(4, array[2]);
                Assert.AreEqual(9, array[3]);
            }


            [Test]
            public void SomeSome()
            {
                for (var i = 3; i < 9; i++) array.Add(i);

                array.AddAll(new FunEnumerable(4, new Func<int, int>(sqr)));
                Assert.AreEqual(9, array.Count);
                Assert.IsTrue(array.Check());
                Assert.IsTrue(IC.eq(array, 0, 1, 3, 4, 5, 6, 7, 8, 9));
            }


            [TearDown]
            public void Dispose()
            {
                array = null;
            }

            public AddAll(MemoryType memoryType)
                : base(memoryType)
            {
            }
        }


        [TestFixture(MemoryType.Normal)]
        [TestFixture(MemoryType.Strict)]
        [TestFixture(MemoryType.Safe)]
        public class AddSorted : BaseMemoryType
        {
            private int sqr(int i)
            {
                return i * i;
            }


            private int bad(int i)
            {
                return i * (5 - i);
            }


            SortedArray<int> array;


            [SetUp]
            public void Init()
            {
                array = new SortedArray<int>(new IC(), MemoryType);
            }


            [Test]
            public void EmptyEmpty()
            {
                array.AddSorted(new FunEnumerable(0, new Func<int, int>(sqr)));
                Assert.AreEqual(0, array.Count);
                Assert.IsTrue(array.Check());
            }


            [Test]
            public void SomeEmpty()
            {
                for (var i = 4; i < 9; i++) array.Add(i);

                array.AddSorted(new FunEnumerable(0, new Func<int, int>(sqr)));
                Assert.AreEqual(5, array.Count);
                Assert.IsTrue(array.Check());
            }


            [Test]
            public void EmptySome()
            {
                array.AddSorted(new FunEnumerable(4, new Func<int, int>(sqr)));
                Assert.AreEqual(4, array.Count);
                Assert.IsTrue(array.Check());
                Assert.AreEqual(0, array[0]);
                Assert.AreEqual(1, array[1]);
                Assert.AreEqual(4, array[2]);
                Assert.AreEqual(9, array[3]);
            }


            [Test]
            public void SomeSome()
            {
                for (var i = 3; i < 9; i++) array.Add(i);

                array.AddSorted(new FunEnumerable(4, new Func<int, int>(sqr)));
                Assert.AreEqual(9, array.Count);
                Assert.IsTrue(array.Check());
                Assert.IsTrue(IC.eq(array, 0, 1, 3, 4, 5, 6, 7, 8, 9));
            }

            [Test]
            public void EmptyBad()
            {
                var exception = Assert.Throws<ArgumentException>(() =>
                    array.AddSorted(new FunEnumerable(9, new Func<int, int>(bad))));
                Assert.AreEqual("Argument not sorted", exception.Message);
            }


            [TearDown]
            public void Dispose()
            {
                array = null;
            }

            public AddSorted(MemoryType memoryType)
                : base(memoryType)
            {
            }
        }

        [TestFixture(MemoryType.Normal)]
        [TestFixture(MemoryType.Strict)]
        [TestFixture(MemoryType.Safe)]
        public class Rest : BaseMemoryType
        {
            SortedArray<int> array, array2;


            public Rest(MemoryType memoryType)
                : base(memoryType)
            {
            }

            [SetUp]
            public void Init()
            {
                array = new SortedArray<int>(new IC(), MemoryType);
                array2 = new SortedArray<int>(new IC(), MemoryType);
                for (var i = 0; i < 10; i++)
                    array.Add(i);

                for (var i = 0; i < 10; i++)
                    array2.Add(2 * i);
            }


            [Test]
            public void RemoveAll()
            {
                array.RemoveAll(array2.RangeFromTo(3, 7));
                Assert.AreEqual(8, array.Count);
                Assert.IsTrue(array.Check());
                Assert.IsTrue(IC.eq(array, 0, 1, 2, 3, 5, 7, 8, 9));
                array.RemoveAll(array2.RangeFromTo(3, 7));
                Assert.AreEqual(8, array.Count);
                Assert.IsTrue(array.Check());
                Assert.IsTrue(IC.eq(array, 0, 1, 2, 3, 5, 7, 8, 9));
                array.RemoveAll(array2.RangeFromTo(13, 17));
                Assert.AreEqual(8, array.Count);
                Assert.IsTrue(array.Check());
                Assert.IsTrue(IC.eq(array, 0, 1, 2, 3, 5, 7, 8, 9));
                array.RemoveAll(array2.RangeFromTo(3, 17));
                Assert.AreEqual(7, array.Count);
                Assert.IsTrue(array.Check());
                Assert.IsTrue(IC.eq(array, 0, 1, 2, 3, 5, 7, 9));
                for (var i = 0; i < 10; i++) array2.Add(i);

                array.RemoveAll(array2.RangeFromTo(-1, 10));
                Assert.AreEqual(0, array.Count);
                Assert.IsTrue(array.Check());
                Assert.IsTrue(IC.eq(array));
            }


            [Test]
            public void RetainAll()
            {
                array.RetainAll(array2.RangeFromTo(3, 17));
                Assert.AreEqual(3, array.Count);
                Assert.IsTrue(array.Check());
                Assert.IsTrue(IC.eq(array, 4, 6, 8));
                array.RetainAll(array2.RangeFromTo(1, 17));
                Assert.AreEqual(3, array.Count);
                Assert.IsTrue(array.Check());
                Assert.IsTrue(IC.eq(array, 4, 6, 8));
                array.RetainAll(array2.RangeFromTo(3, 5));
                Assert.AreEqual(1, array.Count);
                Assert.IsTrue(array.Check());
                Assert.IsTrue(IC.eq(array, 4));
                array.RetainAll(array2.RangeFromTo(7, 17));
                Assert.AreEqual(0, array.Count);
                Assert.IsTrue(array.Check());
                Assert.IsTrue(IC.eq(array));
                for (var i = 0; i < 10; i++) array.Add(i);

                array.RetainAll(array2.RangeFromTo(5, 5));
                Assert.AreEqual(0, array.Count);
                Assert.IsTrue(array.Check());
                Assert.IsTrue(IC.eq(array));
                for (var i = 0; i < 10; i++) array.Add(i);

                array.RetainAll(array2.RangeFromTo(15, 25));
                Assert.AreEqual(0, array.Count);
                Assert.IsTrue(array.Check());
                Assert.IsTrue(IC.eq(array));
            }


            [Test]
            public void ContainsAll()
            {
                Assert.IsFalse(array.ContainsAll(array2));
                Assert.IsTrue(array.ContainsAll(array));
                array2.Clear();
                Assert.IsTrue(array.ContainsAll(array2));
                array.Clear();
                Assert.IsTrue(array.ContainsAll(array2));
                array2.Add(8);
                Assert.IsFalse(array.ContainsAll(array2));
            }


            [Test]
            public void RemoveInterval()
            {
                array.RemoveInterval(3, 4);
                Assert.IsTrue(array.Check());
                Assert.AreEqual(6, array.Count);
                Assert.IsTrue(IC.eq(array, 0, 1, 2, 7, 8, 9));
                array.RemoveInterval(2, 3);
                Assert.IsTrue(array.Check());
                Assert.AreEqual(3, array.Count);
                Assert.IsTrue(IC.eq(array, 0, 1, 9));
                array.RemoveInterval(0, 3);
                Assert.IsTrue(array.Check());
                Assert.AreEqual(0, array.Count);
                Assert.IsTrue(IC.eq(array));
            }


            [Test]
            public void RemoveRangeBad1()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => array.RemoveInterval(-3, 8));
            }


            [Test]
            public void RemoveRangeBad2()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => array.RemoveInterval(3, -8));
            }


            [Test]
            public void RemoveRangeBad3()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => array.RemoveInterval(3, 8));
            }


            [Test]
            public void GetRange()
            {
                SCG.IEnumerable<int> e = array[3, 3];

                Assert.IsTrue(IC.eq(e, 3, 4, 5));
                e = array[3, 0];
                Assert.IsTrue(IC.eq(e));
            }

            [Test]
            public void GetRangeBad1()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() =>
                {
                    object foo = array[-3, 0];
                });
            }

            [Test]
            public void GetRangeBad2()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() =>
                {
                    object foo = array[3, -1];
                });
            }

            [Test]
            public void GetRangeBad3()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() =>
                {
                    object foo = array[3, 8];
                });
            }

            [TearDown]
            public void Dispose()
            {
                array = null;
                array2 = null;
            }
        }
    }


    namespace Sync
    {
        [TestFixture(MemoryType.Normal)]
        [TestFixture(MemoryType.Strict)]
        [TestFixture(MemoryType.Safe)]
        public class SyncRoot : BaseMemoryType
        {
            private SortedArray<int> tree;
            private readonly Object mySyncRoot = new Object();
            int sz = 5000;


            public SyncRoot(MemoryType memoryType)
                : base(memoryType)
            {
            }

            [Test]
            public void Safe()
            {
                var t1 = new System.Threading.Thread(new System.Threading.ThreadStart(safe1));
                var t2 = new System.Threading.Thread(new System.Threading.ThreadStart(safe2));

                t1.Start();
                t2.Start();
                t1.Join();
                t2.Join();
                Assert.AreEqual(2 * sz + 1, tree.Count);
                Assert.IsTrue(tree.Check());
            }


            //[Test]
            public void UnSafe()
            {
                var bad = false;

                for (var i = 0; i < 10; i++)
                {
                    var t1 = new System.Threading.Thread(new System.Threading.ThreadStart(unsafe1));
                    var t2 = new System.Threading.Thread(new System.Threading.ThreadStart(unsafe2));

                    t1.Start();
                    t2.Start();
                    t1.Join();
                    t2.Join();
                    if (bad = 2 * sz + 1 != tree.Count)
                    {
                        Console.WriteLine("{0}::Unsafe(): bad at {1}", GetType(), i);
                        break;
                    }
                }

                Assert.IsTrue(bad, "No sync problems!");
            }


            [Test]
            public void SafeUnSafe()
            {
                var t1 = new System.Threading.Thread(new System.Threading.ThreadStart(unsafe1));
                var t2 = new System.Threading.Thread(new System.Threading.ThreadStart(unsafe2));

                t1.Start();
                t1.Join();
                t2.Start();
                t2.Join();
                Assert.AreEqual(2 * sz + 1, tree.Count);
            }


            [SetUp]
            public void Init()
            {
                tree = new SortedArray<int>(new IC(), MemoryType);
            }


            private void unsafe1()
            {
                for (var i = 0; i < 2 * sz; i++)
                    tree.Add(i * 2);

                for (var i = 1; i < sz; i++)
                    tree.Remove(i * 4);
            }


            private void safe1()
            {
                for (var i = 0; i < 2 * sz; i++)
                    lock (mySyncRoot)
                        tree.Add(i * 2);

                for (var i = 1; i < sz; i++)
                    lock (mySyncRoot)
                        tree.Remove(i * 4);
            }


            private void unsafe2()
            {
                for (var i = 2 * sz; i > 0; i--)
                    tree.Add(i * 2 + 1);

                for (var i = sz; i > 0; i--)
                    tree.Remove(i * 4 + 1);
            }


            private void safe2()
            {
                for (var i = 2 * sz; i > 0; i--)
                    lock (mySyncRoot)
                        tree.Add(i * 2 + 1);

                for (var i = sz; i > 0; i--)
                    lock (mySyncRoot)
                        tree.Remove(i * 4 + 1);
            }


            [TearDown]
            public void Dispose()
            {
                tree = null;
            }
        }


        [TestFixture(MemoryType.Normal)]
        [TestFixture(MemoryType.Strict)]
        [TestFixture(MemoryType.Safe)]
        public class ConcurrentQueries : BaseMemoryType
        {
            private SortedArray<int> tree;

            int sz = 500000;

            public ConcurrentQueries(MemoryType memoryType)
                : base(memoryType)
            {
            }

            [SetUp]
            public void Init()
            {
                tree = new SortedArray<int>(new IC(), MemoryType);
                for (var i = 0; i < sz; i++)
                {
                    tree.Add(i);
                }
            }


            class A
            {
                public int count = 0;

                SortedArray<int> t;


                public A(SortedArray<int> t)
                {
                    this.t = t;
                }


                public void a(int i)
                {
                    count++;
                }

                public void traverse()
                {
                    traverse(null);
                }

                /// <summary>
                /// It calls the method a(int i) but it raises an exception if an error occur. This has been added to test
                /// exception being thrown if multithread mode and MemoryMode.Strict is selected.
                /// </summary>
                /// <param name="onError">On error.</param>
                public void traverse(Action onError = null)
                {
                    try
                    {
                        t.Apply(a);
                    }
                    catch (Exception)
                    {
                        if (onError != null)
                            onError();
                    }
                }
            }


            [Test]
            public void Safe()
            {
                var a = new A(tree);

                a.traverse();
                Assert.AreEqual(sz, a.count);
            }


            [Test]
            public void RegrettablyUnsafe()
            {
                if (MemoryType == MemoryType.Strict) return;

                var t = new System.Threading.Thread[10];
                var a = new A[10];
                for (var i = 0; i < 10; i++)
                {
                    a[i] = new A(tree);
                    t[i] = new System.Threading.Thread(new System.Threading.ThreadStart(a[i].traverse));
                }

                for (var i = 0; i < 10; i++)
                    t[i].Start();
                for (var i = 0; i < 10; i++)
                    t[i].Join();
                for (var i = 0; i < 10; i++)
                    Assert.AreEqual(sz, a[i].count);
            }

            // This is a static placeholder to detect exception in a multithread context. Unfortunately
            // exception risen in secondary threads are swallowed and not detected.
            private static bool ErrorOnChildThread;

            [Test]
            public void RegrettablyUnsafeStrictMemory()
            {
                if (MemoryType != MemoryType.Strict)
                    return;

                var t = new System.Threading.Thread[10];
                var a = new A[10];
                Action onError = () => { ErrorOnChildThread = true; };
                for (var i = 0; i < 10; i++)
                {
                    a[i] = new A(tree);
                    var i1 = i;
                    t[i] = new System.Threading.Thread(obj => { a[i1].traverse(onError); });
                }

                for (var i = 0; i < 10; i++)
                    t[i].Start();
                for (var i = 0; i < 10; i++)
                    t[i].Join();

                Assert.True(ErrorOnChildThread);
            }


            [TearDown]
            public void Dispose()
            {
                tree = null;
            }
        }
    }


    namespace Hashing
    {
        [TestFixture(MemoryType.Normal)]
        [TestFixture(MemoryType.Strict)]
        [TestFixture(MemoryType.Safe)]
        public class ISequenced : BaseMemoryType
        {
            private ISequenced<int> dit, dat, dut;

            public ISequenced(MemoryType memoryType)
                : base(memoryType)
            {
            }

            [SetUp]
            public void Init()
            {
                dit = new SortedArray<int>(8, SCG.Comparer<int>.Default, EqualityComparer<int>.Default, MemoryType);
                dat = new SortedArray<int>(8, SCG.Comparer<int>.Default, EqualityComparer<int>.Default, MemoryType);
                dut = new SortedArray<int>(8, new RevIC(), EqualityComparer<int>.Default, MemoryType);
            }


            [Test]
            public void EmptyEmpty()
            {
                Assert.IsTrue(dit.SequencedEquals(dat));
            }


            [Test]
            public void EmptyNonEmpty()
            {
                dit.Add(3);
                Assert.IsFalse(dit.SequencedEquals(dat));
                Assert.IsFalse(dat.SequencedEquals(dit));
            }

            [Test]
            public void HashVal()
            {
                Assert.AreEqual(CHC.sequencedhashcode(), dit.GetSequencedHashCode());
                dit.Add(3);
                Assert.AreEqual(CHC.sequencedhashcode(3), dit.GetSequencedHashCode());
                dit.Add(7);
                Assert.AreEqual(CHC.sequencedhashcode(3, 7), dit.GetSequencedHashCode());
                Assert.AreEqual(CHC.sequencedhashcode(), dut.GetSequencedHashCode());
                dut.Add(3);
                Assert.AreEqual(CHC.sequencedhashcode(3), dut.GetSequencedHashCode());
                dut.Add(7);
                Assert.AreEqual(CHC.sequencedhashcode(7, 3), dut.GetSequencedHashCode());
            }


            [Test]
            public void Normal()
            {
                dit.Add(3);
                dit.Add(7);
                dat.Add(3);
                Assert.IsFalse(dit.SequencedEquals(dat));
                Assert.IsFalse(dat.SequencedEquals(dit));
                dat.Add(7);
                Assert.IsTrue(dit.SequencedEquals(dat));
                Assert.IsTrue(dat.SequencedEquals(dit));
            }


            [Test]
            public void WrongOrder()
            {
                dit.Add(3);
                dut.Add(3);
                Assert.IsTrue(dit.SequencedEquals(dut));
                Assert.IsTrue(dut.SequencedEquals(dit));
                dit.Add(7);
                dut.Add(7);
                Assert.IsFalse(dit.SequencedEquals(dut));
                Assert.IsFalse(dut.SequencedEquals(dit));
            }


            [Test]
            public void Reflexive()
            {
                Assert.IsTrue(dit.SequencedEquals(dit));
                dit.Add(3);
                Assert.IsTrue(dit.SequencedEquals(dit));
                dit.Add(7);
                Assert.IsTrue(dit.SequencedEquals(dit));
            }


            [TearDown]
            public void Dispose()
            {
                dit = null;
                dat = null;
                dut = null;
            }
        }


        [TestFixture(MemoryType.Normal)]
        [TestFixture(MemoryType.Strict)]
        [TestFixture(MemoryType.Safe)]
        public class IEditableCollection : BaseMemoryType
        {
            private ICollection<int> dit, dat, dut;


            [SetUp]
            public void Init()
            {
                dit = new SortedArray<int>(8, SCG.Comparer<int>.Default, EqualityComparer<int>.Default, MemoryType);
                dat = new SortedArray<int>(8, SCG.Comparer<int>.Default, EqualityComparer<int>.Default, MemoryType);
                dut = new SortedArray<int>(8, new RevIC(), EqualityComparer<int>.Default, MemoryType);
            }


            [Test]
            public void EmptyEmpty()
            {
                Assert.IsTrue(dit.UnsequencedEquals(dat));
            }


            [Test]
            public void EmptyNonEmpty()
            {
                dit.Add(3);
                Assert.IsFalse(dit.UnsequencedEquals(dat));
                Assert.IsFalse(dat.UnsequencedEquals(dit));
            }


            [Test]
            public void HashVal()
            {
                Assert.AreEqual(CHC.unsequencedhashcode(), dit.GetUnsequencedHashCode());
                dit.Add(3);
                Assert.AreEqual(CHC.unsequencedhashcode(3), dit.GetUnsequencedHashCode());
                dit.Add(7);
                Assert.AreEqual(CHC.unsequencedhashcode(3, 7), dit.GetUnsequencedHashCode());
                Assert.AreEqual(CHC.unsequencedhashcode(), dut.GetUnsequencedHashCode());
                dut.Add(3);
                Assert.AreEqual(CHC.unsequencedhashcode(3), dut.GetUnsequencedHashCode());
                dut.Add(7);
                Assert.AreEqual(CHC.unsequencedhashcode(7, 3), dut.GetUnsequencedHashCode());
            }


            [Test]
            public void Normal()
            {
                dit.Add(3);
                dit.Add(7);
                dat.Add(3);
                Assert.IsFalse(dit.UnsequencedEquals(dat));
                Assert.IsFalse(dat.UnsequencedEquals(dit));
                dat.Add(7);
                Assert.IsTrue(dit.UnsequencedEquals(dat));
                Assert.IsTrue(dat.UnsequencedEquals(dit));
            }


            [Test]
            public void WrongOrder()
            {
                dit.Add(3);
                dut.Add(3);
                Assert.IsTrue(dit.UnsequencedEquals(dut));
                Assert.IsTrue(dut.UnsequencedEquals(dit));
                dit.Add(7);
                dut.Add(7);
                Assert.IsTrue(dit.UnsequencedEquals(dut));
                Assert.IsTrue(dut.UnsequencedEquals(dit));
            }


            [Test]
            public void Reflexive()
            {
                Assert.IsTrue(dit.UnsequencedEquals(dit));
                dit.Add(3);
                Assert.IsTrue(dit.UnsequencedEquals(dit));
                dit.Add(7);
                Assert.IsTrue(dit.UnsequencedEquals(dit));
            }


            [TearDown]
            public void Dispose()
            {
                dit = null;
                dat = null;
                dut = null;
            }

            public IEditableCollection(MemoryType memoryType)
                : base(memoryType)
            {
            }
        }
    }
}