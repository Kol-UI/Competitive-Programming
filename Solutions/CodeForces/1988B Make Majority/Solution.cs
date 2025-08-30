// Make Majority
namespace CompetitiveProgramming.CodeForces.MakeMajority;
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
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            long z = s[0] == '0' ? 1 : 0;
            long a = s[0] == '1' ? 1 : 0;
            for (int p = 1; p < n; p++)
            {
                if (s[p] == '1') a++;
                else if (s[p - 1] == '1') z++;
            }
            Console.WriteLine(a > z ? "YES" : "NO");
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
        StyleHelper.Title("Make Majority");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}