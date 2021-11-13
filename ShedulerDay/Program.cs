using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;

namespace ShedulerDay
{ 
    class Program
    {
        private static async Task Main(string[] args)
        {
            using IHost host = CreateHostBuilder(args).Build();
            var service = host.Services.GetService<CoreService>();
            service?.Start();
        }
        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .AddEnvironmentVariables()
                .AddCommandLine(args)
                .AddJsonFile("appsettings.json")
                .Build();
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices((_,service)=>service.Add(Register.Add(configuration)));
        }
    }
}
