using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Converts the value in number format {1 , 0}.
        /// </summary>
        /// <param name="boolean"></param>
        /// <returns>int</returns>
        /// <example>
        /// 	<code>
        /// 		int result= default(bool).ToBinaryTypeNumber()
        /// 	</code>
        /// </example>
        /// <remarks>
        /// 	Contributed by Mohammad Rahman, http://mohammad-rahman.blogspot.com/
        /// </remarks>
        public static int ToBinaryTypeNumber(this Boolean boolean)
        {
            return boolean ? 1 : 0;
        }
    }
}