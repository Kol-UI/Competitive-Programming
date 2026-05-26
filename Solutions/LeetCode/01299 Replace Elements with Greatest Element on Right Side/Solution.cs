// Replace Elements with Greatest Element on Right Side
namespace CompetitiveProgramming.LeetCode.ReplaceElementswithGreatestElementonRightSide;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] ReplaceElements(int[] arr)
    {
        if (arr.Length == 1)
            return [-1];

        for (var i = 0; i < arr.Length - 1; i++)
        {
            arr[i] = arr[(i + 1)..].Max();
        }

        arr[^1] = -1;

        return arr;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int[]>(solution.ReplaceElements([17,18,5,4,6,1]), [18,6,6,6,1,-1]),
            ResultTester.CheckResult<int[]>(solution.ReplaceElements([400]), [-1]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Replace Elements with Greatest Element on Right Side");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}