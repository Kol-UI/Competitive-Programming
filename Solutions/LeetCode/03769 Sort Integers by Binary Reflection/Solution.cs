namespace CompetitiveProgramming.LeetCode.SortIntegersbyBinaryReflection;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    int Reverse(int num)
    {
        char[] res = Convert.ToString(num, 2).ToCharArray();
        Array.Reverse(res);
        return Convert.ToInt32(new string(res), 2);
    }
    
    public int[] SortByReflection(int[] nums)
    {
        return nums
            .OrderBy(x => Reverse(x))
            .ThenBy(x => x)
            .ToArray();
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int[]>(solution.SortByReflection([4,5,4]), [4,4,5]),
            ResultTester.CheckResult<int[]>(solution.SortByReflection([3,6,5,8]), [8,3,6,5]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Sort Integers by Binary Reflection");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}