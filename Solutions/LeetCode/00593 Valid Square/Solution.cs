// Valid Square
namespace CompetitiveProgramming.LeetCode.ValidSquare;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool ValidSquare(int[] p1, int[] p2, int[] p3, int[] p4)
    {
        var p = new int[][] { p1, p2, p3, p4 };

        Array.Sort(p, (a, b) =>
            (a[0] - b[0]) == 0 ? (a[1] - b[1]) : (a[0] - b[0]));

        if (p[0][0] == p[1][0] && p[0][1] == p[1][1]) return false;

        return Dist(p[0], p[3]) == Dist(p[1], p[2]) &&
               Dist(p[0], p[1]) == Dist(p[0], p[2]);
    }

    int Dist(int[] p1, int[] p2)
    {
        var d1 = p1[0] - p2[0];
        var d2 = p1[1] - p2[1];

        return d1 * d1 + d2 * d2;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Valid Square");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}