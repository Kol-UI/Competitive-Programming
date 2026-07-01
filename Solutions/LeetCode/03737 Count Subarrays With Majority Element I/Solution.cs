// Count Subarrays With Majority Element I
namespace CompetitiveProgramming.LeetCode.CountSubarraysWithMajorityElementI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int CountMajoritySubarrays(int[] nums, int target)
    {
        int n = nums.Length;
        int result = 0;

        for (int i = 0; i < n; i++)
        {
            int count = 0;

            for (int j = i; j < n; j++)
            {
                if (nums[j] == target)
                {
                    count++;
                }

                int length = j - i + 1;

                if (2 * count > length)
                {
                    result++;
                }
            }
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
            ResultTester.CheckResult<int>(solution.CountMajoritySubarrays([1,2,2,3], 2), 5),
            ResultTester.CheckResult<int>(solution.CountMajoritySubarrays([1,1,1,1], 1), 10),
            ResultTester.CheckResult<int>(solution.CountMajoritySubarrays([1,2,3], 4), 0),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Subarrays With Majority Element I");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}