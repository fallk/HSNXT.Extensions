
namespace CodeBetter.Extensions.Tests
{
   using System.Collections.Specialized;
   using NUnit.Framework;

   [TestFixture]
   public class NameValueCollectionTests
   {
      [Test]
      public void GetDouble()
      {
         var nvc = new NameValueCollection {{"Value", "1.2"}};
         Assert.AreEqual(1.2, nvc.GetDouble("Value"));
      }
      [Test, ExpectedException("System.ArgumentNullException")]
      public void GetDouble_ThrowsExceptionIfKeyNotFound()
      {
         var nvc = new NameValueCollection();
         nvc.GetDouble("Value");
         Assert.Fail();
      }
      [Test, ExpectedException("System.FormatException")]
      public void GetDouble_ThrowsExceptionIfCantFormat()
      {
         var nvc = new NameValueCollection { { "Value", "It's over 9000" } };
         nvc.GetDouble("Value");
         Assert.Fail();
      }

      [Test]
      public void GetFloat()
      {
         var nvc = new NameValueCollection { { "Value", "1.2" } };
         Assert.AreEqual(1.2, nvc.GetFloat("Value"));
      }
      [Test, ExpectedException("System.ArgumentNullException")]
      public void GetFloat_ThrowsExceptionIfKeyNotFound()
      {
         var nvc = new NameValueCollection();
         nvc.GetFloat("Value");
         Assert.Fail();
      }
      [Test, ExpectedException("System.FormatException")]
      public void GetFloat_ThrowsExceptionIfCantFormat()
      {
         var nvc = new NameValueCollection { { "Value", "It's over 9000" } };
         nvc.GetFloat("Value");
         Assert.Fail();
      }

      [Test]
      public void GetInt()
      {
         var nvc = new NameValueCollection { { "Value", "2" } };
         Assert.AreEqual(2, nvc.GetInt("Value"));
      }
      [Test, ExpectedException("System.ArgumentNullException")]
      public void GetInt_ThrowsExceptionIfKeyNotFound()
      {
         var nvc = new NameValueCollection();
         nvc.GetInt("Value");
         Assert.Fail();
      }
      [Test, ExpectedException("System.FormatException")]
      public void GetInt_ThrowsExceptionIfCantFormat()
      {
         var nvc = new NameValueCollection { { "Value", "It's over 9000" } };
         nvc.GetInt("Value");
         Assert.Fail();
      }

      [Test]
      public void GetBoolean()
      {
         var nvc = new NameValueCollection { { "Value", "true" } };
         Assert.IsTrue(nvc.GetBoolean("Value"));
      }
      [Test, ExpectedException("System.ArgumentNullException")]
      public void GetBoolean_ThrowsExceptionIfKeyNotFound()
      {
         var nvc = new NameValueCollection();
         nvc.GetBoolean("Value");
         Assert.Fail();
      }
      [Test, ExpectedException("System.FormatException")]
      public void GetBoolean_ThrowsExceptionIfCantFormat()
      {
         var nvc = new NameValueCollection { { "Value", "It's over 9000" } };
         nvc.GetBoolean("Value");
         Assert.Fail();
      }
   }
}
