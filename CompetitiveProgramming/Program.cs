using System;
using CompetitiveProgramming.AddTwoIntegers;

namespace CompetitiveProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddTwoIntegersFunc();
        }

        private static void AddTwoIntegersFunc()
        {
            // Add Two Intergers
            // Case 1
            int Case1_2235 = AddTwoIntegers.Solution.Sum(12, 5);
            Console.WriteLine(Case1_2235);
            // Case 2
            int Case2_2235 = AddTwoIntegers.Solution.Sum(-10, 4);
            Console.WriteLine(Case2_2235);
        }
    }
}