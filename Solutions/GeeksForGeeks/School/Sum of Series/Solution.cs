using System;
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
}