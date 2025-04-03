// Maximum Value of an Ordered Triplet II
namespace CompetitiveProgramming.LeetCode.MaximumValueofanOrderedTripletII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long MaximumTripletValue(int[] nums)
    {
        long max = 0;
        long min = 0;
        long result = 0;
        int n = nums.Length;
        for (int i = 0; i < n ; i++)
        {
            result = Math.Max(result, min * nums[i]);
            min = Math.Max(min, max - nums[i]);
            max = Math.Max(max, nums[i]);
        }
        return result;
    }
}

public class TestSolution : Models.BaseSolution
{
    public override void GetResult()
    {
        Helpers.StyleHelper.Space();
        Helpers.StyleHelper.Title("Maximum Value of an Ordered Triplet II");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}