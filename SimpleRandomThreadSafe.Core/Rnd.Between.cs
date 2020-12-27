using System;

namespace SimpleRandomThreadSafe
{
    public static partial class Rnd
    {
        public static double Between(double val1, double val2)
            => (val1 <= val2) ? RandomLocal.NextDouble() * (val2 - val1) + val1 : Between(val2, val1);

        public static int Between(int val1, int val2)
            => (val1 <= val2) ? RandomLocal.Next(val1, val2) : Between(val2, val1);

        public static byte Between(byte val1, byte val2)
            => Convert.ToByte(Between(Convert.ToInt32(val1), Convert.ToInt32(val2)));

        public static short Between(short val1, short val2)
            => Convert.ToInt16(Between(Convert.ToInt32(val1), Convert.ToInt32(val2)));

        public static long Between(long val1, long val2)
            => Convert.ToInt64(Between(Convert.ToDouble(val1), Convert.ToDouble(val2)));

        public static decimal Between(decimal val1, decimal val2)
            => Convert.ToDecimal(Between(Convert.ToDouble(val1), Convert.ToDouble(val2)));

    }
}
