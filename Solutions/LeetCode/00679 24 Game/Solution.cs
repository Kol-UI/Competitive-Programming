// 24 Game
namespace CompetitiveProgramming.LeetCode.TwentyFourGame;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool JudgePoint24(int[] cards)
    {
        foreach (var c in Permutations(cards))
        {
            foreach (var res in Calc(c, 0, 3))
            {
                if (Math.Abs(24 - res) < 1e-9)
                    return true;
            }
        }
        return false;
    }

    IEnumerable<double> Calc(int[] cards, int l, int r)
    {
        if (l == r)
        {
            yield return cards[l];
        }
        for (var m = l; m < r; m++)
        {
            foreach (var lp in Calc(cards, l, m))
            {
                foreach (var rp in Calc(cards, m+1, r))
                {
                    yield return lp + rp;
                    yield return lp - rp;
                    yield return lp * rp;
                    if (rp > 0) yield return lp / rp;
                }
            }
        }
    }

    IEnumerable<int[]> Permutations(int[] cards)
    {
        int[] indexes = new[]{0, 1, 2, 3};
        var i = 2;
        while (i >= 0)
        {
            yield return indexes.Select(e => cards[e]).ToArray();
            i = 2;
            while (i >= 0 && indexes[i] > indexes[i+1])
                i--;
            if (i >= 0)
            {
                var j = 3;
                while (indexes[i] > indexes[j])
                    j--;
                (indexes[i], indexes[j]) = (indexes[j], indexes[i]);
            }
            Array.Reverse(indexes, i+1, 3-i);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("24 Game");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}