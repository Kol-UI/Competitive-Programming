// Count Number of Nice Subarrays

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CountNumberofNiceSubarrays
{
    public class Solution
    {
        public static int NumberOfSubarrays(int[] nums, int k)
        {
            int n = nums.Length;
            int l = 0, r = 0, result = 0;

            while (r < n)
            {
                while (r < n && k > 0) if (nums[r++] % 2 != 0) k--;

                int i = l;
                int j = r;
                while (l < r && nums[l] % 2 == 0) l++;
                while (r < n && nums[r] % 2 == 0) r++;

                if (k == 0) result += (l - i + 1) * (r - j + 1);
                l++;
                k++;
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
                ResultTester.CheckResult<int>(Solution.NumberOfSubarrays(new int[]{1,1,2,1,1}, 3), 2),
                ResultTester.CheckResult<int>(Solution.NumberOfSubarrays(new int[]{2,4,6}, 1), 0),
                ResultTester.CheckResult<int>(Solution.NumberOfSubarrays(new int[]{2,2,2,1,2,2,1,2,2,2}, 2), 16)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Number of Nice Subarrays");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}