// Number Line Jumps

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.HackerRank.NumberLineJumps
{
    public class Solution
    {
        //public static string kangaroo(int x1, int v1, int x2, int v2)
        public static string Kangaroo(int x1, int v1, int x2, int v2)
        {
            if (v1 == v2)
            {
                return (x1 == x2) ? "YES" : "NO";
            }

            int meetingPoint = (x2 - x1) % (v1 - v2);

            return (meetingPoint == 0 && (x1 < x2 && v1 > v2) || (x1 > x2 && v1 < v2)) ? "YES" : "NO";
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.Kangaroo(0, 3, 4, 2), "YES"),
                ResultTester.CheckResult<string>(Solution.Kangaroo(0, 2, 5, 3), "NO"),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number Line Jumps");
            ResultTester.CheckCurrentSolution(ProblemOrigin.HackerRank, ProblemCategory.EasyHR, Test.TestCases());
        }
    }
}