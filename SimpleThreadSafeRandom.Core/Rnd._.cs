// Based on:
//https://devblogs.microsoft.com/pfxteam/getting-random-numbers-in-a-thread-safe-way/


using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace SimpleThreadSafeRandom
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
    }
}
