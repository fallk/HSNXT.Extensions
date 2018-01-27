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
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="short" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Returns the number of days in the specified month of the specified year.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <param name="month">The month.</param>
        /// <returns>
        ///     Returns the number of days of the specified month.
        ///     For example February (2), the return value is 28 or 29 depending upon whether is a leap year.
        /// </returns>
        [Pure]
        [PublicAPI]
        public static Int32 DaysInMonth( this Int16 year, Int16 month )
            => DateTime.DaysInMonth( year, month );
    }
}
﻿#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="short" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Returns whether the given year is a leap year or not.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>Returns true if the year is a leap year, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean IsLeapYear( this Int16 year )
            => DateTime.IsLeapYear( year );
    }
}
﻿#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="int" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Returns the number of days in the specified month of the specified year.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <param name="month">The month.</param>
        /// <returns>
        ///     Returns the number of days of the specified month.
        ///     For example February (2), the return value is 28 or 29 depending upon whether is a leap year.
        /// </returns>
        [Pure]
        [PublicAPI]
        public static Int32 DaysInMonth( this Int32 year, Int32 month )
            => DateTime.DaysInMonth( year, month );
    }
}
﻿#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="int" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Returns whether the given year is a leap year or not.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>Returns true if the year is a leap year, otherwise false.</returns>
        [Pure]
        [PublicAPI]
        public static Boolean IsLeapYear( this Int32 year )
            => DateTime.IsLeapYear( year );
    }
}