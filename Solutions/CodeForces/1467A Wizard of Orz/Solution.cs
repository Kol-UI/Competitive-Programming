// Wizard of Orz
namespace CompetitiveProgramming.CodeForces.WizardofOrz;
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
            if (n >= 1) Console.Write("9");
            if (n >= 2) Console.Write("8");
            for (long p = 0; p + 2 < n; p++) Console.Write((9 + p) % 10);
            Console.WriteLine();
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
        StyleHelper.Title("Wizard of Orz");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}