using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using JCore.Utils;

namespace JCore.Utils.Encryption
{
    public class RSA
    {
        #region Variables

        public BigInteger n { get; private set; }
        public BigInteger e { get; private set; }
        public BigInteger d { get; private set; }
        public BigInteger p { get; private set; }
        public BigInteger q { get; private set; }
        public BigInteger dmp1 { get; private set; }
        public BigInteger dmq1 { get; private set; }
        public BigInteger coeff { get; private set; }

        protected Boolean canDecrypt { get; private set; }
        protected Boolean canEncrypt { get; private set; }

        #endregion

        #region Constructor

        public RSA(BigInteger n, BigInteger e, BigInteger d, BigInteger p, BigInteger q, BigInteger dmp1,
                   BigInteger dmq1, BigInteger coeff)
        {
            this.n = n;
            this.e = e;
            this.d = d;
            this.p = p;
            this.q = q;
            this.dmp1 = dmp1;
            this.dmq1 = dmq1;
            this.coeff = coeff;

            canEncrypt = this.n != 0 && this.e != 0;
            canDecrypt = canEncrypt && this.d != 0;
        }

        public RSA(int b, BigInteger e)
        {
            this.e = e;

            int qs = b >> 1;

            while (true)
            {
                while (true)
                {
                    p = BigInteger.genPseudoPrime(b - qs, 1, new Random());

                    if ((p - 1).gcd(this.e) == 1 && p.isProbablePrime(10))
                    {
                        break;
                    }
                }

                while (true)
                {
                    q = BigInteger.genPseudoPrime(qs, 1, new Random());

                    if ((q - 1).gcd(this.e) == 1 && p.isProbablePrime(10))
                    {
                        break;
                    }
                }

                if (p < q)
                {
                    BigInteger t = p;
                    p = q;
                    q = t;
                }

                BigInteger phi = (p - 1) * (q - 1);
                if (phi.gcd(this.e) == 1)
                {
                    n = p * q;
                    d = this.e.modInverse(phi);
                    dmp1 = d % (p - 1);
                    dmq1 = d % (q - 1);
                    coeff = q.modInverse(p);
                    break;
                }
            }

            canEncrypt = n != 0 && this.e != 0;
            canDecrypt = canEncrypt && d != 0;
        }

        public RSA(BigInteger e, BigInteger p, BigInteger q)
        {
            this.e = e;
            this.p = p;
            this.q = q;

            BigInteger phi = (this.p - 1) * (this.q - 1);
            if (phi.gcd(this.e) == 1)
            {
                n = this.p * this.q;
                d = this.e.modInverse(phi);
                dmp1 = d % (this.p - 1);
                dmq1 = d % (this.q - 1);
                coeff = this.q.modInverse(this.p);
            }

            canEncrypt = n != 0 && this.e != 0;
            canDecrypt = canEncrypt && d != 0;
        }

        #endregion

        private int GetBlockSize()
        {
            return (n.bitCount() + 7) / 8;
        }

        public BigInteger DoPublic(BigInteger x)
        {
            if (canEncrypt)
            {
                return x.modPow(e, n);
            }

            return 0;
        }

        public string Encrypt(string text)
        {
            if (text.Length > GetBlockSize() - 11)
            {
                Console.WriteLine("RSA Encrypt: Message is to big!");
            }

            var m = new BigInteger(pkcs1pad2(Encoding.GetEncoding("iso-8859-1").GetBytes(text), GetBlockSize()));
            if (m == 0)
            {
                return null;
            }

            BigInteger c = DoPublic(m);
            if (c == 0)
            {
                return null;
            }

            string result = c.ToString(16);
            if ((result.Length & 1) == 0)
            {
                return result;
            }

            return "0" + result;
        }

        private byte[] pkcs1pad2(byte[] data, int n)
        {
            var bytes = new byte[n];
            int i = data.Length - 1;
            while (i >= 0 && n > 11)
            {
                bytes[--n] = data[i--];
            }
            bytes[--n] = 0;

            while (n > 2)
            {
                bytes[--n] = 0x01;
            }

            bytes[--n] = 0x2;
            bytes[--n] = 0;

            return bytes;
        }

        public BigInteger DoPrivate(BigInteger x)
        {
            if (canDecrypt)
            {
                return x.modPow(d, n);
            }

            return 0;
        }

        public string Decrypt(string ctext)
        {
            var c = new BigInteger(ctext, 16);
            BigInteger m = DoPrivate(c);
            if (m == 0)
            {
                return null;
            }

            byte[] bytes = pkcs1unpad2(m, GetBlockSize());

            if (bytes == null)
            {
                return null;
            }

            return Encoding.GetEncoding("iso-8859-1").GetString(bytes);
        }

        private byte[] pkcs1unpad2(BigInteger m, int b)
        {
            byte[] bytes = m.getBytes();

            int i = 0;
            while (i < bytes.Length && bytes[i] == 0) ++i;

            if (bytes.Length - i != (b - 1) || bytes[i] != 0x2)
            {
                return null;
            }

            while (bytes[i] != 0)
            {
                if (++i >= bytes.Length)
                {
                    return null;
                }
            }

            var result = new byte[bytes.Length - i + 1];
            int p = 0;
            while (++i < bytes.Length)
            {
                result[p++] = bytes[i];
            }

            return result;
        }
    }
}
