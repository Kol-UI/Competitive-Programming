// Check if Word Equals Summation of Two Words
namespace CompetitiveProgramming.LeetCode.CheckifWordEqualsSummationofTwoWords;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool IsSumEqual(string firstWord, string secondWord, string targetWord)
    {
        return (GetNumericalValue(firstWord) + GetNumericalValue(secondWord)) == GetNumericalValue(targetWord);
    }

    private int GetNumericalValue(string s)
    {
        int num = 0;
        int multiplier = 1;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            num+= (s[i]-'a') * multiplier;
            multiplier *= 10;
        }
        return num;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<bool>(solution.IsSumEqual("acb", "cba", "cdb"), true),
            ResultTester.CheckResult<bool>(solution.IsSumEqual("aaa", "a", "aab"), false),
            ResultTester.CheckResult<bool>(solution.IsSumEqual("aaa", "a", "aaaa"), true),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Check if Word Equals Summation of Two Words");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}