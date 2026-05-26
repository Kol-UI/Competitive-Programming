// Falling Apart
namespace CompetitiveProgramming.Kattis.FallingApart;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] v = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
        Array.Sort(v);
        Array.Reverse(v);
        
        int a = 0;
        int b = 0;
        
        for (int i = 0; i < v.Length; i++)
        {
            if (i % 2 == 0)
                a += v[i];
            else
                b += v[i];
        }
        
        Console.WriteLine($"{a} {b}");
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Falling Apart");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}