// Simple multiplication

// This kata is about multiplying a given number by eight if it is an even number and by nine otherwise.


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.EightKyu.Simplemultiplication
{
    public class Solution
    {
        public static int Multiply(int x) 
        {
            if (x % 2 == 0)
                return x * 8;
            else
                return x * 9;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.Multiply(1), 9),
                ResultTester.CheckResult<int>(Solution.Multiply(2), 16),
                ResultTester.CheckResult<int>(Solution.Multiply(8), 64),
                ResultTester.CheckResult<int>(Solution.Multiply(4), 32),
                ResultTester.CheckResult<int>(Solution.Multiply(5), 45),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Simple multiplication");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeWars, ProblemCategory.EightKyu, Test.TestCases());
        }
    }
}