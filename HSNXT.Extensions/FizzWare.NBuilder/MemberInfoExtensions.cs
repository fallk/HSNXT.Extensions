using System;
using System.Diagnostics;
using System.Reflection;

namespace HSNXT
{
    public static partial class Extensions
    {
        public static Type GetFieldOrPropertyType(this MemberInfo m)
        {
            return m is FieldInfo info ? info.FieldType : ((PropertyInfo)m).PropertyType;
        }

        public static object GetFieldOrPropertyValue<T>(this MemberInfo memberInfo, T instance)
        {
            object currentValue = null;

            switch (memberInfo)
            {
                case FieldInfo info:
                    currentValue = info.GetValue(instance);
                    break;
                case PropertyInfo propertyInfo:
                    try
                    {
                        if (propertyInfo.GetGetMethod() != null)
                        {
                            currentValue = propertyInfo.GetValue(instance, null);
                        }
                    }
                    catch (Exception)
                    {
                        Debug.WriteLine(string.Format("NBuilder warning: {0} threw an exception when attempting to read its current value", memberInfo.Name));
                    }

                    break;
            }

            return currentValue;
        }

        public static void SetFieldOrPropertyValue<T>(this MemberInfo m, T instance, object value)
        {
            switch (m)
            {
                case FieldInfo info:
                    info.SetValue(instance, value);
                    break;
                case PropertyInfo prop:
                    if (prop.CanWrite)
                    {
                        prop.SetValue(instance, value, null);
                    }

                    break;
            }
        }
    }
}
