// Truncate Sentence
namespace CompetitiveProgramming.LeetCode.TruncateSentence;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string TruncateSentence(string s, int k)
    {
        return string.Join(" ", (s.Split(' ').Take(k)));
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<string>(solution.TruncateSentence("Hello how are you Contestant", 4), "Hello how are you"),
            ResultTester.CheckResult<string>(solution.TruncateSentence("What is the solution to this problem", 4), "What is the solution"),
            ResultTester.CheckResult<string>(solution.TruncateSentence("chopper is not a tanuki", 5), "chopper is not a tanuki"),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Truncate Sentence");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}