// Beginner - Reduce but Grow


using System;
using System.Linq;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeWars.EightKyu.BeginnerReducebutGrow
{
    public class Kata
    {
        public static int Grow(int[] x)
        {
            if (x == null || x.Length == 0)
            {
                return 0;
            }

            int result = 1;

            foreach (int value in x)
            {
                result *= value;
            }

            return result;
        }

        public static int Grow2(int[] x)
        {
            return x.Aggregate((a,b) => a*b);
        }

        public static int Grow3(int[] x)
        {
            var sum = 1;
            for(var i = 0; i < x.Length; i++)
            {
                sum *= x[i];
            }
            return sum;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Kata.Grow(new [] { 1, 2, 3 }), 6),
                ResultTester.CheckResult<int>(Kata.Grow(new [] { 4, 1, 1, 1, 4 }), 16),
                ResultTester.CheckResult<int>(Kata.Grow(new [] { 2, 2, 2, 2, 2, 2 }), 64),

                ResultTester.CheckResult<int>(Kata.Grow2(new [] { 1, 2, 3 }), 6),
                ResultTester.CheckResult<int>(Kata.Grow2(new [] { 4, 1, 1, 1, 4 }), 16),
                ResultTester.CheckResult<int>(Kata.Grow2(new [] { 2, 2, 2, 2, 2, 2 }), 64),

                ResultTester.CheckResult<int>(Kata.Grow3(new [] { 1, 2, 3 }), 6),
                ResultTester.CheckResult<int>(Kata.Grow3(new [] { 4, 1, 1, 1, 4 }), 16),
                ResultTester.CheckResult<int>(Kata.Grow3(new [] { 2, 2, 2, 2, 2, 2 }), 64),
            };

            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reduce but Grow");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeWars, ProblemCategory.EightKyu, Test.TestCases());
        }
    }
}