// Sum Multiples


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.SumMultiples
{
    public class Solution
    {
        public static int SumOfMultiples(int n) => Enumerable.Range(1,n).Where(x => x % 3 == 0 || x % 5 == 0 || x % 7 == 0).Sum(); 
    }
    
    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.SumOfMultiples(7), 21),
                ResultTester.CheckResult<int>(Solution.SumOfMultiples(10), 40),
                ResultTester.CheckResult<int>(Solution.SumOfMultiples(9), 30),
            };
            return results;
        }
    }
}