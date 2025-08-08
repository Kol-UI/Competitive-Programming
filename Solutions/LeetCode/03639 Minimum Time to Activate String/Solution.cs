// Minimum Time to Activate String
namespace CompetitiveProgramming.LeetCode.MinimumTimetoActivateString;

using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinTime(string s, int[] order, int k)
    {
        var left = 0;
        var right = order.Length;

        while (left < right)
        {
            var mid = left + (right - left) / 2;

            if (Solve(s, order, mid) >= k)
            {
                right = mid;
            }
            else
                left = mid + 1;
        }

        return right == order.Length?-1:right;
    }

    private long Solve(string s, int[] order, int time)
    {
        var sb = new StringBuilder(s);
        for (var i = 0; i <= time; i++)
        {
            sb[order[i]] = '*';
        }

        var length = s.Length;
        var left = 0;
        var right = 0;
        var cnt = 0L;
        var result = 0L;

        while (left < length)
        {
            while (right < length && cnt < 1)
            {
                if (sb[right] == '*')
                {
                    cnt++;
                }
                right++;
            }

            if (cnt < 1)
                break;

            result += length - right + 1;
            if (sb[left++] == '*')
            {
                cnt--;
            }
        }

        return result;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Time to Activate String");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}