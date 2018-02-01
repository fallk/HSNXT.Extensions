using HSNXT;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevLib.ExtensionMethods.UnitTest
{
    /// <summary>
    ///This is a test class for Given_BoolExtensions and is intended
    ///to contain all Given_BoolExtensions Unit Tests
    ///</summary>
    [TestClass]
    public class Given_BoolExtensions
    {
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

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
        ///A test for BitIntToBool
        ///</summary>
        [TestMethod]
        public void When_BitIntToBool()
        {
            var source = 0; // TODO: Initialize to an appropriate value
            var expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = source.BitIntToBool();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for BitStringToBool
        ///</summary>
        [TestMethod]
        public void When_BitStringToBool()
        {
            var source = "1";
            var expected = true;
            bool actual;
            actual = source.BitStringToBool();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for IfFalse
        ///</summary>
        [TestMethod]
        public void When_IfFalse()
        {
            var source = false;
            var expected = false;
            bool actual;
            actual = source.IfFalse(() => Assert.AreEqual(expected, source));
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for IfTrue
        ///</summary>
        [TestMethod]
        public void When_IfTrue()
        {
            var source = true;
            var expected = true;
            bool actual;
            actual = source.IfTrue(() => Assert.AreEqual(expected, source));
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ToBitInt
        ///</summary>
        [TestMethod]
        public void When_ToBitInt()
        {
            var source = false;
            var expected = 0;
            int actual;
            actual = source.ToBitInt();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ToBitString
        ///</summary>
        [TestMethod]
        public void When_ToBitString()
        {
            var source = true;
            var expected = "1";
            string actual;
            actual = source.ToBitString();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ToYesNoString
        ///</summary>
        [TestMethod]
        public void When_ToYesNoString()
        {
            var source = false;
            var expected = "No";
            string actual;
            actual = source.ToYesNoString();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for YesNoToBool
        ///</summary>
        [TestMethod]
        public void When_YesNoToBool()
        {
            var source = "Yes";
            var ignoreCase = false;
            var expected = true;
            bool actual;
            actual = source.YesNoToBool(ignoreCase);
            Assert.AreEqual(expected, actual);
        }
    }
}
