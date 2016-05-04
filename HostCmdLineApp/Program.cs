using System;
using System.ServiceModel;

namespace HostCmdLineApp
{
    class Program
    {
        /// <summary>
        /// Demonstrates hosting a service in a console application
        /// Furture demonstrates Consuming the service hosted in a console application
        /// See page 55, Chapter 3, 'Hosting the service in a managed application' - WCF 4.5 Multi-Layer Services Development with Entity Framework
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            /**** HOSTING ****/
            /*
            ServiceHost host = new ServiceHost(typeof(WCFServices.HelloWorldService),new Uri("http://localhost:18578/HostCmdLineApp/HelloWorldService.svc"));
            host.Open();
            Console.WriteLine("HelloWorldService is now running. ");

            HelloWorldServiceClient client = new HelloWorldServiceClient();

            Console.WriteLine(client.GetMessage("Paul hosted from cmd line"));
            Console.WriteLine("Press any key to stop it ...");
            Console.ReadKey();

            host.Close();
            */

            /**** CONSUMING ****/
            //HelloWorldServiceClient client = new HelloWorldServiceClient();
            //Console.WriteLine(client.GetMessage("Paul hosted from cmd line"));

            HelloWorldServiceClient client = new HelloWorldServiceClient();
            Console.WriteLine(client.GetMessage("Paul hosted from IIS"));
        }
    }
}
