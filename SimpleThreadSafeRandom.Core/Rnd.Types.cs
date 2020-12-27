using System;

namespace SimpleThreadSafeRandom
{
    public static partial class Rnd
    {
        public static double Double()
            => RandomLocal.NextDouble();

        public static int Int32()
            => RandomLocal.Next();

        public static byte Byte()
            => Between(byte.MinValue, byte.MaxValue);

        public static short Int16()
            => Between(short.MinValue, short.MaxValue);

        public static long Int64()
            => Between(long.MinValue, long.MaxValue);

        public static decimal Decimal()
            => Between(decimal.MinValue, decimal.MaxValue);

        public static bool Boolean()
            => Double() < 0.5;
    }
}
