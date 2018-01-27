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
//using System.Globalization;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="DateTime" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Converts the DateTime value to a full date time string.
        /// </summary>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <returns>The given value converted to a full date time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToFullDateTimeString( this DateTime dateTime )
            => dateTime.ToString( "F", DateTimeFormatInfo.CurrentInfo );

        /// <summary>
        ///     Converts the DateTime value to a full date time string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The format info can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="formatInfo">The date time format info.</param>
        /// <returns>The given value converted to a full date time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToFullDateTimeString( this DateTime dateTime, [NotNull] DateTimeFormatInfo formatInfo )
        {
            formatInfo.ThrowIfNull( nameof(formatInfo) );

            return dateTime.ToString( "F", formatInfo );
        }

        /// <summary>
        ///     Converts the DateTime value to a full date time string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The culture can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="culture">The culture.</param>
        /// <returns>The given value converted to a full date time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToFullDateTimeString( this DateTime dateTime, [NotNull] CultureInfo culture )
        {
            culture.ThrowIfNull( nameof(culture) );

            return dateTime.ToString( "F", culture );
        }
    }
}
﻿#region Usings

//using System;
//using System.Globalization;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="DateTime" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Converts the DateTime value to a long date short time string.
        /// </summary>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <returns>The given value converted to a long date short time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToLongDateShortTimeString( this DateTime dateTime )
            => dateTime.ToString( "f", DateTimeFormatInfo.CurrentInfo );

        /// <summary>
        ///     Converts the DateTime value to a long date short time string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The format info can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="formatInfo">The date time format info.</param>
        /// <returns>The given value converted to a long date short time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToLongDateShortTimeString( this DateTime dateTime, [NotNull] DateTimeFormatInfo formatInfo )
        {
            formatInfo.ThrowIfNull( nameof(formatInfo) );

            return dateTime.ToString( "f", formatInfo );
        }

        /// <summary>
        ///     Converts the DateTime value to a long date short time string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The culture can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="culture">The culture.</param>
        /// <returns>The given value converted to a long date short time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToLongDateShortTimeString( this DateTime dateTime, [NotNull] CultureInfo culture )
        {
            culture.ThrowIfNull( nameof(culture) );

            return dateTime.ToString( "f", culture );
        }
    }
}
﻿#region Usings

//using System;
//using System.Globalization;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="DateTime" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Converts the DateTime value to a long date time string.
        /// </summary>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <returns>The given value converted to a long date time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToLongDateString( this DateTime dateTime )
            => dateTime.ToString( "D", DateTimeFormatInfo.CurrentInfo );

        /// <summary>
        ///     Converts the DateTime value to a long date time string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The format info can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="formatInfo">The date time format info.</param>
        /// <returns>The given value converted to a long date time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToLongDateString( this DateTime dateTime, [NotNull] DateTimeFormatInfo formatInfo )
        {
            formatInfo.ThrowIfNull( nameof(formatInfo) );

            return dateTime.ToString( "D", formatInfo );
        }

        /// <summary>
        ///     Converts the DateTime value to a long date time string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The culture can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="culture">The culture.</param>
        /// <returns>The given value converted to a long date time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToLongDateString( this DateTime dateTime, [NotNull] CultureInfo culture )
        {
            culture.ThrowIfNull( nameof(culture) );

            return dateTime.ToString( "D", culture );
        }
    }
}
﻿#region Usings

//using System;
//using System.Globalization;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="DateTime" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Converts the DateTime value to a long time string.
        /// </summary>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <returns>The given value converted to a long time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToLongTimeString( this DateTime dateTime )
            => dateTime.ToString( "T", DateTimeFormatInfo.CurrentInfo );

        /// <summary>
        ///     Converts the DateTime value to a long time string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The format info can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="formatInfo">The date time format info.</param>
        /// <returns>The given value converted to a long time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToLongTimeString( this DateTime dateTime, [NotNull] DateTimeFormatInfo formatInfo )
        {
            formatInfo.ThrowIfNull( nameof(formatInfo) );

            return dateTime.ToString( "T", formatInfo );
        }

        /// <summary>
        ///     Converts the DateTime value to a long time string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The culture can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="culture">The culture.</param>
        /// <returns>The given value converted to a long time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToLongTimeString( this DateTime dateTime, [NotNull] CultureInfo culture )
        {
            culture.ThrowIfNull( nameof(culture) );

            return dateTime.ToString( "T", culture );
        }
    }
}
﻿#region Usings

