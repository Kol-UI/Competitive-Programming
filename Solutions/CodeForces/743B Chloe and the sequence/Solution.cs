// Chloe and the sequence
namespace CompetitiveProgramming.CodeForces.Chloeandthesequence;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600

using System;

class Solution
{
    static void Main()
    {
        string input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input)) return;

        string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        long n = long.Parse(parts[0]);
        long k = long.Parse(parts[1]);

        const long B = 100;
        --k;
        long mod = 2;
        long rem = 0;
        long res = 1;

        while (res < B)
        {
            if (k % mod == rem)
            {
                Console.WriteLine(res);
                break;
            }
            mod *= 2;
            rem = 2 * rem + 1;
            ++res;
        }
    }
}

#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Chloe and the sequence");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}