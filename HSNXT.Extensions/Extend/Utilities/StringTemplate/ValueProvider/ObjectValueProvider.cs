using System;
using System.Collections.Generic;
using System.Reflection;
using HSNXT.JetBrains.Annotations;
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


namespace HSNXT.Internal
{
    /// <summary>
    ///     Value provider for objects.
    /// </summary>
    public class ObjectValueProvider : ValueProviderBase
    {
        #region Fields

        /// <summary>
        ///     The source object.
        /// </summary>
        private readonly object _source;

        #endregion

        #region Ctor

        /// <summary>
        ///     Initializes a new instance of the <see cref="ObjectValueProvider" /> class.
        /// </summary>
        /// <exception cref="ArgumentNullException">source can not be null.</exception>
        /// <param name="source">The source object.</param>
        public ObjectValueProvider( object source )
        {
            source.ThrowIfNull( nameof(source) );

            _source = source;
        }

        #endregion

        #region Implementation of IValueProvider

        /// <summary>
        ///     Gets the value represented by the given expression.
        /// </summary>
        /// <param name="expression">The name of a property optionally combined with a string format compatible expression.</param>
        /// <returns>Returns the value represented by the given expression.</returns>
        public override string GetValue( string expression )
        {
            try
            {
                var formatInformation = ParsExpression( expression );
                var value = ExpressionEvaluator.GetValue( formatInformation.ValueName, _source );

                return formatInformation.Format.IsNullOrEmpty()
                    ? value?.ToString()
                    : formatInformation.Format.F( value );
            }
            catch ( Exception ex )
            {
                throw new FormatException( $"Invalid format, invalid formatted expression: '{expression}'", ex );
            }
        }

        #endregion
    }
}