// Maximize Sum Of Array After K Negations

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximizeSumOfArrayAfterKNegations
{
    public class Solution
    {
        public int LargestSumAfterKNegations(int[] nums, int k)
        {
            Array.Sort(nums);

            int negationsLeft = k;
            int index = 0;
            int length = nums.Length;

            while (index < length && nums[index] < 0 && negationsLeft > 0)
            {
                nums[index] = -nums[index];
                negationsLeft--;
                index++;
            }

            int totalSum = 0;
            int minAbsoluteValue = int.MaxValue;

            foreach (int number in nums)
            {
                totalSum += number;
                minAbsoluteValue = Math.Min(Math.Abs(number), minAbsoluteValue);
            }

            if (negationsLeft % 2 == 1)
            {
                totalSum -= 2 * minAbsoluteValue;
            }

            return totalSum;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximize Sum Of Array After K Negations");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}