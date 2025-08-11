// Range Product Queries of Powers
namespace CompetitiveProgramming.LeetCode.RangeProductQueriesofPowers;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] ProductQueries(int n, int[][] queries)
    {
        var mod = 1000000007;
        var powers = new List<long>();
        while (n > 0)
        {
            var lowBit = n & -n;
            powers.Add(lowBit);
            n ^= lowBit;
        }

        var result = new int[queries.Length];

        for (var i = 0; i < queries.Length; i++)
        {
            var tmp = queries[i];
            var product = 1L;

            for (var j = tmp[0]; j <= tmp[1]; j++)
            {
                product = (product * powers[j]) % mod;
            }

            result[i] = (int)product;
        }

        return result;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Range Product Queries of Powers");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}