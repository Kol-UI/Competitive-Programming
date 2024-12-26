// Target Sum

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.TargetSum
{
    public class Solution
    {
        public int FindTargetSumWays(int[] nums, int target)
        {
            long sum = nums.Sum();
            if ((sum + target) % 2 != 0 || sum < target) return 0;

            long subsetSum = (sum + target) / 2;
            return CountSubsets(nums, (int)subsetSum);
        }
        
        private int CountSubsets(int[] nums, int target)
        {
            if (target < 0) return 0;
            
            int[] dp = new int[target + 1];
            dp[0] = 1;

            foreach (int num in nums)
            {
                for (int j = target; j >= num; j--)
                {
                    if (j - num >= 0)
                    {
                        dp[j] += dp[j - num];
                    }
                }
            }

            return dp[target];
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(solution.FindTargetSumWays(new int[]{1,1,1,1,1}, 3), 5),
                ResultTester.CheckResult<int>(solution.FindTargetSumWays(new int[]{1}, 1), 1),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Target Sum");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}