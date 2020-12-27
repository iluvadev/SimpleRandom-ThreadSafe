using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleThreadSafeRandom
{
    public class NextLink
    {

        public double Double()
            => Rnd.RandomLocal.NextDouble();
        public double Double(double val1, double val2)
            => (val1 <= val2) ? Rnd.RandomLocal.NextDouble() * (val2 - val1) + val1 : Double(val2, val1);
        public double Double(double max)
            => Double(double.MinValue, max);

        public int Int32()
            => Rnd.RandomLocal.Next();
        public int Int32(int val1, int val2)
            => (val1 <= val2) ? Rnd.RandomLocal.Next(val1, val2) : Int32(val2, val1);
        public int Int32(int max)
            => Int32(int.MinValue, max);

        public byte Byte()
            => Byte(byte.MinValue, byte.MaxValue);
        public byte Byte(byte val1, byte val2)
            => Convert.ToByte(Int32(Convert.ToInt32(val1), Convert.ToInt32(val2)));
        public byte Byte(byte max)
            => Byte(byte.MinValue, max);

        public short Int16()
            => Int16(short.MinValue, short.MaxValue);
        public short Int16(short val1, short val2)
            => Convert.ToInt16(Int32(Convert.ToInt32(val1), Convert.ToInt32(val2)));
        public short Int16(short max)
            => Int16(short.MinValue, max);

        public long Int64()
            => Int64(long.MinValue, long.MaxValue);
        public long Int64(long val1, long val2)
            => Convert.ToInt64(Double(Convert.ToDouble(val1), Convert.ToDouble(val2)));
        public long Int64(long max)
            => Int64(long.MinValue, max);

        public decimal Decimal()
            => Decimal(decimal.MinValue, decimal.MaxValue);
        public decimal Decimal(decimal val1, decimal val2)
            => Convert.ToDecimal(Double(Convert.ToDouble(val1), Convert.ToDouble(val2)));
        public decimal Decimal(decimal max)
            => Decimal(decimal.MinValue, max);

        public bool Boolean()
            => Double() < 0.5;

        public T From<T>(IEnumerable<T> elements)
            => elements.ElementAt(Int32(0, elements.Count()));

        public T From<T>(params T[] elements)
            => elements.ElementAt(Int32(0, elements.Count()));

        public T From<T>() where T : struct, IConvertible
        {
            var enumType = typeof(T);

            if (!enumType.IsEnum)
                throw new NotSupportedException(enumType.Name + " is not an enum");

            return From(Enum.GetValues(enumType).Cast<T>());
        }
    }
}
