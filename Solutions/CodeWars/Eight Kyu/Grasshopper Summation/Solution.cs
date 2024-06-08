using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using CompetitiveProgramming.TestDrivenDevelopment;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;

namespace CompetitiveProgramming.CodeWars.EightKyu.GrasshopperSummation
{
    public class Solution
	{
        //Write a program that finds the summation of every number from 1 to num.
        //The number will always be a positive integer greater than 0.

        //For example (Input -> Output):

        //2 -> 3 (1 + 2)
        //8 -> 36 (1 + 2 + 3 + 4 + 5 + 6 + 7 + 8)
        public static int summation(int num)
        {
            return Enumerable.Range(1, num).Sum();
        }
    }

    public class Test
    {
        public static bool[] TestGrasshopperSummation()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(GrasshopperSummation.Solution.summation(3), 6),
                ResultTester.CheckResult<int>(GrasshopperSummation.Solution.summation(2), 3),
                ResultTester.CheckResult<int>(GrasshopperSummation.Solution.summation(8), 36),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Grasshopper Summation");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeWars, ProblemCategory.EightKyu, Test.TestGrasshopperSummation());
        }
    }
}

