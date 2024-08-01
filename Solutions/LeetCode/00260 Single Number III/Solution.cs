// Single Number III

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.SingleNumberIII
{
    public class Solution
    {
        public static int[] SingleNumber(int[] nums)
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (frequency.ContainsKey(num))
                {
                    frequency[num]++;
                }
                else
                {
                    frequency[num] = 1;
                }
            }

            List<int> result = new List<int>();
            foreach (var pair in frequency)
            {
                if (pair.Value == 1)
                {
                    result.Add(pair.Key);
                }
            }

            return result.ToArray();
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Solution.SingleNumber(new int[]{1,2,1,3,2,5}), new int[]{3,5}),
                ResultTester.CheckResult<int[]>(Solution.SingleNumber(new int[]{-1,0}), new int[]{-1,0}),
                ResultTester.CheckResult<int[]>(Solution.SingleNumber(new int[]{0,1}), new int[]{0,1}),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Single Number III");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}