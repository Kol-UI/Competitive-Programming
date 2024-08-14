// Find K-th Smallest Pair Distance

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindKthSmallestPairDistance
{
    public class Solution
    {
        public int SmallestDistancePair(int[] nums, int k)
        {
            Array.Sort(nums);
            int left = 0;
            int right = nums[nums.Length - 1] - nums[0];
            
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                int count = 0;
                
                for (int i = 0; i < nums.Length; i++)
                {
                    int j = i + 1;
                    while (j < nums.Length && nums[j] - nums[i] <= mid)
                    {
                        j++;
                    }
                    count += j - i - 1;
                }
                
                if (count < k)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            
            return left;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find K-th Smallest Pair Distance");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
        }
    }
}