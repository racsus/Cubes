using CubesTechnicalTest.Core.Interfaces;
using CubesTechnicalTest.Core.Services;
using CubesTechnicalTest.Helpers;
using Infrastructure.DependencyBuilder;
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
        private static IServiceProvider _serviceProvider;

        static async Task Main(string[] args)
        {
            //setup DI
            _serviceProvider = DependencyBuilderClient.Configure();

            //Parameters validation
            var cubes = ArgumentValidationHelper.CheckParameters(args);

            //Process execution
            if ((cubes != null) && (cubes.Count == 2))
            {
                var service = _serviceProvider.GetService<ICubeService>();
                if (service.IsIntersection(cubes[0], cubes[1]))
                {
                    ConsoleLogHelper.ShowInfoMessage($"Cubes intersect.", System.ConsoleColor.Green);
                    var volumeIntersecion = service.VolumeIntersection(cubes[0], cubes[1]);
                    ConsoleLogHelper.ShowInfoMessage($"Intersected volume: {volumeIntersecion}", System.ConsoleColor.Green);
                } else
                {
                    ConsoleLogHelper.ShowInfoMessage($"Cubes DON'T intersect.", System.ConsoleColor.Yellow);
                }
            }

            Console.WriteLine(string.Empty);
            Console.WriteLine("Press any key to close the application...");
            Console.ReadLine();
        }
    }
}
