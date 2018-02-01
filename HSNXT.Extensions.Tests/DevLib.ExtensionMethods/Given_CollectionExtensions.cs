using System;
using System.Collections.Generic;
using System.Linq;
using HSNXT;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevLib.ExtensionMethods.UnitTest
{
    /// <summary>
    ///This is a test class for Given_CollectionExtensions and is intended
    ///to contain all Given_CollectionExtensions Unit Tests
    ///</summary>
    [TestClass]
    public class GivenCollectionExtensions
    {
        private TestContext _testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return _testContextInstance;
            }
            set
            {
                _testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        /// <summary>
        ///A test for FindAllIndex
        ///</summary>
        [TestMethod]
        public void When_FindAllIndex()
        {
            var source = "abcdefgabcdefg";
            var expected = new List<int> { 0, 5, 7, 12 };
            List<int> actual;
            actual = source.FindAllIndex(i => i == 'a' || i == 'f');

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void When_FindAllIndex1()
        {
            var source = new List<string> { "abc", "def", "ghi", "abcde" };
            var expected = new List<int> { 0, 3 };
            List<int> actual;
            actual = source.FindAllIndex(i => i.Contains("a"));

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void When_ForEach()
        {
            var source = new Dictionary<int, string>();
            source.Add(1, "a");
            source.Add(2, "B");

            source.ForEach((k, v) =>
            {
                Assert.IsInstanceOfType(k, typeof(int));
                Assert.IsInstanceOfType(v, typeof(string));
            });
        }

        /// <summary>
        ///A test for GetEnumerableElementType
        ///</summary>
        [TestMethod]
        public void When_GetEnumerableElementType()
        {
            var source = typeof(List<DateTime>);
            var expected = typeof(DateTime);
            Type actual;
            actual = source.GetEnumerableElementType();

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetEnumerableElementType
        ///</summary>
        [TestMethod]
        public void When_GetEnumerableElementType1()
        {
            var source = typeof(char[]);
            var expected = typeof(char);
            Type actual;
            actual = source.GetEnumerableElementType();

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for IsDictionary
        ///</summary>
        [TestMethod]
        public void When_IsDictionary()
        {
            var source = typeof(SortedDictionary<string, string>);
            const bool expected = true;
            var actual = source.IsDictionary();

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for IsEnumerable
        ///</summary>
        [TestMethod]
        public void When_IsEnumerable()
        {
            var source = typeof(LinkedList<int>);
            var expected = true;
            bool actual;
            actual = source.IsEnumerable();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void When_IsNotNullNorEmpty()
        {
            List<string> source = null;
            var expected = false;
            bool actual;
            actual = source.IsNotNullNorEmpty();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void When_IsNullOrEmpty()
        {
            List<string> source = null;
            var expected = true;
            bool actual;
            actual = source.IsNullOrEmpty();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void When_EmptyIfNull()
        {
            List<string> source = null;
            var expected = Enumerable.Empty<string>();
            var actual = source.EmptyIfNull();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void When_SplitByEndsWith()
        {
        }

        [TestMethod]
        public void When_SplitByStartsWith()
        {
        }

        [TestMethod]
        public void When_Update()
        {
            var source = new Dictionary<int, string> {{1, "a"}, {2, "b"}};

            var expected = "c";
            source.Update(2, "c");
            var actual=source[2];

            Assert.AreEqual(expected, actual);
        }
    }
}
