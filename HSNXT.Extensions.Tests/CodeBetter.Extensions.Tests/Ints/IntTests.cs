namespace CodeBetter.Extensions.Tests
{
   using NUnit.Framework;
   using Extensions;
   using HSNXT;

   [TestFixture]
   public class IntTests
   {
      [Test]
      public void Times_IteratesProperNumberOfTimes()
      {
         int counter = 1;
         3.Times(i => ++counter);
         Assert.AreEqual(4, counter);
      }
      [Test]
      public void UpTo_IteratesFromAndTo()
      {
         int sum = 0;
         5.UpTo(10, x => sum+= x);
         Assert.AreEqual(45, sum);
      }

      [Test]
      public void Suffix()
      {
         Assert.AreEqual("st", 1.Suffix());
         Assert.AreEqual("nd", 32.Suffix());
         Assert.AreEqual("rd", 103.Suffix());
         Assert.AreEqual("th", 2004.Suffix());
         Assert.AreEqual("th", 11.Suffix());
      }      
      
      [Test]
      public void Suffixed()
      {
         Assert.AreEqual("1st", 1.Suffixed());
         Assert.AreEqual("14th", 14.Suffixed());
         Assert.AreEqual("32nd", 32.Suffixed());
         Assert.AreEqual("203rd", 203.Suffixed());
      }
   }
}
