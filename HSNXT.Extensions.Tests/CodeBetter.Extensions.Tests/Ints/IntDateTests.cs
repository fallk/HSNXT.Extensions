namespace CodeBetter.Extensions.Tests
{
   using System;
   using NUnit.Framework;

   [TestFixture]
   public class IntDateTests
   {
      [SetUp]
      public void SetUp()
      {
         SystemTime.Now = () => new DateTime(2004, 01, 01);
      }
      [TearDown]
      public void TearDown()
      {
         SystemTime.ResetNow();
      }
     
      [Test]
      public void YearsAgo()
      {
         Assert.AreEqual(SystemTime.Now().AddYears(-4), 4.YearsAgo());
         Assert.AreEqual(SystemTime.Now().AddYears(2), (-2).YearsAgo());
      }
      [Test]
      public void MonthsAgo()
      {
         Assert.AreEqual(SystemTime.Now().AddMonths(-4), 4.MonthsAgo());
         Assert.AreEqual(SystemTime.Now().AddMonths(2), (-2).MonthsAgo());
      }
      [Test]
      public void DaysAgo()
      {
         Assert.AreEqual(SystemTime.Now().AddDays(-4), 4.DaysAgo());
         Assert.AreEqual(SystemTime.Now().AddDays(2), (-2).DaysAgo());
      }
      [Test]
      public void HoursAgo()
      {
         Assert.AreEqual(SystemTime.Now().AddHours(-4), 4.HoursAgo());
         Assert.AreEqual(SystemTime.Now().AddHours(2), (-2).HoursAgo());
      }
      [Test]
      public void MinutesAgo()
      {
         Assert.AreEqual(SystemTime.Now().AddMinutes(-4), 4.MinutesAgo());
         Assert.AreEqual(SystemTime.Now().AddMinutes(2), (-2).MinutesAgo());
      }
      [Test]
      public void SecondsAgo()
      {
         Assert.AreEqual(SystemTime.Now().AddSeconds(-4), 4.SecondsAgo());
         Assert.AreEqual(SystemTime.Now().AddSeconds(2), (-2).SecondsAgo());
      }
      
      [Test]
      public void YearsFromNow()
      {
         Assert.AreEqual(SystemTime.Now().AddYears(4), 4.YearsFromNow());
         Assert.AreEqual(SystemTime.Now().AddYears(2), (2).YearsFromNow());
      }
      [Test]
      public void MonthsFromNow()
      {
         Assert.AreEqual(SystemTime.Now().AddMonths(4), 4.MonthsFromNow());
         Assert.AreEqual(SystemTime.Now().AddMonths(2), (2).MonthsFromNow());
      }
      [Test]
      public void DaysFromNow()
      {
         Assert.AreEqual(SystemTime.Now().AddDays(4), 4.DaysFromNow());
         Assert.AreEqual(SystemTime.Now().AddDays(2), (2).DaysFromNow());
      }
      [Test]
      public void HoursFromNow()
      {
         Assert.AreEqual(SystemTime.Now().AddHours(4), 4.HoursFromNow());
         Assert.AreEqual(SystemTime.Now().AddHours(2), (2).HoursFromNow());
      }
      [Test]
      public void MinutesFromNow()
      {
         Assert.AreEqual(SystemTime.Now().AddMinutes(4), 4.MinutesFromNow());
         Assert.AreEqual(SystemTime.Now().AddMinutes(2), (2).MinutesFromNow());
      }
      [Test]
      public void SecondsFromNow()
      {
         Assert.AreEqual(SystemTime.Now().AddSeconds(4), 4.SecondsFromNow());
         Assert.AreEqual(SystemTime.Now().AddSeconds(2), (2).SecondsFromNow());
      }      

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