using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HSNXT;

namespace HSNXT.Nardax.Tests
{
    [TestClass]
    public class AsseblyExtensionsTests
    {
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GetAppSettingsValue_InvalidKey_ThrowsException()
        {
            var invalidKey = "InvalidSetting";

            var assembly = Assembly.GetExecutingAssembly();
            assembly.GetAppSettingsValue(invalidKey);

            Assert.Fail();
        }
    }
}