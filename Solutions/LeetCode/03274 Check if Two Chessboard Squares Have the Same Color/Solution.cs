// Check if Two Chessboard Squares Have the Same Color
namespace CompetitiveProgramming.LeetCode.CheckifTwoChessboardSquaresHavetheSameColor;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool CheckTwoChessboards(string coordinate1, string coordinate2)
    {
        int x = coordinate1[0] - 'a';
        int y = coordinate1[1] - '0';

        int first_cordinate_sum = x + y;

        int a = coordinate2[0] - 'a';
        int b = coordinate2[1] - '0';

        int second_cordinate_sum = a + b;

        if ((first_cordinate_sum % 2 == 0 && second_cordinate_sum % 2 == 0) || (first_cordinate_sum % 2 != 0 && second_cordinate_sum % 2 != 0))
            return true;

        return false;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<bool>(solution.CheckTwoChessboards("a1", "c3"), true),
            ResultTester.CheckResult<bool>(solution.CheckTwoChessboards("a1", "h3"), false)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Check if Two Chessboard Squares Have the Same Color");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}