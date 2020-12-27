using System;

namespace SimpleThreadSafeRandom
{
    public static partial class Rnd
    {
        public static double Between(double val1, double val2)
            => Next.Double(val1, val2);

        public static int Between(int val1, int val2)
            => Next.Int32(val1, val2);

        public static byte Between(byte val1, byte val2)
            => Next.Byte(val1, val2);

        public static short Between(short val1, short val2)
            => Next.Int16(val1, val2);

        public static long Between(long val1, long val2)
            => Next.Int64(val1, val2);

        public static decimal Between(decimal val1, decimal val2)
            => Next.Decimal(val1, val2);

    }
}
