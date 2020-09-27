using CubesTechnicalTest.Core.Interfaces;
using CubesTechnicalTest.Core.Services;
using Infrastructure.Geometry;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Infrastructure.DependencyBuilder
{
    public static class DependencyBuilderClient
    {
        public static ServiceProvider Configure()
        {
            return new ServiceCollection()
                .AddScoped<ICubeService, CubeService>()
                .AddScoped<IGeometryClient, GeometryClient>()
                .BuildServiceProvider();
        }
    }
}