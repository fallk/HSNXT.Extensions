namespace CodeBetter.Extensions.Tests
{
   using System;
   using System.Collections.Generic;
   using System.IO;
   using System.Reflection;
   using NUnit.Framework;

   [TestFixture]
   public class StreamTests
   {
      [Test]
      public void ReadAll()
      {
         Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("CodeBetter.Extensions.Tests.TestResource.txt");
         string expected = "start{0}line 1{0}it's over 9000{0}line 3{0}end".FormatWith(Environment.NewLine);
         Assert.AreEqual(expected, stream.ReadAll());
      }

      [Test]
      public void ReadLines()
      {
         Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("CodeBetter.Extensions.Tests.TestResource.txt");
         var lines = stream.ReadLines();
         Assert.AreEqual(5, lines.Count);
         Assert.AreEqual("start", lines[0]);
         Assert.AreEqual("end", lines[4]);
      }
   }
}
