namespace CodeBetter.Extensions.Tests
{
   using System;
   using NUnit.Framework;

   [TestFixture]
   public class DayTests
   {
      private DateTime _monday;
      private DateTime _tuesday;
      private DateTime _nextMonday;      
      private DateTime _march = new DateTime(2008, 3, 15); // march 15th


      [SetUp]
      public void Setup()
      {
         _monday = new DateTime(2008, 3, 3, 17, 15, 30); // monday 3rd of March, 2008, 17h 15m 30s
         _tuesday = _monday.AddDays(1);
         _nextMonday = _monday.AddDays(7);
      }
    
      [Test]
      public void NextWhenDayOfWeekIsAfterCurrentDayOfWeek()
      {
         Assert.AreEqual(_tuesday, _monday.Next(DayOfWeek.Tuesday));
      }

      [Test]
      public void NextWhenDayOfWeekIsBeforeCurrentDayOfWeek()
      {
         Assert.AreEqual(_nextMonday, _tuesday.Next(DayOfWeek.Monday));
      }

      [Test]
      public void NextWhenDayOfWeekIsSameAsCurrentDayOfWeek()
      {
         Assert.AreEqual(_nextMonday, _monday.Next(DayOfWeek.Monday));
      }

      [Test]
      public void FirstDayOfMonth()
      {
         DateTime expected = new DateTime(_monday.Year, _monday.Month, 1);
         Assert.AreEqual(expected, _march.First());
      }

      [Test]
      public void FirstSpecificDayOfMonth()
      {
         DateTime expected = new DateTime(_monday.Year, _monday.Month, 3); // first monday in march 2008
         Assert.AreEqual(expected, _march.First(DayOfWeek.Monday));
      }

      [Test]
      public void FirstSpecificDayOfMonthWhenItIsReallyFirstDayOfMonth()
      {
         DateTime expected = new DateTime(2008, 3, 1); // first saturday in march 2008
         Assert.AreEqual(DayOfWeek.Saturday, expected.DayOfWeek);
         Assert.AreEqual(expected, _march.First(DayOfWeek.Saturday));
      }

      [Test]
      public void LastDayOfMonth()
      {
         DateTime expected = new DateTime(_march.Year, _march.Month, DateTime.DaysInMonth(_march.Year, _march.Month));
         Assert.AreEqual(expected, _march.Last());
      }

      [Test]
      public void LastSpecificDayOfMonth()
      {
         DateTime expected = new DateTime(_march.Year, _march.Month, DateTime.DaysInMonth(_march.Year, _march.Month));
         while (expected.DayOfWeek != DayOfWeek.Sunday)
         {
            expected = expected.AddDays(-1);
         }
         Assert.AreEqual(expected, _march.Last(DayOfWeek.Sunday));
      }

      [Test]
      public void LastSpecificDayOfMonthWhenItIsReallyLastDayOfMonth()
      {
         DateTime expected = new DateTime(2008, 3, 31); // last day in march 2008 = monday
         Assert.AreEqual(DayOfWeek.Monday, expected.DayOfWeek);
         Assert.AreEqual(expected, _march.Last(DayOfWeek.Monday));
      }
   }

}
