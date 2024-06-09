// Between Two Sets

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.HackerRank.BetweenTwoSets
{
    public class Solution
    {
        private static int Gcd(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private static int Lcm(int a, int b)
        {
            return (a * b) / Gcd(a, b);
        }

        //public static int getTotalX(List<int> a, List<int> b)
        public static int GetTotalX(List<int> a, List<int> b)
        {
            int lcmValue = a.Aggregate(Lcm);
            int gcdValue = b.Aggregate(Gcd);

            int count = 0;
            for (int i = lcmValue; i <= gcdValue; i += lcmValue)
            {
                if (gcdValue % i == 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
     
    public class Test
    {
        public static bool[] TestCases()
        {
            List<int> a1 = new() { 2, 4 };
            List<int> b1 = new() { 16, 32, 96 };

            List<int> a2 = new() { 3, 4 };
            List<int> b2 = new() { 24, 48 };
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.GetTotalX(a1, b1), 3),
                ResultTester.CheckResult<int>(Solution.GetTotalX(a2, b2), 2),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Between Two Sets");
            ResultTester.CheckCurrentSolution(ProblemOrigin.HackerRank, ProblemCategory.EasyHR, Test.TestCases());
        }
    }
}