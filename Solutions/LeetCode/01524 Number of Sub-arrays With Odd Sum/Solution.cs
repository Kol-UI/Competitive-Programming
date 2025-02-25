// Number of Sub-arrays With Odd Sum
namespace CompetitiveProgramming.LeetCode.NumberofSubarraysWithOddSum;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int NumOfSubarrays(int[] arr)
    {
        const int MOD = 1000000007;
        long oddCount = 0;
        long evenCount = 1;
        long currentSum = 0;
        long oddSubarrayCount = 0;

        foreach (int num in arr)
        {
            currentSum += num;

            if (currentSum % 2 == 0)
            {
                oddSubarrayCount = (oddSubarrayCount + oddCount) % MOD;
                evenCount++;
            }
            else
            {
                oddSubarrayCount = (oddSubarrayCount + evenCount) % MOD;
                oddCount++;
            }
        }

        return (int)oddSubarrayCount;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Number of Sub-arrays With Odd Sum");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}