using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Conversores
{
    public class ConvertirString
    {

        public string convertirStringPublica(System.Security.Cryptography.RSA csp)
        {
            var llavePublica = csp.ToXmlString(false);

            return llavePublica;
        }

        public string convertirStringPrivada(System.Security.Cryptography.RSA csp)
        {
            var llavePrivada = csp.ToXmlString(true);
            return llavePrivada;
        }
    }
}
