// Lunar New Year and Number Division
namespace CompetitiveProgramming.CodeForces.LunarNewYearandNumberDivision;
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
        int n = int.Parse(Console.ReadLine());
        long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        
        Array.Sort(numbers);
        
        long total = 0;
        for (int i = 0; i < n / 2; i++)
        {
            long sum = numbers[i] + numbers[n - 1 - i];
            total += sum * sum;
        }
        
        Console.WriteLine(total);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Lunar New Year and Number Division");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}