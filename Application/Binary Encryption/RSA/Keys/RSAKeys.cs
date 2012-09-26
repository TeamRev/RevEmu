using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JCore.Utils;

namespace Revolution.New_Protocol.New_Protocol_Encryption.RSA.Keys
{
    internal class RsaKeys
    {
        internal class N
        {
            public static BigInteger GetKey
            {
                get
                {
                    return new BigInteger(
                        "90e0d43db75b5b8ffc8a77e31cc9758fa43fe69f14184bef64e61574beb18fac32520566f6483b246ddc3c991cb366bae975a6f6b733fd9570e8e72efc1e511ff6e2bcac49bf9237222d7c2bf306300d4dfc37113bcc84fa4401c9e4f2b4c41ade9654ef00bd592944838fae21a05ea59fecc961766740c82d84f4299dfb33dd",
                        16);
                }
                set
                {
                    new BigInteger(value);
                    return;
                }
            }
        }

        internal class E
        {
            public static BigInteger GetKey
            {
                get { return new BigInteger(3); }
                set
                {
                    new BigInteger(value);
                    return;
                }
            }
        }

        internal class D
        {
            public static BigInteger GetKey
            {
                get { return new BigInteger(0); }
                set
                {
                    new BigInteger(value);
                    return;
                }
            }
        }
    }
}
