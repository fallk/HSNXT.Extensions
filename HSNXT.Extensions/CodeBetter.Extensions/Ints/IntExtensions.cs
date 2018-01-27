namespace HSNXT
{
   #region
   using System;
   #endregion

   public static partial class Extensions
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
      /// Performs the speficied action from start to end
      /// 3.UpTo(5, i => sum += i)
      /// </summary>      
      public static void UpTo(this int start, int end, Action<int> action)
      {
         if (action == null)
         {
            throw new ArgumentNullException("action");
         }
         for (var i = start; i <= end; ++i)
         {
            action(i);
         }
      }
   }
}