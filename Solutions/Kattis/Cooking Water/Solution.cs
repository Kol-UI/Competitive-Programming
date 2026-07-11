// Cooking Water
namespace CompetitiveProgramming.Kattis.CookingWater;
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
        int n = int.Parse(Console.ReadLine());
        
        int hi = 1000000010;
        int lo = 0;
        
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            int l = int.Parse(input[0]);
            int r = int.Parse(input[1]);
            
            if (r < hi) hi = r;
            if (l > lo) lo = l;
        }
        
        if (lo > hi)
            Console.WriteLine("edward is right");
        else
            Console.WriteLine("gunilla has a point");
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Cooking Water");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}