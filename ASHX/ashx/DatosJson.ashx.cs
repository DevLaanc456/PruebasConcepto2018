using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace ASHX
{
    /// <summary>
    /// Summary description for DatosJson
    /// </summary>
    public class DatosJson : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            List<Persona> listadoPersona = new List<Persona>();
            listadoPersona.Add(new Persona { Nombre = "Isaac", Apellido = "Perez", Edad = "31" });
            listadoPersona.Add(new Persona { Nombre = "Jose", Apellido = "Perez", Edad = "31" });
            listadoPersona.Add(new Persona { Nombre = "Juan", Apellido = "Perez", Edad = "31" });
            listadoPersona.Add(new Persona { Nombre = "Jimena", Apellido = "Perez", Edad = "31" });
            listadoPersona.Add(new Persona { Nombre = "Jorge", Apellido = "Perez", Edad = "31" });

            context.Response.Write( JsonConvert.SerializeObject(listadoPersona));
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
    public class Persona
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Edad { get; set; }



    }

}