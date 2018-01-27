using System;
using System.Collections.Generic;
using System.Reflection;
using JetBrains.Annotations;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Text;
using System.Globalization;
using System.Collections;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Collections.Concurrent;
using HSNXT.Internal;


namespace HSNXT
{
    /// <summary>
    ///     Member selection provider.
    /// </summary>
    internal static class MemberSelectionRuleProvider
    {
        /// <summary>
        ///     Gets the default member children selection rules.
        /// </summary>
        /// <returns>Returns the member children selection rules.</returns>
        internal static IEnumerable<IMemberSelectionRule> GetDefaultMemberChildreSelectionRules()
        {
            //Include all children
            yield return new AllMemberSelectionRule( MemberSelectionMode.Include, "Include all child members", "Includes all child members." );

            //Exclude Microsoft (FX) types
            yield return new ExpressionMemberSelectionRule( x => x.MemberType.IsMicrosoftType(),
                                                            MemberSelectionMode.Exclude,
                                                            "Microsoft Type Filter",
                                                            "Excludes all types from Microsoft (Framework types)." );
        }

        /// <summary>
        ///     Gets the default member selection rules.
        /// </summary>
        /// <returns>Returns the member selection rules.</returns>
        internal static IEnumerable<IMemberSelectionRule> GetDefaultMemberSelectionRules()
        {
            yield return new AllMemberSelectionRule( MemberSelectionMode.Include, "Include all members", "Includes all members." );
        }
    }
}