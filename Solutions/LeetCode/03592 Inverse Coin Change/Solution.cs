// Inverse Coin Change
namespace CompetitiveProgramming.LeetCode.InverseCoinChange;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public IList<int> FindCoins(int[] numWays)
    {
        var rs = new List<int>();
        var dic = new Dictionary<(int index, int sum), int>();
        for (int i = 0; i < numWays.Length; i++)
        {
            var index = rs.Count - 1;
            var countNumWays = CountNumWays((index, i + 1), dic, rs);
            if (countNumWays > numWays[i]) return new List<int>();
            if (countNumWays == numWays[i]) continue;
            if (numWays[i] - countNumWays > 1) return new List<int>();
            rs.Add(i + 1);
        }
        return rs;
    }

    private int CountNumWays((int index, int sum) key, Dictionary<(int index, int sum), int> dic, List<int> denominations)
    {
        if (dic.ContainsKey(key)) return dic[key];
        if (denominations.Count == 0) return 0;
        if (key.sum <= 0) return 1;
        if (key.index < 0) return 0;
        var biggestDenomination = denominations[key.index];
        var rs = 0;
        for (int i = 0; i <= key.sum / biggestDenomination; i++)
        {
            rs += CountNumWays((key.index - 1, key.sum - biggestDenomination * i), dic, denominations);
        }
        if (!dic.ContainsKey(key)) dic.Add(key, rs);
        return rs;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Inverse Coin Change");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}