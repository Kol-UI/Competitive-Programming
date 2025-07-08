// I Hate 1111
namespace CompetitiveProgramming.CodeForces.IHate1111;
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
            int n = int.Parse(Console.ReadLine());
            bool ok = false;
            while (n > 0)
            {
                if (n % 11 == 0 || n % 111 == 0)
                {
                    ok = true;
                    break;
                }
                else
                {
                    n -= 111;
                }
            }
            Console.WriteLine(ok ? "YES" : "NO");
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
        StyleHelper.Title("I Hate 1111");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1400);
    }
}