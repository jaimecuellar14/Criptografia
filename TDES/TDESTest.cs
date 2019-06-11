using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TDES
{
    class TDESTest
    {

        [Test]
        public void TdesTest()
        {
            var tdes = new TDESMaker();
            tdes.CrearLlavesTDES();
        }
    }
}
