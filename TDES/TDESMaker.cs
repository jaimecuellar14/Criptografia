﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace TDES
{
    public class TDESMaker
    {

        public byte[] iv;
        public TripleDESCryptoServiceProvider CrearLlavesTDES()
        {
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.GenerateKey();
            tdes.GenerateIV();
            this.iv = tdes.IV;
            var llave = tdes.Key;
            return tdes;
        }

        public byte[] getIV()
        {
            return this.iv;
        }
    }
}
