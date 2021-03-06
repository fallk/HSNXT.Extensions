﻿using System.Collections.Generic;
using HSNXT;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevLib.ExtensionMethods.UnitTest
{
    /// <summary>
    ///This is a test class for Given_StringExtensions and is intended
    ///to contain all Given_StringExtensions Unit Tests
    ///</summary>
    [TestClass]
    public class GivenStringExtensions
    {
        private TestContext _testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get { return _testContextInstance; }
            set { _testContextInstance = value; }
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
        /// A test for JoinBy
        ///</summary>
        [TestMethod]
        public void When_JoinBy()
        {
            IEnumerable<string> source = new List<string> {"a", "bc", "def", "ghij"};
            var expected = "a,bc,def,ghij";
            string actual;
            actual = source.JoinBy(",");

            Assert.AreEqual(expected, actual);
        }
    }
}