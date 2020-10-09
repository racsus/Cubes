using CubesTechnicalTest.Core.Models;
using CubesTechnicalTest.Extensions;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CubesTechnicalTest.Factories
{
    public static class CubeFactory
    {
        public static Cube BuildCube(string name, string x, string y, string z, string cubeLength)
        {
            //Show Cubes info to the user
            return new Cube(name, new Coord(
                x.ConvertToDouble().Value,
                y.ConvertToDouble().Value,
                z.ConvertToDouble().Value), 
                cubeLength.ConvertToDouble().Value);
        }
    }
}
