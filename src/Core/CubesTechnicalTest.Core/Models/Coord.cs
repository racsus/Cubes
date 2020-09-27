using System;
using System.Collections.Generic;
using System.Text;

namespace CubesTechnicalTest.Core.Models
{
    public class Coord
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Coord(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
