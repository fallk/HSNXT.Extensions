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
//using System.Linq;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Extracts all Decimals from the given string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Invalid start index.</exception>
        /// <param name="value">The string to extract the decimals from.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <returns>The extracted decimals.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static List<Decimal> ExtractAllDecimal( [NotNull] this String value, Int32 startIndex = 0 )
            => new List<Decimal>( ExtractAllFloatingNumbers( value, startIndex )
                                      .Select( x => x.ToDecimal() ) );
    }
}
﻿#region Usings

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Extracts all Doubles from the given string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Invalid start index.</exception>
        /// <param name="value">The string to extract the doubles from.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <returns>The extracted doubles.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static List<Double> ExtractAllDouble( [NotNull] this String value, Int32 startIndex = 0 )
            => new List<Double>( ExtractAllFloatingNumbers( value, startIndex )
                                     .Select( x => x.ToDouble() ) );
    }
}
﻿#region Usings

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Extracts all Int16 from the given string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Invalid start index.</exception>
        /// <param name="value">The string to extract the decimal from.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <returns>The extracted Int16.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static List<Int16> ExtractAllInt16( [NotNull] this String value, Int32 startIndex = 0 )
            => new List<Int16>( ExtractAllNumbers( value, startIndex )
                                    .Select( x => x.ToInt16() ) );
    }
}
﻿#region Usings

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Extracts all Int32 from the given string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Invalid start index.</exception>
        /// <param name="value">The string to extract the decimal from.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <returns>The extracted Int32.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static List<Int32> ExtractAllInt32( [NotNull] this String value, Int32 startIndex = 0 )
            => new List<Int32>( ExtractAllNumbers( value, startIndex )
                                    .Select( x => x.ToInt32() ) );
    }
}
﻿#region Usings

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Extracts all Int64 from the given string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Invalid start index.</exception>
        /// <param name="value">The string to extract the decimal from.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <returns>The extracted Int64.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static List<Int64> ExtractAllInt64( [NotNull] this String value, Int32 startIndex = 0 )
            => new List<Int64>( ExtractAllNumbers( value, startIndex )
                                    .Select( x => x.ToInt64() ) );
    }
}
﻿#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Extracts the first Decimal from the given string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Invalid start index.</exception>
        /// <param name="value">The string to extract the decimal from.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <returns>The extracted decimal.</returns>
        [Pure]
        [PublicAPI]
        public static Decimal ExtractFirstDecimal( [NotNull] this String value, Int32 startIndex = 0 )
            => ExtractFloatingNumber( value, startIndex )
                .ToDecimal();
    }
}
﻿#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Extracts the first double from the given string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Invalid start index.</exception>
        /// <param name="value">The string to extract the decimal from.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <returns>The extracted double.</returns>
        [Pure]
        [PublicAPI]
        public static Double ExtractFirstDouble( [NotNull] this String value, Int32 startIndex = 0 )
            => ExtractFloatingNumber( value, startIndex )
                .ToDouble();
    }
}
﻿#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Extracts the first Int16 from the given string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Invalid start index.</exception>
        /// <param name="value">The string to extract the decimal from.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <returns>The extracted Int16.</returns>
        [Pure]
        [PublicAPI]
        public static Int16 ExtractFirstInt16( [NotNull] this String value, Int32 startIndex = 0 )
            => ExtractNumber( value, startIndex )
                .ToInt16();
    }
}
﻿#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Extracts the first Int32 from the given string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Invalid start index.</exception>
        /// <param name="value">The string to extract the decimal from.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <returns>The extracted Int32.</returns>
        [Pure]
        [PublicAPI]
        public static Int32 ExtractFirstInt32( [NotNull] this String value, Int32 startIndex = 0 )
            => ExtractNumber( value, startIndex )
                .ToInt32();
    }
}
﻿#region Usings

//using System;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Extracts the first Int64 from the given string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Invalid start index.</exception>
        /// <param name="value">The string to extract the decimal from.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <returns>The extracted Int64.</returns>
        [Pure]
        [PublicAPI]
        public static Int64 ExtractFirstInt64( [NotNull] this String value, Int32 startIndex = 0 )
            => ExtractNumber( value, startIndex )
                .ToInt64();
    }
}
﻿#region Usings

