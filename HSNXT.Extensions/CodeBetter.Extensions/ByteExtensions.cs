using System.Text;

namespace CodeBetter.Extensions
{
   public static class ByteExtensions
   {
      /// <summary>
      /// Converts a byte array into a hex string
      /// </summary>      
      public static string ToHex(this byte[] bytes)
      {
         var sb = new StringBuilder();
         for (int i = 0; i < bytes.Length; ++i)
         {
            sb.Append(bytes[i].ToString("x2"));
         }
         return sb.ToString();
      }

      /// <summary>
      /// Converts a single byte to a hex string
      /// </summary>      
      public static string ToHex(this byte @byte)
      {
         return @byte.ToString("x2");
      }
   }
}
