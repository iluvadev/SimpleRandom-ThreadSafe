using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleRandomThreadSafe
{
    public static partial class Rnd
    {
        public static double LessThan(double max)
            => Between(double.MinValue, max);

        public static int LessThan(int max)
            => Between(int.MinValue, max);

        public static byte LessThan(byte max)
            => Between(byte.MinValue, max);

        public static short LessThan(short max)
             => Between(short.MinValue, max);

        public static long LessThan(long max)
            => Between(long.MinValue, max);

        public static decimal LessThan(decimal max)
            => Between(decimal.MinValue, max);
    }
}
