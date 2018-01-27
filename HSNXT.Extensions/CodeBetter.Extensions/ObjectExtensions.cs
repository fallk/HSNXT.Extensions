namespace CodeBetter.Extensions
{
   using System;
   using System.Collections;
   using System.Collections.Generic;
   using System.ComponentModel;

   public static class ObjectExtensions
   {
      /// <summary>
      /// Takes an object and turns it into a dictionary. Each public property is
      /// added to the dictionary, with the name of the property being the dictionary key,
      /// and its value being the dictionary value.      
      /// </summary>
      /// <remarks>
      /// Particularly useful for dealing with anonymous type decleration passed as objects
      /// to a method.
      /// </remarks>      
      public static Dictionary<string, object> ToDictionary(this object @object)
      {
         var properties = TypeDescriptor.GetProperties(@object);
         var hash = new Dictionary<string, object>(properties.Count);
         foreach (PropertyDescriptor descriptor in properties)
         {
            hash.Add(descriptor.Name, descriptor.GetValue(@object));
         }
         return hash;         
      }

      /// <summary>
      /// Determines if the object is in the specific list.
      /// </summary>      
      public static bool In(this object @object, IEnumerable list)
      {
         foreach (var item in list)
         {
            if (item.Equals(@object))
            {
               return true;
            }
         }
         return false;
      }

      /// <summary>
      /// Returns true if the object is marked with the specified attribute
      /// </summary>
      public static bool DefinesAttribute(this object @object, string attributeType)
      {
         return @object.DefinesAttribute(Type.GetType(attributeType, true, true));
      }

      /// <summary>
      /// Returns true if the object is marked with the specified attribute
      /// </summary>
      public static bool DefinesAttribute(this object @object, Type attributeType)
      {
         var definedAttributes = @object.GetType().GetCustomAttributes(attributeType, true);
         return (definedAttributes != null && definedAttributes.Length > 0);
      }
   }
}
