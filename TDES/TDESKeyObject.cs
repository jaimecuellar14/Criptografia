using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDES
{
    public  class TDESKeyObject
    {
        public byte[] tdesKey1 { set; get; }
        public byte[] tdesKey2 { set; get; }
        public byte[] tdesKey3 { set; get; }

        public TDESKeyObject dividirArray(byte[] key)
        {
            var keyObject = new TDESKeyObject();

            keyObject.tdesKey1 = key.Take(8).ToArray();
            var test = key.Skip(8);
            keyObject.tdesKey2 = test.Take(8).ToArray();
            var test2 = test.Skip(8);
            keyObject.tdesKey3 = test2.Take(8).ToArray();
            return keyObject;
        }
    }
}
