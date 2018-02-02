
#pragma warning disable 169
namespace CodeBetter.Extensions.Tests
{
   public class FakeClass
   {
      private int _id;
      private string _name;
      private string _password;
      private int _internalId;

      public int Id
      {
         get { return _id; }
         set { _id = value; }
      }
      public string Name
      {
         get { return _name; }
         set { _name = value; }
      }
      protected int InternalId
      {
         get { return _internalId; }
         set { _internalId = value; }
      }

      public FakeClass() { }
      public FakeClass(int id)
      {
         _id = id;        
      }
   }
}
