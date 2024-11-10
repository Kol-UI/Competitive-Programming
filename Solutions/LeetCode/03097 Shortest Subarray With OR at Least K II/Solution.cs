// Shortest Subarray With OR at Least K II
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ShortestSubarrayWithORatLeastKII
{
    public class Solution
    {
        public int MinimumSubarrayLength(int[] nums, int k)
        {
            var n = nums.Length;
            var prefixBitSum = new int[n+1, 32];
            for (var i = 1; i <= n; i++)
            {
                var a = nums[i-1];
                for (var j = 0; j < 32; j++)
                {
                    prefixBitSum[i, j] = (a & 1) + prefixBitSum[i-1, j];
                    a >>= 1;
                }
            } 
            int l = 0, r = 0;
            var result = -1; 
            while (r < n && l <= r)
            {
                if (OrAtLeastIsK(prefixBitSum, l, r, k))
                {
                    if (result == -1 || result > r - l + 1)
                    {
                        result = r - l + 1;
                    }
                    if (l == r)
                    {
                        r++;
                    } else {
                        l++;
                    }
                } else 
                {
                    r++;
                }
            }
            return result;
        }

        private static bool OrAtLeastIsK(int[,] prefixBitSum, int from, int to, int k)
        {
            var orValue = 0;
            for (var j = 0; j < 32; j++)
            {
                if (prefixBitSum[to+1, j] - prefixBitSum[from, j] > 0)
                {
                    orValue += (1 << j);
                }
            }
            return orValue >= k;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(solution.MinimumSubarrayLength(new int[]{1,2,3},2), 1),
                ResultTester.CheckResult<int>(solution.MinimumSubarrayLength(new int[]{2,1,8},10), 3),
                ResultTester.CheckResult<int>(solution.MinimumSubarrayLength(new int[]{1,2},0), 1),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Shortest Subarray With OR at Least K II");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}