//using System;
//using System.Globalization;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="DateTime" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Converts the DateTime value to a month day string.
        /// </summary>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <returns>The given value converted to a month day string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToMonthDayString( this DateTime dateTime )
            => dateTime.ToString( "m", DateTimeFormatInfo.CurrentInfo );

        /// <summary>
        ///     Converts the DateTime value to a month day string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The format info can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="formatInfo">The date time format info.</param>
        /// <returns>The given value converted to a month day string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToMonthDayString( this DateTime dateTime, [NotNull] DateTimeFormatInfo formatInfo )
        {
            formatInfo.ThrowIfNull( nameof(formatInfo) );

            return dateTime.ToString( "m", formatInfo );
        }

        /// <summary>
        ///     Converts the DateTime value to a month day string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The culture can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="culture">The culture.</param>
        /// <returns>The given value converted to a month day string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToMonthDayString( this DateTime dateTime, [NotNull] CultureInfo culture )
        {
            culture.ThrowIfNull( nameof(culture) );

            return dateTime.ToString( "m", culture );
        }
    }
}
﻿#region Usings

//using System;
//using System.Globalization;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="DateTime" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Converts the DateTime value to a month string.
        /// </summary>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <returns>The given value converted to a year month string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToMonthString( this DateTime dateTime )
            => dateTime.ToString( "MMMM", DateTimeFormatInfo.CurrentInfo );

        /// <summary>
        ///     Converts the DateTime value to a month string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The format info can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="formatInfo">The date time format info.</param>
        /// <returns>The given value converted to year month string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToMonthString( this DateTime dateTime, [NotNull] DateTimeFormatInfo formatInfo )
        {
            formatInfo.ThrowIfNull( nameof(formatInfo) );

            return dateTime.ToString( "MMMM", formatInfo );
        }

        /// <summary>
        ///     Converts the DateTime value to a month string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The culture can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="culture">The culture.</param>
        /// <returns>The given value converted to a year month string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToMonthString( this DateTime dateTime, [NotNull] CultureInfo culture )
        {
            culture.ThrowIfNull( nameof(culture) );

            return dateTime.ToString( "MMMM", culture );
        }
    }
}
﻿#region Usings

//using System;
//using System.Globalization;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="DateTime" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Converts the DateTime value to a short date long time string.
        /// </summary>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <returns>The given value converted to a short date long time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToShortDateLongTimeString( this DateTime dateTime )
            => dateTime.ToString( "G", DateTimeFormatInfo.CurrentInfo );

        /// <summary>
        ///     Converts the DateTime value to a short date long time string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The format info can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="formatInfo">The date time format info.</param>
        /// <returns>The given value converted to a short date long time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToShortDateLongTimeString( this DateTime dateTime, [NotNull] DateTimeFormatInfo formatInfo )
        {
            formatInfo.ThrowIfNull( nameof(formatInfo) );

            return dateTime.ToString( "G", formatInfo );
        }

        /// <summary>
        ///     Converts the DateTime value to a short date long time string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The culture can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="culture">The culture.</param>
        /// <returns>The given value converted to a short date long time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToShortDateLongTimeString( this DateTime dateTime, [NotNull] CultureInfo culture )
        {
            culture.ThrowIfNull( nameof(culture) );

            return dateTime.ToString( "G", culture );
        }
    }
}
﻿#region Usings

