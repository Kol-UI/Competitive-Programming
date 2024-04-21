// Shortest Subarray With OR at Least K I

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ShortestSubarrayWithORatLeastKI
{
    public class Solution
    {
        public static int MinimumSubarrayLength(int[] nums, int k)
        {
            var result = nums.Length + 1;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    if (SubarrayLength(i, j, nums) >= k)
                    {
                        result = Math.Min(result, j - i + 1);
                    }
                }
            }
            if (result == nums.Length + 1) result = -1;
            return result;
        }

        private static int SubarrayLength(int a, int b, int[] nums)
        {
            var result = nums[a];

            for (int i = a + 1; i <= b; i++)
            {
                result |= nums[i];
            }
            
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinimumSubarrayLength(new int[] {1,2,3}, 2), 1),
                ResultTester.CheckResult<int>(Solution.MinimumSubarrayLength(new int[] {1,2}, 0), 1),
                ResultTester.CheckResult<int>(Solution.MinimumSubarrayLength(new int[] {2,1,8}, 10), 3),

            };
            return results;
        }
    }
}