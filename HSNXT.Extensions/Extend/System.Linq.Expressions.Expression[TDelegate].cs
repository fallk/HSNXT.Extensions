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
        ///     Gets the member info of from the given member expression.
        /// </summary>
        /// <remarks>
        ///     Contains logic to work with unary expressions:
        ///     E.g. to work with expressions containing a Convert node.
        /// </remarks>
        /// <exception cref="ArgumentNullException">expression can not be null.</exception>
        /// <typeparam name="TDeclairingType">The type of the declaring type.</typeparam>
        /// <typeparam name="TMember">The type of the member.</typeparam>
        /// <param name="expression">The member expression.</param>
        /// <returns>Returns the member info from the given expression, or null if the expression is not valid.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static MemberInfo GetMemberInfoFromExpression<TDeclairingType, TMember>(
            [NotNull] this Expression<Func<TDeclairingType, TMember>> expression )
        {
            expression.ThrowIfNull( nameof(expression) );

            expression.TryGetMemberExpression( out var memberExpression );
            return memberExpression.Member;
        }
        /// <summary>
        ///     Gets a dotted path of property names representing the property expression. E.g. Parent.Child.Sibling.Name.
        /// </summary>
        /// <exception cref="ArgumentNullException">expression can not be null.</exception>
        /// <param name="expression">The expression pointing to the member.</param>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static string GetMemberPath<TDeclaringType, TMember>( [NotNull] this Expression<Func<TDeclaringType, TMember>> expression )
        {
            expression.ThrowIfNull( nameof(expression) );

            var result = new List<string>();
            Expression node = expression;

            while ( node != null )
                // ReSharper disable once SwitchStatementMissingSomeCases
                switch ( node.NodeType )
                {
                    case ExpressionType.Lambda:
                        node = ( (LambdaExpression) node ).Body;
                        break;

                    case ExpressionType.Convert:
                        var unaryExpression = (UnaryExpression) node;
                        node = unaryExpression.Operand;
                        break;

                    case ExpressionType.MemberAccess:
                        var memberExpression = (MemberExpression) node;
                        node = memberExpression.Expression;
                        result.Add( memberExpression.Member.Name );
                        break;

                    case ExpressionType.ArrayIndex:
                        var binaryExpression = (BinaryExpression) node;
                        var constantExpression = (ConstantExpression) binaryExpression.Right;
                        node = binaryExpression.Left;
                        result.Add( "[" + constantExpression.Value + "]" );
                        break;

                    case ExpressionType.Parameter:
                        node = null;
                        break;

                    default:
                        throw new ArgumentOutOfRangeException( nameof(expression.Body),
                                                               expression.Body,
                                                               $"Expression '{expression.Body}' cannot be used to select a member." );
                }

            return result
                .AsEnumerable()
                .Reverse()
                .StringJoin( "." )
                .Replace( ".[", "[" );
        }
    }
}