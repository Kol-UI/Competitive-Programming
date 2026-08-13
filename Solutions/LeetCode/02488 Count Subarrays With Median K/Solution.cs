// Count Subarrays With Median K
namespace CompetitiveProgramming.LeetCode.CountSubarraysWithMedianK;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int CountSubarrays(int[] nums, int k)
    {
        if (nums.Length == 0)
        {
            return 0;
        }
        else if (k == 0)
        {
            return 0;
        }

        int kIndex = 0;
        while (nums[kIndex] != k)
        {
            kIndex++;
        }

        Dictionary<int, int> diff = new Dictionary<int, int>();
        int weight = 0;
        for (int i = kIndex; i < nums.Length; i++)
        {
            weight += nums[i] == k ? 0 : nums[i] > k ? 1 : -1;
            if (!diff.ContainsKey(weight))
            {
                diff.Add(weight, 0);
            }
            diff[weight] += 1;
        }
        
        int result = 0;
        weight = 0;
        for (int i = kIndex; i >= 0; i--)
        {
            weight += nums[i] == k ? 0 : nums[i] > k ? 1 : -1;

            int zero = diff.ContainsKey(-weight) ? diff[-weight] : 0;
            int largerPlusOne = diff.ContainsKey(-weight + 1) ? diff[-weight + 1] : 0;
            result += zero + largerPlusOne;
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
            ResultTester.CheckResult<int>(solution.CountSubarrays([3,2,1,4,5], 4), 3),
            ResultTester.CheckResult<int>(solution.CountSubarrays([2,3,1], 3), 1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Subarrays With Median K");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}