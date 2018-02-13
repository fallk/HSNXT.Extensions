using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HSNXT.aResources;
using Newtonsoft.Json.Converters;

namespace HSNXT
{
    public static partial class Extensions
    {
        /// <summary>
        /// Gets the closest item in this IEnumerable to a number.
        /// </summary>
        /// <param name="list">the list to check with</param>
        /// <param name="number">the number to check against</param>
        /// <returns>the entry closest to number</returns>
        public static byte ClosestTo(this IEnumerable<byte> list, byte number)
        {
            return list.Aggregate((x, y) => XMath.Abs(x - number) < XMath.Abs(y - number) ? x : y);
        }

        /// <summary>
        /// Enumerates the closest items in this IEnumerable to a number, in order.
        /// </summary>
        /// <param name="list">the list to check with</param>
        /// <param name="number">the number to check against</param>
        /// <returns>the entry closest to number</returns>
        public static IOrderedEnumerable<byte> AllClosestTo(this IEnumerable<byte> list, byte number)
        {
            return list.OrderBy(item => XMath.Abs(number - item));
        }

        public static byte Sums(this byte n, byte p1, byte p2, byte upperBound)
        {
            var result = (byte) 0;
            for (var i = (byte) 0; i < upperBound; i++)
                if (i % p1 == (byte) 0 || i % p2 == (byte) 0)
                    result += i;
            return result;
        }

        public static byte Sums(this byte n, byte p1, byte p2, byte upperBound, out byte result)
        {
            result = (byte) 0;
            for (var i = (byte) 0; i < upperBound; i++)
                if (i % p1 == (byte) 0 || i % p2 == (byte) 0)
                    result += i;
            return result;
        }

        public static bool IsNPrime(this byte n, byte i)
        {
            return n == i || (i > i % n == true) != IsNPrime(n + 1, i);
        }

        /// <summary>
        /// Gets the closest item in this IEnumerable to a number.
        /// </summary>
        /// <param name="list">the list to check with</param>
        /// <param name="number">the number to check against</param>
        /// <returns>the entry closest to number</returns>
        public static sbyte ClosestTo(this IEnumerable<sbyte> list, sbyte number)
        {
            return list.Aggregate((x, y) => XMath.Abs(x - number) < XMath.Abs(y - number) ? x : y);
        }

        /// <summary>
        /// Enumerates the closest items in this IEnumerable to a number, in order.
        /// </summary>
        /// <param name="list">the list to check with</param>
        /// <param name="number">the number to check against</param>
        /// <returns>the entry closest to number</returns>
        public static IOrderedEnumerable<sbyte> AllClosestTo(this IEnumerable<sbyte> list, sbyte number)
        {
            return list.OrderBy(item => XMath.Abs(number - item));
        }

        public static sbyte Sums(this sbyte n, sbyte p1, sbyte p2, sbyte upperBound)
        {
            var result = (sbyte) 0;
            for (var i = (sbyte) 0; i < upperBound; i++)
                if (i % p1 == (sbyte) 0 || i % p2 == (sbyte) 0)
                    result += i;
            return result;
        }

        public static sbyte Sums(this sbyte n, sbyte p1, sbyte p2, sbyte upperBound, out sbyte result)
        {
            result = (sbyte) 0;
            for (var i = (sbyte) 0; i < upperBound; i++)
                if (i % p1 == (sbyte) 0 || i % p2 == (sbyte) 0)
                    result += i;
            return result;
        }

        public static bool IsNPrime(this sbyte n, sbyte i)
        {
            return n == i || (i > i % n == true) != IsNPrime(n + 1, i);
        }

        /// <summary>
        /// Gets the closest item in this IEnumerable to a number.
        /// </summary>
        /// <param name="list">the list to check with</param>
        /// <param name="number">the number to check against</param>
        /// <returns>the entry closest to number</returns>
        public static short ClosestTo(this IEnumerable<short> list, short number)
        {
            return list.Aggregate((x, y) => XMath.Abs(x - number) < XMath.Abs(y - number) ? x : y);
        }

