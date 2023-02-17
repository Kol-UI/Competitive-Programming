using System;
using System.Collections.Generic;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming
{
    // dotnet run
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CSharpTDD.StartAllTDD();
        }

        // Helpers
        public static void Space()
        {
            Console.WriteLine();
        }

        public static void Title(string StringTitle)
        {
            Space();
            Console.WriteLine("--- {0} ---", StringTitle);
        }

        public static void SubTitle(string StringTitle)
        {
            Space();
            Console.WriteLine("- {0} -", StringTitle);
        }

        public static void PrintArray(int[] array)
        {
            Console.WriteLine("[{0}]", string.Join(", ", array));
        }

        public static void PrintBeforeAfterStringToString(string before, string after)
        {
            Console.WriteLine("Before : '{0}' - After : '{1}'", before, after);
        }

        public static void PrintBeforeAfterIntToInt(int before, int after)
        {
            Console.WriteLine("Before : '{0}' - After : '{1}'", before, after);
        }
    }
}