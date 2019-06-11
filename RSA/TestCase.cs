using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Xml;

namespace RSA
{
    class TestCase
    {
     /*   [Test]
        public void Test()
        {
            var test1 = new RSAMaker();
            var xmlparser = new StringtoXML();
            var rsa = test1.CreateRSAKeyPair();
            var llavePublica = test1.KeyToString(rsa.PublicKey);
            var llavePrivada = test1.KeyToString(rsa.PrivateKey);
            var llave1 = llavePublica.GetElementsByTagName("Modulus")[0].InnerText;
            var llave2 = llavePrivada.GetElementsByTagName("Modulus")[0].InnerText;
            
            Assert.Equals(llave1, llave2);
           // Assert.AreNotEqual(rsa.PublicKey, rsa.PrivateKey);
        }*/

      /*  [Test]
        public void Encrypt()
        {
            var encriptador = new Encriptador();

            var textoEncriptar = "Prueba Encriptacion";
            var texto = encriptador.Encriptar(textoEncriptar);

            var textoOriginal = encriptador.Desencriptar(texto);

            Assert.AreEqual(textoEncriptar, textoOriginal);
        }*/
    }
}
