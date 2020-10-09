using CubesTechnicalTest.Core.Interfaces;
using CubesTechnicalTest.Core.Services;
using CubesTechnicalTest.Factories;
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
            if (ArgumentValidationHelper.CheckParameters(args))
            {
                var cube1 = CubeFactory.BuildCube(args[0], args[1], args[2], args[3], args[4]);
                var cube2 = CubeFactory.BuildCube(args[5], args[6], args[7], args[8], args[9]);
                //Process execution
                if ((cube1 != null) && (cube2 != null))
                {
                    var service = _serviceProvider.GetService<ICubeService>();
                    if (service.IsIntersection(cube1, cube2))
                    {
                        ConsoleLogHelper.ShowInfoMessage($"Cubes intersect.", System.ConsoleColor.Green);
                        var volumeIntersecion = service.VolumeIntersection(cube1, cube2);
                        ConsoleLogHelper.ShowInfoMessage($"Intersected volume: {volumeIntersecion}", System.ConsoleColor.Green);
                    }
                    else
                    {
                        ConsoleLogHelper.ShowInfoMessage($"Cubes DON'T intersect.", System.ConsoleColor.Yellow);
                    }
                }
            }

            Console.WriteLine(string.Empty);
            Console.WriteLine("Press any key to close the application...");
            Console.ReadLine();
        }
    }
}
