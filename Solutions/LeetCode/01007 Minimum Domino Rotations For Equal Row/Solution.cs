// Minimum Domino Rotations For Equal Row
namespace CompetitiveProgramming.LeetCode.MinimumDominoRotationsForEqualRow;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinDominoRotations(int[] tops, int[] bottoms)
    {
        var x = tops.Concat(bottoms)
                    .GroupBy(v => v)
                    .OrderBy(g => -g.Count())
                    .Select(g => g.Key)
                    .First();
        
        var rotationsTop = 0;
        var rotationsBottom = 0;
        for (int i = 0; i < tops.Length; i++)
        {
            if (tops[i] != x && bottoms[i] != x) return -1;
            if (tops[i] != x) rotationsTop++;
            if (bottoms[i] != x) rotationsBottom++;
        }
        
        return Math.Min(rotationsTop, rotationsBottom);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Domino Rotations For Equal Row");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}