using System;
using System.Collections.Generic;
using CompetitiveProgramming.CoderByte;
using CompetitiveProgramming.LeetCode;

namespace CompetitiveProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ClimbingStairsFunc();
            AddTwoIntegersFunc();
            FirstFactorialFunc();
            FirstReverseFunc();
            ReplaceWithAlphabetPositionFunc();
            GrasshopperSummationFunc();
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
            int Case1_70 = LeetCode.ClimbingStairs.Solution.ClimbStairs(2);
            Console.WriteLine(Case1_70);
            // Case 2
            int Case2_70 = LeetCode.ClimbingStairs.Solution.ClimbStairs(3);
            Console.WriteLine(Case2_70);
            // Case 3
            int Case3_70 = LeetCode.ClimbingStairs.Solution.ClimbStairs(40);
            Console.WriteLine(Case3_70);
        }

        private static void AddTwoIntegersFunc()
        {
            Space();
            Title("2235. Add Two Integers");
            // Add Two Intergers
            // Case 1
            int Case1_2235 = LeetCode.AddTwoIntegers.Solution.Sum(12, 5);
            Console.WriteLine(Case1_2235);
            // Case 2
            int Case2_2235 = LeetCode.AddTwoIntegers.Solution.Sum(-10, 4);
            Console.WriteLine(Case2_2235);
        }

        private static void FirstFactorialFunc()
        {
            Space();
            Title("First Factorial");
            // First Factorial
            // Case 1
            int Case1_FirstFactorial = CoderByte.FirstFactorial.Solution.FirstFactorial(4);
            Console.WriteLine(Case1_FirstFactorial);
            // Case 2
            int Case2_FirstFactorial = CoderByte.FirstFactorial.Solution.FirstFactorial(8);
            Console.WriteLine(Case2_FirstFactorial);
        }

        private static void FirstReverseFunc()
        {
            Space();
            Title("First Reverse");
            // First Reverse
            // Case 1
            string Case1_FirstReverse = CoderByte.FirstReverse.Solution.FirstReverseFunc("Test");
            Console.WriteLine(Case1_FirstReverse);
            // Case 2
            string Case2_FirstReverse = CoderByte.FirstReverse.Solution.FirstReverseFunc("Code");
            Console.WriteLine(Case2_FirstReverse);
        }

        private static void ReplaceWithAlphabetPositionFunc()
        {
            Space();
            Title("Replace With Alphabet Position");
            // Case 1
            string Case1_ReplaceWithAlphabetPosition = CodeWars.SixKyu.ReplaceWithAlphabetPosition.Solution.AlphabetPosition("Test");
            Console.WriteLine(Case1_ReplaceWithAlphabetPosition);
        }

        private static void GrasshopperSummationFunc()
        {
            Space();
            Title("Grasshopper Summation");
            // Case 1
            int Case1_Grasshopper_Summation = CodeWars.EightKyu.GrasshopperSummation.Solution.summation(3);
            Console.WriteLine(Case1_Grasshopper_Summation);
            // Case 2
            int Case2_Grasshopper_Summation = CodeWars.EightKyu.GrasshopperSummation.Solution.summation(2);
            Console.WriteLine(Case2_Grasshopper_Summation);
            // Case 3
            int Case3_Grasshopper_Summation = CodeWars.EightKyu.GrasshopperSummation.Solution.summation(8);
            Console.WriteLine(Case3_Grasshopper_Summation);
        }
    }
}