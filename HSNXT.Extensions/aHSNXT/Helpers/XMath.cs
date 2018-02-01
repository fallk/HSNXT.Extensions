using System;
using System.Runtime.CompilerServices;
using SN = System.Numerics;
using Impl = System.Runtime.CompilerServices.MethodImplOptions;

namespace HSNXT
{
    public class XMath
    {
        [MethodImpl(Impl.AggressiveInlining)] public static byte Abs(byte i) => i;
        [MethodImpl(Impl.AggressiveInlining)] public static ushort Abs(ushort i) => i;
        [MethodImpl(Impl.AggressiveInlining)] public static uint Abs(uint i) => i;
        [MethodImpl(Impl.AggressiveInlining)] public static ulong Abs(ulong i) => i;
        
        [MethodImpl(Impl.AggressiveInlining)] public static sbyte Abs(sbyte i) => Math.Abs(i);
        [MethodImpl(Impl.AggressiveInlining)] public static short Abs(short i) => Math.Abs(i);
        [MethodImpl(Impl.AggressiveInlining)] public static int Abs(int i) => Math.Abs(i);
        [MethodImpl(Impl.AggressiveInlining)] public static long Abs(long i) => Math.Abs(i);
        
        [MethodImpl(Impl.AggressiveInlining)] public static float Abs(float i) => Math.Abs(i);
        [MethodImpl(Impl.AggressiveInlining)] public static double Abs(double i) => Math.Abs(i);
        [MethodImpl(Impl.AggressiveInlining)] public static decimal Abs(decimal i) => Math.Abs(i);
        
        [MethodImpl(Impl.AggressiveInlining)] public static Int128 Abs(Int128 i) => i.ToAbs();
        [MethodImpl(Impl.AggressiveInlining)] public static Int256 Abs(Int256 i) => i.ToAbs();
        [MethodImpl(Impl.AggressiveInlining)] public static BigInteger Abs(BigInteger i) => i.Abs();
        [MethodImpl(Impl.AggressiveInlining)] public static SN.BigInteger Abs(SN.BigInteger i) => SN.BigInteger.Abs(i);
    }
}