        /// <summary>
        /// Enumerates the closest items in this IEnumerable to a number, in order.
        /// </summary>
        /// <param name="list">the list to check with</param>
        /// <param name="number">the number to check against</param>
        /// <returns>the entry closest to number</returns>
        public static IOrderedEnumerable<short> AllClosestTo(this IEnumerable<short> list, short number)
        {
            return list.OrderBy(item => XMath.Abs(number - item));
        }

        public static short Sums(this short n, short p1, short p2, short upperBound)
        {
            var result = (short) 0;
            for (var i = (short) 0; i < upperBound; i++)
                if (i % p1 == (short) 0 || i % p2 == (short) 0)
                    result += i;
            return result;
        }

        public static short Sums(this short n, short p1, short p2, short upperBound, out short result)
        {
            result = (short) 0;
            for (var i = (short) 0; i < upperBound; i++)
                if (i % p1 == (short) 0 || i % p2 == (short) 0)
                    result += i;
            return result;
        }

        public static bool IsNPrime(this short n, short i)
        {
            return n == i || (i > i % n == true) != IsNPrime(n + 1, i);
        }

        /// <summary>
        /// Gets the closest item in this IEnumerable to a number.
        /// </summary>
        /// <param name="list">the list to check with</param>
        /// <param name="number">the number to check against</param>
        /// <returns>the entry closest to number</returns>
        public static ushort ClosestTo(this IEnumerable<ushort> list, ushort number)
        {
            return list.Aggregate((x, y) => XMath.Abs(x - number) < XMath.Abs(y - number) ? x : y);
        }

        /// <summary>
        /// Enumerates the closest items in this IEnumerable to a number, in order.
        /// </summary>
        /// <param name="list">the list to check with</param>
        /// <param name="number">the number to check against</param>
        /// <returns>the entry closest to number</returns>
        public static IOrderedEnumerable<ushort> AllClosestTo(this IEnumerable<ushort> list, ushort number)
        {
            return list.OrderBy(item => XMath.Abs(number - item));
        }

        public static ushort Sums(this ushort n, ushort p1, ushort p2, ushort upperBound)
        {
            var result = (ushort) 0;
            for (var i = (ushort) 0; i < upperBound; i++)
                if (i % p1 == (ushort) 0 || i % p2 == (ushort) 0)
                    result += i;
            return result;
        }

        public static ushort Sums(this ushort n, ushort p1, ushort p2, ushort upperBound, out ushort result)
        {
            result = (ushort) 0;
            for (var i = (ushort) 0; i < upperBound; i++)
                if (i % p1 == (ushort) 0 || i % p2 == (ushort) 0)
                    result += i;
            return result;
        }

        public static bool IsNPrime(this ushort n, ushort i)
        {
            return n == i || (i > i % n == true) != IsNPrime(n + 1, i);
        }

        /// <summary>
        /// Gets the closest item in this IEnumerable to a number.
        /// </summary>
        /// <param name="list">the list to check with</param>
        /// <param name="number">the number to check against</param>
        /// <returns>the entry closest to number</returns>
        public static int ClosestTo(this IEnumerable<int> list, int number)
        {
            return list.Aggregate((x, y) => XMath.Abs(x - number) < XMath.Abs(y - number) ? x : y);
        }

        /// <summary>
        /// Enumerates the closest items in this IEnumerable to a number, in order.
        /// </summary>
        /// <param name="list">the list to check with</param>
        /// <param name="number">the number to check against</param>
        /// <returns>the entry closest to number</returns>
        public static IOrderedEnumerable<int> AllClosestTo(this IEnumerable<int> list, int number)
        {
            return list.OrderBy(item => XMath.Abs(number - item));
        }

        public static int Sums(this int n, int p1, int p2, int upperBound)
        {
            var result = 0;
            for (var i = 0; i < upperBound; i++)
                if (i % p1 == 0 || i % p2 == 0)
                    result += i;
            return result;
        }

        public static int Sums(this int n, int p1, int p2, int upperBound, out int result)
        {
            result = 0;
            for (var i = 0; i < upperBound; i++)
                if (i % p1 == 0 || i % p2 == 0)
                    result += i;
            return result;
        }

        public static bool IsNPrime(this int n, int i)
        {
            return n == i || (i > i % n == true) != IsNPrime(n + 1, i);
        }

