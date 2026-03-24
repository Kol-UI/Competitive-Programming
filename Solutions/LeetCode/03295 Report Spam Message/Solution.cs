// Report Spam Message
namespace CompetitiveProgramming.LeetCode.ReportSpamMessage;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool ReportSpam(string[] message, string[] bannedWords)
    {
        int len = bannedWords.Length;
        if (len == 0)
            return false;

        HashSet<string> banned = new HashSet<string>(bannedWords), spam = new();
        foreach (string s in message)
        {
            if (banned.Contains(s))
            {
                if (!spam.Add(s) || spam.Count == 2)
                    return true;
            }
        }

        return false;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<bool>(solution.ReportSpam(["hello","world","leetcode"], ["world","hello"]), true),
            ResultTester.CheckResult<bool>(solution.ReportSpam(["hello","programming","fun"], ["world","programming","leetcode"]), false),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Report Spam Message");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}