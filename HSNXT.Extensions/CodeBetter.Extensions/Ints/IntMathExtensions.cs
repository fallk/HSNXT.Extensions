namespace CodeBetter.Extensions
{
   public static class IntMathExtensions
   {      
      /// <summary>
      /// Determines if a number is even or not
      /// </summary>      
      public static bool IsEven(this int number)
      {
         return number % 2 == 0;
      }
      /// <summary>
      /// Determines if a number is odd or not
      /// </summary>
      public static bool IsOdd(this int number)
      {
         return !number.IsEven();
      }
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