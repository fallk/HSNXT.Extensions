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
    ///     Path based member selection rule.
    /// </summary>
    public class PathMemberSelectionRule : MemberSelectionRuleBase
    {
        #region Fields

        /// <summary>
        ///     Gets the member path used to find matching members.
        /// </summary>
        private readonly string _memberPath;

        /// <summary>
        ///     Gets the selection mode.
        /// </summary>
        private readonly MemberSelectionMode _selectionMode;

        #endregion

        #region Ctor

        /// <summary>
        ///     Initializes a new instance of the <see cref="PathMemberSelectionRule" /> class.
        /// </summary>
        /// <param name="memberPath">The member path used to find matching members.</param>
        /// <param name="selectionMode">The selection mode to apply.</param>
        /// <param name="name">The name of the rule.</param>
        /// <param name="description">The description of the rule.</param>
        public PathMemberSelectionRule( [NotNull] string memberPath, MemberSelectionMode selectionMode, string name = null, string description = null )
            : base( name, description )
        {
            memberPath.ThrowIfNull( nameof(memberPath) );

            _memberPath = memberPath;
            _selectionMode = selectionMode;
        }

        #endregion

        #region Overrides of MemberSelectionRuleBase

        /// <summary>
        ///     Gets the selection result for the given member.
        /// </summary>
        /// <param name="member">The member to get the selection result for.</param>
        /// <returns>Returns the selection result for the given member.</returns>
        public override MemberSelectionResult GetSelectionResult( IMemberInformation member )
        {
            var matchesPath = member.MemberPath == _memberPath;
            if ( !matchesPath )
                return MemberSelectionResult.Neutral;

            return _selectionMode == MemberSelectionMode.Include
                ? MemberSelectionResult.IncludeMember
                : MemberSelectionResult.ExcludeMember;
        }

        #endregion

        #region Overrides of Object

        /// <summary>
        ///     Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        ///     A string that represents the current object.
        /// </returns>
        public override string ToString()
            => $"[{RuleName}] = ({_selectionMode} members at {_memberPath}) ({RuleDescription}).";

        #endregion
    }
}