
namespace HSNXT
{
   using System;
   using System.Collections.Generic;

   public static partial class Extensions
   {
      /// <summary>
      /// Performs the specified action on each element of the list and includes
      /// an index value (starting at 0)
      /// </summary>
      public static void EachIndex<T>(this IEnumerable<T> list, Action<T, int> action)
      {
         if (action == null)
         {
            throw new ArgumentNullException(nameof(action));
         }
         var enumerator = list.GetEnumerator();
         var count = 0;
         while (enumerator.MoveNext())
         {
            action(enumerator.Current, count++);
         }
      }
      /// <summary>
      /// Validates that the predicate is true for each element of the list
      /// </summary>      
      public static bool TrueForAll<T>(this IEnumerable<T> list, Predicate<T> predicate)
      {
         if (predicate == null)
         {
            throw new ArgumentNullException(nameof(predicate));
         }
         var enumerator = list.GetEnumerator();
         while (enumerator.MoveNext())
         {
            if (!predicate(enumerator.Current))
            {
               return false;
            }
         }
         return true;
      }
      /// <summary>
      /// Retuns a list of all items matching the predicate
      /// </summary>      
      public static List<T> FindAll<T>(this IEnumerable<T> list, Predicate<T> predicate)
      {
         if (predicate == null)
         {
            throw new ArgumentNullException(nameof(predicate));
         }
         var found = new List<T>();
         var enumerator = list.GetEnumerator();
         while (enumerator.MoveNext())
         {
            if (predicate(enumerator.Current))
            {
               found.Add(enumerator.Current);
            }
         }
         return found;
      }
      /// <summary>
      /// Retuns the first matching item
      /// </summary>      
      public static T Find<T>(this IEnumerable<T> list, Predicate<T> predicate)
      {         
         if (predicate == null)
         {
            throw new ArgumentNullException(nameof(predicate));
         }         
         var enumerator = list.GetEnumerator();
         while (enumerator.MoveNext())
         {
            if (predicate(enumerator.Current))
            {
               return enumerator.Current;
            }
         }
         return default(T);
      }
      /// <summary>
      /// Finds the index of an item
      /// </summary>      
      public static int Index<T>(this IEnumerable<T> list, Predicate<T> predicate)
      {
         if (predicate == null)
         {
            throw new ArgumentNullException(nameof(predicate));
         }
         var enumerator = list.GetEnumerator();
         for (int i = 0; enumerator.MoveNext(); ++i)
         {
            if (predicate(enumerator.Current))
            {
               return i;
            }
         }
         return -1;
      }
      /// <summary>
      /// Determines whether or not the item exists
      /// </summary>      
      public static bool Exists<T>(this IEnumerable<T> list, Predicate<T> predicate)
      {
         return list.Index(predicate) > -1;
      }
   }
}
   