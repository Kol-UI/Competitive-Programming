// Transform Array to All Equal Elements
namespace CompetitiveProgramming.LeetCode.TransformArraytoAllEqualElements;

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool CanMakeEqual(int[] nums, int k)
    {
        var tmpNums = (int[])nums.Clone();
        return Check(nums, 1, k) || Check(tmpNums, -1, k);
    }

    public bool Check(int[] nums, int target, int k)
    {
        var cnt = 0;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] != target)
            {
                nums[i] *= -1;
                nums[i + 1] *= -1;
                cnt++;
            }
            if (cnt > k)
                return false;
        }
        if (nums[nums.Length - 1] != target)
            return false;

        return true;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Transform Array to All Equal Elements");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}