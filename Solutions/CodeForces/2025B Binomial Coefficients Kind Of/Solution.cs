// Binomial Coefficients, Kind Of
namespace CompetitiveProgramming.CodeForces.BinomialCoefficientsKindOf;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

public class Solution
{
    static public void Main()
    {
        const long MOD = 1000000007L;
        int t = int.Parse(Console.ReadLine());
        
        long[] powers = new long[100007];
        powers[0] = 1;
        for(int p = 1; p < powers.Length; p++)
        {
            powers[p] = (2 * powers[p - 1]) % MOD;
        }
        
        long[] wn = Console.ReadLine().Split().Select(long.Parse).ToArray();
        long[] wk = Console.ReadLine().Split().Select(long.Parse).ToArray();
        
        for(int p = 0; p < t; p++)
        {
            long result = wk[p] < wn[p] ? powers[wk[p]] : 1;
            Console.WriteLine(result);
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Binomial Coefficients, Kind Of");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}