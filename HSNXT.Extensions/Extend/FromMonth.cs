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
        ///     Returns a date-time representing the specified day in April
        ///     in the specified year.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>Return a date-time representing the specified day in April in the specified year.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime April( this Int16 day, Int16 year )
            => new DateTime( year, 4, day );
    }
}
﻿#region Usings

//using System;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="short" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Returns a date-time representing the specified day in August
        ///     in the specified year.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>Return a date-time representing the specified day in August in the specified year.</returns>
        /// [Pure]
        /// [PublicAPI]
        public static DateTime August( this Int16 day, Int16 year )
            => new DateTime( year, 8, day );
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
        ///     Returns a date-time representing the specified day in December
        ///     in the specified year.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>Return a date-time representing the specified day in December in the specified year.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime December( this Int16 day, Int16 year )
            => new DateTime( year, 12, day );
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
        ///     Returns a date-time representing the specified day in February
        ///     in the specified year.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>Return a date-time representing the specified day in February in the specified year.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime February( this Int16 day, Int16 year )
            => new DateTime( year, 2, day );
    }
}
﻿#region Usings

//using System;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="short" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Returns a date-time representing the specified day in January
        ///     in the specified year.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>Return a date-time representing the specified day in January in the specified year.</returns>
        /// [Pure]
        /// [PublicAPI]
        public static DateTime January( this Int16 day, Int16 year )
            => new DateTime( year, 1, day );
    }
}
﻿#region Usings

//using System;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="short" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Returns a date-time representing the specified day in July
        ///     in the specified year.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>Return a date-time representing the specified day in July in the specified year.</returns>
        /// [Pure]
        /// [PublicAPI]
        public static DateTime July( this Int16 day, Int16 year )
            => new DateTime( year, 7, day );
    }
}
﻿#region Usings

//using System;

#endregion

namespace HSNXT
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="short" />.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Returns a date-time representing the specified day in June
        ///     in the specified year.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>Return a date-time representing the specified day in June in the specified year.</returns>
        /// [Pure]
        /// [PublicAPI]
        public static DateTime June( this Int16 day, Int16 year )
            => new DateTime( year, 6, day );
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
        ///     Returns a date-time representing the specified day in March
        ///     in the specified year.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>Return a date-time representing the specified day in March in the specified year.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime March( this Int16 day, Int16 year )
            => new DateTime( year, 3, day );
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
        ///     Returns a date-time representing the specified day in May
        ///     in the specified year.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>Return a date-time representing the specified day in May in the specified year.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime May( this Int16 day, Int16 year )
            => new DateTime( year, 5, day );
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
        ///     Returns a date-time representing the specified day in November
        ///     in the specified year.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>Return a date-time representing the specified day in November in the specified year.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime November( this Int16 day, Int16 year )
            => new DateTime( year, 11, day );
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
        ///     Returns a date-time representing the specified day in October
        ///     in the specified year.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>Return a date-time representing the specified day in October in the specified year.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime October( this Int16 day, Int16 year )
            => new DateTime( year, 10, day );
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
        ///     Returns a date-time representing the specified day in September
        ///     in the specified year.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>Return a date-time representing the specified day in September in the specified year.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime September( this Int16 day, Int16 year )
            => new DateTime( year, 9, day );
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
        ///     Returns a date-time representing the specified day in April
        ///     in the specified year.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>Return a date-time representing the specified day in April in the specified year.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime April( this Int32 day, Int32 year )
            => new DateTime( year, 4, day );
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
        ///     Returns a date-time representing the specified day in August
        ///     in the specified year.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>Return a date-time representing the specified day in August in the specified year.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime August( this Int32 day, Int32 year )
            => new DateTime( year, 8, day );
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
        ///     Returns a date-time representing the specified day in December
        ///     in the specified year.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>Return a date-time representing the specified day in December in the specified year.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime December( this Int32 day, Int32 year )
            => new DateTime( year, 12, day );
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
        ///     Returns a date-time representing the specified day in February
        ///     in the specified year.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>Return a date-time representing the specified day in February in the specified year.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime February( this Int32 day, Int32 year )
            => new DateTime( year, 2, day );
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
        ///     Returns a date-time representing the specified day in January
        ///     in the specified year.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>Return a date-time representing the specified day in January in the specified year.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime January( this Int32 day, Int32 year )
            => new DateTime( year, 1, day );
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
        ///     Returns a date-time representing the specified day in July
        ///     in the specified year.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>Return a date-time representing the specified day in July in the specified year.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime July( this Int32 day, Int32 year )
            => new DateTime( year, 7, day );
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
        ///     Returns a date-time representing the specified day in June
        ///     in the specified year.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>Return a date-time representing the specified day in June in the specified year.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime June( this Int32 day, Int32 year )
            => new DateTime( year, 6, day );
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
        ///     Returns a date-time representing the specified day in March
        ///     in the specified year.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>Return a date-time representing the specified day in March in the specified year.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime March( this Int32 day, Int32 year )
            => new DateTime( year, 3, day );
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
        ///     Returns a date-time representing the specified day in May
        ///     in the specified year.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>Return a date-time representing the specified day in May in the specified year.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime May( this Int32 day, Int32 year )
            => new DateTime( year, 5, day );
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
        ///     Returns a date-time representing the specified day in November
        ///     in the specified year.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>Return a date-time representing the specified day in November in the specified year.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime November( this Int32 day, Int32 year )
            => new DateTime( year, 11, day );
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
        ///     Returns a date-time representing the specified day in October
        ///     in the specified year.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>Return a date-time representing the specified day in October in the specified year.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime October( this Int32 day, Int32 year )
            => new DateTime( year, 10, day );
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
        ///     Returns a date-time representing the specified day in September
        ///     in the specified year.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns>Return a date-time representing the specified day in September in the specified year.</returns>
        [Pure]
        [PublicAPI]
        public static DateTime September( this Int32 day, Int32 year )
            => new DateTime( year, 9, day );
    }
}