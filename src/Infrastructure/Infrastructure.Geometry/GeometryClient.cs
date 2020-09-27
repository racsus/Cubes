using CubesTechnicalTest.Core.Interfaces;
using CubesTechnicalTest.Core.Models;
using System;

namespace Infrastructure.Geometry
{
    public class GeometryClient: IGeometryClient
    {
        public GeometryClient()
        {

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
            return (a.minX <= b.maxX && a.maxX >= b.minX) &&
                 (a.minY <= b.maxY && a.maxY >= b.minY) &&
                 (a.minZ <= b.maxZ && a.maxZ >= b.minZ);
        }

        /// <summary>
        /// Get the volume of the intersection taking the intersection points and calculating the volume of a cube (a * b * c)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double VolumeIntersection(Cube a, Cube b)
        {

            var xIntersecion = Math.Max(0, Math.Min(a.maxX, b.maxX) - Math.Max(a.minX, b.minX));
            var yIntersecion = Math.Max(0, Math.Min(a.maxY, b.maxY) - Math.Max(a.minY, b.minY));
            var zIntersecion = Math.Max(0, Math.Min(a.maxZ, b.maxZ) - Math.Max(a.minZ, b.minZ));
            return xIntersecion * yIntersecion * zIntersecion;
        }
    }
}
