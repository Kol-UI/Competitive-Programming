// Duff and Meat
namespace CompetitiveProgramming.CodeForces.DuffandMeat;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int n = int.Parse(Console.ReadLine()!);
        List<Tuple<long, long>> v = new List<Tuple<long, long>>();
        
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine()!.Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            v.Add(new Tuple<long, long>(a, b));
        }

        long mn = long.MaxValue;
        long ans = 0;
        foreach (var i in v)
        {
            if (i.Item2 < mn)
                mn = i.Item2;
            ans += i.Item1 * mn;
        }
        Console.WriteLine(ans);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Duff and Meat");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}