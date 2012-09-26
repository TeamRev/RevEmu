using System;
using System.Globalization;

using Revolution.New_Protocol.New_Protocol_Encryption.RSA.Keys;
using JCore.Utils;
using JCore.Utils.Encryption;

namespace Revolution.Core
{
    public class Protocol : DiffieHellman
    {
        private static BigInteger n = new BigInteger("90e0d43db75b5b8ffc8a77e31cc9758fa43fe69f14184bef64e61574beb18fac32520566f6483b246ddc3c991cb366bae975a6f6b733fd9570e8e72efc1e511ff6e2bcac49bf9237222d7c2bf306300d4dfc37113bcc84fa4401c9e4f2b4c41ade9654ef00bd592944838fae21a05ea59fecc961766740c82d84f4299dfb33dd", 16);
        private static BigInteger e = new BigInteger(3);
        private static BigInteger d = new BigInteger(0); //Missing secret number ;o

        private RSA RSA;

        public Boolean Initialized { get; private set; }

        public Rc4 Rc4 { get; private set; }

        public Protocol()
            : base(200)
        {
            this.RSA = new RSA(n, e, d, 0, 0, 0, 0, 0);

            this.Rc4 = new Rc4();

            this.Initialized = false;
        }

        public Protocol(BigInteger _n, BigInteger _e, BigInteger _d)
            : base(200)
        {
            n = _n;
            e = _e;
            d = _d;

            this.RSA = new RSA(n, e, d, 0, 0, 0, 0, 0);

            this.Rc4 = new Rc4();

            this.Initialized = false;
        }

        public Boolean InitializeRC4(string ctext)
        {
            try
            {
                string publickey = this.RSA.Decrypt(ctext);

                base.GenerateSharedKey(publickey.Replace(((char)0).ToString(), ""));

                this.Rc4.Init(base.SharedKey.getBytes());

                this.Initialized = true;

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}