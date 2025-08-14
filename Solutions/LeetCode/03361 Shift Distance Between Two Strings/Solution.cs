// Shift Distance Between Two Strings
namespace CompetitiveProgramming.LeetCode.ShiftDistanceBetweenTwoStrings;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long ShiftDistance(string s, string t, int[] nextCost, int[] previousCost)
    {
        long res = 0;
        int lenS = s.Length, lenT = t.Length, chaLen = 26;
        if(lenS != lenT)
            return -1;

        if(lenS == 0)
            return res;

        long[] pre = new long[chaLen], next = new long[chaLen];
        pre[chaLen-1] = previousCost[chaLen-1];
        next[0] = nextCost[0];
        for (int i = chaLen-2; i >= 0; i--)
        {
            pre[i] = previousCost[i] + pre[i + 1];
        }

        for (int i = 1; i < chaLen; i++)
        {
            next[i] = nextCost[i] + next[i-1];
        }

        for (int i = 0; i < lenS; i++)
        {

            int idxS = s[i] - 'a';
            int idxT = t[i] - 'a';

            if (idxS < idxT)
            {
                long preCnt = pre[0] - (pre[idxS+1] - (idxT < chaLen-1 ? pre[idxT+1] : 0));
                long nextCnt = next[idxT-1] - (idxS > 0 ?  next[idxS-1] : 0);
                res += Math.Min(preCnt, nextCnt);
            }
            else if (idxS > idxT)
            {
                long preCnt = pre[idxT+1] - (idxS < chaLen-1 ? pre[idxS+1] : 0);
                long nextCnt = next[chaLen-1] - (next[idxS-1] - (idxT > 0 ?next[idxT-1] : 0));
                res += Math.Min(preCnt, nextCnt);
            }
        }

        return res;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Shift Distance Between Two Strings");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}