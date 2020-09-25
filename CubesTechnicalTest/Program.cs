using CubesTechnicalTest.Core.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Threading.Tasks;

namespace CubesTechnicalTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var builder = new HostBuilder();
            builder.ConfigureAppConfiguration((hostcontext, config) =>
            {
                config.SetBasePath(Directory.GetCurrentDirectory());
                config.AddEnvironmentVariables();

                if (args != null)
                {
                    config.AddCommandLine(args);
                }

                config.AddUserSecrets<Program>();
            })
            .ConfigureServices((hostcontext, services) =>
            {
                services.AddScoped<CubeService>();
            })
            .UseConsoleLifetime();

            var host = builder.Build();

            using (host)
            {
                var entryPoint = host.Services.GetService<CubeService>();
                //await entryPoint.MigrateSlimPayCardAccounts();
                await host.StopAsync();
            }
        }
    }
}
