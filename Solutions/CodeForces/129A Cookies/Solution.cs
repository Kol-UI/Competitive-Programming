// Cookies
namespace CompetitiveProgramming.CodeForces.Cookies;
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
        int[] count = new int[n];
        int sum = 0, output = 0;
        string[] input = Console.ReadLine().Split();
        for (int k = 0; k < n; k++)
        {
            count[k] = int.Parse(input[k]);
            sum += count[k];
        }
        int sumMod = sum % 2;
        for (int k = 0; k < n; k++)
        {
            if (count[k] % 2 == sumMod) output++;
        }
        Console.WriteLine(output);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Cookies");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}
