﻿using System;
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
    /// <summary>
    ///     XOr specification.
    /// </summary>
    /// <typeparam name="T">The target type of the specification.</typeparam>
    public class XOrSpecification<T> : OperatorSpecification<T>
    {
        #region Ctor

        /// <summary>
        ///     Initialize a new instance of the <see cref="XOrSpecification{T}" /> class.
        /// </summary>
        /// <exception cref="ArgumentNullException">left can not be null.</exception>
        /// <exception cref="ArgumentNullException">right can not be null.</exception>
        /// <param name="left">The left specification.</param>
        /// <param name="right">The right specification.</param>
        public XOrSpecification( [NotNull] ISpecification<T> left, [NotNull] ISpecification<T> right )
            : base( left, right )
        {
        }

        #endregion

        #region Overrides of Specification<T>

        /// <summary>
        ///     Checks if the given objects satisfies the specification.
        /// </summary>
        /// <param name="obj">The object to validate.</param>
        /// <returns>Returns true if the object satisfies the specification; otherwise, false.</returns>
        public override Boolean IsSatisfiedBy( T obj )
            => Left.IsSatisfiedBy( obj ) ^ Right.IsSatisfiedBy( obj );

        /// <summary>
        ///     Checks if the given objects satisfies the specification.
        /// </summary>
        /// <param name="obj">The object to validate.</param>
        /// <returns>Returns a collection of error messages.</returns>
        public override IEnumerable<String> IsSatisfiedByWithMessages( T obj )
        {
            var leftResult = Left.IsSatisfiedByWithMessages( obj )
                                 .ToList();
            var rightResult = Right.IsSatisfiedByWithMessages( obj )
                                   .ToList();

            if ( leftResult.NotAny() ^ rightResult.NotAny() )
                return new String[0];

            if ( leftResult.NotAny() && rightResult.NotAny() )
                return new List<String> { "The given object matches both specifications." };
            return leftResult.Concat( rightResult );
        }

        #endregion
    }
}