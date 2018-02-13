using System;
using System.Globalization;
using FluentAssertions;
using HSNXT;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProjTest.aHSNXT
{
    [TestClass]
    public class Class1
    {
        [TestMethod]
        public void GetDateTimeFormatsInvariant()
        {
            var now = DateTime.Now;
            now.GetDateTimeFormats(CultureInfo.InvariantCulture).ShouldBeEquivalentTo(now.GetDateTimeFormatsInvariant());
        }

        [TestMethod]
        public void GetDateTimeFormatsInvariant2()
        {
            var chars = new[] {'d', 'D', 'f', 'F', 'g', 'G', 'm', 'o', 'r', 's', 't', 'T', 'u', 'U', 'y'};
            foreach (var c in chars)
            {
                var now = DateTime.Now;
                now.GetDateTimeFormats(c, CultureInfo.InvariantCulture).ShouldBeEquivalentTo(now.GetDateTimeFormatsInvariant(c));
            }
        }
    }
}