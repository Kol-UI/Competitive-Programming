// Minimum Equal Sum of Two Arrays After Replacing Zeros
namespace CompetitiveProgramming.CodeForces.MinimumEqualSumofTwoArraysAfterReplacingZeros;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long MinSum(int[] nums1, int[] nums2)
    {
        long sum1 = 0, z1 = 0;
        long sum2 = 0, z2 = 0;

        foreach(int x in nums1)
        {
            sum1 += x;
            if(x == 0)
            {
                z1++;
            }
        }

        foreach(int x in nums2)
        {
            sum2 += x;
            if(x == 0)
            {
                z2++;
            }
        }

        long ans1 = sum1+z1, ans2 = sum2 + z2;
        long ans = ans1 > ans2 ? ans1 : ans2;

        if(ans1 == ans2)
        {
            return ans;
        }

        if(ans1 == ans && z2 > 0)
        {
            return ans;
        }

        if(ans2 == ans && z1 > 0)
        {
            return ans;
        }

        return -1;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Equal Sum of Two Arrays After Replacing Zeros");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}