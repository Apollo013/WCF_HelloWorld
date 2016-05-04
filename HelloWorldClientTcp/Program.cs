using System;

namespace HelloWorldClientTcp
{
    /// <summary>
    /// Tests our WCF service hosted in IIS using the TCP protocol
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorldServiceRef.HelloWorldServiceClient client = new HelloWorldServiceRef.HelloWorldServiceClient("NetTcpBinding_IHelloWorldService");
            Console.WriteLine(client.GetMessage("ABA DABA DU"));
            Console.ReadLine();
        }
    }
}
