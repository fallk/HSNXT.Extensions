#region License, Terms and Author(s)
//
// Mannex - Extension methods for .NET
// Copyright (c) 2009 Atif Aziz. All rights reserved.
//
//  Author(s):
//
//      Atif Aziz, http://www.raboof.com
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion

namespace HSNXT
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    /// <summary>
    /// Extension methods for <see cref="Enum"/>.
    /// </summary>
    public static partial class Extensions
    {
        #if NET4

        /// <summary>
        /// Determines whether any of the given bit fields are set in the 
        /// current instance.
        /// </summary>

        public static bool HasEitherFlag(this Enum value, Enum flag1, Enum flag2)
        {
            return value.HasFlag(flag1) || value.HasFlag(flag2);
        }

        /// <summary>
        /// Determines whether any of the given bit fields are set in the 
        /// current instance.
        /// </summary>

        public static bool HasEitherFlag(this Enum value, Enum flag1, Enum flag2, Enum flag3)
        {
            return value.HasEitherFlag(flag1, flag2) || value.HasFlag(flag3);
        }

        /// <summary>
        /// Determines whether any of the given bit fields are set in the 
        /// current instance.
        /// </summary>

        public static bool HasEitherFlag(this Enum value, Enum flag1, Enum flag2, Enum flag3, Enum flag4)
        {
            return value.HasEitherFlag(flag1, flag2, flag3) || value.HasFlag(flag4);
        }

        /// <summary>
        /// Determines whether any of the given bit fields are set in the 
        /// current instance.
        /// </summary>

        public static bool HasEitherFlag(this Enum value, Enum flag1, Enum flag2, Enum flag3, Enum flag4, Enum flag5, params Enum[] others)
        {
            return value.HasEitherFlag(flag1, flag2, flag3, flag4) 
                || value.HasFlag(flag5) 
                || others.Any(value.HasFlag);
        }

        #endif
    }
}
