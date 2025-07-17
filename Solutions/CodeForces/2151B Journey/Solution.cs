// Journey
namespace CompetitiveProgramming.CodeForces.Journey;
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
            long[] values = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long n = values[0], a = values[1], b = values[2], c = values[3];
            long s = a + b + c;
            long result = 3 * (n / s);
            n %= s;

            if (n > 0 && n <= a) result++;
            else if (n > a && n <= a + b) result += 2;
            else if (n > a + b) result += 3;

            Console.WriteLine(result);
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
        StyleHelper.Title("Journey");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}