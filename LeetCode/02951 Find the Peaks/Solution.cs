// Find the Peaks



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.FindthePeaks
{
    public class Solution
    {
        public static IList<int> FindPeaks(int[] mountain) => Enumerable
            .Range(1, mountain.Length - 2)
            .Where(i => mountain[i - 1] < mountain[i] && mountain[i] > mountain[i + 1])
            .ToList();    
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] mountainArray1 = new int[] { 2, 4, 4 };
            int[] mountainArray2 = new int[] { 1, 4, 3, 8, 5 };
            IList<int> listExpected1 = new List<int>();
            IList<int> listExpected2 = new List<int> { 1, 3 };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<int>>(Solution.FindPeaks(mountainArray1), listExpected1),
                ResultTester.CheckResult<IList<int>>(Solution.FindPeaks(mountainArray2), listExpected2),
            };
            return results;
        }
    }
}