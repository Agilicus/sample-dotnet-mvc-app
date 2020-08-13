using System;
using Microsoft.AspNetCore.Hosting;

namespace CoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nAgilicus sample-dotnet-mvc-app started\n");

            var host = new WebHostBuilder()
            .UseKestrel()
            .UseStartup<Startup>()
            .Build();

            host.Run();
        }
    }
}
