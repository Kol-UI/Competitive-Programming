// Arya and Bran
namespace CompetitiveProgramming.CodeForces.AryaandBran;
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
        long[] input = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        long n = input[0];
        long k = input[1];
        
        long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        long collected = 0;
        long total = 0;
        long day = -1;
        
        for (int i = 0; i < n; i++)
        {
            long current = numbers[i];
            long extra = total > collected ? total - collected : 0;
            long today = current + extra;
            if (today > 8) today = 8;
            
            total += current;
            collected += today;
            if (collected >= k)
            {
                day = i + 1;
                break;
            }
        }
        
        Console.WriteLine(day);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Arya and Bran");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}