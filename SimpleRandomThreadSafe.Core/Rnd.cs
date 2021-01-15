// Based on:
//https://devblogs.microsoft.com/pfxteam/getting-random-numbers-in-a-thread-safe-way/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace SimpleRandomThreadSafe
{
    public static partial class Rnd
    {
        private static readonly RNGCryptoServiceProvider _cryptoProvider = new RNGCryptoServiceProvider();

        [ThreadStatic]
        private static Random _RandomLocal;
        internal static Random RandomLocal
        {
            get
            {
                if (_RandomLocal == null)
                {
                    byte[] buffer = new byte[4];
                    _cryptoProvider.GetBytes(buffer);
                    _RandomLocal = new Random(BitConverter.ToInt32(buffer, 0));
                }
                return _RandomLocal;
            }
        }

        #region Types
        /// <summary>
        /// Gets a Random double
        /// </summary>
        /// <returns></returns>
        public static double Double()
            => RandomLocal.NextDouble();

        /// <summary>
        /// Gets a Random Int32
        /// </summary>
        /// <returns></returns>
        public static int Int32()
            => RandomLocal.Next();

        /// <summary>
        /// Gets a Random Byte
        /// </summary>
        /// <returns></returns>
        public static byte Byte()
            => Between(byte.MinValue, byte.MaxValue);

        /// <summary>
        /// Gets a Random Int16
        /// </summary>
        /// <returns></returns>
        public static short Int16()
            => Between(short.MinValue, short.MaxValue);

        /// <summary>
        /// Gets a Random Int64
        /// </summary>
        /// <returns></returns>
        public static long Int64()
            => Between(long.MinValue, long.MaxValue);

        /// <summary>
        /// Gets a Random Decimal
        /// </summary>
        /// <returns></returns>
        public static decimal Decimal()
            => Between(decimal.MinValue, decimal.MaxValue);

        /// <summary>
        /// Gets a Random Boolean
        /// </summary>
        /// <returns></returns>
        public static bool Boolean()
            => Double() < 0.5;
        #endregion Types

        #region Between
        /// <summary>
        /// Gets a Random number Between value1 and value2
        /// </summary>
        /// <param name="value1">The minimum Value</param>
        /// <param name="value2">The maximum Value</param>
        /// <returns></returns>
        public static double Between(double value1, double value2)
            => (value1 <= value2) ? RandomLocal.NextDouble() * (value2 - value1) + value1 : Between(value2, value1);

        /// <summary>
        /// Gets a Random number Between value1 and value2
        /// </summary>
        /// <param name="value1">The minimum Value</param>
        /// <param name="value2">The maximum Value</param>
        /// <returns></returns>
        public static int Between(int value1, int value2)
            => (value1 <= value2) ? RandomLocal.Next(value1, value2) : Between(value2, value1);

        /// <summary>
        /// Gets a Random number Between value1 and value2
        /// </summary>
        /// <param name="value1">The minimum Value</param>
        /// <param name="value2">The maximum Value</param>
        /// <returns></returns>
        public static byte Between(byte value1, byte value2)
            => Convert.ToByte(Between(Convert.ToInt32(value1), Convert.ToInt32(value2)));

        /// <summary>
        /// Gets a Random number Between value1 and value2
        /// </summary>
        /// <param name="value1">The minimum Value</param>
        /// <param name="value2">The maximum Value</param>
        /// <returns></returns>
        public static short Between(short value1, short value2)
            => Convert.ToInt16(Between(Convert.ToInt32(value1), Convert.ToInt32(value2)));

        /// <summary>
        /// Gets a Random number Between value1 and value2
        /// </summary>
        /// <param name="value1">The minimum Value</param>
        /// <param name="value2">The maximum Value</param>
        /// <returns></returns>
        public static long Between(long val1, long val2)
            => Convert.ToInt64(Between(Convert.ToDouble(val1), Convert.ToDouble(val2)));

        /// <summary>
        /// Gets a Random number Between value1 and value2
        /// </summary>
        /// <param name="value1">The minimum Value</param>
        /// <param name="value2">The maximum Value</param>
        /// <returns></returns>
        public static decimal Between(decimal val1, decimal val2)
            => Convert.ToDecimal(Between(Convert.ToDouble(val1), Convert.ToDouble(val2)));
        #endregion Between

        #region GreaterThan
        /// <summary>
        /// Gets a Random number Greater than min value
        /// </summary>
        /// <param name="min">The minimum value</param>
        /// <returns></returns>
        public static double GreaterThan(double min)
            => Between(min, double.MaxValue);

        /// <summary>
        /// Gets a Random number Greater than min value
        /// </summary>
        /// <param name="min">The minimum value</param>
        /// <returns></returns>
        public static int GreaterThan(int min)
            => Between(min, int.MaxValue);

        /// <summary>
        /// Gets a Random number Greater than min value
        /// </summary>
        /// <param name="min">The minimum value</param>
        /// <returns></returns>
        public static byte GreaterThan(byte min)
            => Between(min, byte.MaxValue);

        /// <summary>
        /// Gets a Random number Greater than min value
        /// </summary>
        /// <param name="min">The minimum value</param>
        /// <returns></returns>
        public static short GreaterThan(short min)
             => Between(min, short.MaxValue);

        /// <summary>
        /// Gets a Random number Greater than min value
        /// </summary>
        /// <param name="min">The minimum value</param>
        /// <returns></returns>
        public static long GreaterThan(long min)
            => Between(min, long.MaxValue);

        /// <summary>
        /// Gets a Random number Greater than min value
        /// </summary>
        /// <param name="min">The minimum value</param>
        /// <returns></returns>
        public static decimal GreaterThan(decimal min)
            => Between(min, decimal.MaxValue);
        #endregion GreaterThan

        #region LessThan
        /// <summary>
        /// Gets a Random number Less than max value
        /// </summary>
        /// <param name="max">The maximum value</param>
        /// <returns></returns>
        public static double LessThan(double max)
            => Between(double.MinValue, max);

        /// <summary>
        /// Gets a Random number Less than max value
        /// </summary>
        /// <param name="max">The maximum value</param>
        /// <returns></returns>
        public static int LessThan(int max)
            => Between(int.MinValue, max);

        /// <summary>
        /// Gets a Random number Less than max value
        /// </summary>
        /// <param name="max">The maximum value</param>
        /// <returns></returns>
        public static byte LessThan(byte max)
            => Between(byte.MinValue, max);

        /// <summary>
        /// Gets a Random number Less than max value
        /// </summary>
        /// <param name="max">The maximum value</param>
        /// <returns></returns>
        public static short LessThan(short max)
             => Between(short.MinValue, max);

        /// <summary>
        /// Gets a Random number Less than max value
        /// </summary>
        /// <param name="max">The maximum value</param>
        /// <returns></returns>
        public static long LessThan(long max)
            => Between(long.MinValue, max);

        /// <summary>
        /// Gets a Random number Less than max value
        /// </summary>
        /// <param name="max">The maximum value</param>
        /// <returns></returns>
        public static decimal LessThan(decimal max)
            => Between(decimal.MinValue, max);
        #endregion LessThan

        #region From
        /// <summary>
        /// Gets Random element in an enumerable collection of elements
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="elements"></param>
        /// <returns></returns>
        public static T From<T>(IEnumerable<T> elements)
            => elements.ElementAt(Between(0, elements.Count()));

        /// <summary>
        /// Gets Random element from parameters
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="elements"></param>
        /// <returns></returns>
        public static T From<T>(params T[] elements)
            => elements.ElementAt(Between(0, elements.Count()));

        /// <summary>
        /// Gets Random value of an enum
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="elements"></param>
        /// <returns></returns>
        public static T From<T>() where T : struct, IConvertible
        {
            var enumType = typeof(T);

            if (!enumType.IsEnum)
                throw new NotSupportedException(enumType.Name + " is not an enum");

            return From(Enum.GetValues(enumType).Cast<T>());
        }
        #endregion From
    }
}
