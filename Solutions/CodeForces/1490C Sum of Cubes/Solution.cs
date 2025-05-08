// Sum of Cubes
namespace CompetitiveProgramming.CodeForces.SumofCubes;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine()!);
            bool ok = false;
            for (long i = 1; i * i * i < n; i++)
            {
                double b = Math.Cbrt(n - i * i * i);
                if (Math.Abs(b - Math.Round(b)) < 1e-9)
                {
                    Console.WriteLine("YES");
                    ok = true;
                    break;
                }
            }
            if (!ok) Console.WriteLine("NO");
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Sum of Cubes");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}