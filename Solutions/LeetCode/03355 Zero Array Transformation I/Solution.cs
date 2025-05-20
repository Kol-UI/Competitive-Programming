// Zero Array Transformation I
namespace CompetitiveProgramming.LeetCode.ZeroArrayTransformationI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool IsZeroArray(int[] nums, int[][] queries)
    {
        var tmp = new int[nums.Length + 1];
        foreach (var arr in queries)
        {
            tmp[arr[0]]++;
            tmp[arr[1] + 1]--;
        }

        var differ = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            differ += tmp[i];
            if (nums[i] > differ)
                return false;
        }

        return true;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Zero Array Transformation I");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}