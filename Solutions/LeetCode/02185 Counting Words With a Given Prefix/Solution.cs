// Counting Words With a Given Prefix

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CountingWordsWithaGivenPrefix;

public class Solution
{
    public int PrefixCount(string[] words, string pref)
    {
        int count = 0;
        foreach (var word in words)
        { 
            if (word.StartsWith(pref)) count++;
        }
        return count;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.PrefixCount(new string[]{"pay","attention","practice","attend"}, "at"), 2),
            ResultTester.CheckResult<int>(solution.PrefixCount(new string[]{"leetcode","win","loops","success"}, "code"), 0),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Counting Words With a Given Prefix");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}