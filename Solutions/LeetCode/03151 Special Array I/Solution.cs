// Special Array I

namespace CompetitiveProgramming.LeetCode.SpecialArrayI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool IsArraySpecial(int[] nums)
    {
        if (nums.Length <= 1)
        {
            return true;
        }
        
        for (int i = 1; i < nums.Length; i++)
        {
            if (HasSameParity(nums[i], nums[i - 1]))
            {
                return false;
            }
        }
        return true;
    }

    private bool HasSameParity(int a, int b)
    {
        return (a % 2) == (b % 2);
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<bool>(solution.IsArraySpecial(new int[]{1}), true),
            ResultTester.CheckResult<bool>(solution.IsArraySpecial(new int[]{2,1,4}), true),
            ResultTester.CheckResult<bool>(solution.IsArraySpecial(new int[]{4,3,1,6}), false),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Special Array I");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}