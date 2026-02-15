// Removing Minimum Number of Magic Beans
namespace CompetitiveProgramming.LeetCode.RemovingMinimumNumberofMagicBeans;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long MinimumRemoval(int[] beans)
    {
        Dictionary<int, int> freq = new();
        long sum = 0;
        foreach(int b in beans)
        {
            freq.TryAdd(b, 0);
            freq[b]++;
            sum += b;
        }

        if(freq.Count == 1)
            return 0;

        List<int> keys = freq.Keys.ToList();
        keys.Sort();
        long minSteps = sum, preDel = 0, restCnt = beans.Length;
        for(int i = 0; i < keys.Count; i++)
        {
            int keepV = keys[i], f = freq[keepV];
            long curTotal = preDel + sum - keepV*restCnt;
            minSteps = Math.Min(minSteps, curTotal);
            preDel += keepV*f;
            restCnt -= f;
            sum -= keepV*f;
        }

        return minSteps;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Removing Minimum Number of Magic Beans");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}