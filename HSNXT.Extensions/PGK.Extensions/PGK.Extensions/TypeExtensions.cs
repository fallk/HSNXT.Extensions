using System;

namespace HSNXT
{
    public static partial class Extensions
    {
            ///<summary>
            ///	Check if this is a base type
            ///</summary>
            ///<param name = "type"></param>
            ///<param name = "checkingType"></param>
            ///<returns></returns>
            /// <remarks>
            /// 	Contributed by Michael T, http://about.me/MichaelTran
            /// </remarks>
            public static bool IsBaseType(this Type type, Type checkingType)
            {
                while (type != typeof(object) && type != null)
                {
                    if (type == checkingType)
                        return true;

                    type = type.BaseType;
                }

                return false;
            }

            /// <summary>
            /// Closes the passed generic type with the provided type arguments and returns an instance of the newly constructed type.
            /// </summary>
            /// <typeparam name="T">The typed type to be returned.</typeparam>
            /// <param name="genericType">The open generic type.</param>
            /// <param name="typeArguments">The type arguments to close the generic type.</param>
            /// <returns>An instance of the constructed type casted to T.</returns>
            public static T CreateGenericTypeInstance<T>(this Type genericType, params Type[] typeArguments)
                where T : class
            {
                var constructedType = genericType.MakeGenericType(typeArguments);
                var instance = Activator.CreateInstance(constructedType);
                return (instance as T);
            }
        }
    }