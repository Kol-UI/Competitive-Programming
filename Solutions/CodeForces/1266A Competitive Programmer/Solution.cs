// Competitive Programmer
namespace CompetitiveProgramming.CodeForces.CompetitiveProgrammer;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;

class Program
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        while (n-- > 0)
        {
            string s = Console.ReadLine();
            long v = 0, z = 0, t = 0;
            
            for (long p = 0; p < s.Length; p++)
            {
                long d = s[(int)p] - '0';
                t += d;
                if (d == 0 && z == 0)
                {
                    z = 1;
                }
                else if (d % 2 == 0)
                {
                    v = 1;
                }
            }
            
            bool ans = (z == 1 && v == 1 && t % 3 == 0) || s == "0";
            Console.WriteLine(ans ? "red" : "cyan");
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Competitive Programmer");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}