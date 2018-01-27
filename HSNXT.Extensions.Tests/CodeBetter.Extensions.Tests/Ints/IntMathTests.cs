
namespace CodeBetter.Extensions.Tests
{
   using NUnit.Framework;

   [TestFixture]
   public class IntMathTests
   {
      [Test]
      public void IsEven_ReturnsTrueForEvenNumbersAndFalseOtherwise()
      {
         Assert.IsTrue(0.IsEven());
         Assert.IsTrue((-2).IsEven());
         Assert.IsTrue((1000).IsEven());
         Assert.IsFalse(1.IsEven());
         Assert.IsFalse((-1).IsEven());
         Assert.IsFalse((99).IsEven());
      }
      [Test]
      public void IsOdd_ReturnsTrueForEvenNumbersAndFalseOtherwise()
      {
         Assert.IsFalse(0.IsOdd());
         Assert.IsFalse((-2).IsOdd());
         Assert.IsFalse((1000).IsOdd());
         Assert.IsTrue(1.IsOdd());
         Assert.IsTrue((-1).IsOdd());
         Assert.IsTrue((99).IsOdd());
      }
      [Test]
      public void MultipleOf_ForSingleValue()
      {
         Assert.IsTrue(10.MultipleOf(5));
         Assert.IsTrue(2.MultipleOf(1));
         Assert.IsFalse(2.MultipleOf(3));
         Assert.IsFalse(7.MultipleOf(3));
         Assert.IsFalse(3.MultipleOf(new int[] { }));
      }
      [Test]
      public void MultipleOf_ForMultipleValues()
      {
         Assert.IsTrue(10.MultipleOf(5, 2));
         Assert.IsTrue(2.MultipleOf(1, 2));
         Assert.IsFalse(10.MultipleOf(5, 2, 3));
         Assert.IsFalse(6.MultipleOf(4, 4, 5));
      }
      [Test]
      public void FactorOf_ForSingleValue()
      {
         Assert.IsTrue(5.FactorOf(10));
         Assert.IsTrue(1.FactorOf(2));
         Assert.IsFalse(3.FactorOf(2));
         Assert.IsFalse(3.FactorOf(7));
         Assert.IsFalse(3.FactorOf(new int[] { }));
      }
      [Test]
      public void FactorOf_ForMultipleValues()
      {
         Assert.IsTrue(5.FactorOf(10, 15));
         Assert.IsTrue(2.FactorOf(2, 200));
         Assert.IsFalse(10.FactorOf(100, 150, 21));
         Assert.IsFalse(6.FactorOf(12, 12, 13));
      }
   }
}
