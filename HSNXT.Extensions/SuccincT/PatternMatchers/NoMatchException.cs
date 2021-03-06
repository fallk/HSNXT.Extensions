﻿using System;
using System.Diagnostics.CodeAnalysis;

namespace HSNXT.SuccincT.PatternMatchers
{
    [SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors")]
    public sealed class NoMatchException : Exception
    {
        public NoMatchException(string message) : base(message)
        {
        }
    }
}