// Shooting
namespace CompetitiveProgramming.CodeForces.Shooting;
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
        long n = long.Parse(Console.ReadLine());
        var a = Console.ReadLine().Split().Select((x, i) => new { Value = long.Parse(x), Index = i + 1 }).ToArray();
        a = a.OrderByDescending(x => x.Value).ToArray();
        long total = n;
        for (long p = 1; p < n; p++) total += p * a[p].Value;
        Console.WriteLine(total);
        foreach (var item in a) Console.Write(item.Index + " ");
        Console.WriteLine();
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Shooting");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}