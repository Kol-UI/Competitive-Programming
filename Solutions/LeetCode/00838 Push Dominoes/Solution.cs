// Push Dominoes
namespace CompetitiveProgramming.LeetCode.PushDominoes;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string PushDominoes(string dominoes)
    {
        string result = "";

        while (!result.Equals(dominoes))
        {
            result = dominoes;
            dominoes = dominoes.Replace("R.L", "-")
                                .Replace(".L", "LL")
                                .Replace("R.", "RR");
        }

        return result.Replace("-", "R.L");
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Push Dominoes");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}