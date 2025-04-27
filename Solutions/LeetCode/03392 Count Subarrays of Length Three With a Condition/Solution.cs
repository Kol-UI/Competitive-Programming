// Count Subarrays of Length Three With a Condition
namespace CompetitiveProgramming.LeetCode.CountSubarraysofLengthThreeWithaCondition;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int CountSubarrays(int[] nums)
    {
        int count = 0;

        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (2 * (nums[i] + nums[i + 2]) == nums[i + 1])
            {
                count++;
            }
        }

        return count;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Subarrays of Length Three With a Condition");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}