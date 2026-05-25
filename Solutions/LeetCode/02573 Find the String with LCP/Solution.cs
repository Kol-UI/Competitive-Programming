// Find the String with LCP
namespace CompetitiveProgramming.LeetCode.FindtheStringwithLCP;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string FindTheString(int[][] lcp)
    {
        const char unassigned = '\0';
        var n = lcp.Length;
        var candidate = new char[n];
        var nextCh = 'a';

        for (var i = 0; i < n; ++i)
        {
            if (candidate[i] != unassigned) continue;
            if (nextCh > 'z') return "";

            candidate[i] = nextCh;
            var row = lcp[i];
            for (var j = i + 1; j < n; ++j)
            {
                if (row[j] > 0) candidate[j] = nextCh;
            }
            
            ++nextCh;
        }

        for (var i = n - 1; i >= 0; --i)
        {
            var row = lcp[i];
            var nextRow = i + 1 < n ? lcp[i + 1] : null;

            for (var j = n - 1; j >= 0; --j)
            {
                var expected = 1;
                if (nextRow is not null && j + 1 < n)
                    expected = nextRow[j + 1] + 1;

                if (candidate[i] != candidate[j])
                {
                    if (row[j] != 0) return "";
                }
                else if (row[j] != expected)
                {
                    return "";
                }
            }
        }
        
        return new string(candidate);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find the String with LCP");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}