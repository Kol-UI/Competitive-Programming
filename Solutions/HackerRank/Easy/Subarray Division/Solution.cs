// Subarray Division


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.HackerRank.SubarrayDivision
{
    public class Solution
    {
        //public static int birthday(List<int> s, int d, int m)
        public static int Birthday(List<int> s, int d, int m)
        {
            int count = 0;

            if (s.Count < m)
            {
                return count;
            }

            for (int i = 0; i <= s.Count - m; i++)
            {
                int sum = 0;
                for (int j = i; j < i + m; j++)
                {
                    sum += s[j];
                }

                if (sum == d)
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
            List<int> s = new List<int> { 1, 2, 1, 3, 2 };
            int d = 3;
            int m = 2;
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.Birthday(s, d, m), 2),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Subarray Division");
            ResultTester.CheckCurrentSolution(ProblemOrigin.HackerRank, ProblemCategory.EasyHR, Test.TestCases());
        }
    }
}