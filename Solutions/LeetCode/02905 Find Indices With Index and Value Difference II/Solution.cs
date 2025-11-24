// Find Indices With Index and Value Difference II
namespace CompetitiveProgramming.LeetCode.FindIndicesWithIndexandValueDifferenceII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] FindIndices(int[] nums, int indexDifference, int valueDifference)
    {
        var min = (Val: int.MaxValue, Idx: -1);
        var max = (Val: int.MinValue, Idx: -1);

        for (int i = indexDifference; i < nums.Length; i++)
        {
            var j = i - indexDifference;

            if (nums[j] < min.Val)
                min = (nums[j], j);

            if (nums[j] > max.Val)
                max = (nums[j], j);

            if (nums[i] - min.Val >= valueDifference)
                return [min.Idx, i];

            if (max.Val - nums[i] >= valueDifference)
                return [max.Idx, i];
        }

        return [-1, -1];
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find Indices With Index and Value Difference II");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}