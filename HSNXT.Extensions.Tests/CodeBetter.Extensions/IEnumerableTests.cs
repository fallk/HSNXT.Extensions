namespace CodeBetter.Extensions.Tests
{
   using System.Collections.Generic;
   using System.Collections.ObjectModel;
   using NUnit.Framework;
   using HSNXT;

   [TestFixture]
   public class IEnumerableTests
   {
      [Test]
      public void Each()
      {
         var list = new[] {1, 2, 3, 4};
         var seen = new int[4];
         var counter = 0;
         list.Each(i => seen[counter++] = i);         
         Assert.AreEqual(list, seen);
      }
      [Test]
      public void TrueForAll()
      {         
         Assert.IsTrue(new[] { 1, 2, 3, 4 }.TrueForAll(i => i / 1 == i));
         Assert.IsFalse(new[] { 1, 2, 3, 4 }.TrueForAll(i => i / 1 == 0));
      }

      [Test]
      public void Find()
      {
         var values = new ReadOnlyCollection<int>(new[]{1,2,3,4});
         Assert.AreEqual(2, values.Find(i => i == 2));
      }

      [Test]
      public void FindAll()
      {
         var values = new ReadOnlyCollection<int>(new[] { 1, 2, 3, 4 });
         Assert.AreEqual(new[]{2,4}, values.FindAll(i => i % 2 == 0).ToArray());
      }
   }
}
