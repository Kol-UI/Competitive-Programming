// Chugging
namespace CompetitiveProgramming.Kattis.Chugging;
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

        string[] firstLine = Console.ReadLine().Split();
        int ta = int.Parse(firstLine[0]);
        int da = int.Parse(firstLine[1]);

        string[] secondLine = Console.ReadLine().Split();
        int tb = int.Parse(secondLine[0]);
        int db = int.Parse(secondLine[1]);

        long sa = (long)n * ta + (long)da * n * (n - 1) / 2;
        long sb = (long)n * tb + (long)db * n * (n - 1) / 2;

        if (sa == sb)
            Console.WriteLine("=");
        else if (sa > sb)
            Console.WriteLine("Bob");
        else
            Console.WriteLine("Alice");
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Chugging");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}