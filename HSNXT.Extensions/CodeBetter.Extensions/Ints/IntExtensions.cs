namespace CodeBetter.Extensions
{
   #region
   using System;
   #endregion

   public static class IntExtensions
   {
      /// <summary>
      /// Returns the suffic (st, nd, rd, th) for the specified number
      /// </summary>      
      public static string Suffix(this int number)
      {         
         if (number >= 10 && number < 20)
         {
            return "th";
         }
         switch (number % 10)
         {
            case 1:
               return "st";
            case 2:
               return "nd";
            case 3:
               return "rd";
            default:
               return "th";
         }
      }
      /// <summary>
      /// Returns the suffix for the specified number appended to the number
      /// (1st, 12th, 33rd, 2nd)
      /// </summary>      
      public static string Suffixed(this int number)
      {
         return number + number.Suffix();
      }
      /// <summary>
      /// Performs the specified action a given number of times
      /// 3.times(i => sum += i);
      /// </summary>      
      public static void Times(this int times, Action<int> action)
      {
         if (action == null)
         {
            throw new ArgumentNullException("action");
         }
         for (int i = 1; i <= times; ++i)
         {
            action(i);
         }
      }
      /// <summary>
      /// Performs the speficied action from start to end
      /// 3.UpTo(5, i => sum += i)
      /// </summary>      
      public static void UpTo(this int start, int end, Action<int> action)
      {
         if (action == null)
         {
            throw new ArgumentNullException("action");
         }
         for (int i = start; i <= end; ++i)
         {
            action(i);
         }
      }
   }
}