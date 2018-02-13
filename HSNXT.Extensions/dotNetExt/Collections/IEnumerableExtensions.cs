﻿//Copyright (c) Chris Pietschmann 2012 (http://pietschsoft.com)
//All rights reserved.
//Licensed under the GNU Library General Public License (LGPL)
//License can be found here: http://www.codeplex.com/dotNetExt/license

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using HSNXT.dotNetExt;
using DNX = HSNXT.dotNetExt;

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Returns a PaginatedList<> based on the specified IEnumerable<> and page index and page size. The total count is gathered from the IEnumerable itself.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static DNX.PaginatedList<T> ToPaginatedList<T>(this IEnumerable<T> collection, int pageIndex,
            int pageSize)
        {
            return new DNX.PaginatedList<T>(collection.AsQueryable(), pageIndex, pageSize);
        }

        /// <summary>
        /// Returns a PaginatedList<> based on the specified IEnumerable with the specified page index, page size and total count set. This is for using when the IEnumerable contains a known subset of the full data set.
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        public static DNX.PaginatedList<T> ToPaginatedList<T>(this IEnumerable<T> collection, int pageIndex,
            int pageSize, int totalCount)
        {
            return new DNX.PaginatedList<T>(collection.AsQueryable(), pageIndex, pageSize, totalCount);
        }

        // <summary>
        // Returns a boolean indicating whether the IEnumerable contains any matches to the predicate
        // </summary>
        // <typeparam name="T"></typeparam>
        // <param name="collection">The IEnumerable to search</param>
        // <param name="predicate">The predicate to search for</param>
        // <returns></returns>
        public static bool Contains<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            return collection.Where(predicate).Any();
        }

        /// <summary>
        /// Returns a boolean indicating if the IEnumerable is Empty.
        /// </summary>
        /// <param name="collection">The IEnumerable object to check</param>
        /// <returns></returns>
        public static bool IsEmpty(this IEnumerable collection)
        {
            return !collection.Cast<object>().Any();
        }

        /// <summary>
        /// Performs the specified action on each element in the IEnumerable
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="action"></param>
        public static void Each(this IEnumerable collection, Action<object> action)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("collection");
            }

            if (action == null)
            {
                throw new ArgumentNullException("action");
            }

            foreach (var item in collection)
            {
                action(item);
            }
        }
    }
}