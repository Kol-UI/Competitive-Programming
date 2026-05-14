// Perfect Team
namespace CompetitiveProgramming.CodeForces.PerfectTeam;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        long q = long.Parse(Console.ReadLine());
        while (q-- > 0)
        {
            string[] input = Console.ReadLine().Split();
            long x = long.Parse(input[0]);
            long y = long.Parse(input[1]);
            long z = long.Parse(input[2]);
            
            long a = (x < y) ? x : y;
            long t = (x + y + z) / 3;
            a = (a < t) ? a : t;
            
            Console.WriteLine(a);
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
        StyleHelper.Title("Perfect Team");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}