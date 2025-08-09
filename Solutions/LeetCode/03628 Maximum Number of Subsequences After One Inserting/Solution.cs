// Maximum Number of Subsequences After One Inserting
namespace CompetitiveProgramming.LeetCode.MaximumNumberofSubsequencesAfterOneInserting;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long NumOfSubsequences(string s)
    {
        var LCT = FindDistinct(s, "LCT");
        var LC = FindDistinct(s, "LC");
        var CT = FindDistinct(s, "CT");
        var T_Cnt = 0L;
        foreach (var c in s)
        {
            if (c == 'T')
                T_Cnt++;
        }

        var LT = 0L;
        var L_Cnt = 0L;
        foreach (var c in s)
        {
            if (c == 'L')
                L_Cnt++;
            else if (c == 'T')
                T_Cnt--;
            LT = Math.Max(LT, L_Cnt * T_Cnt);
        }

        return Math.Max(LC, Math.Max(CT, LT)) + LCT;
    }

    private long FindDistinct(string iStr, string iTarget)
    {
        var s = iStr.Length;
        var t = iTarget.Length;
        if (s < t)
            return 0;

        var f = new long[t + 1];
        f[0] = 1;

        for (var i = 0; i < s; i++)
        {
            for (var j = Math.Min(i, t - 1); j >= Math.Max(t - s + i, 0); j--)
            {
                if (iStr[i] == iTarget[j])
                    f[j + 1] += f[j];
            }
        }
        return f[t];
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Number of Subsequences After One Inserting");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}