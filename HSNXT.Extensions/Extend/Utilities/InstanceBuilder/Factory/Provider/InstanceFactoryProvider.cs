using System;
using System.Collections.Generic;


namespace HSNXT
{
    /// <summary>
    ///     Factory provider.
    /// </summary>
    internal static class InstanceFactoryProvider
    {
        /// <summary>
        ///     Gets the default instance factories.
        /// </summary>
        /// <returns>Returns the factories.</returns>
        internal static IEnumerable<IInstanceFactory> GetDefaultFactories()
        {
            yield return
                new ExpressionInstanceFactory( x => Extensions.GetRandomInt16(), "Int16 Factory", "Factory for Int16 values." )
                    .AddSelectionRule( new TypeMemberSelectionRule( typeof(short),
                                                                    MemberSelectionMode.Include,
                                                                    CompareMode.Is,
                                                                    "Int16 Selector",
                                                                    "Includes all members of type Int16" ) );

            yield return
                new ExpressionInstanceFactory( x => Extensions.GetRandomInt32(), "Int32 Factory", "Factory for Int32 values." )
                    .AddSelectionRule( new TypeMemberSelectionRule( typeof(int),
                                                                    MemberSelectionMode.Include,
                                                                    CompareMode.Is,
                                                                    "Int32 Selector",
                                                                    "Includes all members of type Int32" ) );

            yield return
                new ExpressionInstanceFactory( x => Extensions.GetRandomInt64(), "Int64 Factory", "Factory for Int64 values." )
                    .AddSelectionRule( new TypeMemberSelectionRule( typeof(long),
                                                                    MemberSelectionMode.Include,
                                                                    CompareMode.Is,
                                                                    "Int64 Selector",
                                                                    "Includes all members of type Int64" ) );

            yield return
                new ExpressionInstanceFactory( x => Extensions.GetRandomDouble(), "Double Factory", "Factory for Double values." )
                    .AddSelectionRule( new TypeMemberSelectionRule( typeof(double),
                                                                    MemberSelectionMode.Include,
                                                                    CompareMode.Is,
                                                                    "Double Selector",
                                                                    "Includes all members of type Double" ) );

            yield return
                new ExpressionInstanceFactory( x => Extensions.GetRandomChar(), "Char Factory", "Factory for Char values." )
                    .AddSelectionRule( new TypeMemberSelectionRule( typeof(char),
                                                                    MemberSelectionMode.Include,
                                                                    CompareMode.Is,
                                                                    "Char Selector",
                                                                    "Includes all members of type Char" ) );

            yield return
                new ExpressionInstanceFactory( x => Extensions.GetRandomString(), "String Factory", "Factory for String values." )
                    .AddSelectionRule( new TypeMemberSelectionRule( typeof(string),
                                                                    MemberSelectionMode.Include,
                                                                    CompareMode.Is,
                                                                    "String Selector",
                                                                    "Includes all members of type String" ) );

            yield return
                new ExpressionInstanceFactory( x => Extensions.GetRandomBoolean(), "Boolean Factory", "Factory for Boolean values." )
                    .AddSelectionRule( new TypeMemberSelectionRule( typeof(bool),
                                                                    MemberSelectionMode.Include,
                                                                    CompareMode.Is,
                                                                    "Boolean Selector",
                                                                    "Includes all members of type Boolean" ) );

            yield return
                new ExpressionInstanceFactory( x => Extensions.GetRandomDateTime(), "DateTime Factory", "Factory for DateTime values." )
                    .AddSelectionRule( new TypeMemberSelectionRule( typeof(DateTime),
                                                                    MemberSelectionMode.Include,
                                                                    CompareMode.Is,
                                                                    "DateTime Selector",
                                                                    "Includes all members of type DateTime" ) );
        }
    }
}