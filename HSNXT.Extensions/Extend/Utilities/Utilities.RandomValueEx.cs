﻿using System;
using System.Collections.Generic;
using HSNXT.JetBrains.Annotations;
using System.Linq;


namespace HSNXT
{
    public static partial class Extensions
    {
        #region Constants

        /// <summary>
        ///     Array of characters used to "generate" random characters.
        /// </summary>
        private static readonly char[] Chars =
            "qwertzuiopasdfghjklyxcvbnmQWERTZUIOPASDFGHJKLYXCVBNMöäüéàè.;:()/&%ç*?`!".ToCharArray();

        /// <summary>
        ///     The object used to generate random values.
        /// </summary>
        private static readonly Random Random2 = new Random();

        /// <summary>
        ///     The object used to synchronize accesses to <see cref="Rnd" /> across different threads.
        /// </summary>
        private static readonly object SyncLock = new object();

        #endregion

        #region Properties

        /// <summary>
        ///     Gets the random object used to create the random values.
        /// </summary>
        private static Random Rnd
        {
            get
            {
                lock (SyncLock)
                    return Random2;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Gets random string.
        /// </summary>
        /// <returns>A random string.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static string GetRandomString()
            => Guid.NewGuid()
                .ToString();

        /// <summary>
        ///     Gets random char.
        /// </summary>
        /// <returns>A random char.</returns>
        [PublicAPI]
        [Pure]
        public static char GetRandomChar()
            => Chars[GetRandomInt32(0, Chars.Length)];

        /// <summary>
        ///     Gets a list of random strings.
        /// </summary>
        /// <param name="numberOfItems">The number of items to generate.</param>
        /// <returns>A list of random strings.</returns>
        [PublicAPI]
        [Pure]
        [NotNull]
        public static List<string> GetRandomStrings(int? numberOfItems = null)
        {
            var list = new List<string>();
            numberOfItems = numberOfItems ?? GetRandomInt32(1, 1000);
            for (var i = 0; i < numberOfItems; i++)
                list.Add(GetRandomString());
            return list;
        }

        /// <summary>
        ///     Gets a random integer value which is in the specified range.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">min is greater than max</exception>
        /// <param name="min">
        ///     The inclusive min bound.
        ///     <value>Int32.MinValue</value>
        /// </param>
        /// <param name="max">
        ///     The exclusive maximum bound. Must be greater than min.
        ///     <value>Int32.MaxValue</value>
        /// </param>
        /// <returns>A random integer value.</returns>
        [PublicAPI]
        [Pure]
        public static int GetRandomInt32(int min = int.MinValue, int max = int.MaxValue)
        {
            if (max < min)
                throw new ArgumentOutOfRangeException(nameof(max), "max must be greater than min");

            return Rnd.Next(min, max);
        }

        /// <summary>
        ///     Gets a random integer value which is in the specified range.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">min is greater than max</exception>
        /// <param name="min">
        ///     The inclusive min bound.
        ///     <value>Int16.MinValue</value>
        /// </param>
        /// <param name="max">
        ///     The exclusive maximum bound. Must be greater than min.
        ///     <value>Int16.MaxValue</value>
        /// </param>
        /// <returns>A random integer value.</returns>
        [PublicAPI]
        [Pure]
        public static short GetRandomInt16(short min = short.MinValue, short max = short.MaxValue)
        {
            if (max < min)
                throw new ArgumentOutOfRangeException(nameof(max), max,
                    $"{nameof(max)} must be greater than {nameof(min)}");

            return (short) Rnd.Next(min, max);
        }

        /// <summary>
        ///     Gets a random Boolean value.
        /// </summary>
        /// <returns>A random Boolean value.</returns>
        [PublicAPI]
        [Pure]
        public static bool GetRandomBoolean()
            => GetRandomInt32() % 2 == 0;

        /// <summary>
        ///     Gets a random date-time value between the given minimum and maximum.
        /// </summary>
        /// <remarks>
        ///     Default value for minimum is: 01.01.1753.
        ///     Default value for maximum is: 31.12.9999.
        /// </remarks>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>Returns the generated random date-time value.</returns>
        [PublicAPI]
        [Pure]
        public static DateTime GetRandomDateTime(DateTime? min = null, DateTime? max = null)
        {
            min = min ?? new DateTime(1753, 01, 01);
            max = max ?? new DateTime(9999, 12, 31);

            var range = max.Value - min.Value;
            var randomUpperBound = (int) range.TotalSeconds;
            if (randomUpperBound <= 0)
                randomUpperBound = Rnd.Next(1, int.MaxValue);

            var randTimeSpan = TimeSpan.FromSeconds((long) (range.TotalSeconds - Rnd.Next(0, randomUpperBound)));

            return min.Value.Add(randTimeSpan);
        }

        /// <summary>
        ///     Gets a random value of the enumeration of the specified type.
        /// </summary>
        /// <typeparam name="T">The type of the enumeration.</typeparam>
        /// <returns>A random value of the enumeration of the specified type.</returns>
        [PublicAPI]
        [Pure]
        public static T GetRandomEnum<T>() where T : struct
        {
            var values = Enum.GetValues(typeof(T))
                .Cast<T>();

            var enumerable = values as T[];
            return enumerable?.ElementAt(Rnd.Next(0, enumerable.Length)) ?? default(T);
        }

        /// <summary>
        ///     Gets a random long value which is in the specified range.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">min is greater than max</exception>
        /// <param name="min">
        ///     The inclusive min bound.
        ///     <value>Int64.MinValue</value>
        /// </param>
        /// <param name="max">
        ///     The exclusive maximum bound. Must be greater than min.
        ///     <value>Int64.MaxValue</value>
        /// </param>
        /// <returns>A random long value.</returns>
        public static long GetRandomInt64(long min = long.MinValue, long max = long.MaxValue)
        {
            if (max < min)
                throw new ArgumentOutOfRangeException(nameof(max), "max must be greater than min");

            var uRange = (ulong) (max - min);

            ulong ulongRand;
            do
            {
                var buffer = new byte[8];
                Rnd.NextBytes(buffer);
                ulongRand = (ulong) BitConverter.ToInt64(buffer, 0);
            } while (ulongRand > ulong.MaxValue - (ulong.MaxValue % uRange + 1) % uRange);

            return (long) (ulongRand % uRange) + min;
        }

        /// <summary>
        ///     Gets a random <see cref="Byte" /> value.
        /// </summary>
        /// <returns>A random <see cref="Byte" /> value.</returns>
        [PublicAPI]
        [Pure]
        public static byte GetRandomByte()
            => (byte) GetRandomInt32();

        /// <summary>
        ///     Gets a random <see cref="Double" /> value which is in the specified range.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">min is greater than max</exception>
        /// <param name="min">
        ///     The inclusive min bound.
        ///     <value>Double.MinValue</value>
        /// </param>
        /// <param name="max">
        ///     The exclusive maximum bound. Must be greater than min.
        ///     <value>Double.MaxValue</value>
        /// </param>
        /// <returns>A random <see cref="Double" /> value.</returns>
        [PublicAPI]
        [Pure]
        public static double GetRandomDouble(double min = double.MinValue, double max = double.MaxValue)
        {
            if (max < min)
                throw new ArgumentOutOfRangeException(nameof(max), max,
                    $"{nameof(max)} must be greater than {nameof(min)}");

            var part = Math.Min(double.MaxValue, max - min);
            return min + Rnd.NextDouble() * part;
        }

        #endregion Methods
    }
}