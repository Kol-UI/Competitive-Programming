// Shortest and Lexicographically Smallest Beautiful String
namespace CompetitiveProgramming.LeetCode.ShortestandLexicographicallySmallestBeautifulString;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string ShortestBeautifulSubstring(string s, int k)
    {
        var list = GetIndexesOfOnes(s);
        if (list.Count < k) return "";
        var min = list[k - 1] - list[0] + 1;
        var candidates = new List<string> { s.Substring(list[0], min) };
        for (int i = 0; i < list.Count - (k - 1); i++)
        {
            var min2 = list[i + k - 1] - list[i] + 1;
            if (min > min2)
            {
                min = min2;
                candidates = new List<string> { s.Substring(list[i], min) };
            }
            else
            {
                if (min == min2)
                {
                    candidates.Add(s.Substring(list[i], min));
                }
            }
        }
        candidates.Sort();
        var result = candidates[0];
        return result;
    }

    private List<int> GetIndexesOfOnes(string s)
    {
        var result = new List<int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '1') result.Add(i);
        }
        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<string>(solution.ShortestBeautifulSubstring("100011001", 3), "11001"),
            ResultTester.CheckResult<string>(solution.ShortestBeautifulSubstring("1011", 2), "11"),
            ResultTester.CheckResult<string>(solution.ShortestBeautifulSubstring("000", 1), ""),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Shortest and Lexicographically Smallest Beautiful String");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}