// Greed
namespace CompetitiveProgramming.CodeForces.Greed;
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
        long[] capacities = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        
        long total = numbers.Sum();
        long max1 = 0;
        long max2 = 0;
        
        foreach (long capacity in capacities)
        {
            if (capacity >= max1)
            {
                max2 = max1;
                max1 = capacity;
            }
            else if (capacity > max2)
            {
                max2 = capacity;
            }
        }
        
        Console.WriteLine(total <= max1 + max2 ? "YES" : "NO");
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Greed");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}