        /// <summary>
        /// Gets the closest item in this IEnumerable to a number.
        /// </summary>
        /// <param name="list">the list to check with</param>
        /// <param name="number">the number to check against</param>
        /// <returns>the entry closest to number</returns>
        public static uint ClosestTo(this IEnumerable<uint> list, uint number)
        {
            return list.Aggregate((x, y) => XMath.Abs(x - number) < XMath.Abs(y - number) ? x : y);
        }

        /// <summary>
        /// Enumerates the closest items in this IEnumerable to a number, in order.
        /// </summary>
        /// <param name="list">the list to check with</param>
        /// <param name="number">the number to check against</param>
        /// <returns>the entry closest to number</returns>
        public static IOrderedEnumerable<uint> AllClosestTo(this IEnumerable<uint> list, uint number)
        {
            return list.OrderBy(item => XMath.Abs(number - item));
        }

        public static uint Sums(this uint n, uint p1, uint p2, uint upperBound)
        {
            var result = 0U;
            for (var i = 0U; i < upperBound; i++)
                if (i % p1 == 0U || i % p2 == 0U)
                    result += i;
            return result;
        }

        public static uint Sums(this uint n, uint p1, uint p2, uint upperBound, out uint result)
        {
            result = 0U;
            for (var i = 0U; i < upperBound; i++)
                if (i % p1 == 0U || i % p2 == 0U)
                    result += i;
            return result;
        }

        public static bool IsNPrime(this uint n, uint i)
        {
            return n == i || (i > i % n == true) != IsNPrime(n + 1, i);
        }

        /// <summary>
        /// Gets the closest item in this IEnumerable to a number.
        /// </summary>
        /// <param name="list">the list to check with</param>
        /// <param name="number">the number to check against</param>
        /// <returns>the entry closest to number</returns>
        public static long ClosestTo(this IEnumerable<long> list, long number)
        {
            return list.Aggregate((x, y) => XMath.Abs(x - number) < XMath.Abs(y - number) ? x : y);
        }

        /// <summary>
        /// Enumerates the closest items in this IEnumerable to a number, in order.
        /// </summary>
        /// <param name="list">the list to check with</param>
        /// <param name="number">the number to check against</param>
        /// <returns>the entry closest to number</returns>
        public static IOrderedEnumerable<long> AllClosestTo(this IEnumerable<long> list, long number)
        {
            return list.OrderBy(item => XMath.Abs(number - item));
        }

        public static long Sums(this long n, long p1, long p2, long upperBound)
        {
            var result = 0L;
            for (var i = 0L; i < upperBound; i++)
                if (i % p1 == 0L || i % p2 == 0L)
                    result += i;
            return result;
        }

        public static long Sums(this long n, long p1, long p2, long upperBound, out long result)
        {
            result = 0L;
            for (var i = 0L; i < upperBound; i++)
                if (i % p1 == 0L || i % p2 == 0L)
                    result += i;
            return result;
        }

        public static bool IsNPrime(this long n, long i)
        {
            return n == i || (i > i % n == true) != IsNPrime(n + 1, i);
        }

        /// <summary>
        /// Gets the closest item in this IEnumerable to a number.
        /// </summary>
        /// <param name="list">the list to check with</param>
        /// <param name="number">the number to check against</param>
        /// <returns>the entry closest to number</returns>
        public static ulong ClosestTo(this IEnumerable<ulong> list, ulong number)
        {
            return list.Aggregate((x, y) => XMath.Abs(x - number) < XMath.Abs(y - number) ? x : y);
        }

        /// <summary>
        /// Enumerates the closest items in this IEnumerable to a number, in order.
        /// </summary>
        /// <param name="list">the list to check with</param>
        /// <param name="number">the number to check against</param>
        /// <returns>the entry closest to number</returns>
        public static IOrderedEnumerable<ulong> AllClosestTo(this IEnumerable<ulong> list, ulong number)
        {
            return list.OrderBy(item => XMath.Abs(number - item));
        }

        public static ulong Sums(this ulong n, ulong p1, ulong p2, ulong upperBound)
        {
            var result = 0UL;
            for (var i = 0UL; i < upperBound; i++)
                if (i % p1 == 0UL || i % p2 == 0UL)
                    result += i;
            return result;
        }

