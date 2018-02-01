using System.Collections;
using System.Drawing;
using HSNXT;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevLib.ExtensionMethods.UnitTest
{
    /// <summary>
    ///This is a test class for Given_ByteExtensions and is intended
    ///to contain all Given_ByteExtensions Unit Tests
    ///</summary>
    [TestClass]
    public class GivenByteExtensions
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
        ///A test for BitStringToBitArray
        ///</summary>
        [TestMethod]
        public void When_BitStringToBitArray()
        {
            var source = "0101";
            var expected = new BitArray(new[] { false, true, false, true });
            BitArray actual;
            actual = source.BitStringToBitArray();

            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Compress
        ///</summary>
        [TestMethod]
        public void When_Compress()
        {
            var source = "hello".ToByteArray();
            var expected = source.Compress().Decompress();
            var actual = source;

            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Decompress
        ///</summary>
        [TestMethod]
        public void When_Decompress()
        {
            var source = "hello".ToByteArray();
            var expected = source.Compress().Decompress();
            var actual = source;

            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for HexToByteArray
        ///</summary>
        [TestMethod]
        public void When_HexToByteArray()
        {
            var source = "00FF";
            byte[] expected = { 0, 255 };
            byte[] actual;
            actual = source.HexToByteArray();

            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ToBitArray
        ///</summary>
        [TestMethod]
        public void When_ToBitArray()
        {
            byte[] source = { 0, 0 };
            var expected = new BitArray(16, false);
            BitArray actual;
            actual = source.ToBitArray();

            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ToBitArray
        ///</summary>
        [TestMethod]
        public void When_ToBitArray1()
        {
            var source = 0;
            var expected = new BitArray(32, false);
            BitArray actual;
            actual = source.ToBitArray();

            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ToBitArray
        ///</summary>
        [TestMethod]
        public void When_ToBitArray2()
        {
            byte source = 0;
            var expected = new BitArray(8, false);
            BitArray actual;
            actual = source.ToBitArray();

            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ToBitIntArray
        ///</summary>
        [TestMethod]
        public void When_ToBitIntArray()
        {
            var source = "11".BitStringToBitArray();
            int[] expected = { 3, 0 };
            int[] actual;
            actual = source.ToBitIntArray();

            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ToBitString
        ///</summary>
        [TestMethod]
        public void When_ToBitString()
        {
            var source = new BitArray(8, true);
            var expected = "11111111";
            string actual;
            actual = source.ToBitString();

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ToBoolArray
        ///</summary>
        [TestMethod]
        public void When_ToBoolArray()
        {
            var source = new BitArray(8, true);
            bool[] expected = { true, true, true, true, true, true, true, true };
            bool[] actual;
            actual = source.ToBoolArray();

            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ToByteArray
        ///</summary>
        [TestMethod]
        public void When_ToByteArray()
        {
            var source = new BitArray(8, false);
            byte[] expected = { 0 };
            byte[] actual;
            actual = source.ToByteArray();

            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ToEncodingString
        ///</summary>
        [TestMethod]
        public void When_ToEncodingString()
        {
            var source = "hello".ToByteArray();
            var expected = "hello";
            string actual;
            actual = source.ToEncodingString();

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ToHexString
        ///</summary>
        [TestMethod]
        public void When_ToHexString()
        {
            byte source = 255;
            var expected = "FF";
            string actual;
            actual = source.ToHexString();

            Assert.AreEqual(expected, actual, true);
        }

        /// <summary>
        ///A test for ToHexString
        ///</summary>
        [TestMethod]
        public void When_ToHexString1()
        {
            byte[] source = { 0, 255, 255, 0 };
            const string expected = "00-FF-FF-00";
            string actual;
            actual = source.ToHexString('-');

            Assert.AreEqual(expected, actual, true);
        }

        /// <summary>
        ///A test for ToImage
        ///</summary>
        [TestMethod]
        public void When_ToImage()
        {
            var expected = DrawFilledRectangle(Brushes.Blue, 100, 100);
            var source = expected.ImageToByteArray();
            Bitmap actual;
            actual = (Bitmap)source.ToImage();

            for (var i = 0; i < 100; i++)
            {
                for (var j = 0; j < 100; j++)
                {
                    Assert.AreEqual(expected.GetPixel(i, j), actual.GetPixel(i, j));
                }
            }
        }

        private Bitmap DrawFilledRectangle(Brush brush, int width, int height)
        {
            var result = new Bitmap(width, height);

            using (var graph = Graphics.FromImage(result))
            {
                var imageSize = new Rectangle(0, 0, width, height);
                graph.FillRectangle(brush, imageSize);
            }

            return result;
        }
    }
}
