// Digit Frequency Score
namespace CompetitiveProgramming.LeetCode.DigitFrequencyScore;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int DigitFrequencyScore(int n)
    {
        var freq = new Dictionary<int, int>();

        foreach (char c in n.ToString())
        {
            int d = c - '0';
            if (freq.ContainsKey(d))
                freq[d]++;
            else
                freq[d] = 1;
        }

        int score = 0;
        foreach (var pair in freq)
        {
            score += pair.Key * pair.Value;
        }

        return score;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.DigitFrequencyScore(122), 5),
            ResultTester.CheckResult<int>(solution.DigitFrequencyScore(101), 2)
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Digit Frequency Score");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}