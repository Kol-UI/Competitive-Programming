using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.Helpers.Outputs
{
    public class StyleHelper
    {
        public static void Space()
        {
            Console.WriteLine();
        }

        public static void Title(string StringTitle)
        {
            Space();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--- {0} ---", StringTitle);
            Console.ResetColor();
        }

        public static void SubTitle(string StringTitle)
        {
            Space();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("- {0} -", StringTitle);
            Console.ResetColor();
        }
    }
}