using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Xml;


namespace HelloWorldService
{

    
    public class HelloWorldService: IHelloWorldService
    {

        public string GetMessage(string name)
        {
            return "Hello world from " + name + "!";
        }

        public Persona GetPersona(Persona _persona)
        {
            Persona persona = new Persona() { Nombre = _persona.Nombre, Apellido = _persona.Apellido, Edad = _persona.Edad };

            return _persona;
        }

    }

    [DataContract(Name = "JJSo", Namespace = "http://Prueba.com" )  ]
    public class Persona
    {
        [DataMember(Name = "Nombre",Order = 2)]
        public string Nombre { get; set; }

        [DataMember(Name = "Apellido", Order = 3)]
        public string Apellido { get; set; }

        [DataMember(Name = "Edad", Order = 1)]
        public string Edad { get; set; }

  
    }


}
