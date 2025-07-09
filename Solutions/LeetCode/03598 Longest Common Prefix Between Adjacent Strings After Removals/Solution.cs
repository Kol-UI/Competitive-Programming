// Longest Common Prefix Between Adjacent Strings After Removals
namespace CompetitiveProgramming.LeetCode.LongestCommonPrefixBetweenAdjacentStringsAfterRemovals;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] LongestCommonPrefix(string[] words)
    {
        var pre = new int[words.Length];
        var suf = new int[words.Length];
        var result = new int[words.Length];
        var tmpMax = 0;

        for (int i = 2; i < words.Length; i++)
        {
            tmpMax = Math.Max(tmpMax, LCP(words[i - 1], words[i - 2]));
            pre[i] = tmpMax;
        }

        tmpMax = 0;
        for (var i = words.Length - 3; i >= 0; i--)
        {
            tmpMax = Math.Max(tmpMax, LCP(words[i + 1], words[i + 2]));
            suf[i] = tmpMax;
        }

        for (var i = 0; i < words.Length; i++)
        {
            if (i == 0 || i == words.Length - 1)
                result[i] = Math.Max(pre[i], suf[i]);
            else
            {
                result[i] = Math.Max(LCP(words[i - 1], words[i + 1]), Math.Max(pre[i], suf[i]));
            }
        }

        return result;
    }

    private int LCP(string iStr1, string iStr2)
    {
        var minL = Math.Min(iStr1.Length, iStr2.Length);

        for (var i = 0; i < minL; i++)
        {
            if (iStr1[i] != iStr2[i])
                return i;
        }

        return minL;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Longest Common Prefix Between Adjacent Strings After Removals");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}