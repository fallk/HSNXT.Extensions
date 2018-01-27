namespace CodeBetter.Extensions.Tests
{
   using NUnit.Framework;
   using HSNXT;

   [TestFixture]
   public class StringValidationTests
   {
      [Test]
      public void IsEmail_ReturnsTrueForEmails()
      {
         Assert.IsTrue("a@a.com".IsEmail());
      }
      [Test]
      public void IsEmail_ReturnsFalseForInvalidEmails()
      {
         Assert.IsFalse("a".IsEmail());
         Assert.IsFalse("s\t@a.org".IsEmail());
         Assert.IsFalse("@a.museum".IsEmail());
         Assert.IsFalse("something@.net".IsEmail());
      }
      [Test]
      public void IsBadWord_ReturnsTrueForBadWords()
      {
         Assert.IsTrue("fuck".IsBadWord());
         Assert.IsTrue("FUCK".IsBadWord());
      }
      [Test]
      public void IsBadWord_ReturnsFalseForNonBadWords()
      {
         Assert.IsFalse("hello".IsBadWord());
         Assert.IsFalse("sunshine".IsBadWord());
      }
   }
}
