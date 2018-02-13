namespace CodeBetter.Extensions.Tests
{
    using NUnit.Framework;
    using Extensions;
    using HSNXT;

    [TestFixture]
    public class StringParserTests
    {
        [Test]
        public void ToInt()
        {
            Assert.AreEqual(1234, "1234".ToInt());
            Assert.AreEqual(-1234, "-1234".ToInt());
        }

        [Test]
        public void ToBoolean()
        {
            Assert.IsTrue("1".ToBoolean());
            Assert.IsTrue("true".ToBoolean());
            Assert.IsFalse("0".ToBoolean());
            Assert.IsFalse("false".ToBoolean());
        }

        [Test]
        public void ExtractInt_ReturnsPositiveIntegers()
        {
            Assert.AreEqual(1, "1".ExtractInt());
            Assert.AreEqual(1, "1a".ExtractInt());
            Assert.AreEqual(234, " 234abbk399a".ExtractInt());
        }

        [Test]
        public void ExtractInt_ReturnsNegativeIntegers()
        {
            Assert.AreEqual(-1, "-1".ExtractInt());
            Assert.AreEqual(-1, "-1a".ExtractInt());
            Assert.AreEqual(-234, " -234abbk399a".ExtractInt());
        }

        [Test]
        public void TryExtractInt_ReturnsTrueOnSuccess()
        {
            int x;
            Assert.IsTrue("-3233".TryExtractInt(out x));
            Assert.AreEqual(-3233, x);
        }

        [Test]
        public void TryExtractInt_ReturnsFalseOnFailure()
        {
            int x;
            Assert.IsFalse("-af3233".TryExtractInt(out x));
        }

        [Test]
        [SetCulture("en-US")]
        public void ToDouble()
        {
            Assert.AreEqual(9000.1d, "9000.1".ToDouble());
            Assert.AreEqual(-9000.1d, "-9000.1".ToDouble());
        }

        [Test]
        [SetCulture("en-US")]
        public void ToFloat()
        {
            Assert.AreEqual(9000.1f, "9000.1".ToFloat());
            Assert.AreEqual(-9000.1f, "-9000.1".ToFloat());
        }
    }
}