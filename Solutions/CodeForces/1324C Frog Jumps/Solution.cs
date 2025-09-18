// Frog Jumps
namespace CompetitiveProgramming.CodeForces.FrogJumps;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string s = Console.ReadLine() + "R";
            int mx = 0, last = -1;
            for (int p = 0; p < s.Length; p++)
            {
                if (s[p] == 'L') continue;
                int diff = p - last;
                last = p;
                mx = Math.Max(mx, diff);
            }
            Console.WriteLine(mx);
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Frog Jumps");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}