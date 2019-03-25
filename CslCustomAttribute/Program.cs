using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CslCustomAttribute
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomAttributes _prueba = new CustomAttributes();
            _prueba.ObtenerPropiedadesClase(typeof(DatosArchivos));
            Console.WriteLine("Termino");
            Console.ReadKey();

        }
    }
}
