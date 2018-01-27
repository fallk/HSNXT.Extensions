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

#endregion

namespace HSNXT.Internal
{
    /// <summary>
    ///     Base class for value providers.
    /// </summary>
    public abstract class ValueProviderBase : IValueProvider
    {
        #region Constants

        /// <summary>
        ///     Character used to separate property name and format.
        /// </summary>
        private const Char FormatSeperator = ':';

        #endregion

        #region Implementation of IValueProvider

        /// <summary>
        ///     Gets the value represented by the given expression.
        /// </summary>
        /// <param name="expression">The name of a property optionally combined with a string format compatible expression.</param>
        /// <returns>Returns the value represented by the given expression.</returns>
        public abstract String GetValue( String expression );

        #endregion

        /// <summary>
        ///     Extracts the format information from the given expression.
        /// </summary>
        /// <param name="expression">The name of a property optionally combined with a string format compatible expression.</param>
        /// <returns>Returns the format information.</returns>
        protected static FormatInformation ParsExpression( String expression )
        {
            var colonIndex = expression.IndexOf( FormatSeperator );

            return colonIndex <= 0
                ? new FormatInformation( expression, null )
                : new FormatInformation( expression.Substring( 0, colonIndex ), "{0:" + expression.Substring( colonIndex + 1 ) + "}" );
        }
    }
}