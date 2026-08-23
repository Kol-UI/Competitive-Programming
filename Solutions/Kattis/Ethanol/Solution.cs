// Ethanol
namespace CompetitiveProgramming.Kattis.Ethanol;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[] hs = Enumerable.Repeat("H", n).ToArray();
        string[] bs = Enumerable.Repeat("|", n).ToArray();
        string[] cs = Enumerable.Repeat("C", n).ToArray();

        Console.WriteLine($"  {string.Join(" ", hs)}");
        Console.WriteLine($"  {string.Join(" ", bs)}");
        Console.WriteLine($"H-{string.Join("-", cs)}-OH");
        Console.WriteLine($"  {string.Join(" ", bs)}");
        Console.WriteLine($"  {string.Join(" ", hs)}");
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Ethanol");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}