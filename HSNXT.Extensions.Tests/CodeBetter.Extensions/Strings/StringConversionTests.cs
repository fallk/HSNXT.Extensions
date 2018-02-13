namespace CodeBetter.Extensions.Tests
{
    using NUnit.Framework;
    using HSNXT;

    [TestFixture]
    public class StringConversionTests
    {
        [Test]
        public void EncodeUrl()
        {
            Assert.AreEqual("hello+world%2c+how%27s+life%3f", "hello world, how's life?".EncodeUrl());
        }

        [Test]
        public void DecodeUrl()
        {
            Assert.AreEqual("hello world, how's life?", "hello+world%2c+how's+life%3f".DecodeUrl());
        }

        [Test]
        public void EncodeHtml()
        {
            Assert.AreEqual("he said &quot;life is like a box of &lt;i&gt;jello!&lt;/i&gt;",
                "he said \"life is like a box of <i>jello!</i>".EncodeHtml());
        }

        [Test]
        public void DecodeHtml()
        {
            Assert.AreEqual("he said \"life is like a box of <i>jello!</i>",
                "he said &quot;life is like a box of &lt;i&gt;jello!&lt;/i&gt;".DecodeHtml());
        }

        [Test]
        public void EncodeBase64()
        {
            Assert.AreEqual("aXQncyBvdmVyIDkwMDA=", "it's over 9000".EncodeBase64());
        }

        [Test]
        public void EncodeBase64_WithEncoding()
        {
            Assert.AreEqual("aXQncyBvdmVyIDkwMDA=", "it's over 9000".EncodeBase64(EncodingType.Ascii));
            Assert.AreEqual("aXQncyBvdmVyIDkwMDA=", "it's over 9000".EncodeBase64(EncodingType.Utf7));
            Assert.AreEqual("aXQncyBvdmVyIDkwMDA=", "it's over 9000".EncodeBase64(EncodingType.Utf8));
            Assert.AreEqual("aXQncyBvdmVyIDkwMDA=", "it's over 9000".EncodeBase64(EncodingType.Default));
            Assert.AreEqual("aQB0ACcAcwAgAG8AdgBlAHIAIAA5ADAAMAAwAA==",
                "it's over 9000".EncodeBase64(EncodingType.Unicode));
        }

        [Test]
        public void DecodeBase64()
        {
            Assert.AreEqual("it's over 9000", "aXQncyBvdmVyIDkwMDA=".DecodeBase64());
        }

        [Test]
        public void DecodeBase64_WithEncoding()
        {
            Assert.AreEqual("it's over 9000", "aXQncyBvdmVyIDkwMDA=".DecodeBase64(EncodingType.Ascii));
            Assert.AreEqual("it's over 9000", "aXQncyBvdmVyIDkwMDA=".DecodeBase64(EncodingType.Utf7));
            Assert.AreEqual("it's over 9000", "aXQncyBvdmVyIDkwMDA=".DecodeBase64(EncodingType.Utf8));
            Assert.AreEqual("it's over 9000", "aXQncyBvdmVyIDkwMDA=".DecodeBase64(EncodingType.Default));
            Assert.AreEqual("it's over 9000",
                "aQB0ACcAcwAgAG8AdgBlAHIAIAA5ADAAMAAwAA==".DecodeBase64(EncodingType.Unicode));
        }

        [Test]
        public void EncodeMd5()
        {
            Assert.AreEqual("8fde489eb64699a3a54885782377de10",
                "it's over 9000".EncodeMd5().Replace(" ", "").ToLowerInvariant());
        }

        [Test]
        public void EncodeMd5_WithEncoding()
        {
            Assert.AreEqual("8aeef8fb4b2a64332229b4561dc53e96",
                "it's over 9000".EncodeMd5(EncodingType.Unicode).Replace(" ", "").ToLowerInvariant());
        }

        [Test]
        public void EncodeSha1()
        {
            Assert.AreEqual("c9ca98ba13bd8b4d1872275cc2b411a788ccef69",
                "it's over 9000".EncodeSha1().Replace(" ", "").ToLowerInvariant());
        }

        [Test]
        public void EncodeSha1_WithEncoding()
        {
            Assert.AreEqual("eb87c9250245db7692b78eaaf1d89df01e4b0723",
                "it's over 9000".EncodeSha1(EncodingType.Unicode).Replace(" ", "").ToLowerInvariant());
        }

        [Test]
        public void ToBytes()
        {
            var normal = new byte[] {105, 116, 39, 115, 32, 111, 118, 101, 114, 32, 57, 48, 48, 48};
            Assert.AreEqual(normal, "it's over 9000".GetBytes());
        }

        [Test]
        public void ToBytes_WithEncoding()
        {
            var normal = new byte[] {105, 116, 39, 115, 32, 111, 118, 101, 114, 32, 57, 48, 48, 48};
            Assert.AreEqual(normal, "it's over 9000".GetBytes());
        }
    }
}