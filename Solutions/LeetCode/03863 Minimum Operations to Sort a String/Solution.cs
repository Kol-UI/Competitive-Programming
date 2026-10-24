// Minimum Operations to Sort a String
namespace CompetitiveProgramming.LeetCode.MinimumOperationstoSortaString;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinOperations(string s)
    {
        if (IsSorted(s)) return 0;
        if (s.Length == 2) return -1;
        var arr = s.ToCharArray();
        Array.Sort(arr);
        if ((s[0] == arr[0]) || (s[s.Length - 1] == arr[arr.Length - 1])) return 1;
        if ((s[0] == arr[arr.Length - 1]) && (s[s.Length - 1] == arr[0]))
        {
            if (arr[0] != arr[1] && arr[arr.Length - 2] != arr[arr.Length - 1])
            {
                return 3;
            }
        }
        return 2;
    }

    private bool IsSorted(string s)
    {
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i - 1] > s[i]) return false;
        }
        return true;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MinOperations("dog"), 1),
            ResultTester.CheckResult<int>(solution.MinOperations("card"), 2),
            ResultTester.CheckResult<int>(solution.MinOperations("gf"), -1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Operations to Sort a String");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}