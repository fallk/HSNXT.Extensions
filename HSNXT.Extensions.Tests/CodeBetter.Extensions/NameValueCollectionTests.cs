namespace CodeBetter.Extensions.Tests
{
    using System.Collections.Specialized;
    using NUnit.Framework;
    using HSNXT;

    [TestFixture]
    public class NameValueCollectionTests
    {
        [Test]
        [SetCulture("en-US")]
        public void GetDouble()
        {
            var nvc = new NameValueCollection {{"Value", "1.2"}};
            Assert.AreEqual(1.2, nvc.GetDouble("Value"));
        }

        [Test]
        [SetCulture("en-US")]
        public void GetFloat()
        {
            var nvc = new NameValueCollection {{"Value", "1.2"}};
            Assert.AreEqual(1.2f, nvc.GetFloat("Value"));
        }

        [Test]
        public void GetInt()
        {
            var nvc = new NameValueCollection {{"Value", "2"}};
            Assert.AreEqual(2, nvc.GetInt("Value"));
        }

        [Test]
        public void GetBoolean()
        {
            var nvc = new NameValueCollection {{"Value", "true"}};
            Assert.IsTrue(nvc.GetBoolean("Value"));
        }
    }
}