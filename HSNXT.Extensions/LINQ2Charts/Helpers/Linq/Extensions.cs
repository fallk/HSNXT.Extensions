// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

// INTENTIONALLY HERE
// DO NOT MOVE TO ROOT NAMESPACE

using System.Collections.Generic;
using System.Linq;

namespace HSNXT.Linq
{
    public static class Linq2ChartExtensionsDoNotMove
    {
        public static IEnumerable<KeyValuePair<int, T>> WithIndex<T>(this IEnumerable<T> source)
        {
            return source.Select((x, i) => new KeyValuePair<int, T>(i, x));
        }
    }
}