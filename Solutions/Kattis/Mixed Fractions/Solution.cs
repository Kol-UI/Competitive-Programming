// Mixed Fractions
namespace CompetitiveProgramming.Kattis.MixedFractions;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600

using System;

class Solution
{
    static void Main()
    {
        string line;
        while ((line = Console.ReadLine()) != null)
        {
            string[] input = line.Split();
            long num = long.Parse(input[0]);
            long div = long.Parse(input[1]);
            
            if (num == 0 && div == 0)
            {
                return;
            }
            
            Console.WriteLine($"{num / div} {num % div} / {div}");
        }
    }
}

#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Mixed Fractions");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}