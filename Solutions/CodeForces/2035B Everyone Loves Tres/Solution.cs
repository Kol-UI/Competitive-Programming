// Everyone Loves Tres
namespace CompetitiveProgramming.CodeForces.EveryoneLovesTres;
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
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            string res;
            if (n == 1 || n == 3) res = "-1";
            else if (n % 2 != 0) res = new string('3', (int)(n - 5)) + "36366";
            else res = new string('3', (int)(n - 2)) + "66";
            Console.WriteLine(res);
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
        StyleHelper.Title("Everyone Loves Tres");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}