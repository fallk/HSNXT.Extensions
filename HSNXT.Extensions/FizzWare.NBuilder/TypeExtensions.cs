using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace HSNXT
{
    public static partial class Extensions
    {
#if !NETSTANDARD1_6
        // added for api compatibility with .net standard

        //public static MethodInfo GetMethodInfo(this MulticastDelegate d)
        //{
        //    return d.Method;
        //}

        public static MethodInfo GetMethodInfo(this Delegate d)
        {
            return d.Method;
        }

        public static Type GetTypeInfo(this Type t)
        {
            return t; 
        }
#else
#endif

        public static IList<MemberInfo> GetPublicInstancePropertiesAndFields(this Type t)
        {
            var memberInfos = new List<MemberInfo>();
            memberInfos.AddRange(t.GetProperties(BindingFlags.Public | BindingFlags.Instance));
            memberInfos.AddRange(t.GetFields());
            return memberInfos;
        }

        public static bool IsAbstract(this Type self)
        {
            return self.IsAbstract;
        }

        public static bool IsInterface(this Type self)
        {
            return self.IsInterface;
        }

        public static ConstructorInfo[] GetConstructors(this Type self)
        {
            return self.GetConstructors();
        }

        public static ConstructorInfo[] GetConstructors(this Type self, BindingFlags flags)
        {
            return self.GetConstructors(flags);
        }

        public static FieldInfo[] GetFields(this Type self)
        {
            return self.GetFields();
        }

        public static FieldInfo[] GetFields(this Type self, BindingFlags flags)
        {
            return self.GetFields(flags);
        }

        public static PropertyInfo[] GetProperties(this Type self)
        {
            return self.GetProperties();
        }

        public static PropertyInfo[] GetProperties(this Type self, BindingFlags flags)
        {
            return self.GetProperties(flags);
        }

        public static Type BaseType(this Type self)
        {
            return self.BaseType;
        }
    }
}
