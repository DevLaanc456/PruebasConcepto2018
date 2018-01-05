using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace HelloWorldService
{
    [ServiceContract(Name = "JJSo", Namespace = "http://Prueba.com")]
    interface IHelloWorldService
    {
        [OperationContract]
        string GetMessage(string name);

        [OperationContract]
        Persona GetPersona(Persona _persona);
    }
}
