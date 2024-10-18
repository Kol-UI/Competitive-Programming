// Count Number of Maximum Bitwise-OR Subsets

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CountNumberofMaximumBitwiseORSubsets
{
    public class Solution
    {
        public int CountMaxOrSubsets(int[] nums)
        {
            int max = 0, count = 0, l = nums.Length;
            foreach(var n in nums) max |= n;
            for(int mask = 1 << l; --mask >= 0; )
            {
                int b = 0, m = 1;
                foreach(var n in nums)
                {
                    if((mask & m) > 0) b |= n;
                    m <<= 1;
                }
                if (b == max) count++;
            }
            return count;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Number of Maximum Bitwise-OR Subsets");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}