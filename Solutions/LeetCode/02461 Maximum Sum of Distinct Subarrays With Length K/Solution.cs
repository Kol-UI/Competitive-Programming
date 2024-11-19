// Maximum Sum of Distinct Subarrays With Length K
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumSumofDistinctSubarraysWithLengthK
{
    public class Solution
    {
        public long MaximumSubarraySum(int[] nums, int k)
        {
            Dictionary<int, int> elementCount = new Dictionary<int, int>();
            long maxSum = 0, windowSum = 0;
            int distinctCount = 0, start = 0;

            for (int end = 0; end < nums.Length; end++)
            {
                if (!elementCount.ContainsKey(nums[end]))
                {
                    elementCount[nums[end]] = 0;
                }
                elementCount[nums[end]]++;
                if (elementCount[nums[end]] == 1)
                {
                    distinctCount++;
                }
                windowSum += nums[end];

                if (end - start + 1 == k)
                {
                    if (distinctCount == k)
                    {
                        maxSum = Math.Max(maxSum, windowSum);
                    }
                    elementCount[nums[start]]--;
                    if (elementCount[nums[start]] == 0)
                    {
                        distinctCount--;
                    }
                    windowSum -= nums[start];
                    start++;
                }
            }

            return maxSum;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Sum of Distinct Subarrays With Length K");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}