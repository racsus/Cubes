using System;
using System.Collections.Generic;
using System.Text;

namespace CubesTechnicalTest.Extensions
{
    public static class StringExtension
    {
        public static double? ConvertToDouble(this string parameter)
        {
            double res;
            if (!double.TryParse(parameter, out res))
            {
                return null;
            }
            return res;
        }
    }
}
