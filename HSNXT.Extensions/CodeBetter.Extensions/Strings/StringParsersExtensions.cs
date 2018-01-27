namespace HSNXT
{
   using System;

   public static partial class Extensions
   {
      /// <summary>
      /// Attempts to extract an integer from a string. This function behaves similarly
      /// to atoi functions, which will read up to a non-numeric value. For example:
      /// 103abc --> 103   or -1!  -> -1 
      /// </summary>
      /// <remarks>
      /// This will throw an exception on failure
      /// </remarks>      
      public static int ExtractInt(this string @string)
      {
         if (@string.Length == 0)
         {
            throw new FormatException();
         }
         @string = @string.Trim();
         var isNegative = (@string[0] == '-');
         if (isNegative && @string.Length == 1)
         {
            throw new FormatException();
         }
         var offset = isNegative ? 1 : 0;
         if (@string[offset] < '0' || @string[offset] > '9')
         {
            throw new FormatException();
         }
         var value = 0;
         for (; offset < @string.Length; ++offset)
         {
            var c = @string[offset];
            if (c < '0' || c > '9')
            {
               break;
            }
            value = value * 10 + (c - '0');
         }
         return isNegative ? -1 * value : value;
      }

      /// <summary>
      /// Attempts to extract an integer from a string
      /// </summary>      
      public static bool TryExtractInt(this string @string, out int value)
      {
         try
         {
            value = @string.ExtractInt();
            return true;
         }
         catch (FormatException)
         {
            value = 0;
            return false;
         }
      }
   }
}
