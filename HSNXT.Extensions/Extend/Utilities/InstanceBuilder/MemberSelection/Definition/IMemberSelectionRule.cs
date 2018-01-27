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
    ///     Interface representing a member selection rule.
    /// </summary>
    public interface IMemberSelectionRule
    {
        #region Properties

        /// <summary>
        ///     Gets the name of the rule.
        /// </summary>
        /// <value>The name of the rule.</value>
        String RuleName { get; }

        /// <summary>
        ///     Gets the description of the rule.
        /// </summary>
        /// <value>The description of the rule.</value>
        String RuleDescription { get; }

        #endregion

        /// <summary>
        ///     Gets the selection result for the given member.
        /// </summary>
        /// <param name="member">The member to get the selection result for.</param>
        /// <returns>Returns the selection result for the given member.</returns>
        [PublicAPI]
        MemberSelectionResult GetSelectionResult( IMemberInformation member );
    }
}