// Count Elements With Strictly Smaller and Greater Elements  

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CountElementsWithStrictlySmallerandGreaterElements
{
    public class Solution
    {
        public int CountElements(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;

            int minValue = FindMinValue(nums);
            int maxValue = FindMaxValue(nums);

            return CountExcludingMinMax(nums, minValue, maxValue);
        }

        private int FindMinValue(int[] nums)
        {
            int minValue = nums[0];
            foreach (var num in nums)
            {
                if (num < minValue) minValue = num;
            }
            return minValue;
        }

        private int FindMaxValue(int[] nums)
        {
            int maxValue = nums[0];
            foreach (var num in nums)
            {
                if (num > maxValue) maxValue = num;
            }
            return maxValue;
        }

        private int CountExcludingMinMax(int[] nums, int minValue, int maxValue)
        {
            int count = 0;
            foreach (var num in nums)
            {
                if (num != minValue && num != maxValue) count++;
            }
            return count;
        }
    }
    
    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Elements With Strictly Smaller and Greater Elements");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}