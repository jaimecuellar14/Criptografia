using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversores
{
    public class StringAByteArray
    {

        public byte[] convertirByteArr(string llave)
        {
            return Convert.FromBase64String(llave);
        }
    }
}
