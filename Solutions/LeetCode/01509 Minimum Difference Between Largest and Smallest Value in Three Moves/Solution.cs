// Minimum Difference Between Largest and Smallest Value in Three Moves

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumDifferenceBetweenLargestandSmallestValueinThreeMoves
{
    public class Solution
    {
        public int MinDifference(int[] nums)
        {
            int n = nums.Length;
            if (n <= 4) return 0;
            
            Array.Sort(nums);
            
            int minDifference = int.MaxValue;
            
            minDifference = Math.Min(minDifference, nums[n-4] - nums[0]);
            
            minDifference = Math.Min(minDifference, nums[n-3] - nums[1]);
            
            minDifference = Math.Min(minDifference, nums[n-2] - nums[2]);
            
            minDifference = Math.Min(minDifference, nums[n-1] - nums[3]);
            
            return minDifference;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Difference Between Largest and Smallest Value in Three Moves");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}