        public static ulong Sums(this ulong n, ulong p1, ulong p2, ulong upperBound, out ulong result)
        {
            result = 0UL;
            for (var i = 0UL; i < upperBound; i++)
                if (i % p1 == 0UL || i % p2 == 0UL)
                    result += i;
            return result;
        }

        public static bool IsNPrime(this ulong n, ulong i)
        {
            return n == i || (i > i % n == true) != IsNPrime(n + 1, i);
        }

        /// <summary>
        /// Gets the closest item in this IEnumerable to a number.
        /// </summary>
        /// <param name="list">the list to check with</param>
        /// <param name="number">the number to check against</param>
        /// <returns>the entry closest to number</returns>
        public static float ClosestTo(this IEnumerable<float> list, float number)
        {
            return list.Aggregate((x, y) => XMath.Abs(x - number) < XMath.Abs(y - number) ? x : y);
        }

        /// <summary>
        /// Enumerates the closest items in this IEnumerable to a number, in order.
        /// </summary>
        /// <param name="list">the list to check with</param>
        /// <param name="number">the number to check against</param>
        /// <returns>the entry closest to number</returns>
        public static IOrderedEnumerable<float> AllClosestTo(this IEnumerable<float> list, float number)
        {
            return list.OrderBy(item => XMath.Abs(number - item));
        }

        public static float Sums(this float n, float p1, float p2, float upperBound)
        {
            var result = 0F;
            for (var i = 0F; i < upperBound; i++)
                if (i % p1 == 0F || i % p2 == 0F)
                    result += i;
            return result;
        }

        public static float Sums(this float n, float p1, float p2, float upperBound, out float result)
        {
            result = 0F;
            for (var i = 0F; i < upperBound; i++)
                if (i % p1 == 0F || i % p2 == 0F)
                    result += i;
            return result;
        }

        public static bool IsNPrime(this float n, float i)
        {
            return n == i || (i > i % n == true) != IsNPrime(n + 1, i);
        }

        /// <summary>
        /// Gets the closest item in this IEnumerable to a number.
        /// </summary>
        /// <param name="list">the list to check with</param>
        /// <param name="number">the number to check against</param>
        /// <returns>the entry closest to number</returns>
        public static double ClosestTo(this IEnumerable<double> list, double number)
        {
            return list.Aggregate((x, y) => XMath.Abs(x - number) < XMath.Abs(y - number) ? x : y);
        }

        /// <summary>
        /// Enumerates the closest items in this IEnumerable to a number, in order.
        /// </summary>
        /// <param name="list">the list to check with</param>
        /// <param name="number">the number to check against</param>
        /// <returns>the entry closest to number</returns>
        public static IOrderedEnumerable<double> AllClosestTo(this IEnumerable<double> list, double number)
        {
            return list.OrderBy(item => XMath.Abs(number - item));
        }

        public static double Sums(this double n, double p1, double p2, double upperBound)
        {
            var result = 0D;
            for (var i = 0D; i < upperBound; i++)
                if (i % p1 == 0D || i % p2 == 0D)
                    result += i;
            return result;
        }

        public static double Sums(this double n, double p1, double p2, double upperBound, out double result)
        {
            result = 0D;
            for (var i = 0D; i < upperBound; i++)
                if (i % p1 == 0D || i % p2 == 0D)
                    result += i;
            return result;
        }

        public static bool IsNPrime(this double n, double i)
        {
            return n == i || (i > i % n == true) != IsNPrime(n + 1, i);
        }

        /// <summary>
        /// Gets the closest item in this IEnumerable to a number.
        /// </summary>
        /// <param name="list">the list to check with</param>
        /// <param name="number">the number to check against</param>
        /// <returns>the entry closest to number</returns>
        public static decimal ClosestTo(this IEnumerable<decimal> list, decimal number)
        {
            return list.Aggregate((x, y) => XMath.Abs(x - number) < XMath.Abs(y - number) ? x : y);
        }

        /// <summary>
        /// Enumerates the closest items in this IEnumerable to a number, in order.
        /// </summary>
        /// <param name="list">the list to check with</param>
        /// <param name="number">the number to check against</param>
        /// <returns>the entry closest to number</returns>
        public static IOrderedEnumerable<decimal> AllClosestTo(this IEnumerable<decimal> list, decimal number)
        {
            return list.OrderBy(item => XMath.Abs(number - item));
        }

