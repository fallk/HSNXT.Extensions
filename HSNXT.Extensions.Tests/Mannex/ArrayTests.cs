#region License, Terms and Author(s)
//
// Mannex - Extension methods for .NET
// Copyright (c) 2009 Atif Aziz. All rights reserved.
//
//  Author(s):
//
//      Atif Aziz, http://www.raboof.com
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion

using HSNXT;

namespace Mannex.Tests
{
    #region Imports

    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;
    using Xunit;

    #endregion

    public class ArrayTests
    {
        [Fact]
        public void ToHexFailsWithNullThis()
        {
            Assert.Throws<ArgumentNullException>(() =>
                Extensions.ToHex(null, 0, 0, new StringBuilder()));
        }

        [Fact]
        public void ToHexWithNullStringBuilderSuppliesOne()
        {
            Assert.NotNull(new byte[0].ToHex(0, 0, null));
        }

        [Fact]
        public void ToHexFailsWithInvalidRanges()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                new byte[] { 1, 2, 3 }.ToHex(-1, 0, new StringBuilder()));
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                new byte[] { 1, 2, 3 }.ToHex(4, 0, new StringBuilder()));
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                new byte[] { 1, 2, 3 }.ToHex(1, 3, new StringBuilder()));
        }

        [Fact]
        public void ToHex()
        {
            var result = Enumerable.Range(0, 256)
                                   .Select(n => (byte) n)
                                   .ToArray()
                                   .ToHex();

            Assert.Equal(
                "00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F 10 11 12 13 14 15 16 17 18 19 1A 1B 1C 1D 1E 1F 20 21 " +
                "22 23 24 25 26 27 28 29 2A 2B 2C 2D 2E 2F 30 31 32 33 34 35 36 37 38 39 3A 3B 3C 3D 3E 3F 40 41 42 43 " +
                "44 45 46 47 48 49 4A 4B 4C 4D 4E 4F 50 51 52 53 54 55 56 57 58 59 5A 5B 5C 5D 5E 5F 60 61 62 63 64 65 " +
                "66 67 68 69 6A 6B 6C 6D 6E 6F 70 71 72 73 74 75 76 77 78 79 7A 7B 7C 7D 7E 7F 80 81 82 83 84 85 86 87 " +
                "88 89 8A 8B 8C 8D 8E 8F 90 91 92 93 94 95 96 97 98 99 9A 9B 9C 9D 9E 9F A0 A1 A2 A3 A4 A5 A6 A7 A8 A9 " +
                "AA AB AC AD AE AF B0 B1 B2 B3 B4 B5 B6 B7 B8 B9 BA BB BC BD BE BF C0 C1 C2 C3 C4 C5 C6 C7 C8 C9 CA CB " +
                "CC CD CE CF D0 D1 D2 D3 D4 D5 D6 D7 D8 D9 DA DB DC DD DE DF E0 E1 E2 E3 E4 E5 E6 E7 E8 E9 EA EB EC ED " +
                "EE EF F0 F1 F2 F3 F4 F5 F6 F7 F8 F9 FA FB FC FD FE FF",
                        result);
        }

        [Fact]
        public void ToHexOnSubrange()
        {
            var result = Enumerable.Range(0, 256)
                                   .Select(n => (byte)n)
                                   .ToArray()
                                   .ToHex(10 * 16, 16);

            Assert.Equal("a0a1a2a3a4a5a6a7a8a9aaabacadaeaf", result);
        }

        [Fact]
        public void RotateFailsWithNullThis()
        {
            var e = Assert.Throws<ArgumentNullException>(() =>
                Extensions.Rotate<object>(null));
            Assert.Equal("array", e.ParamName);
        }

        [Fact]
        public void RotateEmptyArray()
        {
            var array = new object[0];
            array.Rotate();
            // no assertions; point is to test it does not fail
        }

        [Fact]
        public void Rotate()
        {
            var array = new [] { 1, 2, 3 };
            array.Rotate();
            Assert.Equal(new[] { 2, 3, 1 }, array);
        }

        [Fact]
        public void UpdateFailsWithNullThis()
        {
            ArgumentNullException e1, e2;

            e1 = Assert.Throws<ArgumentNullException>(() =>
                Extensions.Update<object, object>(null, new object[0], (t, s, i) => -1));
            Assert.Equal("target", e1.ParamName);

            e2 = Assert.Throws<ArgumentNullException>(() =>
                Extensions.Update<object, object>(null, new object[0], (t, s, i) => -1));
            Assert.Equal("target", e2.ParamName);
        }

        [Fact]
        public void UpdateFailsWithNullFunction()
        {
            ArgumentNullException e1, e2;

            e1 = Assert.Throws<ArgumentNullException>(() =>
                     new object[0].Update(new object[0], (Func<object, object, int, object>) null));
            Assert.Equal("function", e1.ParamName);

            e2 = Assert.Throws<ArgumentNullException>(() =>
                     new object[0].Update(new object[0], (Func<object, object, object>) null));
            Assert.Equal("function", e2.ParamName);
        }

        [Fact]
        public void UpdateFailsWithNullSource()
        {
            ArgumentNullException e1, e2;

            e1 = Assert.Throws<ArgumentNullException>(() =>
                     new object[0].Update((object[]) null, (t, s, i) => null));
            Assert.Equal("source", e1.ParamName);

            e2 = Assert.Throws<ArgumentNullException>(() =>
                     new object[0].Update((object[]) null, (t, s) => null));
            Assert.Equal("source", e2.ParamName);
        }

        [Fact]
        public void Update()
        {
            var xs = new[] { 4, 5, 6 };
            var ys = new[] { 7, 8, 9 };
            xs.Update(ys, (x, y, i) => (i + 1) * 100 + x * 10 + y);
            Assert.Equal(new[] { 147, 258, 369 }, xs);
        }

        [Fact]
        public void UpdateShort()
        {
            var xs = new[] { 4, 5,   };
            var ys = new[] { 7, 8, 9 };
            xs.Update(ys, (x, y, i) => (i + 1) * 100 + x * 10 + y);
            Assert.Equal(new[] { 147, 258 }, xs);
        }

        [Fact]
        public void UpdateLong()
        {
            var xs = new[] { 4, 5, 6 };
            var ys = new[] { 7, 8,   };
            xs.Update(ys, (x, y, i) => (i + 1) * 100 + x * 10 + y);
            Assert.Equal(new[] { 147, 258, 6 }, xs);
        }

        [Fact]
        public void RemoveFailsWithNullThis()
        {
            var e = Assert.Throws<ArgumentNullException>(() =>
                Extensions.Remove((int[])null, 0));
            Assert.Equal("array", e.ParamName);
        }

        [Fact]
        public void RemoveWhenNonExistingReturnsOriginal()
        {
            var ns = new[] { 1, 2, 3 };
            Assert.True(ReferenceEquals(ns, ns.Remove(42)));
        }

        [Fact]
        public void Remove()
        {
            var ns = new[] { 123, 456, 789 };
            Assert.Equal(new[] { 456, 789 }, ns.Remove(123));
            Assert.Equal(new[] { 123, 789 }, ns.Remove(456));
            Assert.Equal(new[] { 123, 456 }, ns.Remove(789));
        }

        [Fact]
        public void RemoveRemovesFirstOccurenceOnly()
        {
            var ns = new[] { 123, 456, 789,
                             123, 456, 789 };
            Assert.Equal(new[] { 123,      789,
                                 123, 456, 789 }, ns.Remove(456));
        }

        [Fact]
        public void RemoveUsingComparer()
        {
            const string foo = "foo";
            const string bar = "bar";
            const string baz = "baz";
            var ns = new[] { foo, bar, baz };
            var comparer = StringComparer.OrdinalIgnoreCase;
            Assert.Equal(new[] { bar, baz }, ns.Remove("FoO", comparer));
            Assert.Equal(new[] { foo, baz }, ns.Remove("bAr", comparer));
            Assert.Equal(new[] { foo, bar }, ns.Remove("BAZ", comparer));
        }

        [Fact]
        public void RemoveUsingComparerRemovesFirstOccurenceOnly()
        {
            var ns = new[] { "foo", "bar", "baz",
                             "foo", "bar", "baz" };
            var comparer = StringComparer.OrdinalIgnoreCase;
            Assert.Equal(new[] { "foo",        "baz",
                                 "foo", "bar", "baz" }, ns.Remove("BaR", comparer));
        }

        [Fact]
        public void PartitionFailsWithNullThis()
        {
            var e = Assert.Throws<ArgumentNullException>(() =>
                Extensions.Partition<object, object>(null, 0, delegate { return null; }));
            Assert.Equal("array", e.ParamName);
        }

        [Fact]
        public void PartitionFailsWithNullSelector()
        {
            var e = Assert.Throws<ArgumentNullException>(() =>
                new object[0].Partition<object, object>(0, null));
            Assert.Equal("selector", e.ParamName);
        }

        [Fact]
        public void PartitionFailsWithNegativeIndex()
        {
            const int minus1 = -1;
            var e = Assert.Throws<ArgumentOutOfRangeException>(() =>
                new object[0].Partition(minus1, (lhs, rhs) => new { Left = lhs, Right = rhs }));
            Assert.Equal("index", e.ParamName);
            Assert.Equal(minus1, e.ActualValue);
        }

        [Theory]
        [InlineData(0, new int[0], new int[0], new int[0])]
        [InlineData(1, new int[0], new int[0], new int[0])]
        [InlineData(2, new int[0], new int[0], new int[0])]
        [InlineData(0, new[] { 1, 2, 3, 4, 5 }, new int[0], new[] { 1, 2, 3, 4, 5 })]
        [InlineData(1, new[] { 1, 2, 3, 4, 5 }, new[] { 1 }, new[] { 2, 3, 4, 5 })]
        [InlineData(2, new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2 }, new[] { 3, 4, 5 })]
        [InlineData(3, new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3 }, new[] { 4, 5 })]
        [InlineData(4, new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4 }, new[] { 5 })]
        [InlineData(5, new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5 }, new int[0])]
        [InlineData(6, new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5 }, new int[0])]
        public void Partition(int index, int[] array, int[] left, int[] right)
        {
            var result = array.Partition(index, (lhs, rhs) => new { Left = lhs, Right = rhs });
            Assert.Equal(left, result.Left);
            Assert.Equal(right, result.Right);
        }

        [Fact]
        public void PartitionStrictlyFailsWithNullThis()
        {
            var e = Assert.Throws<ArgumentNullException>(() =>
                Extensions.PartitionStrictly<object, object>(null, 0, delegate { return null; }));
            Assert.Equal("array", e.ParamName);
        }

        [Fact]
        public void PartitionStrictlyFailsWithNullSelector()
        {
            var e = Assert.Throws<ArgumentNullException>(() =>
                new object[0].PartitionStrictly<object, object>(0, null));
            Assert.Equal("selector", e.ParamName);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(1)]
        public void PartitionStrictlyFailsWithOutOfBoundIndex(int index)
        {
            var e = Assert.Throws<ArgumentOutOfRangeException>(() =>
                new object[0].PartitionStrictly(index, (lhs, rhs) => new { Left = lhs, Right = rhs }));
            Assert.Equal("index", e.ParamName);
            Assert.Equal(index, e.ActualValue);
        }

        [Theory]
        [InlineData(0, new int[0], new int[0], new int[0])]
        [InlineData(0, new[] { 1, 2, 3, 4, 5 }, new int[0], new[] { 1, 2, 3, 4, 5 })]
        [InlineData(1, new[] { 1, 2, 3, 4, 5 }, new[] { 1 }, new[] { 2, 3, 4, 5 })]
        [InlineData(2, new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2 }, new[] { 3, 4, 5 })]
        [InlineData(3, new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3 }, new[] { 4, 5 })]
        [InlineData(4, new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4 }, new[] { 5 })]
        [InlineData(5, new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5 }, new int[0])]
        public void PartitionStrictly(int index, int[] array, int[] left, int[] right)
        {
            var result = array.PartitionStrictly(index, (lhs, rhs) => new { Left = lhs, Right = rhs });
            Assert.Equal(left, result.Left);
            Assert.Equal(right, result.Right);
        }
    }
}