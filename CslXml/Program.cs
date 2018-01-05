using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace CslXml
{
    class Program
    {
        static void Main(string[] args)
        {
            
            XDocument xmlFile = XDocument.Load(@"C:\Users\MUB102946\Documents\Visual Studio 2015\Projects\CslXml\CslXml\xml\XMLApc.xml");

            var query = from c in xmlFile.Elements("RESULTADO").Elements("GENERALES").Elements("GENERALES").Elements("FEC_CREACION")
                        select c;

            foreach (XElement elementos in query)
            {
             elementos.Value = String.IsNullOrEmpty(elementos.Value)  ? DateTime.Now.ToString() : elementos.Value ;
            }

            string xml =  xmlFile.ToString();
            xmlFile.Save(@"C:\Users\MUB102946\Documents\Visual Studio 2015\Projects\CslXml\CslXml\xml\XMLApc.xml");

        }
    }

}
