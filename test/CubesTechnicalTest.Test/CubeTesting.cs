using CubesTechnicalTest.Core.Interfaces;
using CubesTechnicalTest.Core.Models;
using CubesTechnicalTest.Core.Services;
using Infrastructure.Geometry;
using NUnit.Framework;

namespace CubesTechnicalTest.Test
{
    public class CubeTesting
    {
        private CubeService _cubeService;

        public CubeTesting()
        {

        }

        [SetUp]
        public void Setup()
        {
            var geometryClient = new GeometryClient();
            _cubeService = new CubeService(geometryClient);
        }


        [Test]
        public void CubesThatNotIntersect()
        {
            var a = new Cube("Cube A", new Coord(2, 2, 2), 2);
            var b = new Cube("Cube B", new Coord(10, 10, 10), 2);
            Assert.False(_cubeService.IsIntersection(a, b));
        }

        [Test]
        public void CubesThatIntersect()
        {
            var a = new Cube("Cube A", new Coord(2, 2, 2), 2);
            var b = new Cube("Cube B", new Coord(3, 2, 2), 2);
            Assert.True(_cubeService.IsIntersection(a, b));
        }

        [Test]
        public void CubesIntersectionVolumeTest()
        {
            var a = new Cube("Cube A", new Coord(2, 2, 2), 2);
            var b = new Cube("Cube B", new Coord(3, 2, 2), 2);
            Assert.AreEqual(4, _cubeService.VolumeIntersection(a, b));
        }
    }
}