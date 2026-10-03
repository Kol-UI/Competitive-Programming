// Doors Breaking and Repairing
namespace CompetitiveProgramming.CodeForces.DoorsBreakingandRepairing;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;

class Solution
{
    static void Main()
    {
        string[] first = Console.ReadLine().Split();
        long n = long.Parse(first[0]);
        long x = long.Parse(first[1]);
        long y = long.Parse(first[2]);

        long cnt = 0;
        string[] vals = Console.ReadLine().Split();
        for (long p = 0; p < n; p++)
        {
            long a = long.Parse(vals[p]);
            if (a <= x) cnt++;
        }

        Console.WriteLine(x <= y ? (cnt + 1) / 2 : n);
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Doors Breaking and Repairing");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}