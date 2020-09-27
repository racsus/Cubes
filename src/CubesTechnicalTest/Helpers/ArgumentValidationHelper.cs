using CubesTechnicalTest.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CubesTechnicalTest.Helpers
{
    public static class ArgumentValidationHelper
    {
        public static List<Cube> CheckParameters(string[] args)
        {
            var res = new List<Cube>();

            if (args.Length != 10)
            {
                ConsoleLogHelper.ShowInfoMessage($"The number of parameters must to be 10. {Constants.Constants._ARGUMENT_GENERIC_ERROR_MESSAGE}", System.ConsoleColor.Red);
                return null;
            }

            var cube1Name = args[0];
            var cube1X = GetDoubleParameter(args[1]);
            var cube1Y = GetDoubleParameter(args[2]);
            var cube1Z = GetDoubleParameter(args[3]);
            var cube1Length = GetDoubleParameter(args[4]);

            var cube2Name = args[5];
            var cube2X = GetDoubleParameter(args[6]);
            var cube2Y = GetDoubleParameter(args[7]);
            var cube2Z = GetDoubleParameter(args[8]);
            var cube2Length = GetDoubleParameter(args[9]);

            if ((cube1X == null) || (cube1Y == null) || (cube1Z == null) || (cube1Length == null) || 
                (cube2X == null) || (cube2Y == null) || (cube2Z == null) || (cube2Length == null))
            {
                ConsoleLogHelper.ShowInfoMessage($"Check the parameters. There is something wrong. {Constants.Constants._ARGUMENT_GENERIC_ERROR_MESSAGE}", System.ConsoleColor.Red);
                return null;
            }

            //Show Cubes info to the user
            res.Add(new Cube(cube1Name, new Coord(cube1X.Value, cube1Y.Value, cube1Z.Value), cube1Length.Value));
            ConsoleLogHelper.ShowInfoMessage($"Cube {cube1Name} created in coords ({cube1X.Value},{cube1Y.Value},{cube1Z.Value}) with a length of {cube1Length.Value}.", System.ConsoleColor.White);
            res.Add(new Cube(cube1Name, new Coord(cube2X.Value, cube2Y.Value, cube2Z.Value), cube2Length.Value));
            ConsoleLogHelper.ShowInfoMessage($"Cube {cube2Name} created in coords ({cube2X.Value},{cube2Y.Value},{cube2Z.Value}) with a length of {cube2Length.Value}.", System.ConsoleColor.White);

            return res;
        }

        private static double? GetDoubleParameter(string parameter)
        {
            double res;
            if (!double.TryParse(parameter, out res))
            {
                ConsoleLogHelper.ShowInfoMessage($"The parameter '{parameter}' should be numerical. {Constants.Constants._ARGUMENT_GENERIC_ERROR_MESSAGE}", System.ConsoleColor.Red);
                return null;
            }
            return res;
        }
    }
}
