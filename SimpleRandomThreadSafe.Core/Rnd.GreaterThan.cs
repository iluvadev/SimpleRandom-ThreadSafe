using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleRandomThreadSafe
{
    public static partial class Rnd
    {
        public static double GreaterThan(double min)
            => Between(min, double.MaxValue);

        public static int GreaterThan(int min)
            => Between(min, int.MaxValue);

        public static byte GreaterThan(byte min)
            => Between(min, byte.MaxValue);

        public static short GreaterThan(short min)
             => Between(min, short.MaxValue);

        public static long GreaterThan(long min)
            => Between(min, long.MaxValue);

        public static decimal GreaterThan(decimal min)
            => Between(min, decimal.MaxValue);
    }
}
