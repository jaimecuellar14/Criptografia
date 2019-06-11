using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace TDES
{
    public class TDESCript
    {

        public byte[] Encriptar(string texto, byte[] llave, byte[] iv)
        {
            byte[] textoEncriptado;
            var tdes = new TripleDESCryptoServiceProvider();
            
            ICryptoTransform cript = tdes.CreateEncryptor(llave, iv);
            using (MemoryStream ms =new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, cript, CryptoStreamMode.Write))
                {
                    using (StreamWriter sw = new StreamWriter(cs))
                    sw.Write(texto);
                    textoEncriptado = ms.ToArray();
                }
            }

            return textoEncriptado;
        }

        public string Desencriptar(byte[] textoCifrado, byte[] llave, byte[] iv)
        {
            string textoOriginal = null;

            using (TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider())
            {
                ICryptoTransform decryptor = tdes.CreateDecryptor(llave, iv);
                using (MemoryStream ms = new MemoryStream(textoCifrado))
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader reader = new StreamReader(cs))
                            textoOriginal = reader.ReadToEnd();
                    }
                }
            }
            return textoOriginal;
        }
    }
}
