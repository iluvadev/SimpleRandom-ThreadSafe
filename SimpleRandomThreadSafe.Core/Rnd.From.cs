using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleRandomThreadSafe
{
    public static partial class Rnd
    {
        public static T From<T>(IEnumerable<T> elements)
        => elements.ElementAt(Between(0, elements.Count()));

        public static T From<T>(params T[] elements)
            => elements.ElementAt(Between(0, elements.Count()));

        public static T From<T>() where T : struct, IConvertible
        {
            var enumType = typeof(T);

            if (!enumType.IsEnum)
                throw new NotSupportedException(enumType.Name + " is not an enum");

            return From(Enum.GetValues(enumType).Cast<T>());
        }
    }
}
