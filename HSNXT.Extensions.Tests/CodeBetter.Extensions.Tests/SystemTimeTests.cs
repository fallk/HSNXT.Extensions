namespace CodeBetter.Extensions.Tests
{
   using System;
   using System.Threading;
   using NUnit.Framework;

   [TestFixture]
   public class SystemTimeTests
   {
      [SetUp]
      public void SetUp()
      {
         SystemTime.ResetNow();
      }

      [Test(Description = "Doesn't really test what it's supposed to")]
      public void Now_ReturnsCurrentDateTime()
      {
         DateTime old = SystemTime.Now();
         Thread.Sleep(10);
         Assert.Less(old, SystemTime.Now());
      }

      [Test]
      public void Now_ReturnsSetTime()
      {
         DateTime date = new DateTime(2004, 01, 01);
         SystemTime.Now = () => date;
         Assert.AreEqual(date, SystemTime.Now());
      }

      [Test]
      public void ResetNow()
      {
         DateTime date = new DateTime(2004, 01, 01);
         SystemTime.Now = () => date;
         SystemTime.ResetNow();
         Assert.Greater(SystemTime.Now(), date);
      }
   }
}
