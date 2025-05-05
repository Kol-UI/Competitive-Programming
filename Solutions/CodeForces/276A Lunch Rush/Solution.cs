// Lunch Rush
namespace CompetitiveProgramming.CodeForces.LunchRush;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        string[] input = Console.ReadLine()!.Split();
        long n = long.Parse(input[0]);
        long k = long.Parse(input[1]);
        List<long> list = new List<long>();

        while (n-- > 0)
        {
            input = Console.ReadLine()!.Split();
            long f = long.Parse(input[0]);
            long t = long.Parse(input[1]);
            list.Insert(0, k - t < 0 ? f - (t - k) : f);
        }

        Console.WriteLine(list.Max());
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Lunch Rush");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}