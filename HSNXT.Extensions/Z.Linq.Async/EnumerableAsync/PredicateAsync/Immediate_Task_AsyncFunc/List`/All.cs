﻿// Description: Async extension methods for LINQ (Language Integrated Query).
// Website & Documentation: https://github.com/zzzprojects/LINQ-Async
// Forum: https://github.com/zzzprojects/LINQ-Async/issues
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace HSNXT
{
    public static partial class Extensions
    {
        public static Task<bool> All<TSource>(this Task<List<TSource>> source, Func<TSource, Task<bool>> predicate,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return source.AsEnumerable(cancellationToken).All(predicate, cancellationToken);
        }
    }
}