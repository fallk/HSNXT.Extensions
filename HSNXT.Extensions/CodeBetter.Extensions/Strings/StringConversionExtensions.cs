namespace HSNXT
{
   using System;
   using System.Security.Cryptography;
   using System.Text;
   using System.Web;

   public static partial class Extensions
   {
      /// <summary>
      /// UrlEncodes a string
      /// </summary>      
      public static string EncodeUrl(this string @string)
      {
         return HttpUtility.UrlEncode(@string);
      }
      
      /// <summary>
      /// UrlDecodes a string
      /// </summary>      
      public static string DecodeUrl(this string @string)
      {
         return HttpUtility.UrlDecode(@string);
      }

      /// <summary>
      /// HtmlEncodes a string
      /// </summary>      
      public static string EncodeHtml(this string @string)
      {
         return HttpUtility.HtmlEncode(@string);
      }

      /// <summary>
      /// HtmlDecodes a string
      /// </summary>
      public static string DecodeHtml(this string @string)
      {
         return HttpUtility.HtmlDecode(@string);
      }

      /// <summary>
      /// Base64's a string with the specified encoding type
      /// </summary>      
      public static string EncodeBase64(this string @string, EncodingType encoding)
      {         
         return System.Convert.ToBase64String(@string.ToBytes(encoding));
      }

      /// <summary>
      /// Decodes a base64 string using the specified encoding type
      /// </summary>
      public static string DecodeBase64(this string base64String, EncodingType encoding)
      {
         return GetEncoding(encoding).GetString(System.Convert.FromBase64String(base64String));
      }

      /// <summary>
      /// Escapes the single quotes within a string
      /// </summary>      
      public static string EncodeJavascript(this string @string)
      {
         return @string.Replace("'", "\\'");
      }
      
      /// <summary>
      /// Converts a string to bytes
      /// </summary>      
      public static byte[] ToBytes(this string @string, EncodingType encoding)
      {
         return GetEncoding(encoding).GetBytes(@string);         
      }

      /// <summary>
      /// Creates an EncodeMd5 of a string using the default encoding type
      /// </summary>      
      public static string EncodeMd5(this string @string)
      {
         return @string.EncodeMd5(EncodingType.Default);
      }

      /// <summary>
      /// Creates an EncodeMd5 of a string using the specified encoding type
      /// </summary>
      public static string EncodeMd5(this string @string, EncodingType encoding)
      {
         return MD5.Create().ComputeHash(@string.ToBytes(encoding)).ToHex();
      }

      /// <summary>
      /// Creates an EncodeSha1 of a string using the default encoding
      /// </summary>     
      public static string EncodeSha1(this string @string)
      {
         return @string.EncodeSha1(EncodingType.Default);
      }

      /// <summary>
      /// Creates an EncodeSha1 of a string using the specified encoding
      /// </summary>      
      public static string EncodeSha1(this string @string, EncodingType encoding)
      {
         return new SHA1Managed().ComputeHash(@string.ToBytes(encoding)).ToHex();
      }
      private static Encoding GetEncoding(EncodingType encoding)
      {
         switch (encoding)
         {
            case EncodingType.Utf8:
               return Encoding.UTF8;               
            case EncodingType.Utf7:
               return Encoding.UTF7;
            case EncodingType.Unicode:
               return Encoding.Unicode;
            case EncodingType.Ascii:
               return Encoding.ASCII;
            default:
               return Encoding.Default;
         }
      }
   }


   public enum EncodingType
   {
      Utf7,
      Utf8,
      Ascii,
      Unicode,
      Default,
   }
}
