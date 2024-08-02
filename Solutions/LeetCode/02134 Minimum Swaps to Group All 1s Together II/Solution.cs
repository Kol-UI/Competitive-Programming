// Minimum Swaps to Group All 1s Together II

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumSwapstoGroupAll1sTogetherII
{
    public class Solution
    {
        public int MinSwaps(int[] nums)
        {
            int totalOnes = CountTotalOnes(nums);

            if (totalOnes <= 1)
            {
                return 0;
            }

            int maxOnesInWindow = FindMaxOnesInSlidingWindow(nums, totalOnes);
            return totalOnes - maxOnesInWindow;
        }

        private int CountTotalOnes(int[] nums)
        {
            int totalOnes = 0;
            foreach (int num in nums)
            {
                totalOnes += num;
            }
            return totalOnes;
        }

        private int FindMaxOnesInSlidingWindow(int[] nums, int windowSize)
        {
            int currentOnes = 0;
            int maxOnesInWindow = 0;
            int n = nums.Length;

            for (int i = 0; i < windowSize; i++)
            {
                currentOnes += nums[i];
            }
            maxOnesInWindow = currentOnes;

            for (int i = windowSize; i < n + windowSize; i++)
            {
                currentOnes += nums[i % n] - nums[(i - windowSize) % n];
                maxOnesInWindow = Math.Max(maxOnesInWindow, currentOnes);
            }

            return maxOnesInWindow;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Swaps to Group All 1s Together II");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}