// Jzzhu and Sequences
namespace CompetitiveProgramming.CodeForces.JzzhuandSequences;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Solution
{
    static void Main()
    {
        string[] first = Console.ReadLine().Split();
        long x = long.Parse(first[0]);
        long y = long.Parse(first[1]);
        long n = long.Parse(Console.ReadLine());

        long output = 0;

        if (n % 6 == 0) output = x - y;
        else if (n % 6 == 1) output = x;
        else if (n % 6 == 2) output = y;
        else if (n % 6 == 3) output = y - x;
        else if (n % 6 == 4) output = -x;
        else if (n % 6 == 5) output = -y;

        const long M = 1000000007;
        if (output < 0) output += 2 * M;
        Console.WriteLine(output % M);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Jzzhu and Sequences");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}