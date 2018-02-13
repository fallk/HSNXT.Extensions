using NUnit.Framework;
using HSNXT;

namespace Tests
{
    [TestFixture]
    public class when_comparing_versions
    {
        [Test]
        public void then_earlier_version_compared_as_earlier_correctly()
        {
            Assert.IsTrue(Extensions.WindowsVistaVersion.IsEarlierThan(Extensions.Windows8Version));
        }

        [Test]
        public void then_laster_version_compared_as_earlier_fails()
        {
            Assert.IsFalse(Extensions.Windows8Version.IsEarlierThan(Extensions.WindowsVistaVersion));
        }

        [Test]
        public void then_later_version_compared_as_later_correctly()
        {
            Assert.IsTrue(Extensions.Windows8Version.IsLaterThan(Extensions.WindowsVistaVersion));
        }

        [Test]
        public void then_ealier_version_compared_as_later_fails()
        {
            Assert.IsFalse(Extensions.WindowsVistaVersion.IsLaterThan(Extensions.Windows8Version));
        }

        [Test]
        public void then_older_version_compared_as_older_correctly()
        {
            Assert.IsTrue(Extensions.WindowsVistaVersion.IsOlderThan(Extensions.Windows8Version));
        }

        [Test]
        public void then_newer_version_compared_as_older_fails()
        {
            Assert.IsFalse(Extensions.Windows8Version.IsOlderThan(Extensions.WindowsVistaVersion));
        }

        [Test]
        public void then_newer_version_compared_as_newer_correctly()
        {
            Assert.IsTrue(Extensions.Windows8Version.IsNewerThan(Extensions.WindowsVistaVersion));
        }

        [Test]
        public void then_older_version_compared_as_newer_correctly()
        {
            Assert.IsFalse(Extensions.WindowsVistaVersion.IsNewerThan(Extensions.Windows8Version));
        }

        [Test]
        public void then_version_between_others_compares_correctly()
        {
            Assert.IsTrue(
                Extensions.WindowsVistaVersion.IsBetween(Extensions.Windows95Version, Extensions.Windows8Version));
        }

        [Test]
        public void then_version_not_between_others_fails()
        {
            Assert.IsFalse(Extensions.Windows95Version.IsBetween(Extensions.WindowsVistaVersion,
                Extensions.Windows8Version));
        }
    }
}