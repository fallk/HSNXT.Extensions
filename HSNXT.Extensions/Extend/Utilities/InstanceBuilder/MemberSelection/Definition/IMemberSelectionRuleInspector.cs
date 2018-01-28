using System;
using System.Collections.Generic;
using System.Reflection;
using HSNXT.JetBrains.Annotations;
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
    ///     Interface representing a rule inspector.
    /// </summary>
    public interface IMemberSelectionRuleInspector
    {
        /// <summary>
        ///     Inspects the given rules for the given member.
        /// </summary>
        /// <param name="rules">A collection of rules.</param>
        /// <param name="memberInformation">The member information to check.</param>
        /// <returns>Returns the inspection result.</returns>
        MemberSelectionResult Inspect( IEnumerable<IMemberSelectionRule> rules, IMemberInformation memberInformation );
    }
}