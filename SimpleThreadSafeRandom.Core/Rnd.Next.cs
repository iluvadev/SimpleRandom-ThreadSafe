using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleThreadSafeRandom
{
    public static partial class Rnd
    {
        [ThreadStatic]
        private static NextLink _Next;
        public static NextLink Next => _Next ??= new NextLink();

    }
}
