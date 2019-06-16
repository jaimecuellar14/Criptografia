using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.ComponentModel;
using System.Xml;

namespace RSA
{
    public class RSAMaker
    {

        private RSAParameters publica;
        private RSAParameters privada;

        public System.Security.Cryptography.RSACryptoServiceProvider CreateRSAKeyPair()
        {
           RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(512);
   
           rsa.ExportParameters(true);
           rsa.ExportParameters(false);
           this.publica = rsa.ExportParameters(false);
           this.privada = rsa.ExportParameters(true);
          
            return rsa;
        }
    }
}
