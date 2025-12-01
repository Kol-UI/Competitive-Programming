// Longest Uncommon Subsequence II
namespace CompetitiveProgramming.LeetCode.LongestUncommonSubsequenceII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int FindLUSlength(string[] strs)
    {
        Array.Sort(strs, (a, b) => b.Length.CompareTo(a.Length));
        for (int i = 0; i < strs.Length; i++)
        {
            bool isUncommon = true;

            for (int j = 0; j < strs.Length; j++)
            {
                if (i == j) continue;
                if (IsSubsequence(strs[i], strs[j]))
                {
                    isUncommon = false;
                    break;
                }
            }

            if (isUncommon) return strs[i].Length;
        }

        return -1;
    }

    private bool IsSubsequence(string a, string b)
    {
        int i = 0, j = 0;

        while (i < a.Length && j < b.Length)
        {
            if (a[i] == b[j]) i++;
            j++;
        }

        return i == a.Length;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Longest Uncommon Subsequence II");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}