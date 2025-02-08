// Maximum Difference Between Even and Odd Frequency I

namespace CompetitiveProgramming.LeetCode.MaximumDifferenceBetweenEvenandOddFrequencyI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Linq;

public class Solution
{
    public int MaxDifference(string s)
    {
        var freq = s.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());

        int maxOdd = int.MinValue, minEven = int.MaxValue;

        foreach (var count in freq.Values)
        {
            if (count % 2 == 0) minEven = Math.Min(minEven, count);
            else maxOdd = Math.Max(maxOdd, count);
        }

        return maxOdd == int.MinValue || minEven == int.MaxValue ? 0 : maxOdd - minEven;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Difference Between Even and Odd Frequency I");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}