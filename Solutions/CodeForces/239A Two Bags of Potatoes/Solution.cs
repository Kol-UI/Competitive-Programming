// Two Bags of Potatoes
namespace CompetitiveProgramming.CodeForces.TwoBagsofPotatoes;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        long y = long.Parse(input[0]);
        long k = long.Parse(input[1]);
        long n = long.Parse(input[2]);
        
        long a = y % k;
        a = (k - a) % k;
        if (a == 0) a = k;
        
        if (y + a > n)
        {
            Console.WriteLine("-1");
        }
        else
        {
            while (y + a <= n)
            {
                Console.Write($"{a} ");
                a += k;
            }
        }
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Two Bags of Potatoes");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}