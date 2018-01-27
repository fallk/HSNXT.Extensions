namespace HSNXT
{
   public static partial class Extensions
   {      
      /// <summary>
      /// if the number is a multiple of all supplied factors
      /// </summary>
      public static bool MultipleOf(this int number, params int[] factors)
      {
         return factors.Length != 0 && factors.TrueForAll(factor => number % factor == 0);
      }
      /// <summary>
      /// if the number is a factor of all supplied multiples
      /// </summary>
      public static bool FactorOf(this int number, params int[] multiples)
      {
         return multiples.Length != 0 && multiples.TrueForAll(multiple => multiple % number == 0);
      }    
   }
}