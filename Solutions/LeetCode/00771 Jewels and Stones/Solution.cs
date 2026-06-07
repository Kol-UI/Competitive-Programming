// Jewels and Stones
namespace CompetitiveProgramming.LeetCode.JewelsandStones;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int NumJewelsInStones(string jewels, string stones)
    {
        int gems = 0;

        foreach (char c in stones)
        {
            if (jewels.Contains(c))
            gems++;
        }

        return gems;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.NumJewelsInStones("aA", "aAAbbbb"), 3),
            ResultTester.CheckResult<int>(solution.NumJewelsInStones("z", "ZZ"), 0),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Jewels and Stones");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}