// Trim Trailing Vowels
namespace CompetitiveProgramming.LeetCode.TrimTrailingVowels;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string TrimTrailingVowels(string s)
    {
        HashSet<char> vows = new HashSet<char>("aeiou");
        int len = s.Length, idx = len - 1;
        while (idx >= 0 && vows.Contains(s[idx]))
        {
            idx--;
        }

        if (idx < 0)
            return "";

        return s.Substring(0, idx + 1);
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<string>(solution.TrimTrailingVowels("idea"), "id"),
            ResultTester.CheckResult<string>(solution.TrimTrailingVowels("day"), "day"),
            ResultTester.CheckResult<string>(solution.TrimTrailingVowels("aeiou"), ""),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Trim Trailing Vowels");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}