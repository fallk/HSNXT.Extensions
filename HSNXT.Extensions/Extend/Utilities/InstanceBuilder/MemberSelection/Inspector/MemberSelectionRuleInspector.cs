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
#region Usings

//using System;
//using System.Collections.Generic;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing the logic to inspect member selection rules.
    /// </summary>
    public class MemberSelectionRuleInspector : IMemberSelectionRuleInspector
    {
        /// <summary>
        ///     Inspects the given rules for the given member.
        /// </summary>
        /// <exception cref="ArgumentNullException">rules can not be null.</exception>
        /// <exception cref="ArgumentNullException">memberInformation can not be null.</exception>
        /// <param name="rules">A collection of rules.</param>
        /// <param name="memberInformation">The member information to check.</param>
        /// <returns>Returns the inspection result.</returns>
        public MemberSelectionResult Inspect( IEnumerable<IMemberSelectionRule> rules, IMemberInformation memberInformation )
        {
            rules.ThrowIfNull( nameof(rules) );
            memberInformation.ThrowIfNull( nameof(memberInformation) );

            var result = MemberSelectionResult.Neutral;
            rules.ForEach( x =>
            {
                //Check if rule targets member and set result to rule result
                var selectionReult = x.GetSelectionResult( memberInformation );
                if ( selectionReult != MemberSelectionResult.Neutral )
                    result = selectionReult;
            } );

            return result;
        }
    }
}