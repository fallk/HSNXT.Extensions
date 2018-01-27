namespace CodeBetter.Extensions.Tests
{
   using System.Collections.Generic;
   using System.Collections.ObjectModel;
   using NUnit.Framework;

   [TestFixture]
   public class IEnumerableTests
   {
      [Test]
      public void Each()
      {
         int[] list = new[] {1, 2, 3, 4};
         int[] seen = new int[4];
         int counter = 0;
         list.Each(i => seen[counter++] = i);         
         Assert.AreEqual(list, seen);
      }
      [Test, ExpectedException("System.ArgumentNullException")]
      public void Each_ThrowsExceptionForNullAction()
      {
         new[] {0}.Each(null);
         Assert.Fail();
      }

      [Test]
      public void TrueForAll()
      {         
         Assert.IsTrue(new[] { 1, 2, 3, 4 }.TrueForAll(i => i / 1 == i));
         Assert.IsFalse(new[] { 1, 2, 3, 4 }.TrueForAll(i => i / 1 == 0));
      }
      [Test, ExpectedException("System.ArgumentNullException")]
      public void TrueForAll_ThrowsExceptionForNullAction()
      {
         new[] { 0 }.TrueForAll(null);
         Assert.Fail();
      }

      [Test]
      public void Find()
      {
         var values = new ReadOnlyCollection<int>(new[]{1,2,3,4});
         Assert.AreEqual(2, values.Find(i => i == 2));
      }
      [Test, ExpectedException("System.ArgumentNullException")]
      public void Find_ThrowsExceptionForNullPredicate()
      {
         var values = new ReadOnlyCollection<int>(new[] { 1, 2, 3, 4 });
         Assert.AreEqual(2, values.Find(null));         
      }

      [Test]
      public void FindAll()
      {
         var values = new ReadOnlyCollection<int>(new[] { 1, 2, 3, 4 });
         Assert.AreEqual(new[]{2,4}, values.FindAll(i => i % 2 == 0).ToArray());
      }
      [Test, ExpectedException("System.ArgumentNullException")]
      public void FindAll_ThrowsExceptionForNullPredicate()
      {
         var values = new ReadOnlyCollection<int>(new[] { 1, 2, 3, 4 });
         Assert.AreEqual(2, values.FindAll(null));
      }
   }
}
