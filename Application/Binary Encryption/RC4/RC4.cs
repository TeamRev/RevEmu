using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JCore.Utils.Encryption
{
    public class Rc4
    {
        private readonly int[] _table;
        private int _i;
        private int _j;

        public Rc4()
        {
            _table = new int[256];
        }

        public Rc4(byte[] key)
        {
            _table = new int[256];

            Init(key);
        }

        public void Init(byte[] key)
        {
            int k = key.Length;
            _i = 0;
            while (_i < 256)
            {
                _table[_i] = _i;
                _i++;
            }

            _i = 0;
            _j = 0;
            while (_i < 0x0100)
            {
                _j = (((_j + _table[_i]) + key[(_i % k)]) % 256);
                Swap(_i, _j);
                _i++;
            }

            _i = 0;
            _j = 0;
        }

        public void Swap(int a, int b)
        {
            int k = _table[a];
            _table[a] = _table[b];
            _table[b] = k;
        }

        public byte[] Decipher(byte[] bytes)
        {
            int k = 0;
            var result = new byte[bytes.Length];
            int pos = 0;

            for (int a = 0; a < bytes.Length; a++)
            {
                _i = ((_i + 1) % 256);
                _j = ((_j + _table[_i]) % 256);
                Swap(_i, _j);
                k = ((_table[_i] + _table[_j]) % 256);
                result[pos++] = (byte)(bytes[a] ^ _table[k]);
            }

            return result;
        }
    }
}
