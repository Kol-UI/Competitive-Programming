// Contiguous Array


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ContiguousArray
{
    public class Solution
    {
        public static int FindMaxLength(int[] nums)
        {
            var dict = new Dictionary<int,int>();
            int diff = 0;
            int maxLen = 0;
            
            dict.Add(0, -1);
            for (int i = 0; i < nums.Length; i++)
            {
                diff += (nums[i] == 1 ? 1 : -1);
                if (dict.ContainsKey(diff))
                    maxLen = Math.Max(maxLen, i - dict[diff]);
                else
                    dict.Add(diff, i);
            }
            
            return maxLen;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.FindMaxLength(new int[]{0,1}), 2),
                ResultTester.CheckResult<int>(Solution.FindMaxLength(new int[]{0,1,0}), 2),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Contiguous Array");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}