﻿using HSNXT.SuccincT.Options;

namespace HSNXT.SuccincT.Functional
{
    public sealed class ConsResult<T>
    {
        public Option<T> Head { get; }
        public IConsEnumerable<T> Tail { get; }

        internal ConsResult(Option<T> head, IConsEnumerable<T> tail)
        {
            Head = head;
            Tail = tail;
        }

        internal ConsResult(Option<T> head)
        {
            Head = head;
            Tail = ConsEnumerable<T>.EmptyEnumerable;
        }
    }
}