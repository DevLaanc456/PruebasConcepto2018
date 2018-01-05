using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prueba.com;

namespace ConsoleWcFClienteAplication
{
    class Program
    {
        static void Main(string[] args)
        {

            var cliente = new HelloWordService.JJSo1Client();
            Console.WriteLine(cliente.GetMessage("Prueba #2"));

            var Persona = new HelloWordService.JJSo();

            HelloWordService.JJSo Per = new HelloWordService.JJSo();
            

            Persona = cliente.GetPersona(new HelloWordService.JJSo() { Nombre = "Juan", Apellido = "Pueblas", Edad = "23"});

            var client = new  JJSoClient();
            Console.WriteLine(client.GetMessage("Miu Ogatawa"));
            Console.ReadKey();


        }
    }
}
