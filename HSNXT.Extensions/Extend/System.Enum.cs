﻿using System;
using System.Collections.Generic;
using HSNXT.JetBrains.Annotations;
using System.Linq;
using System.Collections;


namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        ///     Gets all SET flags of the given enumeration value.
        /// </summary>
        /// <typeparam name="T">The type of the enumeration.</typeparam>
        /// <param name="enumValue">The enumeration value.</param>
        /// <returns>Returns all SET flags of the given value.</returns>
        [PublicAPI]
        [NotNull]
        [Pure]
        public static IEnumerable<T> GetFlags<T>(this Enum enumValue) where T : struct, IConvertible
            => Enum.GetValues(enumValue.GetType())
                .Cast<Enum>()
                .Where(enumValue.HasFlag)
                .Cast<T>();

        /// <summary>
        ///     Gets the values of the specified enumeration as strings.
        /// </summary>
        /// <exception cref="ArgumentException">T must be an enumerated type.</exception>
        /// <typeparam name="T">The type of the enumeration.</typeparam>
        /// <returns>All values of the specified enumeration as strings.</returns>
        [Pure]
        [PublicAPI]
        [NotNull]
        public static IEnumerable<string> GetStringValues<T>() where T : struct => GetValues<T>()
            .Select(x => x.ToString());

        /// <summary>
        ///     Gets a dictionary containing the string value for each value of the enumeration of the given type.
        /// </summary>
        /// <exception cref="ArgumentException">T must be an enumerated type.</exception>
        /// <typeparam name="T">The type of the enumeration.</typeparam>
        /// <returns>Returns a key value pair for each value of the specified enumeration type.</returns>
        [Pure]
        [PublicAPI]
        [NotNull]
        public static IDictionary<T, string> GetValueAndStringValue<T>() where T : struct
        {
            var values = GetValues<T>();
            return values.ToDictionary(x => x, x => x.ToString());
        }

        /// <summary>
        ///     Gets the values of the specified enumeration.
        /// </summary>
        /// <exception cref="ArgumentException">T must be an enumerated type.</exception>
        /// <typeparam name="T">The type of the enumeration.</typeparam>
        /// <returns>All values of the specified enumeration.</returns>
        [Pure]
        [PublicAPI]
        [NotNull]
        public static IEnumerable<T> GetValues<T>() where T : struct
        {
            var type = typeof(T);
            if (!type.IsEnum())
                throw new ArgumentException("T must be an enumerated type.");

            return Enum.GetValues(type)
                .OfType<T>();
        }

        /// <summary>
        ///     Gets the values of the specified enumeration.
        /// </summary>
        /// <exception cref="ArgumentNullException">type can not be null.</exception>
        /// <remarks>
        ///     How to cast returned values:
        ///     values.Cast{Object}();
        ///     values.Select( x => Convert.ChangeType( x, type ) );
        /// </remarks>
        /// <exception cref="ArgumentException">T must be an enumerated type.</exception>
        /// <param name="type">The type of the enumeration.</param>
        /// <returns>All values of the specified enumeration.</returns>
        [Pure]
        [PublicAPI]
        [NotNull]
        public static IEnumerable GetValues([NotNull] Type type)
        {
            type.ThrowIfNull(nameof(type));
            if (!type.IsEnum())
                throw new ArgumentException("T must be an enumerated type.");

            return Enum.GetValues(type);
        }

        /// <summary>
        ///     Gets all values of the specified enumeration type, expect the specified values.
        /// </summary>
        /// <exception cref="ArgumentException">T must be an enumerated type.</exception>
        /// <typeparam name="T">The type of the enumeration.</typeparam>
        /// <param name="exceptions">The values to exclude from the result.</param>
        /// <returns>Returns all values of the specified enumeration type, expect the specified values.</returns>
        [Pure]
        [PublicAPI]
        [NotNull]
        public static IEnumerable<T> GetValuesExpect<T>([CanBeNull] params T[] exceptions) where T : struct
        {
            var values = GetValues<T>();

            return exceptions == null
                ? values
                : values
                    .ToList()
                    .RemoveRange(exceptions);
        }

        /// <summary>
        ///     Gets all values of the specified enumeration type, expect the specified values.
        /// </summary>
        /// <remarks>
        ///     How to cast returned values:
        ///     values.Cast{Object}();
        ///     values.Select( x => Convert.ChangeType( x, type ) );
        /// </remarks>
        /// <exception cref="ArgumentException">T must be an enumerated type.</exception>
        /// <param name="type">The type of the enumeration.</param>
        /// <param name="exceptions">The values to exclude from the result.</param>
        /// <returns>Returns all values of the specified enumeration type, expect the specified values.</returns>
        [Pure]
        [PublicAPI]
        [NotNull]
        public static IEnumerable GetValuesExpect([NotNull] Type type, [CanBeNull] params object[] exceptions)
        {
            var values = GetValues(type)
                .OfType<object>()
                .ToList();

            return exceptions == null ? values : values.RemoveRange(exceptions);
        }
    }
}