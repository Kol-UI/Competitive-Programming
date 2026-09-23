// Find Two Non-overlapping Sub-arrays Each With Target Sum
namespace CompetitiveProgramming.LeetCode.FindTwoNonoverlappingSubarraysEachWithTargetSum;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinSumOfLengths(int[] arr, int target)
    {
        int n = arr.Length;
        int inf = int.MaxValue / 2;
        int[] best = new int[n];
        for (int i = 0; i < n; i++) best[i] = inf;

        int sum = 0, left = 0;
        int result = inf;
        int minLen = inf;

        for (int right = 0; right < n; right++)
        {
            sum += arr[right];
            while (sum > target && left <= right)
            {
                sum -= arr[left++];
            }
            if (sum == target)
            {
                int len = right - left + 1;
                if (left > 0)
                {
                    result = Math.Min(result, len + best[left - 1]);
                }
                minLen = Math.Min(minLen, len);
            }
            best[right] = minLen;
        }

        return result == inf ? -1 : result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MinSumOfLengths([3,2,2,4,3], 3), 2),
            ResultTester.CheckResult<int>(solution.MinSumOfLengths([7,3,4,7], 7), 2),
            ResultTester.CheckResult<int>(solution.MinSumOfLengths([4,3,2,6,2,3,4], 6), -1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find Two Non-overlapping Sub-arrays Each With Target Sum");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}