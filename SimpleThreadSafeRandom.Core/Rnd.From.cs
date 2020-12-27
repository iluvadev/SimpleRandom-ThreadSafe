using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace SimpleThreadSafeRandom
{
    public static partial class Rnd
    {
        public static T From<T>(IEnumerable<T> elements)
            => Next.From(elements);

        public static T From<T>(params T[] elements)
            => Next.From(elements);

        public static T From<T>() where T : struct, IConvertible
            => Next.From<T>();

    }
}