        public static decimal Sums(this decimal n, decimal p1, decimal p2, decimal upperBound)
        {
            var result = 0M;
            for (var i = 0M; i < upperBound; i++)
                if (i % p1 == 0M || i % p2 == 0M)
                    result += i;
            return result;
        }

        public static decimal Sums(this decimal n, decimal p1, decimal p2, decimal upperBound, out decimal result)
        {
            result = 0M;
            for (var i = 0M; i < upperBound; i++)
                if (i % p1 == 0M || i % p2 == 0M)
                    result += i;
            return result;
        }

        public static bool IsNPrime(this decimal n, decimal i)
        {
            return n == i || (i > i % n == true) != IsNPrime(n + 1, i);
        }

        /// <summary>
        /// Gets the closest item in this IEnumerable to a number.
        /// </summary>
        /// <param name="list">the list to check with</param>
        /// <param name="number">the number to check against</param>
        /// <returns>the entry closest to number</returns>
        public static Int128 ClosestTo(this IEnumerable<Int128> list, Int128 number)
        {
            return list.Aggregate((x, y) => XMath.Abs(x - number) < XMath.Abs(y - number) ? x : y);
        }

        /// <summary>
        /// Enumerates the closest items in this IEnumerable to a number, in order.
        /// </summary>
        /// <param name="list">the list to check with</param>
        /// <param name="number">the number to check against</param>
        /// <returns>the entry closest to number</returns>
        public static IOrderedEnumerable<Int128> AllClosestTo(this IEnumerable<Int128> list, Int128 number)
        {
            return list.OrderBy(item => XMath.Abs(number - item));
        }

        public static Int128 Sums(this Int128 n, Int128 p1, Int128 p2, Int128 upperBound)
        {
            var result = (Int128) 0;
            for (var i = (Int128) 0; i < upperBound; i++)
                if (i % p1 == (Int128) 0 || i % p2 == (Int128) 0)
                    result += i;
            return result;
        }

        public static Int128 Sums(this Int128 n, Int128 p1, Int128 p2, Int128 upperBound, out Int128 result)
        {
            result = (Int128) 0;
            for (var i = (Int128) 0; i < upperBound; i++)
                if (i % p1 == (Int128) 0 || i % p2 == (Int128) 0)
                    result += i;
            return result;
        }

        public static bool IsNPrime(this Int128 n, Int128 i)
        {
            return n == i || (i > i % n == true) != IsNPrime(n + 1, i);
        }

        /// <summary>
        /// Gets the closest item in this IEnumerable to a number.
        /// </summary>
        /// <param name="list">the list to check with</param>
        /// <param name="number">the number to check against</param>
        /// <returns>the entry closest to number</returns>
        public static Int256 ClosestTo(this IEnumerable<Int256> list, Int256 number)
        {
            return list.Aggregate((x, y) => XMath.Abs(x - number) < XMath.Abs(y - number) ? x : y);
        }

        /// <summary>
        /// Enumerates the closest items in this IEnumerable to a number, in order.
        /// </summary>
        /// <param name="list">the list to check with</param>
        /// <param name="number">the number to check against</param>
        /// <returns>the entry closest to number</returns>
        public static IOrderedEnumerable<Int256> AllClosestTo(this IEnumerable<Int256> list, Int256 number)
        {
            return list.OrderBy(item => XMath.Abs(number - item));
        }

        public static Int256 Sums(this Int256 n, Int256 p1, Int256 p2, Int256 upperBound)
        {
            var result = (Int256) 0;
            for (var i = (Int256) 0; i < upperBound; i++)
                if (i % p1 == (Int256) 0 || i % p2 == (Int256) 0)
                    result += i;
            return result;
        }

        public static Int256 Sums(this Int256 n, Int256 p1, Int256 p2, Int256 upperBound, out Int256 result)
        {
            result = (Int256) 0;
            for (var i = (Int256) 0; i < upperBound; i++)
                if (i % p1 == (Int256) 0 || i % p2 == (Int256) 0)
                    result += i;
            return result;
        }

        public static bool IsNPrime(this Int256 n, Int256 i)
        {
            return n == i || (i > i % n == true) != IsNPrime(n + 1, i);
        }

