// Maximum Square Area by Removing Fences From a Field
namespace CompetitiveProgramming.LeetCode.MaximumSquareAreabyRemovingFencesFromaField;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaximizeSquareArea(int m, int n, int[] hFences, int[] vFences)
    {
        long MOD = 1000000007;
        List<long> hor = new List<long>(hFences.Length + 2);
        List<long> ver = new List<long>(vFences.Length + 2);
        hor.Add(1); hor.Add(m);
        ver.Add(1); ver.Add(n);
        foreach (var x in hFences) hor.Add(x);
        foreach (var x in vFences) ver.Add(x);
        hor.Sort(); ver.Sort();

        long[] hPrefix = new long[hor.Count];
        long[] vPrefix = new long[ver.Count];
        for (int i = 1; i < hor.Count; i++) hPrefix[i] = hPrefix[i - 1] + (hor[i] - hor[i - 1]);
        for (int i = 1; i < ver.Count; i++) vPrefix[i] = vPrefix[i - 1] + (ver[i] - ver[i - 1]);

        HashSet<long> hSet = new HashSet<long>();
        for (int i = 0; i < hor.Count; i++)
        {
            for (int j = i + 1; j < hor.Count; j++)
            {
                long sum = hPrefix[j] - hPrefix[i];
                hSet.Add(sum);
            }
        }

        long ans = -1;
        for (int i = 0; i < ver.Count; i++)
        {
            for (int j = i + 1; j < ver.Count; j++)
            {
                long sum = vPrefix[j] - vPrefix[i];
                if (hSet.Contains(sum)) ans = Math.Max(ans, sum * sum);
            }
        }
        return ans < 0 ? -1 : (int)(ans % MOD);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Square Area by Removing Fences From a Field");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}