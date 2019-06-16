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
      /* [Test]
        public void CrearRSATest()
        {
            var test1 = new RSAMaker();
            var xmlparser = new StringtoXML();
            var rsa = test1.CreateRSAKeyPair();
            var llavePublica = test1.KeyToString(rsa.ExportParameters(false));
            var llavePrivada = test1.KeyToString(rsa.ExportParameters(true));
            var llave1 = llavePublica.GetElementsByTagName("Modulus")[0].InnerText;
            var llave2 = llavePrivada.GetElementsByTagName("Modulus")[0].InnerText;            
            Assert.AreNotEqual(llave1, llave2);
        }
        */
        [Test]
        public void Encrypt()
        {
            var encriptador = new Encriptador();
            var rsa = new RSA.RSAMaker();
           var obj= rsa.CreateRSAKeyPair();
            var textoEncriptar = "Prueba Encriptacion";
            var texto = encriptador.Encriptar(textoEncriptar,obj.ExportParameters(true));


            Assert.AreNotEqual(textoEncriptar, texto);
        }

        [Test]
        public void Decrypt()
        {
            var encriptador = new Encriptador();
            var rsa = new RSA.RSAMaker();
            var obj = rsa.CreateRSAKeyPair();
            var textoEncriptar = "Prueba Desencriptacion";
            var texto = encriptador.Encriptar(textoEncriptar, obj.ExportParameters(true));

            var textoOriginal = encriptador.Desencriptar(texto,obj.ExportParameters(false));

            Assert.AreEqual(textoEncriptar, textoOriginal);
        }
    }
}
