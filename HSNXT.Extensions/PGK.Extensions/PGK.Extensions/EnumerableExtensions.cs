using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// 	Converts all items of a list and returns them as enumerable.
        /// </summary>
        /// <typeparam name = "TSource">The source data type</typeparam>
        /// <typeparam name = "TTarget">The target data type</typeparam>
        /// <param name = "source">The source data.</param>
        /// <returns>The converted data</returns>
        /// <example>
        /// 	var values = new[] { "1", "2", "3" };
        /// 	values.ConvertList&lt;string, int&gt;().ForEach(Console.WriteLine);
        /// </example>
        public static IEnumerable<TTarget> ConvertList<TSource, TTarget>(this IEnumerable<TSource> source)
        {
            if (source == null)
                throw new ArgumentNullException("source");
            return source.Select(value => value.ConvertTo<TTarget>());
        }

        ///<summary>
        ///	Returns enumerable object based on target, which does not contains null references.
        ///	If target is null reference, returns empty enumerable object.
        ///</summary>
        ///<typeparam name = "T">Type of items in target.</typeparam>
        ///<param name = "target">Target enumerable object. Can be null.</param>
        ///<example>
        ///	object[] items = null;
        ///	foreach(var item in items.NotNull()){
        ///	// result of items.NotNull() is empty but not null enumerable
        ///	}
        /// 
        ///	object[] items = new object[]{ null, "Hello World!", null, "Good bye!" };
        ///	foreach(var item in items.NotNull()){
        ///	// result of items.NotNull() is enumerable with two strings
        ///	}
        ///</example>
        ///<remarks>
        ///	Contributed by tencokacistromy, http://www.codeplex.com/site/users/view/tencokacistromy
        ///</remarks>
        public static IEnumerable<T> IgnoreNulls<T>(this IEnumerable<T> target)
        {
            if (ReferenceEquals(target, null))
                yield break;

            foreach (var item in target.Where(item => !ReferenceEquals(item, null)))
                yield return item;
        }

        /// <summary>
        /// 	Returns the maximum item based on a provided selector.
        /// </summary>
        /// <typeparam name = "TItem">The item type</typeparam>
        /// <typeparam name = "TValue">The value item</typeparam>
        /// <param name = "items">The items.</param>
        /// <param name = "selector">The selector.</param>
        /// <param name = "maxValue">The max value as output parameter.</param>
        /// <returns>The maximum item</returns>
        /// <example>
        /// 	<code>
        /// 		int age;
        /// 		var oldestPerson = persons.MaxItem(p =&gt; p.Age, out age);
        /// 	</code>
        /// </example>
        public static TItem MaxItem<TItem, TValue>(this IEnumerable<TItem> items, Func<TItem, TValue> selector,
            out TValue maxValue)
            where TItem : class
            where TValue : IComparable
        {
            TItem maxItem = null;
            maxValue = default(TValue);

            foreach (var item in items)
            {
                if (item == null)
                    continue;

                var itemValue = selector(item);

                if ((maxItem != null) && (itemValue.CompareTo(maxValue) <= 0))
                    continue;

                maxValue = itemValue;
                maxItem = item;
            }

            return maxItem;
        }

        /// <summary>
        /// 	Returns the maximum item based on a provided selector.
        /// </summary>
        /// <typeparam name = "TItem">The item type</typeparam>
        /// <typeparam name = "TValue">The value item</typeparam>
        /// <param name = "items">The items.</param>
        /// <param name = "selector">The selector.</param>
        /// <returns>The maximum item</returns>
        /// <example>
        /// 	<code>
        /// 		var oldestPerson = persons.MaxItem(p =&gt; p.Age);
        /// 	</code>
        /// </example>
        public static TItem MaxItem<TItem, TValue>(this IEnumerable<TItem> items, Func<TItem, TValue> selector)
            where TItem : class
            where TValue : IComparable
        {
            TValue maxValue;

            return items.MaxItem(selector, out maxValue);
        }

        /// <summary>
        /// 	Returns the minimum item based on a provided selector.
        /// </summary>
        /// <typeparam name = "TItem">The item type</typeparam>
        /// <typeparam name = "TValue">The value item</typeparam>
        /// <param name = "items">The items.</param>
        /// <param name = "selector">The selector.</param>
        /// <param name = "minValue">The min value as output parameter.</param>
        /// <returns>The minimum item</returns>
        /// <example>
        /// 	<code>
        /// 		int age;
        /// 		var youngestPerson = persons.MinItem(p =&gt; p.Age, out age);
        /// 	</code>
        /// </example>
        public static TItem MinItem<TItem, TValue>(this IEnumerable<TItem> items, Func<TItem, TValue> selector,
            out TValue minValue)
            where TItem : class
            where TValue : IComparable
        {
            TItem minItem = null;
            minValue = default(TValue);

            foreach (var item in items)
            {
                if (item == null)
                    continue;
                var itemValue = selector(item);

                if ((minItem != null) && (itemValue.CompareTo(minValue) >= 0))
                    continue;
                minValue = itemValue;
                minItem = item;
            }

            return minItem;
        }

        /// <summary>
        /// 	Returns the minimum item based on a provided selector.
        /// </summary>
        /// <typeparam name = "TItem">The item type</typeparam>
        /// <typeparam name = "TValue">The value item</typeparam>
        /// <param name = "items">The items.</param>
        /// <param name = "selector">The selector.</param>
        /// <returns>The minimum item</returns>
        /// <example>
        /// 	<code>
        /// 		var youngestPerson = persons.MinItem(p =&gt; p.Age);
        /// 	</code>
        /// </example>
        public static TItem MinItem<TItem, TValue>(this IEnumerable<TItem> items, Func<TItem, TValue> selector)
            where TItem : class
            where TValue : IComparable
        {
            TValue minValue;

            return items.MinItem(selector, out minValue);
        }

        /// <summary>
        /// Removes matching items from a sequence
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        /// 
        /// <remarks>
        /// 	Renamed by James Curran, to match corresponding HashSet.RemoveWhere()
        /// 	</remarks>
        public static IEnumerable<T> RemoveWhere<T>(this IEnumerable<T> source, Predicate<T> predicate)
        {
            if (source == null)
                yield break;

            foreach (T t in source)
                if (!predicate(t))
                    yield return t;
        }

        ///<summary>
        ///	Remove item from a list
        ///</summary>
        ///<param name = "source"></param>
        ///<param name = "predicate"></param>
        ///<typeparam name = "T"></typeparam>
        ///<returns></returns>
        /// <remarks>
        /// 	Contributed by Michael T, http://about.me/MichaelTran
        /// </remarks>
        [Obsolete("Use RemoveWhere instead..")]
        public static IEnumerable<T> RemoveAll<T>(this IEnumerable<T> source, Predicate<T> predicate)
        {
            if (source == null)
                return Enumerable.Empty<T>();

            var list = source.ToList();
            list.RemoveAll(predicate);
            return list;
        }


        ///<summary>
        /// Turn the list of objects to a string of Common Seperated Value
        ///</summary>
        ///<param name="source"></param>
        ///<param name="separator"></param>
        ///<typeparam name="T"></typeparam>
        ///<returns></returns>
        /// <example>
        /// 	<code>
        /// 		var values = new[] { 1, 2, 3, 4, 5 };
        ///			string csv = values.ToCSV(';');
        /// 	</code>
        /// </example>
        /// <remarks>
        /// 	Contributed by Moses, http://mosesofegypt.net
        /// </remarks>
        public static string ToCSV<T>(this IEnumerable<T> source, char separator)
        {
            if (source == null)
                return String.Empty;

            var csv = new StringBuilder();
            source.ForEach(value => csv.AppendFormat("{0}{1}", value, separator));
            return csv.ToString(0, csv.Length - 1);
        }

        ///<summary>
        /// Turn the list of objects to a string of Common Seperated Value
        ///</summary>
        ///<param name="source"></param>
        ///<typeparam name="T"></typeparam>
        ///<returns></returns>
        /// <example>
        /// 	<code>
        /// 		var values = new[] {1, 2, 3, 4, 5};
        ///			string csv = values.ToCSV();
        /// 	</code>
        /// </example>
        /// <remarks>
        /// 	Contributed by Moses, http://mosesofegypt.net
        /// </remarks>
        public static string ToCSV<T>(this IEnumerable<T> source)
        {
            return source.ToCSV(',');
        }

        /// <summary>
        /// Overload the Select to allow null as a return
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="source"></param>
        /// <param name="selector"></param>
        /// <param name="allowNull"></param>
        /// <returns>An <see cref="IEnumerable{TResult}"/> using the selector containing null or non-null results based on <see cref="allowNull"/>.</returns>
        /// <example>
        /// <code>
        /// var list = new List{object}{ new object(), null, null };
        /// var noNulls = list.Select(x => x, false);
        /// </code>
        /// </example>
        /// <remarks>
        /// Contributed by thinktech_coder
        /// </remarks>
        public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source,
            Func<TSource, TResult> selector, bool allowNull)
        {
            return source.Select(selector).Where(s => allowNull || !Equals(s, default(TSource)));
        }

        /// <summary>
        /// Returns the first item or the <paramref name="defaultValue"/> if the <paramref name="source"/>
        /// does not contain any item.
        /// </summary>
        public static T FirstOrDefault<T>(this IEnumerable<T> source, T defaultValue)
        {
            switch (source)
            {
                case null:
                    throw new ArgumentNullException(nameof(source));
                case IList<T> sourceList:
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

            return defaultValue;
        }

        /// <summary>
        ///     Creates an Array from an IEnumerable&lt;T&gt; using the specified transform function.
        /// </summary>
        /// <typeparam name="TSource">The source data type</typeparam>
        /// <typeparam name="TResult">The target data type</typeparam>
        /// <param name="source">The source data.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>An Array of the target data type</returns>
        /// <example>
        ///     var integers = Enumerable.Range(1, 3);
        ///     var intStrings = values.ToArray(i => i.ToString());
        /// </example>
        /// <remarks>
        ///     This method is a shorthand for the frequently use pattern IEnumerable&lt;T&gt;.Select(Func).ToArray()
        /// </remarks>
        public static TResult[] ToArray2<TSource, TResult>(this IEnumerable<TSource> source,
            Func<TSource, TResult> selector)
        {
            return source.Select(selector).ToArray();
        }

        /// <summary>
        ///     Creates a List&lt;T&gt; from an IEnumerable&lt;T&gt; using the specified transform function.
        /// </summary>
        /// <typeparam name="TSource">The source data type</typeparam>
        /// <typeparam name="TResult">The target data type</typeparam>
        /// <param name="source">The source data.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>An IEnumerable&lt;T&gt; of the target data type</returns>
        /// <example>
        ///     var integers = Enumerable.Range(1, 3);
        ///     var intStrings = values.ToList(i => i.ToString());
        /// </example>
        /// <remarks>
        ///     This method is a shorthand for the frequently use pattern IEnumerable&lt;T&gt;.Select(Func).ToList()
        /// </remarks>
        public static List<TResult> ToList<TSource, TResult>(this IEnumerable<TSource> source,
            Func<TSource, TResult> selector)
        {
            return source.Select(selector).ToList();
        }

        /// <summary>
        /// Computes the sum of a sequence of UInt32 values.
        /// </summary>
        /// <param name="source">A sequence of UInt32 values to calculate the sum of.</param>
        /// <returns>The sum of the values in the sequence.</returns>
        public static uint Sum(this IEnumerable<uint> source)
        {
            return source.Aggregate(0U, (current, number) => current + number);
        }

        /// <summary>
        /// Computes the sum of a sequence of UInt64 values.
        /// </summary>
        /// <param name="source">A sequence of UInt64 values to calculate the sum of.</param>
        /// <returns>The sum of the values in the sequence.</returns>
        public static ulong Sum(this IEnumerable<ulong> source)
        {
            return source.Aggregate(0UL, (current, number) => current + number);
        }

        /// <summary>
        /// Computes the sum of a sequence of nullable UInt32 values.
        /// </summary>
        /// <param name="source">A sequence of nullable UInt32 values to calculate the sum of.</param>
        /// <returns>The sum of the values in the sequence.</returns>
        public static uint? Sum(this IEnumerable<uint?> source)
        {
            return source.Where(nullable => nullable.HasValue)
                .Aggregate(0U, (current, nullable) => current + nullable.GetValueOrDefault());
        }

        /// <summary>
        /// Computes the sum of a sequence of nullable UInt64 values.
        /// </summary>
        /// <param name="source">A sequence of nullable UInt64 values to calculate the sum of.</param>
        /// <returns>The sum of the values in the sequence.</returns>
        public static ulong? Sum(this IEnumerable<ulong?> source)
        {
            return source.Where(nullable => nullable.HasValue)
                .Aggregate(0UL, (current, nullable) => current + nullable.GetValueOrDefault());
        }

        /// <summary>
        /// Computes the sum of a sequence of UInt32 values that are obtained by invoking a transformation function on each element of the intput sequence.
        /// </summary>
        /// <param name="source">A sequence of values that are used to calculate a sum.</param>
        /// <param name="selection">A transformation function to apply to each element.</param>
        /// <returns>The sum of the projected values.</returns>
        public static uint Sum<T>(this IEnumerable<T> source, Func<T, uint> selection)
        {
            return ElementsNotNullFrom(source).Select(selection).Sum();
        }

        private static IEnumerable<T> ElementsNotNullFrom<T>(IEnumerable<T> source)
        {
            return source.Where(x => x.IsNotNull());
        }

        /// <summary>
        /// Computes the sum of a sequence of nullable UInt32 values that are obtained by invoking a transformation function on each element of the intput sequence.
        /// </summary>
        /// <param name="source">A sequence of values that are used to calculate a sum.</param>
        /// <param name="selection">A transformation function to apply to each element.</param>
        /// <returns>The sum of the projected values.</returns>
        public static uint? Sum<T>(this IEnumerable<T> source, Func<T, uint?> selection)
        {
            return ElementsNotNullFrom(source).Select(selection).Sum();
        }

        /// <summary>
        /// Computes the sum of a sequence of UInt64 values that are obtained by invoking a transformation function on each element of the intput sequence.
        /// </summary>
        /// <param name="source">A sequence of values that are used to calculate a sum.</param>
        /// <param name="selector">A transformation function to apply to each element.</param>
        /// <returns>The sum of the projected values.</returns>
        public static ulong Sum<T>(this IEnumerable<T> source, Func<T, ulong> selector)
        {
            return ElementsNotNullFrom(source).Select(selector).Sum();
        }

        /// <summary>
        /// Computes the sum of a sequence of nullable UInt64 values that are obtained by invoking a transformation function on each element of the intput sequence.
        /// </summary>
        /// <param name="source">A sequence of values that are used to calculate a sum.</param>
        /// <param name="selector">A transformation function to apply to each element.</param>
        /// <returns>The sum of the projected values.</returns>
        public static ulong? Sum<T>(this IEnumerable<T> source, Func<T, ulong?> selector)
        {
            return ElementsNotNullFrom(source).Select(selector).Sum();
        }

        /// <summary>
        ///   Returns whether the sequence contains a certain amount of elements.
        /// </summary>
        /// <typeparam name = "T">The type of the elements of the input sequence.</typeparam>
        /// <param name = "source">The source for this extension method.</param>
        /// <param name = "count">The amount of elements the sequence should contain.</param>
        /// <returns>True when the sequence contains the specified amount of elements, false otherwise.</returns>
        public static bool HasCountOf<T>(this IEnumerable<T> source, int count)
        {
            return source.Take(count + 1).Count() == count;
        }

        /// <summary>
        /// Allows you to create Enumerable List of the Enum's Values.
        /// </summary>
        /// <typeparam name="T">Enum Type to enumerate</typeparam>
        /// <returns></returns>
        public static IEnumerable<T> EnumValuesToList<T>(this IEnumerable<T> collection)
        {
            Type enumType = typeof(T);

            // Can't use generic type constraints on value types,
            // so have to do check like this
            // consider using - enumType.IsEnum()
            if (enumType.BaseType != typeof(Enum))
                throw new ArgumentException("T must be of type System.Enum");

            Array enumValArray = Enum.GetValues(enumType);
            var enumValList = new List<T>(enumValArray.Length);
            enumValList.AddRange(from int val in enumValArray select (T) Enum.Parse(enumType, val.ToString()));

            return enumValList;
        }

        /// <summary>
        /// Allows you to create a enumerable string list of the items name in the Enum.
        /// </summary>
        /// <typeparam name="T">Enum Type to enumerate</typeparam>
        /// <returns></returns>
        public static IEnumerable<string> EnumNamesToList<T>(this IEnumerable<T> collection)
        {
            Type cls = typeof(T);

            Type[] enumArrayList = cls.GetInterfaces();

            return (from objType in enumArrayList where objType.IsEnum select objType.Name).ToList();
        }

        /// <summary>
        /// Concatenate a list of items using the provided separator.
        /// </summary>
        /// <param name="items">An enumerable collection of items to concatenate.</param>
        /// <param name="separator">The separator to use for the concatenation (defaults to ",").</param>
        /// <param name="formatString">An optional string formatter for the items in the output list.</param>
        /// <returns>The enumerable collection of items concatenated into a single string.</returns>
        /// <example>
        /// 	<code>
        /// 		List&lt;double&gt; doubles = new List&lt;double&gt;() { 123.4567, 123.4, 123.0, 4, 5 };
        /// 		string concatenated = doubles.ConcatWith(":", "0.00");  // concatenated = 123.46:123.40:123.00:4.00:5.00
        /// 	</code>
        /// </example>
        /// <remarks>
        ///     Contributed by Joseph Eddy, http://www.codeplex.com/site/users/view/jceddy
        /// </remarks>
        public static string ConcatWith<T>(this IEnumerable<T> items, string separator = ",", string formatString = "")
        {
            if (items == null) throw new ArgumentNullException("items");
            if (separator == null) throw new ArgumentNullException("separator");

            // shortcut for string enumerable
            if (typeof(T) == typeof(string))
            {
                return string.Join(separator, ((IEnumerable<string>) items).ToArray());
            }

            if (string.IsNullOrEmpty(formatString))
            {
                formatString = "{0}";
            }
            else
            {
                formatString = string.Format("{{0:{0}}}", formatString);
            }

            return string.Join(separator, items.Select(x => string.Format(formatString, x)).ToArray());
        }
    }
}