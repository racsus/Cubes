using CubesTechnicalTest.Core.Interfaces;
using CubesTechnicalTest.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CubesTechnicalTest.Core.Services
{
    public class CubeService : ICubeService
    {
        private readonly IGeometryClient _geometryClient;
        public CubeService(IGeometryClient geometryClient)
        {
            _geometryClient = geometryClient;
        }

        /// <summary>
        /// Check if there is an intersection between cube 1 and cube 2
        /// f(A,B)=(AminX<=BmaxX∧AmaxX>=BminX)∧(AminY<=BmaxY∧AmaxY>=BminY)∧(AminZ<=BmaxZ∧AmaxZ>=BminZ)
        /// https://developer.mozilla.org/en-US/docs/Games/Techniques/3D_collision_detection
        /// </summary>
        /// <param name="cubeA"></param>
        /// <param name="cubeB"></param>
        /// <returns></returns>
        public bool IsIntersection(Cube a, Cube b)
        {
            return _geometryClient.IsIntersection(a, b);
        }

        /// <summary>
        /// Get the volume of the intersection taking the intersection points and calculating the volume of a cube (a * b * c)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double VolumeIntersection(Cube a, Cube b)
        {
            return _geometryClient.VolumeIntersection(a, b);
        }

    }
}
