using System;
using CompetitiveProgramming.AddTwoIntegers;

namespace CompetitiveProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ClimbingStairsFunc();
            AddTwoIntegersFunc();
        }

        public static void Space()
        {
            Console.WriteLine();
        }

        public static void Title(string StringTitle)
        {
            Space();
            Console.WriteLine("--- {0} ---", StringTitle);
        }

        private static void ClimbingStairsFunc()
        {
            Space();
            Title("70. Climbing Stairs");
            // Climbing Stairs
            // Case 1
            int Case1_70 = ClimbingStairs.Solution.ClimbStairs(2);
            Console.WriteLine(Case1_70);
            // Case 2
            int Case2_70 = ClimbingStairs.Solution.ClimbStairs(3);
            Console.WriteLine(Case2_70);
            // Case 3
            int Case3_70 = ClimbingStairs.Solution.ClimbStairs(40);
            Console.WriteLine(Case3_70);
        }

        private static void AddTwoIntegersFunc()
        {
            Space();
            Title("2235. Add Two Integers");
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