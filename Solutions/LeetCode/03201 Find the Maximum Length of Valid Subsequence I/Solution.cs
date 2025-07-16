// Find the Maximum Length of Valid Subsequence I
namespace CompetitiveProgramming.LeetCode.FindtheMaximumLengthofValidSubsequenceI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaximumLength(int[] nums)
    {
        int countOdd = 0;
        int countEven = 0;
        int countSub = 0;
        int carry = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] % 2 == 0) countEven++;
            else countOdd++;

            if(i == 0)
            {
                carry = nums[i]%2;
                countSub++;
            }
            else
            {
                if(Math.Abs(carry-1) == nums[i] % 2)
                {
                    countSub++;
                    carry = Math.Abs(carry-1);
                }
            }
        }
        return Math.Max(Math.Max(countEven,countOdd),countSub);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find the Maximum Length of Valid Subsequence I");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}