// Check If a String Contains All Binary Codes of Size K
namespace CompetitiveProgramming.LeetCode.CheckIfaStringContainsAllBinaryCodesofSizeK;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool HasAllCodes(string s, int k)
    {
        int target = 1 << k;
        Dictionary<string, bool> map = new();
        for (int i = 0; i < s.Length - k + 1; i++)
        {
            string str = s.Substring(i, k);
            map.TryAdd(str, true);
        }
        return target == map.Count;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<bool>(solution.HasAllCodes("00110110", 2), true),
            ResultTester.CheckResult<bool>(solution.HasAllCodes("0110", 1), true),
            ResultTester.CheckResult<bool>(solution.HasAllCodes("0110", 2), false),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Check If a String Contains All Binary Codes of Size K");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}