// Maximum Beauty of an Array After Applying Operation

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.MaximumBeautyofanArrayAfterApplyingOperation
{
    public class Solution
    {
        public int MaximumBeauty(int[] nums, int k)
        {
            Array.Sort(nums);
            
            int maxBeauty = 0;
            int left = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                while (nums[right] - nums[left] > 2 * k)
                {
                    left++;
                }
                maxBeauty = Math.Max(maxBeauty, right - left + 1);
            }
            
            return maxBeauty;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(solution.MaximumBeauty(new int[]{4,6,1,2}, 2), 3),
                ResultTester.CheckResult<int>(solution.MaximumBeauty(new int[]{1,1,1,1}, 10), 4),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Beauty of an Array After Applying Operation");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}