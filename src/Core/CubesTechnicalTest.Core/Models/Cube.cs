using System;
using System.Collections.Generic;
using System.Text;

namespace CubesTechnicalTest.Core.Models
{
    public class Cube: Figure3D
    {
        public double EdgesSize { get; set; }

        public double minX
        {
            get { return Coord.X - EdgesSize / 2.0; }
        }
        public double minY
        {
            get { return Coord.Y - EdgesSize / 2.0; }
        }
        public double minZ
        {
            get { return Coord.Z - EdgesSize / 2.0; }
        }

        public double maxX
        {
            get { return Coord.X + EdgesSize / 2.0; }
        }
        public double maxY
        {
            get { return Coord.Y + EdgesSize / 2.0; }
        }
        public double maxZ
        {
            get { return Coord.Z + EdgesSize / 2.0; }
        }

        public Cube(string name, Coord coord, double edgesSize)
        {
            Name = name;
            Coord = coord;
            EdgesSize = edgesSize;
        }

    }
}
