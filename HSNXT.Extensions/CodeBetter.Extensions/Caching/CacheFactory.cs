namespace CodeBetter.Extensions
{
   public static class CacheFactory
   {
      public static ICache GetInstance
      {
         get { return new InMemoryCache(); }
      }
   }
}
