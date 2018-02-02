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
    public class System_Object_ToInt32OrDefault
    {
        [TestMethod]
        public void ToInt32OrDefault()
        {
            // Type
            var @thisValid = "32";
            var @thisInvalid = "FizzBuzz";

            // Exemples
            var result1 = @thisValid.ToInt32OrDefault(); // return 32;
            var result2 = @thisInvalid.ToInt32OrDefault(); // return 0;
            var result3 = @thisInvalid.ToInt32OrDefault(-1); // return -1;
            var result4 = @thisInvalid.ToInt32OrDefault(() => -2); // return -2;

            // Unit Test
            Assert.AreEqual(32, result1);
            Assert.AreEqual(0, result2);
            Assert.AreEqual(-1, result3);
            Assert.AreEqual(-2, result4);
        }
    }
}