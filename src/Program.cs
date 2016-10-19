using System;
using Microsoft.AspNetCore.Hosting;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string port = Environment.GetEnvironmentVariable("PORT") ?? "3000";

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .UseUrls($"http://0.0.0.0:{port}")
                .Build();

            host.Run();
        }
    }
}