using System;

namespace HelloWorldClientSecure
{
    /// <summary>
    /// Demonstrates Basic Authentication - Chapter 11
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HelloWorldServiceRef.HelloWorldServiceClient();
            client.ClientCredentials.UserName.UserName = "[YOUR LOGIN NAME]";
            client.ClientCredentials.UserName.Password = "[YOUR PASSWORD]";
            Console.WriteLine(client.GetMessage("Basic Authentication caller"));
        }
    }
}
