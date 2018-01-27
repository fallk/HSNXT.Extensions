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
    public static partial class Extensions
    {
        /// <summary>
        ///     Tries to get a <see cref="MemberExpression" /> from the given expression.
        /// </summary>
        /// <exception cref="ArgumentNullException">expression can not be null.</exception>
        /// <param name="expression">The expression.</param>
        /// <param name="memberExpression">The extracted <see cref="MemberExpression" />.</param>
        /// <returns>Returns true if a <see cref="MemberExpression" /> could be extracted; otherwise, false.</returns>
        [Pure]
        [PublicAPI]
        public static bool TryGetMemberExpression( [NotNull] this Expression expression, out MemberExpression memberExpression )
        {
            expression.ThrowIfNull( nameof(expression) );

            while ( true )
                // ReSharper disable once SwitchStatementMissingSomeCases
                switch ( expression.NodeType )
                {
                    case ExpressionType.MemberAccess:
                        memberExpression = expression as MemberExpression;
                        return true;

                    case ExpressionType.Convert:
                        // ReSharper disable once PossibleNullReferenceException
                        var operand = ( expression as UnaryExpression ).Operand;
                        // Check if operand is member expression
                        if ( operand is MemberExpression )
                        {
                            memberExpression = operand as MemberExpression;
                            return true;
                        }

                        // Operand type is not supported
                        memberExpression = null;
                        return false;

                    case ExpressionType.Constant:
                        memberExpression = null;
                        return false;

                    case ExpressionType.Lambda:
                        expression = ( (LambdaExpression) expression ).Body;
                        break;

                    default:
                        memberExpression = null;
                        return false;
                }
        }
    }
}