//using System;
//using System.Globalization;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="DateTime" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Converts the DateTime value to a short date string.
        /// </summary>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <returns>The given value converted to a short date string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToShortDateString( this DateTime dateTime )
            => dateTime.ToString( "d", DateTimeFormatInfo.CurrentInfo );

        /// <summary>
        ///     Converts the DateTime value to a short date string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The format info can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="formatInfo">The date time format info.</param>
        /// <returns>The given value converted to a short date string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToShortDateString( this DateTime dateTime, [NotNull] DateTimeFormatInfo formatInfo )
        {
            dateTime.ThrowIfNull( nameof(dateTime) );
            formatInfo.ThrowIfNull( nameof(formatInfo) );

            return dateTime.ToString( "d", formatInfo );
        }

        /// <summary>
        ///     Converts the DateTime value to a short date string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The culture can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="culture">The culture.</param>
        /// <returns>The given value converted to a short date string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToShortDateString( this DateTime dateTime, [NotNull] CultureInfo culture )
        {
            culture.ThrowIfNull( nameof(culture) );

            return dateTime.ToString( "d", culture );
        }
    }
}
﻿#region Usings

//using System;
//using System.Globalization;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="DateTime" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Converts the DateTime value to a short date time string.
        /// </summary>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <returns>The given value converted to a short date time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToShortDateTimeString( this DateTime dateTime )
            => dateTime.ToString( "g", DateTimeFormatInfo.CurrentInfo );

        /// <summary>
        ///     Converts the DateTime value to a short date time string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The format info can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="formatInfo">The date time format info.</param>
        /// <returns>The given value converted to a short date time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToShortDateTimeString( this DateTime dateTime, [NotNull] DateTimeFormatInfo formatInfo )
        {
            formatInfo.ThrowIfNull( nameof(formatInfo) );

            return dateTime.ToString( "g", formatInfo );
        }

        /// <summary>
        ///     Converts the DateTime value to a short date time string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The culture can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="culture">The culture.</param>
        /// <returns>The given value converted to a short date time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToShortDateTimeString( this DateTime dateTime, [NotNull] CultureInfo culture )
        {
            culture.ThrowIfNull( nameof(culture) );

            return dateTime.ToString( "g", culture );
        }
    }
}
﻿#region Usings

//using System;
//using System.Globalization;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="DateTime" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Converts the DateTime value to a short time string.
        /// </summary>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <returns>The given value converted to a short time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToShortTimeString( this DateTime dateTime ) => dateTime.ToString( "t", DateTimeFormatInfo.CurrentInfo );

        /// <summary>
        ///     Converts the DateTime value to a short time string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The format info can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="formatInfo">The date time format info.</param>
        /// <returns>The given value converted to a short time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToShortTimeString( this DateTime dateTime, [NotNull] DateTimeFormatInfo formatInfo )
        {
            formatInfo.ThrowIfNull( nameof(formatInfo) );

            return dateTime.ToString( "t", formatInfo );
        }

        /// <summary>
        ///     Converts the DateTime value to a short time string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The culture can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="culture">The culture.</param>
        /// <returns>The given value converted to a short time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToShortTimeString( this DateTime dateTime, [NotNull] CultureInfo culture )
        {
            culture.ThrowIfNull( nameof(culture) );

            return dateTime.ToString( "t", culture );
        }
    }
}
﻿#region Usings

//using System;
//using System.Globalization;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="DateTime" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Converts the DateTime value to a sortable date time string.
        /// </summary>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <returns>The given value converted to a sortable date time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToSortableDateTimeString( this DateTime dateTime )
            => dateTime.ToString( "s", DateTimeFormatInfo.CurrentInfo );

        /// <summary>
        ///     Converts the DateTime value to a sortable date time string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The format info can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="formatInfo">The date time format info.</param>
        /// <returns>The given value converted to a sortable date time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToSortableDateTimeString( this DateTime dateTime, [NotNull] DateTimeFormatInfo formatInfo )
        {
            formatInfo.ThrowIfNull( nameof(formatInfo) );

            return dateTime.ToString( "s", formatInfo );
        }

        /// <summary>
        ///     Converts the DateTime value to a sortable date time string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The culture can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="culture">The culture.</param>
        /// <returns>The given value converted to a sortable date time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToSortableDateTimeString( this DateTime dateTime, [NotNull] CultureInfo culture )
        {
            culture.ThrowIfNull( nameof(culture) );

            return dateTime.ToString( "s", culture );
        }
    }
}
﻿#region Usings

