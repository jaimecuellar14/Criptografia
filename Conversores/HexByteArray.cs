using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversores
{
    public class HexByteArray
    {

        public  string ByteArrayToHex(byte[] llave)
        {
            StringBuilder hex = new StringBuilder(llave.Length * 2);
            foreach (byte b in llave)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }

        public  byte[] StringToByteArray(string llaveString)
        {
            int NumberChars = llaveString.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (var i = 0; i < NumberChars; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(llaveString.Substring(i, 2), 16);
            }

            return bytes;
        }
    }
}
