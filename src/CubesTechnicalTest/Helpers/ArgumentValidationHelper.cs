using CubesTechnicalTest.Core.Models;
using CubesTechnicalTest.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CubesTechnicalTest.Helpers
{
    public static class ArgumentValidationHelper
    {
        public static bool CheckParameters(string[] args)
        {
            var res = new List<Cube>();

            if (args.Length != 10)
            {
                ConsoleLogHelper.ShowInfoMessage($"The number of parameters must to be 10. {Constants.Constants._ARGUMENT_GENERIC_ERROR_MESSAGE}", System.ConsoleColor.Red);
                return false;
            }

            var cube1Name = args[0];
            var cube1X = args[1].ConvertToDouble();
            var cube1Y = args[2].ConvertToDouble();
            var cube1Z = args[3].ConvertToDouble();
            var cube1Length = args[4].ConvertToDouble();

            var cube2Name = args[5];
            var cube2X = args[6].ConvertToDouble();
            var cube2Y = args[7].ConvertToDouble();
            var cube2Z = args[8].ConvertToDouble();
            var cube2Length = args[9].ConvertToDouble();

            if ((cube1X == null) || (cube1Y == null) || (cube1Z == null) || (cube1Length == null) || 
                (cube2X == null) || (cube2Y == null) || (cube2Z == null) || (cube2Length == null))
            {
                ConsoleLogHelper.ShowInfoMessage($"Check the parameters. There is something wrong. {Constants.Constants._ARGUMENT_GENERIC_ERROR_MESSAGE}", System.ConsoleColor.Red);
                return false;
            }

            return true;
        }
    }
}