//using System;
//using System.Globalization;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="DateTime" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Converts the DateTime value to a universal sortable date time string.
        /// </summary>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <returns>The given value converted to a universal sortable date time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToUniversalSortableDateTimeString( this DateTime dateTime )
            => dateTime.ToString( "u", DateTimeFormatInfo.CurrentInfo );

        /// <summary>
        ///     Converts the DateTime value to a universal sortable date time string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The format info can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="formatInfo">The date time format info.</param>
        /// <returns>The given value converted to a universal sortable date time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToUniversalSortableDateTimeString( this DateTime dateTime, [NotNull] DateTimeFormatInfo formatInfo )
        {
            formatInfo.ThrowIfNull( nameof(formatInfo) );

            return dateTime.ToString( "u", formatInfo );
        }

        /// <summary>
        ///     Converts the DateTime value to a universal sortable date time string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The culture can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="culture">The culture.</param>
        /// <returns>The given value converted to a universal sortable date time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToUniversalSortableDateTimeString( this DateTime dateTime, [NotNull] CultureInfo culture )
        {
            culture.ThrowIfNull( nameof(culture) );

            return dateTime.ToString( "u", culture );
        }
    }
}
﻿#region Usings

//using System;
//using System.Globalization;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="DateTime" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Converts the DateTime value to a universal sortable long date time string.
        /// </summary>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <returns>The given value converted to a universal sortable long date time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToUniversalSortableLongDateTimeString( this DateTime dateTime )
            => dateTime.ToString( "U", DateTimeFormatInfo.CurrentInfo );

        /// <summary>
        ///     Converts the DateTime value to a universal sortable long date time string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The format info can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="formatInfo">The date time format info.</param>
        /// <returns>The given value converted to a universal sortable long date time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToUniversalSortableLongDateTimeString( this DateTime dateTime, [NotNull] DateTimeFormatInfo formatInfo )
        {
            formatInfo.ThrowIfNull( nameof(formatInfo) );

            return dateTime.ToString( "U", formatInfo );
        }

        /// <summary>
        ///     Converts the DateTime value to a universal sortable long date time string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The culture can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="culture">The culture.</param>
        /// <returns>The given value converted to a universal sortable long date time string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToUniversalSortableLongDateTimeString( this DateTime dateTime, [NotNull] CultureInfo culture )
        {
            culture.ThrowIfNull( nameof(culture) );

            return dateTime.ToString( "U", culture );
        }
    }
}
﻿#region Usings

//using System;
//using System.Globalization;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="DateTime" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Converts the DateTime value to a year month string.
        /// </summary>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <returns>The given value converted to a year month string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToYearMonthString( this DateTime dateTime )
            => dateTime.ToString( "y", DateTimeFormatInfo.CurrentInfo );

        /// <summary>
        ///     Converts the DateTime value to year month string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The format info can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="formatInfo">The date time format info.</param>
        /// <returns>The given value converted to year month string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToYearMonthString( this DateTime dateTime, [NotNull] DateTimeFormatInfo formatInfo )
        {
            formatInfo.ThrowIfNull( nameof(formatInfo) );

            return dateTime.ToString( "y", formatInfo );
        }

        /// <summary>
        ///     Converts the DateTime value to a year month string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The culture can not be null.</exception>
        /// <param name="dateTime">The DateTime value to convert.</param>
        /// <param name="culture">The culture.</param>
        /// <returns>The given value converted to a year month string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static String ToYearMonthString( this DateTime dateTime, [NotNull] CultureInfo culture )
        {
            culture.ThrowIfNull( nameof(culture) );

            return dateTime.ToString( "y", culture );
        }
    }
}