namespace CodeBetter.Extensions.Tests
{
   using System;
   using NUnit.Framework;
   using HSNXT;

   [TestFixture]
   public class IntDateTests
   {
      [Test]
      public void IsLeapYear_ReturnsTrueForLeapYearAndFalseOtherwise()
      {
         Assert.IsTrue(1804.IsLeapYear());
         Assert.IsTrue(2392.IsLeapYear());
         Assert.IsTrue(400.IsLeapYear());
         Assert.IsFalse(1.IsLeapYear());
         Assert.IsFalse(100.IsLeapYear());
      }

      [Test]
      public void Days()
      {
         Assert.AreEqual(2592000000, 30.Days().TotalMilliseconds);
      }
      [Test]
      public void Hours()
      {
         Assert.AreEqual(72000000, 20.Hours().TotalMilliseconds);
      }
      [Test]
      public void Minutes()
      {
         Assert.AreEqual(600000, 10.Minutes().TotalMilliseconds);
      }
      [Test]
      public void Seconds()
      {
         Assert.AreEqual(5000, 5.Seconds().TotalMilliseconds);
      }
   }
}