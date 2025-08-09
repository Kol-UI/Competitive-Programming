// Bad Ugly Numbers
namespace CompetitiveProgramming.CodeForces.BadUglyNumbers;
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
            if (n <= 1)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.Write("2");
                for (int p = 1; p < n; p++)
                {
                    Console.Write("3");
                }
                Console.WriteLine();
            }
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
        StyleHelper.Title("Bad Ugly Numbers");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}