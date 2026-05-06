// Determine Color of a Chessboard Square
namespace CompetitiveProgramming.LeetCode.DetermineColorofaChessboardSquare;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool SquareIsWhite(string coordinates) => coordinates[0] % 2 == 0 ? coordinates[1] % 2 == 1 : coordinates[1] % 2 == 0;
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<bool>(solution.SquareIsWhite("a1"), false),
            ResultTester.CheckResult<bool>(solution.SquareIsWhite("h3"), true),
            ResultTester.CheckResult<bool>(solution.SquareIsWhite("c7"), false),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Determine Color of a Chessboard Square");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}