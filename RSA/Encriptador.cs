using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Conversores;


namespace RSA
{
    public class Encriptador
    {
        public RSAMaker rsa = new RSAMaker();
        public RSAParameters publica;
        public RSAParameters privada;

        public void CrearLlaves()
        {
            var llaves = this.rsa.CreateRSAKeyPair();
            this.publica = llaves.ExportParameters(false);
            this.privada = llaves.ExportParameters(true);

        }
       public string Encriptar(string text, RSAParameters llavePublica)
        {
          // CrearLlaves();
            
            var csp = new RSACryptoServiceProvider();
            csp.ImportParameters(llavePublica);

            var bytesPlainTextData = new Conversores.HexByteArray().StringToByteArray(text);
            var bytesCypherText = csp.Encrypt(bytesPlainTextData, true);

            var cypherText = new Conversores.HexByteArray().ByteArrayToHex(bytesCypherText);

            return cypherText;
        }
        public string Desencriptar(string textoCifrado, RSAParameters llavePrivada)
        {
            
            // var bytesTextoCifrado = Convert.FromBase64String(textoCifrado);
            var bytesTextoCifrado = new Conversores.HexByteArray().StringToByteArray(textoCifrado);
            var csp = new RSACryptoServiceProvider();
            csp.ImportParameters(llavePrivada);

            var bytesTextoPlano = csp.Decrypt(bytesTextoCifrado,true);
            return new Conversores.HexByteArray().ByteArrayToHex(bytesTextoPlano);



        }
    }
}
