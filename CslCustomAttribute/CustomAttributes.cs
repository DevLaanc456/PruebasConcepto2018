using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CslCustomAttribute
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property) ]
    class CustomAttributes : Attribute
    {
        private string _nombre = string.Empty;
        private string _instrucciondescriptiva = string.Empty;
        public CustomAttributes()
        {
            // 
            // TODO: Add Constructor Logic here
            //
        }

        public CustomAttributes(string nombre, string instruccion)
        {
            NombreDescriptivo = nombre;
            InstruccionDescriptiva = instruccion;
        }

        private string NombreDescriptivo
        {
            get
            {

                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }

        private string InstruccionDescriptiva
        {
            get
            {

                return _instrucciondescriptiva;
            }
            set
            {
                _instrucciondescriptiva = value;
            }
        }

        public  void ObtenerPropiedades(Type _claseDestino)
        {
            foreach (PropertyInfo propertyInfo in _claseDestino.GetProperties())
            {
                string propertyName = propertyInfo.Name;
                object[] attribute = propertyInfo.GetCustomAttributes(typeof(CustomAttributes), true);

                // Just in case you have a property without this annotation
                foreach (Attribute attr in attribute)
                {
                    if (attr is CustomAttributes)
                    {
                        CustomAttributes theStereotype = (CustomAttributes)attr;
                        System.Console.WriteLine("{0} - {1}, {2}", propertyInfo.Name,
                        theStereotype.NombreDescriptivo, theStereotype.InstruccionDescriptiva);
                    }
                }

            }

        }

        public void ObtenerClases(Type _claseDestino)
        {
            foreach (PropertyInfo propertyInfo in _claseDestino.GetProperties())
            {
                string propertyName = propertyInfo.Name;
                object[] attribute = propertyInfo.GetCustomAttributes(typeof(CustomAttributes), true);

                // Just in case you have a property without this annotation
                foreach (Attribute attr in attribute)
                {
                    if (attr is CustomAttributes)
                    {
                        CustomAttributes theStereotype = (CustomAttributes)attr;
                        System.Console.WriteLine("{0} - {1}, {2}", propertyInfo.Name,
                        theStereotype.NombreDescriptivo, theStereotype.InstruccionDescriptiva);
                    }
                }

            }

        }



    }
    
    [CustomAttributes("Clase de Entidades", "Clase de Ejemplo")]
    public class DatosArchivos 
    {

        [CustomAttributes( "Nombre de Archivo",  "Tiene que decir el nombre del archivo")]
        public string NombreArchivo { get; set; }
        [CustomAttributes( "Ubicacion del Archivo",  "Tiene que decir la ubicacion del archivo")]
        public string Destino { get; set; }
        [CustomAttributes( "Longitud del Archivo",  "Tiene que decir cuanto pesa el archivo")]
        public string Tamaño { get; set; }
        
    }
}

