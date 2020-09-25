using System;

namespace CubesTechnicalTest.Helpers
{
    public static class ConsoleLogHelper
    {
        public static void ShowInfoMessage(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}