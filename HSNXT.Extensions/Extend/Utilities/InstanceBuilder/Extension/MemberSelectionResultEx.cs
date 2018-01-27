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

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="MemberSelectionResult" />.
    /// </summary>
    public static class MemberSelectionResultEx
    {
        /// <summary>
        ///     Converts the given <see cref="MemberSelectionResult" /> to a boolean value indicating whether to include or not.
        /// </summary>
        /// <param name="memberSelectionResult">The <see cref="MemberSelectionResult" /> to convert.</param>
        /// <returns>Returns the boolean value of the given <see cref="MemberSelectionResult" />.</returns>
        public static Boolean? AsBoolean( this MemberSelectionResult memberSelectionResult )
        {
            switch ( memberSelectionResult )
            {
                case MemberSelectionResult.IncludeMember:
                    return true;
                case MemberSelectionResult.ExcludeMember:
                    return false;
                case MemberSelectionResult.Neutral:
                    return null;
                default:
                    // This line can not be unit tested
                    throw new ArgumentOutOfRangeException( nameof(memberSelectionResult),
                                                           memberSelectionResult,
                                                           $"The member selection result '{memberSelectionResult}' is not supported." );
            }
        }
    }
}