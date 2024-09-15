// Longest Subarray With Maximum Bitwise AND

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.LongestSubarrayWithMaximumBitwiseAND
{
    public class Solution
    {
        public int LongestSubarray(int[] nums) {
            int maxVal = 0;
            
            foreach (int num in nums) {
                maxVal = Math.Max(maxVal, num);
            }
            
            int maxLength = 0;
            int currentLength = 0;
            
            foreach (int num in nums) {
                if (num == maxVal) {
                    currentLength++;
                    maxLength = Math.Max(maxLength, currentLength);
                } else {
                    currentLength = 0;
                }
            }
            
            return maxLength;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest Subarray With Maximum Bitwise AND");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}