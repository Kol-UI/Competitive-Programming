// Check If Digits Are Equal in String After Operations I
namespace CompetitiveProgramming.LeetCode.CheckIfDigitsAreEqualinStringAfterOperationsI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool HasSameDigits(string s)
    {
        int n = s.Length;
        char[] arr = s.ToCharArray();
        for (int i = 1; i <= n - 2; i++)
        {
            for (int j = 0; j <= n - 1 - i; j++)
            {
                arr[j] = (char)(((arr[j] - '0') + (arr[j + 1] - '0')) % 10 + '0');
            }
        }
        return arr[0] == arr[1];
    }
}


public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<bool>(solution.HasSameDigits("3902"), true),
            ResultTester.CheckResult<bool>(solution.HasSameDigits("34789"), false),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Check If Digits Are Equal in String After Operations I");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}