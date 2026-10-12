// Minimum Sum of Squared Difference
namespace CompetitiveProgramming.LeetCode.MinimumSumofSquaredDifference;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long MinSumSquareDiff(int[] nums1, int[] nums2, int k1, int k2)
    {
        long[] freq = new long[100001];
        long k3 = k1 + k2;
        long sumTotal = 0, maxValue = 0;

        for (int i = 0; i < nums1.Length; i++){
            int sum = Math.Abs(nums1[i] - nums2[i]);
            sumTotal += sum;
            freq[sum]++;

            if (sum > maxValue) maxValue = sum;
        }
        if (sumTotal <= k3) return 0;

        while (k3 > 0)
        {
            long decrementAmount = Math.Min(k3, freq[maxValue]);

            freq[maxValue] -= decrementAmount;
            freq[maxValue - 1] += decrementAmount;

            if (freq[maxValue] != 0) break;

            maxValue -= 1;
            k3 -= decrementAmount;
        }

        long result = 0;
        for (long i = 1; i <= maxValue; i++)
        {
            result += freq[i] * i * i;
        }

        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<long>(solution.MinSumSquareDiff([1,2,3,4], [2,10,20,19], 0, 0), 579),
            ResultTester.CheckResult<long>(solution.MinSumSquareDiff([1,4,10,12], [5,8,6,9], 1, 1), 43)
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Sum of Squared Difference");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}