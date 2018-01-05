using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ReadText.Entidades;
using System.IO;
using FileHelpers;

namespace ReadText
{
    public class Xml
    {

        public void  Crear()
        {
            var engine = new FileHelperEngine<Us>();
            var record = engine.ReadFile(@"C: \Users\MUB102946\Documents\Visual Studio 2015\Projects\PruebaMVC\ReadText\File\Us.txt");

            List<Us> listaUs = new List<Us>();
      

            foreach (var item in record)
            {
                Us obj = new Us();
                obj.first_name = item.first_name;
                obj.last_name = item.last_name;
                obj.company_name = item.company_name;
                obj.address = item.address;
                obj.city = item.city;
                obj.country = item.country;
                obj.state = item.state;
                obj.zip = item.zip;
                obj.phone1 = item.phone1;
                obj.phone2 = item.phone2;
                obj.email = item.email;
                obj.web = item.web;
                listaUs.Add(obj);
            }

            DocumentoUS doc = new DocumentoUS();
            doc.lstus = listaUs;
            var xns = new XmlSerializerNamespaces();

            XmlSerializer serializer = new XmlSerializer(typeof(DocumentoUS));
            TextWriter writer = new StreamWriter(@"C: \Users\MUB102946\Documents\Visual Studio 2015\Projects\PruebaMVC\ReadText\xml\Us.xml");
            xns.Add("JCJode", "http://JaimeSiJodee.com");


            serializer.Serialize(writer, doc, xns);
            writer.Close();


        }

     





    }
}
