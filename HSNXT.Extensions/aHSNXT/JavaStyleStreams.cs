using System;
using System.Collections.Generic;
using System.Linq;
using HSNXT.SuccincT.Options;

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>Determines whether all elements of a sequence satisfy a condition.</summary>
        /// <param name="self">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains the elements to apply the predicate to.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="self" />.</typeparam>
        /// <returns>
        /// <see langword="true" /> if every element of the source sequence passes the test in the specified predicate, or if the sequence is empty; otherwise, <see langword="false" />.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="self" /> or <paramref name="predicate" /> is <see langword="null" />.</exception>
        public static bool AllMatch<T>(this IEnumerable<T> self, Func<T, bool> predicate) => self.All(predicate);

        /// <summary>Determines whether any element of a sequence satisfies a condition.</summary>
        /// <param name="self">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose elements to apply the predicate to.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="self" />.</typeparam>
        /// <returns>
        /// <see langword="true" /> if any elements in the source sequence pass the test in the specified predicate; otherwise, <see langword="false" />.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="self" /> or <paramref name="predicate" /> is <see langword="null" />.</exception>
        public static bool AnyMatch<T>(this IEnumerable<T> self, Func<T, bool> predicate) => self.Any(predicate);

        /// <summary>Applies an accumulator function over a sequence.</summary>
        /// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to aggregate over.</param>
        /// <param name="func">An accumulator function to be invoked on each element.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The final accumulator value.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="func" /> is <see langword="null" />.</exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// <paramref name="source" /> contains no elements.</exception>
        public static TSource
            Collect<TSource>(this IEnumerable<TSource> source, Func<TSource, TSource, TSource> func) =>
            source.Aggregate(func);

        /// <summary>Applies an accumulator function over a sequence. The specified seed value is used as the initial accumulator value.</summary>
        /// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to aggregate over.</param>
        /// <param name="seed">The initial accumulator value.</param>
        /// <param name="func">An accumulator function to be invoked on each element.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <typeparam name="TAccumulate">The type of the accumulator value.</typeparam>
        /// <returns>The final accumulator value.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="func" /> is <see langword="null" />.</exception>
        public static TAccumulate Collect<TSource, TAccumulate>(this IEnumerable<TSource> source, TAccumulate seed,
            Func<TAccumulate, TSource, TAccumulate> func) => source.Aggregate(seed, func);

        /// <summary>Applies an accumulator function over a sequence. The specified seed value is used as the initial accumulator value, and the specified function is used to select the result value.</summary>
        /// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to aggregate over.</param>
        /// <param name="seed">The initial accumulator value.</param>
        /// <param name="func">An accumulator function to be invoked on each element.</param>
        /// <param name="resultSelector">A function to transform the final accumulator value into the result value.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <typeparam name="TAccumulate">The type of the accumulator value.</typeparam>
        /// <typeparam name="TResult">The type of the resulting value.</typeparam>
        /// <returns>The transformed final accumulator value.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="func" /> or <paramref name="resultSelector" /> is <see langword="null" />.</exception>
        public static TResult Collect<TSource, TAccumulate, TResult>(this IEnumerable<TSource> source, TAccumulate seed,
            Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TResult> resultSelector) =>
            source.Aggregate(seed, func, resultSelector);

        /// <summary>Applies an accumulator function over a sequence.</summary>
        /// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to aggregate over.</param>
        /// <param name="func">An accumulator function to be invoked on each element.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The final accumulator value.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="func" /> is <see langword="null" />.</exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// <paramref name="source" /> contains no elements.</exception>
        public static TSource
            Reduce<TSource>(this IEnumerable<TSource> source, Func<TSource, TSource, TSource> func) =>
            source.Aggregate(func);

        /// <summary>Applies an accumulator function over a sequence. The specified seed value is used as the initial accumulator value.</summary>
        /// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to aggregate over.</param>
        /// <param name="seed">The initial accumulator value.</param>
        /// <param name="func">An accumulator function to be invoked on each element.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <typeparam name="TAccumulate">The type of the accumulator value.</typeparam>
        /// <returns>The final accumulator value.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="func" /> is <see langword="null" />.</exception>
        public static TAccumulate Reduce<TSource, TAccumulate>(this IEnumerable<TSource> source, TAccumulate seed,
            Func<TAccumulate, TSource, TAccumulate> func) => source.Aggregate(seed, func);

        /// <summary>Applies an accumulator function over a sequence. The specified seed value is used as the initial accumulator value, and the specified function is used to select the result value.</summary>
        /// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to aggregate over.</param>
        /// <param name="seed">The initial accumulator value.</param>
        /// <param name="func">An accumulator function to be invoked on each element.</param>
        /// <param name="resultSelector">A function to transform the final accumulator value into the result value.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <typeparam name="TAccumulate">The type of the accumulator value.</typeparam>
        /// <typeparam name="TResult">The type of the resulting value.</typeparam>
        /// <returns>The transformed final accumulator value.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="func" /> or <paramref name="resultSelector" /> is <see langword="null" />.</exception>
        public static TResult Reduce<TSource, TAccumulate, TResult>(this IEnumerable<TSource> source, TAccumulate seed,
            Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TResult> resultSelector) =>
            source.Aggregate(seed, func, resultSelector);

        /// <summary>Filters a sequence of values based on a predicate.</summary>
        /// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to filter.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains elements from the input sequence that satisfy the condition.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="predicate" /> is <see langword="null" />.</exception>
        public static IEnumerable<TSource> Filter<TSource>(this IEnumerable<TSource> source,
            Func<TSource, bool> predicate) => source.Where(predicate);

        /// <summary>Filters a sequence of values based on a predicate. Each element's index is used in the logic of the predicate function.</summary>
        /// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to filter.</param>
        /// <param name="predicate">A function to test each source element for a condition; the second parameter of the function represents the index of the source element.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains elements from the input sequence that satisfy the condition.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="predicate" /> is <see langword="null" />.</exception>
        public static IEnumerable<TSource> Filter<TSource>(this IEnumerable<TSource> source,
            Func<TSource, int, bool> predicate) => source.Where(predicate);

        /// <summary>Returns an Option containing the first element of a sequence, or an empty Option if the sequence
        /// contains no elements.</summary>
        /// <param name="source">The <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return the first
        /// element of.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>
        /// empty <see langword="Option" />(<typeparam name="TSource" />) if <paramref name="source" /> is empty;
        /// otherwise, <see langword="Option" /> containing the first element in <paramref name="source" />.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> is <see langword="null" />.</exception>
        public static Option<TSource> FindAny<TSource>(this IEnumerable<TSource> source)
        {
            switch (source)
            {
                case null:
                    throw new ArgumentNullException(nameof(source));
                case IList<TSource> sourceList:
                    if (sourceList.Count > 0)
                        return sourceList[0];
                    break;
                default:
                    using (var enumerator = source.GetEnumerator())
                    {
                        if (enumerator.MoveNext())
                            return enumerator.Current;
                    }

                    break;
            }

            return Option<TSource>.None();
        }

        /// <summary>Returns the first element of a sequence, or a default value if the sequence contains no elements.</summary>
        /// <param name="source">The <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return the first element of.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>
        /// <see langword="default" />(<typeparam name="TSource" />) if <paramref name="source" /> is empty; otherwise, the first element in <paramref name="source" />.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> is <see langword="null" />.</exception>
        public static Option<TSource> FindFirst<TSource>(this IEnumerable<TSource> source) => FindAny(source);

        /// <summary>Projects each element of a sequence to an <see cref="T:System.Collections.Generic.IEnumerable`1" /> and flattens the resulting sequences into one sequence.</summary>
        /// <param name="source">A sequence of values to project.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <typeparam name="TResult">The type of the elements of the sequence returned by <paramref name="selector" />.</typeparam>
        /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose elements are the result of invoking the one-to-many transform function on each element of the input sequence.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="selector" /> is <see langword="null" />.</exception>
        public static IEnumerable<TResult> FlatMap<TSource, TResult>(this IEnumerable<TSource> source,
            Func<TSource, IEnumerable<TResult>> selector) => source.SelectMany(selector);
        
        /// <summary>
        /// Returns an infinite IEnumerable where each element is generated by the provided supplier function.
        /// </summary>
        /// <param name="supplier">the supplier function of the generated elements</param>
        /// <typeparam name="T">the type of IEnumerable elements</typeparam>
        /// <returns>a new infinite IEnumerable</returns>
        public static IEnumerable<T> Generate<T>(this Func<T> supplier)
        {
            while (true)
            {
                yield return supplier();
            }
            // ReSharper disable once IteratorNeverReturns
        }

        /// <summary>
        /// Returns an infinite IEnumerable produced by iterative application of a function f to an
        /// initial element seed, producing a IEnumerable consisting of seed, f(seed), f(f(seed)), etc.
        /// <p>
        /// The first element (position 0) in the IEnumerable will be the provided seed. For n > 0, the element at
        /// position n, will be the result of applying the function f to the element at position n - 1.
        /// </p>
        /// </summary>
        /// <param name="f">a function to be applied to to the previous element to produce a new element</param>
        /// <param name="seed">the initial element</param>
        /// <typeparam name="T">the type of IEnumerable elements</typeparam>
        /// <returns>a new IEnumerable</returns>
        public static IEnumerable<T> Iterate<T>(this Func<T, T> f, T seed)
        {
            yield return seed;
            while (true)
            {
                yield return seed = f(seed);
            }
            // ReSharper disable once IteratorNeverReturns
        }

        /// <summary>
        /// Returns a IEnumerable consisting of the elements of this IEnumerable, truncated to be no longer than maxSize
        /// in length.
        /// </summary>
        /// <param name="self">the current IEnumerable</param>
        /// <param name="maxSize">the number of elements the stream should be limited to</param>
        /// <typeparam name="T">the type of IEnumerable elements</typeparam>
        /// <returns>a new IEnumerable</returns>
        public static IEnumerable<T> Limit<T>(this IEnumerable<T> self, long maxSize)
        {
            long i = 0;
            foreach (var x in self)
            {
                if (i >= maxSize)
                {
                    yield break;
                }
                yield return x;
                i++;
            }
        }

        /// <summary>Projects each element of a sequence into a new form.</summary>
        /// <param name="self">A sequence of values to invoke a transform function on.</param>
        /// <param name="mapper">A transform function to apply to each element.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="self" />.</typeparam>
        /// <typeparam name="TR">The type of the value returned by <paramref name="mapper" />.</typeparam>
        /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose elements are the result of invoking the transform function on each element of <paramref name="source" />.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="self" /> or <paramref name="mapper" /> is <see langword="null" />.</exception>
        public static IEnumerable<TR> Map<T, TR>(this IEnumerable<T> self, Func<T, TR> mapper) => self.Select(mapper);
        
        /// <summary>
        /// Returns whether no elements of this IEnumerable match the provided predicate.
        /// </summary>
        /// <param name="self">this IEnumerable</param>
        /// <param name="mapper">a non-interfering, stateless predicate to apply to elements of this stream</param>
        /// <typeparam name="T">the type of the IEnumerable to check</typeparam>
        /// <returns>true if either no elements of the stream match the provided predicate or the stream is empty, otherwise false</returns>
        public static bool NoneMatch<T>(this IEnumerable<T> self, Func<T, bool> mapper) => self.None(mapper);

        /// <summary>
        /// Returns an IEnumerable consisting of the elements of this IEnumerable, additionally performing the provided
        /// action on each element as elements are consumed from the resulting IEnumerable.
        /// This is an intermediate operation.
        /// For parallel stream pipelines, the action may be called at whatever time and in whatever thread the element
        /// is made available by the upstream operation. If the action modifies shared state, it is responsible for
        /// providing the required synchronization.
        /// </summary>
        /// <param name="self"></param>
        /// <param name="action"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<T> Peek<T>(this IEnumerable<T> self, Action<T> action)
        {
            foreach (var x in self)
            {
                yield return x;
                action(x);
            }
        }
    }
}