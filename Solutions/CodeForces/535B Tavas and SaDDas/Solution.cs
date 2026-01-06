// Tavas and SaDDas
namespace CompetitiveProgramming.CodeForces.TavasandSaDDas;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long temp = n;
        
        long first = 1;
        List<int> digits = new List<int>();
        while (temp > 0)
        {
            first *= 2;
            digits.Add((int)(temp % 10));
            temp /= 10;
        }
        
        long second = 0;
        for (int i = digits.Count - 1; i >= 0; i--)
        {
            second = 2 * second + (digits[i] == 7 ? 1 : 0);
        }
        
        long result = first + second - 1;
        Console.WriteLine(result);
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Tavas and SaDDas");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}