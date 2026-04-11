// Pot
namespace CompetitiveProgramming.Kattis.Pot;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;

class Solution
{
    static void Main()
    {
        int times = int.Parse(Console.ReadLine());
        long total = 0;
        
        for (int i = 0; i < times; i++)
        {
            long temp = long.Parse(Console.ReadLine());
            long num = temp / 10;
            long exp = temp % 10;
            long result = (long)Math.Pow(num, exp);
            total += result;
        }
        
        Console.WriteLine(total);
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Pot");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}