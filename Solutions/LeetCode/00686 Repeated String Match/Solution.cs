// Repeated String Match
namespace CompetitiveProgramming.LeetCode.RepeatedStringMatch;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int RepeatedStringMatch(string source, string target)
    {
        if (target.Length == 0) return 0;
        if (source.Length == 0) return -1;
        if (source.Contains(target)) return 1;
        foreach (char ch in target)
        {
            if (!source.Contains(ch)) return -1;
        }
        string original = source;
        int repetitions = 1;
        while (!source.Contains(target))
        {
            if (source.Length > target.Length * 2 && repetitions > 1) return -1;
            source += original;
            repetitions++;
        }
        return repetitions;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.RepeatedStringMatch("abcd", "cdabcdab"), 3),
            ResultTester.CheckResult<int>(solution.RepeatedStringMatch("a", "aa"), 2)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Repeated String Match");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}