using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HSNXT;
using HSNXT.dotNetExt;

namespace TestProject
{
    [TestClass]
    public class IComparableExtensionsTest
    {
        [TestMethod]
        public void IComparable_InRange_001()
        {
            var source = 3;
            var min = 1;
            var max = 5;
            var actual = source.InRange<int>(min, max);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IComparable_InRange_002()
        {
            var source = 3;
            var min = 3;
            var max = 5;
            var actual = source.InRange(min, max);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IComparable_InRange_003()
        {
            var source = 3;
            var min = 1;
            var max = 3;
            var actual = source.InRange(min, max);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IComparable_InRange_004()
        {
            var source = 3;
            var min = 4;
            var max = 5;
            var actual = source.InRange(min, max);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void IComparable_InRange_005()
        {
            var source = 3;
            var min = -4;
            var max = -1;
            var actual = source.InRange(min, max);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void IComparable_Int_InRange_001()
        {
            var actual = 3.InRange(1, 5);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IComparable_Int_InRange_002()
        {
            var actual = 3.InRange(3, 5);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IComparable_Int_InRange_003()
        {
            var actual = 3.InRange(1, 3);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IComparable_Int_InRange_004()
        {
            var actual = 3.InRange(4, 5);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void IComparable_Int_InRange_005()
        {
            var actual = 3.InRange(-4, -1);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void IComparable_Double_InRange_001()
        {
            var actual = ((double) 3).InRange(1, 5);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IComparable_Double_InRange_002()
        {
            var actual = ((double) 3).InRange(3, 5);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IComparable_Double_InRange_003()
        {
            var actual = ((double) 3).InRange(1, 3);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IComparable_Double_InRange_004()
        {
            var actual = ((double) 3).InRange(4, 5);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void IComparable_Double_InRange_005()
        {
            var actual = ((double) 3).InRange(-4, -1);
            Assert.IsFalse(actual);
        }
    }
}