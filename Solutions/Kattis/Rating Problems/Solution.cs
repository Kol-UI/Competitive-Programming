// Rating Problems
namespace CompetitiveProgramming.Kattis.RatingProblems;
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
        string[] firstLine = Console.ReadLine().Split();
        int n = int.Parse(firstLine[0]);
        int k = int.Parse(firstLine[1]);
        
        int s = 0;
        for (int i = 0; i < k; i++)
        {
            int x = int.Parse(Console.ReadLine());
            s += x;
        }
        
        double a1 = s + 3.0 * (n - k);
        double a2 = s - 3.0 * (n - k);
        
        Console.WriteLine($"{a2 / n:F10} {a1 / n:F10}");
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Rating Problems");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}