//using System;
//using System.Collections.Generic;
//using System.Text;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Extracts all floating point numbers from the given string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Invalid start index.</exception>
        /// <param name="value">The string to extract the decimal from.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <returns>The extracted floating point numbers as strings.</returns>
        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        [NotNull]
        [Pure]
        [PublicAPI]
        private static List<String> ExtractAllFloatingNumbers( [NotNull] this String value, Int32 startIndex = 0 )
        {
            value.ThrowIfNull( nameof(value) );

            if ( startIndex >= value.Length || startIndex < 0 )
                throw new ArgumentOutOfRangeException( nameof(value), "Invalid start index." );

            var chars = value.Substring( startIndex )
                             .ToCharArray();
            var decimals = new List<String>();

            var sb = new StringBuilder();
            for ( var i = 0; i < chars.Length; i++ )
                if ( chars[i]
                    .IsDigit() )
                {
                    if ( sb.Length == 0 && i > 0 && chars[i - 1] == '-' )
                        sb.Append( '-' );
                    sb.Append( chars[i] );
                }
                else if ( chars[i] == '.' && !sb.ToString()
                                                .Contains( "." ) && sb.Length > 0 )
                    sb.Append( '.' );
                else if ( sb.Length > 0 )
                {
                    decimals.Add( sb.ToString() );
                    sb.Clear();
                }
            if ( sb.Length > 0 )
                decimals.Add( sb.ToString() );

            return decimals;
        }
    }
}
﻿#region Usings

//using System;
//using System.Collections.Generic;
//using System.Text;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Extracts all numbers from the given string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Invalid start index.</exception>
        /// <param name="value">The string to extract the decimal from.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <returns>The extracted numbers as string.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        private static List<String> ExtractAllNumbers( [NotNull] this String value, Int32 startIndex = 0 )
        {
            value.ThrowIfNull( nameof(value) );

            if ( startIndex >= value.Length || startIndex < 0 )
                throw new ArgumentOutOfRangeException( nameof(value), "Invalid start index." );

            var chars = value.Substring( startIndex )
                             .ToCharArray();
            var numbers = new List<String>();

            var sb = new StringBuilder();
            for ( var i = 0; i < chars.Length; i++ )
                if ( chars[i]
                    .IsDigit() )
                {
                    if ( sb.Length == 0 && i > 0 && chars[i - 1] == '-' )
                        sb.Append( '-' );
                    sb.Append( chars[i] );
                }
                else if ( sb.Length > 0 )
                {
                    numbers.Add( sb.ToString() );
                    sb.Clear();
                }
            if ( sb.Length > 0 )
                numbers.Add( sb.ToString() );

            return numbers;
        }
    }
}
﻿#region Usings

//using System;
//using System.Text;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Extracts the first floating point number from the given string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Invalid start index.</exception>
        /// <param name="value">The string to extract the number from.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <returns>The extracted floating point number as string.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        private static String ExtractFloatingNumber( [NotNull] this String value, Int32 startIndex = 0 )
        {
            value.ThrowIfNull( nameof(value) );

            if ( startIndex >= value.Length || startIndex < 0 )
                throw new ArgumentOutOfRangeException( nameof(value), "Invalid start index." );

            var chars = value.Substring( startIndex )
                             .ToCharArray();
            var sb = new StringBuilder();

            for ( var i = 0; i < chars.Length; i++ )
                if ( chars[i]
                    .IsDigit() )
                {
                    if ( sb.Length == 0 && i > 0 && chars[i - 1] == '-' )
                        sb.Append( '-' );
                    sb.Append( chars[i] );
                }
                else if ( chars[i] == '.' && !sb.ToString()
                                                .Contains( "." ) && sb.Length > 0 )
                    sb.Append( '.' );
                else if ( sb.Length > 0 )
                    break;

            return sb.ToString();
        }
    }
}
﻿#region Usings

//using System;
//using System.Text;
//using JetBrains.Annotations;

#endregion

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Extracts the first none floating point number from the given string.
        /// </summary>
        /// <exception cref="ArgumentNullException">The value can not be null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Invalid start index.</exception>
        /// <param name="value">The string to extract the number from.</param>
        /// <param name="startIndex">The start index of the string.</param>
        /// <returns>The extracted number as string.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        private static String ExtractNumber( [NotNull] this String value, Int32 startIndex = 0 )
        {
            value.ThrowIfNull( nameof(value) );

            if ( startIndex >= value.Length || startIndex < 0 )
                throw new ArgumentOutOfRangeException( nameof(value), "Invalid start index." );

            var chars = value.Substring( startIndex )
                             .ToCharArray();
            var sb = new StringBuilder();

            for ( var i = 0; i < chars.Length; i++ )
                if ( chars[i]
                    .IsDigit() )
                {
                    if ( sb.Length == 0 && i > 0 && chars[i - 1] == '-' )
                        sb.Append( '-' );
                    sb.Append( chars[i] );
                }
                else if ( sb.Length > 0 )
                    break;

            return sb.ToString();
        }
    }
}