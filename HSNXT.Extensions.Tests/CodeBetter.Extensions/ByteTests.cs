namespace CodeBetter.Extensions.Tests
{
    using NUnit.Framework;
    using HSNXT;

    [TestFixture]
    public class ByteTests
    {
        [Test]
        public void ByteArrayToHex()
        {
            Assert.AreEqual("32 37 17", new byte[] {50, 55, 23}.ToHex());
        }

        [Test]
        public void ToHex()
        {
            Assert.AreEqual("01", ((byte) 1).ToHex());
        }
    }
}