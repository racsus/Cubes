using CubesTechnicalTest.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CubesTechnicalTest.Core.Interfaces
{
    public interface IGeometryClient
    {
        bool IsIntersection(Cube cubeA, Cube cubeB);
        double VolumeIntersection(Cube cubeA, Cube cubeB);
    }
}
