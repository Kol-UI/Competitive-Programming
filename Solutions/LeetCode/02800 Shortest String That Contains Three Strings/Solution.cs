// Shortest String That Contains Three Strings
namespace CompetitiveProgramming.LeetCode.ShortestStringThatContainsThreeStrings;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string MinimumString(string a, string b, string c)
    {
        string merge(string s1, string s2)
        {
            if (s1.Contains(s2)) return s1;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s2.StartsWith(s1.Substring(i))) return s1.Substring(0, i) + s2;
            }
            return s1 + s2;
        }

        string res = "";
        int l = int.MaxValue;
        foreach (string s in new string[]
        {
            merge(merge(a, b), c),
            merge(merge(b, a), c),
            merge(merge(c, b), a),
            merge(merge(b, c), a),
            merge(merge(a, c), b),
            merge(merge(c, a), b)
        })
        {
            if (s.Length < l)
            {
                res = s;
                l = s.Length;
            }
            else if (s.Length == l)
            {
                res = string.CompareOrdinal(res, s) < 0 ? res : s;
            }
        }

        return res;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<string>(solution.MinimumString("abc", "bca", "aaa"), "aaabca"),
            ResultTester.CheckResult<string>(solution.MinimumString("ab", "ba", "aba"), "aba"),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Shortest String That Contains Three Strings");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}