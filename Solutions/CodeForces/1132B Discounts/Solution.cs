// Discounts
namespace CompetitiveProgramming.CodeForces.Discounts;
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
        long total = numbers.Sum();
        
        int m = int.Parse(Console.ReadLine());
        long[] queries = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        
        Array.Sort(numbers);
        
        foreach (long q in queries)
        {
            long result = total - numbers[numbers.Length - (int)q];
            Console.WriteLine(result);
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Discounts");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}