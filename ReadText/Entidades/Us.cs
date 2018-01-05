using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;
using System.Xml.Serialization;


namespace ReadText.Entidades
{

  [DelimitedRecord(",")]
  public  class Us
    {

        [XmlElement("First_Name")] 
        public string first_name { get; set; }

        [XmlElement("Last_Name")]
        public string last_name { get; set; }


        [XmlElement("Company_Name")]
        public string company_name { get; set; }

        [XmlElement("Address")]
        public string address { get; set; }


        [XmlElement("City")]
        public string city { get; set; }

        [XmlElement("Country")]
        public string country { get; set; }

        [XmlElement("State")]
        public string state { get; set; }


        [XmlElement("Zip")]
        public string zip { get; set; }

        [XmlElement("Phone1")]
        public string phone1 { get; set; }

        [XmlElement("Phone2")]
        public string phone2 { get; set; }

        [XmlElement("Email")]
        public string email { get; set; }

        [XmlElement("Web")]
        public string web { get; set; }
    }

    [XmlRoot("RootDocument")]
    public class DocumentoUS
    {
        [XmlElement(ElementName = "US", Namespace = "http://JaimeSiJodee.com")]
        public List<Us> lstus { get; set; }
    }

}
