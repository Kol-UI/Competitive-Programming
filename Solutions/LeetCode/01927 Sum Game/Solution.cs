// Sum Game
namespace CompetitiveProgramming.LeetCode.SumGame;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool SumGame(string num)
    {
        int Lcount = 0;
        int Rcount = 0;
        int n1 = num.Length / 2;
        int Lsum = 0;
        int Rsum = 0;

        for (int i = 0; i < n1; i++)
        {
            if (num[i] == '?')
                Lcount++;
            else
                Lsum += num[i] - '0';
        }

        for (int i = n1; i < num.Length; i++)
        {
            if (num[i] == '?')
                Rcount++;
            else
                Rsum += num[i] - '0';
        }

        if (Lcount == 0 && Rcount == 0)
            return Lsum != Rsum;

        if (2 * (Lsum - Rsum) != 9 * (Rcount - Lcount))
            return true;

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
            ResultTester.CheckResult<bool>(solution.SumGame("5023"), false),
            ResultTester.CheckResult<bool>(solution.SumGame("25??"), true),            
            ResultTester.CheckResult<bool>(solution.SumGame("?3295???"), false),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Sum Game");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}