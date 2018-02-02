namespace CodeBetter.Extensions.Tests
{
   using NUnit.Framework;
   using HSNXT;

   [TestFixture]
   public class ObjectTests
   {
      [Test]
      public void In_ValueTypes()
      {
         Assert.IsTrue(3.In(new[] { 1, 2, 3 }));
         Assert.IsFalse(3.In(new[] { 4, 5, 6 }));         
      }
      [Test]
      public void In_ReferenceTypes()
      {
         var o = new object();
         Assert.IsTrue(o.In(new[] { new object(), o, new object() }));
         Assert.IsFalse(o.In(new[] { new object(), new object() }));
      }

      [Test]
      public void ToDictionary_SerializesPublicPropertiesOnly()
      {
         var hash = new FakeClass(3){Name = "Mozart"}.ToDictionary();
         Assert.AreEqual(3, hash["Id"]);
         Assert.AreEqual("Mozart", hash["Name"]);
         Assert.AreEqual(2, hash.Count);
      }
   }
}
