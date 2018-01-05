using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;
using ReadText;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadText.Xml _read = new ReadText.Xml();
            _read.Crear();
        }
    }
}
