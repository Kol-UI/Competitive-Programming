// Make a Square with the Same Color

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MakeaSquarewiththeSameColor
{
    public class Solution
    {
        public bool CanMakeSquare(char[][] grid) =>
        (
            from row in Enumerable.Range(0, 2)
            from col in Enumerable.Range(0, 2)
            let square =
                from i in Enumerable.Range(0, 2)
                from j in Enumerable.Range(0, 2)
                select grid[row + i][col + j]
            select square
        ).Any(sq => sq.Count(c => c == 'B') != 2);
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Make a Square with the Same Color");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}