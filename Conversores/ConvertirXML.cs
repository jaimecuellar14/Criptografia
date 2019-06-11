using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Conversores
{
    public class ConvertirXML
    {

        public XmlDocument convertirAXml(string llave)
        {
            XmlDocument doc = new XmlDocument();

            doc.LoadXml(llave);
            return doc;
        }
    }
}
