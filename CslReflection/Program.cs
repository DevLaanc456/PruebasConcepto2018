using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CslReflection
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int i = 42;
            System.Type type = i.GetType();
            System.ValueType vtype = i.GetTypeCode();
            System.Console.WriteLine(type);
            System.Console.WriteLine(vtype);

            Persona per = new Persona();
            type = per.GetType();
            System.Console.WriteLine(type);
            Console.ReadKey();


        }



    }





    public class Persona
    {

        public string Nombre { get; set; }

        public string Apellido { get; set; }

    }


    }





