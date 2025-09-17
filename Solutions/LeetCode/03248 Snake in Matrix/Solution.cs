// Snake in Matrix
namespace CompetitiveProgramming.LeetCode.SnakeinMatrix;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int FinalPositionOfSnake(int n, IList<string> commands) =>
        commands.Sum(c => c[0] switch
        {
            'U' => -n,
            'D' => +n,
            'L' => -1,
            'R' => +1,
            _ => throw new NotImplementedException(),
        });
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Snake in Matrix");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}