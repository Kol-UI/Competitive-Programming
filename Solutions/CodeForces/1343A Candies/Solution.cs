// Candies
namespace CompetitiveProgramming.CodeForces.Candies;
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
            int n = int.Parse(Console.ReadLine()!);
            int x = 1;
            int s = 1;
            for (int i = 0; i < n; i++)
            {
                if (n % s == 0 && i > 0)
                {
                    Console.WriteLine(n / s);
                    break;
                }
                else
                {
                    x *= 2;
                    s += x;
                }
            }
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Candies");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}