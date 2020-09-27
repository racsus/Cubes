using CubesTechnicalTest.Core.Models;
using CubesTechnicalTest.Core.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
       
        private readonly CubeService _cubeService;

        public UnitTest1()
        {
            
        }

        public UnitTest1(CubeService cubeService)
        {
            _cubeService = cubeService;
        }


        [TestMethod]
        public void CubesThatNotIntersect()
        {
            var a = new Cube("Cube A", new Coord(2, 2, 2), 2);
            var b = new Cube("Cube B", new Coord(10, 10, 10), 2);
            Assert.IsFalse(_cubeService.IsIntersection(a, b));
        }
    }
}
