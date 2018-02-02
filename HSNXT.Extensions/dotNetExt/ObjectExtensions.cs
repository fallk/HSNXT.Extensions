﻿//Copyright (c) Chris Pietschmann 2012 (http://pietschsoft.com)
//All rights reserved.
//Licensed under the GNU Library General Public License (LGPL)
//License can be found here: http://www.codeplex.com/dotNetExt/license

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;

namespace HSNXT
{
    public static partial class Extensions
    {
#if NetFX
        /// <summary>
        /// Executes a method on an object and returns the result
        /// </summary>
        /// <param name="obj">Required. A pointer to the object exposing the property or method.</param>
        /// <param name="methodName">A string expression containing the property or method of the object.</param>
        /// <param name="args">Optional. A parameter array containing the arguments to be passed to the property or method.</param>
        /// <returns></returns>
        public static object CallMethodByName(this object obj, string methodName, params object[] args)
        {
            // Same as the VB CallByName method
            return Microsoft.VisualBasic.Interaction.CallByName(obj, methodName, Microsoft.VisualBasic.CallType.Method, args);
        }
    
        /// <summary>
        /// Executes a method on an object and returns the result cast as the specified type
        /// </summary>
        /// <typeparam name="T">The Type to cast the returned value as</typeparam>
        /// <param name="obj">Required. A pointer to the object exposing the property or method.</param>
        /// <param name="methodName">A string expression containing the property or method of the object.</param>
        /// <param name="args">Optional. A parameter array containing the arguments to be passed to the property or method.</param>
        /// <returns></returns>
        public static T CallMethodByName<T>(this object obj, string methodName, params object[] args)
        {
            return (T)obj.CallMethodByName(methodName, args);
        }
#endif

        /// <summary>
        /// Returns a Boolean value indicating whether a variable is of the indicated Type
        /// </summary>
        /// <param name="obj">Required. Object variable.</param>
        /// <param name="type">The Type to check the object against.</param>
        /// <returns>Returns a Boolean value indicating whether a variable is of the indicated Type</returns>
        public static bool IsType(this object obj, Type type)
        {
            return obj.GetType() == type;
        }

        /// <summary>
        /// Returns a Boolean value indicating whether a variable points to a System.Array.
        /// </summary>
        /// <param name="obj">Required. Object variable.</param>
        /// <returns>Returns a Boolean value indicating whether a variable points to a System.Array.</returns>
        public static bool IsArray(this object obj)
        {
            return obj.GetType().IsArray;
        }

        /// <summary>
        /// Returns a Boolean value indicating whether a variable points to a DateTime object.
        /// </summary>
        /// <param name="obj">Required. Object variable.</param>
        /// <returns>Returns a Boolean value indicating whether a variable points to a DateTime object.</returns>
        public static bool IsDate(this object obj)
        {
            return obj.IsType(typeof(DateTime));
        }

        /// <summary>
        /// Returns a Boolean value indicating whether an expression evaluates to the DBNull class.
        /// Extension Added by dotNetExt.Object
        /// </summary>
        /// <param name="obj">Required. Object expression.</param>
        /// <returns>Returns a Boolean value indicating whether an expression evaluates to the DBNull class.</returns>
        public static bool IsDBNull(this object obj)
        {
            return obj.IsType(typeof(DBNull));
        }

        /// <summary>
        /// Returns the First Attribute tied to the Object of the Specified Generic Type
        /// </summary>
        /// <typeparam name="TAttributeType">The Type of Attribute to Get.</typeparam>
        /// <param name="obj">Required. The Object to get the Attribute for.</param>
        /// <returns>Returns the First Attribute tied to the Object of the Specified Generic Type</returns>
        public static TAttributeType GetAttribute<TAttributeType>(this object obj) where TAttributeType : Attribute
        {
            return obj.GetAttributes<TAttributeType>().FirstOrDefault();
        }

        /// <summary>
        /// Returns All Attributes tied to the Object of the Specified Generic Type
        /// </summary>
        /// <typeparam name="TAttributeType">The Type of Attribute to Get.</typeparam>
        /// <param name="obj">Required. The Object to get the Attributes for.</param>
        /// <returns>Returns All Attributes tied to the Object of the Specified Generic Type</returns>
        public static TAttributeType[] GetAttributes<TAttributeType>(this object obj) where TAttributeType : Attribute
        {
            return (TAttributeType[])obj.GetType().GetCustomAttributes(typeof(TAttributeType), false);
        }

        /// <summary>
        /// Allows you to easily pass an Anonymous type from one function to another
        /// </summary>
        /// <typeparam name="T">The Anonymous Type</typeparam>
        /// <param name="obj">The Anonymous Type</param>
        /// <param name="targetType">The Object to "Cast As" the Anonymous type</param>
        /// <returns></returns>
        public static T CastAs<T>(this object obj, T targetType)
        {
            return (T)obj;
        }

        /// <summary>
        /// Returns an object of the specified Type and whoes value is equivalent to the specified object.
        /// </summary>
        /// <typeparam name="T">The Type to convert to.</typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T ConvertType<T>(this object obj)
        {
            return (T)Convert.ChangeType(obj, typeof(T));
        }
    }
}
