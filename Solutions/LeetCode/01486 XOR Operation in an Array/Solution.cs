// XOR Operation in an Array
namespace CompetitiveProgramming.LeetCode.XOROperationinanArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution 
{
    public int XorOperation(int n, int start) 
    {
        int xorResult = start, i = 1;

        while (i < n)
        {
            xorResult = xorResult ^ start + (2 * i);
            i++;
        }

        return xorResult;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.XorOperation(5, 0), 8),
            ResultTester.CheckResult<int>(solution.XorOperation(4, 3), 8),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("XOR Operation in an Array");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}