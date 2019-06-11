using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace RSA
{
    public class KeySaver
    {

        public RSAParameters PublicKey { get; set; }
        public RSAParameters PrivateKey { get; set; }
     
    }
}
