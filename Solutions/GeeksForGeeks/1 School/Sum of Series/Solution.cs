using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.GeeksForGeeks.School.SumofSeries
{
	public class Solution
	{
        public static long SeriesSum(int n)
        {
            long n2 = n;
            return n2*(n2+1)/2;
        }
    }

    public class Test
    {
        public static bool[] TestSumofSeries()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<long>(Solution.SeriesSum(1), 1),
                ResultTester.CheckResult<long>(Solution.SeriesSum(5), 15)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sum of Series");
            ResultTester.CheckCurrentSolution(ProblemOrigin.GeeksForGeeks, ProblemCategory.SchoolGFG, Test.TestSumofSeries());
        }
    }
}