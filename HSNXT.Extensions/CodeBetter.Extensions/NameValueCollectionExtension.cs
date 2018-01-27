
namespace HSNXT
{
   using System.Collections.Specialized;

   public static partial class Extensions
   {
      /// <summary>
      /// Gets a double from the specified key
      /// </summary>
      public static double GetDouble(this NameValueCollection collection, string key)
      {
         return collection[key].ToDouble();
      }
      /// <summary>
      /// Gets a float from the specified key
      /// </summary>
      public static float GetFloat(this NameValueCollection collection, string key)
      {
         return collection[key].ToFloat();
      }
      /// <summary>
      /// Gets an int from the specified key
      /// </summary>
      public static int GetInt(this NameValueCollection collection, string key)
      {
         return collection[key].ToInt();
      }
      /// <summary>
      /// Gets a boolean from the specified key
      /// </summary>
      public static bool GetBoolean(this NameValueCollection collection, string key)
      {
         return collection[key].ToBooleanNotNull();         
      }
   }
}
