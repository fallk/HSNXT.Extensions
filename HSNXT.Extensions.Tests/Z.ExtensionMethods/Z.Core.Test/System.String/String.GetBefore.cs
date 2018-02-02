// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HSNXT.Z.Core.Test
{
    [TestClass]
    public class System_String_GetBefore
    {
        [TestMethod]
        public void GetBefore()
        {
            // Type
            var @this = "Fizz";

            // Examples
            var result1 = @this.GetBefore("i"); // return "F";
            var result2 = @this.GetBefore("a"); // return "";

            // Unit Test
            Assert.AreEqual("F", result1);
            Assert.AreEqual("", result2);
        }
    }
}