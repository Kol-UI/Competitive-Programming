// Find the Power of K-Size Subarrays I

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindthePowerofKSizeSubarraysI
{
    public class Solution
    {
        public int[] ResultsArray(int[] nums, int k)
        {
            int n = nums.Length;
            int[] p = new int[n];
            p[0] = 0;
            for (int i = 1; i < n; i++)
            {
                p[i] = p[i - 1] + ((nums[i] == (nums[i - 1] + 1)) ? 1 : 0);
            }

            var ans = new int[n - k + 1];
            for (int i = 0; i < n - k + 1; i++)  
            {
                if (p[i + k - 1] == (p[i] + k - 1))
                {
                    ans[i] = (nums[i + k - 1]);
                }
                else
                {
                    ans[i] = -1;
                }
            }
            return ans;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find the Power of K-Size Subarrays I");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}