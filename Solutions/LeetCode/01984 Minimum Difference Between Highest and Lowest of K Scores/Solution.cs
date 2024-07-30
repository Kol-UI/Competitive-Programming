// Minimum Difference Between Highest and Lowest of K Scores

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumDifferenceBetweenHighestandLowestofKScores
{
    public class Solution
    {
        public int MinimumDifference(int[] nums, int k)
        {
            if (nums == null || nums.Length < k)
            {
                throw new ArgumentException("Array must have at least k elements");
            }

            Array.Sort(nums);

            int minDifference = int.MaxValue;

            for (int i = 0; i <= nums.Length - k; i++)
            {
                int currentDifference = nums[i + k - 1] - nums[i];
                minDifference = Math.Min(minDifference, currentDifference);
            }

            return minDifference;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Difference Between Highest and Lowest of K Scores");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}