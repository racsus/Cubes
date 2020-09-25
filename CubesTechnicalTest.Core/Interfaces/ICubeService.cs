using CubesTechnicalTest.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CubesTechnicalTest.Core.Interfaces
{
    public interface ICubeService
    {
        bool IsIntersection(Cube cubeA, Cube cubeB);
        double VolumenIntersection(Cube cubeA, Cube cubeB);
    }
}
