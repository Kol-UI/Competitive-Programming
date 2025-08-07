// String LCM
namespace CompetitiveProgramming.CodeForces.StringLCM;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static long Gcd(long a, long b) => b == 0 ? a : Gcd(b, a % b);

    //static void Main()
    public static void MainSolution()
    {
        int q = int.Parse(Console.ReadLine());
        while (q-- > 0)
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            long u = s.Length, v = t.Length;
            long lcm = u * v / Gcd(u, v);
            
            string x = "";
            for (long p = 0; p < lcm / u; p++) x += s;
            
            string y = "";
            for (long p = 0; p < lcm / v; p++) y += t;
            
            Console.WriteLine(x == y ? x : "-1");
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
        StyleHelper.Title("String LCM");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}