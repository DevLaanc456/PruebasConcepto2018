using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HostCmdLineApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var host = new ServiceHost(typeof(HelloWorldService.HelloWorldService), new Uri("http://localhost:55859/HostCmdLineApp/Service.svc"));
            host.Open();
            Console.WriteLine("HelloWordlService is now running");
            Console.WriteLine("Press any key to stop it....");
            Console.ReadKey();
            host.Close();



        }
    }
}
