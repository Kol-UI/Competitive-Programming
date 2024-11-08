// Maximum XOR for Each Query

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.MaximumXORforEachQuery
{
    public class Solution
    {
        public int[] GetMaximumXor(int[] nums, int maximumBit)
        {
            int[] xorray = new int[nums.Length];
            int target = (int)(Math.Pow(2, maximumBit) - 1);
            int j = nums.Length - 2;
            xorray[nums.Length - 1] = target ^ nums[0];

            for(int i = 1; i < nums.Length && j >= 0; i++)
            {
                xorray[j] = xorray[j+1] ^ nums[i];
                j--;
            }

            return xorray;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum XOR for Each Query");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}