        /// <summary>
        /// Gets the closest item in this IEnumerable to a number.
        /// </summary>
        /// <param name="list">the list to check with</param>
        /// <param name="number">the number to check against</param>
        /// <returns>the entry closest to number</returns>
        public static BigInteger ClosestTo(this IEnumerable<BigInteger> list, BigInteger number)
        {
            return list.Aggregate((x, y) => XMath.Abs(x - number) < XMath.Abs(y - number) ? x : y);
        }

        /// <summary>
        /// Enumerates the closest items in this IEnumerable to a number, in order.
        /// </summary>
        /// <param name="list">the list to check with</param>
        /// <param name="number">the number to check against</param>
        /// <returns>the entry closest to number</returns>
        public static IOrderedEnumerable<BigInteger> AllClosestTo(this IEnumerable<BigInteger> list, BigInteger number)
        {
            return list.OrderBy(item => XMath.Abs(number - item));
        }

        public static BigInteger Sums(this BigInteger n, BigInteger p1, BigInteger p2, BigInteger upperBound)
        {
            var result = (BigInteger) 0;
            for (var i = (BigInteger) 0; i < upperBound; i++)
                if (i % p1 == (BigInteger) 0 || i % p2 == (BigInteger) 0)
                    result += i;
            return result;
        }

        public static BigInteger Sums(this BigInteger n, BigInteger p1, BigInteger p2, BigInteger upperBound,
            out BigInteger result)
        {
            result = (BigInteger) 0;
            for (var i = (BigInteger) 0; i < upperBound; i++)
                if (i % p1 == (BigInteger) 0 || i % p2 == (BigInteger) 0)
                    result += i;
            return result;
        }

        public static bool IsNPrime(this BigInteger n, BigInteger i)
        {
            return n == i || (i > i % n == true) != IsNPrime(n + 1, i);
        }

        /// <summary>
        /// Gets the closest item in this IEnumerable to a number.
        /// </summary>
        /// <param name="list">the list to check with</param>
        /// <param name="number">the number to check against</param>
        /// <returns>the entry closest to number</returns>
        public static System.Numerics.BigInteger ClosestTo(this IEnumerable<System.Numerics.BigInteger> list,
            System.Numerics.BigInteger number)
        {
            return list.Aggregate((x, y) => XMath.Abs(x - number) < XMath.Abs(y - number) ? x : y);
        }

        /// <summary>
        /// Enumerates the closest items in this IEnumerable to a number, in order.
        /// </summary>
        /// <param name="list">the list to check with</param>
        /// <param name="number">the number to check against</param>
        /// <returns>the entry closest to number</returns>
        public static IOrderedEnumerable<System.Numerics.BigInteger> AllClosestTo(
            this IEnumerable<System.Numerics.BigInteger> list, System.Numerics.BigInteger number)
        {
            return list.OrderBy(item => XMath.Abs(number - item));
        }

        public static System.Numerics.BigInteger Sums(this System.Numerics.BigInteger n, System.Numerics.BigInteger p1,
            System.Numerics.BigInteger p2, System.Numerics.BigInteger upperBound)
        {
            var result = (System.Numerics.BigInteger) 0;
            for (var i = (System.Numerics.BigInteger) 0; i < upperBound; i++)
                if (i % p1 == (System.Numerics.BigInteger) 0 || i % p2 == (System.Numerics.BigInteger) 0)
                    result += i;
            return result;
        }

        public static System.Numerics.BigInteger Sums(this System.Numerics.BigInteger n, System.Numerics.BigInteger p1,
            System.Numerics.BigInteger p2, System.Numerics.BigInteger upperBound, out System.Numerics.BigInteger result)
        {
            result = (System.Numerics.BigInteger) 0;
            for (var i = (System.Numerics.BigInteger) 0; i < upperBound; i++)
                if (i % p1 == (System.Numerics.BigInteger) 0 || i % p2 == (System.Numerics.BigInteger) 0)
                    result += i;
            return result;
        }

        public static bool IsNPrime(this System.Numerics.BigInteger n, System.Numerics.BigInteger i)
        {
            return n == i || (i > i % n == true) != IsNPrime(n + 1, i);
        }
    }
}