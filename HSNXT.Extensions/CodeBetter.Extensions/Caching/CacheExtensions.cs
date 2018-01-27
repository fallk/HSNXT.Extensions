#if NetFX
namespace HSNXT
{
   using System;
   using System.Web.Caching;

   public static partial class Extensions
   {
      public static T Get<T>(this Cache cache, string key, params object[] keyArgs)
      {
         return (T) cache.Get(string.Format(key, keyArgs));
      }

      public static T Fetch<T>(this Cache cache, string key, Func<T> callIfGetReturnsNull, params object[] keyArgs)
      {
         return cache.Fetch(key, null, callIfGetReturnsNull, keyArgs);
      }
      public static T Fetch<T>(this Cache cache, string key, Func<T> callIfGetReturnsNull, DateTime absoluteExpiration, params object[] keyArgs)
      {
         return cache.Fetch(key, null, callIfGetReturnsNull, absoluteExpiration, keyArgs);
      }
      public static T Fetch<T>(this Cache cache, string key, Func<T> callIfGetReturnsNull, TimeSpan slidingExpiration, params object[] keyArgs)
      {
         return cache.Fetch(key, null, callIfGetReturnsNull, slidingExpiration, keyArgs);
      }
      public static T Fetch<T>(this Cache cache, string key, Func<T> callIfGetReturnsNull, CacheDependency dependencies, params object[] keyArgs)
      {
         return cache.Fetch(key, null, callIfGetReturnsNull, dependencies, keyArgs);
      }
      public static T Fetch<T>(this Cache cache, string key, Func<T> callIfGetReturnsNull, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, params object[] keyArgs)
      {
         return cache.Fetch(key, null, callIfGetReturnsNull, dependencies, absoluteExpiration, slidingExpiration, keyArgs);
      }
      public static T Fetch<T>(this Cache cache, string key, Func<T> callIfGetReturnsNull, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, CacheItemPriority priority, CacheItemRemovedCallback onRemoveCallback, params object[] keyArgs)
      {
         return cache.Fetch(key, null, callIfGetReturnsNull, dependencies, absoluteExpiration, slidingExpiration, priority, onRemoveCallback, keyArgs);
      }

      public static T Fetch<T>(this Cache cache, string key, Action<T> callIfGetReturnsValue, Func<T> callIfGetReturnsNull, params object[] keyArgs)
      {
         var item = (T)cache.Get(string.Format(key, keyArgs));
         if (item == null)
         {
            item = callIfGetReturnsNull();
            cache.Insert(key, item, keyArgs);
         }
         else if (callIfGetReturnsValue != null)
         {
            callIfGetReturnsValue(item);
         }
         return item;
      }
      public static T Fetch<T>(this Cache cache, string key, Action<T> callIfGetReturnsValue, Func<T> callIfGetReturnsNull, DateTime absoluteExpiration, params object[] keyArgs)
      {
         var item = (T)cache.Get(string.Format(key, keyArgs));
         if (item == null)
         {
            item = callIfGetReturnsNull();
            cache.Insert(key, item, absoluteExpiration, keyArgs);
         }
         else if (callIfGetReturnsValue != null)
         {
            callIfGetReturnsValue(item);
         }
         return item;
      }
      public static T Fetch<T>(this Cache cache, string key, Action<T> callIfGetReturnsValue, Func<T> callIfGetReturnsNull, TimeSpan slidingExpiration, params object[] keyArgs)
      {
         var item = (T)cache.Get(string.Format(key, keyArgs));
         if (item == null)
         {
            item = callIfGetReturnsNull();
            cache.Insert(key, item, slidingExpiration, keyArgs);
         }
         else if (callIfGetReturnsValue != null)
         {
            callIfGetReturnsValue(item);
         }
         return item;
      }
      public static T Fetch<T>(this Cache cache, string key, Action<T> callIfGetReturnsValue, Func<T> callIfGetReturnsNull, CacheDependency dependencies, params object[] keyArgs)
      {
         var item = (T)cache.Get(string.Format(key, keyArgs));
         if (item == null)
         {
            item = callIfGetReturnsNull();
            cache.Insert(key, item, dependencies, keyArgs);
         }
         else if (callIfGetReturnsValue != null)
         {
            callIfGetReturnsValue(item);
         }
         return item;
      }
      public static T Fetch<T>(this Cache cache, string key, Action<T> callIfGetReturnsValue, Func<T> callIfGetReturnsNull, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, params object[] keyArgs)
      {
         var item = (T)cache.Get(string.Format(key, keyArgs));
         if (item == null)
         {
            item = callIfGetReturnsNull();
            cache.Insert(key, item, dependencies, absoluteExpiration, slidingExpiration, keyArgs);
         }
         else if (callIfGetReturnsValue != null)
         {
            callIfGetReturnsValue(item);
         }
         return item;
      }
      public static T Fetch<T>(this Cache cache, string key, Action<T> callIfGetReturnsValue, Func<T> callIfGetReturnsNull, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, CacheItemPriority priority, CacheItemRemovedCallback onRemoveCallback, params object[] keyArgs)
      {
         var item = (T)cache.Get(string.Format(key, keyArgs));
         if (item == null)
         {
            item = callIfGetReturnsNull();
            cache.Insert(key, item, dependencies, absoluteExpiration, slidingExpiration, priority, onRemoveCallback, keyArgs);
         }
         else if (callIfGetReturnsValue != null)
         {
            callIfGetReturnsValue(item);
         }
         return item;
      }

      public static void Insert(this Cache cache, string key, object data, params object[] keyArgs)
      {
         if (data != null)
         {
            cache.Insert(string.Format(key, keyArgs), data);
         }
      }
      public static void Insert(this Cache cache, string key, object data, DateTime absoluteExpiration, params object[] keyArgs)
      {
         if (data != null)
         {
            cache.Insert(string.Format(key, keyArgs), data, null, absoluteExpiration, Cache.NoSlidingExpiration);
         }
      }
      public static void Insert(this Cache cache, string key, object data, TimeSpan slidingExpiration, params object[] keyArgs)
      {
         if (data != null)
         {
            cache.Insert(string.Format(key, keyArgs), data, null, Cache.NoAbsoluteExpiration, slidingExpiration);
         }
      }
      public static void Insert(this Cache cache, string key, object data, CacheDependency dependencies, params object[] keyArgs)
      {
         if (data != null)
         {
            cache.Insert(string.Format(key, keyArgs), data, dependencies);
         }
      }
      public static void Insert(this Cache cache, string key, object data, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, params object[] keyArgs)
      {
         if (data != null)
         {
            cache.Insert(string.Format(key, keyArgs), data, dependencies, absoluteExpiration, slidingExpiration);
         }
      }
      public static void Insert(this Cache cache, string key, object data, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, CacheItemPriority priority, CacheItemRemovedCallback onRemoveCallback, params object[] keyArgs)
      {
         if (data != null)
         {
            cache.Insert(string.Format(key, keyArgs), data, dependencies, absoluteExpiration, slidingExpiration, priority, onRemoveCallback);
         }
      }

      public static void Remove(this Cache cache, string key, params object[] keyArgs)
      {
         cache.Remove(string.Format(key, keyArgs));
      }
      public static void RemoveAll(this Cache cache)
      {
         var enumerator = cache.GetEnumerator();
         while (enumerator.MoveNext())
         {
            cache.Remove((string)enumerator.Key);
         }
      }
   }
}
#endif